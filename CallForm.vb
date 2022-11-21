Public Class CallForm
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

        If Me.user = "owner" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfForm
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "rider" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub callPicBox_Click(sender As Object, e As EventArgs) Handles callPicBox.Click
        pbKeypad.Visible = False : callPicBox.Visible = False : noCallPicBox.Visible = False : endCallPicBox.Visible = True : lblCalling.Visible = True
    End Sub

    Private Sub endCallPicBox_Click(sender As Object, e As EventArgs) Handles endCallPicBox.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub noCallPicBox_Click(sender As Object, e As EventArgs) Handles noCallPicBox.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class