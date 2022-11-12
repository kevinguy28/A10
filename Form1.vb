Public Class Form1

    ' Form objects that will be used ----------------------------------------------------------------------

    Dim ownerForm As ownerHomeScreen
    Dim riderForm As riderHomeScreen
    Dim devForm As devWindow

    ' Displays Forms when button ares clicked for Owner, Rider, and Dev -----------------------------------
    Private Sub ownerButton_Click(sender As Object, e As EventArgs) Handles ownerButton.Click
        ownerForm = New ownerHomeScreen
        ownerForm.Show()
    End Sub

    Private Sub riderButton_Click(sender As Object, e As EventArgs) Handles riderButton.Click
        riderForm = New riderHomeScreen
        riderForm.Show()
    End Sub

    Private Sub devButton_Click(sender As Object, e As EventArgs) Handles devButton.Click
        devForm = New devWindow
        devForm.Show()
    End Sub
End Class
