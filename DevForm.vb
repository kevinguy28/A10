Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Dim currentOwnerForm As AppForm
    Dim currentRiderForm As AppForm

    Private Sub DevForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnScenario_Click(sender As Object, e As EventArgs) Handles _
        btnScenarioOne.Click, btnScenarioTwo.Click,
        btnScenarioThree.Click, btnScenarioFour.Click,
        btnScenarioFive.Click, btnScenarioSix.Click

        ' If other windows are open, close them
        If (ownerWindow IsNot Nothing) Or (riderWindow IsNot Nothing) Then
            Me.ownerWindow.CloseAllForms()
            Me.riderWindow.CloseAllForms()
        End If

        ' Open new windows
        Me.ownerWindow = New HomeForm("owner", CType(sender, Button).Tag, Me)
        Me.riderWindow = New HomeForm("rider", CType(sender, Button).Tag, Me)
        Me.ownerWindow.addOtherForm(riderWindow)
        Me.riderWindow.addOtherForm(ownerWindow)
        Me.ownerWindow.Show()
        Me.riderWindow.Show()
    End Sub

    Public Sub SetCurrentOwnerForm(form As AppForm)
        Me.currentOwnerForm = form
    End Sub

    Public Sub SetCurrentRiderForm(form As AppForm)
        Me.currentRiderForm = form
    End Sub

    Public Shared Function GetFormWidth() As Integer
        Return 500
    End Function

    Public Shared Function GetFormHeight() As Integer
        Return 1000
    End Function

    Public Shared Function GetDevWidth() As Integer
        Return DevForm.Width
    End Function

    ' --------------
    ' --- Popups ---
    ' --------------
    Public Sub OpenPopup(user As String, popup As Form)
        Select Case user
            Case "owner"
                currentOwnerForm.CreateDimOverlay()
                currentOwnerForm.DimScreen()
            Case "rider"
                currentRiderForm.CreateDimOverlay()
                currentRiderForm.DimScreen()
        End Select
        popup.Show()
        popup.TopMost = True
    End Sub

    Public Sub ClosePopup(user As String)
        Select Case user
            Case "owner"
                currentOwnerForm.UnDimScreen()
            Case "rider"
                currentRiderForm.UnDimScreen()
        End Select
    End Sub

End Class