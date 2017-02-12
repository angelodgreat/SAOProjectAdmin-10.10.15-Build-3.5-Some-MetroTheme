Public Class rfPrints
    Private Sub tilStudents_Click(sender As Object, e As EventArgs) Handles tilStudents.Click
        rfIndivPrint.Show()
        Hide()
    End Sub

    Private Sub tilAll_Click(sender As Object, e As EventArgs) Handles tilAll.Click
        rfUniColPrint.Show()
        Hide()
    End Sub

    Private Sub tilHome_Click(sender As Object, e As EventArgs) Handles tilHome.Click
        rfAdminHome.Show()
        Hide()
    End Sub
End Class