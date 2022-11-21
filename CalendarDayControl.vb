Public Class CalendarDayControl

    Dim previousForm As CalendarDayForm
    Dim timesLabels As Label()
    Dim currDay As Date
    Dim today As Date
    Dim isToday As Boolean = False

    Private Sub CalendarDayControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Times Label
        Me.timesLabels = {
            Me.lblSlot12am, Me.lblSlot1am, Me.lblSlot2am, Me.lblSlot3am,
            Me.lblSlot4am, Me.lblSlot5am, Me.lblSlot6am, Me.lblSlot7am,
            Me.lblSlot8am, Me.lblSlot9am, Me.lblSlot10am, Me.lblSlot11am,
            Me.lblSlot12pm, Me.lblSlot1pm, Me.lblSlot2pm, Me.lblSlot3pm,
            Me.lblSlot4pm, Me.lblSlot5pm, Me.lblSlot6pm, Me.lblSlot7pm,
            Me.lblSlot8pm, Me.lblSlot9pm, Me.lblSlot10pm, Me.lblSlot11pm
        }

    End Sub

    Public Sub SetParentForm(parentForm As CalendarDayForm)
        Me.previousForm = parentForm
    End Sub

    Public Sub SetDate(newDate As Date)
        Me.currDay = newDate

        ' Is selected date today
        today = New Date.Now()
        If (Me.today.Day = Me.currDay.Day) And
            (Me.today.Month = Me.currDay.Month) And
            (Me.today.Year = Me.currDay.Year) Then
            isToday = True
        End If

        ' If so, current time
        If isToday Then
            Me.timesLabels(today.Hour).BackColor = Color.FromArgb(151, 203, 197)
        End If
    End Sub

    'TimeSlotClicked

    ' -----------------------
    ' --- Day Label Click ---
    ' -----------------------

    Private Sub lblTimes_Click(sender As Object, e As EventArgs) Handles _
        lblSlot12am.Click, lblSlot1am.Click, lblSlot2am.Click, lblSlot3am.Click,
        lblSlot4am.Click, lblSlot5am.Click, lblSlot6am.Click, lblSlot7am.Click,
        lblSlot8am.Click, lblSlot9am.Click, lblSlot10am.Click, lblSlot11am.Click,
        lblSlot12pm.Click, lblSlot1pm.Click, lblSlot2pm.Click, lblSlot3pm.Click,
        lblSlot4pm.Click, lblSlot5pm.Click, lblSlot6pm.Click, lblSlot7pm.Click,
        lblSlot8pm.Click, lblSlot9pm.Click, lblSlot10pm.Click, lblSlot11pm.Click

        For index As Integer = 0 To Me.timesLabels.Length - 1

            If Me.timesLabels(index) Is sender Then
                Dim timeDate = New Date(Me.currDay.Year, Me.currDay.Month, Me.currDay.Day, index, 0, 0)
                Me.previousForm.TimeSlotClicked(timeDate)
                Exit For
            End If

        Next

    End Sub

    ' -----------------------
    ' --- Day Label Hover ---
    ' -----------------------
    Private Sub lblTimes_MouseEnter(sender As Object, e As EventArgs) Handles _
        lblSlot12am.MouseEnter, lblSlot1am.MouseEnter, lblSlot2am.MouseEnter, lblSlot3am.MouseEnter,
        lblSlot4am.MouseEnter, lblSlot5am.MouseEnter, lblSlot6am.MouseEnter, lblSlot7am.MouseEnter,
        lblSlot8am.MouseEnter, lblSlot9am.MouseEnter, lblSlot10am.MouseEnter, lblSlot11am.MouseEnter,
        lblSlot12pm.MouseEnter, lblSlot1pm.MouseEnter, lblSlot2pm.MouseEnter, lblSlot3pm.MouseEnter,
        lblSlot4pm.MouseEnter, lblSlot5pm.MouseEnter, lblSlot6pm.MouseEnter, lblSlot7pm.MouseEnter,
        lblSlot8pm.MouseEnter, lblSlot9pm.MouseEnter, lblSlot10pm.MouseEnter, lblSlot11pm.MouseEnter

        CType(sender, Label).BackColor = Color.FromArgb(127, 242, 229)
    End Sub

    Private Sub lblTimes_MouseLeave(sender As Object, e As EventArgs) Handles _
        lblSlot12am.MouseLeave, lblSlot1am.MouseLeave, lblSlot2am.MouseLeave, lblSlot3am.MouseLeave,
        lblSlot4am.MouseLeave, lblSlot5am.MouseLeave, lblSlot6am.MouseLeave, lblSlot7am.MouseLeave,
        lblSlot8am.MouseLeave, lblSlot9am.MouseLeave, lblSlot10am.MouseLeave, lblSlot11am.MouseLeave,
        lblSlot12pm.MouseLeave, lblSlot1pm.MouseLeave, lblSlot2pm.MouseLeave, lblSlot3pm.MouseLeave,
        lblSlot4pm.MouseLeave, lblSlot5pm.MouseLeave, lblSlot6pm.MouseLeave, lblSlot7pm.MouseLeave,
        lblSlot8pm.MouseLeave, lblSlot9pm.MouseLeave, lblSlot10pm.MouseLeave, lblSlot11pm.MouseLeave

        If (isToday) And (CType(sender, Label) Is Me.timesLabels(Me.today.Hour)) Then
            Me.timesLabels(Me.today.Hour).BackColor = Color.FromArgb(151, 203, 197)
        Else
            CType(sender, Label).BackColor = Color.White
        End If
    End Sub

End Class
