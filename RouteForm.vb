Imports Microsoft.VisualBasic.ApplicationServices
Public Class RouteForm
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

    Private Sub RouteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Route"
            Case "rider"
                Me.Text = "Car Rider Route"
        End Select

        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Route")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
    End Sub

End Class