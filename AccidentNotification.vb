Public Class AccidentNotification
    ' Parent
    Dim user As String
    Dim scenario As Integer
    Public devForm As DevForm
    Public previousForm As CarForm
    ' Child
    Public emergencyContactForm As EmergencyContactForm
    Public ownerAccidentForm As AccidentNotification

    Public Sub New(user As String, scenario As Integer, devForm As DevForm, previousForm As CarForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devForm = devForm : Me.previousForm = previousForm
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
        ' Confirms the accident by rider, emergency call form for rider, homescreen for owner
        Me.Close()
        Me.ownerAccidentForm = New AccidentNotification("owner", 2, devForm, Me.previousForm) 'Me.previousForm = carForm
        Me.ownerAccidentForm.Location = New Point(Me.ownerAccidentForm.SetLocation(), 0)
        Me.ownerAccidentForm.denyButton.Visible = False : Me.ownerAccidentForm.confirmButton.Visible = False : Me.ownerAccidentForm.btnConfirm.Visible = True
        Me.ownerAccidentForm.lblAccident1.Text = "The accident" : Me.ownerAccidentForm.lblAccident2.Text = "was confirmed!"
        Me.ownerAccidentForm.Show()

        Me.emergencyContactForm = New EmergencyContactForm("rider", 2, devForm, Me)
        Me.emergencyContactForm.Show()
        Me.emergencyContactForm.Location = New Point(Me.emergencyContactForm.SetLocation(), 2)

        ''Rider Accident Notification
        'Me.emergencyContactForm = New EmergencyContactForm("rider", Me.scenario, Me, Me.devForm) : Me.Hide()
        'Me.emergencyContactForm.Show() : Me.emergencyContactForm.Location = New Point(Me.emergencyContactForm.SetLocation(), 0)
        'Me.SetCurrentForm(Me.emergencyContactForm)
        ''Owner Accident Notification
        'Dim ownerAccidentNotification As New AccidentNotification("owner", Me.scenario, Me.devForm) : ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation, 0)
        'ownerAccidentNotification.confirmButton.Hide() : ownerAccidentNotification.denyButton.Hide() : ownerAccidentNotification.lblAccident1.Text = "The accident was" : ownerAccidentNotification.lblAccident2.Text = "confirmed!"
        'ownerAccidentNotification.btnConfirm.Visible = True : ownerAccidentNotification.Show() : Me.SetCurrentForm()
        'Me.Dispose()
        'Me.Close()
    End Sub

    ' Goes back to previous rider CarForm, shows new rider notfication
    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.Close() : Me.previousForm.Show()
        Me.ownerAccidentForm = New AccidentNotification("owner", 2, devForm, Me.previousForm)
        Me.ownerAccidentForm.Location = New Point(Me.ownerAccidentForm.SetLocation(), 0)
        Me.ownerAccidentForm.denyButton.Visible = False : Me.ownerAccidentForm.confirmButton.Visible = False : Me.ownerAccidentForm.btnConfirm.Visible = True
        Me.ownerAccidentForm.lblAccident1.Text = "The accident was a" : Me.ownerAccidentForm.lblAccident2.Text = "false alarm!"
        Me.ownerAccidentForm.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Me.Close()
        'Me.previousForm.Show()
        'Me.SetCurrentForm(Me.previousForm)
        'Me.Dispose()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        Me.previousForm.ownerAccidentNotification.Close()
    End Sub

End Class