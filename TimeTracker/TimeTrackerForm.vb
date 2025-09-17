Public Class TimeTrackerForm
    Private WithEvents StopWatch As New TimerClass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StopWatch.StartStopwatch()
    End Sub

    Private Sub StopWatch_UpdateStopwatch(value As String) Handles StopWatch.UpdateStopwatch
        Button1.Text = value
    End Sub
End Class
