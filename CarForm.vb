Public Class CarForm
    ' Parent
    Dim user As String
    Dim scenario As Integer
    Dim previousForm As HomeForm
    Dim devForm As DevForm
    ' Children
    Public ownerAccidentNotification As AccidentNotification
    Public riderAccidentNotification As AccidentNotification

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = previousForm
        Me.devForm = devForm
    End Sub

    Private Sub CarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White
    End Sub

    Public Sub CloseAllForms()
        Me.Dispose()
    End Sub

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.devForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devForm.SetCurrentRiderForm(form)
        End If
    End Sub

    ' ----------------
    ' --- Location ---
    ' ----------------
    Private Sub CarForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.SetLocation()
    End Sub

    Private Sub SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = devForm.Width / 2
        Dim halfForm = Me.Width / 2

        If Me.user = "owner" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfForm
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "rider" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub CarForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = Me.devForm.GetWidth()
        Me.Height = Me.devForm.GetHeight()
    End Sub

    ' ------------
    ' --- Home ---
    ' ------------
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.previousForm.Show()
        Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
    End Sub

    Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        Me.btnHome.BackgroundImage = My.Resources.Home___Hover
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        Me.btnHome.BackgroundImage = My.Resources.Home
    End Sub

    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        'Rider Accident Notification
        Me.riderAccidentNotification = New AccidentNotification("rider", 2, Me, devForm) : Me.Hide()
        Me.riderAccidentNotification.Show() : Me.riderAccidentNotification.Location = New Point(riderAccidentNotification.SetLocation(), 0)
        Me.SetCurrentForm(Me.riderAccidentNotification)
        ' Owner Accident Notification
        Me.ownerAccidentNotification = New AccidentNotification("owner", 2, Me, devForm)
        Me.ownerAccidentNotification.Show() : Me.ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation(), 0)
        Me.SetCurrentForm(Me.ownerAccidentNotification) : Me.ownerAccidentNotification.btnConfirm.Visible = True
        Me.ownerAccidentNotification.confirmButton.Hide() : Me.ownerAccidentNotification.denyButton.Hide()
    End Sub

    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        ' car features form opens up here
    End Sub

    Private Sub btnCarFeatures_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCarFeatures.MouseDown
        btnCarFeatures.BackgroundImage = My.Resources.fan_press
    End Sub

    Private Sub btnCarFeatures_MouseEnter(sender As Object, e As EventArgs) Handles btnCarFeatures.MouseEnter
        btnCarFeatures.BackgroundImage = My.Resources.fan_hover
    End Sub

    Private Sub btnCarFeatures_MouseLeave(sender As Object, e As EventArgs) Handles btnCarFeatures.MouseLeave
        btnCarFeatures.BackgroundImage = My.Resources.fan_neutral

    End Sub
End Class