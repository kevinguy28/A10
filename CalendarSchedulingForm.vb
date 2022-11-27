Public Class CalendarSchedulingForm
    Inherits AppForm

    ' Children
    Dim confirmForm As CalendarConfirmForm

    Dim currTime As Date
    Dim schedulingEvent As UserCalendarEvent
    Dim previousEvent As UserCalendarEvent

    Dim repeat As String = ""
    Dim repeatTime As Date
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
        If Me.previousEvent IsNot Nothing Then
            Me.devWindow.RemoveAvailability(Me.previousEvent)
        End If

        'Add booking
        Dim startDate = Me.schedulingEvent.GetStartDate
        Dim endDate = Me.schedulingEvent.GetEndDate
        Select Case Me.repeat
            Case ""
            Case "Daily"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                       Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                        startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
                    Me.devWindow.AddAvailability(schdle)
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
            Case "Weekly"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                       Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                        startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
                    Me.devWindow.AddAvailability(schdle)
                    startDate = startDate.AddDays(7)
                    endDate = endDate.AddDays(7)
                Loop
            Case "Monthly"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                       Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                        startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
                    Me.devWindow.AddAvailability(schdle)
                    startDate = startDate.AddMonths(1)
                    endDate = endDate.AddMonths(1)
                Loop
            Case "Monday to Friday"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    If Not (startDate.DayOfWeek = 0) AndAlso Not (startDate.DayOfWeek = 6) Then
                        Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                       Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                        startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
                        Me.devWindow.AddAvailability(schdle)
                    End If
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
            Case "Saturday to Sunday"
                Do Until endDate.CompareTo(Me.repeatTime) >= 0
                    If (startDate.DayOfWeek = 0) OrElse (startDate.DayOfWeek = 6) Then
                        Dim schdle = New UserCalendarEvent(Me.schedulingEvent.GetProfilePicture, Me.schedulingEvent.GetName, Me.schedulingEvent.GetUserType,
                                                   Me.schedulingEvent.GetCar, Me.schedulingEvent.GetColour, Me.schedulingEvent.GetRatingInt,
                                                    startDate, endDate, Me.schedulingEvent.GetStartLocation, Me.schedulingEvent.GetEndLocation)
                        Me.devWindow.AddAvailability(schdle)
                    End If
                    startDate = startDate.AddDays(1)
                    endDate = endDate.AddDays(1)
                Loop
        End Select

        Me.Close()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)
        Me.homeWindow.CloseAllChildren()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Function GetLblError()
        Return Me.lblError
    End Function

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If
    End Sub
End Class