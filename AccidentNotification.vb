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
            Me.GetCurrentForms()
        End If

        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub GetCurrentForms()
        Me.prevOwnerForm = Me.devWindow.GetCurrentOwnerForm
        Me.prevRiderForm = Me.devWindow.GetCurrentRiderForm
    End Sub

    Private Sub OpenOwnerForm()
        If AccidentNotification.ownerAccidentForm Is Nothing Then
            AccidentNotification.ownerOpened = True
            AccidentNotification.ownerAccidentForm = New AccidentNotification("owner", Me.scenario, Me.devWindow)
            AccidentNotification.ownerAccidentForm.denyButton.Visible = False
            AccidentNotification.ownerAccidentForm.confirmButton.Visible = False
            AccidentNotification.ownerAccidentForm.btnConfirm.Visible = True
            Me.devWindow.OpenPopup("owner", ownerAccidentForm)
        End If
    End Sub

    Private Sub OpenEmergencyForm()
        If AccidentNotification.emergencyContactForm Is Nothing Then
            AccidentNotification.emergencyOpened = True
            AccidentNotification.emergencyContactForm = New EmergencyContactForm("rider", Me.scenario, DevForm)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If Not mainOpened And Not ownerOpened And Not emergencyOpened Then

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

    ' Set current form

    'Private Sub SetCurrentForm(form As Form)
    '    If (user = "owner") Then
    '        Me.devForm.SetCurrentOwnerForm(form)
    '    ElseIf (user = "rider") Then
    '        Me.devForm.SetCurrentRiderForm(form)
    '    End If
    'End Sub

    '' Set Location of the Accident Notifcation

    'Function SetLocation()
    '    Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
    '    Dim halfScreen = fullScreen / 2
    '    Dim halfDev = DevForm.Width / 2
    '    Dim halfHome = Me.Width / 2

    '    If Me.user = "owner" Then
    '        Return ((halfScreen - halfDev) / 2) - halfHome

    '    Else
    '        Return (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
    '    End If
    'End Function

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        ' Confirms the accident by rider, emergency call form for rider, homescreen for owner
        Me.OpenOwnerForm()

        AccidentNotification.ownerAccidentForm.lblAccident.Text = "The accident was confirmed!"

        OpenEmergencyForm()

        AccidentNotification.mainAccidentForm.Close()
        AccidentNotification.mainOpened = False
        Me.devWindow.ClosePopup(AccidentNotification.mainAccidentForm.user)
        AccidentNotification.CloseAllForms()

        'Me.Close()
        'Me.ownerAccidentForm = New AccidentNotification("owner", Me.scenario, Me.devForm) 'Me.previousForm = carForm
        ''Me.ownerAccidentForm.Location = New Point(Me.ownerAccidentForm.SetLocation(), 0)
        'Me.ownerAccidentForm.denyButton.Visible = False : Me.ownerAccidentForm.confirmButton.Visible = False : Me.ownerAccidentForm.btnConfirm.Visible = True
        'Me.ownerAccidentForm.lblAccident.Text = "The accident" : Me.ownerAccidentForm.lblAccident.Text = "was confirmed!"
        'Me.ownerAccidentForm.Show()

        'Me.emergencyContactForm = New EmergencyContactForm("rider", 2, DevForm, Me)
        'Me.emergencyContactForm.Show()
        'Me.emergencyContactForm.Location = New Point(Me.emergencyContactForm.SetLocation(), 2)
    End Sub

    ' Goes back to previous rider CarForm, shows new rider notfication
    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.OpenOwnerForm()

        AccidentNotification.ownerAccidentForm.lblAccident.Text = "The accident was a false alarm!"

        AccidentNotification.mainAccidentForm.Close()
        AccidentNotification.mainOpened = False
        Me.devWindow.ClosePopup(AccidentNotification.mainAccidentForm.user)
        AccidentNotification.CloseAllForms()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        AccidentNotification.ownerAccidentForm.Close()
        AccidentNotification.ownerOpened = False
        Me.devWindow.ClosePopup(AccidentNotification.ownerAccidentForm.user)
        AccidentNotification.CloseAllForms()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(320, 250)
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
    'Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Me.devWindow.ClosePopup(Me.user)
    'End Sub

End Class