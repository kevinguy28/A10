<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnRoute = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.lblChat = New System.Windows.Forms.Label()
        Me.imgAvatar = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tmrAccident = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.imgLogo.Location = New System.Drawing.Point(163, 86)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(140, 90)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 9
        Me.imgLogo.TabStop = False
        '
        'btnCalendar
        '
        Me.btnCalendar.BackgroundImage = Global.A10.My.Resources.Resources.Calendar
        Me.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalendar.FlatAppearance.BorderSize = 0
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Location = New System.Drawing.Point(116, 223)
        Me.btnCalendar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(105, 90)
        Me.btnCalendar.TabIndex = 10
        Me.btnCalendar.TabStop = False
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnCar
        '
        Me.btnCar.BackgroundImage = Global.A10.My.Resources.Resources.Car
        Me.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCar.FlatAppearance.BorderSize = 0
        Me.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCar.Location = New System.Drawing.Point(246, 223)
        Me.btnCar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(105, 90)
        Me.btnCar.TabIndex = 11
        Me.btnCar.TabStop = False
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'btnRoute
        '
        Me.btnRoute.BackgroundImage = Global.A10.My.Resources.Resources.Map
        Me.btnRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRoute.FlatAppearance.BorderSize = 0
        Me.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoute.Location = New System.Drawing.Point(116, 353)
        Me.btnRoute.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRoute.Name = "btnRoute"
        Me.btnRoute.Size = New System.Drawing.Size(105, 90)
        Me.btnRoute.TabIndex = 12
        Me.btnRoute.TabStop = False
        Me.btnRoute.UseVisualStyleBackColor = True
        '
        'btnChat
        '
        Me.btnChat.BackgroundImage = Global.A10.My.Resources.Resources.Chat
        Me.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Location = New System.Drawing.Point(246, 353)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(105, 90)
        Me.btnChat.TabIndex = 13
        Me.btnChat.TabStop = False
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'lblCalendar
        '
        Me.lblCalendar.BackColor = System.Drawing.Color.White
        Me.lblCalendar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalendar.Location = New System.Drawing.Point(125, 199)
        Me.lblCalendar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(105, 23)
        Me.lblCalendar.TabIndex = 18
        Me.lblCalendar.Text = "Calendar"
        Me.lblCalendar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.Color.White
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(255, 199)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(105, 23)
        Me.lblCar.TabIndex = 19
        Me.lblCar.Text = "Car"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRoute
        '
        Me.lblRoute.BackColor = System.Drawing.Color.White
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRoute.Location = New System.Drawing.Point(125, 328)
        Me.lblRoute.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(105, 23)
        Me.lblRoute.TabIndex = 20
        Me.lblRoute.Text = "My Route"
        Me.lblRoute.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblChat
        '
        Me.lblChat.BackColor = System.Drawing.Color.White
        Me.lblChat.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblChat.Location = New System.Drawing.Point(255, 328)
        Me.lblChat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(105, 23)
        Me.lblChat.TabIndex = 21
        Me.lblChat.Text = "Chat"
        Me.lblChat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgAvatar
        '
        Me.imgAvatar.BackColor = System.Drawing.Color.White
        Me.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgAvatar.Image = Global.A10.My.Resources.Resources.OwnerProfile
        Me.imgAvatar.Location = New System.Drawing.Point(200, 26)
        Me.imgAvatar.Margin = New System.Windows.Forms.Padding(2)
        Me.imgAvatar.Name = "imgAvatar"
        Me.imgAvatar.Size = New System.Drawing.Size(35, 30)
        Me.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAvatar.TabIndex = 22
        Me.imgAvatar.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(235, 33)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Name"
        '
        'tmrAccident
        '
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(466, 952)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgAvatar)
        Me.Controls.Add(Me.lblChat)
        Me.Controls.Add(Me.lblRoute)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblCalendar)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnRoute)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.btnCalendar)
        Me.Controls.Add(Me.imgLogo)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnCar As Button
    Friend WithEvents btnRoute As Button
    Friend WithEvents btnChat As Button
    Friend WithEvents lblCalendar As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblChat As Label
    Friend WithEvents imgAvatar As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents tmrAccident As Timer
End Class
