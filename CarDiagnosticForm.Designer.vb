<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarDiagnosticForm
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
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lbDiagnostic = New System.Windows.Forms.ListBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnTow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.BackColor = System.Drawing.Color.Transparent
        Me.lblCondition.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCondition.Location = New System.Drawing.Point(45, 186)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(157, 37)
        Me.lblCondition.TabIndex = 0
        Me.lblCondition.Text = "Conditions:"
        '
        'lbDiagnostic
        '
        Me.lbDiagnostic.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDiagnostic.FormattingEnabled = True
        Me.lbDiagnostic.ItemHeight = 30
        Me.lbDiagnostic.Items.AddRange(New Object() {"Engine:" & Global.Microsoft.VisualBasic.ChrW(9), "Radiator: " & Global.Microsoft.VisualBasic.ChrW(9), "Wheels: " & Global.Microsoft.VisualBasic.ChrW(9), "Doors:" & Global.Microsoft.VisualBasic.ChrW(9), "Battery:" & Global.Microsoft.VisualBasic.ChrW(9), "Brakes:" & Global.Microsoft.VisualBasic.ChrW(9), "Windows:" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.lbDiagnostic.Location = New System.Drawing.Point(45, 226)
        Me.lbDiagnostic.Name = "lbDiagnostic"
        Me.lbDiagnostic.Size = New System.Drawing.Size(392, 214)
        Me.lbDiagnostic.TabIndex = 1
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRun.FlatAppearance.BorderSize = 0
        Me.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Location = New System.Drawing.Point(235, 183)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(202, 37)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run diagnostic"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'btnTow
        '
        Me.btnTow.BackColor = System.Drawing.Color.IndianRed
        Me.btnTow.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnTow.FlatAppearance.BorderSize = 0
        Me.btnTow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnTow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnTow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTow.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTow.ForeColor = System.Drawing.Color.White
        Me.btnTow.Location = New System.Drawing.Point(92, 739)
        Me.btnTow.Name = "btnTow"
        Me.btnTow.Size = New System.Drawing.Size(300, 50)
        Me.btnTow.TabIndex = 5
        Me.btnTow.Text = "Request a tow"
        Me.btnTow.UseVisualStyleBackColor = False
        '
        'CarDiagnosticForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnTow)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lbDiagnostic)
        Me.Controls.Add(Me.lblCondition)
        Me.DoubleBuffered = True
        Me.Name = "CarDiagnosticForm"
        Me.Text = "CarDiagnosticForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCondition As Label
    Friend WithEvents lbDiagnostic As ListBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnTow As Button
End Class
