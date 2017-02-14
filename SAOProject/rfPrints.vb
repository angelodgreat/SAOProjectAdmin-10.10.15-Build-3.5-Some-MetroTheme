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
    Private Sub FrmAdHome_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class