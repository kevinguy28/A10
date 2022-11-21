Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Dim currentOwnerForm As AppForm
    Dim currentRiderForm As AppForm

    Dim ownerAvailabilityList As List(Of UserCalendarEvent)
    Dim riderBookingList As List(Of UserCalendarEvent)
    Dim chatHistory As New List(Of ChatMessage)

    Private Sub DevForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CreateOwnerAvailability()
        Me.CreateRiderBookings()
        Me.chatHistory = New List(Of ChatMessage)
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

        ' Reset Arrays
        Me.CreateOwnerAvailability()
        Me.CreateRiderBookings()
        Me.chatHistory = New List(Of ChatMessage)
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

    ' ------------------
    ' --- Scheduling ---
    ' ------------------

    Private Function EarlierThan(dateOne As Date, dateTwo As Date)
        Return (dateOne.CompareTo(dateTwo) <= 0)
    End Function

    Private Function LaterThan(dateOne As Date, dateTwo As Date)
        Return (dateOne.CompareTo(dateTwo) >= 0)
    End Function

    Private Sub CreateOwnerAvailability()
        Dim startDate = New Date(2022, 11, 26, 8, 0, 0)
        Dim endDate = New Date(2022, 11, 26, 20, 0, 0)

        Dim ownerOne = New UserCalendarEvent(My.Resources.RandomProfileOne, "Eric Holme", "owner", "Hyundai Ioniq 6", "Red", 2, startDate, endDate)
        Dim ownerTwo = New UserCalendarEvent(My.Resources.RandomProfileTwo, "Nessa Whitney", "owner", "Tesla Model 3", "Black", 4, startDate, endDate)
        Dim ownerThr = New UserCalendarEvent(My.Resources.RandomProfileThree, "Monica Penner", "owner", "Chevrolet Bolt EV", "Grey", 5, startDate, endDate)
        Dim ownerFou = New UserCalendarEvent(My.Resources.RandomProfileFour, "Robert Kitchens", "owner", "Ford Mustang Mach-E", "White", 3, startDate, endDate)

        Me.ownerAvailabilityList = New List(Of UserCalendarEvent)()
        Me.ownerAvailabilityList.Add(ownerOne)
        Me.ownerAvailabilityList.Add(ownerTwo)
        Me.ownerAvailabilityList.Add(ownerThr)
        Me.ownerAvailabilityList.Add(ownerFou)
    End Sub

    Private Sub CreateRiderBookings()
        Me.riderBookingList = New List(Of UserCalendarEvent)()
    End Sub

    Public Function AddAvailability(profilePicture As Image, userName As String, userType As String, carName As String, carColour As String, userRating As Integer, startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim conflict = False

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = userName Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                Dim oldCar = cldrEvent.GetCar()

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If
            End If
        Next

        If conflict Then
            Return False
            Exit Function
        End If

        ' No conflict
        Dim newOwner = New UserCalendarEvent(profilePicture, userName, userType, carName, carColour, userRating, startDate, endDate)
        Me.ownerAvailabilityList.Add(newOwner)
        Return True

    End Function

    Public Sub RemoveAvailability(availability As UserCalendarEvent)
        Me.ownerAvailabilityList.Remove(availability)
    End Sub

    Public Function GetAvailability(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate

        Dim allAvblty As List(Of UserCalendarEvent) = New List(Of UserCalendarEvent)()

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            Dim oldStart = cldrEvent.GetStartDate()
            Dim oldEnd = cldrEvent.GetEndDate()

            ' New | ⬛⬛⬛⬛ |
            ' Old |  ⬛⬛  |
            'newStart earlier than oldStart
            'newEnd later than oldEnd
            If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                allAvblty.Add(cldrEvent)
            End If
        Next

        Return allAvblty
    End Function

    Public Function GetOwnerFirstAvailability(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim availability As UserCalendarEvent

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = "Jane Doe" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    availability = cldrEvent
                    Exit For
                End If
            End If
        Next

        Return availability
    End Function

    Public Function isOwnerAvailable(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim available = False

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = "Jane Doe" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    available = True
                    Exit For
                End If

            End If
        Next

        Return available
    End Function

    ' ---------------
    ' --- Booking ---
    ' ---------------
    Public Sub AddBooking(booking As UserCalendarEvent)
        For Each ownerEvent As UserCalendarEvent In Me.ownerAvailabilityList

            If ownerEvent.GetName = booking.GetCarOwnerName AndAlso ownerEvent.GetCar = booking.GetColour _
                AndAlso Me.LaterThan(booking.GetStartDate, ownerEvent.GetStartDate) AndAlso Me.EarlierThan(booking.GetEndDate, ownerEvent.GetEndDate) Then

                ownerEvent.RiderFound("John Smith", My.Resources.RiderProfile)
                Exit For
            End If
        Next

        Me.riderBookingList.Add(booking)
    End Sub

    Public Sub RemoveBooking(booking As UserCalendarEvent)
        For Each ownerEvent As UserCalendarEvent In Me.ownerAvailabilityList

            If ownerEvent.GetName = booking.GetCarOwnerName AndAlso ownerEvent.GetCar = booking.GetColour _
                AndAlso Me.LaterThan(booking.GetStartDate, ownerEvent.GetStartDate) AndAlso Me.EarlierThan(booking.GetEndDate, ownerEvent.GetEndDate) Then

                ownerEvent.RiderRemove()
                Exit For
            End If
        Next

        Me.riderBookingList.Remove(booking)
    End Sub

    Public Function GetBooking(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate

        Dim allBkng As List(Of UserCalendarEvent) = New List(Of UserCalendarEvent)()

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            Dim oldStart = cldrEvent.GetStartDate()
            Dim oldEnd = cldrEvent.GetEndDate()

            ' New | ⬛⬛⬛⬛ |
            ' Old |  ⬛⬛  |
            'newStart earlier than oldStart
            'newEnd later than oldEnd
            If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                allBkng.Add(cldrEvent)
            End If
        Next

        Return allBkng
    End Function

    Public Function GetRiderFirstBooking(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim booking As UserCalendarEvent

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            ' If user has schedule
            If cldrEvent.GetName() = "John Smith" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booking = cldrEvent
                    Exit For
                End If
            End If
        Next

        Return booking
    End Function

    Public Function isRiderBooked(startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim booked = False

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            ' If user has schedule
            If cldrEvent.GetName() = "John Smith" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booked = True
                    Exit For
                End If

            End If
        Next

        Return booked
    End Function

    ' ------------
    ' --- Chat ---
    ' ------------

    Public Sub AddChat(chatMessage As ChatMessage)
        chatHistory.Add(chatMessage)
    End Sub

    Public Function GetChatHistory()
        Return Me.chatHistory
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