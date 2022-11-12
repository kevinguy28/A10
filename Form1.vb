Public Class Form1

    ' LOGIN FOR OWNER & RIDER --------------------------------------------------------------
    Private Sub ownerButton_Click(sender As Object, e As EventArgs) Handles ownerButton.Click
        Dim ownerForm As New ownerHomeScreen
        ownerForm.Show()
    End Sub

    Private Sub riderButton_Click(sender As Object, e As EventArgs) Handles riderButton.Click
        Dim riderForm As New riderHomeScreen
        riderForm.Show()
    End Sub
End Class
