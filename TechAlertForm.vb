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
            Me.devWindow.OpenPopup("owner", ownerTechForm)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If (Not mainOpened) AndAlso (Not ownerOpened) Then

            If (TechAlertForm.ownerTechForm IsNot Nothing) Then
                TechAlertForm.ownerTechForm.Dispose()
                TechAlertForm.ownerTechForm = Nothing
            End If

            If (TechAlertForm.mainTechForm IsNot Nothing) Then
                TechAlertForm.mainTechForm.Dispose()
                TechAlertForm.mainTechForm = Nothing
            End If

            ' Opened
            mainOpened = False
            ownerOpened = False

        End If
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnDiagnostic_Click(sender As Object, e As EventArgs) Handles btnDiagnostic.Click
        Me.Hide()
        Dim ownerHome As HomeForm = Me.devWindow.GetOwnerHomeForm
        Me.carDiagnostic = New CarDiagnosticForm("owner", Me.scenario, ownerHome, ownerHome, Me.devWindow)

        Me.devWindow.ClosePopup(Me.user)
        ownerHome.CloseAllChildren()
        ownerHome.Hide()
        Me.carDiagnostic.Show()
        Me.devWindow.SetCurrentOwnerForm(Me.carDiagnostic)

        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.devWindow.ClosePopup(Me.user)
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.devWindow.ClosePopup(Me.user)
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
        TechAlertForm.CloseAllForms()
    End Sub
End Class