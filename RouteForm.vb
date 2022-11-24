Imports Microsoft.VisualBasic.ApplicationServices
Public Class RouteForm
    Inherits AppForm

    Dim startTime As Date
    Dim endTime As Date

    Dim minTime As Date
    Dim maxTime As Date

    Dim changedStartTime = False
    Dim changedEndTime = False

    Dim startMinute As Integer
    Dim startHour As Integer
    Dim startDay As Integer
    Dim startMonth As Integer
    Dim startYear As Integer

    Dim endMinute As Integer
    Dim endHour As Integer
    Dim endDay As Integer
    Dim endMonth As Integer
    Dim endYear As Integer

    ' MouseHold
    Dim mouseHoldSec = 0
    Dim mouseHoldImg As PictureBox

    Dim bookingEvent As UserCalendarEvent

    ' Children
    Dim confirmForm As CarRouteChangeForm
    Dim recallForm As CarRecallForm

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm, startDate As Date, endDate As Date, bookingEvent As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm

        ' Time
        Me.startTime = startDate
        Me.endTime = endDate

        Me.startMinute = 0
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year

        Me.endMinute = 0
        Me.endMonth = Me.startTime.Month
        Me.endYear = Me.startTime.Year

        Me.startHour = Me.startTime.Hour
        Me.startDay = Me.startTime.Day
        Me.endHour = Me.endTime.Hour
        Me.endDay = Me.endTime.Day

        Me.minTime = Me.startTime
        Me.maxTime = Me.endTime

        Me.bookingEvent = bookingEvent

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

        Me.UpdateLabels()
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

    Private Sub UpdateEndTimeVar()
        If changedEndTime = False Then
            Me.endTime = startTime.AddHours(1)
        End If
        Me.endMinute = Me.endTime.Minute
        Me.endHour = Me.endTime.Hour
        Me.endDay = Me.endTime.Day
        Me.endMonth = Me.endTime.Month
        Me.endYear = Me.endTime.Year
    End Sub

    Private Sub UpdateLabels()
        Me.lblHourStart.Text = Format(Me.startTime, "hh")
        Me.lblMinuteStart.Text = Format(Me.startTime, "mm")
        Me.lblAmPmStart.Text = Format(Me.startTime, "tt").ToLower

        Me.lblHourEnd.Text = Format(Me.endTime, "hh")
        Me.lblMinuteEnd.Text = Format(Me.endTime, "mm")
        Me.lblAmPmEnd.Text = Format(Me.endTime, "tt").ToLower
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

        ' Disable Down
        Me.imgEndHourUp.Enabled = False
        Me.imgEndHourDown.Enabled = False
        Me.imgEndMinuteUp.Enabled = False
        Me.imgEndMinuteDown.Enabled = False
        Me.imgEndAmPmUp.Enabled = False
        Me.imgEndAmPmDown.Enabled = False

        ' Grey Out Time
        Dim disableColour = Color.Gray
        Me.lblHourStart.ForeColor = disableColour
        Me.lblMinuteStart.ForeColor = disableColour
        Me.lblStartColon.ForeColor = disableColour
        Me.lblAmPmStart.ForeColor = disableColour
        Me.lblHourEnd.ForeColor = disableColour
        Me.lblMinuteEnd.ForeColor = disableColour
        Me.lblEndColon.ForeColor = disableColour
        Me.lblAmPmEnd.ForeColor = disableColour
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
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

    Private Sub UpdateMinute(minuteChange As Integer, time As String)
        Dim hourChng = 0

        If time = "start" Then
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
            Me.UpdateEndTimeVar()
            changedStartTime = True
        ElseIf time = "end" Then
            Dim newMinute = Me.endMinute + minuteChange
            If newMinute <= -1 Then
                ' Minus hour
                newMinute = newMinute + 60
                hourChng = -1
            ElseIf newMinute >= 60 Then
                ' Plus Hour
                newMinute = newMinute - 60
                hourChng = 1
            End If

            Me.endMinute = newMinute
            Me.endTime = New Date(Me.endYear, Me.endMonth, Me.endDay, Me.endHour, Me.endMinute, 0)
            changedEndTime = True
        End If

        If hourChng <> 0 Then
            Me.UpdateHour(hourChng, time)
        End If

        Me.UpdateLabels()
    End Sub
    Private Sub UpdateHour(hourChange As Integer, time As String)
        If time = "start" Then
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
            Me.UpdateEndTimeVar()
            changedStartTime = True

        ElseIf time = "end" Then
            Dim newHour = Me.endHour + hourChange
            If newHour <= -1 Then
                ' Jump Forward
                newHour = 23
            ElseIf newHour >= 24 Then
                ' Jump Back
                newHour = 0
            End If

            Me.endHour = newHour
            Me.endTime = New Date(Me.endYear, Me.endMonth, Me.endDay, Me.endHour, Me.endMinute, 0)
            changedEndTime = True

        End If

        Me.UpdateLabels()
    End Sub

    ' ------------------------
    ' --- Time Arrow Click ---
    ' ------------------------

    Private Sub imgTime_Click(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.Click, imgStartMinuteUp.Click, imgStartHourDown.Click,
        imgStartMinuteDown.Click, imgStartAmPmUp.Click, imgStartAmPmDown.Click,
        imgEndHourUp.Click, imgEndMinuteUp.Click, imgEndHourDown.Click,
        imgEndMinuteDown.Click, imgEndAmPmUp.Click, imgEndAmPmDown.Click

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Then
            Me.UpdateHour(1, "start")

        ElseIf (imgCur Is imgStartMinuteUp) Then
            Me.UpdateMinute(1, "start")

        ElseIf (imgCur Is imgStartHourDown) Then
            Me.UpdateHour(-1, "start")

        ElseIf (imgCur Is imgStartMinuteDown) Then
            Me.UpdateMinute(-1, "start")

        ElseIf (imgCur Is imgStartAmPmUp) Then
            If Me.startHour >= 12 Then
                Me.UpdateHour(-12, "start")
            Else
                Me.UpdateHour(12, "start")
            End If

        ElseIf (imgCur Is imgStartAmPmDown) Then
            If Me.startHour >= 12 Then
                Me.UpdateHour(-12, "start")
            Else
                Me.UpdateHour(12, "start")
            End If


        ElseIf (imgCur Is imgEndHourUp) Then
            Me.UpdateHour(1, "end")

        ElseIf (imgCur Is imgEndMinuteUp) Then
            Me.UpdateMinute(1, "end")

        ElseIf (imgCur Is imgEndHourDown) Then
            Me.UpdateHour(-1, "end")

        ElseIf (imgCur Is imgEndMinuteDown) Then
            Me.UpdateMinute(-1, "end")

        ElseIf (imgCur Is imgEndAmPmUp) Then
            If Me.endHour >= 12 Then
                Me.UpdateHour(-12, "end")
            Else
                Me.UpdateHour(12, "end")
            End If

        ElseIf (imgCur Is imgEndAmPmDown) Then
            If Me.endHour >= 12 Then
                Me.UpdateHour(-12, "end")
            Else
                Me.UpdateHour(12, "end")
            End If

        End If
    End Sub

    ' -----------------------
    ' --- Time Arrow Hold ---
    ' -----------------------

    Private Sub imgTime_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        imgStartHourUp.MouseDown, imgStartMinuteUp.MouseDown, imgStartHourDown.MouseDown, imgStartMinuteDown.MouseDown,
        imgEndHourUp.MouseDown, imgEndMinuteUp.MouseDown, imgEndHourDown.MouseDown, imgEndMinuteDown.MouseDown

        Me.mouseHoldSec = 0
        Me.mouseHoldImg = CType(sender, PictureBox)
        Me.tmrMouseHold.Start()
    End Sub

    Private Sub imgTime_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        imgStartHourUp.MouseUp, imgStartMinuteUp.MouseUp, imgStartHourDown.MouseUp, imgStartMinuteDown.MouseUp,
        imgEndHourUp.MouseUp, imgEndMinuteUp.MouseUp, imgEndHourDown.MouseUp, imgEndMinuteDown.MouseUp

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
                Me.UpdateHour(hourChng, "start")

            ElseIf (imgCur Is imgStartMinuteUp) Then
                Me.UpdateMinute(minChng, "start")

            ElseIf (imgCur Is imgStartHourDown) Then
                Me.UpdateHour(-hourChng, "start")

            ElseIf (imgCur Is imgStartMinuteDown) Then
                Me.UpdateMinute(-minChng, "start")


            ElseIf (imgCur Is imgEndHourUp) Then
                Me.UpdateHour(hourChng, "end")

            ElseIf (imgCur Is imgEndMinuteUp) Then
                Me.UpdateMinute(minChng, "end")

            ElseIf (imgCur Is imgEndHourDown) Then
                Me.UpdateHour(-hourChng, "end")

            ElseIf (imgCur Is imgEndMinuteDown) Then
                Me.UpdateMinute(-minChng, "end")

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
        imgStartMinuteDown.MouseEnter, imgStartAmPmUp.MouseEnter, imgStartAmPmDown.MouseEnter,
        imgEndHourUp.MouseEnter, imgEndMinuteUp.MouseEnter, imgEndHourDown.MouseEnter,
        imgEndMinuteDown.MouseEnter, imgEndAmPmUp.MouseEnter, imgEndAmPmDown.MouseEnter

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Or (imgCur Is imgStartMinuteUp) Or (imgCur Is imgStartAmPmUp) Or
            (imgCur Is imgEndHourUp) Or (imgCur Is imgEndMinuteUp) Or (imgCur Is imgEndAmPmUp) Then
            imgCur.Image = My.Resources.arrow_up_hover

        ElseIf (imgCur Is imgStartHourDown) Or (imgCur Is imgStartMinuteDown) Or (imgCur Is imgStartAmPmDown) Or
            (imgCur Is imgEndHourDown) Or (imgCur Is imgEndMinuteDown) Or (imgCur Is imgEndAmPmDown) Then
            imgCur.Image = My.Resources.arrow_down_hover
        End If
    End Sub

    Private Sub btnStartHourUp_MouseLeave(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.MouseLeave, imgStartMinuteUp.MouseLeave, imgStartHourDown.MouseLeave,
        imgStartMinuteDown.MouseLeave, imgStartAmPmUp.MouseLeave, imgStartAmPmDown.MouseLeave,
        imgEndHourUp.MouseLeave, imgEndMinuteUp.MouseLeave, imgEndHourDown.MouseLeave,
        imgEndMinuteDown.MouseLeave, imgEndAmPmUp.MouseLeave, imgEndAmPmDown.MouseLeave

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartHourUp) Or (imgCur Is imgStartMinuteUp) Or (imgCur Is imgStartAmPmUp) Or
            (imgCur Is imgEndHourUp) Or (imgCur Is imgEndMinuteUp) Or (imgCur Is imgEndAmPmUp) Then
            imgCur.Image = My.Resources.arrow_up_neutral

        ElseIf (imgCur Is imgStartHourDown) Or (imgCur Is imgStartMinuteDown) Or (imgCur Is imgStartAmPmDown) Or
            (imgCur Is imgEndHourDown) Or (imgCur Is imgEndMinuteDown) Or (imgCur Is imgEndAmPmDown) Then
            imgCur.Image = My.Resources.arrow_down_neutral

        End If
    End Sub

    Private Sub cmbx_TextChanged(sender As Object, e As EventArgs) Handles cmbxStart.TextChanged, cmbxEnd.TextChanged
        If Me.cmbxStart.Text <> "" And Me.cmbxEnd.Text <> "" Then
            Me.btnStart.Enabled = True
        End If
    End Sub
End Class