Public Class CallForm
    Dim user As String
    Dim scenario As Integer
    Dim devWindow As DevForm

    Dim messageIndex = 0
    Dim messageName() = New String() {"", "", "Worker:", "John Smith:", "Worker:", "", ""}
    Dim messageMssg() = New String() {"Calling...", "", "Tow-UR-Car. Hey, what's up?", "I'd like to request a tow.", "Ok, we are on our way.", "", "...End Call"}

    Public Sub New(user As String, scenario As Integer, devWindow As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.devWindow = devWindow

        ' Size and Location
        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
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

        Me.lblName.Text = ""
        Me.lblMessage.Text = ""

    End Sub

    '---------------
    '--- Buttons ---
    '---------------

    Private Sub callPicBox_Click(sender As Object, e As EventArgs) Handles imgCall.Click
        Me.messageMssg(2) = cmbxCompany.Text & ". Hey, what's up?"

        imgCall.Visible = False
        imgNoCall.Visible = False
        imgEndCall.Visible = True
        lblName.Visible = True
        lblMessage.Visible = True

        Me.tmrCall.Start()
    End Sub

    Private Sub endCallPicBox_Click(sender As Object, e As EventArgs) Handles imgEndCall.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub noCallPicBox_Click(sender As Object, e As EventArgs) Handles imgNoCall.Click
        Me.Close()
        Me.Dispose()
    End Sub

    '---------------
    '--- Calling ---
    '---------------

    Private Sub tmrCall_Tick(sender As Object, e As EventArgs) Handles tmrCall.Tick
        If messageIndex <> 0 Then
            Me.lblName.Text += vbCrLf
            Me.lblMessage.Text += vbCrLf
        End If

        Me.lblName.Text += Me.messageName(Me.messageIndex)
        Me.lblMessage.Text += Me.messageMssg(Me.messageIndex)
        Me.messageIndex += 1
        If Me.messageIndex = 7 Then
            tmrCall.Stop()
        End If
    End Sub

    Private Sub cmbxCompany_TextChanged(sender As Object, e As EventArgs) Handles cmbxCompany.TextChanged
        Me.imgCall.Enabled = True
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(410, 433)
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
        Me.devWindow.ClosePopup(Me.user)
        Me.Dispose()
    End Sub
End Class