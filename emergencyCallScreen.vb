Public Class emergencyCallScreen

    ' Changes the look of this emergencyCallScreen form to look as if a call is being made.
    Private Sub callPicBox_Click(sender As Object, e As EventArgs) Handles callPicBox.Click
        Me.label2.Text = "Emergency Call -" : Me.label3.Text = "calling ..." : Me.endCallPicBox.Visible = True : Me.callPicBox.Visible = False : Me.noCallPicBox.Visible = False
    End Sub

    ' Closes this form.

    Private Sub endCallPicBox_Click(sender As Object, e As EventArgs) Handles endCallPicBox.Click
        Me.Close()
    End Sub

    Private Sub noCallPicBox_Click(sender As Object, e As EventArgs) Handles noCallPicBox.Click
        Me.Close()
    End Sub
End Class