Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.Drawing.Printing
Imports System.IO

Public Class Notes

    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim reader As MySqlDataReader

    Private Sub btn_clear_reminder_Click(sender As Object, e As EventArgs) Handles btn_clear_reminder.Click

        rtb_reminder.Text = ""
        dtp_reminder.Text = ""
    End Sub

    Private Sub btn_delete_reminder_Click(sender As Object, e As EventArgs) Handles btn_delete_reminder.Click

        'DELETING EVENTS IN CALENDAR EVENT
        MysqlConn = ConnectToDatabase()
        Command = New MySqlCommand


        Dim a As Integer

        If tb_reminder.Text = "" Or rtb_reminder.Text = "" Then

            MetroMessageBox.Show(Me, "No Selected Note.", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else


            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this note?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from saoinfo.saoreminder where saonotenumber='" & tb_reminder.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader


                    rtb_reminder.Text = ""
                    dtp_reminder.Text = ""
                    MetroMessageBox.Show(Me, "Note Deleted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MysqlConn.Close()


                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    TabMain.DataGridView3.DataSource = bsource
                    SDA.Update(dbdataset)
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If

        End If
    End Sub

    Private Sub btn_update_reminder_Click(sender As Object, e As EventArgs) Handles btn_update_reminder.Click
        'UPDATING EVENTS IN CALENDAR EVENT
        MysqlConn = ConnectToDatabase()
        Command = New MySqlCommand
        Dim a As Integer


        If tb_reminder.Text = "" Or rtb_reminder.Text = "" Then
            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this note?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String


                    query = "select * from saoinfo.saoreminder where saonotenumber ='" & tb_reminder.Text & "' "

                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    Dim count As Integer

                    count = 0
                    '  While reader.Read
                    'count += 1

                    '  End While

                    If count = 1 Then
                        MsgBox("The Note# " & tb_reminder.Text & " is already in used", MsgBoxStyle.Critical, "Note# Used")


                    Else
                        If tb_reminder.Text = "" Or rtb_reminder.Text = "" Or dtp_reminder.Text = "" Then
                            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "update saoinfo.saoreminder set saoreminderdate='" & Format(CDate(dtp_reminder.Value), "yyyy-MM-dd") & "',saonote ='" & rtb_reminder.Text & "' , saonotenumber='" & tb_reminder.Text & "'
            where saonotenumber='" & tb_reminder.Text & "'"

                            Command = New MySqlCommand(query, MysqlConn)
                            reader = Command.ExecuteReader
                            MetroMessageBox.Show(Me, "Note Updated", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            MysqlConn.Close()

                        End If


                    End If



                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    TabMain.DataGridView3.DataSource = bsource
                    SDA.Update(dbdataset)
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
            End If
        End If
    End Sub

    Private Sub btn_submit_reminder_Click(sender As Object, e As EventArgs) Handles btn_submit_reminder.Click
        'ADDING EVENTS IN CALENDAR EVENT
        MysqlConn = ConnectToDatabase()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from saoinfo.saoreminder where saonotenumber ='" & tb_reminder.Text & "' "


            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count += 1

            End While

            If count = 1 Then
                MsgBox("The Note# " & tb_reminder.Text & " is already in used", MsgBoxStyle.Critical, "Note# Used")

            Else
                If tb_reminder.Text = "" Or rtb_reminder.Text = "" Or dtp_reminder.Text = "" Then
                    MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    MysqlConn.Close()

                    MysqlConn.Open()

                    query = "insert into saoinfo.saoreminder (saonotenumber,saoreminderdate,saonote) values ('" & tb_reminder.Text & "' , '" & Format(CDate(dtp_reminder.Value), "yyyy-MM-dd") & "' ,'" & rtb_reminder.Text & "')"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    MetroMessageBox.Show(Me, "Note Submitted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            TabMain.DataGridView3.DataSource = bsource
            SDA.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()

            query = "Select MAX(saonotenumber) from saoreminder"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                tb_reminder.Text = reader.Item(0) + 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = ConnectToDatabase()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try
            MysqlConn.Open()

            query = "Select count(saonotenumber) from saoreminder"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                tb_reminder.Text = reader.Item(0) + 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Notes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
    End Sub
End Class