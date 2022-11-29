Imports Microsoft.VisualBasic.ApplicationServices
Public Class RouteForm
    Inherits AppForm

    Dim startTime As Date

    Dim bookingEvent As UserCalendarEvent
    Dim previousBooking As UserCalendarEvent

    ' Children
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

        ' Booking
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
            Me.btnStart.Text = "Recall Car"
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
        Me.btnStart.Enabled = True

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

    Public Sub CancelClicked()

    End Sub

    Public Overrides Sub CloseAllChildren()
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
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Select Case Me.user
            Case "owner"
                ' Recall Car
                Me.recallForm = New CarRecallForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                Me.devWindow.OpenPopup(Me.user, Me.recallForm)
            Case "rider"
                ' Change Route
                If Me.btnStart.Text = "Change" Then
                    Me.changeForm = New CarRouteChangeForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                    Me.devWindow.OpenPopup(Me.user, Me.changeForm)
                End If
        End Select
    End Sub

    ' -----------------
    ' --- Locations ---
    ' -----------------

    Private Sub cmbx_TextChanged(sender As Object, e As EventArgs) Handles cmbxStart.TextChanged, cmbxEnd.TextChanged
        If Me.cmbxStart.Text <> "" And Me.cmbxEnd.Text <> "" Then
            Me.btnStart.Enabled = True
            Me.txtEta.Text = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text) & " minutes"
            Me.txtPrice.Text = "$" & Me.devWindow.GetCost(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        End If

        If (Me.user = "rider") AndAlso (Me.cmbxStart.Text <> Me.bookingEvent.GetStartLocation) AndAlso (Me.cmbxEnd.Text <> Me.bookingEvent.GetEndLocation) Then
            Me.btnStart.Text = "Change"
        Else
            Me.btnStart.Text = "Start"
        End If
    End Sub

End Class