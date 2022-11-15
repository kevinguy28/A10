Public Class AccidentNotification

    ' NOTE: THE DEFAULT NOTFICATION LOCATION IS 685, 200
    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        ' Owners Accident Screen needs to be modified because Accident Notifaction is by default made with respect to riderHomeScreen
        Dim ownerAccidentNotification As New AccidentNotification
        ownerAccidentNotification.Location = New Point(200, 200) : ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide()
        ownerAccidentNotification.accidentLabel.Text = "Rider has Confirmed an Accident" : ownerAccidentNotification.accidentLabel.Font = New Font("SimSun-ExtB", 9, FontStyle.Bold)

        ownerAccidentNotification.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class