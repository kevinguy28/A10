Imports System.ComponentModel
Imports System.Threading

Public Class CalendarBookingControl

    Dim previousForm As CalendarBookingForm

    Dim startTime As Date

    Dim changedStartTime = False

    Dim startMinute As Integer
    Dim startHour As Integer
    Dim startDay As Integer
    Dim startMonth As Integer
    Dim startYear As Integer

    ' Height Change
    Dim addedHeight = 472

    ' Border Change
    Dim bdrTopHghtChanged = False

    ' Error Shake
    Dim WithEvents backgroundWorker As BackgroundWorker
    Dim lblError As Label

    ' MouseHold
    Dim mouseHoldSec = 0
    Dim mouseHoldImg As PictureBox

    ' Fonts
    Dim headingFont = New Font("Segoe UI Semibold", 24, FontStyle.Bold)
    Dim bodyFont = New Font("Segoe UI", 14)
    Dim bodyBoldFont = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Dim timeFont = New Font("Segoe UI Semibold", 22, FontStyle.Bold)

    ' Size
    Dim headingSize = New Size(435 - 40, 50)
    Dim timeSize = New Size(55, 40)
    Dim colonSize = New Size(20, 40)
    Dim amPmSize = New Size(65, 40)

    ' Colour
    Dim colourHover = Color.FromArgb(127, 242, 229)
    Dim colourNeutral = Color.FromArgb(151, 203, 197)
    Dim colourPressed = Color.FromArgb(120, 145, 141)
    Dim colourWhite = Color.White

    ' Padding                     (l, t, r, b)
    Dim leftPadding = New Padding(25, 5, 0, 5)
    Dim sidePadding = New Padding(5, 5, 0, 5)
    Dim noPadding = New Padding(0, 0, 0, 0)
    Dim headingPadding = New Padding(leftPadding.Left / 2, 50, 0, 3)

    ' TextAlign
    Dim headingTextAlign = ContentAlignment.TopCenter

    ' === Controls ===

    ' --- Now ---
    Dim WithEvents btnNow As Button

    ' --- Start ---
    Dim lblStart As Label

    Dim lblDateStartPrompt As Label
    Dim txtDateStart As TextBox
    Dim WithEvents btnDateStartSelect As Button

    Dim lblTimeStartPrompt As Label
    Dim lblHourStart As Label
    Dim lblMinuteStart As Label
    Dim lblAmPmStart As Label
    Dim lblStartTimeColon As Label

    Dim WithEvents imgStartHourUp As PictureBox
    Dim WithEvents imgStartMinuteUp As PictureBox
    Dim WithEvents imgStartHourDown As PictureBox
    Dim WithEvents imgStartMinuteDown As PictureBox
    Dim WithEvents imgStartAmPmUp As PictureBox
    Dim WithEvents imgStartAmPmDown As PictureBox

    Dim lblStartConfirmPrompt As Label
    Dim lblStartConfirmDate As Label

    ' --- Start Month ---
    Dim showMonthsStart As Boolean
    Dim lblStartMonth As Label
    Dim WithEvents imgStartArrowLeft As PictureBox
    Dim WithEvents imgStartArrowRight As PictureBox
    Dim usrctrlStartMonth As CalendarMonthControl

    ' --- Next ---
    Dim WithEvents btnNext As Button

    Private Sub CalendarBookingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vertical scroll bar is around 25 pixels
        ' Form white area is 435, 632 pixels
        ' User Control width - scroll bar (to make space for it) = 410
        Me.showMonthsStart = False

        ' Background Worker
        Me.backgroundWorker = New BackgroundWorker()
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Sub Setup(currTime As Date, trigger As String, previousForm As CalendarBookingForm, userEvent As UserCalendarEvent)
        Me.flPanel.Location = New Point(0, 0)
        Me.flPanel.Size = New Size(410, 632)

        Dim initialAddedHeight = 80
        Me.Height = Me.Height + initialAddedHeight
        Me.flPanel.Height = Me.flPanel.Height + initialAddedHeight

        Me.previousForm = previousForm
        Me.lblError = Me.previousForm.GetLblError()

        If userEvent Is Nothing Then
            Me.startTime = currTime
        Else
            Me.startTime = userEvent.GetStartDate
        End If

        Me.startMinute = 0
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year

        If (trigger = "MonthPlus") Then
            Me.startHour = 0
            Me.startDay = 1
        ElseIf (trigger = "DayPlus") Then
            Me.startHour = 0
            Me.startDay = Me.startTime.Day
        ElseIf (trigger = "DaySlot") Then
            Me.startHour = Me.startTime.Hour
            Me.startDay = Me.startTime.Day
        End If

        Me.CreateNow()
        Me.CreateStart()
        Me.CreateStartMonths()
        Me.CreateNext()
        Me.AddControls()

        ' Border
        Dim borderSize = New Size(10, 392)
        Dim top = 50 + 60 + 50
        Dim lft = 10
        Dim rgt = 400

        Me.lblStartLeft.BringToFront()
        Me.lblStartLeft.BackColor = colourNeutral
        Me.lblStartLeft.Location = New Point(lft, top)
        Me.lblStartLeft.Size = borderSize

        Me.lblStartRight.BringToFront()
        Me.lblStartRight.BackColor = colourNeutral
        Me.lblStartRight.Location = New Point(rgt, top)
        Me.lblStartRight.Size = borderSize

    End Sub

    Private Sub CreateNow()
        'btnNow
        Me.btnNow = New Button
        Me.btnNow.Text = "Now"
        Me.btnNow.Font = headingFont
        Me.btnNow.TextAlign = headingTextAlign
        Me.btnNow.BackColor = colourNeutral
        Me.btnNow.ForeColor = Color.White
        Me.btnNow.TabStop = False
        Me.btnNow.FlatStyle = FlatStyle.Flat
        Me.btnNow.FlatAppearance.BorderSize = 0
        Me.btnNow.FlatAppearance.BorderColor = colourNeutral
        Me.btnNow.FlatAppearance.MouseDownBackColor = colourPressed
        Me.btnNow.FlatAppearance.MouseOverBackColor = colourHover
        Me.btnNow.Size = New Size(300, 60)
        Me.btnNow.Margin = New Padding(((Me.Width - Me.btnNow.Width) / 2) - 10, 50, 0, 0)
    End Sub

    Private Sub CreateStart()
        ' lblStart
        Me.lblStart = New Label()
        Me.lblStart.Text = "Start"
        Me.lblStart.TextAlign = headingTextAlign
        Me.lblStart.Font = headingFont
        Me.lblStart.Size = headingSize
        Me.lblStart.AutoSize = False
        Me.lblStart.Margin = headingPadding
        Me.lblStart.BackColor = colourNeutral
        Me.lblStart.ForeColor = colourWhite

        ' --- Date ---
        Dim txtPad = 5
        Dim txtBor = 15

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
        Me.txtDateStart.Width = 300 - txtPad - txtBor
        Me.txtDateStart.Text = Format(Me.startTime, "dddd d MMMM yyyy")
        Me.txtDateStart.Margin = New Padding(25 + txtPad, 5, 0, 5)

        ' btnDateStartSelect
        Me.btnDateStartSelect = New Button
        Me.btnDateStartSelect.Text = "Select"
        Me.btnDateStartSelect.Font = bodyFont
        Me.btnDateStartSelect.Height = Me.txtDateStart.Height
        Me.btnDateStartSelect.BackColor = colourNeutral
        Me.btnDateStartSelect.ForeColor = Color.White
        Me.btnDateStartSelect.TabStop = False
        Me.btnDateStartSelect.FlatStyle = FlatStyle.Flat
        Me.btnDateStartSelect.FlatAppearance.BorderSize = 0
        Me.btnDateStartSelect.Margin = sidePadding

        ' --- Time: Labels ---

        ' lblTimeStartPrompt
        Me.lblTimeStartPrompt = New Label
        Me.lblTimeStartPrompt.Text = "Select the start time of your car booking:"
        Me.lblTimeStartPrompt.Font = bodyFont
        Me.lblTimeStartPrompt.AutoSize = True
        Me.lblTimeStartPrompt.Margin = leftPadding

        Dim left = 110

        ' lblHourStart
        Me.lblHourStart = New Label
        Me.lblHourStart.Text = Format(Me.startTime, "hh")
        Me.lblHourStart.TextAlign = ContentAlignment.MiddleCenter
        Me.lblHourStart.Font = timeFont
        Me.lblHourStart.Size = timeSize
        Me.lblHourStart.AutoSize = False
        Me.lblHourStart.Padding = noPadding
        Me.lblHourStart.Margin = New Padding(left, 0, 0, 0)

        ' lblMinuteStart
        Me.lblMinuteStart = New Label
        Me.lblMinuteStart.Text = Format(Me.startTime, "mm")
        Me.lblMinuteStart.TextAlign = ContentAlignment.MiddleCenter
        Me.lblMinuteStart.Font = timeFont
        Me.lblMinuteStart.Size = timeSize
        Me.lblMinuteStart.AutoSize = False
        Me.lblMinuteStart.Padding = noPadding
        Me.lblMinuteStart.Margin = noPadding

        ' lblAmPmStart
        Me.lblAmPmStart = New Label
        Me.lblAmPmStart.Text = Format(Me.startTime, "tt").ToLower
        Me.lblAmPmStart.TextAlign = ContentAlignment.MiddleCenter
        Me.lblAmPmStart.Font = timeFont
        Me.lblAmPmStart.Size = amPmSize
        Me.lblAmPmStart.AutoSize = False
        Me.lblAmPmStart.Padding = noPadding
        Me.lblAmPmStart.Margin = New Padding(colonSize.Width - 5, 0, 0, 0)

        ' lblStartTimeColon
        Me.lblStartTimeColon = New Label
        Me.lblStartTimeColon.Text = ":"
        Me.lblStartTimeColon.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartTimeColon.Font = timeFont
        Me.lblStartTimeColon.Size = colonSize
        Me.lblStartTimeColon.AutoSize = False
        Me.lblStartTimeColon.Margin = noPadding

        ' --- Time: Arrows ---

        ' imgStartHourUp
        Me.imgStartHourUp = New PictureBox
        Me.imgStartHourUp.Size = New Size(45, 45)
        Me.imgStartHourUp.Image = My.Resources.arrow_up_neutral
        Me.imgStartHourUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartHourUp.Margin = New Padding(left + 5, 5, 0, 0)

        ' imgStartMinuteUp
        Me.imgStartMinuteUp = New PictureBox
        Me.imgStartMinuteUp.Size = New Size(45, 45)
        Me.imgStartMinuteUp.Image = My.Resources.arrow_up_neutral
        Me.imgStartMinuteUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartMinuteUp.Margin = New Padding(colonSize.Width + 10, 5, 0, 0)

        ' imgStartAmPmUp
        Me.imgStartAmPmUp = New PictureBox
        Me.imgStartAmPmUp.Size = New Size(45, 45)
        Me.imgStartAmPmUp.Image = My.Resources.arrow_up_neutral
        Me.imgStartAmPmUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartAmPmUp.Margin = New Padding(colonSize.Width + 10, 5, 0, 0)

        ' imgStartHourDown
        Me.imgStartHourDown = New PictureBox
        Me.imgStartHourDown.Size = New Size(45, 45)
        Me.imgStartHourDown.Image = My.Resources.arrow_down_neutral
        Me.imgStartHourDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartHourDown.Margin = New Padding(left + 5, 8, 0, 5)

        ' imgStartMinuteDown
        Me.imgStartMinuteDown = New PictureBox
        Me.imgStartMinuteDown.Size = New Size(45, 45)
        Me.imgStartMinuteDown.Image = My.Resources.arrow_down_neutral
        Me.imgStartMinuteDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartMinuteDown.Margin = New Padding(colonSize.Width + 10, 8, 0, 5)

        ' imgStartAmPmDown
        Me.imgStartAmPmDown = New PictureBox
        Me.imgStartAmPmDown.Size = New Size(45, 45)
        Me.imgStartAmPmDown.Image = My.Resources.arrow_down_neutral
        Me.imgStartAmPmDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartAmPmDown.Margin = New Padding(colonSize.Width + 10, 8, 0, 5)

        ' --- Time: Confirm ---

        ' lblStartConfirmPrompt
        Me.lblStartConfirmPrompt = New Label
        Me.lblStartConfirmPrompt.Text = "Your booking will start on"
        Me.lblStartConfirmPrompt.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartConfirmPrompt.Font = bodyFont
        Me.lblStartConfirmPrompt.Size = New Size(Me.Width, 24)
        Me.lblStartConfirmPrompt.AutoSize = False
        Me.lblStartConfirmPrompt.Margin = noPadding

        ' lblStartConfirmDate
        Me.lblStartConfirmDate = New Label
        Me.lblStartConfirmDate.Text = Format(Me.startTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.startTime, "h:mm tt")
        Me.lblStartConfirmDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartConfirmDate.Font = bodyBoldFont
        Me.lblStartConfirmDate.Size = New Size(Me.Width - 40, 55)
        Me.lblStartConfirmDate.AutoSize = False
        Me.lblStartConfirmDate.Margin = New Padding(leftPadding.Left / 2, 0, 0, 0)
        Me.lblStartConfirmDate.BackColor = colourNeutral
        Me.lblStartConfirmDate.ForeColor = Color.White

    End Sub

    Private Sub CreateStartMonths()
        '                          l, t, r, b
        Dim padding = New Padding(0, 20, 0, 20)
        Dim leftMonthPadding = New Padding(25, 20, 0, 20)

        ' imgStartArrowLeft
        Me.imgStartArrowLeft = New PictureBox
        Me.imgStartArrowLeft.Size = New Size(45, 45)
        Me.imgStartArrowLeft.Image = My.Resources.ArrowLeft
        Me.imgStartArrowLeft.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartArrowLeft.Margin = leftMonthPadding

        ' lblStartMonth
        Me.lblStartMonth = New Label
        Me.lblStartMonth.Text = Format(Me.startTime, "MMMM yyyy")
        Me.lblStartMonth.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartMonth.Font = headingFont
        Me.lblStartMonth.AutoSize = False
        Me.lblStartMonth.Size = New Size(410 - ((Me.imgStartArrowLeft.Width * 2) + 40), Me.imgStartArrowLeft.Height)
        Me.lblStartMonth.Margin = padding

        ' imgStartArrowRight
        Me.imgStartArrowRight = New PictureBox
        Me.imgStartArrowRight.Size = New Size(45, 45)
        Me.imgStartArrowRight.Image = My.Resources.ArrowRight
        Me.imgStartArrowRight.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgStartArrowRight.Margin = padding

        ' usrctrlStartMonth
        Me.usrctrlStartMonth = New CalendarMonthControl()
        Me.usrctrlStartMonth.SetBookingForm(Me)
        Me.usrctrlStartMonth.SetMin(New Date.Now())
        Me.usrctrlStartMonth.SetMonth(Me.startTime)
        Me.usrctrlStartMonth.Margin = New Padding(28, 0, 0, 10)
        Me.usrctrlStartMonth.Size = New Size(Me.usrctrlStartMonth.Width - 28, Me.usrctrlStartMonth.Height - 28)

    End Sub

    Private Sub CreateNext()
        'btnNext
        Me.btnNext = New Button
        Me.btnNext.Text = "Select Car"
        Me.btnNext.Font = headingFont
        Me.btnNext.TextAlign = headingTextAlign
        Me.btnNext.BackColor = colourNeutral
        Me.btnNext.ForeColor = Color.White
        Me.btnNext.TabStop = False
        Me.btnNext.FlatStyle = FlatStyle.Flat
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.Size = New Size(300, 60)
        Me.btnNext.Margin = New Padding(((Me.Width - Me.btnNext.Width) / 2) - 10, 50, 0, 0)
    End Sub

    Private Sub AddControls()
        Me.SuspendLayout()
        Me.flPanel.Controls.Clear()

        ' Now
        Me.flPanel.Controls.Add(Me.btnNow)
        Me.flPanel.SetFlowBreak(Me.btnNow, True)

        ' Start: Month
        Me.flPanel.Controls.Add(Me.lblStart)
        Me.flPanel.Controls.Add(Me.lblDateStartPrompt)
        Me.flPanel.SetFlowBreak(Me.lblDateStartPrompt, True)
        Me.flPanel.Controls.Add(Me.txtDateStart)
        Me.flPanel.Controls.Add(Me.btnDateStartSelect)
        Me.flPanel.SetFlowBreak(Me.btnDateStartSelect, True)

        If showMonthsStart Then
            Me.flPanel.Controls.Add(Me.imgStartArrowLeft)
            Me.flPanel.Controls.Add(Me.lblStartMonth)
            Me.flPanel.Controls.Add(Me.imgStartArrowRight)
            Me.flPanel.Controls.Add(Me.usrctrlStartMonth)
        End If

        ' Start: Time
        Me.flPanel.Controls.Add(Me.lblTimeStartPrompt)
        Me.flPanel.SetFlowBreak(Me.lblTimeStartPrompt, True)

        Me.flPanel.Controls.Add(Me.imgStartHourUp)
        Me.flPanel.Controls.Add(Me.imgStartMinuteUp)
        Me.flPanel.Controls.Add(Me.imgStartAmPmUp)
        Me.flPanel.SetFlowBreak(Me.imgStartAmPmUp, True)

        Me.flPanel.Controls.Add(Me.lblHourStart)
        Me.flPanel.Controls.Add(Me.lblStartTimeColon)
        Me.flPanel.Controls.Add(Me.lblMinuteStart)
        Me.flPanel.Controls.Add(Me.lblAmPmStart)
        Me.flPanel.SetFlowBreak(Me.lblAmPmStart, True)

        Me.flPanel.Controls.Add(Me.imgStartHourDown)
        Me.flPanel.Controls.Add(Me.imgStartMinuteDown)
        Me.flPanel.Controls.Add(Me.imgStartAmPmDown)
        Me.flPanel.SetFlowBreak(Me.imgStartAmPmDown, True)

        Me.flPanel.Controls.Add(Me.lblStartConfirmPrompt)
        Me.flPanel.SetFlowBreak(Me.lblStartConfirmPrompt, True)
        Me.flPanel.Controls.Add(Me.lblStartConfirmDate)
        Me.flPanel.SetFlowBreak(Me.lblStartConfirmDate, True)

        ' Next
        Me.flPanel.Controls.Add(Me.btnNext)

        Me.flPanel.ResumeLayout(True)
        Me.ResumeLayout(True)
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------
    Private Sub UpdateFormSize(change As Integer)
        Dim changeHeight = addedHeight * change

        Me.Height += changeHeight
        Me.flPanel.Height += changeHeight

        Dim topHchanged = False

        If showMonthsStart Then
            If Not bdrTopHghtChanged Then topHchanged = True
        Else
            If bdrTopHghtChanged Then topHchanged = True
        End If

        'Top Height
        If topHchanged Then
            Me.lblStartLeft.Height += changeHeight
            Me.lblStartRight.Height += changeHeight
            bdrTopHghtChanged = Not bdrTopHghtChanged
        End If

    End Sub

    Private Sub UpdateStartTimeVar()
        Me.startMinute = Me.startTime.Minute
        Me.startHour = Me.startTime.Hour
        Me.startDay = Me.startTime.Day
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year
    End Sub

    Private Sub UpdateLabels()
        Me.txtDateStart.Text = Format(Me.startTime, "dddd d MMMM yyyy")
        Me.lblHourStart.Text = Format(Me.startTime, "hh")
        Me.lblMinuteStart.Text = Format(Me.startTime, "mm")
        Me.lblAmPmStart.Text = Format(Me.startTime, "tt").ToLower
        Me.lblStartConfirmDate.Text = Format(Me.startTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.startTime, "h:mm tt")
    End Sub

    Private Function GetMinDate(dateOne As Date)
        Dim dateTwo = New Date.Now()

        ' dateOne is earlier than dateTwo
        If dateOne.CompareTo(dateTwo) < 0 Then
            Return dateTwo
        Else
            Return dateOne
        End If
    End Function

    ' ----------------------
    ' --- Calendar Month ---
    ' ----------------------
    Public Sub DayClicked(day As Integer, curCtrl As CalendarMonthControl)

        If (curCtrl Is Me.usrctrlStartMonth) Then
            Dim newDate = New Date(Me.startYear, Me.startMonth, day, Me.startHour, Me.startMinute, 0)
            Me.startTime = newDate
            Me.UpdateStartTimeVar()

            Me.showMonthsStart = False

            Me.btnDateStartSelect.Enabled = True
            Me.btnDateStartSelect.BackColor = colourNeutral

        End If

        Me.UpdateFormSize(-1)
        Me.UpdateLabels()
        Me.AddControls()
    End Sub

    Private Sub UpdateMonth(monthChange As Integer, time As String)
        If time = "start" Then
            Me.startTime = Me.startTime.AddMonths(monthChange)
            Me.UpdateStartTimeVar()

            Me.usrctrlStartMonth.SetMonth(Me.startTime)
            Me.lblStartMonth.Text = Format(Me.startTime, "MMMM yyyy")
        End If
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
            changedStartTime = True
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
            changedStartTime = True

        End If

        Me.UpdateLabels()
    End Sub

    ' -------------------
    ' --- Date Select ---
    ' -------------------
    Private Sub btnDateSelect_Click(sender As Object, e As EventArgs) Handles btnDateStartSelect.Click

        Dim btnCur = CType(sender, Button)

        If (btnCur Is btnDateStartSelect) Then
            Me.showMonthsStart = True
            Me.btnDateStartSelect.Enabled = False
            Me.btnDateStartSelect.BackColor = colourPressed

        End If

        Me.UpdateFormSize(1)
        Me.AddControls()
    End Sub

    Private Sub btnDateSelect_MouseEnter(sender As Object, e As EventArgs) Handles btnDateStartSelect.MouseEnter
        CType(sender, Button).BackColor = colourHover
    End Sub

    Private Sub btnDateSelect_MouseLeave(sender As Object, e As EventArgs) Handles btnDateStartSelect.MouseLeave
        CType(sender, Button).BackColor = colourNeutral
    End Sub

    ' -------------------------
    ' --- Month Arrow Click ---
    ' -------------------------
    Private Sub imgArrowRight_Click(sender As Object, e As EventArgs) Handles imgStartArrowRight.Click

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartArrowRight) Then
            Me.UpdateMonth(1, "start")
        End If
    End Sub

    Private Sub imgArrowLeft_Click(sender As Object, e As EventArgs) Handles imgStartArrowLeft.Click
        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartArrowLeft) Then
            Me.UpdateMonth(-1, "start")
        End If
    End Sub

    ' -------------------------
    ' --- Month Arrow Hover ---
    ' -------------------------
    Private Sub imgArrowRight_MouseEnter(sender As Object, e As EventArgs) Handles imgStartArrowRight.MouseEnter
        CType(sender, PictureBox).Image = My.Resources.ArrowRight___Hover
    End Sub

    Private Sub imgArrowRight_MouseLeave(sender As Object, e As EventArgs) Handles imgStartArrowRight.MouseLeave
        CType(sender, PictureBox).Image = My.Resources.ArrowRight
    End Sub

    Private Sub imgArrowLeft_MouseEnter(sender As Object, e As EventArgs) Handles imgStartArrowLeft.MouseEnter
        CType(sender, PictureBox).Image = My.Resources.ArrowLeft___Hover
    End Sub

    Private Sub imgArrowLeft_MouseLeave(sender As Object, e As EventArgs) Handles imgStartArrowLeft.MouseLeave, imgStartArrowLeft.MouseLeave
        CType(sender, PictureBox).Image = My.Resources.ArrowLeft
    End Sub

    ' ------------------------
    ' --- Time Arrow Click ---
    ' ------------------------

    Private Sub imgTime_Click(sender As Object, e As EventArgs) Handles _
        imgStartHourUp.Click, imgStartMinuteUp.Click, imgStartHourDown.Click,
        imgStartMinuteDown.Click, imgStartAmPmUp.Click, imgStartAmPmDown.Click

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
                Me.UpdateHour(hourChng, "start")

            ElseIf (imgCur Is imgStartMinuteUp) Then
                Me.UpdateMinute(minChng, "start")

            ElseIf (imgCur Is imgStartHourDown) Then
                Me.UpdateHour(-hourChng, "start")

            ElseIf (imgCur Is imgStartMinuteDown) Then
                Me.UpdateMinute(-minChng, "start")

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

    ' -------------------
    ' --- Now Button ---
    ' -------------------

    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
        Me.startTime = New Date.Now()
        Me.UpdateStartTimeVar()
        Me.UpdateLabels()
    End Sub

    ' -------------------
    ' --- Next Button ---
    ' -------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim errorMsg = ""

        ' Singular loop to get out of, if match condition
        For x As Integer = 0 To 1

            ' Start time passed
            If startTime.CompareTo(New Date.Now()) < 0 Then
                errorMsg = "Error: Start time has already passed"
                Exit For
            End If

        Next

        ' If error
        If (errorMsg <> "") Then
            Me.ShakeErrorMessage(errorMsg)
            Exit Sub
        End If

        'If not error
        Me.previousForm.NextClicked(startTime)

    End Sub

    Private Sub btnNext_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        CType(sender, Button).BackColor = colourHover
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        CType(sender, Button).BackColor = colourNeutral
    End Sub

    ' -------------
    ' --- Shake ---
    ' -------------
    Private Sub ShakeErrorMessage(errorText As String)
        Me.lblError.Text = errorText
        Me.lblError.Visible = True
        Me.lblError.BringToFront()
        If Me.backgroundWorker.IsBusy() = False Then
            Me.lblError.Location = New Point((Me.previousForm.Width / 2) - (Me.lblError.Width / 2) - 18, Me.lblError.Top)
            Me.backgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker.DoWork
        ''                 |           plus           |                 minus                 |                 minus                 |            plus             |
        ''                 1, 2, 3, 4, 5, 6, 7, 8, 9,10,  9,  8,  7,  6,  5,  4,  3,  2,  1,  0, -1, -2, -3, -4, -5, -6, -7, -8, -9,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1, 0
        'Dim shakeArr() = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        'Dim shakeArr() = {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}
        'Dim shakeArr() = {3, 3, 3, 3, 3, 3, 3, 3, 3, 3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, -3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}
        'Dim shakeArr() = {5, -5, 5, -5, 5, -5, 5, -5, 5, -5, 5, -5, 5, -5, 5, -5}
        'Dim shakeArr() = {10, -10, 10, -10, 10, -10, 10, -10, 10, -10, 10, -10, 10, -10, 10, -10}
        'Dim shakeArr() = {25, -25, 25, -25, 25, -25, 25, -25, 25, -25, 25, -25, 25, -25, 25, -25}
        ''                 |    plus    |       minus       |       minus       |     plus     |
        ''                  2  4  6  8  10  8   6   4   2   0  -2  -4  -6  -8  -10-8 -6 -4  -2 0
        ''                 1  3  5  7  9   9   7   5   3   1  -1  -3  -5  -7  -9 -9 -7,-5,-3,-1,
        'Dim shakeArr() = {2, 2, 2, 2, 2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, 2, 2, 2, 2, 2}
        Dim shakeArr() = {1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1}

        Try
            ' Shake
            For fullShake As Integer = 0 To 3
                For moveIndex As Integer = 0 To shakeArr.Length() - 1
                    'Move
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() lblError.Left += shakeArr(moveIndex)) _
                    Else lblError.Left += shakeArr(moveIndex)

                    'Wait
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                    Else Me.lblError.Refresh()
                    Threading.Thread.Sleep(10)
                Next
            Next

            ' Pause
            For pause As Integer = 0 To 150
                'Wait
                If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                Else Me.lblError.Refresh()
                Threading.Thread.Sleep(10)
            Next

            If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Visible = False) _
            Else Me.lblError.Visible = False
        Catch ex As Exception
        End Try

    End Sub

End Class
