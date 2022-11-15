<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnScenarioOne = New System.Windows.Forms.Button()
        Me.btnScenarioTwo = New System.Windows.Forms.Button()
        Me.btnScenarioFour = New System.Windows.Forms.Button()
        Me.btnScenarioThree = New System.Windows.Forms.Button()
        Me.btnScenarioSix = New System.Windows.Forms.Button()
        Me.btnScenarioFive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(15, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(398, 54)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Developer Window"
        '
        'btnScenarioOne
        '
        Me.btnScenarioOne.Location = New System.Drawing.Point(12, 66)
        Me.btnScenarioOne.Name = "btnScenarioOne"
        Me.btnScenarioOne.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioOne.TabIndex = 1
        Me.btnScenarioOne.Tag = "1"
        Me.btnScenarioOne.Text = "Scenario 1"
        Me.btnScenarioOne.UseVisualStyleBackColor = True
        '
        'btnScenarioTwo
        '
        Me.btnScenarioTwo.Location = New System.Drawing.Point(218, 66)
        Me.btnScenarioTwo.Name = "btnScenarioTwo"
        Me.btnScenarioTwo.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioTwo.TabIndex = 2
        Me.btnScenarioTwo.Tag = "2"
        Me.btnScenarioTwo.Text = "Scenario 2"
        Me.btnScenarioTwo.UseVisualStyleBackColor = True
        '
        'btnScenarioFour
        '
        Me.btnScenarioFour.Location = New System.Drawing.Point(218, 122)
        Me.btnScenarioFour.Name = "btnScenarioFour"
        Me.btnScenarioFour.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioFour.TabIndex = 4
        Me.btnScenarioFour.Tag = "4"
        Me.btnScenarioFour.Text = "Scenario 4"
        Me.btnScenarioFour.UseVisualStyleBackColor = True
        '
        'btnScenarioThree
        '
        Me.btnScenarioThree.Location = New System.Drawing.Point(12, 122)
        Me.btnScenarioThree.Name = "btnScenarioThree"
        Me.btnScenarioThree.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioThree.TabIndex = 3
        Me.btnScenarioThree.Tag = "3"
        Me.btnScenarioThree.Text = "Scenario 3"
        Me.btnScenarioThree.UseVisualStyleBackColor = True
        '
        'btnScenarioSix
        '
        Me.btnScenarioSix.Location = New System.Drawing.Point(218, 178)
        Me.btnScenarioSix.Name = "btnScenarioSix"
        Me.btnScenarioSix.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioSix.TabIndex = 6
        Me.btnScenarioSix.Tag = "6"
        Me.btnScenarioSix.Text = "Scenario 6"
        Me.btnScenarioSix.UseVisualStyleBackColor = True
        '
        'btnScenarioFive
        '
        Me.btnScenarioFive.Location = New System.Drawing.Point(12, 178)
        Me.btnScenarioFive.Name = "btnScenarioFive"
        Me.btnScenarioFive.Size = New System.Drawing.Size(200, 50)
        Me.btnScenarioFive.TabIndex = 5
        Me.btnScenarioFive.Tag = "5"
        Me.btnScenarioFive.Text = "Scenario 5"
        Me.btnScenarioFive.UseVisualStyleBackColor = True
        '
        'DevForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 244)
        Me.Controls.Add(Me.btnScenarioSix)
        Me.Controls.Add(Me.btnScenarioFive)
        Me.Controls.Add(Me.btnScenarioFour)
        Me.Controls.Add(Me.btnScenarioThree)
        Me.Controls.Add(Me.btnScenarioTwo)
        Me.Controls.Add(Me.btnScenarioOne)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DevForm"
        Me.Text = "Dev Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnScenarioOne As Button
    Friend WithEvents btnScenarioTwo As Button
    Friend WithEvents btnScenarioFour As Button
    Friend WithEvents btnScenarioThree As Button
    Friend WithEvents btnScenarioSix As Button
    Friend WithEvents btnScenarioFive As Button
End Class
