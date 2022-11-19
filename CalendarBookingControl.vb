Imports System.Drawing.Printing

Public Class CalendarBookingControl

    Dim previousForm As Form

    Dim currTime As Date

    Dim hour As Integer
    Dim day As Integer
    Dim month As Integer
    Dim year As Integer

    Dim hourSet As Boolean
    Dim daySet As Boolean

    ' Fonts
    Dim headingFont = New Font("Segoe UI Semibold", 24, FontStyle.Bold)
    Dim bodyFont = New Font("Segoe UI", 14)

    ' Height Change
    Dim addedHeight = 300

    ' Controls

    ' Start
    Dim lblStart As Label

    Dim lblDateStartPrompt As Label
    Dim txtDateStart As TextBox
    Dim WithEvents btnDateStartSelect As Button

    Dim lblTimeStartPrompt As Label
    Dim WithEvents txtTimeHour As TextBox
    Dim lblTimeColon As Label
    Dim WithEvents txtTimeMinute As TextBox

    Dim lblStartConfirm As Label

    ' Month
    Dim showMonthsStart As Boolean
    Dim lblMonth As Label
    Dim WithEvents imgArrowLeft As PictureBox
    Dim WithEvents imgArrowRight As PictureBox
    Dim usrctrlMonth As CalendarMonthControl

    Private Sub CalendarBookingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vertical scroll bar is around 25 pixels
        ' Form white area is 435, 632 pixels
        ' User Control width - scroll bar (to make space for it) = 410
        Me.showMonthsStart = False
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Sub Setup(currTime As Date, trigger As String, previousForm As Form)
        Me.previousForm = previousForm

        Me.currTime = currTime
        Me.month = Me.currTime.Month
        Me.year = Me.currTime.Year
        If (trigger = "MonthPlus") Then
            Me.hour = 0
            Me.day = 1
            Me.hourSet = False
            Me.daySet = False
        ElseIf (trigger = "DayPlus") Then
            Me.hour = 0
            Me.day = currTime.Day
            Me.hourSet = False
            Me.daySet = True
        ElseIf (trigger = "DaySlot") Then
            Me.hour = currTime.Hour
            Me.day = currTime.Day
            Me.hourSet = True
            Me.daySet = True
        End If

        Me.CreateStart()
        Me.CreateMonths()
        Me.AddControls()

    End Sub

    Private Sub CreateStart()
        Dim leftPadding = New Padding(25, 5, 0, 5)
        Dim sidePadding = New Padding(5, 5, 0, 5)

        ' lblStart
        Me.lblStart = New Label()
        Me.lblStart.Text = "Date"
        Me.lblStart.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStart.Font = headingFont
        Me.lblStart.Size = New Size(Me.Width - 25, 45)
        Me.lblStart.AutoSize = False
        Me.lblStart.Margin = New Padding(leftPadding.Left / 2, padding.Top, padding.Bottom, padding.Right)

        ' lblDateStartPrompt
        Me.lblDateStartPrompt = New Label
        Me.lblDateStartPrompt.Text = "Select the start date of your car booking:"
        Me.lblDateStartPrompt.Font = bodyFont
        Me.lblDateStartPrompt.AutoSize = True
        Me.lblDateStartPrompt.Margin = leftPadding

        ' txtDateStart
        Me.txtDateStart = New TextBox
        Me.txtDateStart.Multiline = False
        Me.txtDateStart.Enabled = False
        Me.txtDateStart.Font = bodyFont
        Me.txtDateStart.Width = 300
        Me.txtDateStart.Text = Format(Me.currTime, "dddd d MMMM yyyy")
        Me.txtDateStart.Margin = leftPadding

        ' btnDateStartSelect
        Me.btnDateStartSelect = New Button
        Me.btnDateStartSelect.Text = "Select"
        Me.btnDateStartSelect.Font = bodyFont
        Me.btnDateStartSelect.Height = Me.txtDateStart.Height
        Me.btnDateStartSelect.Margin = sidePadding

        'Dim lblTimeStartPrompt As Label
        'Dim txtTimeHour As TextBox
        'Dim lblTimeColon As Label
        'Dim txtTimeMinute As TextBox
        'Dim lblStartConfirm As Label

        ' lblTimeStartPrompt
        Me.lblDateStartPrompt = New Label
        Me.lblDateStartPrompt.Text = "Select the start time of your car booking:"
        Me.lblDateStartPrompt.Font = bodyFont
        Me.lblDateStartPrompt.AutoSize = True
        Me.lblDateStartPrompt.Margin = leftPadding

        ' txtTimeHour
        Me.txtTimeHour = New TextBox
        Me.txtTimeHour.Multiline = False
        Me.txtTimeHour.Font = bodyFont
        Me.txtTimeHour.Width = 100
        Me.txtTimeHour.Margin = leftPadding

        ' lblTimeColon
        Me.lblDateStartPrompt = New Label
        Me.lblDateStartPrompt.Text = ":"
        Me.lblDateStartPrompt.Font = bodyFont
        Me.lblDateStartPrompt.AutoSize = True
        Me.lblDateStartPrompt.Margin = sidePadding

        ' txtTimeMinute
        Me.txtTimeMinute = New TextBox
        Me.txtTimeMinute.Multiline = False
        Me.txtTimeMinute.Font = bodyFont
        Me.txtTimeMinute.Width = 100
        Me.txtTimeMinute.Margin = sidePadding

        ' lblStartConfirm
        Me.lblDateStartPrompt = New Label
        Me.lblDateStartPrompt.Text = "Select the start time of your car booking:"
        Me.lblDateStartPrompt.Font = bodyFont
        Me.lblDateStartPrompt.AutoSize = True
        Me.lblDateStartPrompt.Margin = leftPadding


    End Sub

    Private Sub CreateMonths()
        Dim padding = New Padding(0, 20, 0, 20)
        Dim leftPadding = New Padding(25, padding.Top, padding.Bottom, padding.Right)

        ' imgArrowLeft
        Me.imgArrowLeft = New PictureBox
        Me.imgArrowLeft.Size = New Size(45, 45)
        Me.imgArrowLeft.Image = My.Resources.ArrowLeft
        Me.imgArrowLeft.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgArrowLeft.Margin = leftPadding

        ' lblMonth
        Me.lblMonth = New Label
        Me.lblMonth.Text = Format(Me.currTime, "MMMM yyyy")
        Me.lblMonth.TextAlign = ContentAlignment.MiddleCenter
        Me.lblMonth.Font = headingFont
        Me.lblMonth.AutoSize = False
        'Me.lblMonth.Size = New Size(265, Me.imgArrowLeft.Height)
        Me.lblMonth.Size = New Size(410 - ((Me.imgArrowLeft.Width * 2) + 55), Me.imgArrowLeft.Height)
        Me.lblMonth.Margin = padding

        ' imgArrowRight
        Me.imgArrowRight = New PictureBox
        Me.imgArrowRight.Size = New Size(45, 45)
        Me.imgArrowRight.Image = My.Resources.ArrowRight
        Me.imgArrowRight.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgArrowRight.Margin = padding

        ' usrctrlMonth
        Me.usrctrlMonth = New CalendarMonthControl()
        Me.usrctrlMonth.SetBookingForm(Me)
        Me.usrctrlMonth.SetMonth(Me.currTime)
        Me.usrctrlMonth.Margin = New Padding(14, padding.Top, padding.Bottom, padding.Right)
    End Sub

    Private Sub AddControls()
        Me.SuspendLayout()
        Me.flPanel.Controls.Clear()

        Me.flPanel.Controls.Add(Me.lblStart)
        Me.flPanel.Controls.Add(Me.lblDateStartPrompt)
        Me.flPanel.SetFlowBreak(Me.lblDateStartPrompt, True)
        Me.flPanel.Controls.Add(Me.txtDateStart)
        Me.flPanel.Controls.Add(Me.btnDateStartSelect)
        Me.flPanel.SetFlowBreak(Me.btnDateStartSelect, True)

        If showMonthsStart Then
            Me.flPanel.Controls.Add(Me.imgArrowLeft)
            Me.flPanel.Controls.Add(Me.lblMonth)
            Me.flPanel.Controls.Add(Me.imgArrowRight)
            Me.flPanel.Controls.Add(Me.usrctrlMonth)
        End If

        Me.flPanel.Controls.Add(Me.lblTimeStartPrompt)
        Me.flPanel.SetFlowBreak(Me.lblTimeStartPrompt, True)

        Me.flPanel.ResumeLayout(True)
        Me.ResumeLayout(True)
    End Sub

    Public Sub DayClicked(day As Integer)
        Dim newDate = New Date(Me.year, Me.month, day)
        Me.currTime = newDate
        Me.txtDateStart.Text = Format(Me.currTime, "dddd d MMMM yyyy")
        Me.showMonthsStart = False
        Me.Height = Me.Height - addedHeight
        Me.flPanel.Height = Me.flPanel.Height - addedHeight
        Me.btnDateStartSelect.Enabled = True
        Me.AddControls()
    End Sub

    ' ----------------------
    ' --- Calendar Month ---
    ' ----------------------

    Private Sub UpdateMonth(monthChange As Integer)
        Dim newMonth = Me.month + monthChange
        If newMonth = 0 Then
            ' Previous year Dec
            newMonth = 12
            Me.year -= 1
        ElseIf newMonth = 13 Then
            ' Next year Jan
            newMonth = 1
            Me.year += 1
        End If

        Me.month = newMonth
        Me.currTime = New Date(Me.year, Me.month, 1)

        Me.usrctrlMonth.SetMonth(Me.currTime)
        Me.lblMonth.Text = Format(Me.currTime, "MMMM yyyy")
    End Sub


    ' -------------------
    ' --- Date Select ---
    ' -------------------
    Private Sub btnDateSelect_Click(sender As Object, e As EventArgs) Handles btnDateStartSelect.Click
        Me.showMonthsStart = True
        Me.btnDateStartSelect.Enabled = False
        Me.Height = Me.Height + addedHeight
        Me.flPanel.Height = Me.flPanel.Height + addedHeight
        Me.AddControls()
    End Sub

    ' -------------------
    ' --- Arrow Click ---
    ' -------------------
    Private Sub imgArrowRight_Click(sender As Object, e As EventArgs) Handles imgArrowRight.Click
        If Me.imgArrowRight.Enabled Then
            Me.UpdateMonth(1)
        End If
    End Sub

    Private Sub imgArrowLeft_Click(sender As Object, e As EventArgs) Handles imgArrowLeft.Click
        If Me.imgArrowLeft.Enabled Then
            Me.UpdateMonth(-1)
        End If
    End Sub

    ' -------------------
    ' --- Arrow Hover ---
    ' -------------------
    Private Sub imgArrowRight_MouseEnter(sender As Object, e As EventArgs) Handles imgArrowRight.MouseEnter
        Me.imgArrowRight.Image = My.Resources.ArrowRight___Hover
    End Sub

    Private Sub imgArrowRight_MouseLeave(sender As Object, e As EventArgs) Handles imgArrowRight.MouseLeave
        Me.imgArrowRight.Image = My.Resources.ArrowRight
    End Sub

    Private Sub imgArrowLeft_MouseEnter(sender As Object, e As EventArgs) Handles imgArrowLeft.MouseEnter
        Me.imgArrowLeft.Image = My.Resources.ArrowLeft___Hover
    End Sub

    Private Sub imgArrowLeft_MouseLeave(sender As Object, e As EventArgs) Handles imgArrowLeft.MouseLeave
        Me.imgArrowLeft.Image = My.Resources.ArrowLeft
    End Sub

End Class
