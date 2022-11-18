Public Class CalendarBookingForm

    Dim user As String
    Dim scenario As Integer
    Dim previousForm As Form
    Dim homeForm As HomeForm
    Dim devForm As DevForm

    Dim currTime As Date

    Public Sub New(user As String, scenario As Integer, previousForm As Form, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = previousForm
        Me.homeForm = homeForm
        Me.devForm = devForm
        Me.currTime = currTime
        Me.usrctrlBooking.Setup(Me.currTime, trigger, Me)
    End Sub

    Private Sub CalendarBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form
        If Me.user = "owner" Then
            Me.Text = "Car Owner Scheduling"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Booking"
        End If

        ' Title
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White
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

    ' -----------------
    ' --- Functions ---
    ' -----------------


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
        Me.Width = DevForm.GetWidth()
        Me.Height = DevForm.GetHeight()
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

End Class