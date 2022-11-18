Public Class CalendarBookingForm
    Inherits AppForm

    Dim currTime As Date

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm, currTime As Date, trigger As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm Variables
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
        ' If your form opens a new form (not home or back buttons, or notifications, but creates a new one)
        ' Then you need to create a globabl variable for each child.
        ' See HomeForm for an example.
        ' Over here, you call the following for each child:
        '       If (Me.childForm IsNot Nothing) Then
        '          Me.childForm.CloseAllForms()
        '       End If
        ' See HomeForm for example
        ' If you don't have any children forms, then you can ignore this
    End Sub

End Class