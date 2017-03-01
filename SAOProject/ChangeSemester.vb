Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.Drawing.Printing
Imports System.IO
Public Class ChangeSemester




    Private Sub btn_createSCYS_Click(sender As Object, e As EventArgs) Handles btn_createSCYS.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim tablename As String = cb_selectyearndsem.Text

        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            query = "CREATE TABLE `saoevent" & tablename & "` LIKE saoevent"
            ' for copying all
            ' query = "CREATE TABLE `saoevent" & tablename & "` LIKE saoevent; INSERT into `saoevent" & tablename & "` SELECT * FROM saoevent;"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            MetroMessageBox.Show(Me, "School Year successfully created", "CEU Students Organization Scheduling Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub btn_loadSCYS_Click(sender As Object, e As EventArgs) Handles btn_loadSCYS.Click
        My.Settings.schoolyear = cb_selectyearndsem.Text
        MetroMessageBox.Show(Me, "School Year successfully loaded", "CEU Students Organization Scheduling Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'SHOWING DATA FROM THE TABLE
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            TabMain.DataGridView1.DataSource = bsource
            GuestOnly.DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub btn_deleteSCYS_Click(sender As Object, e As EventArgs) Handles btn_deleteSCYS.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim tablename As String = cb_selectyearndsem.Text


        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to delete this School Year?", "CEU Students Organization Scheduling Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If a = vbYes Then
            Command = New MySqlCommand
            Dim reader As MySqlDataReader

            Try
                MysqlConn.Open()
                query = "Drop table `saoevent" & cb_selectyearndsem.Text & "`"

                Command = New MySqlCommand(query, MysqlConn)
                reader = Command.ExecuteReader

                MetroMessageBox.Show(Me, "School Year successfully deleted.", "CEU Students Organization Scheduling Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)


                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        Else

            Exit Sub
        End If

    End Sub

    Private Sub ChangeSemester_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
    End Sub


End Class