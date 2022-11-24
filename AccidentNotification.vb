Public Class AccidentNotification
    Dim user As String
    Dim scenario As Integer
    Public devWindow As DevForm
    'Public previousForm As CarForm

    Shared prevOwnerForm As AppForm
    Shared prevRiderForm As AppForm

    ' Forms
    Shared mainAccidentForm As AccidentNotification
    Shared emergencyContactForm As EmergencyContactForm
    Shared ownerAccidentForm As AccidentNotification

    ' Opened
    Shared mainOpened = False
    Shared ownerOpened = False
    Public Shared emergencyOpened = False

    Public Sub New(user As String, scenario As Integer, devForm As DevForm, Optional mainForm As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devWindow = devForm

        If mainForm Then
            AccidentNotification.mainAccidentForm = Me
            AccidentNotification.mainOpened = True
            AccidentNotification.mainAccidentForm.Text = "Car Rider Accident"
            Me.OpenOwnerForm()
        End If

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub OpenOwnerForm()
        If Not AccidentNotification.ownerOpened Then
            AccidentNotification.ownerOpened = True
            AccidentNotification.ownerAccidentForm = New AccidentNotification("owner", Me.scenario, Me.devWindow)
            AccidentNotification.ownerAccidentForm.Text = "Car Owner Accident"
            AccidentNotification.ownerAccidentForm.denyButton.Visible = False
            AccidentNotification.ownerAccidentForm.confirmButton.Visible = False
            AccidentNotification.ownerAccidentForm.btnConfirm.Visible = True
            Me.devWindow.OpenPopup("owner", ownerAccidentForm)
        End If
    End Sub

    Private Sub OpenEmergencyForm()
        If Not AccidentNotification.emergencyOpened Then
            AccidentNotification.mainAccidentForm.Close()
            AccidentNotification.emergencyOpened = True
            AccidentNotification.emergencyContactForm = New EmergencyContactForm("rider", Me.scenario, DevForm)
            Me.devWindow.OpenPopup("rider", emergencyContactForm)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If (Not mainOpened) AndAlso (Not ownerOpened) AndAlso (Not emergencyOpened) Then

            If (AccidentNotification.mainAccidentForm IsNot Nothing) Then
                AccidentNotification.mainAccidentForm.Dispose()
                AccidentNotification.mainAccidentForm = Nothing
            End If

            If (AccidentNotification.ownerAccidentForm IsNot Nothing) Then
                AccidentNotification.ownerAccidentForm.Dispose()
                AccidentNotification.ownerAccidentForm = Nothing
            End If

            If (AccidentNotification.emergencyContactForm IsNot Nothing) Then
                AccidentNotification.emergencyContactForm.Dispose()
                AccidentNotification.emergencyContactForm = Nothing
            End If

        End If
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Me.OpenOwnerForm()

        AccidentNotification.ownerAccidentForm.lblAccident.Text = "The accident was confirmed!"
        AccidentNotification.ownerAccidentForm.lblMessage.BringToFront()
        AccidentNotification.ownerAccidentForm.lblMessage.Text = "Contact the rider for more information."

        Me.OpenEmergencyForm()
    End Sub

    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.OpenOwnerForm()

        AccidentNotification.ownerAccidentForm.lblAccident.Text = "The accident was a false alarm!"

        AccidentNotification.mainAccidentForm.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        AccidentNotification.ownerAccidentForm.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(365, 250)
    End Sub

    Private Sub Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x = 0
        Dim y = 0
        If Me.user = "rider" Then
            x = DevForm.GetRiderLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetRiderLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        ElseIf Me.user = "owner" Then
            x = DevForm.GetOwnerLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetOwnerLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        End If
        Me.Location = New Size(x, y)
    End Sub

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Me Is AccidentNotification.mainAccidentForm Then
            AccidentNotification.mainOpened = False
        End If
        If Me Is AccidentNotification.ownerAccidentForm Then
            AccidentNotification.ownerOpened = False
        End If
        Me.devWindow.ClosePopup(Me.user)
        AccidentNotification.CloseAllForms()
    End Sub

End Class