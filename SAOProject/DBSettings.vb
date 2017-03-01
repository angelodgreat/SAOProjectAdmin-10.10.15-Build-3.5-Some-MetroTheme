Imports MySql.Data.MySqlClient
Imports MetroFramework
Public Class DBSettings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_setserver.Text = My.Settings.Server
        tb_setDB.Text = My.Settings.Database
        tb_setport.Text = My.Settings.Port
        tb_setusername.Text = My.Settings.SUsername
        tb_setpassword.Text = My.Settings.SPassword


    End Sub

    Public Sub savesettings()
        My.Settings.Server = tb_setserver.Text
        My.Settings.Database = tb_setDB.Text
        My.Settings.Port = tb_setport.Text
        My.Settings.SUsername = tb_setusername.Text
        My.Settings.SPassword = tb_setpassword.Text
        My.Settings.Save()
    End Sub

    Private Sub mb_savesettings_Click(sender As Object, e As EventArgs) Handles mb_savesettings.Click
        savesettings()
        MetroMessageBox.Show(Me, "Settings Saved!", "CEU Students Organization Scheduling Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        savesettings()
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub DBSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        AcceptButton = MetroButton1
    End Sub
End Class