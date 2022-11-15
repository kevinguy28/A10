Public Class devWindow

    ' Owner Position: 200, 200 | Rider Position: 685, 200
    Private Sub accidentButton_Click(sender As Object, e As EventArgs) Handles accidentButton.Click
        ' Owners Accident Screen needs to be modified because Accident Notifaction is by default made with respect to riderHomeScreen
        Dim ownerAccidentNotification As New AccidentNotification
        ownerAccidentNotification.Location = New Point(200, 200) : ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide()
        ownerAccidentNotification.Show()

        Dim riderAccidentNotification As New AccidentNotification
        riderAccidentNotification.Show()
    End Sub
End Class