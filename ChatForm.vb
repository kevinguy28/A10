Public Class ChatForm
    Inherits AppForm

    Dim colourHover = Color.FromArgb(127, 242, 229)
    Dim colourNeutral = Color.FromArgb(151, 203, 197)

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm
    End Sub

    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Chat")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)

        ' Set properties
        Me.btnSubmit.BackColor = colourNeutral
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = colourHover

        ' Start timer
        Me.tmrCheckChat.Start()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim profilePicture
        Dim username
        Dim message = Me.txtChatMessage.Text
        Select Case Me.user
            Case "owner"
                profilePicture = My.Resources.OwnerProfile
                username = "Jane Doe"
            Case "rider"
                profilePicture = My.Resources.RiderProfile
                username = "John Smith"
        End Select

        Dim chatMessage = New ChatMessage(profilePicture, username, message)
        Me.devWindow.AddChat(chatMessage)

        Me.txtChatMessage.Text = ""
    End Sub

    Private Sub tmrCheckChat_Tick(sender As Object, e As EventArgs) Handles tmrCheckChat.Tick
        Dim chatHistory As List(Of ChatMessage) = Me.devWindow.GetChatHistory()


        Me.lblChat.Text = ""

        For Each chatMessage In chatHistory
            Me.lblChat.Text += chatMessage.username & ": " & chatMessage.message & vbCrLf
        Next
    End Sub
End Class