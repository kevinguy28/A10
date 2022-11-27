Public Class ExitCarForm
    Dim user As String
    Dim scenario As Integer
    Public devWindow As DevForm

    ' Forms
    Shared mainExitCarForm As ExitCarForm

    ' Opened
    Shared riderOpened = False

    Public Sub New(user As String, scenario As Integer, devForm As DevForm, Optional mainForm As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devWindow = devForm

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub OpenOwnerForm()
        If Not ExitCarForm.riderOpened Then
            ExitCarForm.riderOpened = True
            ExitCarForm.mainExitCarForm = New ExitCarForm("rider", Me.scenario, Me.devWindow)
            'IntrusionAlertForm.ownerIntrusionForm.Text = "Car Owner Accident"
            Me.devWindow.OpenPopup("rider", mainExitCarForm)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If (Not riderOpened) Then
            If (ExitCarForm.mainExitCarForm IsNot Nothing) Then
                ExitCarForm.mainExitCarForm.Dispose()
                ExitCarForm.mainExitCarForm = Nothing
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
        If Me Is ExitCarForm.mainExitCarForm Then
            ExitCarForm.riderOpened = False
        End If
        Me.devWindow.ClosePopup(Me.user)
        ExitCarForm.CloseAllForms()
    End Sub

End Class