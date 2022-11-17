Public Class CalendarDayControl

    Dim timesLabels As Label()
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

    Public Sub SetDate(day As Integer, month As Integer)
        ' Is selected date today
        today = New Date.Now()
        If (today.Day = day) And (today.Month = month) Then
            isToday = True
        End If

        ' Current Time
        If isToday Then
            Me.timesLabels(today.Hour).BackColor = Color.FromArgb(151, 203, 197)
        End If
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

        If (isToday) And (CType(sender, Label) Is Me.timesLabels(today.Hour)) Then
            Me.timesLabels(today.Hour).BackColor = Color.FromArgb(151, 203, 197)
        Else
            CType(sender, Label).BackColor = Color.White
        End If
    End Sub
End Class
