Public Class CalendarSchedulingForm
    Inherits AppForm

    Dim currTime As Date
    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String)

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
        Me.schedulingctrl.Setup(Me.currTime, trigger, Me)
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

    Public Function GetLblError()
        Return Me.lblError
    End Function
End Class