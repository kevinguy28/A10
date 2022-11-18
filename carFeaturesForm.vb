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
End Class