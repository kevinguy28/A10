<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits AppForm

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
        Me.imgEmergency = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmergency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.imgLogo.Location = New System.Drawing.Point(142, 144)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(200, 150)
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
        Me.btnCalendar.Location = New System.Drawing.Point(74, 372)
        Me.btnCalendar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(150, 150)
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
        Me.btnCar.Location = New System.Drawing.Point(260, 372)
        Me.btnCar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(150, 150)
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
        Me.btnRoute.Location = New System.Drawing.Point(74, 588)
        Me.btnRoute.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRoute.Name = "btnRoute"
        Me.btnRoute.Size = New System.Drawing.Size(150, 150)
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
        Me.btnChat.Location = New System.Drawing.Point(260, 588)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(150, 150)
        Me.btnChat.TabIndex = 13
        Me.btnChat.TabStop = False
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'lblCalendar
        '
        Me.lblCalendar.BackColor = System.Drawing.Color.White
        Me.lblCalendar.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalendar.Location = New System.Drawing.Point(74, 332)
        Me.lblCalendar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(150, 38)
        Me.lblCalendar.TabIndex = 18
        Me.lblCalendar.Text = "Calendar"
        Me.lblCalendar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.Color.White
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(260, 332)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(150, 38)
        Me.lblCar.TabIndex = 19
        Me.lblCar.Text = "Car"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRoute
        '
        Me.lblRoute.BackColor = System.Drawing.Color.White
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRoute.Location = New System.Drawing.Point(74, 548)
        Me.lblRoute.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(150, 38)
        Me.lblRoute.TabIndex = 20
        Me.lblRoute.Text = "My Route"
        Me.lblRoute.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblChat
        '
        Me.lblChat.BackColor = System.Drawing.Color.White
        Me.lblChat.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblChat.Location = New System.Drawing.Point(260, 548)
        Me.lblChat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(150, 38)
        Me.lblChat.TabIndex = 21
        Me.lblChat.Text = "Chat"
        Me.lblChat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgAvatar
        '
        Me.imgAvatar.BackColor = System.Drawing.Color.White
        Me.imgAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgAvatar.Image = Global.A10.My.Resources.Resources.OwnerProfile
        Me.imgAvatar.Location = New System.Drawing.Point(291, 44)
        Me.imgAvatar.Margin = New System.Windows.Forms.Padding(2)
        Me.imgAvatar.Name = "imgAvatar"
        Me.imgAvatar.Size = New System.Drawing.Size(50, 50)
        Me.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAvatar.TabIndex = 22
        Me.imgAvatar.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(345, 56)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Name"
        '
        'imgEmergency
        '
        Me.imgEmergency.BackColor = System.Drawing.Color.White
        Me.imgEmergency.Image = Global.A10.My.Resources.Resources.EmergencyHome
        Me.imgEmergency.Location = New System.Drawing.Point(23, 819)
        Me.imgEmergency.Name = "imgEmergency"
        Me.imgEmergency.Size = New System.Drawing.Size(75, 75)
        Me.imgEmergency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEmergency.TabIndex = 24
        Me.imgEmergency.TabStop = False
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.imgEmergency)
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
        CType(Me.imgEmergency, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgEmergency As PictureBox
End Class
