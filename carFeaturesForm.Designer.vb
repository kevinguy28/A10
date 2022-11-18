<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carFeaturesForm
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
        Me.btnToggleWindows = New System.Windows.Forms.Button()
        Me.lblCarFeatures = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenTrunk = New System.Windows.Forms.Button()
        Me.lblInsideTemp = New System.Windows.Forms.Label()
        Me.lblInsideTempValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnToggleWindows
        '
        Me.btnToggleWindows.BackgroundImage = Global.A10.My.Resources.Resources.toggle_off
        Me.btnToggleWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnToggleWindows.Location = New System.Drawing.Point(296, 205)
        Me.btnToggleWindows.Name = "btnToggleWindows"
        Me.btnToggleWindows.Size = New System.Drawing.Size(96, 78)
        Me.btnToggleWindows.TabIndex = 0
        Me.btnToggleWindows.UseVisualStyleBackColor = True
        '
        'lblCarFeatures
        '
        Me.lblCarFeatures.AutoSize = True
        Me.lblCarFeatures.BackColor = System.Drawing.Color.White
        Me.lblCarFeatures.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarFeatures.Location = New System.Drawing.Point(93, 97)
        Me.lblCarFeatures.Name = "lblCarFeatures"
        Me.lblCarFeatures.Size = New System.Drawing.Size(299, 65)
        Me.lblCarFeatures.TabIndex = 1
        Me.lblCarFeatures.Text = "Car Features"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Open Windows"
        '
        'btnOpenTrunk
        '
        Me.btnOpenTrunk.Location = New System.Drawing.Point(134, 709)
        Me.btnOpenTrunk.Name = "btnOpenTrunk"
        Me.btnOpenTrunk.Size = New System.Drawing.Size(191, 65)
        Me.btnOpenTrunk.TabIndex = 3
        Me.btnOpenTrunk.Text = "Open Trunk"
        Me.btnOpenTrunk.UseVisualStyleBackColor = True
        '
        'lblInsideTemp
        '
        Me.lblInsideTemp.AutoSize = True
        Me.lblInsideTemp.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTemp.Location = New System.Drawing.Point(67, 641)
        Me.lblInsideTemp.Name = "lblInsideTemp"
        Me.lblInsideTemp.Size = New System.Drawing.Size(231, 32)
        Me.lblInsideTemp.TabIndex = 4
        Me.lblInsideTemp.Text = "Inside Temperature: "
        '
        'lblInsideTempValue
        '
        Me.lblInsideTempValue.AutoSize = True
        Me.lblInsideTempValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTempValue.Location = New System.Drawing.Point(351, 641)
        Me.lblInsideTempValue.Name = "lblInsideTempValue"
        Me.lblInsideTempValue.Size = New System.Drawing.Size(40, 32)
        Me.lblInsideTempValue.TabIndex = 5
        Me.lblInsideTempValue.Text = "12"
        '
        'carFeaturesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblInsideTempValue)
        Me.Controls.Add(Me.lblInsideTemp)
        Me.Controls.Add(Me.btnOpenTrunk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCarFeatures)
        Me.Controls.Add(Me.btnToggleWindows)
        Me.DoubleBuffered = True
        Me.Name = "carFeaturesForm"
        Me.Text = "carFeaturesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToggleWindows As Button
    Friend WithEvents lblCarFeatures As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenTrunk As Button
    Friend WithEvents lblInsideTemp As Label
    Friend WithEvents lblInsideTempValue As Label
End Class
