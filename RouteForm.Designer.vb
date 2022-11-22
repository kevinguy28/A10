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
        Me.btnStart = New System.Windows.Forms.Button()
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
        Me.imgEndAmPmDown = New System.Windows.Forms.PictureBox()
        Me.imgEndMinuteDown = New System.Windows.Forms.PictureBox()
        Me.imgEndHourDown = New System.Windows.Forms.PictureBox()
        Me.imgEndAmPmUp = New System.Windows.Forms.PictureBox()
        Me.imgEndMinuteUp = New System.Windows.Forms.PictureBox()
        Me.imgEndHourUp = New System.Windows.Forms.PictureBox()
        Me.lblAmPmEnd = New System.Windows.Forms.Label()
        Me.lblMinuteEnd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHourEnd = New System.Windows.Forms.Label()
        Me.tmrMouseHold = New System.Windows.Forms.Timer(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartHourUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartMinuteUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartAmPmUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartHourDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartMinuteDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStartAmPmDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndAmPmDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndMinuteDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndHourDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndAmPmUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndMinuteUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEndHourUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRoute
        '
        Me.pbRoute.BackgroundImage = Global.A10.My.Resources.Resources.the_map
        Me.pbRoute.Location = New System.Drawing.Point(24, 169)
        Me.pbRoute.Name = "pbRoute"
        Me.pbRoute.Size = New System.Drawing.Size(436, 286)
        Me.pbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRoute.TabIndex = 0
        Me.pbRoute.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStart.Enabled = False
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(153, 764)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(179, 35)
        Me.btnStart.TabIndex = 13
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
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
        Me.cmbxStart.Items.AddRange(New Object() {"Toronto Metropolitan University"})
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
        Me.cmbxEnd.Items.AddRange(New Object() {"University of Toronto"})
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
        Me.lblHourStart.Size = New System.Drawing.Size(37, 30)
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
        Me.lblMinuteStart.Location = New System.Drawing.Point(222, 548)
        Me.lblMinuteStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMinuteStart.Name = "lblMinuteStart"
        Me.lblMinuteStart.Size = New System.Drawing.Size(37, 30)
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
        'imgEndAmPmDown
        '
        Me.imgEndAmPmDown.BackColor = System.Drawing.Color.White
        Me.imgEndAmPmDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgEndAmPmDown.Location = New System.Drawing.Point(284, 724)
        Me.imgEndAmPmDown.Name = "imgEndAmPmDown"
        Me.imgEndAmPmDown.Size = New System.Drawing.Size(25, 25)
        Me.imgEndAmPmDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndAmPmDown.TabIndex = 37
        Me.imgEndAmPmDown.TabStop = False
        '
        'imgEndMinuteDown
        '
        Me.imgEndMinuteDown.BackColor = System.Drawing.Color.White
        Me.imgEndMinuteDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgEndMinuteDown.Location = New System.Drawing.Point(227, 724)
        Me.imgEndMinuteDown.Name = "imgEndMinuteDown"
        Me.imgEndMinuteDown.Size = New System.Drawing.Size(25, 25)
        Me.imgEndMinuteDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndMinuteDown.TabIndex = 36
        Me.imgEndMinuteDown.TabStop = False
        '
        'imgEndHourDown
        '
        Me.imgEndHourDown.BackColor = System.Drawing.Color.White
        Me.imgEndHourDown.Image = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.imgEndHourDown.Location = New System.Drawing.Point(170, 724)
        Me.imgEndHourDown.Name = "imgEndHourDown"
        Me.imgEndHourDown.Size = New System.Drawing.Size(25, 25)
        Me.imgEndHourDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndHourDown.TabIndex = 35
        Me.imgEndHourDown.TabStop = False
        '
        'imgEndAmPmUp
        '
        Me.imgEndAmPmUp.BackColor = System.Drawing.Color.White
        Me.imgEndAmPmUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgEndAmPmUp.Location = New System.Drawing.Point(284, 675)
        Me.imgEndAmPmUp.Name = "imgEndAmPmUp"
        Me.imgEndAmPmUp.Size = New System.Drawing.Size(25, 25)
        Me.imgEndAmPmUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndAmPmUp.TabIndex = 34
        Me.imgEndAmPmUp.TabStop = False
        '
        'imgEndMinuteUp
        '
        Me.imgEndMinuteUp.BackColor = System.Drawing.Color.White
        Me.imgEndMinuteUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgEndMinuteUp.Location = New System.Drawing.Point(227, 675)
        Me.imgEndMinuteUp.Name = "imgEndMinuteUp"
        Me.imgEndMinuteUp.Size = New System.Drawing.Size(25, 25)
        Me.imgEndMinuteUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndMinuteUp.TabIndex = 33
        Me.imgEndMinuteUp.TabStop = False
        '
        'imgEndHourUp
        '
        Me.imgEndHourUp.BackColor = System.Drawing.Color.White
        Me.imgEndHourUp.Image = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.imgEndHourUp.Location = New System.Drawing.Point(170, 675)
        Me.imgEndHourUp.Name = "imgEndHourUp"
        Me.imgEndHourUp.Size = New System.Drawing.Size(25, 25)
        Me.imgEndHourUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEndHourUp.TabIndex = 32
        Me.imgEndHourUp.TabStop = False
        '
        'lblAmPmEnd
        '
        Me.lblAmPmEnd.BackColor = System.Drawing.Color.White
        Me.lblAmPmEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAmPmEnd.Location = New System.Drawing.Point(275, 696)
        Me.lblAmPmEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAmPmEnd.Name = "lblAmPmEnd"
        Me.lblAmPmEnd.Size = New System.Drawing.Size(45, 30)
        Me.lblAmPmEnd.TabIndex = 31
        Me.lblAmPmEnd.Text = "am"
        Me.lblAmPmEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinuteEnd
        '
        Me.lblMinuteEnd.BackColor = System.Drawing.Color.White
        Me.lblMinuteEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMinuteEnd.Location = New System.Drawing.Point(222, 696)
        Me.lblMinuteEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMinuteEnd.Name = "lblMinuteEnd"
        Me.lblMinuteEnd.Size = New System.Drawing.Size(37, 30)
        Me.lblMinuteEnd.TabIndex = 30
        Me.lblMinuteEnd.Text = "00"
        Me.lblMinuteEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(202, 696)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 30)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHourEnd
        '
        Me.lblHourEnd.BackColor = System.Drawing.Color.White
        Me.lblHourEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHourEnd.Location = New System.Drawing.Point(165, 696)
        Me.lblHourEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHourEnd.Name = "lblHourEnd"
        Me.lblHourEnd.Size = New System.Drawing.Size(37, 30)
        Me.lblHourEnd.TabIndex = 28
        Me.lblHourEnd.Text = "00"
        Me.lblHourEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'RouteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.imgEndAmPmDown)
        Me.Controls.Add(Me.imgEndMinuteDown)
        Me.Controls.Add(Me.imgEndHourDown)
        Me.Controls.Add(Me.imgEndAmPmUp)
        Me.Controls.Add(Me.imgEndMinuteUp)
        Me.Controls.Add(Me.imgEndHourUp)
        Me.Controls.Add(Me.lblAmPmEnd)
        Me.Controls.Add(Me.lblMinuteEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHourEnd)
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
        Me.Controls.Add(Me.btnStart)
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
        CType(Me.imgEndAmPmDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEndMinuteDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEndHourDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEndAmPmUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEndMinuteUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEndHourUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbRoute As PictureBox
    Friend WithEvents btnStart As Button
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
    Friend WithEvents imgEndAmPmDown As PictureBox
    Friend WithEvents imgEndMinuteDown As PictureBox
    Friend WithEvents imgEndHourDown As PictureBox
    Friend WithEvents imgEndAmPmUp As PictureBox
    Friend WithEvents imgEndMinuteUp As PictureBox
    Friend WithEvents imgEndHourUp As PictureBox
    Friend WithEvents lblAmPmEnd As Label
    Friend WithEvents lblMinuteEnd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHourEnd As Label
    Friend WithEvents tmrMouseHold As Timer
    Friend WithEvents lblError As Label
End Class
