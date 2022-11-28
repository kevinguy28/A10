Imports System.Security.Authentication.ExtendedProtection

Public Class ChooseStationForm
    Dim user As String
    Dim scenario As Integer
    Dim devWindow As DevForm

    Public aNotification As LowBatteryResponseForm
    Public Sub New(user As String, scenario As Integer, devWindow As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.devWindow = devWindow

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub ChooseStationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Choose Station"
            Case "rider"
                Me.Text = "Car Rider Choose Station"
        End Select

        Me.lblStationAddress.Text = rb1.Text
    End Sub

    ' ---------------
    ' --- Buttons ---
    ' ---------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        LowBatteryNotificationForm.CreateResponseForm(False, lblStationAddress.Text)
        Me.Close()
    End Sub

    ' ---------------------
    ' --- Radio Buttons ---
    ' ---------------------

    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rb1.CheckedChanged, rb2.CheckedChanged, rb3.CheckedChanged, rb4.CheckedChanged, rb5.CheckedChanged, rb6.CheckedChanged
        If DirectCast(sender, RadioButton).Checked = True Then
            DirectCast(sender, RadioButton).BackColor = Color.FromArgb(120, 145, 141)
            Me.lblStationAddress.Text = DirectCast(sender, RadioButton).Tag
        Else
            DirectCast(sender, RadioButton).BackColor = Color.FromArgb(151, 203, 197)
        End If
    End Sub

    Private Sub rb1_Click(sender As Object, e As EventArgs) Handles rb1.Click
        Me.pbMap.Image = My.Resources.the_map_rb1
        'Me.homeWindow.changeMap(My.Resources.the_map_rb1)
        'Me.homeWindow.otherForm.changeMap(My.Resources.the_map_rb1)
    End Sub

    Private Sub rb2_Click(sender As Object, e As EventArgs) Handles rb2.Click
        Me.pbMap.Image = My.Resources.the_map_rb2
        'Me.devWindow.GetOwnerHomeForm.changeMap(My.Resources.the_map_rb2)
    End Sub
    Private Sub rb3_Click(sender As Object, e As EventArgs) Handles rb3.Click
        Me.pbMap.Image = My.Resources.the_map_rb3
        'Me.devWindow.GetOwnerHomeForm.changeMap(My.Resources.the_map_rb3)
    End Sub

    Private Sub rb4_Click(sender As Object, e As EventArgs) Handles rb4.Click
        Me.pbMap.Image = My.Resources.the_map_rb4
        'Me.devWindow.GetOwnerHomeForm.changeMap(My.Resources.the_map_rb4)
    End Sub

    Private Sub rb5_Click(sender As Object, e As EventArgs) Handles rb5.Click
        Me.pbMap.Image = My.Resources.the_map_rb5
        'Me.devWindow.GetOwnerHomeForm.changeMap(My.Resources.the_map_rb5)
    End Sub

    Private Sub rb6_Click(sender As Object, e As EventArgs) Handles rb6.Click
        Me.pbMap.Image = My.Resources.the_map_rb6
        'Me.devWindow.GetOwnerHomeForm.changeMapp(My.Resources.the_map_rb6)
    End Sub

    Private Sub rb_MouseEnter(sender As Object, e As EventArgs) Handles rb1.MouseEnter, rb2.MouseEnter, rb3.MouseEnter, rb4.MouseEnter, rb5.MouseEnter, rb6.MouseEnter
        CType(sender, RadioButton).BackColor = Color.FromArgb(127, 242, 229)
    End Sub

    Private Sub rb_MouseLeave(sender As Object, e As EventArgs) Handles rb1.MouseLeave, rb2.MouseLeave, rb3.MouseLeave, rb4.MouseLeave, rb5.MouseLeave, rb6.MouseLeave
        CType(sender, RadioButton).BackColor = Color.FromArgb(151, 203, 197)
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(455, 600)
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

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub CalendarCarConfirmForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.devWindow.ClosePopup(Me.user)
        LowBatteryNotificationForm.CloseAllForms()
    End Sub
End Class