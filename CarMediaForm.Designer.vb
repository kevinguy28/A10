<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarMediaForm
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
        Me.lblSpeakers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolumeDown = New System.Windows.Forms.Button()
        Me.btnVolumeUp = New System.Windows.Forms.Button()
        Me.lblVolumeNumber = New System.Windows.Forms.Label()
        Me.btnSpeakersToggle = New System.Windows.Forms.Button()
        Me.btnConnectPhone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSpeakers
        '
        Me.lblSpeakers.AutoSize = True
        Me.lblSpeakers.BackColor = System.Drawing.Color.White
        Me.lblSpeakers.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSpeakers.Location = New System.Drawing.Point(72, 289)
        Me.lblSpeakers.Name = "lblSpeakers"
        Me.lblSpeakers.Size = New System.Drawing.Size(112, 32)
        Me.lblSpeakers.TabIndex = 0
        Me.lblSpeakers.Text = "Speakers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(72, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Volume"
        '
        'btnVolumeDown
        '
        Me.btnVolumeDown.BackColor = System.Drawing.Color.White
        Me.btnVolumeDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeDown.FlatAppearance.BorderSize = 0
        Me.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolumeDown.Location = New System.Drawing.Point(246, 371)
        Me.btnVolumeDown.Name = "btnVolumeDown"
        Me.btnVolumeDown.Size = New System.Drawing.Size(50, 50)
        Me.btnVolumeDown.TabIndex = 2
        Me.btnVolumeDown.UseVisualStyleBackColor = True
        '
        'btnVolumeUp
        '
        Me.btnVolumeUp.BackColor = System.Drawing.Color.White
        Me.btnVolumeUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeUp.FlatAppearance.BorderSize = 0
        Me.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolumeUp.Location = New System.Drawing.Point(356, 371)
        Me.btnVolumeUp.Name = "btnVolumeUp"
        Me.btnVolumeUp.Size = New System.Drawing.Size(50, 50)
        Me.btnVolumeUp.TabIndex = 3
        Me.btnVolumeUp.UseVisualStyleBackColor = True
        '
        'lblVolumeNumber
        '
        Me.lblVolumeNumber.AutoSize = True
        Me.lblVolumeNumber.BackColor = System.Drawing.Color.White
        Me.lblVolumeNumber.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVolumeNumber.Location = New System.Drawing.Point(306, 371)
        Me.lblVolumeNumber.Name = "lblVolumeNumber"
        Me.lblVolumeNumber.Size = New System.Drawing.Size(38, 46)
        Me.lblVolumeNumber.TabIndex = 4
        Me.lblVolumeNumber.Text = "1"
        '
        'btnSpeakersToggle
        '
        Me.btnSpeakersToggle.BackColor = System.Drawing.Color.White
        Me.btnSpeakersToggle.BackgroundImage = Global.A10.My.Resources.Resources.toggle_on
        Me.btnSpeakersToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSpeakersToggle.FlatAppearance.BorderSize = 0
        Me.btnSpeakersToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeakersToggle.Location = New System.Drawing.Point(310, 265)
        Me.btnSpeakersToggle.Name = "btnSpeakersToggle"
        Me.btnSpeakersToggle.Size = New System.Drawing.Size(96, 78)
        Me.btnSpeakersToggle.TabIndex = 5
        Me.btnSpeakersToggle.Tag = "1"
        Me.btnSpeakersToggle.UseVisualStyleBackColor = True
        '
        'btnConnectPhone
        '
        Me.btnConnectPhone.Location = New System.Drawing.Point(147, 492)
        Me.btnConnectPhone.Name = "btnConnectPhone"
        Me.btnConnectPhone.Size = New System.Drawing.Size(203, 62)
        Me.btnConnectPhone.TabIndex = 6
        Me.btnConnectPhone.Tag = "0"
        Me.btnConnectPhone.Text = "connect phone"
        Me.btnConnectPhone.UseVisualStyleBackColor = True
        '
        'CarMediaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnVolumeUp)
        Me.Controls.Add(Me.btnConnectPhone)
        Me.Controls.Add(Me.btnSpeakersToggle)
        Me.Controls.Add(Me.lblVolumeNumber)
        Me.Controls.Add(Me.btnVolumeDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSpeakers)
        Me.DoubleBuffered = True
        Me.Name = "CarMediaForm"
        Me.Text = "CarMediaForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeakers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolumeDown As Button
    Friend WithEvents btnVolumeUp As Button
    Friend WithEvents lblVolumeNumber As Label
    Friend WithEvents btnSpeakersToggle As Button
    Friend WithEvents btnConnectPhone As Button
End Class
