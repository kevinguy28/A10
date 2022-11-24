Imports System.IO.Enumeration

Public Class CarFeatureForm
    Inherits AppForm

    Shared temperature As Integer = 12
    Shared fanStength As Integer = 1
    Shared fanIntake As Integer = 1

    Public Sub New(user As String, scenario As Integer, previousForm As CarForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.previousWindow = previousForm : Me.homeWindow = homeForm : Me.devWindow = devForm
    End Sub

    Private Sub CarFeatureForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetBackground()
        Me.CreateTitleLabel("Car Features")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        Me.SetLocation()

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Features"
            Case "rider"
                Me.Text = "Car Rider Car Features"
        End Select

        Me.lblFanStrength.Text = fanStength : Me.lblAirIntakeNumber.Text = fanIntake
        Me.lblInsideTempValue.Text = temperature

        tmrUpdate.Start()
    End Sub

    Private Sub btnToggleWindows_Click(sender As Object, e As EventArgs) Handles btnToggleWindows.Click
        If Me.devWindow.GetToggleWindow = 1 Then
            btnToggleWindows.BackgroundImage = My.Resources.toggle_off
            Me.devWindow.UpdateToggleWindow(0)
        Else
            btnToggleWindows.BackgroundImage = My.Resources.toggle_on
            Me.devWindow.UpdateToggleWindow(1)
        End If

    End Sub
    '----Fan strength Down Button-----
    Private Sub btnFanStrengthDown_Click(sender As Object, e As EventArgs) Handles btnFanStrengthDown.Click
        'lowers the fan strength (range from 1 to 10)
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_press
        If Not Me.devWindow.GetFanStrength = 1 Then
            Me.devWindow.UpdateStregth(-1)
            lblFanStrengthNumber.Text = Me.devWindow.GetFanStrength
            Me.devWindow.UpdateTemperature(1)
            lblInsideTempValue.Text = Me.devWindow.GetTemperature
        End If
    End Sub

    Private Sub btnFanStrengthDown_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseEnter
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnFanStrengthDown_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthDown.MouseLeave
        btnFanStrengthDown.BackgroundImage = My.Resources.arrow_down_neutral

    End Sub
    '----Fan strength Up Button-----
    Private Sub btnFanStrengthUp_Click(sender As Object, e As EventArgs) Handles btnFanStrengthUp.Click
        'increases the fan strength (range from 1 to 10)
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_press
        If Not Me.devWindow.GetFanStrength = 10 Then ' if tag is not 10 then increase intensity b/c 10 is max
            Me.devWindow.UpdateStregth(1)
            lblFanStrengthNumber.Text = Me.devWindow.GetFanStrength
            Me.devWindow.UpdateTemperature(-1)
            lblInsideTempValue.Text = Me.devWindow.GetTemperature
        End If
    End Sub

    Private Sub btnFanStrengthUp_MouseEnter(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseEnter
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_hover

    End Sub

    Private Sub btnFanStrengthUp_MouseLeave(sender As Object, e As EventArgs) Handles btnFanStrengthUp.MouseLeave
        btnFanStrengthUp.BackgroundImage = My.Resources.arrow_up_neutral

    End Sub
    '-----Air Intake Up Button -----
    Private Sub btnAirIntakeUp_Click(sender As Object, e As EventArgs) Handles btnAirIntakeUp.Click
        'increases the air intake
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_press
        If Not Me.devWindow.GetFanIntake = 10 Then
            Me.devWindow.UpdateIntake(1)
            lblAirIntakeNumber.Text = Me.devWindow.GetFanIntake
            Me.devWindow.UpdateTemperature(-1)
            lblInsideTempValue.Text = Me.devWindow.GetTemperature
        End If
    End Sub

    Private Sub btnAirIntakeUp_MouseEnter(sender As Object, e As EventArgs) Handles btnAirIntakeUp.MouseEnter
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_hover

    End Sub

    Private Sub btnAirIntakeUp_MouseLeave(sender As Object, e As EventArgs) Handles btnAirIntakeUp.MouseLeave
        btnAirIntakeUp.BackgroundImage = My.Resources.arrow_up_neutral

    End Sub

    Private Sub btnAirIntakeDown_Click(sender As Object, e As EventArgs) Handles btnAirIntakeDown.Click
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_press
        If Not Me.devWindow.GetFanIntake = 1 Then
            Me.devWindow.UpdateIntake(-1)
            lblAirIntakeNumber.Text = Me.devWindow.GetFanIntake
            Me.devWindow.UpdateTemperature(1)
            lblInsideTempValue.Text = Me.devWindow.GetTemperature
        End If
    End Sub

    Private Sub btnAirIntakeDown_MouseEnter(sender As Object, e As EventArgs) Handles btnAirIntakeDown.MouseEnter
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnAirIntakeDown_MouseLeave(sender As Object, e As EventArgs) Handles btnAirIntakeDown.MouseLeave
        btnAirIntakeDown.BackgroundImage = My.Resources.arrow_down_neutral
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        Me.SuspendLayout()
        lblAirIntakeNumber.Text = Me.devWindow.GetFanIntake
        lblFanStrengthNumber.Text = Me.devWindow.GetFanStrength
        lblInsideTempValue.Text = Me.devWindow.GetTemperature
        If Me.devWindow.GetToggleWindow = 1 Then
            btnToggleWindows.BackgroundImage = My.Resources.toggle_on
        Else
            btnToggleWindows.BackgroundImage = My.Resources.toggle_off
        End If
        Me.ResumeLayout()
    End Sub
End Class