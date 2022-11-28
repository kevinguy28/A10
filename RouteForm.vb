Imports Microsoft.VisualBasic.ApplicationServices
Public Class RouteForm
    Inherits AppForm

    Dim startTime As Date

    Dim minTime As Date

    Dim changedStartTime = False

    Dim startMinute As Integer
    Dim startHour As Integer
    Dim startDay As Integer
    Dim startMonth As Integer
    Dim startYear As Integer

    ' MouseHold
    Dim mouseHoldSec = 0
    Dim mouseHoldImg As PictureBox

    Dim bookingEvent As UserCalendarEvent
    Dim previousBooking As UserCalendarEvent

    ' Children
    Dim confirmForm As CalendarConfirmForm
    Dim requestForm As BookingRequestForm
    Dim responseForm As BookingRequestResponseForm
    Dim changeForm As CarRouteChangeForm
    Dim recallForm As CarRecallForm

    Public Sub New(user As String, scenario As Integer, previousWindow As AppForm, homeWindow As HomeForm, devWindow As DevForm, startDate As Date, bookingEvent As UserCalendarEvent, Optional previousBooking As UserCalendarEvent = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousWindow
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow

        ' Time
        Me.startTime = startDate

        Me.startMinute = 0
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year

        Me.startHour = Me.startTime.Hour
        Me.startDay = Me.startTime.Day

        Me.minTime = Me.startTime

        Me.bookingEvent = bookingEvent
        Me.previousBooking = previousBooking

    End Sub

    Private Sub RouteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Route"
            Case "rider"
                Me.Text = "Car Rider Route"
        End Select

        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Route")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)

        ' Book Button
        If Me.user = "owner" Then
            Me.btnBook.Text = "Recall Car"
        End If

        ' If no current booking
        If Me.bookingEvent Is Nothing Then
            ' Disable
            Me.DisableForm()
            ' Error
            Me.ShowError()
            ' Don't show car
            Me.ChangeMap(My.Resources.the_map)
            Exit Sub
        End If

        Me.cmbxStart.Text = Me.bookingEvent.GetStartLocation
        Me.cmbxEnd.Text = Me.bookingEvent.GetEndLocation

        'Rider
        If Me.user = "rider" Then
            If Me.bookingEvent.GetStartLocation <> "" Then
                Me.btnBook.Text = "Change"
            Else
                Me.CreateBackButton()
                Me.Controls.Add(Me.btnBack)
            End If
            Exit Sub
        End If

        ' Owner with booking
        If bookingEvent.GetCarOwnerName = "Jane Doe" Then
            ' Disable
            Me.DisableForm()

            ' Owner without booking
        Else
            ' Disable
            Me.DisableForm()
            ' Don't show car
            Me.ChangeMap(My.Resources.the_map)
        End If

        ' Recall Car
        Me.btnBook.Enabled = True

    End Sub

    Private Sub UpdateStartTimeVar()
        Me.startMinute = Me.startTime.Minute
        Me.startHour = Me.startTime.Hour
        Me.startDay = Me.startTime.Day
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Sub DisableForm()
        Me.cmbxStart.Enabled = False
        Me.cmbxEnd.Enabled = False
    End Sub

    Public Sub ShowError()
        ' lblError
        Select Case Me.user
            Case "owner"
                Me.lblError.Text = "You need to accept a booking request"
                Me.lblError.Visible = True
                Me.lblError.BringToFront()
            Case "rider"
                Me.lblError.Text = "You need to add a booking"
                Me.lblError.Visible = True
                Me.lblError.BringToFront()
        End Select
    End Sub

    Public Sub ChangeMap(newMap As Bitmap)
        Me.pbRoute.BackgroundImage = newMap
    End Sub

    Public Sub ConfirmClicked()
        ' Remove previous booking if there
        If Me.previousBooking IsNot Nothing Then
            Me.devWindow.RemoveBooking(Me.previousBooking)
        End If

        Me.Close()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)

        ' Send request to Owner
        If Me.bookingEvent.GetCarOwnerName = "Jane Doe" Then
            Me.requestForm = New BookingRequestForm("owner", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
            Me.devWindow.OpenPopup("owner", Me.requestForm)
        Else
            Me.responseForm = New BookingRequestResponseForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, "accept")
            Me.devWindow.OpenPopup(Me.user, Me.responseForm)
            'Add booking
            Me.devWindow.AddBooking(Me.bookingEvent)
        End If

        Me.homeWindow.CloseAllChildren()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If

        If (Me.requestForm IsNot Nothing) Then
            Me.requestForm.Dispose()
        End If

        If (Me.responseForm IsNot Nothing) Then
            Me.responseForm.Dispose()
        End If

        If (Me.changeForm IsNot Nothing) Then
            Me.changeForm.Dispose()
        End If

        If (Me.recallForm IsNot Nothing) Then
            Me.recallForm.Dispose()
        End If
    End Sub

    ' --------------
    ' --- Button ---
    ' --------------
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Select Case Me.user
            Case "owner"
                Me.recallForm = New CarRecallForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                Me.devWindow.OpenPopup(Me.user, Me.recallForm)
            Case "rider"
                ' Add Booking
                If Me.bookingEvent.GetStartLocation = "" Then
                    Me.bookingEvent.SetLocations(Me.cmbxStart.Text, Me.cmbxEnd.Text)
                    Dim eta = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text)
                    Me.bookingEvent.SetEndDate(Me.bookingEvent.GetStartDate.AddMinutes(eta))

                    Me.confirmForm = New CalendarConfirmForm(Me.bookingEvent, Me.user, Me.devWindow)
                    Me.confirmForm.SetBookingForm(Me)

                    Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
                    Exit Sub
                End If
                ' Change Route
                Me.changeForm = New CarRouteChangeForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                Me.devWindow.OpenPopup(Me.user, Me.changeForm)
        End Select
    End Sub

    ' -----------------
    ' --- Locations ---
    ' -----------------

    Private Sub cmbx_TextChanged(sender As Object, e As EventArgs) Handles cmbxStart.TextChanged, cmbxEnd.TextChanged
        If Me.cmbxStart.Text <> "" And Me.cmbxEnd.Text <> "" Then
            Me.btnBook.Enabled = True
            Me.txtEta.Text = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text) & " minutes"
            Me.txtPrice.Text = "$" & Me.devWindow.GetCost(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        End If
    End Sub

End Class