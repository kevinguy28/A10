Public Class CarForm
    Inherits AppForm

    ' Children
    Public ownerAccidentNotification As AccidentNotification
    Public riderAccidentNotification As AccidentNotification

    Dim carFeatures As CarFeaturesForm

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'App Form
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm
    End Sub

    Private Sub CarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Car")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
    End Sub

    ' -----------------
    ' --- Emergency ---
    ' -----------------
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click

        'Rider Accident Notification
        Me.riderAccidentNotification = New AccidentNotification("rider", 2, Me.devWindow, Me) : Me.Hide()
        Me.riderAccidentNotification.Show() : Me.riderAccidentNotification.Location = New Point(riderAccidentNotification.SetLocation(), 0)
        Me.SetCurrentForm(Me.riderAccidentNotification)
        ' Owner Accident Notification
        Me.ownerAccidentNotification = New AccidentNotification("owner", 2, Me.devWindow, Me)
        Me.ownerAccidentNotification.Show() : Me.ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation(), 0)
        Me.SetCurrentForm(Me.ownerAccidentNotification) : Me.ownerAccidentNotification.btnConfirm.Visible = True
        Me.ownerAccidentNotification.confirmButton.Hide() : Me.ownerAccidentNotification.denyButton.Hide()
    End Sub

    ' --------------------
    ' --- Car Features ---
    ' --------------------
    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        ' car features form opens up here
        carFeatures = New CarFeaturesForm
        Me.Hide()
        carFeatures.Show()


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