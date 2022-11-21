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
        Me.imgArrow = New System.Windows.Forms.PictureBox()
        Me.imgRating = New System.Windows.Forms.PictureBox()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblAvblty = New System.Windows.Forms.Label()
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArrow, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(48, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(347, 40)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgArrow
        '
        Me.imgArrow.BackColor = System.Drawing.Color.White
        Me.imgArrow.Image = Global.A10.My.Resources.Resources.ArrowDown
        Me.imgArrow.Location = New System.Drawing.Point(370, 20)
        Me.imgArrow.Name = "imgArrow"
        Me.imgArrow.Size = New System.Drawing.Size(25, 25)
        Me.imgArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgArrow.TabIndex = 2
        Me.imgArrow.TabStop = False
        '
        'imgRating
        '
        Me.imgRating.Location = New System.Drawing.Point(48, 48)
        Me.imgRating.Name = "imgRating"
        Me.imgRating.Size = New System.Drawing.Size(210, 37)
        Me.imgRating.TabIndex = 3
        Me.imgRating.TabStop = False
        '
        'lblCar
        '
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(48, 88)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(347, 40)
        Me.lblCar.TabIndex = 4
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvblty
        '
        Me.lblAvblty.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAvblty.Location = New System.Drawing.Point(48, 128)
        Me.lblAvblty.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAvblty.Name = "lblAvblty"
        Me.lblAvblty.Size = New System.Drawing.Size(347, 40)
        Me.lblAvblty.TabIndex = 5
        Me.lblAvblty.Text = "lblAvblty"
        Me.lblAvblty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CarListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblAvblty)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.imgRating)
        Me.Controls.Add(Me.imgArrow)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfile)
        Me.Name = "CarListControl"
        Me.Size = New System.Drawing.Size(400, 171)
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgProfile As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents imgArrow As PictureBox
    Friend WithEvents imgRating As PictureBox
    Friend WithEvents lblCar As Label
    Friend WithEvents lblAvblty As Label
End Class
