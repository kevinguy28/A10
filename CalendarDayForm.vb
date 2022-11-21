Public Class CalendarDayForm
    Inherits AppForm

    Dim currDay As Date
    Dim userEvent As UserCalendarEvent

    'Children
    Dim bookingForm As CalendarBookingForm
    Dim schedulingForm As CalendarSchedulingForm

    Public Sub New(user As String, scenario As Integer, previousForm As CalendarForm, homeForm As HomeForm, devForm As DevForm, currDay As Date)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = homeForm
        Me.devWindow = devForm

        ' Date
        Me.currDay = currDay

    End Sub

    Private Sub CalendarDayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        Dim title As String
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
            title = "Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
            title = "Booking"
        End If



        ' Add Title, Home, Plus and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel(title)
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.CreatePlusButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPlus)

        ' Day Label
        Me.lblDay.Text = Format(Me.currDay, "ddd d MMM yyyy")

        ' Day Control
        Me.usrctrlDay.SetParentForm(Me)
        Me.usrctrlDay.SetDevForm(Me.devWindow)
        Me.usrctrlDay.SetVariables(Me.user, Me.scenario)
        Me.usrctrlDay.SetDate(Me.currDay)

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.bookingForm IsNot Nothing) Then
            Me.bookingForm.CloseAllForms()
        End If

        If (Me.schedulingForm IsNot Nothing) Then
            Me.schedulingForm.CloseAllForms()
        End If

    End Sub

    Public Sub TimeSlotClicked(timeDate As Date, Optional userEvent As UserCalendarEvent = Nothing)
        Me.userEvent = userEvent

        If Me.user = "rider" Then
            Me.bookingForm = New CalendarBookingForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, timeDate, "DaySlot", Me.userEvent)
            Me.Hide()
            Me.bookingForm.Show()
            Me.SetCurrentForm(Me.bookingForm)

        ElseIf Me.user = "owner" Then
            'Me.schedulingForm = New CalendarSchedulingForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, timeDate, "DaySlot", Me.userEvent)
            Me.Hide()
            Me.schedulingForm.Show()
            Me.SetCurrentForm(Me.schedulingForm)
        End If

    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------
    Protected Overrides Sub btnPlus_Click(sender As Object, e As EventArgs)

        If Me.user = "rider" Then
            Me.bookingForm = New CalendarBookingForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, Me.currDay, "DayPlus")
            Me.Hide()
            Me.bookingForm.Show()
            Me.SetCurrentForm(Me.bookingForm)

        ElseIf Me.user = "owner" Then
            Me.schedulingForm = New CalendarSchedulingForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, Me.currDay, "DayPlus")
            Me.Hide()
            Me.schedulingForm.Show()
            Me.SetCurrentForm(Me.schedulingForm)
        End If

    End Sub

End Class