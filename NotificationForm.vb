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

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Notification"
            Case "rider"
                Me.Text = "Car Rider Notification"
        End Select
    End Sub

    Function SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "rider" Then
            Me.Location = New Point(((halfScreen - halfDev) / 2) - halfHome, 0)

        Else
            Me.Location = New Point((fullScreen - ((halfScreen - halfDev) / 2)) - halfHome, 0)
        End If
    End Function

    Function SetOtherLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "owner" Then
            Me.Location = New Point(((halfScreen - halfDev) / 2) - halfHome, 0)

        Else
            Me.Location = New Point((fullScreen - ((halfScreen - halfDev) / 2)) - halfHome, 0)
        End If
    End Function

    Public Sub changeTitle(title As String)
        Me.lblTitle.Text = title
    End Sub

    Public Sub changeDescription(description As String)
        Me.lblDescription.Text = description
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim ownerNotification As New NotificationForm("rider", Me.scenario, Me.homeWindow)
        ownerNotification.Show() : ownerNotification.changeTitle("Car Stopped") : ownerNotification.SetLocation() : ownerNotification.changeDescription("The rider has stopped the vehicle.")
        Me.Close()
    End Sub

    Public Sub makeBtnVisible()
        Me.btnApprove.Visible = True : Me.btnDeny.Visible = True : Me.btnConfirm.Visible = False
    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        Me.Close()
    End Sub
End Class