Public Class Form1

    Dim finalDay As String = "2018/01/11 09:00:00"
    Dim startTime As String = Date.Now.ToString()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim nowTime As String = Date.Now.ToString()

        Dim total, duration1, duration2 As TimeSpan
        duration1 = DateTime.Parse(nowTime).Subtract(DateTime.Parse(startTime))
        total = duration1.Add(duration2)

        lblTimer.Text = total.ToString()

        If lblDay.Text = String.Empty Then
            Dim result As String = DateDiff(DateInterval.Day, DateTime.Now(), DateTime.Parse(finalDay)).ToString()
            If "0".Equals(result) Then
                lblDay.Text = "d-Day"
                Label2.Text = String.Empty
            Else
                lblDay.Text = DateDiff(DateInterval.Day, DateTime.Now(), DateTime.Parse(finalDay)).ToString()
            End If
        End If

    End Sub

End Class
