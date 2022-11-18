Public Class CalendarBookingForm
    Inherits AppForm

    Dim currTime As Date

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = homeForm
        Me.devWindow = devForm
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

        ' Add Home and Back buttons
        Me.CreateHomeButton()
        Me.Controls.Add(Me.btnHome)
        Me.CreateBackButton()
        Me.Controls.Add(Me.btnBack)
    End Sub

    Public Overrides Sub CloseAllForms()
        ' If your form opens a new form (not home or back buttons, but creates a new one)
        ' Then you need 

        Me.Dispose()
    End Sub

End Class