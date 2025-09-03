Public Class TimerClass
    Public Event UpdateStopwatch(value As String)

    Private WithEvents SecondTimer As New Timer

    Private secondsValue As Integer
    Private minutesValue As Integer
    Private hoursValue As Integer

    ''' <summary>
    ''' When the TimerClass is initialized
    ''' </summary>
    Public Sub New()
        SecondTimer.Interval = 1000
    End Sub

    Public Sub StartStopwatch()
        SecondTimer.Start()
    End Sub

    Public Sub StopStopwatch()
        SecondTimer.Stop()
    End Sub

    Public Sub ResetStopwatch()
        secondsValue = 0
        minutesValue = 0
        hoursValue = 0
    End Sub


    '###___EventHandlers___###

    Private Sub TimerEnd() Handles SecondTimer.Tick
        If secondsValue = 59 Then
            secondsValue = 0
            If minutesValue = 59 Then
                minutesValue = 0
                hoursValue = ++1
            Else
                minutesValue = ++1
            End If
        Else
            secondsValue = ++1
        End If

        RaiseEvent UpdateStopwatch($"{hoursValue}:{minutesValue}:{secondsValue}")
    End Sub

End Class
