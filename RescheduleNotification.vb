Public Class RescheduleNotification
    Inherits AppForm

    ' Forms
    Shared riderNotification As RescheduleNotification
    Shared riderRebook As CalendarForm

    ' Opened
    Shared riderNotificationOpened = False
    Public Shared calenderOpened = False

    Public Sub New(user As String, scenario As Integer, devForm As DevForm, home As HomeForm, Optional mainForm As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.devWindow = devForm : Me.homeWindow = home

    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Private Sub OpenReschedulingForm()
        If Not RescheduleNotification.calenderOpened Then
            RescheduleNotification.calenderOpened = True
            RescheduleNotification.riderRebook = New CalendarForm("rider", Me.scenario, Me.homeWindow, Me.devWindow)
            Me.Close()
            RescheduleNotification.riderRebook.Show()
            Me.SetCurrentForm(RescheduleNotification.riderRebook)
        End If
    End Sub

    Public Shared Sub CloseAllForms()
        If (Not riderNotificationOpened) AndAlso (Not calenderOpened) Then

            If (RescheduleNotification.riderNotification IsNot Nothing) Then
                RescheduleNotification.riderNotification.Dispose()
                RescheduleNotification.riderNotification = Nothing
            End If

            If (RescheduleNotification.riderRebook IsNot Nothing) Then
                RescheduleNotification.riderRebook.Dispose()
                RescheduleNotification.riderRebook = Nothing
            End If

            ' Opened
            calenderOpened = False
            riderNotificationOpened = False
        End If
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnReschedule_Click(sender As Object, e As EventArgs) Handles btnReschedule.Click
        Me.OpenReschedulingForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        RescheduleNotification.CloseAllForms()
        Me.Close()
    End Sub

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Me Is RescheduleNotification.riderNotification Then
            RescheduleNotification.riderNotificationOpened = False
        End If
        If Me Is RescheduleNotification.riderRebook Then
            RescheduleNotification.calenderOpened = False
        End If
        Me.devWindow.ClosePopup(Me.user)
        RescheduleNotification.CloseAllForms()
    End Sub
End Class