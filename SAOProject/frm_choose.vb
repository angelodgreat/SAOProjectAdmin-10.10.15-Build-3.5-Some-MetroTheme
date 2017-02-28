Imports MetroFramework

Public Class frm_choose
    Public logintype As String


    Private Sub btn_consoli_Click(sender As Object, e As EventArgs) Handles btn_consoli.Click
        logintype = Login.usertype

        Try
            If logintype = "Admin" Then
                TabMain.reg_cb_usertype.Items.Add("Guest")
                TabMain.reg_cb_usertype.Items.Add("-")
                Hide()
                TabMain.Show()
            ElseIf logintype = "SuperAdmin" Then
                TabMain.reg_cb_usertype.Items.Add("Admin")
                TabMain.reg_cb_usertype.Items.Add("Guest")
                TabMain.reg_cb_usertype.Items.Add("-")
                Hide()
                TabMain.Show()
            ElseIf logintype = "Guest" Then
                Hide()
                GuestOnly.Show()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_rating_Click(sender As Object, e As EventArgs) Handles btn_rating.Click
        rfAdminHome.Show()
        Hide()
    End Sub
End Class