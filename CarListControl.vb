Public Class CarListControl
    Dim usrEvent As UserCalendarEvent
    Dim previousForm As CalendarCarSelectForm

    Dim expanded = False
    Dim selected = False

    Dim collapsedHeight = 50
    Dim expandedHeight = 185

    Dim colourNeutral = Color.FromArgb(151, 203, 197)
    Dim colourWhite = Color.White

    Public Sub New(usrEvent As UserCalendarEvent, previousForm As CalendarCarSelectForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.previousForm = previousForm

        Me.lblTop.BackColor = colourNeutral

        Me.imgProfile.Image = Me.usrEvent.GetProfilePicture
        Me.imgProfile.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblName.Text = Me.usrEvent.GetName

        Me.imgRating.Image = Me.usrEvent.GetRatingImg
        Me.imgRating.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblCar.Text = Me.usrEvent.GetColour() & " " & Me.usrEvent.GetCar()

        Dim startText = Format(Me.usrEvent.GetStartDate, "ddd d MMM yyyy") & " " & Format(Me.usrEvent.GetStartDate, "h:mm tt")
        Dim endText = Format(Me.usrEvent.GetEndDate, "ddd d MMM yyyy") & " " & Format(Me.usrEvent.GetEndDate, "h:mm tt")

        Me.lblAvblty.Text = startText & vbCrLf & endText
    End Sub

    Private Sub CarListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = collapsedHeight
    End Sub

    Private Sub CarListControl_Click(sender As Object, e As EventArgs) Handles _
        Me.Click, lblName.Click, lblCar.Click, lblAvblty.Click, imgProfile.Click, imgRating.Click

        Me.previousForm.ControlClicked(Me)
    End Sub

    Private Sub imgArrow_Click(sender As Object, e As EventArgs) Handles imgArrow.Click
        If expanded Then
            expanded = False
            Me.Height = collapsedHeight
            Me.imgArrow.Image = My.Resources.ArrowDown___Hover
        Else
            expanded = True
            Me.Height = expandedHeight
            Me.imgArrow.Image = My.Resources.ArrowUp___Hover
        End If
    End Sub

    Public Sub SelectItem()
        Me.selected = True
        Me.BackColor = colourNeutral

        Me.imgArrow.BackColor = colourNeutral
        Me.imgProfile.BackColor = colourNeutral

        Me.lblName.BackColor = colourNeutral
        Me.lblCar.BackColor = colourNeutral
        Me.lblAvblty.BackColor = colourNeutral
        Me.lblAvPrompt.BackColor = colourNeutral
        Me.lblFromPrompt.BackColor = colourNeutral
        Me.lblToPrompt.BackColor = colourNeutral

        Select Case Me.imgArrow.Image.ToString
            Case My.Resources.ArrowUp___Neutral.ToString
                Me.imgArrow.Image = My.Resources.ArrowUp___White
            Case My.Resources.ArrowDown___Neutral.ToString
                Me.imgArrow.Image = My.Resources.ArrowDown___White
        End Select
    End Sub

    Public Sub DeselectItem()
        Me.selected = False
        Me.BackColor = colourWhite

        Me.imgArrow.BackColor = colourWhite
        Me.imgProfile.BackColor = colourWhite

        Me.lblName.BackColor = colourWhite
        Me.lblCar.BackColor = colourWhite
        Me.lblAvblty.BackColor = colourWhite
        Me.lblAvPrompt.BackColor = colourWhite
        Me.lblFromPrompt.BackColor = colourWhite
        Me.lblToPrompt.BackColor = colourWhite

        Select Case Me.imgArrow.Image.ToString
            Case My.Resources.ArrowUp___White.ToString
                Me.imgArrow.Image = My.Resources.ArrowUp___Neutral
            Case My.Resources.ArrowDown___White.ToString
                Me.imgArrow.Image = My.Resources.ArrowDown___Neutral
        End Select
    End Sub

    Private Sub imgArrow_MouseEnter(sender As Object, e As EventArgs) Handles imgArrow.MouseEnter
        If expanded Then
            Me.imgArrow.Image = My.Resources.ArrowUp___Hover
        Else
            Me.imgArrow.Image = My.Resources.ArrowDown___Hover
        End If
    End Sub

    Private Sub imgArrow_MouseLeave(sender As Object, e As EventArgs) Handles imgArrow.MouseLeave
        If expanded Then
            If selected Then
                Me.imgArrow.Image = My.Resources.ArrowUp___White
            Else
                Me.imgArrow.Image = My.Resources.ArrowUp___Neutral
            End If
        Else
            If selected Then
                Me.imgArrow.Image = My.Resources.ArrowDown___White
            Else
                Me.imgArrow.Image = My.Resources.ArrowDown___Neutral
            End If
        End If
    End Sub
End Class
