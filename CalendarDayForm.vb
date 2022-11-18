Public Class CalendarDayForm

    Dim user As String
    Dim scenario As Integer
    Dim previousForm As CalendarForm
    Dim homeForm As HomeForm
    Dim devForm As DevForm

    Dim currDay As Date

    Dim day As Integer
    Dim month As Integer
    Dim year As Integer

    Public Sub New(user As String, scenario As Integer, previousForm As CalendarForm, homeForm As HomeForm, devForm As DevForm, currDay As Date)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = previousForm
        Me.homeForm = homeForm
        Me.devForm = devForm
        Me.currDay = currDay

        Me.day = Me.currDay.Day
        Me.month = Me.currDay.Month
        Me.year = Me.currDay.Year

    End Sub

    Private Sub CalendarDayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
        End If

        ' Title
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White

        ' Day Label
        Me.lblDay.Text = Format(Me.currDay, "ddd d MMM yyyy")

        ' Day Control
        Me.usrctrlDay.SetDate(Me.currDay)

    End Sub

    Public Sub CloseAllForms()
        Me.Dispose()
    End Sub

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.devForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devForm.SetCurrentRiderForm(form)
        End If
    End Sub

    ' ----------------
    ' --- Location ---
    ' ----------------
    Private Sub CalendarDayForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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

    Private Sub CalendarDayForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = DevForm.GetFormWidth()
        Me.Height = DevForm.GetFormHeight()
    End Sub

    ' ------------
    ' --- Home ---
    ' ------------
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.homeForm.Show()
        Me.SetCurrentForm(Me.homeForm)
        Me.Dispose()
    End Sub

    Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        Me.btnHome.BackgroundImage = My.Resources.Home___Hover
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        Me.btnHome.BackgroundImage = My.Resources.Home
    End Sub

    ' ------------
    ' --- Back ---
    ' ------------

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Me.previousForm.Show()
        Me.SetCurrentForm(Me.previousForm)
        Me.Dispose()
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        Me.btnBack.BackgroundImage = My.Resources.ArrowBack___Hover
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        Me.btnBack.BackgroundImage = My.Resources.ArrowBack
    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

    End Sub

    Private Sub btnPlus_MouseEnter(sender As Object, e As EventArgs) Handles btnPlus.MouseEnter
        Me.btnPlus.BackgroundImage = My.Resources.Plus___Hover
    End Sub

    Private Sub btnPlus_MouseLeave(sender As Object, e As EventArgs) Handles btnPlus.MouseLeave
        Me.btnPlus.BackgroundImage = My.Resources.Plus
    End Sub

End Class