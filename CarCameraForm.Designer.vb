<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarCameraForm
    'Inherits System.Windows.Forms.Form
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
        Me.pbCameraView = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnFrontInterior = New System.Windows.Forms.Button()
        Me.btnBackInterior = New System.Windows.Forms.Button()
        Me.btnFrontExterior = New System.Windows.Forms.Button()
        Me.btnBackExterior = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbCameraView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCameraView
        '
        Me.pbCameraView.BackColor = System.Drawing.Color.Transparent
        Me.pbCameraView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbCameraView.Image = Global.A10.My.Resources.Resources.in_front
        Me.pbCameraView.Location = New System.Drawing.Point(34, 241)
        Me.pbCameraView.Name = "pbCameraView"
        Me.pbCameraView.Size = New System.Drawing.Size(415, 274)
        Me.pbCameraView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCameraView.TabIndex = 0
        Me.pbCameraView.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(86, 183)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 46)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Front Interior"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFrontInterior
        '
        Me.btnFrontInterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnFrontInterior.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFrontInterior.ForeColor = System.Drawing.Color.White
        Me.btnFrontInterior.Location = New System.Drawing.Point(86, 541)
        Me.btnFrontInterior.Name = "btnFrontInterior"
        Me.btnFrontInterior.Size = New System.Drawing.Size(131, 89)
        Me.btnFrontInterior.TabIndex = 2
        Me.btnFrontInterior.Text = "Front Interior"
        Me.btnFrontInterior.UseVisualStyleBackColor = False
        '
        'btnBackInterior
        '
        Me.btnBackInterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnBackInterior.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBackInterior.ForeColor = System.Drawing.Color.White
        Me.btnBackInterior.Location = New System.Drawing.Point(267, 541)
        Me.btnBackInterior.Name = "btnBackInterior"
        Me.btnBackInterior.Size = New System.Drawing.Size(131, 89)
        Me.btnBackInterior.TabIndex = 3
        Me.btnBackInterior.Text = "Back Interior"
        Me.btnBackInterior.UseVisualStyleBackColor = False
        '
        'btnFrontExterior
        '
        Me.btnFrontExterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnFrontExterior.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFrontExterior.ForeColor = System.Drawing.Color.White
        Me.btnFrontExterior.Location = New System.Drawing.Point(86, 658)
        Me.btnFrontExterior.Name = "btnFrontExterior"
        Me.btnFrontExterior.Size = New System.Drawing.Size(131, 89)
        Me.btnFrontExterior.TabIndex = 4
        Me.btnFrontExterior.Text = "Front Exterior"
        Me.btnFrontExterior.UseVisualStyleBackColor = False
        '
        'btnBackExterior
        '
        Me.btnBackExterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnBackExterior.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBackExterior.ForeColor = System.Drawing.Color.White
        Me.btnBackExterior.Location = New System.Drawing.Point(267, 658)
        Me.btnBackExterior.Name = "btnBackExterior"
        Me.btnBackExterior.Size = New System.Drawing.Size(131, 89)
        Me.btnBackExterior.TabIndex = 5
        Me.btnBackExterior.Text = "Back Exterior"
        Me.btnBackExterior.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(143, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Car Camera"
        '
        'CarCameraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBackExterior)
        Me.Controls.Add(Me.btnFrontExterior)
        Me.Controls.Add(Me.btnBackInterior)
        Me.Controls.Add(Me.btnFrontInterior)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbCameraView)
        Me.DoubleBuffered = True
        Me.Name = "CarCameraForm"
        Me.Text = "CarCameraForm"
        CType(Me.pbCameraView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbCameraView As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnFrontInterior As Button
    Friend WithEvents btnBackInterior As Button
    Friend WithEvents btnFrontExterior As Button
    Friend WithEvents btnBackExterior As Button
    Friend WithEvents Label1 As Label
End Class
