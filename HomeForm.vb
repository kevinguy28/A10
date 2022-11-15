Imports System.IO

Public Class HomeForm
    Dim user As String
    Dim scenario As Integer

    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario

        If Me.user = "owner" Then
            Me.Text = "Car Owner Home"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Home"
        End If

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.user = "owner" Then
            Me.Location = New Point(Me.Width * 0.25, 0)
        ElseIf Me.user = "rider" Then
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - (Me.Width * 1.25), 0)
        End If
    End Sub
End Class