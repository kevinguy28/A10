Public Class DevForm
    Private Sub btnScenario_Click(sender As Object, e As EventArgs) Handles _
        btnScenarioOne.Click, btnScenarioTwo.Click,
        btnScenarioThree.Click, btnScenarioFour.Click,
        btnScenarioFive.Click, btnScenarioSix.Click
        Dim ownerWindow As New HomeForm("owner", CType(sender, Button).Tag)
        Dim riderWindow As New HomeForm("rider", CType(sender, Button).Tag)
        ownerWindow.Show()
        riderWindow.Show()
    End Sub
End Class