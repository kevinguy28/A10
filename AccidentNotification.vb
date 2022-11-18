Public Class AccidentNotification
    ' Parent
    Dim user As String
    Dim scenario As Integer
    Public devForm As DevForm
    Public previousForm As CarForm
    ' Child
    Public emergencyContactForm As EmergencyContactForm

    Public Sub New(user As String, scenario As Integer, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.previousForm = previousForm : Me.devForm = devForm
    End Sub

    ' Set current form

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.devForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devForm.SetCurrentRiderForm(form)
        End If
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
        'Rider Accident Notification
        Me.emergencyContactForm = New EmergencyContactForm("rider", Me.scenario, Me, Me.devForm) : Me.Hide()
        Me.emergencyContactForm.Show() : Me.emergencyContactForm.Location = New Point(Me.emergencyContactForm.SetLocation(), 0)
        Me.SetCurrentForm(Me.emergencyContactForm)
        'Owner Accident Notification
        Dim ownerAccidentNotification As New AccidentNotification("owner", Me.scenario, Me.devForm) : ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation, 0)
        ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide() : ownerAccidentNotification.lblAccident1.Text = "The accident was" : ownerAccidentNotification.lblAccident2.Text = "confirmed!"
        ownerAccidentNotification.btnConfirm.Visible = True : ownerAccidentNotification.Show() : Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.previousForm.Show() : Me.previousForm.ownerAccidentNotification.Close()
        Dim ownerAccidentNotification As New AccidentNotification("owner", Me.scenario, Me.devForm) : ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation, 0)
        ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide() : ownerAccidentNotification.lblAccident1.Text = "The accident was" : ownerAccidentNotification.lblAccident2.Text = "reported false!"
        ownerAccidentNotification.btnConfirm.Visible = True : ownerAccidentNotification.Show() : Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.previousForm.Show()
        Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        Me.SetCurrentForm(Me.previousForm)
    End Sub

End Class