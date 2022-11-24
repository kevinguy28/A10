Public Class UserCalendarEvent

    ' All
    Dim profilePic As Bitmap
    Dim userName As String
    Dim userType As String

    Dim carName As String
    Dim carColour As String
    Dim userRating As Integer
    Dim startDate As Date
    Dim endDate As Date

    ' Owner
    Dim carRiderName As String
    Dim carRiderProfilePic As Image

    ' Rider
    Dim carOwnerName As String
    Dim carOwnerProfilePic As Image

    Public Sub New(profilePicture As Image, userName As String, userType As String, carName As String, carColour As String, userRating As Integer, startDate As Date, endDate As Date)
        Me.profilePic = profilePicture
        Me.userName = userName
        Me.userType = userType
        Me.carName = carName
        Me.carColour = carColour
        Me.userRating = userRating
        Me.startDate = startDate
        Me.endDate = endDate
    End Sub

    Public Sub OwnerFound(carOwnerName As String, carOwnerProfilePic As Image)
        Me.carOwnerName = carOwnerName
        Me.carOwnerProfilePic = carOwnerProfilePic
    End Sub

    Public Sub OwnerRemove()
        Me.carOwnerName = ""
        Me.carOwnerProfilePic = Nothing
    End Sub

    Public Sub RiderFound(carRiderName As String, carRiderProfilePic As Image)
        Me.carRiderName = carRiderName
        Me.carOwnerProfilePic = carRiderProfilePic
    End Sub

    Public Sub RiderRemove()
        Me.carRiderName = ""
        Me.carOwnerProfilePic = Nothing
    End Sub

    Public Function GetProfilePicture() As Bitmap
        Return Me.profilePic
    End Function

    Public Function GetName() As String
        Return Me.userName
    End Function

    Public Function GetUserType() As String
        Return Me.userType
    End Function

    Public Function GetCar() As String
        Return Me.carName
    End Function

    Public Function GetColour() As String
        Return Me.carColour
    End Function

    Public Function GetRatingInt() As Integer
        Return Me.userRating
    End Function

    Public Function GetRatingImg() As Bitmap
        Select Case Me.userRating
            Case 0
                Return My.Resources.StarZero
            Case 1
                Return My.Resources.StarOne
            Case 2
                Return My.Resources.StarTwo
            Case 3
                Return My.Resources.StarThree
            Case 4
                Return My.Resources.StarFour
            Case 5
                Return My.Resources.StarFive
        End Select
    End Function

    Public Function GetStartDate() As Date
        Return Me.startDate
    End Function

    Public Function GetEndDate() As Date
        Return Me.endDate
    End Function

    Public Function GetCarOwnerName() As String
        Return Me.carOwnerName
    End Function

    Public Function GetCarOwnerProfilePicture() As Bitmap
        Return Me.carOwnerProfilePic
    End Function

    Public Function GetCarRiderName() As String
        Return Me.carRiderName
    End Function

    Public Function GetCarRiderProfilePicture() As Bitmap
        Return Me.carRiderProfilePic
    End Function

End Class
