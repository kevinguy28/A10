Public Class CarCameraForm
    Inherits AppForm
    Public Sub New(user As String, scenario As Integer, previousForm As CarFeatureForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.previousWindow = previousForm : Me.homeWindow = homeForm : Me.devWindow = devForm
    End Sub

    Private Sub CarCameraForm_load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetBackground()
        Me.CreateTitleLabel("Car Camera")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        Me.SetLocation()

        Me.Text = "Car Owner Camera View"
    End Sub

    Private Sub btnFrontInterior_Click(sender As Object, e As EventArgs) Handles btnFrontInterior.Click
        Me.pbCameraView.Image = My.Resources.in_front
        Me.lblTitle.Text = "Front Interior"
    End Sub

    Private Sub btnBackInterior_Click(sender As Object, e As EventArgs) Handles btnBackInterior.Click
        Me.pbCameraView.Image = My.Resources.in_back
        Me.lblTitle.Text = "Back Interior"
    End Sub

    Private Sub btnFrontExterior_Click(sender As Object, e As EventArgs) Handles btnFrontExterior.Click
        Me.pbCameraView.Image = My.Resources.out_front
        Me.lblTitle.Text = "Front Exterior"
    End Sub

    Private Sub btnBackExterior_Click(sender As Object, e As EventArgs) Handles btnBackExterior.Click
        Me.pbCameraView.Image = My.Resources.out_back
        Me.lblTitle.Text = "Back Exterior"
    End Sub
End Class