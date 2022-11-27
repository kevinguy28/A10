<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RouteForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pbRoute = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.cmbxStart = New System.Windows.Forms.ComboBox()
        Me.cmbxEnd = New System.Windows.Forms.ComboBox()
        Me.lblHourStart = New System.Windows.Forms.Label()
        Me.lblStartColon = New System.Windows.Forms.Label()
        Me.lblMinuteStart = New System.Windows.Forms.Label()
        Me.lblAmPmStart = New System.Windows.Forms.Label()
        Me.imgStartHourUp = New System.Windows.Forms.PictureBox()
        Me.imgStartMinuteUp = New System.Windows.Forms.PictureBox()
        Me.imgStartAmPmUp = New System.Windows.Forms.PictureBox()
        Me.imgStartHourDown = New System.Windows.Forms.PictureBox()
        Me.imgStartMinuteDown = New System.Windows.Forms.PictureBox()
        Me.imgStartAmPmDown = New System.Windows.Forms.PictureBox()
        Me.tmrMouseHold = New System.Windows.Forms.Timer(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblEta = New System.Windows.Forms.Label()
        Me.txtEta = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartHourUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartMinuteUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartAmPmUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartHourDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartMinuteDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartAmPmDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRoute
        '
        Me.pbRoute.BackgroundImage = Global.A10.My.Resources.Resources.the_map_car
        Me.pbRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRoute.Location = New System.Drawing.Point(24, 169)
        Me.pbRoute.Name = "pbRoute"
        Me.pbRoute.Size = New System.Drawing.Size(436, 286)
        Me.pbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRoute.TabIndex = 0
        Me.pbRoute.TabStop = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnBook.Enabled = False
        Me.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnBook.FlatAppearance.BorderSize = 0
        Me.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(153, 764)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(179, 35)
        Me.btnBook.TabIndex = 13
        Me.btnBook.TabStop = False
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.ForeColor = System.Drawing.Color.White
        Me.lblStartPrompt.Location = New System.Drawing.Point(30, 458)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(425, 30)
        Me.lblStartPrompt.TabIndex = 14
        Me.lblStartPrompt.Text = "Starting Point"
        Me.lblStartPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDes
        '
        Me.lblDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblDes.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDes.ForeColor = System.Drawing.Color.White
        Me.lblDes.Location = New System.Drawing.Point(30, 606)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(425, 30)
        Me.lblDes.TabIndex = 15
        Me.lblDes.Text = "Destination"
        Me.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxStart
        '
        Me.cmbxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStart.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxStart.FormattingEnabled = True
        Me.cmbxStart.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxStart.Location = New System.Drawing.Point(30, 491)
        Me.cmbxStart.Name = "cmbxStart"
        Me.cmbxStart.Size = New System.Drawing.Size(425, 33)
        Me.cmbxStart.TabIndex = 16
        '
        'cmbxEnd
        '
        Me.cmbxEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEnd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxEnd.FormattingEnabled = True
        Me.cmbxEnd.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxEnd.Location = New System.Drawing.Point(30, 639)
        Me.cmbxEnd.Name = "cmbxEnd"
        Me.cmbxEnd.Size = New System.Drawing.Size(425, 33)
        Me.cmbxEnd.TabIndex = 17
        '
        'lblHourStart
        '
        Me.lblHourStart.BackColor = System.Drawing.Color.White
        Me.lblHourStart.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHourStart.Location = New System.Drawing.Point(165, 548)
        Me.lblHourStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHourStart.Name = "lblHourStart"
        Me.lblHourStart.Size = New System.Drawing.Size(40, 30)
        Me.lblHourStart.TabIndex = 18
        Me.lblHourStart.Text = "00"
        Me.lblHourStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartColon
        '
        Me.lblStartColon.BackColor = System.Drawing.Color.White
        Me.lblStartColon.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartColon.Location = New System.Drawing.Point(202, 548)
        Me.lblStartColon.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartColon.Name = "lblStartColon"
        Me.lblStartColon.Size = New System.Drawing.Size(20, 30)
        Me.lblStartColon.TabIndex = 19
        Me.lblStartColon.Text = ":"
        Me.lblStartColon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinuteStart
        '
        Me.lblMinuteStart.BackColor = System.Drawing.Color.White
        Me.lblMinuteStart.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMinuteStart.Location = New System.Drawing.Point(221, 548)
        Me.lblMinuteStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMinuteStart.Name = "lblMinuteStart"
        Me.lblMinuteStart.Size = New System.Drawing.Size(40, 30)
        Me.lblMinuteStart.TabIndex = 20
        Me.lblMinuteStart.Text = "00"
        Me.lblMinuteStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmPmStart
        '
        Me.lblAmPmStart.BackColor = System.Drawing.Color.White
        Me.lblAmPmStart.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAmPmStart.Location = New System.Drawing.Point(275, 548)
        Me.lblAmPmStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAmPmStart.Name = "lblAmPmStart"
        Me.lblAmPmStart.Size = New System.Drawing.Size(45, 30)
        Me.lblAmPmStart.TabIndex = 21
        Me.lblAmPmStart.Text = "am"
        Me.lblAmPmStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgStartHourUp
        '
        Me.imgStartHourUp.BackColor = System.Drawing.Color.White
        Me.imgStartHourUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgStartHourUp.Location = New System.Drawing.Point(170, 527)
        Me.imgStartHourUp.Name = "imgStartHourUp"
        Me.imgStartHourUp.Size = New System.Drawing.Size(25, 25)
        Me.imgStartHourUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartHourUp.TabIndex = 22
        Me.imgStartHourUp.TabStop = False
        '
        'imgStartMinuteUp
        '
        Me.imgStartMinuteUp.BackColor = System.Drawing.Color.White
        Me.imgStartMinuteUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgStartMinuteUp.Location = New System.Drawing.Point(227, 527)
        Me.imgStartMinuteUp.Name = "imgStartMinuteUp"
        Me.imgStartMinuteUp.Size = New System.Drawing.Size(25, 25)
        Me.imgStartMinuteUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartMinuteUp.TabIndex = 23
        Me.imgStartMinuteUp.TabStop = False
        '
        'imgStartAmPmUp
        '
        Me.imgStartAmPmUp.BackColor = System.Drawing.Color.White
        Me.imgStartAmPmUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgStartAmPmUp.Location = New System.Drawing.Point(284, 527)
        Me.imgStartAmPmUp.Name = "imgStartAmPmUp"
        Me.imgStartAmPmUp.Size = New System.Drawing.Size(25, 25)
        Me.imgStartAmPmUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartAmPmUp.TabIndex = 24
        Me.imgStartAmPmUp.TabStop = False
        '
        'imgStartHourDown
        '
        Me.imgStartHourDown.BackColor = System.Drawing.Color.White
        Me.imgStartHourDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgStartHourDown.Location = New System.Drawing.Point(170, 576)
        Me.imgStartHourDown.Name = "imgStartHourDown"
        Me.imgStartHourDown.Size = New System.Drawing.Size(25, 25)
        Me.imgStartHourDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartHourDown.TabIndex = 25
        Me.imgStartHourDown.TabStop = False
        '
        'imgStartMinuteDown
        '
        Me.imgStartMinuteDown.BackColor = System.Drawing.Color.White
        Me.imgStartMinuteDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgStartMinuteDown.Location = New System.Drawing.Point(227, 576)
        Me.imgStartMinuteDown.Name = "imgStartMinuteDown"
        Me.imgStartMinuteDown.Size = New System.Drawing.Size(25, 25)
        Me.imgStartMinuteDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartMinuteDown.TabIndex = 26
        Me.imgStartMinuteDown.TabStop = False
        '
        'imgStartAmPmDown
        '
        Me.imgStartAmPmDown.BackColor = System.Drawing.Color.White
        Me.imgStartAmPmDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgStartAmPmDown.Location = New System.Drawing.Point(284, 576)
        Me.imgStartAmPmDown.Name = "imgStartAmPmDown"
        Me.imgStartAmPmDown.Size = New System.Drawing.Size(25, 25)
        Me.imgStartAmPmDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStartAmPmDown.TabIndex = 27
        Me.imgStartAmPmDown.TabStop = False
        '
        'tmrMouseHold
        '
        Me.tmrMouseHold.Interval = 10
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblError.Location = New System.Drawing.Point(30, 300)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(425, 25)
        Me.lblError.TabIndex = 38
        Me.lblError.Text = "lblError"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'lblEta
        '
        Me.lblEta.AutoSize = True
        Me.lblEta.BackColor = System.Drawing.Color.White
        Me.lblEta.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEta.Location = New System.Drawing.Point(30, 681)
        Me.lblEta.Name = "lblEta"
        Me.lblEta.Size = New System.Drawing.Size(226, 25)
        Me.lblEta.TabIndex = 39
        Me.lblEta.Text = "Estimated Time of Arrival:"
        Me.lblEta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEta
        '
        Me.txtEta.Enabled = False
        Me.txtEta.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEta.Location = New System.Drawing.Point(262, 678)
        Me.txtEta.Name = "txtEta"
        Me.txtEta.Size = New System.Drawing.Size(193, 32)
        Me.txtEta.TabIndex = 40
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(198, 719)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(58, 25)
        Me.lblPrice.TabIndex = 41
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.Location = New System.Drawing.Point(262, 716)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(193, 32)
        Me.txtPrice.TabIndex = 42
        '
        'RouteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtEta)
        Me.Controls.Add(Me.lblEta)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.imgStartAmPmDown)
        Me.Controls.Add(Me.imgStartMinuteDown)
        Me.Controls.Add(Me.imgStartHourDown)
        Me.Controls.Add(Me.imgStartAmPmUp)
        Me.Controls.Add(Me.imgStartMinuteUp)
        Me.Controls.Add(Me.imgStartHourUp)
        Me.Controls.Add(Me.lblAmPmStart)
        Me.Controls.Add(Me.lblMinuteStart)
        Me.Controls.Add(Me.lblStartColon)
        Me.Controls.Add(Me.lblHourStart)
        Me.Controls.Add(Me.cmbxEnd)
        Me.Controls.Add(Me.cmbxStart)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.lblStartPrompt)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.pbRoute)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RouteForm"
        Me.Text = "RouteForm"
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartHourUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartMinuteUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartAmPmUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartHourDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartMinuteDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStartAmPmDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRoute As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents cmbxStart As ComboBox
    Friend WithEvents cmbxEnd As ComboBox
    Friend WithEvents lblHourStart As Label
    Friend WithEvents lblStartColon As Label
    Friend WithEvents lblMinuteStart As Label
    Friend WithEvents lblAmPmStart As Label
    Friend WithEvents imgStartHourUp As PictureBox
    Friend WithEvents imgStartMinuteUp As PictureBox
    Friend WithEvents imgStartAmPmUp As PictureBox
    Friend WithEvents imgStartHourDown As PictureBox
    Friend WithEvents imgStartMinuteDown As PictureBox
    Friend WithEvents imgStartAmPmDown As PictureBox
    Friend WithEvents tmrMouseHold As Timer
    Friend WithEvents lblError As Label
    Friend WithEvents lblEta As Label
    Friend WithEvents txtEta As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
End Class
