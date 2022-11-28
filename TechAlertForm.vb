Public Class TechAlertForm
    Dim user As String
    Dim scenario As Integer
    Dim devWindow As DevForm

    ' Forms
    Shared mainTechForm As TechAlertForm
    Shared ownerTechForm As TechAlertForm
    Dim homeWindow As HomeForm

    ' Opened
    Shared mainOpened = False
    Shared ownerOpened = False
    Public Shared emergencyOpened = False
    Dim carDiagnostic As CarDiagnosticForm
    Dim previousForm As AppForm
    Dim carForm As CarForm

    Public Sub New(user As String, scenario As Integer, devForm As DevForm, homeWindow As HomeForm, previousForm As AppForm, carForm As CarForm, Optional mainForm As Boolean = False)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devWindow = devForm : Me.homeWindow = homeWindow : Me.previousForm = previousForm : Me.carForm = carForm

        If mainForm Then
            TechAlertForm.mainTechForm = Me
            TechAlertForm.mainOpened = True
            TechAlertForm.mainTechForm.Text = "Car Rider Tech"
            Me.OpenOwnerForm()
        End If

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub TechAlertForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.user = "rider" Then
            Me.btnClose.Visible = False : Me.btnDiagnostic.Visible = False : Me.btnConfirm.Visible = True
        End If
    End Sub



    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub OpenOwnerForm()
        If Not TechAlertForm.ownerOpened Then
            TechAlertForm.ownerOpened = True
            TechAlertForm.ownerTechForm = New TechAlertForm("owner", Me.scenario, Me.devWindow, Me.homeWindow, Me.previousForm, Me.carForm)
            TechAlertForm.ownerTechForm.Text = "Car Owner Accident"
            'TechAlertForm.ownerAccidentForm.denyButton.Visible = False
            'TechAlertForm.ownerAccidentForm.confirmButton.Visible = False
            'TechAlertForm.ownerAccidentForm.btnConfirm.Visible = True
            Me.devWindow.OpenPopup("owner", ownerTechForm)
        End If
    End Sub

    'Private Sub OpenEmergencyForm()
    '    If Not TechAlertForm.emergencyOpened Then
    '        TechAlertForm.mainTechForm.Close()
    '        TechAlertForm.emergencyOpened = True
    '        TechAlertForm.emergencyContactForm = New TechAlertForm("rider", Me.scenario, DevForm)
    '        Me.devWindow.OpenPopup("rider", TechAlertForm)
    '    End If
    'End Sub

    Public Shared Sub CloseAllForms()
        If (Not mainOpened) AndAlso (Not ownerOpened) AndAlso (Not emergencyOpened) Then

            If (TechAlertForm.ownerTechForm IsNot Nothing) Then
                TechAlertForm.ownerTechForm.Dispose()
                TechAlertForm.ownerTechForm = Nothing
            End If

            If (TechAlertForm.mainTechForm IsNot Nothing) Then
                TechAlertForm.mainTechForm.Dispose()
                TechAlertForm.mainTechForm = Nothing
            End If

            'If (TechAlertForm.emergencyContactForm IsNot Nothing) Then
            '    TechAlertForm.emergencyContactForm.Dispose()
            '    TechAlertForm.emergencyContactForm = Nothing
            'End If

            ' Opened
            mainOpened = False
            ownerOpened = False
            emergencyOpened = False

        End If
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnDiagnostic_Click(sender As Object, e As EventArgs) Handles btnDiagnostic.Click
        Me.Hide()
        Me.carDiagnostic = New CarDiagnosticForm(Me.user, Me.scenario, Me.carForm, Me.homeWindow, Me.devWindow)

        Me.carDiagnostic.Show()
        Me.previousForm.SetCurrentForm(Me.carDiagnostic)

        'Me.OpenOwnerForm()

        'TechAlertForm.ownerTechForm.lblAccident.Text = "The accident was confirmed!"
        'TechAlertForm.ownerTechForm.lblMessage.BringToFront()
        'TechAlertForm.ownerTechForm.lblMessage.Text = "Contact the rider for more information."

        'Me.OpenEmergencyForm()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Me.OpenOwnerForm()

        'TechAlertForm.ownerTechForm.lblAccident.Text = "The accident was a false alarm!"

        'TechAlertForm.mainTechForm.Close()
        Me.Close()
    End Sub

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
        If Me Is TechAlertForm.mainTechForm Then
            TechAlertForm.mainOpened = False
        End If
        If Me Is TechAlertForm.ownerTechForm Then
            TechAlertForm.ownerOpened = False
        End If
        Me.devWindow.ClosePopup(Me.user)
        TechAlertForm.CloseAllForms()
    End Sub
End Class