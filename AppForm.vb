Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class AppForm
    Inherits System.Windows.Forms.Form

    Protected user As String
    Protected scenario As Integer

    Protected previousWindow As AppForm
    Protected homeWindow As HomeForm
    Protected devWindow As DevForm

    Protected WithEvents lblTitle As Label
    Protected WithEvents btnHome As Button
    Protected WithEvents btnBack As Button
    Protected WithEvents btnPlus As Button
    Protected dimOverlay As Panel

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Overridable Sub CloseAllChildren()
        'If (Me.childForm IsNot Nothing) Then
        '    Me.childForm.CloseAllForms()
        'End If
    End Sub

    Public Overridable Sub CloseAllForms()
        Me.CloseAllChildren()
        Me.Dispose()
    End Sub

    Protected Sub SetCurrentForm(form As AppForm)
        If (user = "owner") Then
            Me.devWindow.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devWindow.SetCurrentRiderForm(form)
        End If
    End Sub

    ' ----------------
    ' --- Location ---
    ' ----------------
    Protected Sub Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.SetLocation()
    End Sub

    Protected Sub SetLocation()
        If Me.user = "owner" Then
            Me.Location = DevForm.GetOwnerLocation()
        ElseIf Me.user = "rider" Then
            Me.Location = DevForm.GetRiderLocation()
        End If
    End Sub

    Protected Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = DevForm.GetFormWidth()
        Me.Height = DevForm.GetFormHeight()
    End Sub

    ' ------------------
    ' --- Background ---
    ' ------------------
    Protected Sub SetBackground()
        Me.BackgroundImage = My.Resources.Phone___Form
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CreateDimOverlay()
    End Sub

    ' -------------
    ' --- Title ---
    ' -------------
    Protected Sub CreateTitleLabel(titleText As String)
        Me.lblTitle = New Label
        Me.lblTitle.Text = titleText
        Me.lblTitle.Font = New Font("Segoe UI Semibold", 36.0!, FontStyle.Bold, GraphicsUnit.Point)
        Me.lblTitle.Size = New Size(402, 65)
        Me.lblTitle.Location = New Point(41, 77)
        Me.lblTitle.Margin = New Padding(0)
        Me.lblTitle.Size = New Size(402, 65)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.TextAlign = ContentAlignment.TopCenter
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White
    End Sub

    ' ------------
    ' --- Home ---
    ' ------------
    Protected Sub CreateHomeButton()
        Me.btnHome = New Button
        Me.btnHome.Text = ""
        Me.btnHome.TabStop = False
        Me.btnHome.BackgroundImage = My.Resources.Home
        Me.btnHome.BackgroundImageLayout = ImageLayout.Zoom
        Me.btnHome.FlatStyle = FlatStyle.Flat
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.Size = New Size(75, 75)
        Me.btnHome.Location = New Point(205, 812)
        Me.btnHome.UseVisualStyleBackColor = True
    End Sub

    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)
        Me.homeWindow.CloseAllChildren()
    End Sub

    Protected Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        Me.btnHome.BackgroundImage = My.Resources.Home___Hover
    End Sub

    Protected Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        Me.btnHome.BackgroundImage = My.Resources.Home
    End Sub

    ' ------------
    ' --- Back ---
    ' ------------
    Protected Sub CreateBackButton()
        Me.btnBack = New Button
        Me.btnBack.TabStop = False
        Me.btnBack.BackgroundImage = My.Resources.ArrowBack
        Me.btnBack.BackgroundImageLayout = ImageLayout.Zoom
        Me.btnBack.FlatStyle = FlatStyle.Flat
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.Size = New Size(50, 50)
        Me.btnBack.Location = New Point(38, 824)
        Me.btnBack.UseVisualStyleBackColor = True
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Me.previousWindow.Show()
        Me.SetCurrentForm(Me.previousWindow)
        Me.Dispose()
    End Sub

    Protected Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        Me.btnBack.BackgroundImage = My.Resources.ArrowBack___Hover
    End Sub

    Protected Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        Me.btnBack.BackgroundImage = My.Resources.ArrowBack
    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------
    Protected Sub CreatePlusButton()
        Me.btnPlus = New Button
        Me.btnPlus.TabStop = False
        Me.btnPlus.BackgroundImage = My.Resources.Plus
        Me.btnPlus.BackgroundImageLayout = ImageLayout.Zoom
        Me.btnPlus.FlatStyle = FlatStyle.Flat
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.Size = New Size(75, 75)
        Me.btnPlus.Location = New Point(353, 694)
        Me.btnPlus.UseVisualStyleBackColor = True
    End Sub

    Protected Overridable Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
    End Sub

    Protected Sub btnPlus_MouseEnter(sender As Object, e As EventArgs) Handles btnPlus.MouseEnter
        Me.btnPlus.BackgroundImage = My.Resources.Plus___Hover
    End Sub

    Protected Sub btnPlus_MouseLeave(sender As Object, e As EventArgs) Handles btnPlus.MouseLeave
        Me.btnPlus.BackgroundImage = My.Resources.Plus
    End Sub

    ' ------------------
    ' --- Dim Screen ---
    ' ------------------
    Public Sub CreateDimOverlay()
        Me.dimOverlay = New Panel
        Me.dimOverlay.BackgroundImageLayout = ImageLayout.None
        Me.dimOverlay.Visible = False
        Me.Controls.Add(Me.dimOverlay)
    End Sub

    Public Sub DimScreen()
        Dim clientBitmap As New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height)
        Using bitmap As New Bitmap(DevForm.GetFormWidth, DevForm.GetFormHeight)
            Me.DrawToBitmap(bitmap, New Rectangle(Point.Empty, New Drawing.Size(DevForm.GetFormWidth, DevForm.GetFormHeight)))
            Dim pointToClient As Point = Me.PointToClient(Me.Location)
            Using grphcs As Graphics = Graphics.FromImage(clientBitmap)
                grphcs.DrawImage(bitmap, pointToClient.X, pointToClient.Y, bitmap.Width, bitmap.Height)
            End Using
        End Using

        Using g As Graphics = Graphics.FromImage(clientBitmap), brush As New SolidBrush(Color.FromArgb(128, Color.Black))
            g.FillRectangle(brush, 0, 0, clientBitmap.Width, clientBitmap.Height)
        End Using

        If dimOverlay.BackgroundImage IsNot Nothing Then dimOverlay.BackgroundImage.Dispose()
        dimOverlay.BackgroundImage = clientBitmap
        dimOverlay.Bounds = New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        dimOverlay.BringToFront()
        dimOverlay.Visible = True
    End Sub

    Public Sub UnDimScreen()
        Me.dimOverlay.Visible = False
    End Sub

End Class
