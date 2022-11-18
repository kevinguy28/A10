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
    Dim lblDate As Label
    Dim lblDatePrompt As Label
    Dim txtDate As TextBox
    Dim WithEvents btnDateSelect As Button

    Dim showMonths As Boolean
    Dim lblMonth As Label
    Dim WithEvents imgArrowLeft As PictureBox
    Dim WithEvents imgArrowRight As PictureBox
    Dim usrctrlMonth As CalendarMonthControl

    Private Sub CalendarBookingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vertical scroll bar is around 25 pixels
        ' Form white area is 435, 632 pixels
        ' User Control width - scroll bar (to make space for it) = 410
        Me.showMonths = False
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

        Me.CreateDate()
        Me.CreateMonths()
        Me.AddControls()

    End Sub

    Private Sub CreateDate()
        Dim padding = New Padding(25, 5, 0, 5)

        ' lblDate
        Me.lblDate = New Label()
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblDate.Font = headingFont
        Me.lblDate.AutoSize = False
        Me.lblDate.Height = 45
        Me.lblDate.Margin = New Padding(padding.Left / 2, padding.Top, padding.Bottom, padding.Right)

        ' lblDatePrompt
        Me.lblDatePrompt = New Label
        Me.lblDatePrompt.Text = "Select the date you want to book a car:"
        Me.lblDatePrompt.Font = bodyFont
        Me.lblDatePrompt.AutoSize = True
        Me.lblDatePrompt.Margin = padding

        ' txtDate
        Me.txtDate = New TextBox
        Me.txtDate.Multiline = False
        Me.txtDate.Enabled = False
        Me.txtDate.Font = bodyFont
        'Me.txtDate.Width = Me.Width * 0.7
        Me.txtDate.Width = 300
        Me.txtDate.Text = Format(Me.currTime, "dddd d MMMM yyyy")
        Me.txtDate.Margin = padding

        ' btnDateSelect
        Me.btnDateSelect = New Button
        Me.btnDateSelect.Text = "Select"
        Me.btnDateSelect.Font = bodyFont
        Me.btnDateSelect.Height = Me.txtDate.Height
        Me.btnDateSelect.Margin = New Padding(padding.Top, padding.Top, padding.Bottom, padding.Right)

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

        Me.flPanel.Controls.Add(Me.lblDate)
        Me.flPanel.Controls.Add(Me.lblDatePrompt)
        Me.flPanel.SetFlowBreak(Me.lblDatePrompt, True)
        Me.flPanel.Controls.Add(Me.txtDate)
        Me.flPanel.Controls.Add(Me.btnDateSelect)
        Me.flPanel.SetFlowBreak(Me.btnDateSelect, True)

        If showMonths Then
            Me.flPanel.Controls.Add(Me.imgArrowLeft)
            Me.flPanel.Controls.Add(Me.lblMonth)
            Me.flPanel.Controls.Add(Me.imgArrowRight)
            Me.flPanel.Controls.Add(Me.usrctrlMonth)
        End If

        Me.flPanel.ResumeLayout(True)
        Me.ResumeLayout(True)
    End Sub

    Public Sub DayClicked(day As Integer)
        Dim newDate = New Date(Me.year, Me.month, day)
        Me.currTime = newDate
        Me.txtDate.Text = Format(Me.currTime, "dddd d MMMM yyyy")
        Me.showMonths = False
        Me.Height = Me.Height - addedHeight
        Me.flPanel.Height = Me.flPanel.Height - addedHeight
        Me.btnDateSelect.Enabled = True
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
    Private Sub btnDateSelect_Click(sender As Object, e As EventArgs) Handles btnDateSelect.Click
        Me.showMonths = True
        Me.btnDateSelect.Enabled = False
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
