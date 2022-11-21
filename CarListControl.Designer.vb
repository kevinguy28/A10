<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarListControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.imgProfile = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgRating = New System.Windows.Forms.PictureBox()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblAvblty = New System.Windows.Forms.Label()
        Me.lblAvPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblTop = New System.Windows.Forms.Label()
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgProfile
        '
        Me.imgProfile.Location = New System.Drawing.Point(5, 5)
        Me.imgProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.imgProfile.Name = "imgProfile"
        Me.imgProfile.Size = New System.Drawing.Size(40, 40)
        Me.imgProfile.TabIndex = 0
        Me.imgProfile.TabStop = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(48, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(347, 40)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgRating
        '
        Me.imgRating.Location = New System.Drawing.Point(48, 48)
        Me.imgRating.Name = "imgRating"
        Me.imgRating.Size = New System.Drawing.Size(157, 28)
        Me.imgRating.TabIndex = 3
        Me.imgRating.TabStop = False
        '
        'lblCar
        '
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(48, 79)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(369, 30)
        Me.lblCar.TabIndex = 4
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvblty
        '
        Me.lblAvblty.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAvblty.Location = New System.Drawing.Point(103, 134)
        Me.lblAvblty.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAvblty.Name = "lblAvblty"
        Me.lblAvblty.Size = New System.Drawing.Size(278, 50)
        Me.lblAvblty.TabIndex = 5
        Me.lblAvblty.Text = "lblAvblty"
        '
        'lblAvPrompt
        '
        Me.lblAvPrompt.AutoSize = True
        Me.lblAvPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAvPrompt.Location = New System.Drawing.Point(48, 109)
        Me.lblAvPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAvPrompt.Name = "lblAvPrompt"
        Me.lblAvPrompt.Size = New System.Drawing.Size(83, 25)
        Me.lblAvPrompt.TabIndex = 6
        Me.lblAvPrompt.Text = "Available"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(48, 159)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(33, 25)
        Me.lblToPrompt.TabIndex = 7
        Me.lblToPrompt.Text = "to:"
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(48, 134)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(55, 25)
        Me.lblFromPrompt.TabIndex = 8
        Me.lblFromPrompt.Text = "from:"
        '
        'lblTop
        '
        Me.lblTop.BackColor = System.Drawing.Color.Gray
        Me.lblTop.Location = New System.Drawing.Point(0, 0)
        Me.lblTop.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(420, 3)
        Me.lblTop.TabIndex = 10
        '
        'CarListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblAvPrompt)
        Me.Controls.Add(Me.lblAvblty)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.imgRating)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfile)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CarListControl"
        Me.Size = New System.Drawing.Size(420, 185)
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgProfile As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents imgRating As PictureBox
    Friend WithEvents lblCar As Label
    Friend WithEvents lblAvblty As Label
    Friend WithEvents lblAvPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblTop As Label
End Class
