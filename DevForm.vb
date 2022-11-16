Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Dim currentOwnerForm As Form
    Dim currentRiderForm As Form

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

    Public Sub SetCurrentOwnerForm(form As Form)
        Me.currentOwnerForm = form
    End Sub

    Public Sub SetCurrentRiderForm(form As Form)
        Me.currentRiderForm = form
    End Sub

End Class