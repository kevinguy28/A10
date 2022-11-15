Public Class AccidentNotification

    ' NOTE: THE DEFAULT NOTFICATION LOCATION IS 685, 200
    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        ' Owners Accident Screen needs to be modified because Accident Notifaction is by default made with respect to riderHomeScreen
        Dim ownerAccidentNotification As New AccidentNotification
        ownerAccidentNotification.Location = New Point(200, 200) : ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide()
        ownerAccidentNotification.accidentLabel.Text = "Rider has Confirmed an Accident" : ownerAccidentNotification.accidentLabel.Font = New Font("SimSun-ExtB", 9, FontStyle.Bold)
        ownerAccidentNotification.Show()

        ' Prompts emergency call screen on rider screen.
        Dim riderEmergencyCallScreen As New emergencyCallScreen
        riderEmergencyCallScreen.Show()


        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Dim otherForm = Application.OpenForms.OfType(Of AccidentNotification)().FirstOrDefault()
        If otherForm IsNot Nothing Then
            otherForm.Close()
        End If
        Me.Close()
    End Sub

End Class