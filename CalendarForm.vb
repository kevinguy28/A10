Public Class CalendarForm
    Inherits AppForm

    'Parent
    Dim user As String
    Dim scenario As Integer
    Dim previousForm As HomeForm
    Dim devForm As DevForm
    'Children
    Dim dayForm As CalendarDayForm
    Dim bookingForm As CalendarBookingForm

    'Variables
    Dim currMonth As Date
    Dim month As Integer
    Dim year As Integer

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm, Optional month As Integer = 0, Optional year As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = previousForm
        Me.devForm = devForm
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

        ' Title
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White

        ' Month
        Me.usrctrlMonth.SetMonthForm(Me)
        Me.UpdateMonth(0)

    End Sub

    Public Sub CloseAllForms()
        If (Me.dayForm IsNot Nothing) Then
            Me.dayForm.CloseAllForms()
        End If

        If (Me.bookingForm IsNot Nothing) Then
            Me.bookingForm.CloseAllForms()
        End If

        ' For Saadia~
        ' Please copy+paste the bookingForm if-statement and adjust it to your scheduling form

        Me.Dispose()
    End Sub

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.devForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devForm.SetCurrentRiderForm(form)
        End If
    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------
    Public Sub DayClicked(day As Integer)
        Dim newDate = New Date(Me.year, Me.month, day)
        Me.dayForm = New CalendarDayForm(Me.user, Me.scenario, Me, Me.previousForm, Me.devForm, newDate)
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

    ' ----------------
    ' --- Location ---
    ' ----------------
    Private Sub CalendarForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.SetLocation()
    End Sub

    Private Sub SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = devForm.Width / 2
        Dim halfForm = Me.Width / 2

        If Me.user = "owner" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfForm
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "rider" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub CalendarForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = DevForm.GetFormWidth()
        Me.Height = DevForm.GetFormHeight()
    End Sub

    ' ------------
    ' --- Home ---
    ' ------------
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.previousForm.Show()
        Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
    End Sub

    Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        Me.btnHome.BackgroundImage = My.Resources.Home___Hover
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        Me.btnHome.BackgroundImage = My.Resources.Home
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

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        If Me.user = "rider" Then
            Me.bookingForm = New CalendarBookingForm(Me.user, Me.scenario, Me, Me.previousForm, Me.devForm, Me.currMonth, "MonthPlus")
            Me.Hide()
            Me.bookingForm.Show()
            Me.SetCurrentForm(Me.bookingForm)

        ElseIf Me.user = "owner" Then
            ' For Saadia!

        End If
    End Sub

    Private Sub btnPlus_MouseEnter(sender As Object, e As EventArgs) Handles btnPlus.MouseEnter
        Me.btnPlus.BackgroundImage = My.Resources.Plus___Hover
    End Sub

    Private Sub btnPlus_MouseLeave(sender As Object, e As EventArgs) Handles btnPlus.MouseLeave
        Me.btnPlus.BackgroundImage = My.Resources.Plus
    End Sub

End Class