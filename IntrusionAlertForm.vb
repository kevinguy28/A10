Public Class IntrusionAlertForm
    Dim user As String
    Dim scenario As Integer
    Public devWindow As DevForm

    ' Forms
    Shared mainIntrusionForm As IntrusionAlertForm
    Shared emergencyContactForm As EmergencyContactForm
    Shared ownerIntrusionForm As IntrusionAlertForm

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
            IntrusionAlertForm.mainIntrusionForm = Me
            IntrusionAlertForm.mainOpened = True
            IntrusionAlertForm.mainIntrusionForm.Text = "Car Rider Intrusion"
            Me.OpenOwnerForm()
        End If

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub OpenOwnerForm()
        If Not IntrusionAlertForm.ownerOpened Then
            IntrusionAlertForm.ownerOpened = True
            IntrusionAlertForm.ownerIntrusionForm = New IntrusionAlertForm("owner", Me.scenario, Me.devWindow)
            'IntrusionAlertForm.ownerIntrusionForm.Text = "Car Owner Accident"
            Me.devWindow.OpenPopup("owner", ownerIntrusionForm)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If (Not mainOpened) AndAlso (Not ownerOpened) AndAlso (Not emergencyOpened) Then

            If (IntrusionAlertForm.mainIntrusionForm IsNot Nothing) Then
                IntrusionAlertForm.mainIntrusionForm.Dispose()
                IntrusionAlertForm.mainIntrusionForm = Nothing
            End If

            If (IntrusionAlertForm.ownerIntrusionForm IsNot Nothing) Then
                IntrusionAlertForm.ownerIntrusionForm.Dispose()
                IntrusionAlertForm.ownerIntrusionForm = Nothing
            End If

            If (IntrusionAlertForm.emergencyContactForm IsNot Nothing) Then
                IntrusionAlertForm.emergencyContactForm.Dispose()
                IntrusionAlertForm.emergencyContactForm = Nothing
            End If

        End If
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
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
        If Me Is IntrusionAlertForm.mainIntrusionForm Then
            IntrusionAlertForm.mainOpened = False
        End If
        If Me Is IntrusionAlertForm.ownerIntrusionForm Then
            IntrusionAlertForm.ownerOpened = False
        End If
        Me.devWindow.ClosePopup(Me.user)
        IntrusionAlertForm.CloseAllForms()
    End Sub

End Class