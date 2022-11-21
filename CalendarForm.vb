Public Class CalendarForm
    Inherits AppForm

    'Children
    Dim dayForm As CalendarDayForm
    Dim bookingForm As CalendarBookingForm
    Dim schedulingForm As CalendarSchedulingForm


    'Variables
    Dim currMonth As Date
    Dim month As Integer
    Dim year As Integer

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm, Optional month As Integer = 0, Optional year As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm Variables
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm

        ' Date Variables
        Me.month = month
        Me.year = year

        Dim today = New Date.Now()
        If Me.month = 0 Then
            Me.month = today.Month
        End If
        If Me.year = 0 Then
            Me.year = today.Year
        End If
        currMonth = New Date(Me.year, Me.month, 1)

    End Sub

    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
        End If

        ' Title, Home, and Plus
        Me.SetBackground()
        Me.CreateTitleLabel("Calendar")
        Me.CreateHomeButton()
        Me.CreatePlusButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnPlus)

        ' Month
        Me.usrctrlMonth.SetMonthForm(Me)
        Me.UpdateMonth(0)

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.dayForm IsNot Nothing) Then
            Me.dayForm.CloseAllForms()
        End If

        If (Me.bookingForm IsNot Nothing) Then
            Me.bookingForm.CloseAllForms()
        End If

        ' For Saadia~
        ' Please copy+paste the bookingForm if-statement and adjust it to your scheduling form

    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------
    Public Sub DayClicked(day As Integer)
        Dim newDate = New Date(Me.year, Me.month, day)
        Me.dayForm = New CalendarDayForm(Me.user, Me.scenario, Me, Me.previousWindow, Me.devWindow, newDate)
        Me.Hide()
        Me.dayForm.Show()
        Me.SetCurrentForm(Me.dayForm)
    End Sub

    Private Sub UpdateMonth(monthChange As Integer)
        Dim newMonth = Me.month + monthChange
        If newMonth = 0 Then
            ' Previous year Dec
            newMonth = 12
            Me.year -= 1
        ElseIf newMonth = 13 Then
            ' Next year Jan
            newMonth = 1
            Me.year += 1
        End If

        Me.month = newMonth
        Me.currMonth = New Date(Me.year, Me.month, 1)

        Me.usrctrlMonth.SetMonth(Me.currMonth)
        Me.lblMonth.Text = Format(Me.currMonth, "MMMM yyyy")
    End Sub

    ' -------------------
    ' --- Arrow Click ---
    ' -------------------
    Private Sub imgArrowRight_Click(sender As Object, e As EventArgs) Handles imgArrowRight.Click
        If Me.imgArrowRight.Enabled Then
            Me.UpdateMonth(1)
        End If
    End Sub

    Private Sub imgArrowLeft_Click(sender As Object, e As EventArgs) Handles imgArrowLeft.Click
        If Me.imgArrowLeft.Enabled Then
            Me.UpdateMonth(-1)
        End If
    End Sub


    ' -------------------
    ' --- Arrow Hover ---
    ' -------------------
    Private Sub imgArrowRight_MouseEnter(sender As Object, e As EventArgs) Handles imgArrowRight.MouseEnter
        Me.imgArrowRight.Image = My.Resources.ArrowRight___Hover
    End Sub

    Private Sub imgArrowRight_MouseLeave(sender As Object, e As EventArgs) Handles imgArrowRight.MouseLeave
        Me.imgArrowRight.Image = My.Resources.ArrowRight
    End Sub

    Private Sub imgArrowLeft_MouseEnter(sender As Object, e As EventArgs) Handles imgArrowLeft.MouseEnter
        Me.imgArrowLeft.Image = My.Resources.ArrowLeft___Hover
    End Sub

    Private Sub imgArrowLeft_MouseLeave(sender As Object, e As EventArgs) Handles imgArrowLeft.MouseLeave
        Me.imgArrowLeft.Image = My.Resources.ArrowLeft
    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------
    Protected Overrides Sub btnPlus_Click(sender As Object, e As EventArgs)

        If Me.user = "rider" Then
            Me.bookingForm = New CalendarBookingForm(Me.user, Me.scenario, Me, Me.previousWindow, Me.devWindow, Me.currMonth, "MonthPlus")
            Me.Hide()
            Me.bookingForm.Show()
            Me.SetCurrentForm(Me.bookingForm)

        ElseIf Me.user = "owner" Then
            ' For Saadia
            Me.schedulingForm = New CalendarSchedulingForm(Me.user, Me.scenario, Me, Me.previousWindow, Me.devWindow, Me.currMonth, "MonthPlus")
            Me.Hide()
            Me.schedulingForm.Show()
            Me.SetCurrentForm(Me.schedulingForm )
        End If
    End Sub

End Class