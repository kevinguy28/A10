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
    Dim confirmForm As CarRouteChangeForm
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

        Me.UpdateLabels()

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

    Private Sub UpdateLabels()
        Me.lblHourStart.Text = Format(Me.startTime, "hh")
        Me.lblMinuteStart.Text = Format(Me.startTime, "mm")
        Me.lblAmPmStart.Text = Format(Me.startTime, "tt").ToLower
    End Sub

    Public Sub DisableForm()
        ' Disable Combo Box
        Me.cmbxStart.Enabled = False
        Me.cmbxEnd.Enabled = False

        ' Disable Up
        Me.imgStartHourUp.Enabled = False
        Me.imgStartHourDown.Enabled = False
        Me.imgStartMinuteUp.Enabled = False
        Me.imgStartMinuteDown.Enabled = False
        Me.imgStartAmPmUp.Enabled = False
        Me.imgStartAmPmDown.Enabled = False

        ' Grey Out Time
        Dim disableColour = Color.Gray
        Me.lblHourStart.ForeColor = disableColour
        Me.lblMinuteStart.ForeColor = disableColour
        Me.lblStartColon.ForeColor = disableColour
        Me.lblAmPmStart.ForeColor = disableColour
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

    ' --------------
    ' --- Button ---
    ' --------------

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Select Case Me.user
            Case "owner"
                Me.recallForm = New CarRecallForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                Me.devWindow.OpenPopup(Me.user, Me.recallForm)
            Case "rider"
                Me.confirmForm = New CarRouteChangeForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
                Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
        End Select
    End Sub

    ' -------------------
    ' --- Time Change ---
    ' -------------------

    Private Sub UpdateMinute(minuteChange As Integer)
        Dim hourChng = 0

        Dim newMinute = Me.startMinute + minuteChange
        If newMinute <= -1 Then
            ' Minus hour
            newMinute = newMinute + 60
            hourChng = -1
        ElseIf newMinute >= 60 Then
            ' Plus Hour
            newMinute = newMinute - 60
            hourChng = 1
        End If

        Me.startMinute = newMinute
        Me.startTime = New Date(Me.startYear, Me.startMonth, Me.startDay, Me.startHour, Me.startMinute, 0)
        changedStartTime = True

        If hourChng <> 0 Then
            Me.UpdateHour(hourChng)
        End If

        Me.UpdateLabels()
    End Sub
    Private Sub UpdateHour(hourChange As Integer)
        Dim newHour = Me.startHour + hourChange
        If newHour <= -1 Then
            ' Jump Forward
            newHour = 23
        ElseIf newHour >= 24 Then
            ' Jump Back
            newHour = 0
        End If

        Me.startHour = newHour
        Me.startTime = New Date(Me.startYear, Me.startMonth, Me.startDay, Me.startHour, Me.startMinute, 0)
        changedStartTime = True

        Me.UpdateLabels()
    End Sub

    ' ------------------------
    ' --- Time Arrow Click ---
    ' ------------------------

    Private Sub imgTime_Click(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.Click, imgStartMinuteUp.Click, imgStartHourDown.Click,
        imgStartMinuteDown.Click, imgStartAmPmUp.Click, imgStartAmPmDown.Click

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Then
            Me.UpdateHour(1)

        ElseIf (imgCur Is imgStartMinuteUp) Then
            Me.UpdateMinute(1)

        ElseIf (imgCur Is imgStartHourDown) Then
            Me.UpdateHour(-1)

        ElseIf (imgCur Is imgStartMinuteDown) Then
            Me.UpdateMinute(-1)

        ElseIf (imgCur Is imgStartAmPmUp) Then
            If Me.startHour >= 12 Then
                Me.UpdateHour(-12)
            Else
                Me.UpdateHour(12)
            End If

        ElseIf (imgCur Is imgStartAmPmDown) Then
            If Me.startHour >= 12 Then
                Me.UpdateHour(-12)
            Else
                Me.UpdateHour(12)
            End If

        End If
    End Sub

    ' -----------------------
    ' --- Time Arrow Hold ---
    ' -----------------------

    Private Sub imgTime_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        imgStartHourUp.MouseDown, imgStartMinuteUp.MouseDown, imgStartHourDown.MouseDown, imgStartMinuteDown.MouseDown

        Me.mouseHoldSec = 0
        Me.mouseHoldImg = CType(sender, PictureBox)
        Me.tmrMouseHold.Start()
    End Sub

    Private Sub imgTime_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        imgStartHourUp.MouseUp, imgStartMinuteUp.MouseUp, imgStartHourDown.MouseUp, imgStartMinuteDown.MouseUp

        Me.mouseHoldSec = 0
        Me.mouseHoldImg = Nothing
        Me.tmrMouseHold.Stop()
    End Sub

    Private Sub tmrMouseHold_Tick(sender As Object, e As EventArgs) Handles tmrMouseHold.Tick
        If Me.mouseHoldSec = 30 Then
            Me.mouseHoldSec = 0

            Dim imgCur = Me.mouseHoldImg, PictureBox
            Dim hourChng = 6
            Dim minChng = 10

            If (imgCur Is imgStartHourUp) Then
                Me.UpdateHour(hourChng)

            ElseIf (imgCur Is imgStartMinuteUp) Then
                Me.UpdateMinute(minChng)

            ElseIf (imgCur Is imgStartHourDown) Then
                Me.UpdateHour(-hourChng)

            ElseIf (imgCur Is imgStartMinuteDown) Then
                Me.UpdateMinute(-minChng)

            End If

        Else
            Me.mouseHoldSec += 1
        End If
    End Sub

    ' ------------------------
    ' --- Time Arrow Hover ---
    ' ------------------------

    Private Sub btnTime_MouseEnter(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.MouseEnter, imgStartMinuteUp.MouseEnter, imgStartHourDown.MouseEnter,
        imgStartMinuteDown.MouseEnter, imgStartAmPmUp.MouseEnter, imgStartAmPmDown.MouseEnter

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Or (imgCur Is imgStartMinuteUp) Or (imgCur Is imgStartAmPmUp) Then
            imgCur.Image = My.Resources.arrow_up_hover

        ElseIf (imgCur Is imgStartHourDown) Or (imgCur Is imgStartMinuteDown) Or (imgCur Is imgStartAmPmDown) Then
            imgCur.Image = My.Resources.arrow_down_hover
        End If
    End Sub

    Private Sub btnStartHourUp_MouseLeave(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.MouseLeave, imgStartMinuteUp.MouseLeave, imgStartHourDown.MouseLeave,
        imgStartMinuteDown.MouseLeave, imgStartAmPmUp.MouseLeave, imgStartAmPmDown.MouseLeave

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Or (imgCur Is imgStartMinuteUp) Or (imgCur Is imgStartAmPmUp) Then
            imgCur.Image = My.Resources.arrow_up_neutral

        ElseIf (imgCur Is imgStartHourDown) Or (imgCur Is imgStartMinuteDown) Or (imgCur Is imgStartAmPmDown) Then
            imgCur.Image = My.Resources.arrow_down_neutral

        End If
    End Sub

    Private Sub cmbx_TextChanged(sender As Object, e As EventArgs) Handles cmbxStart.TextChanged, cmbxEnd.TextChanged
        If Me.cmbxStart.Text <> "" And Me.cmbxEnd.Text <> "" Then
            Me.btnBook.Enabled = True
            Me.txtEta.Text = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text) & " minutes"
            Me.txtPrice.Text = "$" & Me.devWindow.GetCost(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        End If
    End Sub
End Class