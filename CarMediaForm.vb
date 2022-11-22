
Public Class CarMediaForm
    Inherits AppForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

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
        '  Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        ' Me.Controls.Add(Me.btnHome)

        'to set the volume keys
    End Sub

    Private Sub btnSpeakersToggle_Click(sender As Object, e As EventArgs) Handles btnSpeakersToggle.Click
        If btnSpeakersToggle.Tag = 1 Then
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_off
            btnSpeakersToggle.Tag = 0
        Else
            btnSpeakersToggle.BackgroundImage = My.Resources.toggle_on
            btnSpeakersToggle.Tag = 1
        End If
    End Sub

    Private Sub btnVolumeUp_Click(sender As Object, e As EventArgs) Handles btnVolumeUp.Click
        btnVolumeUp.BackgroundImage = My.Resources.arrow_up_press
        If Not lblVolumeNumber.Tag = 10 Then
            lblVolumeNumber.Tag += 1
            lblVolumeNumber.Text = lblVolumeNumber.Tag
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
        If Not lblVolumeNumber.Tag = 1 Then
            lblVolumeNumber.Tag -= 1
            lblVolumeNumber.Text = lblVolumeNumber.Tag

        End If
    End Sub

    Private Sub btnVolumeDown_MouseEnter(sender As Object, e As EventArgs) Handles btnVolumeDown.MouseEnter
        btnVolumeDown.BackgroundImage = My.Resources.arrow_down_hover
    End Sub

    Private Sub btnVolumeDown_MouseLeave(sender As Object, e As EventArgs) Handles btnVolumeDown.MouseLeave
        btnVolumeDown.BackgroundImage = My.Resources.arrow_down_neutral

    End Sub

    Private Sub btnConnectPhone_Click(sender As Object, e As EventArgs) Handles btnConnectPhone.Click
        If btnConnectPhone.Tag = 0 Then
            MsgBox("Phone is now connected.")
            btnConnectPhone.Tag = 1
            btnConnectPhone.Text = "Disconnect Phone"
        Else

            MsgBox("Phone is now disconnected.")
            btnConnectPhone.Text = "Connect Phone"
            btnConnectPhone.Tag = 0

        End If
    End Sub

End Class