Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgb.Increment(5)

        If prgb.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            DBSettings.Show()

        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class