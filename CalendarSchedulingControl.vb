Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class CalendarSchedulingControl

    Dim previousForm As CalendarSchedulingForm

    Dim startTime As Date
    Dim endTime As Date
    Dim repeatTime As Date

    Dim changedStartTime = False
    Dim changedEndTime = False
    Dim changedRepeatTime = False

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

    Dim repeatMinute As Integer
    Dim repeatHour As Integer
    Dim repeatDay As Integer
    Dim repeatMonth As Integer
    Dim repeatYear As Integer

    ' Scroll
    Dim vScroll = 0

    ' Height Change
    Dim addedHeight = 472

    ' Border Change
    Dim bdrTopHghtChanged = False
    Dim bdrBotHghtChanged = False
    Dim bdrBotPosnChanged = False
    Dim bdrRptHghtChangedOne = False
    Dim bdrRptPosnChangedOne = False
    Dim bdrRptHghtChanged = False
    Dim bdrRptPosnChangedTwo = False

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

    Dim lblLocationStartPrompt As Label
    Dim WithEvents cmbxLocationStart As ComboBox

    Dim lblStartConfirmPrompt As Label
    Dim lblStartConfirmDate As Label

    ' --- End ---
    Dim lblEnd As Label

    Dim lblDateEndPrompt As Label
    Dim txtDateEnd As TextBox
    Dim WithEvents btnDateEndSelect As Button

    Dim lblTimeEndPrompt As Label
    Dim lblHourEnd As Label
    Dim lblMinuteEnd As Label
    Dim lblAmPmEnd As Label
    Dim lblEndTimeColon As Label

    Dim WithEvents imgEndHourUp As PictureBox
    Dim WithEvents imgEndMinuteUp As PictureBox
    Dim WithEvents imgEndHourDown As PictureBox
    Dim WithEvents imgEndMinuteDown As PictureBox
    Dim WithEvents imgEndAmPmUp As PictureBox
    Dim WithEvents imgEndAmPmDown As PictureBox

    Dim lblLocationEndPrompt As Label
    Dim WithEvents cmbxLocationEnd As ComboBox

    Dim lblEndConfirmPrompt As Label
    Dim lblEndConfirmDate As Label

    ' --- Repeat ---
    Dim lblRepeat As Label

    Dim lblTypeRepeatPrompt As Label
    Dim WithEvents cmbxTypeRepeat As ComboBox
    Dim lblDateRepeatPrompt As Label
    Dim txtDateRepeat As TextBox
    Dim WithEvents btnDateRepeatSelect As Button

    Dim lblRepeatConfirmPrompt As Label
    Dim lblRepeatConfirmDate As Label

    ' --- Start Month ---
    Dim showMonthsStart As Boolean
    Dim lblStartMonth As Label
    Dim WithEvents imgStartArrowLeft As PictureBox
    Dim WithEvents imgStartArrowRight As PictureBox
    Dim usrctrlStartMonth As CalendarMonthControl

    ' --- End Month ----
    Dim showMonthsEnd As Boolean
    Dim lblEndMonth As Label
    Dim WithEvents imgEndArrowLeft As PictureBox
    Dim WithEvents imgEndArrowRight As PictureBox
    Dim usrctrlEndMonth As CalendarMonthControl

    ' --- Repeat Month ----
    Dim showMonthsRepeat As Boolean
    Dim lblRepeatMonth As Label
    Dim WithEvents imgRepeatArrowLeft As PictureBox
    Dim WithEvents imgRepeatArrowRight As PictureBox
    Dim usrctrlRepeatMonth As CalendarMonthControl

    ' --- Next ---
    Dim WithEvents btnNext As Button


    Private Sub CalendarSchedulingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vertical scroll bar is around 25 pixels
        ' Form white area is 435, 632 pixels
        ' User Control width - scroll bar (to make space for it) = 410
        Me.showMonthsStart = False
        Me.showMonthsEnd = False

        ' Background Worker
        Me.backgroundWorker = New BackgroundWorker()
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Sub Setup(currTime As Date, trigger As String, previousForm As CalendarSchedulingForm, userEvent As UserCalendarEvent)
        Me.flPanel.Location = New Point(0, 0)
        Me.flPanel.Size = New Size(410, 868)

        Dim initialAddedHeight = 755
        Me.Height = Me.Height + initialAddedHeight
        Me.flPanel.Height = Me.flPanel.Height + initialAddedHeight

        Me.previousForm = previousForm
        Me.lblError = Me.previousForm.GetLblError()

        If userEvent Is Nothing Then
            Me.startTime = currTime
            Me.endTime = Me.startTime.AddHours(1)
        Else
            Me.startTime = userEvent.GetStartDate
            Me.endTime = userEvent.GetEndDate
            Me.changedEndTime = True
        End If

        Me.startMinute = 0
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year

        Me.endMinute = 0
        Me.endMonth = Me.startTime.Month
        Me.endYear = Me.startTime.Year

        If (trigger = "MonthPlus") Then
            Me.startHour = 0
            Me.startDay = 1
            Me.endHour = 1
            Me.endDay = 1
        ElseIf (trigger = "DayPlus") Then
            Me.startHour = 0
            Me.startDay = Me.startTime.Day
            Me.endHour = 1
            Me.endDay = Me.startTime.Day
        ElseIf (trigger = "DaySlot") Then
            Me.startHour = Me.startTime.Hour
            Me.startDay = Me.startTime.Day
            Me.endHour = Me.endTime.Hour
            Me.endDay = Me.endTime.Day
        End If

        Me.repeatTime = Me.endTime.AddDays(7)
        Me.UpdateRepeatTimeVar()

        Me.CreateStart()
        Me.CreateEnd()
        Me.CreateRepeat()
        Me.CreateStartMonths()
        Me.CreateEndMonths()
        Me.CreateRepeatMonths()
        Me.CreateNext()
        Me.AddControls()

        ' Border
        Dim borderSize = New Size(10, 510)
        Dim borderRepeatSize = New Size(10, 292)
        Dim top = 50
        Dim btm = 610
        Dim rpt = 1170
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

        Me.lblEndLeft.BringToFront()
        Me.lblEndLeft.BackColor = colourNeutral
        Me.lblEndLeft.Location = New Point(lft, btm)
        Me.lblEndLeft.Size = borderSize

        Me.lblEndRight.BringToFront()
        Me.lblEndRight.BackColor = colourNeutral
        Me.lblEndRight.Location = New Point(rgt, btm)
        Me.lblEndRight.Size = borderSize

        Me.lblRepeatLeft.BringToFront()
        Me.lblRepeatLeft.BackColor = colourNeutral
        Me.lblRepeatLeft.Location = New Point(lft, rpt)
        Me.lblRepeatLeft.Size = borderRepeatSize

        Me.lblRepeatRight.BringToFront()
        Me.lblRepeatRight.BackColor = colourNeutral
        Me.lblRepeatRight.Location = New Point(rgt, rpt)
        Me.lblRepeatRight.Size = borderRepeatSize


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
        Me.lblDateStartPrompt.Text = "Select the start date of your car availability:"
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
        Me.lblTimeStartPrompt.Text = "Select the start time of your car availability:"
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

        ' --- Location ---

        Me.lblLocationStartPrompt = New Label
        Me.lblLocationStartPrompt.Text = "Select the start location of your car:"
        Me.lblLocationStartPrompt.Font = bodyFont
        Me.lblLocationStartPrompt.AutoSize = True
        Me.lblLocationStartPrompt.Margin = leftPadding

        Me.cmbxLocationStart = New ComboBox
        Me.cmbxLocationStart.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbxLocationStart.Font = bodyFont
        Me.cmbxLocationStart.Width = 320 - txtPad - txtBor
        Me.cmbxLocationStart.Margin = New Padding(25 + txtPad, 5, 0, 10)
        Me.cmbxLocationStart.Items.Add("CN Tower")
        Me.cmbxLocationStart.Items.Add("Toronto Metropolitan University")
        Me.cmbxLocationStart.Items.Add("Union Station")
        Me.cmbxLocationStart.Items.Add("University of Toronto")
        Me.cmbxLocationStart.Text = "CN Tower"

        ' --- Confirm ---

        ' lblStartConfirmPrompt
        Me.lblStartConfirmPrompt = New Label
        Me.lblStartConfirmPrompt.Text = "Your availability will start on"
        Me.lblStartConfirmPrompt.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartConfirmPrompt.Font = bodyFont
        Me.lblStartConfirmPrompt.Size = New Size(Me.Width, 24)
        Me.lblStartConfirmPrompt.AutoSize = False
        Me.lblStartConfirmPrompt.Margin = noPadding

        ' lblStartConfirmDate
        Me.lblStartConfirmDate = New Label
        Me.lblStartConfirmDate.Text = Format(Me.startTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.startTime, "h:mm tt") & vbCrLf & "at " & cmbxLocationStart.Text
        Me.lblStartConfirmDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblStartConfirmDate.Font = bodyBoldFont
        Me.lblStartConfirmDate.Size = New Size(Me.Width - 40, 90)
        Me.lblStartConfirmDate.AutoSize = False
        Me.lblStartConfirmDate.Margin = New Padding(leftPadding.Left / 2, 0, 0, 0)
        Me.lblStartConfirmDate.BackColor = colourNeutral
        Me.lblStartConfirmDate.ForeColor = Color.White

    End Sub

    Private Sub CreateEnd()
        ' lblEnd
        Me.lblEnd = New Label()
        Me.lblEnd.Text = "End"
        Me.lblEnd.TextAlign = headingTextAlign
        Me.lblEnd.Font = headingFont
        Me.lblEnd.Size = headingSize
        Me.lblEnd.AutoSize = False
        Me.lblEnd.Margin = headingPadding
        Me.lblEnd.BackColor = colourNeutral
        Me.lblEnd.ForeColor = colourWhite

        ' --- Date ---
        Dim txtPad = 5
        Dim txtBor = 15

        ' lblDateEndPrompt
        Me.lblDateEndPrompt = New Label
        Me.lblDateEndPrompt.Text = "Select the end date of your car availability:"
        Me.lblDateEndPrompt.Font = bodyFont
        Me.lblDateEndPrompt.AutoSize = True
        Me.lblDateEndPrompt.Margin = leftPadding

        ' txtDateEnd
        Me.txtDateEnd = New TextBox
        Me.txtDateEnd.Multiline = False
        Me.txtDateEnd.Enabled = False
        Me.txtDateEnd.Font = bodyFont
        Me.txtDateEnd.Width = 300 - txtPad - txtBor
        Me.txtDateEnd.Text = Format(Me.endTime, "dddd d MMMM yyyy")
        Me.txtDateEnd.Margin = New Padding(25 + txtPad, 5, 0, 5)

        ' btnDateEndSelect
        Me.btnDateEndSelect = New Button
        Me.btnDateEndSelect.Text = "Select"
        Me.btnDateEndSelect.Font = bodyFont
        Me.btnDateEndSelect.Height = Me.txtDateEnd.Height
        Me.btnDateEndSelect.BackColor = colourNeutral
        Me.btnDateEndSelect.ForeColor = Color.White
        Me.btnDateEndSelect.TabStop = False
        Me.btnDateEndSelect.FlatStyle = FlatStyle.Flat
        Me.btnDateEndSelect.FlatAppearance.BorderSize = 0
        Me.btnDateEndSelect.Margin = sidePadding

        ' --- Time: Labels ---

        ' lblTimeEndPrompt
        Me.lblTimeEndPrompt = New Label
        Me.lblTimeEndPrompt.Text = "Select the end time of your car availability:"
        Me.lblTimeEndPrompt.Font = bodyFont
        Me.lblTimeEndPrompt.AutoSize = True
        Me.lblTimeEndPrompt.Margin = leftPadding

        Dim left = 110

        ' lblHourEnd
        Me.lblHourEnd = New Label
        Me.lblHourEnd.Text = Format(Me.endTime, "hh")
        Me.lblHourEnd.TextAlign = ContentAlignment.MiddleCenter
        Me.lblHourEnd.Font = timeFont
        Me.lblHourEnd.Size = timeSize
        Me.lblHourEnd.AutoSize = False
        Me.lblHourEnd.Padding = noPadding
        Me.lblHourEnd.Margin = New Padding(left, 0, 0, 0)

        ' lblMinuteEnd
        Me.lblMinuteEnd = New Label
        Me.lblMinuteEnd.Text = Format(Me.endTime, "mm")
        Me.lblMinuteEnd.TextAlign = ContentAlignment.MiddleCenter
        Me.lblMinuteEnd.Font = timeFont
        Me.lblMinuteEnd.Size = timeSize
        Me.lblMinuteEnd.AutoSize = False
        Me.lblMinuteEnd.Padding = noPadding
        Me.lblMinuteEnd.Margin = noPadding

        ' lblAmPmEnd
        Me.lblAmPmEnd = New Label
        Me.lblAmPmEnd.Text = Format(Me.endTime, "tt").ToLower
        Me.lblAmPmEnd.TextAlign = ContentAlignment.MiddleCenter
        Me.lblAmPmEnd.Font = timeFont
        Me.lblAmPmEnd.Size = amPmSize
        Me.lblAmPmEnd.AutoSize = False
        Me.lblAmPmEnd.Padding = noPadding
        Me.lblAmPmEnd.Margin = New Padding(colonSize.Width - 5, 0, 0, 0)

        ' lblEndTimeColon
        Me.lblEndTimeColon = New Label
        Me.lblEndTimeColon.Text = ":"
        Me.lblEndTimeColon.TextAlign = ContentAlignment.MiddleCenter
        Me.lblEndTimeColon.Font = timeFont
        Me.lblEndTimeColon.Size = colonSize
        Me.lblEndTimeColon.AutoSize = False
        Me.lblEndTimeColon.Margin = noPadding

        ' --- Time: Arrows ---

        ' imgEndHourUp
        Me.imgEndHourUp = New PictureBox
        Me.imgEndHourUp.Size = New Size(45, 45)
        Me.imgEndHourUp.Image = My.Resources.arrow_up_neutral
        Me.imgEndHourUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndHourUp.Margin = New Padding(left + 5, 5, 0, 0)

        ' imgEndMinuteUp
        Me.imgEndMinuteUp = New PictureBox
        Me.imgEndMinuteUp.Size = New Size(45, 45)
        Me.imgEndMinuteUp.Image = My.Resources.arrow_up_neutral
        Me.imgEndMinuteUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndMinuteUp.Margin = New Padding(colonSize.Width + 10, 5, 0, 0)

        ' imgEndAmPmUp
        Me.imgEndAmPmUp = New PictureBox
        Me.imgEndAmPmUp.Size = New Size(45, 45)
        Me.imgEndAmPmUp.Image = My.Resources.arrow_up_neutral
        Me.imgEndAmPmUp.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndAmPmUp.Margin = New Padding(colonSize.Width + 10, 5, 0, 0)

        ' imgEndHourDown
        Me.imgEndHourDown = New PictureBox
        Me.imgEndHourDown.Size = New Size(45, 45)
        Me.imgEndHourDown.Image = My.Resources.arrow_down_neutral
        Me.imgEndHourDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndHourDown.Margin = New Padding(left + 5, 8, 0, 5)

        ' imgEndMinuteDown
        Me.imgEndMinuteDown = New PictureBox
        Me.imgEndMinuteDown.Size = New Size(45, 45)
        Me.imgEndMinuteDown.Image = My.Resources.arrow_down_neutral
        Me.imgEndMinuteDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndMinuteDown.Margin = New Padding(colonSize.Width + 10, 8, 0, 5)

        ' imgEndAmPmDown
        Me.imgEndAmPmDown = New PictureBox
        Me.imgEndAmPmDown.Size = New Size(45, 45)
        Me.imgEndAmPmDown.Image = My.Resources.arrow_down_neutral
        Me.imgEndAmPmDown.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndAmPmDown.Margin = New Padding(colonSize.Width + 10, 8, 0, 5)

        ' --- Location ---

        Me.lblLocationEndPrompt = New Label
        Me.lblLocationEndPrompt.Text = "Select the end location of your car:"
        Me.lblLocationEndPrompt.Font = bodyFont
        Me.lblLocationEndPrompt.AutoSize = True
        Me.lblLocationEndPrompt.Margin = leftPadding

        Me.cmbxLocationEnd = New ComboBox
        Me.cmbxLocationEnd.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbxLocationEnd.Font = bodyFont
        Me.cmbxLocationEnd.Width = 320 - txtPad - txtBor
        Me.cmbxLocationEnd.Margin = New Padding(25 + txtPad, 5, 0, 10)
        Me.cmbxLocationEnd.Items.Add("CN Tower")
        Me.cmbxLocationEnd.Items.Add("Toronto Metropolitan University")
        Me.cmbxLocationEnd.Items.Add("Union Station")
        Me.cmbxLocationEnd.Items.Add("University of Toronto")
        Me.cmbxLocationEnd.Text = "CN Tower"

        ' --- Confirm ---

        ' lblEndConfirmPrompt
        Me.lblEndConfirmPrompt = New Label
        Me.lblEndConfirmPrompt.Text = "Your availability will end on"
        Me.lblEndConfirmPrompt.TextAlign = ContentAlignment.MiddleCenter
        Me.lblEndConfirmPrompt.Font = bodyFont
        Me.lblEndConfirmPrompt.Size = New Size(Me.Width, 24)
        Me.lblEndConfirmPrompt.AutoSize = False
        Me.lblEndConfirmPrompt.Margin = noPadding

        ' lblEndConfirmDate
        Me.lblEndConfirmDate = New Label
        Me.lblEndConfirmDate.Text = Format(Me.endTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.endTime, "h:mm tt") & vbCrLf & "at " & cmbxLocationStart.Text
        Me.lblEndConfirmDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblEndConfirmDate.Font = bodyBoldFont
        Me.lblEndConfirmDate.Size = New Size(Me.Width - 40, 90)
        Me.lblEndConfirmDate.AutoSize = False
        Me.lblEndConfirmDate.Margin = New Padding(leftPadding.Left / 2, 0, 0, 0)
        Me.lblEndConfirmDate.BackColor = colourNeutral
        Me.lblEndConfirmDate.ForeColor = Color.White
    End Sub

    Private Sub CreateRepeat()
        ' lblRepeat
        Me.lblRepeat = New Label()
        Me.lblRepeat.Text = "Repeat"
        Me.lblRepeat.TextAlign = headingTextAlign
        Me.lblRepeat.Font = headingFont
        Me.lblRepeat.Size = headingSize
        Me.lblRepeat.AutoSize = False
        Me.lblRepeat.Margin = headingPadding
        Me.lblRepeat.BackColor = colourNeutral
        Me.lblRepeat.ForeColor = colourWhite

        ' --- Type ---
        Dim txtPad = 5
        Dim txtBor = 15

        ' lblTypeRepeatPrompt
        Me.lblTypeRepeatPrompt = New Label
        Me.lblTypeRepeatPrompt.Text = "Select the repeat of your car availability:"
        Me.lblTypeRepeatPrompt.Font = bodyFont
        Me.lblTypeRepeatPrompt.AutoSize = True
        Me.lblTypeRepeatPrompt.Margin = leftPadding

        ' cmbxTypeRepeat
        Me.cmbxTypeRepeat = New ComboBox
        Me.cmbxTypeRepeat.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbxTypeRepeat.Font = bodyFont
        Me.cmbxTypeRepeat.Width = 320 - txtPad - txtBor
        Me.cmbxTypeRepeat.Margin = New Padding(25 + txtPad, 5, 0, 10)
        Me.cmbxTypeRepeat.Items.Add("Never")
        Me.cmbxTypeRepeat.Items.Add("Daily")
        Me.cmbxTypeRepeat.Items.Add("Weekly")
        Me.cmbxTypeRepeat.Items.Add("Monthly")
        Me.cmbxTypeRepeat.Items.Add("Monday to Friday")
        Me.cmbxTypeRepeat.Items.Add("Saturday to Sunday")
        Me.cmbxTypeRepeat.SelectedItem = "Never"

        ' --- Date ---

        ' lblDateRepeatPrompt
        Me.lblDateRepeatPrompt = New Label
        Me.lblDateRepeatPrompt.Text = "Repeat until:"
        Me.lblDateRepeatPrompt.Font = bodyFont
        Me.lblDateRepeatPrompt.AutoSize = True
        Me.lblDateRepeatPrompt.Margin = leftPadding

        ' txtDateRepeat
        Me.txtDateRepeat = New TextBox
        Me.txtDateRepeat.Multiline = False
        Me.txtDateRepeat.Enabled = False
        Me.txtDateRepeat.Font = bodyFont
        Me.txtDateRepeat.Width = 300 - txtPad - txtBor
        Me.txtDateRepeat.Text = Format(Me.repeatTime, "dddd d MMMM yyyy")
        Me.txtDateRepeat.Margin = New Padding(25 + txtPad, 5, 0, 5)

        ' btnDateEndSelect
        Me.btnDateRepeatSelect = New Button
        Me.btnDateRepeatSelect.Text = "Select"
        Me.btnDateRepeatSelect.Font = bodyFont
        Me.btnDateRepeatSelect.Height = Me.txtDateEnd.Height
        Me.btnDateRepeatSelect.BackColor = colourNeutral
        Me.btnDateRepeatSelect.ForeColor = Color.White
        Me.btnDateRepeatSelect.TabStop = False
        Me.btnDateRepeatSelect.FlatStyle = FlatStyle.Flat
        Me.btnDateRepeatSelect.FlatAppearance.BorderSize = 0
        Me.btnDateRepeatSelect.Margin = sidePadding
        Me.btnDateRepeatSelect.Enabled = False

        ' --- Confirm ---

        ' lblRepeatConfirmPrompt
        Me.lblRepeatConfirmPrompt = New Label
        Me.lblRepeatConfirmPrompt.Text = "Your availability will repeat"
        Me.lblRepeatConfirmPrompt.TextAlign = ContentAlignment.MiddleCenter
        Me.lblRepeatConfirmPrompt.Font = bodyFont
        Me.lblRepeatConfirmPrompt.Size = New Size(Me.Width, 24)
        Me.lblRepeatConfirmPrompt.AutoSize = False
        Me.lblRepeatConfirmPrompt.Margin = noPadding

        ' lblRepeatConfirmDate
        Me.lblRepeatConfirmDate = New Label
        Me.lblRepeatConfirmDate.Text = cmbxTypeRepeat.Text & vbCrLf & "until " & Format(Me.repeatTime, "dddd d MMMM yyyy")
        Me.lblRepeatConfirmDate.TextAlign = ContentAlignment.MiddleCenter
        Me.lblRepeatConfirmDate.Font = bodyBoldFont
        Me.lblRepeatConfirmDate.Size = New Size(Me.Width - 40, 55)
        Me.lblRepeatConfirmDate.AutoSize = False
        Me.lblRepeatConfirmDate.Margin = New Padding(leftPadding.Left / 2, 0, 0, 0)
        Me.lblRepeatConfirmDate.BackColor = colourNeutral
        Me.lblRepeatConfirmDate.ForeColor = Color.White

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
        Me.usrctrlStartMonth.SetSchedulingForm(Me)
        Me.usrctrlStartMonth.SetMin(New Date.Now())
        Me.usrctrlStartMonth.SetMonth(Me.startTime)
        Me.usrctrlStartMonth.Margin = New Padding(28, 0, 0, 10)
        Me.usrctrlStartMonth.Size = New Size(Me.usrctrlStartMonth.Width - 28, Me.usrctrlStartMonth.Height - 28)

    End Sub

    Private Sub CreateEndMonths()
        '                          l, t, r, b
        Dim padding = New Padding(0, 20, 0, 20)
        Dim leftMonthPadding = New Padding(25, 20, 0, 20)

        ' imgEndArrowLeft
        Me.imgEndArrowLeft = New PictureBox
        Me.imgEndArrowLeft.Size = New Size(45, 45)
        Me.imgEndArrowLeft.Image = My.Resources.ArrowLeft
        Me.imgEndArrowLeft.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndArrowLeft.Margin = leftMonthPadding

        ' lblEndMonth
        Me.lblEndMonth = New Label
        Me.lblEndMonth.Text = Format(Me.endTime, "MMMM yyyy")
        Me.lblEndMonth.TextAlign = ContentAlignment.MiddleCenter
        Me.lblEndMonth.Font = headingFont
        Me.lblEndMonth.AutoSize = False
        Me.lblEndMonth.Size = New Size(410 - ((Me.imgEndArrowLeft.Width * 2) + 40), Me.imgEndArrowLeft.Height)
        Me.lblEndMonth.Margin = padding

        ' imgEndArrowRight
        Me.imgEndArrowRight = New PictureBox
        Me.imgEndArrowRight.Size = New Size(45, 45)
        Me.imgEndArrowRight.Image = My.Resources.ArrowRight
        Me.imgEndArrowRight.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgEndArrowRight.Margin = padding

        ' usrctrlEndMonth
        Me.usrctrlEndMonth = New CalendarMonthControl()
        Me.usrctrlEndMonth.SetSchedulingForm(Me)
        Me.usrctrlEndMonth.SetMin(New Date.Now().AddHours(1))
        Me.usrctrlEndMonth.SetMonth(Me.endTime)
        Me.usrctrlEndMonth.Margin = New Padding(28, 0, 0, 10)
        Me.usrctrlEndMonth.Size = New Size(Me.usrctrlEndMonth.Width - 28, Me.usrctrlEndMonth.Height - 28)
    End Sub

    Private Sub CreateRepeatMonths()
        '                          l, t, r, b
        Dim padding = New Padding(0, 20, 0, 20)
        Dim leftMonthPadding = New Padding(25, 20, 0, 20)

        ' imgRepeatArrowLeft
        Me.imgRepeatArrowLeft = New PictureBox
        Me.imgRepeatArrowLeft.Size = New Size(45, 45)
        Me.imgRepeatArrowLeft.Image = My.Resources.ArrowLeft
        Me.imgRepeatArrowLeft.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgRepeatArrowLeft.Margin = leftMonthPadding

        ' lblRepeatMonth
        Me.lblRepeatMonth = New Label
        Me.lblRepeatMonth.Text = Format(Me.repeatTime, "MMMM yyyy")
        Me.lblRepeatMonth.TextAlign = ContentAlignment.MiddleCenter
        Me.lblRepeatMonth.Font = headingFont
        Me.lblRepeatMonth.AutoSize = False
        Me.lblRepeatMonth.Size = New Size(410 - ((Me.imgRepeatArrowLeft.Width * 2) + 40), Me.imgRepeatArrowLeft.Height)
        Me.lblRepeatMonth.Margin = padding

        ' imgRepeatArrowRight
        Me.imgRepeatArrowRight = New PictureBox
        Me.imgRepeatArrowRight.Size = New Size(45, 45)
        Me.imgRepeatArrowRight.Image = My.Resources.ArrowRight
        Me.imgRepeatArrowRight.SizeMode = PictureBoxSizeMode.Zoom
        Me.imgRepeatArrowRight.Margin = padding

        ' usrctrlRepeatMonth
        Me.usrctrlRepeatMonth = New CalendarMonthControl()
        Me.usrctrlRepeatMonth.SetSchedulingForm(Me)
        Me.usrctrlRepeatMonth.SetMin(New Date.Now().AddHours(1).AddDays(1))
        Me.usrctrlRepeatMonth.SetMonth(Me.repeatTime)
        Me.usrctrlRepeatMonth.Margin = New Padding(28, 0, 0, 10)
        Me.usrctrlRepeatMonth.Size = New Size(Me.usrctrlRepeatMonth.Width - 28, Me.usrctrlRepeatMonth.Height - 28)
    End Sub

    Private Sub CreateNext()
        'btnNext
        Me.btnNext = New Button
        Me.btnNext.Text = "Schedule"
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

        'Scroll
        Dim vScroll = Me.VerticalScroll.Value

        Me.SuspendLayout()
        Me.flPanel.Controls.Clear()

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

        Me.flPanel.Controls.Add(Me.lblLocationStartPrompt)
        Me.flPanel.SetFlowBreak(Me.lblLocationStartPrompt, True)
        Me.flPanel.Controls.Add(Me.cmbxLocationStart)
        Me.flPanel.SetFlowBreak(Me.cmbxLocationStart, True)

        Me.flPanel.Controls.Add(Me.lblStartConfirmPrompt)
        Me.flPanel.SetFlowBreak(Me.lblStartConfirmPrompt, True)
        Me.flPanel.Controls.Add(Me.lblStartConfirmDate)
        Me.flPanel.SetFlowBreak(Me.lblStartConfirmDate, True)

        ' End: Month
        Me.flPanel.Controls.Add(Me.lblEnd)
        Me.flPanel.Controls.Add(Me.lblDateEndPrompt)
        Me.flPanel.SetFlowBreak(Me.lblDateEndPrompt, True)
        Me.flPanel.Controls.Add(Me.txtDateEnd)
        Me.flPanel.Controls.Add(Me.btnDateEndSelect)
        Me.flPanel.SetFlowBreak(Me.btnDateEndSelect, True)

        If showMonthsEnd Then
            Me.flPanel.Controls.Add(Me.imgEndArrowLeft)
            Me.flPanel.Controls.Add(Me.lblEndMonth)
            Me.flPanel.Controls.Add(Me.imgEndArrowRight)
            Me.flPanel.Controls.Add(Me.usrctrlEndMonth)
        End If

        ' End: Time
        Me.flPanel.Controls.Add(Me.lblTimeEndPrompt)
        Me.flPanel.SetFlowBreak(Me.lblTimeEndPrompt, True)

        Me.flPanel.Controls.Add(Me.imgEndHourUp)
        Me.flPanel.Controls.Add(Me.imgEndMinuteUp)
        Me.flPanel.Controls.Add(Me.imgEndAmPmUp)
        Me.flPanel.SetFlowBreak(Me.imgEndAmPmUp, True)

        Me.flPanel.Controls.Add(Me.lblHourEnd)
        Me.flPanel.Controls.Add(Me.lblEndTimeColon)
        Me.flPanel.Controls.Add(Me.lblMinuteEnd)
        Me.flPanel.Controls.Add(Me.lblAmPmEnd)
        Me.flPanel.SetFlowBreak(Me.lblAmPmEnd, True)

        Me.flPanel.Controls.Add(Me.imgEndHourDown)
        Me.flPanel.Controls.Add(Me.imgEndMinuteDown)
        Me.flPanel.Controls.Add(Me.imgEndAmPmDown)
        Me.flPanel.SetFlowBreak(Me.imgEndAmPmDown, True)

        Me.flPanel.Controls.Add(Me.lblLocationEndPrompt)
        Me.flPanel.SetFlowBreak(Me.lblLocationEndPrompt, True)
        Me.flPanel.Controls.Add(Me.cmbxLocationEnd)
        Me.flPanel.SetFlowBreak(Me.cmbxLocationEnd, True)

        Me.flPanel.Controls.Add(Me.lblEndConfirmPrompt)
        Me.flPanel.SetFlowBreak(Me.lblEndConfirmPrompt, True)
        Me.flPanel.Controls.Add(Me.lblEndConfirmDate)
        Me.flPanel.SetFlowBreak(Me.lblEndConfirmDate, True)

        ' Repeat
        Me.flPanel.Controls.Add(Me.lblRepeat)
        Me.flPanel.SetFlowBreak(Me.lblRepeat, True)

        Me.flPanel.Controls.Add(Me.lblTypeRepeatPrompt)
        Me.flPanel.SetFlowBreak(Me.lblTypeRepeatPrompt, True)
        Me.flPanel.Controls.Add(Me.cmbxTypeRepeat)
        Me.flPanel.SetFlowBreak(Me.cmbxTypeRepeat, True)

        Me.flPanel.Controls.Add(Me.lblDateRepeatPrompt)
        Me.flPanel.SetFlowBreak(Me.lblDateRepeatPrompt, True)
        Me.flPanel.Controls.Add(Me.txtDateRepeat)
        Me.flPanel.Controls.Add(Me.btnDateRepeatSelect)
        Me.flPanel.SetFlowBreak(Me.btnDateRepeatSelect, True)

        If showMonthsRepeat Then
            Me.flPanel.Controls.Add(Me.imgRepeatArrowLeft)
            Me.flPanel.Controls.Add(Me.lblRepeatMonth)
            Me.flPanel.Controls.Add(Me.imgRepeatArrowRight)
            Me.flPanel.Controls.Add(Me.usrctrlRepeatMonth)
        End If

        Me.flPanel.Controls.Add(Me.lblRepeatConfirmPrompt)
        Me.flPanel.SetFlowBreak(Me.lblRepeatConfirmPrompt, True)
        Me.flPanel.Controls.Add(Me.lblRepeatConfirmDate)
        Me.flPanel.SetFlowBreak(Me.lblRepeatConfirmDate, True)

        ' Next
        Me.flPanel.Controls.Add(Me.btnNext)

        'Scroll
        If Me.vScroll > Me.VerticalScroll.Maximum Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Maximum
        ElseIf Me.vScroll < Me.VerticalScroll.Minimum Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Minimum
        Else
            Me.VerticalScroll.Value = Me.vScroll
        End If

        Me.flPanel.ResumeLayout(True)
        Me.ResumeLayout(True)

    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------
    Private Sub UpdateFormSize(change As Integer)
        'Scroll
        Dim vScroll = Me.VerticalScroll.Value

        Dim changeHeight = addedHeight * change

        Me.Height += changeHeight
        Me.flPanel.Height += changeHeight

        Dim topHchanged = False
        Dim botPchanged = False
        Dim botHchanged = False
        Dim rptPchangedO = False
        Dim rptPchangedT = False
        Dim rptHchanged = False

        If showMonthsStart Then
            If Not bdrTopHghtChanged Then topHchanged = True
            If Not bdrBotPosnChanged Then botPchanged = True
            If Not bdrRptPosnChangedOne Then rptPchangedO = True
        Else
            If bdrTopHghtChanged Then topHchanged = True
            If bdrBotPosnChanged Then botPchanged = True
            If bdrRptPosnChangedOne Then rptPchangedO = True
        End If

        If showMonthsEnd Then
            If Not bdrBotHghtChanged Then botHchanged = True
            If Not bdrRptPosnChangedTwo Then rptPchangedT = True
        Else
            If bdrBotHghtChanged Then botHchanged = True
            If bdrRptPosnChangedTwo Then rptPchangedT = True
        End If

        If showMonthsRepeat Then
            If Not bdrRptHghtChanged Then rptHchanged = True
        Else
            If bdrRptHghtChanged Then rptHchanged = True
        End If

        'Top Height
        If topHchanged Then
            Me.lblStartLeft.Height += changeHeight
            Me.lblStartRight.Height += changeHeight
            bdrTopHghtChanged = Not bdrTopHghtChanged
        End If

        ' Bottom Position
        If botPchanged Then
            Me.lblEndLeft.Top += changeHeight
            Me.lblEndRight.Top += changeHeight
            bdrBotPosnChanged = Not bdrBotPosnChanged
        End If

        ' Bottom Height
        If botHchanged Then
            Me.lblEndLeft.Height += changeHeight
            Me.lblEndRight.Height += changeHeight
            bdrBotHghtChanged = Not bdrBotHghtChanged
        End If

        ' Repeat Position One
        If rptPchangedO Then
            Me.lblRepeatLeft.Top += changeHeight
            Me.lblRepeatRight.Top += changeHeight
            bdrRptPosnChangedOne = Not bdrRptPosnChangedOne
        End If

        ' Repeat Position Two
        If rptPchangedT Then
            Me.lblRepeatLeft.Top += changeHeight
            Me.lblRepeatRight.Top += changeHeight
            bdrRptPosnChangedTwo = Not bdrRptPosnChangedTwo
        End If

        ' Repeat Height
        If rptHchanged Then
            Me.lblRepeatLeft.Height += changeHeight
            Me.lblRepeatRight.Height += changeHeight
            bdrRptHghtChanged = Not bdrRptHghtChanged
        End If

        'Scroll
        If Me.vScroll > Me.VerticalScroll.Maximum Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Maximum
        ElseIf Me.vScroll < Me.VerticalScroll.Minimum Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Minimum
        Else
            Me.VerticalScroll.Value = Me.vScroll
        End If

    End Sub

    Private Sub UpdateStartTimeVar()
        Me.startMinute = Me.startTime.Minute
        Me.startHour = Me.startTime.Hour
        Me.startDay = Me.startTime.Day
        Me.startMonth = Me.startTime.Month
        Me.startYear = Me.startTime.Year
    End Sub

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

    Private Sub UpdateRepeatTimeVar()
        If changedRepeatTime = False Then
            Me.repeatTime = endTime.AddDays(7)
        End If
        Me.repeatMinute = Me.repeatTime.Minute
        Me.repeatHour = Me.repeatTime.Hour
        Me.repeatDay = Me.repeatTime.Day
        Me.repeatMonth = Me.repeatTime.Month
        Me.repeatYear = Me.repeatTime.Year
    End Sub

    Private Sub UpdateLabels()
        Me.txtDateStart.Text = Format(Me.startTime, "dddd d MMMM yyyy")
        Me.lblHourStart.Text = Format(Me.startTime, "hh")
        Me.lblMinuteStart.Text = Format(Me.startTime, "mm")
        Me.lblAmPmStart.Text = Format(Me.startTime, "tt").ToLower
        Me.lblStartConfirmDate.Text = Format(Me.startTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.startTime, "h:mm tt") & vbCrLf & "at " & Me.cmbxLocationStart.Text

        Me.txtDateEnd.Text = Format(Me.endTime, "dddd d MMMM yyyy")
        Me.lblHourEnd.Text = Format(Me.endTime, "hh")
        Me.lblMinuteEnd.Text = Format(Me.endTime, "mm")
        Me.lblAmPmEnd.Text = Format(Me.endTime, "tt").ToLower
        Me.lblEndConfirmDate.Text = Format(Me.endTime, "dddd d MMMM yyyy") & vbCrLf & "at " & Format(Me.endTime, "h:mm tt") & vbCrLf & "at " & cmbxLocationEnd.Text

        Me.txtDateRepeat.Text = Format(Me.repeatTime, "dddd d MMMM yyyy")
        Me.lblRepeatConfirmDate.Text = cmbxTypeRepeat.Text & vbCrLf & "until " & Format(Me.repeatTime, "dddd d MMMM yyyy")
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
            Me.UpdateEndTimeVar()

            Me.showMonthsStart = False
            Me.usrctrlEndMonth.SetMin(Me.GetMinDate(Me.startTime.AddHours(1)))

            Me.btnDateStartSelect.Enabled = True
            Me.btnDateStartSelect.BackColor = colourNeutral

        ElseIf (curCtrl Is Me.usrctrlEndMonth) Then
            Dim newDate = New Date(Me.endYear, Me.endMonth, day, Me.endHour, Me.endMinute, 0)
            Me.endTime = newDate
            Me.changedEndTime = True
            Me.UpdateEndTimeVar()
            Me.UpdateRepeatTimeVar()

            Me.showMonthsEnd = False
            Me.usrctrlRepeatMonth.SetMin(Me.GetMinDate(Me.endTime.AddDays(1)))

            Me.btnDateEndSelect.Enabled = True
            Me.btnDateEndSelect.BackColor = colourNeutral

        ElseIf (curCtrl Is Me.usrctrlRepeatMonth) Then
            Dim newDate = New Date(Me.repeatYear, Me.repeatMonth, day, Me.repeatHour, Me.repeatMinute, 0)
            Me.repeatTime = newDate
            Me.changedRepeatTime = True
            Me.UpdateRepeatTimeVar()

            Me.showMonthsRepeat = False

            Me.btnDateRepeatSelect.Enabled = True
            Me.btnDateRepeatSelect.BackColor = colourNeutral

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

        ElseIf time = "end" Then
            Me.changedEndTime = True
            Me.endTime = Me.endTime.AddMonths(monthChange)
            Me.UpdateEndTimeVar()

            Me.usrctrlEndMonth.SetMonth(Me.endTime)
            Me.lblEndMonth.Text = Format(Me.endTime, "MMMM yyyy")

        ElseIf time = "repeat" Then
            Me.changedRepeatTime = True
            Me.repeatTime = Me.repeatTime.AddMonths(monthChange)
            Me.UpdateRepeatTimeVar()

            Me.usrctrlRepeatMonth.SetMonth(Me.repeatTime)
            Me.lblRepeatMonth.Text = Format(Me.repeatTime, "MMMM yyyy")
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
            Me.usrctrlEndMonth.SetMin(Me.GetMinDate(Me.startTime.AddHours(1)))

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

    ' -------------------
    ' --- Date Select ---
    ' -------------------
    Private Sub btnDateSelect_Click(sender As Object, e As EventArgs) Handles btnDateStartSelect.Click, btnDateEndSelect.Click, btnDateRepeatSelect.Click

        Dim btnCur = CType(sender, Button)

        If (btnCur Is btnDateStartSelect) Then
            Me.showMonthsStart = True
            Me.btnDateStartSelect.Enabled = False
            Me.btnDateStartSelect.BackColor = colourPressed

        ElseIf (btnCur Is btnDateEndSelect) Then
            Me.showMonthsEnd = True
            Me.btnDateEndSelect.Enabled = False
            Me.btnDateEndSelect.BackColor = colourPressed

        ElseIf (btnCur Is btnDateRepeatSelect) Then
            Me.showMonthsRepeat = True
            Me.btnDateRepeatSelect.Enabled = False
            Me.btnDateRepeatSelect.BackColor = colourPressed

        End If

        Me.UpdateFormSize(1)
        Me.AddControls()
    End Sub

    Private Sub btnDateSelect_MouseEnter(sender As Object, e As EventArgs) Handles btnDateStartSelect.MouseEnter, btnDateEndSelect.MouseEnter
        CType(sender, Button).BackColor = colourHover
    End Sub

    Private Sub btnDateSelect_MouseLeave(sender As Object, e As EventArgs) Handles btnDateStartSelect.MouseLeave, btnDateEndSelect.MouseLeave
        CType(sender, Button).BackColor = colourNeutral
    End Sub

    ' -------------------------
    ' --- Month Arrow Click ---
    ' -------------------------
    Private Sub imgArrowRight_Click(sender As Object, e As EventArgs) Handles imgStartArrowRight.Click, imgEndArrowRight.Click, imgRepeatArrowRight.Click

        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartArrowRight) Then
            Me.UpdateMonth(1, "start")
        ElseIf (imgCur Is imgEndArrowRight) Then
            Me.UpdateMonth(1, "end")
        ElseIf (imgCur Is imgRepeatArrowRight) Then
            Me.UpdateMonth(1, "repeat")
        End If
    End Sub

    Private Sub imgArrowLeft_Click(sender As Object, e As EventArgs) Handles imgStartArrowLeft.Click, imgEndArrowLeft.Click, imgRepeatArrowLeft.Click
        Dim imgCur = CType(sender, PictureBox)

        If (imgCur Is imgStartArrowLeft) Then
            Me.UpdateMonth(-1, "start")
        ElseIf (imgCur Is imgEndArrowLeft) Then
            Me.UpdateMonth(-1, "end")
        ElseIf (imgCur Is imgRepeatArrowLeft) Then
            Me.UpdateMonth(-1, "repeat")
        End If
    End Sub

    ' -------------------------
    ' --- Month Arrow Hover ---
    ' -------------------------
    Private Sub imgArrowRight_MouseEnter(sender As Object, e As EventArgs) _
        Handles imgStartArrowRight.MouseEnter, imgEndArrowRight.MouseEnter, imgRepeatArrowRight.MouseEnter

        CType(sender, PictureBox).Image = My.Resources.ArrowRight___Hover
    End Sub

    Private Sub imgArrowRight_MouseLeave(sender As Object, e As EventArgs) _
        Handles imgStartArrowRight.MouseLeave, imgEndArrowRight.MouseLeave, imgRepeatArrowRight.MouseLeave

        CType(sender, PictureBox).Image = My.Resources.ArrowRight
    End Sub

    Private Sub imgArrowLeft_MouseEnter(sender As Object, e As EventArgs) _
        Handles imgStartArrowLeft.MouseEnter, imgEndArrowLeft.MouseEnter, imgRepeatArrowLeft.MouseEnter

        CType(sender, PictureBox).Image = My.Resources.ArrowLeft___Hover
    End Sub

    Private Sub imgArrowLeft_MouseLeave(sender As Object, e As EventArgs) _
        Handles imgStartArrowLeft.MouseLeave, imgStartArrowLeft.MouseLeave, imgRepeatArrowLeft.MouseLeave

        CType(sender, PictureBox).Image = My.Resources.ArrowLeft
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

    ' -------------------
    ' --- Next Button ---
    ' -------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim errorMsg = ""

        ' Singular loop to get out of, if match condition
        For x As Integer = 0 To 1

            ' End time before start time
            If endTime.CompareTo(Me.startTime) < 0 Then
                errorMsg = "Error: End time is before start time"
                Exit For
            End If

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
        Me.previousForm.NextClicked(startTime, endTime, Me.cmbxTypeRepeat.Text, Me.repeatTime, Me.cmbxLocationStart.Text, Me.cmbxLocationEnd.Text)

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

    ' -----------------
    ' --- Combo Box ---
    ' -----------------
    Private Sub cmbxLocation_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmbxLocationStart.SelectionChangeCommitted, cmbxLocationEnd.SelectionChangeCommitted, cmbxTypeRepeat.SelectionChangeCommitted
        If (Me.lblStartConfirmDate IsNot Nothing) AndAlso (Me.lblEndConfirmDate IsNot Nothing) Then
            Me.UpdateLabels()
        End If
    End Sub

    Private Sub cmbxDateRepeat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbxTypeRepeat.SelectionChangeCommitted
        If btnDateRepeatSelect IsNot Nothing Then
            If cmbxTypeRepeat.Text = "Never" Then
                Me.btnDateRepeatSelect.Enabled = False
            Else
                Me.btnDateRepeatSelect.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbxTypeRepeat_MouseWheel(sender As Object, e As MouseEventArgs) Handles cmbxLocationStart.MouseWheel, cmbxLocationEnd.MouseWheel, cmbxTypeRepeat.MouseWheel
        DirectCast(e, HandledMouseEventArgs).Handled = True
        CType(sender, ComboBox).DroppedDown = False
        If (Me.VerticalScroll.Value - e.Delta < Me.VerticalScroll.Minimum) Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Minimum
        ElseIf (Me.VerticalScroll.Value - e.Delta > Me.VerticalScroll.Maximum) Then
            Me.VerticalScroll.Value = Me.VerticalScroll.Maximum
        Else
            Me.VerticalScroll.Value -= e.Delta
        End If
        Me.vScroll = Me.VerticalScroll.Value
    End Sub

    Private Sub flPanel_MouseWheel(sender As Object, e As MouseEventArgs) Handles flPanel.MouseWheel
        Me.vScroll = Me.VerticalScroll.Value
    End Sub

    Private Sub flPanel_Scroll(sender As Object, e As ScrollEventArgs) Handles flPanel.Scroll
        Me.vScroll = Me.VerticalScroll.Value
    End Sub
End Class
