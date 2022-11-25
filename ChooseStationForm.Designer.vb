<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseStationForm
    Inherits System.Windows.Forms.Form

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
        Me.lblStationAddress = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblCarPosition = New System.Windows.Forms.Label()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.pbMap = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStationAddress
        '
        Me.lblStationAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStationAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblStationAddress.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStationAddress.Location = New System.Drawing.Point(12, 467)
        Me.lblStationAddress.Name = "lblStationAddress"
        Me.lblStationAddress.Size = New System.Drawing.Size(418, 31)
        Me.lblStationAddress.TabIndex = 28
        Me.lblStationAddress.Text = "lblStationAddress"
        Me.lblStationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.Location = New System.Drawing.Point(138, 436)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(163, 30)
        Me.lblLocation.TabIndex = 27
        Me.lblLocation.Text = "Current Station:"
        '
        'lblCarPosition
        '
        Me.lblCarPosition.AutoSize = True
        Me.lblCarPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblCarPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarPosition.ForeColor = System.Drawing.Color.White
        Me.lblCarPosition.Location = New System.Drawing.Point(186, 292)
        Me.lblCarPosition.Name = "lblCarPosition"
        Me.lblCarPosition.Size = New System.Drawing.Size(41, 21)
        Me.lblCarPosition.TabIndex = 26
        Me.lblCarPosition.Text = "CAR"
        '
        'rb2
        '
        Me.rb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb2.Location = New System.Drawing.Point(389, 227)
        Me.rb2.Name = "rb2"
        Me.rb2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb2.Size = New System.Drawing.Size(23, 23)
        Me.rb2.TabIndex = 25
        Me.rb2.TabStop = True
        Me.rb2.Tag = "144 Dundas Street West"
        Me.rb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb2.UseVisualStyleBackColor = False
        '
        'rb4
        '
        Me.rb4.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb4.Location = New System.Drawing.Point(372, 347)
        Me.rb4.Name = "rb4"
        Me.rb4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb4.Size = New System.Drawing.Size(23, 23)
        Me.rb4.TabIndex = 24
        Me.rb4.TabStop = True
        Me.rb4.Tag = "223 City Hall St"
        Me.rb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb4.UseVisualStyleBackColor = False
        '
        'rb3
        '
        Me.rb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb3.Location = New System.Drawing.Point(67, 156)
        Me.rb3.Name = "rb3"
        Me.rb3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb3.Size = New System.Drawing.Size(23, 23)
        Me.rb3.TabIndex = 23
        Me.rb3.TabStop = True
        Me.rb3.Tag = "58 University Ave"
        Me.rb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb3.UseVisualStyleBackColor = False
        '
        'rb5
        '
        Me.rb5.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb5.Location = New System.Drawing.Point(131, 381)
        Me.rb5.Name = "rb5"
        Me.rb5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb5.Size = New System.Drawing.Size(23, 23)
        Me.rb5.TabIndex = 22
        Me.rb5.TabStop = True
        Me.rb5.Tag = "17 University Ave"
        Me.rb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb5.UseVisualStyleBackColor = False
        '
        'rb6
        '
        Me.rb6.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb6.Location = New System.Drawing.Point(222, 227)
        Me.rb6.Name = "rb6"
        Me.rb6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb6.Size = New System.Drawing.Size(23, 23)
        Me.rb6.TabIndex = 21
        Me.rb6.TabStop = True
        Me.rb6.Tag = "12 Temperance St"
        Me.rb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb6.UseVisualStyleBackColor = False
        '
        'rb1
        '
        Me.rb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.rb1.Location = New System.Drawing.Point(249, 139)
        Me.rb1.Name = "rb1"
        Me.rb1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.rb1.Size = New System.Drawing.Size(23, 23)
        Me.rb1.TabIndex = 20
        Me.rb1.TabStop = True
        Me.rb1.Tag = "Trinity Sq Rd"
        Me.rb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rb1.UseVisualStyleBackColor = False
        '
        'pbMap
        '
        Me.pbMap.BackColor = System.Drawing.Color.Transparent
        Me.pbMap.Image = Global.A10.My.Resources.Resources.the_map_rb1
        Me.pbMap.Location = New System.Drawing.Point(9, 117)
        Me.pbMap.Margin = New System.Windows.Forms.Padding(0)
        Me.pbMap.Name = "pbMap"
        Me.pbMap.Size = New System.Drawing.Size(421, 310)
        Me.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMap.TabIndex = 19
        Me.pbMap.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(9, 55)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(418, 63)
        Me.lblPrompt.TabIndex = 18
        Me.lblPrompt.Text = "lblPrompt"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(415, 45)
        Me.lblTitle.TabIndex = 44
        Me.lblTitle.Text = "Charging Station"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(169, 511)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 40)
        Me.btnConfirm.TabIndex = 45
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'ChooseStationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(439, 561)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStationAddress)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblCarPosition)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb5)
        Me.Controls.Add(Me.rb6)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.pbMap)
        Me.Controls.Add(Me.lblPrompt)
        Me.DoubleBuffered = True
        Me.Name = "ChooseStationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ChooseStationForm"
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStationAddress As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblCarPosition As Label
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents pbMap As PictureBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnConfirm As Button
End Class
