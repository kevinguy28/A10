Public Class CarDiagnosticForm
    Inherits AppForm

    Dim callForm As CallForm

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
    Private Sub CarDiagnosticForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetLocation()
        Me.SetBackground()
        Me.CreateTitleLabel("Diagnostic")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        For i As Integer = 0 To 6
            If Me.scenario = 2 And (i = 0 Or i = 1 Or i = 3) Then
                Me.lbDiagnostic.Items(i) = Me.lbDiagnostic.Items(i) + "Damaged"
            Else
                Me.lbDiagnostic.Items(i) = Me.lbDiagnostic.Items(i) + "Good"
            End If
        Next
    End Sub

    Private Sub btnTow_Click(sender As Object, e As EventArgs) Handles btnTow.Click
        Me.callForm = New CallForm(Me.user, Me.scenario) : Me.callForm.setLocation()
        Me.callForm.Show()
    End Sub
End Class