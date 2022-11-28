Public Class CalendarBookingForm
    Inherits AppForm

    ' Children
    Dim carSelectForm As CalendarCarSelectForm

    Dim currTime As Date
    Dim userEvent As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String, Optional userEvent As UserCalendarEvent = Nothing)

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
        Me.userEvent = userEvent
        Me.usrctrlBooking.Setup(Me.currTime, trigger, Me, Me.userEvent)
    End Sub

    Private Sub CalendarBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
        End If

        ' Add Title, Home and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel("Booking")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.carSelectForm IsNot Nothing) Then
            Me.carSelectForm.CloseAllForms()
        End If

    End Sub

    Public Sub NextClicked(dateStart As Date)
        Me.carSelectForm = New CalendarCarSelectForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, dateStart, Me.userEvent)
        Me.Hide()
        Me.carSelectForm.Show()
        Me.SetCurrentForm(Me.carSelectForm)
    End Sub

    Public Function GetLblError()
        Return Me.lblError
    End Function

End Class