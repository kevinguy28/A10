Public Class CarFeaturesForm

    Private Sub btnToggleWindows_Click(sender As Object, e As EventArgs) Handles btnToggleWindows.Click
        If btnToggleWindows.Tag = 1 Then
            btnToggleWindows.BackgroundImage = My.Resources.toggle_off
            btnToggleWindows.Tag = 0
        Else
            btnToggleWindows.BackgroundImage = My.Resources.toggle_on
            btnToggleWindows.Tag = 1
        End If

    End Sub

    Private Sub btnFanStrengthDown_Click(sender As Object, e As EventArgs) Handles btnFanStrengthDown.Click
        'lowers the fan strength
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_press

    End Sub

    Private Sub btnFanStrengthDown_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseEnter
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnFanStrengthDown_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseLeave
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_neutral

    End Sub

    Private Sub btnFanStrengthUp_Click(sender As Object, e As EventArgs) Handles btnFanStrengthUp.Click
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_press
        If Not lblFanStrengthNumber.Tag = 10 Then ' if tag is not 10 then increase intensity b/c 10 is max
            lblFanStrengthNumber.Tag += 1
            lblFanStrengthNumber.Text = CStr(lblFanStrength.Tag)
        End If


    End Sub

    Private Sub btnFanStrengthUp_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseEnter
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_hover

    End Sub

    Private Sub btnFanStrengthUp_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseLeave
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_neutral

    End Sub
End Class
