<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ownerButton = New System.Windows.Forms.Button()
        Me.riderButton = New System.Windows.Forms.Button()
        Me.devButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A10.My.Resources.Resources.kuber
        Me.PictureBox1.Location = New System.Drawing.Point(134, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(161, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'ownerButton
        '
        Me.ownerButton.Location = New System.Drawing.Point(87, 254)
        Me.ownerButton.Name = "ownerButton"
        Me.ownerButton.Size = New System.Drawing.Size(79, 54)
        Me.ownerButton.TabIndex = 2
        Me.ownerButton.Text = "Owner"
        Me.ownerButton.UseVisualStyleBackColor = True
        '
        'riderButton
        '
        Me.riderButton.Location = New System.Drawing.Point(208, 254)
        Me.riderButton.Name = "riderButton"
        Me.riderButton.Size = New System.Drawing.Size(79, 54)
        Me.riderButton.TabIndex = 3
        Me.riderButton.Text = "Rider"
        Me.riderButton.UseVisualStyleBackColor = True
        '
        'devButton
        '
        Me.devButton.Location = New System.Drawing.Point(229, 546)
        Me.devButton.Name = "devButton"
        Me.devButton.Size = New System.Drawing.Size(75, 23)
        Me.devButton.TabIndex = 4
        Me.devButton.Text = "Dev"
        Me.devButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(369, 629)
        Me.Controls.Add(Me.devButton)
        Me.Controls.Add(Me.riderButton)
        Me.Controls.Add(Me.ownerButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ownerButton As Button
    Friend WithEvents riderButton As Button
    Friend WithEvents devButton As Button
End Class
