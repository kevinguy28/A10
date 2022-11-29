Public Class EmergencyForm
    Inherits AppForm

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
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Emergency"
            Case "rider"
                Me.Text = "Car Rider Emergency"
        End Select

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

    '----------------
    '--- Accident ---
    '----------------

    Private Sub btnAccident_Click(sender As Object, e As EventArgs) Handles btnAccident.Click
        Me.riderAccidentNotification = New AccidentNotification("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderAccidentNotification)
    End Sub

    Private Sub btnAccident_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAccident.MouseDown
        Me.btnAccident.BackgroundImage = My.Resources.accident_press
    End Sub

    Private Sub btnAccident_MouseUp(sender As Object, e As MouseEventArgs) Handles btnAccident.MouseUp
        Me.btnAccident.BackgroundImage = My.Resources.accident_hover
    End Sub

    Private Sub btnAccident_MouseEnter(sender As Object, e As EventArgs) Handles btnAccident.MouseEnter
        Me.btnAccident.BackgroundImage = My.Resources.accident_hover
    End Sub

    Private Sub btnAccident_MouseLeave(sender As Object, e As EventArgs) Handles btnAccident.MouseLeave
        Me.btnAccident.BackgroundImage = My.Resources.accident_neutral
    End Sub

    '---------------------
    '--- Tech Problems ---
    '---------------------

    Private Sub btnTechProblem_Click(sender As Object, e As EventArgs) Handles btnTechProblem.Click
        Me.riderTechProblemNotification = New TechAlertForm("rider", Me.scenario, Me.devWindow, Me.homeWindow, Me, Me.previousWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderTechProblemNotification)
        Me.devWindow.UpdateCarCondition(0)
    End Sub

    Private Sub btnTechProblem_MouseDown(sender As Object, e As MouseEventArgs) Handles btnTechProblem.MouseDown
        Me.btnTechProblem.BackgroundImage = My.Resources.techproblem_press
    End Sub

    Private Sub btnTechProblem_MouseUp(sender As Object, e As MouseEventArgs) Handles btnTechProblem.MouseUp
        Me.btnTechProblem.BackgroundImage = My.Resources.techproblem_hover
    End Sub

    Private Sub btnTechProblem_MouseEnter(sender As Object, e As EventArgs) Handles btnTechProblem.MouseEnter
        Me.btnTechProblem.BackgroundImage = My.Resources.techproblem_hover
    End Sub

    Private Sub btnTechProblem_MouseLeave(sender As Object, e As EventArgs) Handles btnTechProblem.MouseLeave
        Me.btnTechProblem.BackgroundImage = My.Resources.techproblem_neutral
    End Sub

    '-----------------
    '--- Intrusion ---
    '-----------------

    Private Sub btnIntrusion_Click(sender As Object, e As EventArgs) Handles btnIntrusion.Click
        Me.riderIntrusionNotification = New IntrusionAlertForm("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderIntrusionNotification)
    End Sub

    Private Sub btnIntrusion_MouseDown(sender As Object, e As MouseEventArgs) Handles btnIntrusion.MouseDown
        Me.btnIntrusion.BackgroundImage = My.Resources.intrusion_press
    End Sub

    Private Sub btnIntrusion_MouseUp(sender As Object, e As MouseEventArgs) Handles btnIntrusion.MouseUp
        Me.btnIntrusion.BackgroundImage = My.Resources.intrusion_hover
    End Sub

    Private Sub btnIntrusion_MouseEnter(sender As Object, e As EventArgs) Handles btnIntrusion.MouseEnter
        Me.btnIntrusion.BackgroundImage = My.Resources.intrusion_hover
    End Sub

    Private Sub btnIntrusion_MouseLeave(sender As Object, e As EventArgs) Handles btnIntrusion.MouseLeave
        Me.btnIntrusion.BackgroundImage = My.Resources.intrusion_neutral
    End Sub

    '--------------------
    '--- Stop / Expel ---
    '--------------------

    Private Sub btnStop_Expel_Click(sender As Object, e As EventArgs) Handles btnStop_Expel.Click
        If Me.user = "rider" Then
            Dim riderNotification As New CarStopForm("rider", Me.scenario, Me.homeWindow, Me.devWindow)
            Me.devWindow.OpenPopup(Me.user, riderNotification)
        Else
            Me.riderExpelNotification = New ExitCarForm("rider", Me.scenario, Me.devWindow)
            Me.devWindow.OpenPopup("rider", Me.riderExpelNotification)
        End If
    End Sub

    Private Sub btnStop_Expel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStop_Expel.MouseDown
        Me.btnStop_Expel.BackgroundImage = My.Resources.expelrider_press
    End Sub

    Private Sub btnStop_Expel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStop_Expel.MouseUp
        Me.btnStop_Expel.BackgroundImage = My.Resources.expelrider_hover
    End Sub

    Private Sub btnStop_Expel_MouseEnter(sender As Object, e As EventArgs) Handles btnStop_Expel.MouseEnter
        Me.btnStop_Expel.BackgroundImage = My.Resources.expelrider_hover
    End Sub

    Private Sub btnStop_Expel_MouseLeave(sender As Object, e As EventArgs) Handles btnStop_Expel.MouseLeave
        Me.btnStop_Expel.BackgroundImage = My.Resources.expelrider_neutral
    End Sub

End Class