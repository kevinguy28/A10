Public Class devWindow

    ' Owner Position: 200, 200 | Rider Position: 685, 200
    Private Sub accidentButton_Click(sender As Object, e As EventArgs) Handles accidentButton.Click
        Dim accidentNotification As New AccidentNotification
        accidentNotification.Show()
    End Sub
End Class