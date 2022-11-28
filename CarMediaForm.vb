
Public Class CarMediaForm
    Inherits AppForm
    Public Sub New(user As String, scenario As Integer, previousForm As CarForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.previousWindow = previousForm : Me.homeWindow = homeForm : Me.devWindow = devForm
    End Sub
    Private Sub CarMediaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Media"
            Case "rider"
                Me.Text = "Car Rider Car Media"
        End Select

        Me.SetBackground()
        Me.CreateTitleLabel("Car Media Settings")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        tmrSync.Start()
    End Sub

    Private Sub btnSpeakersToggle_Click(sender As Object, e As EventArgs) Handles btnSpeakersToggle.Click
        If Me.devWindow.GetSpeakerOnOff = 1 Then
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_off
            Me.devWindow.UpdateSpeakerOnOff(0)
        Else
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_on
            Me.devWindow.UpdateSpeakerOnOff(1)
        End If
    End Sub

    Private Sub btnVolumeUp_Click(sender As Object, e As EventArgs) Handles btnVolumeUp.Click
        btnVolumeUp.BackgroundImage = My.Resources.arrow_up_press
        If Not Me.devWindow.GetSpeakerVolume = 10 Then
            Me.devWindow.UpdateSpeakerVolume(1)
            lblVolumeNumber.Text = Me.devWindow.GetSpeakerVolume
        End If
    End Sub


    Private Sub btnVolumeUp_MouseEnter(sender As Object, e As EventArgs) Handles btnVolumeUp.MouseEnter
        btnVolumeUp.BackColor = Color.White
        btnVolumeUp.BackgroundImage = My.Resources.arrow_up_hover
    End Sub

    Private Sub btnVolumeUp_Leave(sender As Object, e As EventArgs) Handles btnVolumeUp.MouseLeave
        btnVolumeUp.BackgroundImage = My.Resources.arrow_up_neutral
    End Sub

    Private Sub btnVolumeDown_Click(sender As Object, e As EventArgs) Handles btnVolumeDown.Click
        btnVolumeDown.BackgroundImage = My.Resources.arrow_down_press
        If Not Me.devWindow.GetSpeakerVolume = 1 Then
            Me.devWindow.UpdateSpeakerVolume(-1)
            lblVolumeNumber.Text = Me.devWindow.GetSpeakerVolume
        End If
    End Sub

    Private Sub btnVolumeDown_MouseEnter(sender As Object, e As EventArgs) Handles btnVolumeDown.MouseEnter
        btnVolumeDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnVolumeDown_MouseLeave(sender As Object, e As EventArgs) Handles btnVolumeDown.MouseLeave
        btnVolumeDown.BackgroundImage = My.Resources.arrow_down_neutral

    End Sub

    Private Sub btnConnectPhone_Click(sender As Object, e As EventArgs) Handles btnConnectPhone.Click
        If Me.devWindow.GetConnectedPhone = 0 Then
            Me.devWindow.UpdateConnectedPhone(1)
            lblConnected.Visible = True : pbPause.Visible = True : pbPlay.Visible = True : lblSongStatus.Visible = True : lblSongTitle.Visible = True
            btnConnectPhone.Text = "Disconnect Phone" : lblSongStatus.Text = "Playing"
            btnConnectPhone.BackColor = Color.IndianRed
        Else
            Me.devWindow.UpdateConnectedPhone(0)
            lblConnected.Visible = False : pbPause.Visible = False : pbPlay.Visible = False : lblSongStatus.Visible = False : lblSongTitle.Visible = False
            btnConnectPhone.Text = "Connect Phone" : lblSongStatus.Text = "Paused"
            btnConnectPhone.BackColor = Color.RoyalBlue
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub tmrSync_Tick(sender As Object, e As EventArgs) Handles tmrSync.Tick
        Me.SuspendLayout()
        Me.lblVolumeNumber.Text = Me.devWindow.GetSpeakerVolume
        If Me.devWindow.GetSpeakerOnOff = 1 Then
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_on
        Else
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_off
        End If
        If Me.devWindow.GetConnectedPhone = 0 Then
            lblConnected.Visible = False : pbPause.Visible = False : pbPlay.Visible = False : lblSongStatus.Visible = False : lblSongTitle.Visible = False
            btnConnectPhone.Text = "Connect Phone" : lblSongStatus.Text = "Paused"
            btnConnectPhone.BackColor = Color.RoyalBlue
        Else
            lblConnected.Visible = True : pbPause.Visible = True : pbPlay.Visible = True : lblSongStatus.Visible = True : lblSongTitle.Visible = True
            btnConnectPhone.Text = "Disconnect Phone" : lblSongStatus.Text = "Playing"
            btnConnectPhone.BackColor = Color.IndianRed
        End If
        Me.ResumeLayout()
    End Sub
    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        My.Computer.Audio.Play(My.Resources.house_of_cards, AudioPlayMode.Background)
    End Sub

    Private Sub pbPause_Click(sender As Object, e As EventArgs) Handles pbPause.Click
        My.Computer.Audio.Stop()
    End Sub
End Class