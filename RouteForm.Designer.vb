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
        Me.pbRoute = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.cmbxStart = New System.Windows.Forms.ComboBox()
        Me.cmbxEnd = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblEta = New System.Windows.Forms.Label()
        Me.txtEta = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(92, 716)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(300, 60)
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
        Me.lblDes.Location = New System.Drawing.Point(30, 537)
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
        Me.cmbxEnd.Location = New System.Drawing.Point(30, 570)
        Me.cmbxEnd.Name = "cmbxEnd"
        Me.cmbxEnd.Size = New System.Drawing.Size(425, 33)
        Me.cmbxEnd.TabIndex = 17
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
        Me.lblEta.Location = New System.Drawing.Point(30, 615)
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
        Me.txtEta.Location = New System.Drawing.Point(262, 612)
        Me.txtEta.Name = "txtEta"
        Me.txtEta.Size = New System.Drawing.Size(193, 32)
        Me.txtEta.TabIndex = 40
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(198, 653)
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
        Me.txtPrice.Location = New System.Drawing.Point(262, 650)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRoute As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents cmbxStart As ComboBox
    Friend WithEvents cmbxEnd As ComboBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblEta As Label
    Friend WithEvents txtEta As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
End Class
