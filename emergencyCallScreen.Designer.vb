﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emergencyCallScreen
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.callPicBox = New System.Windows.Forms.PictureBox()
        Me.noCallPicBox = New System.Windows.Forms.PictureBox()
        Me.endCallPicBox = New System.Windows.Forms.PictureBox()
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("SimSun-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(160, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 24)
        Me.label1.TabIndex = 0
        Me.label1.Text = "911"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("SimSun-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label2.Location = New System.Drawing.Point(88, 127)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(192, 24)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Call Emergency"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("SimSun-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.Location = New System.Drawing.Point(121, 158)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(127, 24)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Services?"
        '
        'callPicBox
        '
        Me.callPicBox.Image = Global.A10.My.Resources.Resources._call
        Me.callPicBox.Location = New System.Drawing.Point(88, 366)
        Me.callPicBox.Name = "callPicBox"
        Me.callPicBox.Size = New System.Drawing.Size(73, 84)
        Me.callPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.callPicBox.TabIndex = 3
        Me.callPicBox.TabStop = False
        '
        'noCallPicBox
        '
        Me.noCallPicBox.Image = Global.A10.My.Resources.Resources.nocall
        Me.noCallPicBox.Location = New System.Drawing.Point(207, 366)
        Me.noCallPicBox.Name = "noCallPicBox"
        Me.noCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.noCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.noCallPicBox.TabIndex = 4
        Me.noCallPicBox.TabStop = False
        '
        'endCallPicBox
        '
        Me.endCallPicBox.Image = Global.A10.My.Resources.Resources.endCall
        Me.endCallPicBox.Location = New System.Drawing.Point(148, 366)
        Me.endCallPicBox.Name = "endCallPicBox"
        Me.endCallPicBox.Size = New System.Drawing.Size(73, 84)
        Me.endCallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.endCallPicBox.TabIndex = 5
        Me.endCallPicBox.TabStop = False
        Me.endCallPicBox.Visible = False
        '
        'emergencyCallScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(369, 629)
        Me.Controls.Add(Me.endCallPicBox)
        Me.Controls.Add(Me.noCallPicBox)
        Me.Controls.Add(Me.callPicBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(685, 200)
        Me.Name = "emergencyCallScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "emergencyCallScreen"
        CType(Me.callPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endCallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents callPicBox As PictureBox
    Friend WithEvents noCallPicBox As PictureBox
    Friend WithEvents endCallPicBox As PictureBox
End Class
