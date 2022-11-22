Public Class NotificationForm
    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Public Sub New(user As String, scenario As Integer, homeForm As HomeForm)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.homeWindow = homeForm
    End Sub
    Function SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "rider" Then
            Return ((halfScreen - halfDev) / 2) - halfHome

        Else
            Return (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
        End If
    End Function

    Public Sub changeTitle(title As String)
        Me.lblTitle.Text = title
    End Sub

End Class