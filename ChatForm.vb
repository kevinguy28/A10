Public Class ChatForm
    Inherits AppForm

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm
    End Sub

    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Chat")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
    End Sub


End Class