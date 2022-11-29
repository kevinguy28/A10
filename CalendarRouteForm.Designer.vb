<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarRouteForm
    Inherits AppForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.cmbxStart = New System.Windows.Forms.ComboBox()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.pnlDestination = New System.Windows.Forms.Panel()
        Me.cmbxEnd = New System.Windows.Forms.ComboBox()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.pnlFinal = New System.Windows.Forms.Panel()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblEta = New System.Windows.Forms.Label()
        Me.txtEta = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStops = New System.Windows.Forms.Label()
        Me.imgPlus = New System.Windows.Forms.PictureBox()
        Me.lblStopOne = New System.Windows.Forms.Label()
        Me.imgStopOne = New System.Windows.Forms.PictureBox()
        Me.cmbxStopOne = New System.Windows.Forms.ComboBox()
        Me.cmbxStopTwo = New System.Windows.Forms.ComboBox()
        Me.imgStopTwo = New System.Windows.Forms.PictureBox()
        Me.lblStopTwo = New System.Windows.Forms.Label()
        Me.pnlStart.SuspendLayout()
        Me.pnlDestination.SuspendLayout()
        Me.pnlFinal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStopOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStopTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlStart
        '
        Me.pnlStart.AutoSize = True
        Me.pnlStart.BackColor = System.Drawing.Color.White
        Me.pnlStart.Controls.Add(Me.cmbxStart)
        Me.pnlStart.Controls.Add(Me.lblStartPrompt)
        Me.pnlStart.Location = New System.Drawing.Point(27, 181)
        Me.pnlStart.Margin = New System.Windows.Forms.Padding(5, 25, 5, 25)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(431, 75)
        Me.pnlStart.TabIndex = 0
        '
        'cmbxStart
        '
        Me.cmbxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStart.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxStart.FormattingEnabled = True
        Me.cmbxStart.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxStart.Location = New System.Drawing.Point(3, 39)
        Me.cmbxStart.Name = "cmbxStart"
        Me.cmbxStart.Size = New System.Drawing.Size(425, 33)
        Me.cmbxStart.TabIndex = 18
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.ForeColor = System.Drawing.Color.White
        Me.lblStartPrompt.Location = New System.Drawing.Point(3, 3)
        Me.lblStartPrompt.Margin = New System.Windows.Forms.Padding(3)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(425, 30)
        Me.lblStartPrompt.TabIndex = 17
        Me.lblStartPrompt.Text = "Starting Point"
        Me.lblStartPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDestination
        '
        Me.pnlDestination.AutoSize = True
        Me.pnlDestination.BackColor = System.Drawing.Color.White
        Me.pnlDestination.Controls.Add(Me.cmbxEnd)
        Me.pnlDestination.Controls.Add(Me.lblDes)
        Me.pnlDestination.Location = New System.Drawing.Point(27, 506)
        Me.pnlDestination.Margin = New System.Windows.Forms.Padding(5, 25, 5, 25)
        Me.pnlDestination.Name = "pnlDestination"
        Me.pnlDestination.Size = New System.Drawing.Size(431, 75)
        Me.pnlDestination.TabIndex = 1
        '
        'cmbxEnd
        '
        Me.cmbxEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEnd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxEnd.FormattingEnabled = True
        Me.cmbxEnd.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxEnd.Location = New System.Drawing.Point(3, 39)
        Me.cmbxEnd.Name = "cmbxEnd"
        Me.cmbxEnd.Size = New System.Drawing.Size(425, 33)
        Me.cmbxEnd.TabIndex = 19
        '
        'lblDes
        '
        Me.lblDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblDes.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDes.ForeColor = System.Drawing.Color.White
        Me.lblDes.Location = New System.Drawing.Point(3, 3)
        Me.lblDes.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(425, 30)
        Me.lblDes.TabIndex = 18
        Me.lblDes.Text = "Destination"
        Me.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFinal
        '
        Me.pnlFinal.AutoSize = True
        Me.pnlFinal.BackColor = System.Drawing.Color.White
        Me.pnlFinal.Controls.Add(Me.btnBook)
        Me.pnlFinal.Controls.Add(Me.lblPrice)
        Me.pnlFinal.Controls.Add(Me.txtPrice)
        Me.pnlFinal.Controls.Add(Me.lblEta)
        Me.pnlFinal.Controls.Add(Me.txtEta)
        Me.pnlFinal.Location = New System.Drawing.Point(27, 642)
        Me.pnlFinal.Margin = New System.Windows.Forms.Padding(5, 25, 5, 25)
        Me.pnlFinal.Name = "pnlFinal"
        Me.pnlFinal.Size = New System.Drawing.Size(431, 152)
        Me.pnlFinal.TabIndex = 2
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
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(65, 89)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(300, 60)
        Me.btnBook.TabIndex = 43
        Me.btnBook.TabStop = False
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(171, 44)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(58, 25)
        Me.lblPrice.TabIndex = 46
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.Location = New System.Drawing.Point(235, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(193, 32)
        Me.txtPrice.TabIndex = 47
        '
        'lblEta
        '
        Me.lblEta.AutoSize = True
        Me.lblEta.BackColor = System.Drawing.Color.White
        Me.lblEta.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEta.Location = New System.Drawing.Point(3, 3)
        Me.lblEta.Margin = New System.Windows.Forms.Padding(3)
        Me.lblEta.Name = "lblEta"
        Me.lblEta.Size = New System.Drawing.Size(226, 25)
        Me.lblEta.TabIndex = 44
        Me.lblEta.Text = "Estimated Time of Arrival:"
        Me.lblEta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEta
        '
        Me.txtEta.Enabled = False
        Me.txtEta.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEta.Location = New System.Drawing.Point(235, 3)
        Me.txtEta.Name = "txtEta"
        Me.txtEta.Size = New System.Drawing.Size(193, 32)
        Me.txtEta.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbxStopTwo)
        Me.Panel1.Controls.Add(Me.imgStopTwo)
        Me.Panel1.Controls.Add(Me.lblStopTwo)
        Me.Panel1.Controls.Add(Me.cmbxStopOne)
        Me.Panel1.Controls.Add(Me.imgStopOne)
        Me.Panel1.Controls.Add(Me.lblStopOne)
        Me.Panel1.Controls.Add(Me.imgPlus)
        Me.Panel1.Controls.Add(Me.lblStops)
        Me.Panel1.Location = New System.Drawing.Point(27, 306)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 25, 5, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 150)
        Me.Panel1.TabIndex = 3
        '
        'lblStops
        '
        Me.lblStops.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblStops.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStops.ForeColor = System.Drawing.Color.White
        Me.lblStops.Location = New System.Drawing.Point(3, 3)
        Me.lblStops.Margin = New System.Windows.Forms.Padding(3)
        Me.lblStops.Name = "lblStops"
        Me.lblStops.Size = New System.Drawing.Size(425, 30)
        Me.lblStops.TabIndex = 18
        Me.lblStops.Text = "Stops"
        Me.lblStops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgPlus
        '
        Me.imgPlus.Image = Global.A10.My.Resources.Resources.Plus
        Me.imgPlus.Location = New System.Drawing.Point(398, 39)
        Me.imgPlus.Name = "imgPlus"
        Me.imgPlus.Size = New System.Drawing.Size(30, 30)
        Me.imgPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPlus.TabIndex = 19
        Me.imgPlus.TabStop = False
        '
        'lblStopOne
        '
        Me.lblStopOne.AutoSize = True
        Me.lblStopOne.BackColor = System.Drawing.Color.White
        Me.lblStopOne.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStopOne.Location = New System.Drawing.Point(34, 78)
        Me.lblStopOne.Name = "lblStopOne"
        Me.lblStopOne.Size = New System.Drawing.Size(93, 25)
        Me.lblStopOne.TabIndex = 47
        Me.lblStopOne.Text = "Stop One:"
        Me.lblStopOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgStopOne
        '
        Me.imgStopOne.Image = Global.A10.My.Resources.Resources.Minus
        Me.imgStopOne.Location = New System.Drawing.Point(3, 78)
        Me.imgStopOne.Name = "imgStopOne"
        Me.imgStopOne.Size = New System.Drawing.Size(25, 25)
        Me.imgStopOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStopOne.TabIndex = 20
        Me.imgStopOne.TabStop = False
        '
        'cmbxStopOne
        '
        Me.cmbxStopOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStopOne.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxStopOne.FormattingEnabled = True
        Me.cmbxStopOne.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxStopOne.Location = New System.Drawing.Point(133, 75)
        Me.cmbxStopOne.Name = "cmbxStopOne"
        Me.cmbxStopOne.Size = New System.Drawing.Size(295, 33)
        Me.cmbxStopOne.TabIndex = 49
        '
        'cmbxStopTwo
        '
        Me.cmbxStopTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStopTwo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxStopTwo.FormattingEnabled = True
        Me.cmbxStopTwo.Items.AddRange(New Object() {"CN Tower", "Toronto Metropolitan University", "Union Station", "University of Toronto"})
        Me.cmbxStopTwo.Location = New System.Drawing.Point(133, 114)
        Me.cmbxStopTwo.Name = "cmbxStopTwo"
        Me.cmbxStopTwo.Size = New System.Drawing.Size(295, 33)
        Me.cmbxStopTwo.TabIndex = 52
        '
        'imgStopTwo
        '
        Me.imgStopTwo.Image = Global.A10.My.Resources.Resources.Minus
        Me.imgStopTwo.Location = New System.Drawing.Point(3, 117)
        Me.imgStopTwo.Name = "imgStopTwo"
        Me.imgStopTwo.Size = New System.Drawing.Size(25, 25)
        Me.imgStopTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStopTwo.TabIndex = 50
        Me.imgStopTwo.TabStop = False
        '
        'lblStopTwo
        '
        Me.lblStopTwo.AutoSize = True
        Me.lblStopTwo.BackColor = System.Drawing.Color.White
        Me.lblStopTwo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStopTwo.Location = New System.Drawing.Point(34, 117)
        Me.lblStopTwo.Name = "lblStopTwo"
        Me.lblStopTwo.Size = New System.Drawing.Size(92, 25)
        Me.lblStopTwo.TabIndex = 51
        Me.lblStopTwo.Text = "Stop Two:"
        Me.lblStopTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalendarRouteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlFinal)
        Me.Controls.Add(Me.pnlDestination)
        Me.Controls.Add(Me.pnlStart)
        Me.DoubleBuffered = True
        Me.Name = "CalendarRouteForm"
        Me.Text = "CalendarRouteForm"
        Me.pnlStart.ResumeLayout(False)
        Me.pnlDestination.ResumeLayout(False)
        Me.pnlFinal.ResumeLayout(False)
        Me.pnlFinal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStopOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStopTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlStart As Panel
    Friend WithEvents pnlDestination As Panel
    Friend WithEvents cmbxStart As ComboBox
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents cmbxEnd As ComboBox
    Friend WithEvents lblDes As Label
    Friend WithEvents pnlFinal As Panel
    Friend WithEvents btnBook As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblEta As Label
    Friend WithEvents txtEta As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStops As Label
    Friend WithEvents lblStopOne As Label
    Friend WithEvents imgPlus As PictureBox
    Friend WithEvents imgStopOne As PictureBox
    Friend WithEvents cmbxStopTwo As ComboBox
    Friend WithEvents imgStopTwo As PictureBox
    Friend WithEvents lblStopTwo As Label
    Friend WithEvents cmbxStopOne As ComboBox
End Class
