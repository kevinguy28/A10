Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Private Sub DevForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnScenario_Click(sender As Object, e As EventArgs) Handles _
        btnScenarioOne.Click, btnScenarioTwo.Click,
        btnScenarioThree.Click, btnScenarioFour.Click,
        btnScenarioFive.Click, btnScenarioSix.Click

        ' If other windows are open, close them
        If (ownerWindow IsNot Nothing) Or (riderWindow IsNot Nothing) Then
            Me.ownerWindow.closeChildrenForm()
            Me.riderWindow.closeChildrenForm()
            Me.ownerWindow.Close()
            Me.riderWindow.Close()
        End If

        ' Open new windows
        Me.ownerWindow = New HomeForm("owner", CType(sender, Button).Tag, Me)
        Me.riderWindow = New HomeForm("rider", CType(sender, Button).Tag, Me)
        Me.ownerWindow.addOtherForm(riderWindow)
        Me.riderWindow.addOtherForm(ownerWindow)
        Me.ownerWindow.Show()
        Me.riderWindow.Show()
    End Sub
End Class