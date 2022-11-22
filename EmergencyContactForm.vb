Public Class EmergencyContactForm
    Dim user As String
    Dim scenario As Integer
    Dim devWindow As DevForm
    Dim previousForm As AccidentNotification

    Dim messageIndex = 0
    Dim messageName() = New String() {"", "", "Dispatcher:", "John Smith:", "Dispatcher:", "", ""}
    Dim messageMssg() = New String() {"Calling...", "", "991, what is your emergency?", "I'd like to request an ambulence", "Understood, they are on their way", "", "End Call"}
    Public Sub New(user As String, scenario As Integer, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devWindow = devForm : Me.previousForm = previousForm
    End Sub

    Private Sub EmergencyContactForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblMessage.Text = ""
    End Sub

    '----------------
    '--- Buttons ---
    '----------------

    Private Sub callPicBox_Click(sender As Object, e As EventArgs) Handles imgCall.Click
        Me.lblTitle.Text = "Emergency Call"
        Me.imgEndCall.Visible = True
        Me.imgCall.Visible = False
        Me.imgNoCall.Visible = False
        Me.tmrCall.Start()
    End Sub

    Private Sub endCall_Click(sender As Object, e As EventArgs) Handles imgEndCall.Click, imgNoCall.Click
        Me.Close()
    End Sub

    '-------------
    '--- Timer ---
    '-------------
    Private Sub tmrCall_Tick(sender As Object, e As EventArgs) Handles tmrCall.Tick
        If messageIndex <> 0 Then
            Me.lblName.Text += vbCrLf
            Me.lblMessage.Text += vbCrLf
        End If

        Me.lblName.Text += Me.messageName(Me.messageIndex)
        Me.lblMessage.Text += Me.messageMssg(Me.messageIndex)
        Me.messageIndex += 1
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(410, 380)
    End Sub

    Private Sub Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x = 0
        Dim y = 0
        If Me.user = "rider" Then
            x = DevForm.GetRiderLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetRiderLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        ElseIf Me.user = "owner" Then
            x = DevForm.GetOwnerLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetOwnerLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        End If
        Me.Location = New Size(x, y)
    End Sub

    '----------------
    '--- On Close ---
    '----------------
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Close()
        Me.devWindow.ClosePopup(Me.user)
        AccidentNotification.emergencyOpened = False
        AccidentNotification.CloseAllForms()
    End Sub

End Class