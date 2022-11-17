Public Class EmergencyContactForm
    Dim user As String
    Dim scenario As Integer
    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
    End Sub

    Function SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "owner" Then
            Return ((halfScreen - halfDev) / 2) - halfHome

        Else
            Return (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
        End If
    End Function

    Private Sub callPicBox_Click(sender As Object, e As EventArgs) Handles callPicBox.Click
        Me.label2.Text = "Emergency Call -" : Me.label3.Text = "calling ..." : Me.endCallPicBox.Visible = True : Me.callPicBox.Visible = False : Me.noCallPicBox.Visible = False
    End Sub

    Private Sub endCall_Click(sender As Object, e As EventArgs) Handles endCallPicBox.Click, noCallPicBox.Click
        Me.Close()
    End Sub
End Class