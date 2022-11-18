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

    ' Controls
    Dim lblDate As Label
    Dim lblDatePrompt As Label
    Dim txtDate As TextBox
    Dim WithEvents btnDateSelect As Button

    Dim showMonths As Boolean
    Dim lblMonth As Label
    Dim WithEvents imgArrowLeft As PictureBox
    Dim WithEvents imgArrowRight As PictureBox

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
        ' lblDate
        Me.lblDate = New Label()
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblDate.Font = headingFont
        Me.lblDate.AutoSize = False
        Me.lblDate.Size = New Size(Me.Width, 45)

        ' lblDatePrompt
        Me.lblDatePrompt = New Label
        Me.lblDatePrompt.Text = "Select the date you want to book a car:"
        Me.lblDatePrompt.Font = bodyFont
        Me.lblDatePrompt.AutoSize = True

        ' txtDate
        Me.txtDate = New TextBox
        Me.txtDate.Multiline = False
        Me.txtDate.Enabled = False
        Me.txtDate.Font = bodyFont
        Me.txtDate.Size = New Size(Me.Width * 0.78, Me.txtDate.Size.Height)
        Me.txtDate.Text = Format(Me.currTime, "dddd d MMMM yyyy")

        ' btnDateSelect
        Me.btnDateSelect = New Button
        Me.btnDateSelect.Text = "Select"
        Me.btnDateSelect.Font = bodyFont
        Me.btnDateSelect.Size = New Size(Me.btnDateSelect.Width, Me.txtDate.Height)

    End Sub

    Private Sub CreateMonths()

        ' lblMonth
        Me.lblMonth = New Label
        Me.lblMonth.Text = Format(Me.currTime, "MMMM yyyy")
        Me.lblMonth.TextAlign = ContentAlignment.MiddleCenter
        Me.lblMonth.Font = headingFont
        Me.lblMonth.AutoSize = False
        Me.lblMonth.Size = New Size(Me.Width, 45)
    End Sub

    Private Sub AddControls()
        Me.SuspendLayout()

        Me.flPanel.Controls.Add(Me.lblDate)
        Me.flPanel.Controls.Add(Me.lblDatePrompt)
        Me.flPanel.SetFlowBreak(Me.lblDatePrompt, True)
        Me.flPanel.Controls.Add(Me.txtDate)
        Me.flPanel.Controls.Add(Me.btnDateSelect)

        Me.flPanel.ResumeLayout(True)
        Me.ResumeLayout(True)
    End Sub

    ' ---------------------
    ' --- btnDateSelect ---
    ' ---------------------
    Private Sub btnDateSelect_Click(sender As Object, e As EventArgs) Handles btnDateSelect.Click
        Me.showMonths = True
    End Sub

End Class
