Public Class CalendarMonthControl

    Dim month As String
    Dim monthInt As Integer
    Dim todayLabel As Label
    Dim dayLabels As Label()

    Dim monthForm As CalendarForm
    Dim dayForm As CalendarDayForm

    Private Sub CalendarMonthControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Days of the Week
        Dim daysOfTheWeekLabel = New Label() {Me.lblSunday, Me.lblMonday,
            Me.lblTuesday, Me.lblWednesday, Me.lblThursday,
            Me.lblFriday, Me.lblSaturday}
        For Each weekLbl As Label In daysOfTheWeekLabel
            weekLbl.BackColor = Color.FromArgb(151, 203, 197)
            weekLbl.ForeColor = Color.White
        Next

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

    Public Sub SetMonth(newMonth As String)
        Me.month = newMonth
        Me.LabelSetBlank()
        Me.LabelSetDays()
    End Sub

    Public Sub SetMonthForm(newForm As CalendarForm)
        Me.monthForm = newForm
    End Sub

    Private Sub LabelSetBlank()
        Me.todayLabel = Nothing
        For Each lblDay As Label In Me.dayLabels
            lblDay.Enabled = False
            lblDay.BackColor = Color.White
            lblDay.Text = ""
        Next
    End Sub

    Private Sub LabelSetDays()
        If Me.month = "November" Then
            Me.monthInt = 11
        ElseIf Me.month = "December" Then
            Me.monthInt = 12
        End If

        Dim dateOne As Date
        dateOne = New Date(2022, Me.monthInt, 1, 0, 0, 0)

        Dim startIndex As Integer = dateOne.DayOfWeek()
        Dim endIndex As Integer = (Date.DaysInMonth(2022, Me.monthInt) - 1) + startIndex

        Dim today As Date
        today = Date.Now()

        Dim day As Integer = 1
        For index As Integer = startIndex To endIndex
            Me.dayLabels(index).Enabled = True
            Me.dayLabels(index).Text = day.ToString()

            ' If today, then make background blue
            If (today.Month = Me.monthInt) And (today.Day = day) Then
                Me.todayLabel = Me.dayLabels(index)
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

        Me.monthForm.DayClicked(CType(sender, Label).Text)

    End Sub


End Class
