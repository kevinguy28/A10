Public Class CarDiagnosticForm
    Inherits AppForm

    Public Sub New(user As String, Scenario As Integer, previousForm As CarForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = Scenario
        Me.previousWindow = previousForm
        Me.homeWindow = homeForm
        Me.devWindow = devForm
    End Sub

    Private Sub CarDiagnosticForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        ' Add any initialization after the InitializeComponent() call.
        Me.SetBackground()
        Me.CreateTitleLabel("Diagnostic")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
    End Sub
End Class