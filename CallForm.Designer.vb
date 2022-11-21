<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallForm
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.pbKeypad = New System.Windows.Forms.PictureBox()
        Me.endCallPicBox = New System.Windows.Forms.PictureBox()
        Me.noCallPicBox = New System.Windows.Forms.PictureBox()
        Me.callPicBox = New System.Windows.Forms.PictureBox()
        Me.lblCalling = New System.Windows.Forms.Label()
        CType(Me.pbKeypad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(111, 86)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(262, 46)
        Me.label1.TabIndex = 13
        Me.label1.Text = "647 - 777- 2283"
        '
        'pbKeypad
        '
        Me.pbKeypad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbKeypad.Image = Global.A10.My.Resources.Resources.keypad
        Me.pbKeypad.InitialImage = Global.A10.My.Resources.Resources.keypad
        Me.pbKeypad.Location = New System.Drawing.Point(81, 191)
        Me.pbKeypad.Name = "pbKeypad"
        Me.pbKeypad.Size = New System.Drawing.Size(323, 508)
        Me.pbKeypad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbKeypad.TabIndex = 14
        Me.pbKeypad.TabStop = False
        '
        'endCallPicBox
        '
        Me.endCallPicBox.BackColor = System.Drawing.Color.Transparent
        Me.endCallPicBox.Image = Global.A10.My.Resources.Resources.endCall
        Me.endCallPicBox.Location = New System.Drawing.Point(206, 649)
        Me.endCallPicBox.Name = "endCallPicBox"
        Me.endCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.endCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.endCallPicBox.TabIndex = 20
        Me.endCallPicBox.TabStop = False
        Me.endCallPicBox.Visible = False
        '
        'noCallPicBox
        '
        Me.noCallPicBox.BackColor = System.Drawing.Color.Transparent
        Me.noCallPicBox.Image = Global.A10.My.Resources.Resources.nocall
        Me.noCallPicBox.Location = New System.Drawing.Point(302, 649)
        Me.noCallPicBox.Name = "noCallPicBox"
        Me.noCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.noCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.noCallPicBox.TabIndex = 19
        Me.noCallPicBox.TabStop = False
        '
        'callPicBox
        '
        Me.callPicBox.BackColor = System.Drawing.Color.Transparent
        Me.callPicBox.Image = Global.A10.My.Resources.Resources._call
        Me.callPicBox.Location = New System.Drawing.Point(110, 649)
        Me.callPicBox.Name = "callPicBox"
        Me.callPicBox.Size = New System.Drawing.Size(73, 84)
        Me.callPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.callPicBox.TabIndex = 18
        Me.callPicBox.TabStop = False
        '
        'lblCalling
        '
        Me.lblCalling.AutoSize = True
        Me.lblCalling.BackColor = System.Drawing.Color.Transparent
        Me.lblCalling.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalling.Location = New System.Drawing.Point(165, 203)
        Me.lblCalling.Name = "lblCalling"
        Me.lblCalling.Size = New System.Drawing.Size(154, 46)
        Me.lblCalling.TabIndex = 21
        Me.lblCalling.Text = "calling ..."
        Me.lblCalling.Visible = False
        '
        'CallForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblCalling)
        Me.Controls.Add(Me.endCallPicBox)
        Me.Controls.Add(Me.noCallPicBox)
        Me.Controls.Add(Me.callPicBox)
        Me.Controls.Add(Me.pbKeypad)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.Name = "CallForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CallForm"
        CType(Me.pbKeypad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents pbKeypad As PictureBox
    Friend WithEvents endCallPicBox As PictureBox
    Friend WithEvents noCallPicBox As PictureBox
    Friend WithEvents callPicBox As PictureBox
    Friend WithEvents lblCalling As Label
End Class
