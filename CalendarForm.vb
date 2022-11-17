Public Class CalendarForm
    Dim user As String
    Dim scenario As Integer
    Dim previousForm As HomeForm
    Dim devForm As DevForm
    Dim dayForm As CalendarDayForm

    Dim month As String
    Dim monthInt As Integer

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm, Optional month As String = "November")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = previousForm
        Me.devForm = devForm
        Me.month = month

    End Sub

    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Title
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White

        ' Month
        Me.usrctrlMonth.SetMonthForm(Me)
        Me.UpdateMonth(Me.month)

        ' Arrows
        imgArrowLeft.Enabled = False
        imgArrowRight.Enabled = True

    End Sub

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.devForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.devForm.SetCurrentRiderForm(form)
        End If
    End Sub

    Public Sub DayClicked(day As Integer)
        Me.dayForm = New CalendarDayForm(Me.user, Me.scenario, Me, Me.previousForm, Me.devForm, Me.monthInt, day)
        Me.Hide()
        Me.dayForm.Show()
        Me.SetCurrentForm(Me.dayForm)
    End Sub

    Private Sub UpdateMonth(newMonth As String)
        Me.month = newMonth
        If Me.month = "November" Then
            Me.monthInt = 11
        ElseIf Me.month = "December" Then
            Me.monthInt = 12
        End If

        Me.usrctrlMonth.SetMonth(Me.month)
        Me.lblMonth.Text = Me.month & " 2022"
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
        Me.Width = 500
        Me.Height = 1000
    End Sub

    ' ------------
    ' --- Home ---
    ' ------------
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.previousForm.Show()
        Me.SetCurrentForm(Me.previousForm)
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
            Me.UpdateMonth("December")
        End If

        Me.imgArrowRight.Enabled = False
        Me.imgArrowLeft.Enabled = True

    End Sub

    Private Sub imgArrowLeft_Click(sender As Object, e As EventArgs) Handles imgArrowLeft.Click
        If Me.imgArrowLeft.Enabled Then
            Me.UpdateMonth("November")
        End If

        Me.imgArrowRight.Enabled = True
        Me.imgArrowLeft.Enabled = False
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

    End Sub

    Private Sub btnPlus_MouseEnter(sender As Object, e As EventArgs) Handles btnPlus.MouseEnter
        Me.btnPlus.BackgroundImage = My.Resources.Plus___Hover
    End Sub

    Private Sub btnPlus_MouseLeave(sender As Object, e As EventArgs) Handles btnPlus.MouseLeave
        Me.btnPlus.BackgroundImage = My.Resources.Plus
    End Sub

End Class