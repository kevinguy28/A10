Public Class CalendarMonthControl

    Dim currMonth As Date
    Dim minDay As Date

    Dim month As Integer
    Dim year As Integer = -1

    Dim todayLabel As Label
    Dim weekLables As Label()
    Dim dayLabels As Label()

    Dim monthForm As CalendarForm
    Dim bookingForm As CalendarBookingControl
    Dim schedulingForm As CalendarSchedulingControl


    Private Sub CalendarMonthControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Days of the Week
        If Me.weekLables Is Nothing Then Me.CreateWeekArray()
        For Each weekLbl As Label In Me.weekLables
            weekLbl.BackColor = Color.FromArgb(151, 203, 197)
            weekLbl.ForeColor = Color.White
        Next

        ' Properties
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.MinimumSize = New Size(10, 10)


    End Sub

    ' -------------
    ' --- Setup ---
    ' -------------
    Public Sub SetMonthForm(newForm As CalendarForm)
        Me.monthForm = newForm
    End Sub

    Public Sub SetBookingForm(newForm As CalendarBookingControl)
        Me.bookingForm = newForm
    End Sub

    Public Sub SetSchedulingForm(newform As CalendarSchedulingControl)
        Me.schedulingForm = newform
    End Sub

    Public Sub SetMin(newMin As Date)
        Me.minDay = newMin

        ' If currMonth set
        If Me.year > -1 Then
            Me.SetMonth(Me.currMonth)
        End If
    End Sub

    Public Sub SetMonth(newMonth As Date)
        Me.currMonth = newMonth
        Me.month = Me.currMonth.Month
        Me.year = Me.currMonth.Year

        If Me.dayLabels Is Nothing Then Me.CreateLabelArray()
        Me.LabelSetBlank()
        Me.LabelSetDays()
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub CreateWeekArray()
        Me.weekLables = New Label() {Me.lblSunday, Me.lblMonday,
            Me.lblTuesday, Me.lblWednesday, Me.lblThursday,
            Me.lblFriday, Me.lblSaturday}
    End Sub
    Private Sub CreateLabelArray()
        ' DayLabels
        Me.dayLabels = {
            Me.lblOneOne, Me.lblOneTwo, Me.lblOneThree, Me.lblOneFour, Me.lblOneFive, Me.lblOneSix, Me.lblOneSeven,
            Me.lblTwoOne, Me.lblTwoTwo, Me.lblTwoThree, Me.lblTwoFour, Me.lblTwoFive, Me.lblTwoSix, Me.lblTwoSeven,
            Me.lblThreeOne, Me.lblThreeTwo, Me.lblThreeThree, Me.lblThreeFour, Me.lblThreeFive, Me.lblThreeSix, Me.lblThreeSeven,
            Me.lblFourOne, Me.lblFourTwo, Me.lblFourThree, Me.lblFourFour, Me.lblFourFive, Me.lblFourSix, Me.lblFourSeven,
            Me.lblFiveOne, Me.lblFiveTwo, Me.lblFiveThree, Me.lblFiveFour, Me.lblFiveFive, Me.lblFiveSix, Me.lblFiveSeven,
            Me.lblSixOne, Me.lblSixTwo, Me.lblSixThree, Me.lblSixFour, Me.lblSixFive, Me.lblSixSix, Me.lblSixSeven
        }
    End Sub

    Private Sub LabelSetBlank()
        Me.todayLabel = Nothing
        For Each lblDay As Label In Me.dayLabels
            lblDay.Enabled = False
            lblDay.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            lblDay.BackColor = Color.White
            lblDay.Text = ""
        Next
    End Sub

    Private Sub LabelSetDays()

        Dim dayOne = New Date(Me.currMonth.Year, Me.currMonth.Month, 1, 0, 0, 0)

        Dim startIndex As Integer = dayOne.DayOfWeek()
        Dim endIndex As Integer = (Date.DaysInMonth(2022, Me.month) - 1) + startIndex

        Dim today As Date
        today = Date.Now()

        Dim day As Integer = 1
        For index As Integer = startIndex To endIndex
            Dim currLabel = Me.dayLabels(index)

            ' Check if more then minDay
            Dim currDay = New Date(Me.year, Me.month, day, 23, 59, 59)
            ' -Num = curDay earlier than minDay
            '    0 = curDay same      as minDay
            ' +Num = curDay later   than minDay

            ' currDay is earlier than minDay, grey out
            If currDay.CompareTo(Me.minDay) < 0 Then
                currLabel.ForeColor = Color.Gray

            Else
                ' Else, enable
                currLabel.Enabled = True

            End If
            currLabel.Text = day.ToString()

            ' If today, then make background blue
            If (today.Month = Me.month) And (today.Day = day) And (today.Year = Me.year) Then
                Me.todayLabel = currLabel
                Me.todayLabel.BackColor = Color.FromArgb(151, 203, 197)
            End If

            day += 1
        Next

    End Sub

    ' -----------------------
    ' --- Day Label Hover ---
    ' -----------------------
    Private Sub lblDays_MouseEnter(sender As Object, e As EventArgs) Handles _
        lblOneOne.MouseEnter, lblOneTwo.MouseEnter, lblOneThree.MouseEnter, lblOneFour.MouseEnter, lblOneFive.MouseEnter, lblOneSix.MouseEnter, lblOneSeven.MouseEnter,
        lblTwoOne.MouseEnter, lblTwoTwo.MouseEnter, lblTwoThree.MouseEnter, lblTwoFour.MouseEnter, lblTwoFive.MouseEnter, lblTwoSix.MouseEnter, lblTwoSeven.MouseEnter,
        lblThreeOne.MouseEnter, lblThreeTwo.MouseEnter, lblThreeThree.MouseEnter, lblThreeFour.MouseEnter, lblThreeFive.MouseEnter, lblThreeSix.MouseEnter, lblThreeSeven.MouseEnter,
        lblFourOne.MouseEnter, lblFourTwo.MouseEnter, lblFourThree.MouseEnter, lblFourFour.MouseEnter, lblFourFive.MouseEnter, lblFourSix.MouseEnter, lblFourSeven.MouseEnter,
        lblFiveOne.MouseEnter, lblFiveTwo.MouseEnter, lblFiveThree.MouseEnter, lblFiveFour.MouseEnter, lblFiveFive.MouseEnter, lblFiveSix.MouseEnter, lblFiveSeven.MouseEnter,
        lblSixOne.MouseEnter, lblSixTwo.MouseEnter, lblSixThree.MouseEnter, lblSixFour.MouseEnter, lblSixFive.MouseEnter, lblSixSix.MouseEnter, lblSixSeven.MouseEnter

        CType(sender, Label).BackColor = Color.FromArgb(127, 242, 229)
    End Sub

    Private Sub lblDays_MouseLeave(sender As Object, e As EventArgs) Handles _
        lblOneOne.MouseLeave, lblOneTwo.MouseLeave, lblOneThree.MouseLeave, lblOneFour.MouseLeave, lblOneFive.MouseLeave, lblOneSix.MouseLeave, lblOneSeven.MouseLeave,
        lblTwoOne.MouseLeave, lblTwoTwo.MouseLeave, lblTwoThree.MouseLeave, lblTwoFour.MouseLeave, lblTwoFive.MouseLeave, lblTwoSix.MouseLeave, lblTwoSeven.MouseLeave,
        lblThreeOne.MouseLeave, lblThreeTwo.MouseLeave, lblThreeThree.MouseLeave, lblThreeFour.MouseLeave, lblThreeFive.MouseLeave, lblThreeSix.MouseLeave, lblThreeSeven.MouseLeave,
        lblFourOne.MouseLeave, lblFourTwo.MouseLeave, lblFourThree.MouseLeave, lblFourFour.MouseLeave, lblFourFive.MouseLeave, lblFourSix.MouseLeave, lblFourSeven.MouseLeave,
        lblFiveOne.MouseLeave, lblFiveTwo.MouseLeave, lblFiveThree.MouseLeave, lblFiveFour.MouseLeave, lblFiveFive.MouseLeave, lblFiveSix.MouseLeave, lblFiveSeven.MouseLeave,
        lblSixOne.MouseLeave, lblSixTwo.MouseLeave, lblSixThree.MouseLeave, lblSixFour.MouseLeave, lblSixFive.MouseLeave, lblSixSix.MouseLeave, lblSixSeven.MouseLeave

        If sender Is todayLabel Then
            CType(sender, Label).BackColor = Color.FromArgb(151, 203, 197)
        Else
            CType(sender, Label).BackColor = Color.White
        End If

    End Sub

    ' -----------------------
    ' --- Day Label Click ---
    ' -----------------------

    Private Sub lblDays_Click(sender As Object, e As EventArgs) Handles _
        lblOneOne.Click, lblOneTwo.Click, lblOneThree.Click, lblOneFour.Click, lblOneFive.Click, lblOneSix.Click, lblOneSeven.Click,
        lblTwoOne.Click, lblTwoTwo.Click, lblTwoThree.Click, lblTwoFour.Click, lblTwoFive.Click, lblTwoSix.Click, lblTwoSeven.Click,
        lblThreeOne.Click, lblThreeTwo.Click, lblThreeThree.Click, lblThreeFour.Click, lblThreeFive.Click, lblThreeSix.Click, lblThreeSeven.Click,
        lblFourOne.Click, lblFourTwo.Click, lblFourThree.Click, lblFourFour.Click, lblFourFive.Click, lblFourSix.Click, lblFourSeven.Click,
        lblFiveOne.Click, lblFiveTwo.Click, lblFiveThree.Click, lblFiveFour.Click, lblFiveFive.Click, lblFiveSix.Click, lblFiveSeven.Click,
        lblSixOne.Click, lblSixTwo.Click, lblSixThree.Click, lblSixFour.Click, lblSixFive.Click, lblSixSix.Click, lblSixSeven.Click

        If Me.monthForm IsNot Nothing Then
            Me.monthForm.DayClicked(CType(sender, Label).Text)
        ElseIf Me.bookingForm IsNot Nothing Then
            Me.bookingForm.DayClicked(CType(sender, Label).Text, Me)
        ElseIf Me.schedulingForm IsNot Nothing Then
            Me.schedulingForm.DayClicked(CType(sender, Label).Text, Me)
        End If

    End Sub

    ' --------------
    ' --- Resize ---
    ' --------------

    Private Sub CalendarMonthControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.imgMonth.Size = Me.Size

        If Me.weekLables Is Nothing Then Me.CreateWeekArray()
        If Me.dayLabels Is Nothing Then Me.CreateLabelArray()

        Dim origWidth = 390
        Dim origHeight = 405
        Dim ratioWidth = Me.Width / origWidth
        Dim ratioHeight = Me.Height / origHeight

        Dim newFont = New Font("Segoe UI", 18 - 1)

        For Each weekLbl As Label In Me.weekLables
            weekLbl.Size = New Size(Math.Ceiling(weekLbl.Width * ratioWidth), Math.Ceiling(weekLbl.Height * ratioHeight))
            weekLbl.Location = New Point(Math.Floor(weekLbl.Left * ratioWidth), Math.Floor(weekLbl.Top * ratioHeight))
        Next

        For Each dayLbl As Label In Me.dayLabels
            dayLbl.Font = newFont
            dayLbl.Size = New Size(Math.Ceiling(dayLbl.Width * ratioWidth), Math.Floor(dayLbl.Height * ratioHeight))
            dayLbl.Location = New Point(Math.Floor(dayLbl.Left * ratioWidth), Math.Floor(dayLbl.Top * ratioHeight))
        Next
    End Sub
End Class
