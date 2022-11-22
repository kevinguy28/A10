Public Class CallForm
    Dim user As String
    Dim scenario As Integer

    Dim messageIndex = 0
    Dim messageName() = New String() {"", "", "Dispatcher:", "John Smith:", "Dispatcher:", "", ""}
    Dim messageMssg() = New String() {"Calling...", "", "991, what is your emergency?", "I'd like to request an ambulence.", "Ok, they are on their way.", "", "...End Call"}

    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario
    End Sub

    Private Sub CallForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Call"
            Case "rider"
                Me.Text = "Car Rider Call"
        End Select

        If Me.user = "owner" Then
            Me.messageName(3) = "Jane Doe:"
        End If
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

        Me.tmrCall.Start()
    End Sub

    Private Sub endCallPicBox_Click(sender As Object, e As EventArgs) Handles endCallPicBox.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub noCallPicBox_Click(sender As Object, e As EventArgs) Handles noCallPicBox.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tmrCall_Tick(sender As Object, e As EventArgs) Handles tmrCall.Tick
        If messageIndex <> 0 Then
            Me.lblCalling.Text += vbCrLf
        End If

        Me.lblCalling.Text += Me.messageName(Me.messageIndex) & " " & Me.messageMssg(Me.messageIndex)
        Me.messageIndex += 1
        If Me.messageIndex = 7 Then
            tmrCall.Stop()
        End If
    End Sub
End Class