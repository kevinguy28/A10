Public Class CarFeaturesForm

    Private Sub CarFeaturesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Features"
            Case "rider"
                Me.Text = "Car Rider Car Features"
        End Select
    End Sub
    Private Sub btnToggleWindows_Click(sender As Object, e As EventArgs) Handles btnToggleWindows.Click
        If btnToggleWindows.Tag = 1 Then
            btnToggleWindows.BackgroundImage = My.Resources.toggle_off
            btnToggleWindows.Tag = 0
        Else
            btnToggleWindows.BackgroundImage = My.Resources.toggle_on
            btnToggleWindows.Tag = 1
        End If

    End Sub
    '----Fan strength Down Button-----
    Private Sub btnFanStrengthDown_Click(sender As Object, e As EventArgs) Handles btnFanStrengthDown.Click
        'lowers the fan strength (range from 1 to 10)
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_press
        If Not lblFanStrengthNumber.Tag = 1 Then
            lblFanStrengthNumber.Tag -= 1
            lblFanStrengthNumber.Text -= 1
            lblInsideTempValue.Text += 1
        End If

    End Sub

    Private Sub btnFanStrengthDown_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseEnter
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnFanStrengthDown_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseLeave
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_neutral

    End Sub
    '----Fan strength Up Button-----
    Private Sub btnFanStrengthUp_Click(sender As Object, e As EventArgs) Handles btnFanStrengthUp.Click
        'increases the fan strength (range from 1 to 10)
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_press
        If Not lblFanStrengthNumber.Tag = 10 Then ' if tag is not 10 then increase intensity b/c 10 is max
            lblFanStrengthNumber.Tag += 1
            lblFanStrengthNumber.Text += 1
            lblInsideTempValue.Text -= 1
        End If

    End Sub

    Private Sub btnFanStrengthUp_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseEnter
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_hover

    End Sub

    Private Sub btnFanStrengthUp_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseLeave
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_neutral

    End Sub
    '-----Air Intake Up Button -----
    Private Sub btnAirIntakeUp_Click(sender As Object, e As EventArgs) Handles btnAirIntakeUp.Click
        'increases the air intake
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_press
        If Not lblAirIntakeNumber.Tag = 10 Then
            lblAirIntakeNumber.Tag += 1
            lblAirIntakeNumber.Text += 1
            lblInsideTempValue.Text -= 1
        End If
    End Sub

    Private Sub btnAirIntakeUp_MouseEnter(sender As Object, e As EventArgs) Handles btnAirIntakeUp.MouseEnter
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_hover

    End Sub

    Private Sub btnAirIntakeUp_MouseLeave(sender As Object, e As EventArgs) Handles btnAirIntakeUp.MouseLeave
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_neutral

    End Sub

    Private Sub btnAirIntakeDown_Click(sender As Object, e As EventArgs) Handles btnAirIntakeDown.Click
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_press
        If Not lblAirIntakeNumber.Tag = 1 Then
            lblAirIntakeNumber.Tag -= 1
            lblAirIntakeNumber.Text -= 1
            lblInsideTempValue.Text += 1
        End If
    End Sub

    Private Sub btnAirIntakeDown_MouseEnter(sender As Object, e As EventArgs) Handles btnAirIntakeDown.MouseEnter
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnAirIntakeDown_MouseLeave(sender As Object, e As EventArgs) Handles btnAirIntakeDown.MouseLeave
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_neutral
    End Sub
End Class
