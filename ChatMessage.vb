Public Class ChatMessage

    Public profilePicture As Image
    Public username As String
    Public message As String

    Public Sub New(profilePicture As Image, username As String, message As String)
        Me.profilePicture = profilePicture
        Me.username = username
        Me.message = message
    End Sub
End Class
