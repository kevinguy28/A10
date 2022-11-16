Public Class CalendarForm
    Dim user As String
    Dim scenario As Integer
    Dim parentForm As HomeForm

    Public Sub New(user As String, scenario As Integer, parentForm As HomeForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.parentForm = parentForm

    End Sub

    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitle.BackColor = Color.FromArgb(151, 203, 197)
        Me.lblTitle.ForeColor = Color.White
        'RGB(151, 203, 197)
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
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "owner" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfHome
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "rider" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Me.parentForm.Show()
    End Sub
End Class