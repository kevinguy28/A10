Public Class BookingRequestForm

    Dim user As String
    Private Sub BookingRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner"
            Case "rider"
                Me.Text = "Car Rider"
        End Select

    End Sub

End Class