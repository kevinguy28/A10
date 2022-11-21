<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalendarCarSelectForm
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
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTimePrompt = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flPanel
        '
        Me.flPanel.BackColor = System.Drawing.Color.White
        Me.flPanel.Location = New System.Drawing.Point(32, 341)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.Size = New System.Drawing.Size(420, 380)
        Me.flPanel.TabIndex = 2
        '
        'lblTimePrompt
        '
        Me.lblTimePrompt.BackColor = System.Drawing.Color.White
        Me.lblTimePrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimePrompt.Location = New System.Drawing.Point(32, 175)
        Me.lblTimePrompt.Name = "lblTimePrompt"
        Me.lblTimePrompt.Size = New System.Drawing.Size(420, 25)
        Me.lblTimePrompt.TabIndex = 3
        Me.lblTimePrompt.Text = "These rides are available between"
        Me.lblTimePrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.Color.White
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(32, 250)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(184, 25)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Your selected ride is:"
        Me.lblPrompt.Visible = False
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.Color.White
        Me.imgProfilePicture.Location = New System.Drawing.Point(38, 278)
        Me.imgProfilePicture.Name = "imgProfilePicture"
        Me.imgProfilePicture.Size = New System.Drawing.Size(50, 50)
        Me.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProfilePicture.TabIndex = 5
        Me.imgProfilePicture.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(94, 278)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.Color.White
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(94, 308)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(347, 30)
        Me.lblCar.TabIndex = 8
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.BackColor = System.Drawing.Color.White
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(33, 200)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(55, 25)
        Me.lblFromPrompt.TabIndex = 11
        Me.lblFromPrompt.Text = "from:"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.BackColor = System.Drawing.Color.White
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(33, 225)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(33, 25)
        Me.lblToPrompt.TabIndex = 10
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(88, 200)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(364, 50)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "lblAvblty"
        '
        'btnBook
        '
        Me.btnBook.Enabled = False
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBook.Location = New System.Drawing.Point(92, 732)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(300, 60)
        Me.btnBook.TabIndex = 12
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'lblTop
        '
        Me.lblTop.BackColor = System.Drawing.Color.Gray
        Me.lblTop.Location = New System.Drawing.Point(32, 273)
        Me.lblTop.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(420, 3)
        Me.lblTop.TabIndex = 13
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.Color.Gray
        Me.lblLeft.Location = New System.Drawing.Point(32, 273)
        Me.lblLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(3, 68)
        Me.lblLeft.TabIndex = 14
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.Color.Gray
        Me.lblRight.Location = New System.Drawing.Point(449, 273)
        Me.lblRight.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(3, 68)
        Me.lblRight.TabIndex = 15
        '
        'CalendarCarSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblTimePrompt)
        Me.Controls.Add(Me.flPanel)
        Me.DoubleBuffered = True
        Me.Name = "CalendarCarSelectForm"
        Me.Text = "CalendarCarSelect"
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flPanel As FlowLayoutPanel
    Friend WithEvents lblTimePrompt As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents lblTop As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblRight As Label
End Class
