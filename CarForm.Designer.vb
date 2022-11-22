<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarForm
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
        Me.btnEmergency = New System.Windows.Forms.Button()
        Me.btnCarFeatures = New System.Windows.Forms.Button()
        Me.btnCarMedia = New System.Windows.Forms.Button()
        Me.btnDiagnostic = New System.Windows.Forms.Button()
        Me.lblCarFeatures = New System.Windows.Forms.Label()
        Me.lblCarMedia = New System.Windows.Forms.Label()
        Me.lblDiagnostic = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmergency
        '
        Me.btnEmergency.BackColor = System.Drawing.Color.IndianRed
        Me.btnEmergency.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEmergency.Location = New System.Drawing.Point(24, 742)
        Me.btnEmergency.Name = "btnEmergency"
        Me.btnEmergency.Size = New System.Drawing.Size(436, 65)
        Me.btnEmergency.TabIndex = 3
        Me.btnEmergency.Text = "Report an Emergency"
        Me.btnEmergency.UseVisualStyleBackColor = False
        '
        'btnCarFeatures
        '
        Me.btnCarFeatures.BackColor = System.Drawing.Color.White
        Me.btnCarFeatures.BackgroundImage = Global.A10.My.Resources.Resources.fan_neutral
        Me.btnCarFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCarFeatures.FlatAppearance.BorderSize = 0
        Me.btnCarFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarFeatures.Location = New System.Drawing.Point(68, 258)
        Me.btnCarFeatures.Name = "btnCarFeatures"
        Me.btnCarFeatures.Size = New System.Drawing.Size(150, 150)
        Me.btnCarFeatures.TabIndex = 4
        Me.btnCarFeatures.TabStop = False
        Me.btnCarFeatures.UseVisualStyleBackColor = True
        '
        'btnCarMedia
        '
        Me.btnCarMedia.BackColor = System.Drawing.Color.White
        Me.btnCarMedia.BackgroundImage = Global.A10.My.Resources.Resources.car_media_neutral
        Me.btnCarMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCarMedia.FlatAppearance.BorderSize = 0
        Me.btnCarMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarMedia.Location = New System.Drawing.Point(268, 258)
        Me.btnCarMedia.Name = "btnCarMedia"
        Me.btnCarMedia.Size = New System.Drawing.Size(150, 150)
        Me.btnCarMedia.TabIndex = 5
        Me.btnCarMedia.TabStop = False
        Me.btnCarMedia.UseVisualStyleBackColor = True
        '
        'btnDiagnostic
        '
        Me.btnDiagnostic.BackColor = System.Drawing.Color.White
        Me.btnDiagnostic.BackgroundImage = Global.A10.My.Resources.Resources.diagnostic3
        Me.btnDiagnostic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDiagnostic.FlatAppearance.BorderSize = 0
        Me.btnDiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnostic.Location = New System.Drawing.Point(68, 476)
        Me.btnDiagnostic.Name = "btnDiagnostic"
        Me.btnDiagnostic.Size = New System.Drawing.Size(150, 150)
        Me.btnDiagnostic.TabIndex = 6
        Me.btnDiagnostic.TabStop = False
        Me.btnDiagnostic.UseVisualStyleBackColor = True
        '
        'lblCarFeatures
        '
        Me.lblCarFeatures.BackColor = System.Drawing.Color.White
        Me.lblCarFeatures.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarFeatures.Location = New System.Drawing.Point(68, 217)
        Me.lblCarFeatures.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarFeatures.Name = "lblCarFeatures"
        Me.lblCarFeatures.Size = New System.Drawing.Size(150, 38)
        Me.lblCarFeatures.TabIndex = 19
        Me.lblCarFeatures.Text = "Features"
        Me.lblCarFeatures.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCarMedia
        '
        Me.lblCarMedia.BackColor = System.Drawing.Color.White
        Me.lblCarMedia.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarMedia.Location = New System.Drawing.Point(268, 217)
        Me.lblCarMedia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarMedia.Name = "lblCarMedia"
        Me.lblCarMedia.Size = New System.Drawing.Size(150, 38)
        Me.lblCarMedia.TabIndex = 20
        Me.lblCarMedia.Text = "Media"
        Me.lblCarMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDiagnostic
        '
        Me.lblDiagnostic.BackColor = System.Drawing.Color.White
        Me.lblDiagnostic.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDiagnostic.Location = New System.Drawing.Point(68, 435)
        Me.lblDiagnostic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiagnostic.Name = "lblDiagnostic"
        Me.lblDiagnostic.Size = New System.Drawing.Size(150, 38)
        Me.lblDiagnostic.TabIndex = 21
        Me.lblDiagnostic.Text = "Diagnostic"
        Me.lblDiagnostic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblDiagnostic)
        Me.Controls.Add(Me.lblCarMedia)
        Me.Controls.Add(Me.lblCarFeatures)
        Me.Controls.Add(Me.btnDiagnostic)
        Me.Controls.Add(Me.btnCarMedia)
        Me.Controls.Add(Me.btnCarFeatures)
        Me.Controls.Add(Me.btnEmergency)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CarForm"
        Me.Text = "CarForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCarFeatures As Button
    Friend WithEvents btnEmergency As Button
    Friend WithEvents btnCarMedia As Button
    Friend WithEvents btnDiagnostic As Button
    Friend WithEvents lblCarFeatures As Label
    Friend WithEvents lblCarMedia As Label
    Friend WithEvents lblDiagnostic As Label
End Class
