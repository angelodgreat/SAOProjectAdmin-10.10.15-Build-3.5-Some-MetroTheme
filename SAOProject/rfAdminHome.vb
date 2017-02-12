Public Class rfAdminHome
    Dim notifs As Integer
    Private Sub rfAdminHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        Login.Show()
    End Sub

    Private Sub tilStudents_Click(sender As Object, e As EventArgs) Handles tilStudents.Click
        rfAdminStudents.Show()
        Hide()
    End Sub

    Private Sub tilList_Click(sender As Object, e As EventArgs) Handles tilList.Click
        rfPrints.Show()
        Hide()
    End Sub

    Private Sub tilBack_Click(sender As Object, e As EventArgs) Handles tilBack.Click
        frm_choose.Show()
        Hide()
    End Sub

    Public Sub FetchNotifications()
        Dim query = "SELECT * FROM ratingform1 WHERE appr = 0"
        Dim query1 = "SELECT * FROM ratingform2 WHERE appr = 0"
        Dim query2 = "SELECT * FROM ratingform3 WHERE appr = 0"
        Dim query3 = "SELECT * FROM ratingform4 WHERE appr = 0"
        Dim query4 = "SELECT * FROM ratingform5 WHERE appr = 0"
        Dim query5 = "SELECT * FROM ratingform6 WHERE appr = 0"
        Dim query6 = "SELECT * FROM ratingform7 WHERE appr = 0"

        notifs = count(query, 1) + count(query1, 1) + count(query2, 1) + count(query3, 1) + count(query4, 1) + count(query5, 1) + count(query6, 1)
        lnkNotif.Visible = True
        lnkNotif.Text = "You have " & notifs & " rating forms waiting for approval."
    End Sub

    Private Sub frmAdHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Welcome, " & GetAccount() & "!"
        If GetAccess() <> "Administrator" Then
            lnkNotif.Visible = False
        Else
            FetchNotifications()
        End If

    End Sub
End Class