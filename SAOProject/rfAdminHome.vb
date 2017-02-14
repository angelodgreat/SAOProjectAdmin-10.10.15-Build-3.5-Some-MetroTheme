Public Class rfAdminHome
    Dim notifs As Integer

    Private Sub FrmAdHome_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub FetchNotifications()
        Dim query = "SELECT * FROM ceuratingforms.ratingform1 WHERE appr = 0"
        Dim query1 = "SELECT * FROM ceuratingforms.ratingform2 WHERE appr = 0"
        Dim query2 = "SELECT * FROM ceuratingforms.ratingform3 WHERE appr = 0"
        Dim query3 = "SELECT * FROM ceuratingforms.ratingform4 WHERE appr = 0"
        Dim query4 = "SELECT * FROM ceuratingforms.ratingform5 WHERE appr = 0"
        Dim query5 = "SELECT * FROM ceuratingforms.ratingform6 WHERE appr = 0"
        Dim query6 = "SELECT * FROM ceuratingforms.ratingform7 WHERE appr = 0"

        notifs = count(query, 1) + count(query1, 1) + count(query2, 1) + count(query3, 1) + count(query4, 1) + count(query5, 1) + count(query6, 1)
        lnkNotif.Visible = True
        lnkNotif.Text = "You have " & notifs & " rating forms waiting for approval."
    End Sub

    Private Sub frmAdHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Welcome, " & GetAccount() & "!"
        If GetAccess() <> "Admin" Then
            lnkNotif.Visible = False
        Else
            FetchNotifications()
        End If

    End Sub

    Private Sub tmrDay_Tick(sender As Object, e As EventArgs) Handles tmrDay.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    'private sub tillogout_click(sender as object, e as eventargs)
    '    select case msgbox("are you sure you want to log out?", msgboxstyle.yesno, "")
    '        case msgboxresult.yes
    '            dim nextform = new frmlogin()
    '            hide()
    '            nextform.show()
    '    end select
    'end sub

    Private Sub tilStudents_Click(sender As Object, e As EventArgs) Handles tilStudents.Click
        Dim nextForm = New rfAdminStudents()
        nextForm.Show()
        Hide()
    End Sub

    'Private Sub tilAccounts_Click(sender As Object, e As EventArgs) Handles tilAccounts.Click
    '    Dim nextForm = New frmAdAccounts()
    '    nextForm.Show()
    '    Hide()
    'End Sub

    Private Sub tilList_Click(sender As Object, e As EventArgs) Handles tilList.Click
        Dim nextForm = New rfPrints()
        nextForm.Show()
        Hide()
    End Sub

    Private Sub lnkNotif_Click(sender As Object, e As EventArgs) Handles lnkNotif.Click
        If notifs > 0 Then
            Dim nextForm = New rfApproveForms()
            nextForm.init(Me)
            nextForm.Show()
            Enabled = False
        End If
    End Sub
End Class