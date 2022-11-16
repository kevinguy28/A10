Public Class DevForm
    Private Sub DevForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnScenario_Click(sender As Object, e As EventArgs) Handles _
        btnScenarioOne.Click, btnScenarioTwo.Click,
        btnScenarioThree.Click, btnScenarioFour.Click,
        btnScenarioFive.Click, btnScenarioSix.Click
        Dim ownerWindow As New HomeForm("owner", CType(sender, Button).Tag)
        Dim riderWindow As New HomeForm("rider", CType(sender, Button).Tag)
        ownerWindow.addOtherForm(riderWindow)
        riderWindow.addOtherForm(ownerWindow)
        ownerWindow.Show()
        riderWindow.Show()
    End Sub
End Class