Public Class CalendarDayForm
    Inherits AppForm

    Dim currDay As Date

    Dim day As Integer
    Dim month As Integer
    Dim year As Integer

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

        ' Add Title, Home, Plus and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel("Booking")
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
        Me.usrctrlDay.SetDate(Me.currDay)

    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------
    Protected Overrides Sub btnPlus_Click(sender As Object, e As EventArgs)

    End Sub

End Class