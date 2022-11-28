Public Class CalendarSchedulingForm
    Inherits AppForm

    ' Children
    Dim confirmForm As CalendarConfirmForm

    Dim currTime As Date
    Dim schedulingEvent As UserCalendarEvent
    Dim previousEvent As UserCalendarEvent

    Dim repeat As String = ""
    Dim repeatTime As Date

    Dim conflictEvents As List(Of UserCalendarEvent)
    Dim conflictIndex = 0
    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String, Optional previousEvent As UserCalendarEvent = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = homeForm
        Me.devWindow = devForm

        Me.currTime = currTime
        Me.previousEvent = previousEvent
        Me.schedulingctrl.Setup(Me.currTime, trigger, Me, Me.previousEvent)
    End Sub
    Private Sub CalendarSchedulingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
        End If

        ' Add Title, Home and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel("Scheduling")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        Me.conflictEvents = New List(Of UserCalendarEvent)
    End Sub

    Public Sub NextClicked(dateStart As Date, dateEnd As Date, repeat As String, repeatTime As Date, startLocation As String, endLocation As String)
        Me.repeat = repeat
        Me.repeatTime = repeatTime

        Me.schedulingEvent = New UserCalendarEvent(My.Resources.OwnerProfile, "Jane Doe", "owner",
                                                "Tesla Model 3", "Blue", 5,
                                                dateStart, dateEnd, startLocation, endLocation)

        Me.confirmForm = New CalendarConfirmForm(Me.schedulingEvent, Me.user, Me.devWindow, Me.repeat, Me.repeatTime)
        Me.confirmForm.SetSchedulingForm(Me)

        Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
    End Sub

    Public Sub ConfirmClicked()
        ' Remove previous booking if there
        'If Me.previousEvent IsNot Nothing Then
        '    Me.devWindow.RemoveAvailability(Me.previousEvent)
        'End If

        'Add booking
        Dim startDate = Me.schedulingEvent.GetStartDate
        Dim endDate = Me.schedulingEvent.GetEndDate
        Dim clash = New List(Of UserCalendarEvent)
        Select Case Me.repeat
            Case "Never"
                Me.AddAvailabilityToList(startDate, endDate)
            Case "Daily"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Me.AddAvailabilityToList(startDate, endDate)
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
            Case "Weekly"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Me.AddAvailabilityToList(startDate, endDate)
                    startDate = startDate.AddDays(7)
                    endDate = endDate.AddDays(7)
                Loop
            Case "Monthly"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Me.AddAvailabilityToList(startDate, endDate)
                    startDate = startDate.AddMonths(1)
                    endDate = endDate.AddMonths(1)
                Loop
            Case "Monday to Friday"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    If Not (startDate.DayOfWeek = 0) AndAlso Not (startDate.DayOfWeek = 6) Then
                        Me.AddAvailabilityToList(startDate, endDate)
                    End If
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
            Case "Saturday to Sunday"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    If (startDate.DayOfWeek = 0) OrElse (startDate.DayOfWeek = 6) Then
                        Me.AddAvailabilityToList(startDate, endDate)
                    End If
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
        End Select

        Me.AddAvailability()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Sub ConflictCancelClicked()
        Me.conflictIndex += 1
        Me.AddAvailability()
    End Sub

    Public Sub ConflictConfirmClicked(prevSchdle As UserCalendarEvent)
        Dim schdle = Me.conflictEvents(Me.conflictIndex)

        Me.devWindow.RemoveAvailability(prevSchdle)
        Me.devWindow.AddAvailability(schdle)

        Me.conflictIndex += 1
        Me.AddAvailability()
    End Sub

    Public Function GetLblError()
        Return Me.lblError
    End Function

    Private Sub AddAvailabilityToList(startDate As Date, endDate As Date)
        Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                       Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                        startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
        Me.conflictEvents.Add(schdle)
    End Sub

    Private Sub AddAvailability()
        'AddAvailability Done
        If Me.conflictIndex >= Me.conflictEvents.Count Then
            Me.Close()
            Me.homeWindow.Show()
            Me.SetCurrentForm(Me.homeWindow)
            Me.homeWindow.CloseAllChildren()
            Exit Sub
        End If

        'Else, continue
        Dim schdle = Me.conflictEvents(Me.conflictIndex)

        ' Previous availability
        Dim prevSchdle = Me.devWindow.GetOwnerFirstAvailability(schdle.GetStartDate, schdle.GetEndDate)

        ' No previous availability
        If prevSchdle Is Nothing Then
            Me.devWindow.AddAvailability(schdle)
            Me.conflictIndex += 1
            Me.AddAvailability()
            Exit Sub
        End If

        ' Previous availability exists, check for booking
        Dim booking = prevSchdle.GetBooking()

        'If no booking, remove previous, add new
        If booking Is Nothing Then
            Me.devWindow.RemoveAvailability(prevSchdle)
            Me.devWindow.AddAvailability(schdle)
            Me.conflictIndex += 1
            Me.AddAvailability()
            Exit Sub
        End If

        'Trip ongoing
        If Me.devWindow.IsOngoing(booking) Then
            Dim ongoingForm = New TripOngoingForm(Me.user, Me.scenario, Me, Me.devWindow, prevSchdle)
            Me.devWindow.OpenPopup(Me.user, ongoingForm)
            Exit Sub
        End If

        ' If booking exists, confim booking be removed
        Dim removeForm = New RemoveBookedAvailabilityForm(Me.user, Me.scenario, Me, Me.devWindow, prevSchdle)
        Me.devWindow.OpenPopup(Me.user, removeForm)

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If
    End Sub
End Class