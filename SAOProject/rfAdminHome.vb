Public Class rfAdminHome
    Private Sub rfAdminHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        Login.Show()
    End Sub
End Class