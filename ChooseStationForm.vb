Imports System.Security.Authentication.ExtendedProtection

Public Class ChooseStationForm
    Dim user As String
    Dim scenario As Integer
    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario
    End Sub

    Public Sub setLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.GetDevWidth() / 2
        Dim halfForm = DevForm.GetFormWidth() / 2

        If Me.user = "rider" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfForm
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "owner" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rb1.CheckedChanged, rb2.CheckedChanged, rb3.CheckedChanged, rb4.CheckedChanged, rb5.CheckedChanged, rb6.CheckedChanged
        If DirectCast(sender, RadioButton).Checked = True Then
            DirectCast(sender, RadioButton).BackColor = Color.Green
            Me.lblStationAddress.Text = DirectCast(sender, RadioButton).Tag
        Else
            DirectCast(sender, RadioButton).BackColor = Color.Red
        End If
    End Sub

    Private Sub ChooseStationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblStationAddress.Text = rb1.Text
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub
End Class