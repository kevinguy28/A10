Public Class CalendarCarSelectForm
    Inherits AppForm

    Dim dateStart As Date
    Dim dateEnd As Date

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, HomeForm As HomeForm, DevForm As DevForm, dateStart As Date, dateEnd As Date)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = HomeForm
        Me.devWindow = DevForm

        ' Date
        Me.dateStart = dateStart
        Me.dateEnd = dateEnd
    End Sub

    Private Sub CalendarCarSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add Title, Home, Plus and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel("Select Your Ride")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        Me.Label1.Text = Format(dateStart, "dddd d MMMM yyyy hh:mm:ss tt")
        Me.Label2.Text = Format(dateEnd, "dddd d MMMM yyyy hh:mm:ss tt")

    End Sub

    '' --- Car ---
    'Dim lblCar As Label

    'Dim lblCarPrompt As Label
    'Dim lstvwSelected As ListView
    'Dim WithEvents btnCarSelect As Button

    'Dim lstvwCar As ListView

    'Private Sub CreateCar()
    '    'Dim lblCar As Label

    '    'Dim lblCarPrompt As Label
    '    'Dim lstvwSelected As ListView
    '    'Dim WithEvents btnCarSelect As Button

    '    'Dim lstvwCar As ListView

    '    ' lblCar
    '    Me.lblCar = New Label()
    '    Me.lblCar.Text = "Car"
    '    Me.lblCar.TextAlign = headingTextAlign
    '    Me.lblCar.Font = headingFont
    '    Me.lblCar.Size = headingSize
    '    Me.lblCar.AutoSize = False
    '    Me.lblCar.Margin = headingPadding
    '    Me.lblCar.BackColor = colourNeutral
    '    Me.lblCar.ForeColor = colourWhite

    '    ' lblCarPrompt
    '    Me.lblCarPrompt = New Label
    '    Me.lblCarPrompt.Text = "Select a car to book:"
    '    Me.lblCarPrompt.Font = bodyFont
    '    Me.lblCarPrompt.AutoSize = True
    '    Me.lblCarPrompt.Margin = leftPadding

    'End Sub


End Class