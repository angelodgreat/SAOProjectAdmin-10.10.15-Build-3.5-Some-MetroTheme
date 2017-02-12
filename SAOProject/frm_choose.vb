Imports MetroFramework

Public Class frm_choose


    Private Sub btn_consoli_Click(sender As Object, e As EventArgs) Handles btn_consoli.Click
        TabMain.Show()
        Hide()
    End Sub

    Private Sub btn_rating_Click(sender As Object, e As EventArgs) Handles btn_rating.Click
        rfAdminHome.Show()
        Hide()
    End Sub
End Class