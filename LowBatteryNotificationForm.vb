Public Class LowBatteryNotificationForm
    Dim user As String
    Dim scenario As Integer
    Dim otherForm As HomeForm

    Public Sub New(user As String, scenario As Integer, otherForm As HomeForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.otherForm = otherForm
    End Sub

    Private Sub LowBatteryNotificationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Low Battery"
            Case "rider"
                Me.Text = "Car Rider Low Battery"
        End Select
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
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim chooseStation As New ChooseStationForm("owner", Me.scenario, Me.otherForm) : chooseStation.setLocation()
        chooseStation.Show()
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim chooseStation As New ChooseStationForm("rider", Me.scenario, Me.otherForm) : chooseStation.setLocation()
        chooseStation.lblTitle.Text = "Please choose a station to reroute to. Your bill will be adjusted accordingly."
        chooseStation.Show()
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

End Class