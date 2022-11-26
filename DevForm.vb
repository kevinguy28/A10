Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Dim currentOwnerForm As AppForm
    Dim currentRiderForm As AppForm

    Dim lastOwnerPopup As Form
    Dim lastRiderPopup As Form

    ' Scheduling / Booking
    Dim ownerAvailabilityList As List(Of UserCalendarEvent)
    Dim riderBookingList As List(Of UserCalendarEvent)

    Dim currentBooking As UserCalendarEvent
    Dim currentSchedule As UserCalendarEvent

    ' Chat
    Dim chatHistory As New List(Of ChatMessage)

    ' Route
    Dim carMoving As Boolean = False

    ' Car Features
    Dim fanIntake = 1
    Dim fanStrength = 1
    Dim temperature = 12
    Dim toggleWindow = 0
    Dim toggleTrunk = 0

    ' Car Media
    Dim speakerVolume = 1
    Dim speakersOnOff = 0
    Dim connectedPhone = 0


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

            ' Close Popup
            If Me.lastOwnerPopup IsNot Nothing Then
                Me.lastOwnerPopup.Close()
                Me.lastOwnerPopup.Dispose()
            End If
            If Me.lastRiderPopup IsNot Nothing Then
                Me.lastRiderPopup.Close()
                Me.lastRiderPopup.Dispose()
            End If
        End If

        ' Reset Arrays
        Me.CreateOwnerAvailability()
        Me.CreateRiderBookings()
        Me.chatHistory = New List(Of ChatMessage)

        ' Reset Car Features
        Me.fanIntake = 1
        Me.fanStrength = 1
        Me.temperature = 12
        Me.toggleWindow = 0

        ' Open new windows
        Dim scenario = CType(sender, Button).Tag
        Me.ownerWindow = New HomeForm("owner", CType(sender, Button).Tag, Me)
        Me.riderWindow = New HomeForm("rider", CType(sender, Button).Tag, Me)
        Me.ownerWindow.addOtherForm(riderWindow)
        Me.riderWindow.addOtherForm(ownerWindow)
        Me.ownerWindow.Show()
        Me.riderWindow.Show()
        Me.currentOwnerForm = Me.ownerWindow
        Me.currentRiderForm = Me.riderWindow

        ' Scenario 4: Low Battery Notification
        If scenario = 4 Then
            ' Rider
            Dim riderLowBatteryNotification As New LowBatteryNotificationForm("rider", scenario, Me)
            Me.OpenPopup("rider", riderLowBatteryNotification)

            'Owner
            Dim ownerLowBatteryNotification As New LowBatteryNotificationForm("owner", scenario, Me)
            'ownerLowBatteryNotification.lblDescription.Text = "The car battery is running low. Please wait for the riders response!"
            Me.OpenPopup("owner", ownerLowBatteryNotification)
        End If

    End Sub

    ' ---------------------
    ' --- Current Forms ---
    ' ---------------------

    Public Sub SetCurrentOwnerForm(form As AppForm)
        Me.currentOwnerForm = form
    End Sub

    Public Sub SetCurrentRiderForm(form As AppForm)
        Me.currentRiderForm = form
    End Sub

    Public Function GetCurrentOwnerForm()
        Return Me.currentOwnerForm
    End Function

    Public Function GetCurrentRiderForm()
        Return Me.currentRiderForm
    End Function

    Public Shared Function GetFormWidth() As Integer
        Return 500
    End Function

    Public Shared Function GetFormHeight() As Integer
        Return 1000
    End Function

    Public Shared Function GetDevWidth() As Integer
        Return DevForm.Width
    End Function

    Public Shared Function GetOwnerLocation() As Point
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.GetDevWidth() / 2
        Dim halfForm = DevForm.GetFormWidth() / 2

        Dim x = ((halfScreen - halfDev) / 2) - halfForm
        Dim loc = New Point(x, 0)
        Return loc
    End Function

    Public Shared Function GetRiderLocation() As Point
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.GetDevWidth() / 2
        Dim halfForm = DevForm.GetFormWidth() / 2

        Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
        Dim loc = New Point(x, 0)
        Return loc
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

        Me.ownerAvailabilityList = New List(Of UserCalendarEvent)()
        Dim today = New Date.Now()

        ' Make Availabilities for one week
        For dayNum As Integer = 0 To 6
            Dim currDay = today.AddDays(dayNum)

            Dim startDate = New Date(currDay.Year, currDay.Month, currDay.Day, 8, 0, 0)
            Dim endDate = New Date(currDay.Year, currDay.Month, currDay.Day, 22, 0, 0)

            Dim ownerOne = New UserCalendarEvent(My.Resources.RandomProfileOne, "Eric Holme", "owner", "Hyundai Ioniq 6", "Red", 2, startDate, endDate)
            Dim ownerTwo = New UserCalendarEvent(My.Resources.RandomProfileTwo, "Nessa Whitney", "owner", "Porsche Taycan", "Black", 3, startDate, endDate)
            Dim ownerThr = New UserCalendarEvent(My.Resources.RandomProfileThree, "Monica Penner", "owner", "Chevrolet Bolt EV", "Grey", 3, startDate, endDate)
            Dim ownerFou = New UserCalendarEvent(My.Resources.RandomProfileFour, "Robert Kitchens", "owner", "Ford Mustang Mach-E", "White", 4, startDate, endDate)

            Me.ownerAvailabilityList.Add(ownerOne)
            Me.ownerAvailabilityList.Add(ownerTwo)
            Me.ownerAvailabilityList.Add(ownerThr)
            Me.ownerAvailabilityList.Add(ownerFou)
        Next
    End Sub

    Private Sub CreateRiderBookings()
        Me.riderBookingList = New List(Of UserCalendarEvent)()
    End Sub

    Public Function AddAvailability(scheduling As UserCalendarEvent) As Boolean
        Dim newStart = scheduling.GetStartDate
        Dim newEnd = scheduling.GetEndDate
        Dim conflict = False
        ' Prevent overlap between consecutive schedulings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = scheduling.GetName Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                Dim oldCar = cldrEvent.GetCar()
                ' Prevent overlap between consecutive schedulings
                oldEnd = oldEnd.AddSeconds(-1)

                If Not (oldCar = scheduling.GetCar) Then
                    Continue For
                End If

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
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
        Me.ownerAvailabilityList.Add(scheduling)
        Return True

    End Function

    Public Sub RemoveAvailability(availability As UserCalendarEvent)
        Me.ownerAvailabilityList.Remove(availability)
    End Sub

    Public Function GetAllAvailabilities(startDate As Date, endDate As Date) As List(Of UserCalendarEvent)
        Dim newStart = startDate
        Dim newEnd = endDate
        ' Prevent overlap between consecutive schedulings
        newEnd = newEnd.AddSeconds(-1)

        Dim allAvblty As List(Of UserCalendarEvent) = New List(Of UserCalendarEvent)()

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            Dim oldStart = cldrEvent.GetStartDate()
            Dim oldEnd = cldrEvent.GetEndDate()
            ' Prevent overlap between consecutive schedulings
            oldEnd = oldEnd.AddSeconds(-1)

            ' New | ⬛⬛⬛⬛   |
            ' Old |   ⬛⬛⬛⬛ |
            'newEnd later then oldStart
            'newEnd earlier than oldEnd
            If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                allAvblty.Add(cldrEvent)
                Continue For
            End If

            ' New |   ⬛⬛⬛⬛ |
            ' Old | ⬛⬛⬛⬛   |
            'newStart later than oldStart
            'newStart earlier than oldEnd
            If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                allAvblty.Add(cldrEvent)
                Continue For
            End If

            ' New |  ⬛⬛  |
            ' Old | ⬛⬛⬛⬛ |
            'newStart later than oldStart
            'newEnd earlier than oldEnd
            If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                allAvblty.Add(cldrEvent)
                Continue For
            End If

            ' New | ⬛⬛⬛⬛ |
            ' Old |  ⬛⬛  |
            'newStart earlier than oldStart
            'newEnd later than oldEnd
            If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                allAvblty.Add(cldrEvent)
                Continue For
            End If

        Next

        Return allAvblty
    End Function

    Public Function GetOwnerFirstAvailability(startDate As Date, endDate As Date) As UserCalendarEvent
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim availability As UserCalendarEvent
        ' Prevent overlap between consecutive schedulings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = "Jane Doe" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                ' Prevent overlap between consecutive schedulings
                oldEnd = oldEnd.AddSeconds(-1)

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    availability = cldrEvent
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    availability = cldrEvent
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    availability = cldrEvent
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                    availability = cldrEvent
                    Exit For
                End If

            End If
        Next

        Return availability
    End Function

    Public Function isOwnerAvailable(startDate As Date, endDate As Date) As Boolean
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim available = False
        ' Prevent overlap between consecutive schedulings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerAvailabilityList

            ' If user has schedule
            If cldrEvent.GetName() = "Jane Doe" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                ' Prevent overlap between consecutive schedulings
                oldEnd = oldEnd.AddSeconds(-1)

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    available = True
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    available = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    available = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
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

    Public Function CheckRiderBookingConflict(startDate As Date, endDate As Date) As Boolean
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim conflict = False
        ' Prevent overlap between consecutive bookings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            ' If user has schedule
            If cldrEvent.GetName() = "John Smith" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                Dim oldCar = cldrEvent.GetCar()
                ' Prevent overlap between consecutive bookings
                oldEnd = oldEnd.AddSeconds(-1)

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    conflict = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                    conflict = True
                    Exit For
                End If
            End If
        Next

        If conflict Then
            Return True
            Exit Function
        End If

        Return False
    End Function

    Public Function AddBooking(booking As UserCalendarEvent) As Boolean
        Dim conflict As Boolean = Me.CheckRiderBookingConflict(booking.GetStartDate, booking.GetEndDate)

        If conflict Then
            Return False
            Exit Function
        End If

        ' No conflict

        ' Update owner's event
        For Each ownerEvent As UserCalendarEvent In Me.ownerAvailabilityList

            If ownerEvent.GetName = booking.GetCarOwnerName AndAlso ownerEvent.GetCar = booking.GetCar _
                AndAlso Me.LaterThan(booking.GetStartDate, ownerEvent.GetStartDate) AndAlso Me.EarlierThan(booking.GetEndDate, ownerEvent.GetEndDate) Then

                ownerEvent.RiderFound("John Smith", My.Resources.RiderProfile)
                Exit For
            End If
        Next

        Me.riderBookingList.Add(booking)
        Return True
    End Function

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

    Public Function GetAllBookings(startDate As Date, endDate As Date) As List(Of UserCalendarEvent)
        Dim newStart = startDate
        Dim newEnd = endDate
        ' Prevent overlap between consecutive bookings
        newEnd = newEnd.AddSeconds(-1)

        Dim allBkng As List(Of UserCalendarEvent) = New List(Of UserCalendarEvent)()

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            Dim oldStart = cldrEvent.GetStartDate()
            Dim oldEnd = cldrEvent.GetEndDate()
            ' Prevent overlap between consecutive bookings
            oldEnd = oldEnd.AddSeconds(-1)

            ' New | ⬛⬛⬛⬛   |
            ' Old |   ⬛⬛⬛⬛ |
            'newEnd later then oldStart
            'newEnd earlier than oldEnd
            If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                allBkng.Add(cldrEvent)
                Continue For
            End If

            ' New |   ⬛⬛⬛⬛ |
            ' Old | ⬛⬛⬛⬛   |
            'newStart later than oldStart
            'newStart earlier than oldEnd
            If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                allBkng.Add(cldrEvent)
                Continue For
            End If

            ' New |  ⬛⬛  |
            ' Old | ⬛⬛⬛⬛ |
            'newStart later than oldStart
            'newEnd earlier than oldEnd
            If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                allBkng.Add(cldrEvent)
                Continue For
            End If

            ' New | ⬛⬛⬛⬛ |
            ' Old |  ⬛⬛  |
            'newStart earlier than oldStart
            'newEnd later than oldEnd
            If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                allBkng.Add(cldrEvent)
                Continue For
            End If

        Next

        Return allBkng
    End Function

    Public Function GetRiderFirstBooking(startDate As Date, endDate As Date) As UserCalendarEvent
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim booking As UserCalendarEvent
        ' Prevent overlap between consecutive bookings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            ' If user has schedule
            If cldrEvent.GetName() = "John Smith" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                ' Prevent overlap between consecutive bookings
                oldEnd = oldEnd.AddSeconds(-1)

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booking = cldrEvent
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    booking = cldrEvent
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booking = cldrEvent
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                    booking = cldrEvent
                    Exit For
                End If
            End If
        Next

        Return booking
    End Function

    Public Function isRiderBooked(startDate As Date, endDate As Date) As Boolean
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim booked = False
        ' Prevent overlap between consecutive bookings
        newEnd = newEnd.AddSeconds(-1)

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.riderBookingList

            ' If user has schedule
            If cldrEvent.GetName() = "John Smith" Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                ' Prevent overlap between consecutive bookings
                oldEnd = oldEnd.AddSeconds(-1)

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booked = True
                    Exit For
                End If

                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) Then
                    booked = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) Then
                    booked = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart earlier than oldStart
                'newEnd later than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.LaterThan(newEnd, oldEnd) Then
                    booked = True
                    Exit For
                End If

            End If
        Next

        Return booked
    End Function

    ' ----------------------------------
    ' --- Current Booking / Schedule ---
    ' -----------------------------------

    Private Sub SetCurrentBooking(Optional bookingEvent As UserCalendarEvent = Nothing)
        If bookingEvent Is Nothing Then
            Me.currentBooking = Me.GetRiderFirstBooking(New Date.Now(), New Date.Now().AddYears(10))
        Else
            Me.currentBooking = bookingEvent
        End If
    End Sub

    Public Function GetCurrentBooking() As UserCalendarEvent
        Me.SetCurrentBooking()
        Return Me.currentBooking
    End Function

    Private Sub SetCurrentSchedule(Optional scheduleEvent As UserCalendarEvent = Nothing)
        If scheduleEvent Is Nothing Then
            Me.currentSchedule = Me.GetOwnerFirstAvailability(New Date.Now(), New Date.Now().AddYears(10))
        Else
            Me.currentSchedule = scheduleEvent
        End If
    End Sub

    Public Function GetCurrentSchedule() As UserCalendarEvent
        Me.SetCurrentSchedule()
        Return Me.currentSchedule
    End Function

    ' ------------------
    ' --- Car Moving ---
    ' ------------------

    Public Sub SetCarMoving(moving As Boolean)
        Me.carMoving = moving
    End Sub

    Public Function GetCarMoving() As Boolean
        Return Me.carMoving
    End Function

    ' ------------
    ' --- Chat ---
    ' ------------

    Public Sub AddChat(chatMessage As ChatMessage)
        chatHistory.Add(chatMessage)
    End Sub

    Public Function GetChatHistory() As List(Of ChatMessage)
        Return Me.chatHistory
    End Function

    ' -------------------
    ' --- Car Feature ---
    ' -------------------

    Public Sub UpdateStregth(fanStrength As Integer)
        Me.fanStrength += fanStrength
    End Sub

    Public Sub UpdateIntake(fanIntake As Integer)
        Me.fanIntake += fanIntake
    End Sub

    Public Sub UpdateTemperature(temperature As Integer)
        Me.temperature += temperature
    End Sub

    Public Function GetFanStrength()
        Return Me.fanStrength
    End Function

    Public Function GetFanIntake()
        Return Me.fanIntake
    End Function

    Public Function GetTemperature()
        Return Me.temperature
    End Function

    Public Sub UpdateToggleWindow(update As Integer)
        Me.toggleWindow = update
    End Sub

    Public Function GetToggleWindow()
        Return Me.toggleWindow
    End Function

    Public Sub UpdateToggleTrunk(update As Integer)
        Me.toggleTrunk = update
    End Sub

    Public Function GetToggleTrunk()
        Return Me.toggleTrunk
    End Function

    ' --------------
    ' -- Car Media -
    ' --------------

    Public Sub UpdateSpeakerOnOff(update As Integer)
        Me.speakersOnOff = update
    End Sub

    Public Function GetSpeakerOnOff()
        Return Me.speakersOnOff
    End Function

    Public Sub UpdateSpeakerVolume(value As Integer)
        Me.speakerVolume += value
    End Sub

    Public Function GetSpeakerVolume()
        Return Me.speakerVolume
    End Function

    Public Sub UpdateConnectedPhone(update As Integer)
        Me.connectedPhone = update
    End Sub

    Public Function GetConnectedPhone()
        Return Me.connectedPhone
    End Function


    ' --------------
    ' --- Popups ---
    ' --------------
    Public Sub OpenPopup(user As String, popup As Form)
        Select Case user
            Case "owner"
                Me.currentOwnerForm.DimScreen()
                Me.lastOwnerPopup = popup
            Case "rider"
                Me.currentRiderForm.DimScreen()
                Me.lastRiderPopup = popup
        End Select
        popup.Show()
        popup.TopMost = True
    End Sub

    Public Sub ClosePopup(user As String)
        Select Case user
            Case "owner"
                Me.currentOwnerForm.UnDimScreen()
            Case "rider"
                Me.currentRiderForm.UnDimScreen()
        End Select
    End Sub

End Class