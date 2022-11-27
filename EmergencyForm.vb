Public Class EmergencyForm
    Inherits AppForm

    ' Emergency Form (For accident form)
    Dim carEmergency As EmergencyForm

    ' Notifications
    Dim riderAccidentNotification As AccidentNotification
    Dim riderIntrusionNotification As IntrusionAlertForm
    Dim riderTechProblemNotification As TechAlertForm
    Dim riderExpelNotification As ExitCarForm

    Public Sub New(user As String, scenario As Integer, previousForm As CarForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.previousWindow = previousForm : Me.homeWindow = homeForm : Me.devWindow = devForm
    End Sub

    Private Sub EmergencyForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetBackground()
        Me.CreateTitleLabel("Emergency")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        If Me.user = "owner" Then
            'Me.btnStop_Expel.Visible = False
            'Me.lblStop_Expel.Visible = False
            Me.lblStop_Expel.Text = "Expel Rider"
        Else
            Me.lblStop_Expel.Text = "Request Stop"
        End If
    End Sub

    Private Sub btnAccident_Click(sender As Object, e As EventArgs) Handles btnAccident.Click
        Me.riderAccidentNotification = New AccidentNotification("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderAccidentNotification)
    End Sub

    Private Sub btnTechProblem_Click(sender As Object, e As EventArgs) Handles btnTechProblem.Click
        Me.riderTechProblemNotification = New TechAlertForm("rider", Me.scenario, Me.devWindow, Me.homeWindow, Me.previousWindow, Me.previousWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderTechProblemNotification)
    End Sub

    Private Sub btnIntrusion_Click(sender As Object, e As EventArgs) Handles btnIntrusion.Click
        Me.riderIntrusionNotification = New IntrusionAlertForm("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderIntrusionNotification)
    End Sub

    Private Sub btnStop_Expel_Click(sender As Object, e As EventArgs) Handles btnStop_Expel.Click
        If Me.user = "rider" Then
            Dim riderNotification As New CarStopForm("rider", Me.scenario, Me.homeWindow, Me.devWindow)
            Me.devWindow.OpenPopup(Me.user, riderNotification)
        Else
            Me.riderExpelNotification = New ExitCarForm("rider", Me.scenario, Me.devWindow)
            Me.devWindow.OpenPopup("rider", Me.riderExpelNotification)
        End If
    End Sub
End Class