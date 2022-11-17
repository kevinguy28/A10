Public Class AccidentNotification

    Dim user As String
    Dim scenario As Integer

    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
    End Sub

    ' Set Location of the Accident Notifcation

    Function SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "owner" Then
            Return ((halfScreen - halfDev) / 2) - halfHome

        Else
            Return (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
        End If
    End Function

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        ' Owners Accident Screen needs to be modified because Accident Notifaction is by default made with respect to riderHomeScreen
        Dim ownerAccidentNotification As New AccidentNotification("owner", 2)
        ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation, 0) : ownerAccidentNotification.confirmButton.Hide()
        ownerAccidentNotification.denyButton.Hide() : ownerAccidentNotification.lblAccident1.Text = "Rider has Confirmed" : ownerAccidentNotification.lblAccident2.Text = "an Accident!"

        ownerAccidentNotification.lblAccident1.Font = New Font("Segoe UI Semibold", 25, FontStyle.Bold) : ownerAccidentNotification.Show()
        ' Prompts emergency call screen on rider screen.
        Dim riderEmergencyCallScreen As New EmergencyContactForm("rider", 2) : riderEmergencyCallScreen.Location = New Point(riderEmergencyCallScreen.SetLocation, 0)
        riderEmergencyCallScreen.Show()

        Me.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.Close()
    End Sub
End Class