<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnEmergency = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCarFeatures = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(38, 77)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 65)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Car"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.A10.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(205, 812)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 75)
        Me.btnHome.TabIndex = 2
        Me.btnHome.TabStop = False
        Me.btnHome.UseVisualStyleBackColor = True
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
        Me.btnCarFeatures.BackgroundImage = Global.A10.My.Resources.Resources.fan_neutral
        Me.btnCarFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCarFeatures.Location = New System.Drawing.Point(68, 258)
        Me.btnCarFeatures.Name = "btnCarFeatures"
        Me.btnCarFeatures.Size = New System.Drawing.Size(150, 150)
        Me.btnCarFeatures.TabIndex = 4
        Me.btnCarFeatures.UseVisualStyleBackColor = True
        '
        'CarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnCarFeatures)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEmergency)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CarForm"
        Me.Text = "CarForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCarFeatures As Button
    Friend WithEvents btnEmergency As Button
End Class
