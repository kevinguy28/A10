<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmergencyContactForm
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
        Me.endCallPicBox = New System.Windows.Forms.PictureBox()
        Me.noCallPicBox = New System.Windows.Forms.PictureBox()
        Me.callPicBox = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'endCallPicBox
        '
        Me.endCallPicBox.Image = Global.A10.My.Resources.Resources.endCall
        Me.endCallPicBox.Location = New System.Drawing.Point(206, 442)
        Me.endCallPicBox.Name = "endCallPicBox"
        Me.endCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.endCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.endCallPicBox.TabIndex = 17
        Me.endCallPicBox.TabStop = False
        Me.endCallPicBox.Visible = False
        '
        'noCallPicBox
        '
        Me.noCallPicBox.Image = Global.A10.My.Resources.Resources.nocall
        Me.noCallPicBox.Location = New System.Drawing.Point(302, 442)
        Me.noCallPicBox.Name = "noCallPicBox"
        Me.noCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.noCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.noCallPicBox.TabIndex = 16
        Me.noCallPicBox.TabStop = False
        '
        'callPicBox
        '
        Me.callPicBox.Image = Global.A10.My.Resources.Resources._call
        Me.callPicBox.Location = New System.Drawing.Point(110, 442)
        Me.callPicBox.Name = "callPicBox"
        Me.callPicBox.Size = New System.Drawing.Size(73, 84)
        Me.callPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.callPicBox.TabIndex = 15
        Me.callPicBox.TabStop = False
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.Location = New System.Drawing.Point(104, 282)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(276, 58)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Services?"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label2.Location = New System.Drawing.Point(72, 225)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(341, 57)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Call Emergency"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(209, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 46)
        Me.label1.TabIndex = 12
        Me.label1.Text = "911"
        '
        'EmergencyContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.endCallPicBox)
        Me.Controls.Add(Me.noCallPicBox)
        Me.Controls.Add(Me.callPicBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.Name = "EmergencyContactForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "EmergencyContactForm"
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents endCallPicBox As PictureBox
    Friend WithEvents noCallPicBox As PictureBox
    Friend WithEvents callPicBox As PictureBox
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
End Class
