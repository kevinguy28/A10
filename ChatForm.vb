Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Chat"
            Case "rider"
                Me.Text = "Car Rider Chat"
        End Select

        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Chat")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)

        ' Set properties
        Me.btnSubmit.BackColor = colourNeutral
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = colourHover

        ' Images
        Me.imgList.Images.Add("Jane Doe", My.Resources.OwnerProfile)
        Me.imgList.Images.Add("John Smith", My.Resources.RiderProfile)
        Me.imgList.ImageSize = New Size(30, 30)

        ' List View
        Me.lstView.View = View.Details
        Me.lstView.Columns.Add("Name", 125, HorizontalAlignment.Left)
        Me.lstView.Columns.Add("Message", 407 - 125 - 6, HorizontalAlignment.Left)
        Me.lstView.SmallImageList = Me.imgList
        Me.lstView.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Me.lstView.LabelWrap = True

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
        Me.SuspendLayout()
        Me.lstView.SuspendLayout()

        Dim chatHistory As List(Of ChatMessage) = Me.devWindow.GetChatHistory()

        Me.lstView.Items.Clear()

        For Each chatMessage In chatHistory
            Dim lstStr(1) As String
            lstStr(0) = chatMessage.username
            lstStr(1) = chatMessage.message
            Dim lstItem = New ListViewItem(lstStr)
            lstItem.ImageKey = chatMessage.username
            lstItem.Font = New Font("Segoe UI", 13)
            lstItem.UseItemStyleForSubItems = True
            Me.lstView.Items.Add(lstItem)
        Next

        Me.lstView.ResumeLayout()
        Me.ResumeLayout()
    End Sub
End Class