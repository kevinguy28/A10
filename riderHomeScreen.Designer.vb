<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asaa
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
        Me.currentRideLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.myRideLabel = New System.Windows.Forms.Label()
        Me.bookingLabel = New System.Windows.Forms.Label()
        Me.myCarPicBox = New System.Windows.Forms.PictureBox()
        Me.schedulePicBox = New System.Windows.Forms.PictureBox()
        Me.kuberLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myCarPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentRideLabel
        '
        Me.currentRideLabel.AutoSize = True
        Me.currentRideLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.currentRideLabel.Location = New System.Drawing.Point(77, 255)
        Me.currentRideLabel.Name = "currentRideLabel"
        Me.currentRideLabel.Size = New System.Drawing.Size(103, 13)
        Me.currentRideLabel.TabIndex = 21
        Me.currentRideLabel.Text = "Current Ride"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.A10.My.Resources.Resources.path
        Me.PictureBox1.Location = New System.Drawing.Point(77, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'myRideLabel
        '
        Me.myRideLabel.AutoSize = True
        Me.myRideLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.myRideLabel.Location = New System.Drawing.Point(208, 130)
        Me.myRideLabel.Name = "myRideLabel"
        Me.myRideLabel.Size = New System.Drawing.Size(63, 13)
        Me.myRideLabel.TabIndex = 19
        Me.myRideLabel.Text = "My Ride"
        '
        'bookingLabel
        '
        Me.bookingLabel.AutoSize = True
        Me.bookingLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bookingLabel.Location = New System.Drawing.Point(77, 130)
        Me.bookingLabel.Name = "bookingLabel"
        Me.bookingLabel.Size = New System.Drawing.Size(63, 13)
        Me.bookingLabel.TabIndex = 18
        Me.bookingLabel.Text = "Booking"
        '
        'myCarPicBox
        '
        Me.myCarPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myCarPicBox.Image = Global.A10.My.Resources.Resources.car1
        Me.myCarPicBox.Location = New System.Drawing.Point(208, 146)
        Me.myCarPicBox.Name = "myCarPicBox"
        Me.myCarPicBox.Size = New System.Drawing.Size(84, 90)
        Me.myCarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.myCarPicBox.TabIndex = 17
        Me.myCarPicBox.TabStop = False
        '
        'schedulePicBox
        '
        Me.schedulePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.schedulePicBox.Image = Global.A10.My.Resources.Resources.Calender
        Me.schedulePicBox.Location = New System.Drawing.Point(77, 146)
        Me.schedulePicBox.Name = "schedulePicBox"
        Me.schedulePicBox.Size = New System.Drawing.Size(84, 90)
        Me.schedulePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.schedulePicBox.TabIndex = 16
        Me.schedulePicBox.TabStop = False
        '
        'kuberLogo
        '
        Me.kuberLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.kuberLogo.Location = New System.Drawing.Point(134, 57)
        Me.kuberLogo.Name = "kuberLogo"
        Me.kuberLogo.Size = New System.Drawing.Size(100, 50)
        Me.kuberLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.kuberLogo.TabIndex = 15
        Me.kuberLogo.TabStop = False
        '
        'asaa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(369, 629)
        Me.Controls.Add(Me.currentRideLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.myRideLabel)
        Me.Controls.Add(Me.bookingLabel)
        Me.Controls.Add(Me.myCarPicBox)
        Me.Controls.Add(Me.schedulePicBox)
        Me.Controls.Add(Me.kuberLogo)
        Me.DoubleBuffered = True
        Me.Name = "asaa"
        Me.Text = "riderHomeScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myCarPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents currentRideLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents myRideLabel As Label
    Friend WithEvents bookingLabel As Label
    Friend WithEvents myCarPicBox As PictureBox
    Friend WithEvents schedulePicBox As PictureBox
    Friend WithEvents kuberLogo As PictureBox
End Class
