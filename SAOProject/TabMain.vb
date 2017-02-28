Imports MySql.Data.MySqlClient
Imports MetroFramework
Imports System.Drawing.Printing
Imports System.IO
Imports System.ComponentModel
Imports System.Text

Public Class TabMain


    'CURRENT ERRORS FOR NOW THAT NEED FIXES . 
    ' - EVENT UPDATE ,  -Account Update
    'NEED TO BE FINISHED or deleted
    ' - CALENDAR CONTROL 

    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim reader As MySqlDataReader

    Private Sub TabMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_userid()
        event_date_load()
        load_kpi()
        load_locs()
        load_orgANDschool()
        btn_deletedata.Visible = False
        btn_update.Visible = False
        GroupBoxEvent.Visible = False

        event_datetimepicker.Value = Date.Now
        tb_input_event.Text = ""

        time_picker_from.SelectedIndex = -1
        time_picker_to.SelectedIndex = -1
        tb_location.SelectedIndex = -1
        cb_noa.SelectedIndex = -1
        cb_kpi.SelectedIndex = -1
        cb_eventschool.SelectedIndex = -1
        cb_remarks.SelectedIndex = -1




        'Timer
        Timer_TabMain.Enabled = True

    End Sub



    Public Sub count_id_event()
        Try
            MysqlConn.Open()

            query = "Select eventid from `saoevent" & My.Settings.schoolyear & "`"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                tb_eventid.Text = reader.Item(0)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub get_userid()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo "
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read
                Dim sID = reader.GetString("id")
                lb_showuser.Items.Add(sID)
            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Public Sub event_date_load()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'EventID' ,date as 'Date',TIME_FORMAT(TimeFrom, '%H:%i') as 'From' ,TIME_FORMAT(TimeTo, '%H:%i') as 'To' , location as 'Location' , events as 'Events',school as'School/Organization',kpi as'KPI',noa as 'Nature of Activity', remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView2.DataSource = bsource
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub btn_submitrecords_Click(sender As Object, e As EventArgs) Handles btn_submitrecords.Click

        'ADDING EVENTS IN CALENDAR EVENT
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim a As Integer
        Try
            mysqlconn.Open()
            Dim query As String

            a = MetroMessageBox.Show(Me, "Are you sure you want to save this selected date?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If a = vbYes Then



                Dim elapsedTime As TimeSpan = DateTime.Parse(Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & time_picker_to.Text).Subtract(DateTime.Parse(DateTime.Parse(Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & time_picker_from.Text)))

            If elapsedTime.CompareTo(TimeSpan.Zero) <= 0 Then
                MessageBox.Show(Me, "The Starting Time can't be the same or later on the Ending Time.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            Else


                ' Original code for detecting time conflict
                ' query = "Select * from saoinfo.saoevent where  TimeFrom='" & Format(CDate(time_picker_from.Value), "hh:mm") & "' and TimeTo ='" & Format(CDate(time_picker_to.Value), "hh:mm") & "'and location='" & tb_location.Text & "'and date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "' "
                ' Modified code for detecting time conflict

                'TO BE EDITTED BECAUSE OF LOCATION PROBLEM

                'query = "select * from saoinfo.saoevent where  ('" & Format(CDate(time_picker_from.Value), "hh:mm") & " " & tb_location.Text & "' BETWEEN concat(' ',timefrom,location) AND concat(' ',timeto,location)) OR (' " & Format(CDate(time_picker_to.Value), "hh:mm") & " " & tb_location.Text & "' BETWEEN concat(' ',timefrom,location) AND concat(' ',timeto,location)) and date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "' "



                'query = "Select * from `saoevent" & My.Settings.schoolyear & "` where (location = '" & tb_location.Text & "') AND (('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_from.Text), "hh:mm:01") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR
                '('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Text), "hh:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)))"

                query = "SELECT * FROM `saoevent" & My.Settings.schoolyear & "` WHERE location=@locs AND ((((@a) BETWEEN CONCAT(date,' ',TimeFrom) AND CONCAT(date,' ',TimeTo)) OR (@b BETWEEN CONCAT(date,' ',TimeFrom) AND CONCAT(date,' ',TimeTo))) OR ((DATE_FORMAT(@a,'%Y-%m-%d %H:%i:%s') <= CONCAT(date,' ',TimeFrom)) AND (DATE_FORMAT(@b,'%Y-%m-%d %H:%i:%s') >= CONCAT(date,' ',TimeTo)) AND CONCAT(date,' ',TimeTo) >= DATE_FORMAT(@a,'%Y-%m-%d %H:%i:%s')))"


                Command = New MySqlCommand(query, MysqlConn)
                Command.Parameters.AddWithValue("locs", tb_location.Text)

                Command.Parameters.AddWithValue("@a", Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_from.Text), "HH:mm:01"))
                Command.Parameters.AddWithValue("@b", Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Text), "HH:mm"))
                reader = Command.ExecuteReader
                Dim count As Integer

                count = 0
                While reader.Read
                    count += 1

                End While

                    'MetroMessageBox.Show(Me, "", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    If count = 1 Then
                        MetroMessageBox.Show(Me, "The time " & Format(CDate(time_picker_from.Text), "hh:mm") & " and " & "the location " & tb_location.Text & " is already occupied.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                    Else
                        If tb_location.Text = "-" Or tb_location.Text = "" Or tb_input_event.Text = "" Or cb_eventschool.Text = "-" Or cb_eventschool.Text = "" Or cb_kpi.Text = "-" Or cb_kpi.Text = "" Or cb_noa.Text = "-" Or cb_noa.Text = "" Then

                            MetroMessageBox.Show(Me, "Please fill all fields", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "insert into `saoevent" & My.Settings.schoolyear & "` (Date,location,events,TimeFrom,TimeTo,school,kpi,noa,remarks) values ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "','" & tb_location.Text & "','" & tb_input_event.Text & "','" & Format(CDate(time_picker_from.Text), "HH:mm") & "','" & Format(CDate(time_picker_to.Text), "HH:mm") & "','" & cb_eventschool.Text & "','" & cb_kpi.Text & "','" & cb_noa.Text & "','" & cb_remarks.Text & "')"
                            Command = New MySqlCommand(query, MysqlConn)
                            reader = Command.ExecuteReader

                            ' load_table2()
                            MetroMessageBox.Show(Me, "Event Submitted", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            event_datetimepicker.Value = Date.Now
                            tb_input_event.Text = ""

                            time_picker_from.SelectedIndex = -1
                            time_picker_to.SelectedIndex = -1
                            tb_location.SelectedIndex = -1
                            cb_noa.SelectedIndex = -1
                            cb_kpi.SelectedIndex = -1
                            cb_eventschool.SelectedIndex = -1
                            cb_remarks.SelectedIndex = -1
                            btn_deletedata.Visible = False
                            btn_update.Visible = False
                            btn_submitrecords.Visible = True
                            MysqlConn.Close()
                            event_date_load()
                            count_id_event()
                        End If
                    End If

                End If
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()


        End Try



    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        'UPDATING EVENTS IN CALENDAR EVENT
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim a As Integer


        If tb_location.Text = "-" Or tb_location.Text = "" Or tb_input_event.Text = "" Or cb_eventschool.Text = "-" Or cb_eventschool.Text = "" Or cb_kpi.Text = "-" Or cb_kpi.Text = "" Or cb_noa.Text = "-" Or cb_noa.Text = "" Then

            MetroMessageBox.Show(Me, "Please fill all fields", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this selected date?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Dim elapsedTime As TimeSpan = DateTime.Parse(Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & time_picker_to.Text).Subtract(DateTime.Parse(DateTime.Parse(Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & time_picker_from.Text)))

                If elapsedTime.CompareTo(TimeSpan.Zero) <= 0 Then
                    MessageBox.Show(Me, "The Starting Time can't be the same or later on the Ending Time.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                Else

                    Try
                        MysqlConn.Open()
                        Dim query As String

                        'query = "select * from saoinfo.saoevent where  ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "  " & Format(CDate(time_picker_from.Value), "hh:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Value), "hh:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto))"

                        query = "select * from `saoevent" & My.Settings.schoolyear & "` where (location = '" & tb_location.Text & "') AND (('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_from.Text), "HH:mm:01") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR
                  ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Text), "HH:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)))"

                        Command = New MySqlCommand(query, MysqlConn)
                        reader = Command.ExecuteReader
                        Dim count As Integer

                        count = 0
                        While reader.Read
                            count += 1

                        End While

                        If count = 1 Then

                            MetroMessageBox.Show(Me, "The time " & Format(CDate(time_picker_from.Text), "hh:mm") & " and " & "the location " & tb_location.Text & " is already occupied.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                        Else
                            If tb_location.Text = "" Or tb_input_event.Text = "" Or tb_eventid.Text = "" Or cb_eventschool.Text = "-" Or cb_kpi.Text = "-" Or cb_noa.Text = "-" Then
                                MetroMessageBox.Show(Me, "Please fill all fields", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MysqlConn.Close()

                                MysqlConn.Open()

                                query = "update `saoevent" & My.Settings.schoolyear & "` set date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "',location='" & tb_location.Text & "',TimeFrom='" & Format(CDate(time_picker_from.Text), "HH:mm") & "',TimeTo='" & Format(CDate(time_picker_to.Text), "HH:mm") & "',Events='" & tb_input_event.Text & "' ,eventid='" & tb_eventid.Text & "' ,school= '" & cb_eventschool.Text & "',
                            kpi='" & cb_kpi.Text & "',noa='" & cb_noa.Text & "',remarks='" & cb_remarks.Text & "'  where eventid='" & tb_eventid.Text & "'"

                                Command = New MySqlCommand(query, MysqlConn)
                                reader = Command.ExecuteReader

                                MetroMessageBox.Show(Me, "Event Updated", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                MysqlConn.Close()
                                event_date_load()
                                event_datetimepicker.Value = Date.Now
                                tb_input_event.Text = ""

                                time_picker_from.SelectedIndex = -1
                                time_picker_to.SelectedIndex = -1
                                tb_location.SelectedIndex = -1
                                cb_noa.SelectedIndex = -1
                                cb_kpi.SelectedIndex = -1
                                cb_eventschool.SelectedIndex = -1
                                cb_remarks.SelectedIndex = -1
                                count_id_event()

                            End If


                        End If



                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)

                    Finally
                        MysqlConn.Dispose()

                    End Try
                End If
            Else


            End If


        End If







    End Sub


    Private Sub btn_deletedata_Click(sender As Object, e As EventArgs) Handles btn_deletedata.Click

        'DELETING EVENTS IN CALENDAR EVENT
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim a As Integer



        If tb_eventid.Text = "" Then
            MetroMessageBox.Show(Me, "No selected date.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to delete the selected date?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then




                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from `saoevent" & My.Settings.schoolyear & "` where eventid='" & tb_eventid.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader


                    MetroMessageBox.Show(Me, "Event Deleted.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MysqlConn.Close()
                    event_date_load()
                    count_id_event()

                    event_datetimepicker.Value = Date.Now
                    tb_input_event.Text = ""
                    time_picker_from.SelectedIndex = -1
                    time_picker_to.SelectedIndex = -1
                    tb_location.SelectedIndex = -1
                    cb_noa.SelectedIndex = -1
                    cb_kpi.SelectedIndex = -1
                    cb_eventschool.SelectedIndex = -1
                    cb_remarks.SelectedIndex = -1
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try



            Else


            End If
        End If

    End Sub


    Private Sub btn_recordsreset_Click(sender As Object, e As EventArgs) Handles btn_recordsreset.Click
        btn_deletedata.Visible = False
        btn_update.Visible = False
        btn_submitrecords.Visible = True


        'RESETTING FIELDS IN CALENDAR EVENT
        event_datetimepicker.Value = Date.Now
        tb_input_event.Text = ""

        time_picker_from.SelectedIndex = -1
        time_picker_to.SelectedIndex = -1
        tb_location.SelectedIndex = -1
        cb_noa.SelectedIndex = -1
        cb_kpi.SelectedIndex = -1
        cb_eventschool.SelectedIndex = -1
        cb_remarks.SelectedIndex = -1





    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        'REGISTERING ACCOUNTS IN REGISTER FORM
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim query As String
            query = "Select * from saoinfo.saouserinfo where id='" & reg_id.Text & "' or UName='" & reg_username.Text & "' "
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count += 1
            End While

            If count = 1 Then

                MetroMessageBox.Show(Me, "The account " & reg_id.Text & " already exist." & "The username " & reg_username.Text & " already exist. ", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            Else
                If ((reg_id.Text = "") Or (reg_cb_college.Text = "-") Or reg_cb_college.Text = "" Or (reg_fname.Text = "") Or (reg_lname.Text = "") Or (reg_username.Text = "") Or (reg_password.Text = "") Or (reg_Retype_password.Text = "") Or (reg_cb_usertype.Text = "-")) Then

                    MetroMessageBox.Show(Me, "Please fill all fields", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else
                    MysqlConn.Close()

                    MysqlConn.Open()
                    query = "insert into saoinfo.saouserinfo (id,college,FName,MName,LName,UName,Password,usertype) values ('" & reg_id.Text & "','" & reg_cb_college.Text & "','" & reg_fname.Text & "','" & reg_mname.Text & "','" & reg_lname.Text & "','" & reg_username.Text & "','" & reg_Retype_password.Text & "','" & reg_cb_usertype.Text & "')"
                    Command = New MySqlCommand(query, MysqlConn)
                    Dim tempuser As String

                    If reg_password.Text <> reg_Retype_password.Text Then
                        MetroMessageBox.Show(Me, "Password do not match", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        reader = Command.ExecuteReader

                        tempuser = lb_showuser.Text
                        lb_showuser.Items.Add(tempuser)

                        MetroMessageBox.Show(Me, "Account Registered!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        MysqlConn.Close()

                    End If
                End If
            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try

    End Sub


    Private Sub btn_delete_records_Click(sender As Object, e As EventArgs) Handles btn_delete_records.Click
        'DELETING ACCOUNTS IN REGISTER FORM
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring



        Dim a As Integer


        If reg_id.Text = "" Then
            MetroMessageBox.Show(Me, "No selected user.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this account?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If a = vbYes Then
                Command = New MySqlCommand
                Dim reader As MySqlDataReader
                Dim tempusername As String

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from saoinfo.saouserinfo where id='" & reg_id.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    tempusername = lb_showuser.Text
                    lb_showuser.Items.Remove(tempusername)

                    reg_cb_college.Text = "-"
                    reg_cb_usertype.Text = "-"
                    reg_id.Text = ""
                    reg_fname.Text = ""
                    reg_mname.Text = ""
                    reg_lname.Text = ""
                    reg_username.Text = ""
                    reg_password.Text = ""
                    reg_Retype_password.Text = ""
                    MetroMessageBox.Show(Me, "Account Deleted!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)




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


    Private Sub btn_reset_records_Click(sender As Object, e As EventArgs) Handles btn_reset_records.Click
        'RESETTING FIELDS IN REGISTER FORM
        cb_userlist_reg.Text = ""
        reg_cb_usertype.Text = "-"
        reg_cb_college.Text = "-"

        reg_id.Text = ""
        reg_fname.Text = ""
        reg_mname.Text = ""
        reg_lname.Text = ""
        reg_username.Text = ""
        reg_id.Enabled = True
        reg_username.Enabled = True
        reg_password.Text = ""
        reg_Retype_password.Text = ""
    End Sub


    Private Sub btn_update_records_Click(sender As Object, e As EventArgs) Handles btn_update_records.Click

        'UPDATING ACCOUNTS IN REGISTER FORM
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader
        Dim a As Integer

        If reg_id.Text = "" And reg_username.Text = "" Then
            MetroMessageBox.Show(Me, "No selected user.", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this account?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Select * from saoinfo.saouserinfo where id='" & reg_id.Text & "' or UName='" & reg_username.Text & "' "
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    Dim count As Integer

                    count = 0
                    While reader.Read
                        count += 1
                    End While

                    If count = 1 Then



                        If ((reg_id.Text = "") Or (reg_cb_college.Text = "-") Or reg_cb_college.Text = "" Or (reg_fname.Text = "") Or (reg_lname.Text = "") Or (reg_username.Text = "") Or (reg_password.Text = "") Or (reg_Retype_password.Text = "") Or (reg_cb_usertype.Text = "-")) Then
                            MetroMessageBox.Show(Me, "Please fill all fields", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "update saoinfo.saouserinfo Set id='" & reg_id.Text & "',college='" & reg_cb_college.Text & "',FName='" & reg_fname.Text & "',MName='" & reg_mname.Text & "',LName='" & reg_lname.Text & "',UName='" & reg_username.Text & "',
                             Password='" & reg_Retype_password.Text & "', usertype='" & reg_cb_usertype.Text & "'
                              where id= '" & reg_id.Text & "' "
                            Command = New MySqlCommand(query, MysqlConn)


                            If reg_password.Text <> reg_Retype_password.Text Then
                                MetroMessageBox.Show(Me, "Password do not match", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                reader = Command.ExecuteReader
                                MetroMessageBox.Show(Me, "Account Updated!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                reg_password.Text = ""
                                reg_Retype_password.Text = ""

                                MysqlConn.Close()
                            End If



                        End If
                    End If


                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

            Else


            End If
        End If
    End Sub

    Private Sub calendar_picker_ValueChanged(sender As Object, e As EventArgs)
        'CALENDAR PICKER IN ADDING EVENTS
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from `saoevent" & My.Settings.schoolyear & "` where date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "'"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read
                tb_input_event.Text = reader.GetString("saoevent")
                tb_location.Text = reader.GetString("location")

            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub cb_userlist_reg_TextChanged(sender As Object, e As EventArgs)
        'Showing TAB USERLIST'
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo where id='" & cb_userlist_reg.Text & "'"
            Command = New MySqlCommand(query, MysqlConn)






            reader = Command.ExecuteReader
            While reader.Read


                reg_id.Text = reader.GetString("id")
                reg_id.Enabled = False
                reg_cb_college.Text = reader.GetString("college")
                reg_fname.Text = reader.GetString("FName")
                reg_mname.Text = reader.GetString("MName")
                reg_lname.Text = reader.GetString("LName")
                reg_username.Text = reader.GetString("UName")
                reg_username.Enabled = False
                reg_cb_usertype.Text = reader.GetString("usertype")

            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub lb_showuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_showuser.SelectedIndexChanged
        'Showing list of users in listbox
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo  where id='" & lb_showuser.Text & "' "
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read

                reg_id.Text = reader.GetString("id")
                reg_id.Enabled = False
                reg_cb_college.Text = reader.GetString("college")
                reg_fname.Text = reader.GetString("FName")
                reg_mname.Text = reader.GetString("MName")
                reg_lname.Text = reader.GetString("LName")
                reg_username.Text = reader.GetString("UName")
                reg_username.Enabled = False
                reg_cb_usertype.Text = reader.GetString("usertype")

            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub



    Private Sub load_schedule_Click(sender As Object, e As EventArgs) Handles load_schedule.Click

        'SHOWING DATA FROM THE TABLE
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub





    Private Sub TabMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'FOR CLOSING CONFIRMATION OF CLOSING THE APP
        Dim dialog As DialogResult
        dialog = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub




    Private Sub Timer_Main_Tick(sender As Object, e As EventArgs) Handles Timer_TabMain.Tick
        'TIME CONTROL

        lbl_showsem.Text = My.Settings.schoolyear
        lbl_time.Text = Date.Now.ToString("MMMM dd yyyy     hh:mm:ss tt")

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'PRINT CONTROL
        Dim dataGridViewImage As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)

        DataGridView1.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(dataGridViewImage, 0, 0)


    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ReportViewer.Show()
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'EXIT CONTROL
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Application.ExitThread()

        Else


        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'LOGOUT CONTROL
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to Log-out?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Me.Dispose()
            login.Show()
        Else
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ReportViewer.Show()

        'PRINT CONTROL
        'DataGridView1.DefaultCellStyle.SelectionBackColor = Color.White
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black
        'DataGridView1.ScrollBars = ScrollBars.None

        'Dim pdlg As Form = DirectCast(PrintPreviewDialog1, Form)
        'Dim origheight As Integer = DataGridView1.Height
        'DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height + 1
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'pdlg.WindowState = FormWindowState.Maximized

        'pdlg.ShowDialog()
        'DataGridView1.Height = origheight
    End Sub



    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TP_Event.Enter

        'SHOWING DATA FROM THE TABLE
        event_date_load()

        count_id_event()




    End Sub



    'REMINDER CONTROL

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TP_Note.Enter
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView3.DataSource = bsource
            SDA.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PrintPreviewDialog1_Deactivate(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Deactivate
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255)
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_searchbydate.Click
        'Dim DV As New DataView(dbdataset)
        'DV.RowFilter = "date >='" & filter_dtp2.Value & "' and date <='" & filter_dtp3.Value & "' "
        'DataGridView1.DataSource = DV

        'SHOWING DATA FROM THE TABLE
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as'School/Organization',kpi as 'KPI',noa as 'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` where Date BETWEEN '" & Format(CDate(filter_dtp2.Value), "yyyy-MM-dd") & "' AND '" & Format(CDate(filter_dtp3.Value), "yyyy-MM-dd") & "'"


            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub cb_filterschool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filterschool.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by date desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("`School/Organization` Like'%{0}%'", cb_filterschool.Text)
        DataGridView1.DataSource = DV

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = connstring
        'Dim SDA As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource
        'Try
        '    MysqlConn.Open()
        '    Dim query As String
        '    query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity' from `saoevent" & My.Settings.schoolyear & "` where school like '" & cb_filterschool.Text & "'"
        '    Command = New MySqlCommand(query, MysqlConn)
        '    SDA.SelectCommand = Command
        '    SDA.Fill(dbdataset)
        '    bsource.DataSource = dbdataset

        '    DataGridView1.DataSource = bsource
        '    SDA.Update(dbdataset)

        '    MysqlConn.Close()

        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Notes.Show()

    End Sub


    'END OF REMINDER CODES


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_home_eventadding.Click

        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to add an event?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            TabControl1.SelectedTab = TP_Event
        Else


        End If

    End Sub

    Private Sub btn_useradding_Click(sender As Object, e As EventArgs) Handles btn_home_useradding.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to add a user?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            TabControl1.SelectedTab = TP_User
        Else
        End If
    End Sub


    Private Sub DataGridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to update the selected note?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            Notes.Show()

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView3.Rows(e.RowIndex)

                Notes.tb_reminder.Text = row.Cells("Note#").Value.ToString
                Notes.dtp_reminder.Text = row.Cells("Date").Value.ToString
                Notes.rtb_reminder.Text = row.Cells("Note").Value.ToString
            End If

        Else


        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        GroupBoxEvent.Visible = True
        btn_deletedata.Visible = True
        btn_update.Visible = True
        btn_submitrecords.Visible = False



        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to change this selected event?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            TabControl1.SelectedTab = TP_Event

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = DataGridView2.Rows(e.RowIndex)

                tb_eventid.Text = row.Cells("EventID").Value.ToString
                time_picker_from.Text = row.Cells("From").Value.ToString
                time_picker_to.Text = row.Cells("To").Value.ToString
                event_datetimepicker.Text = row.Cells("Date").Value.ToString
                tb_location.Text = row.Cells("Location").Value.ToString
                tb_input_event.Text = row.Cells("Events").Value.ToString
                cb_eventschool.Text = row.Cells("School/Organization").Value.ToString
                cb_kpi.Text = row.Cells("KPI").Value.ToString
                cb_noa.Text = row.Cells("Nature of Activity").Value.ToString
                cb_remarks.Text = row.Cells("Remarks").Value.ToString
            End If

        Else


        End If
    End Sub



    Private Sub btn_showeventdetails_Click(sender As Object, e As EventArgs) Handles btn_showeventdetails.Click
        GroupBoxEvent.Visible = True
        btn_deletedata.Visible = False
        btn_update.Visible = False

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        btn_deletedata.Visible = True
        btn_update.Visible = True
        btn_submitrecords.Visible = True
    End Sub

    Private Sub cb_filtersearchlocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filtersearchlocation.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by date desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("location Like'%{0}%'", cb_filtersearchlocation.Text)
        DataGridView1.DataSource = DV

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = connstring
        'Dim SDA As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource
        'Try
        '    MysqlConn.Open()
        '    Dim query As String
        '    query = "select * from `saoevent" & My.Settings.schoolyear & "` where location like '" & filter_searchlocation.Text & "'"
        '    Command = New MySqlCommand(query, MysqlConn)
        '    SDA.SelectCommand = Command
        '    SDA.Fill(dbdataset)
        '    bsource.DataSource = dbdataset

        '    DataGridView1.DataSource = bsource
        '    SDA.Update(dbdataset)

        '    MysqlConn.Close()

        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub cb_filtersearchlocation_TextChanged(sender As Object, e As EventArgs) Handles cb_filtersearchlocation.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by date desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("location Like'%{0}%'", cb_filtersearchlocation.Text)
        DataGridView1.DataSource = DV
    End Sub



    Private Sub cb_filterschool_TextChanged(sender As Object, e As EventArgs) Handles cb_filterschool.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by date desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("`School/Organization` Like'%{0}%'", cb_filterschool.Text)
        DataGridView1.DataSource = DV



    End Sub


    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsForm.Show()
    End Sub

    Public Sub load_kpi()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            cb_kpi.Items.Clear()

            MysqlConn.Open()
            query = "SELECT DISTINCT KPI FROM tbl_kpi ORDER BY KPI ASC"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader


            While reader.Read
                cb_kpi.Items.Add(reader.GetString("KPI"))

            End While
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Public Sub load_orgANDschool()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            cb_eventschool.Items.Clear()
            cb_filterschool.Items.Clear()
            reg_cb_college.Items.Clear()

            MysqlConn.Open()
            query = "SELECT DISTINCT school FROM tbl_organizations_school ORDER BY school ASC"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            While reader.Read
                cb_eventschool.Items.Add(reader.GetString("school"))
                cb_filterschool.Items.Add(reader.GetString("school"))
                reg_cb_college.Items.Add(reader.GetString("school"))

            End While
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Public Sub load_locs()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring


            tb_location.Items.Clear()


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            MysqlConn.Open()
            query = "SELECT DISTINCT Location FROM tbl_locations ORDER BY Location ASC"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            While reader.Read
                tb_location.Items.Add(reader.GetString("Location"))
                cb_filtersearchlocation.Items.Add(reader.GetString("Location"))
            End While
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub RatingFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatingFormToolStripMenuItem.Click
        rfAdminHome.Show()
        Hide()
    End Sub


    Private Sub srmsBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles srmsBackupToolStripMenuItem.Click

        Dim savedb_dialog As New SaveFileDialog
            savedb_dialog.Filter = "mySQL Database|*.sql"
            savedb_dialog.Title = "Choose a Location to Save"
            Dim mysql_SAVE As New MySqlBackup(Command)
            mysql_SAVE.ExportInfo.AddCreateDatabase = True
        mysql_SAVE.ExportInfo.EnableEncryption = True
        mysql_SAVE.ExportInfo.EncryptionPassword = "9Wy3Z3xTApDKUtPVN+TegRLTGR2mj8_M3*3ZJwSts83g9+pL?ZLEn?3xnuMR!2g"

        If savedb_dialog.ShowDialog() = DialogResult.OK Then
                Try
                    MysqlConn.ConnectionString = connstring
                    Dim mysql_LOAD As New MySqlBackup(Command)
                    mysql_LOAD.Command.Connection = MysqlConn
                MysqlConn.Open()



                mysql_SAVE.ExportToFile(savedb_dialog.FileName.ToString)
                    MysqlConn.Close()
                MetroMessageBox.Show(Me, "Database successfully saved!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'RadMessageBox.Show("Error in Importing Database:" & Environment.NewLine & ex.Message, "TLTD Scheduling System", MessageBoxButtons.OK, RadMessageIcon.Error)
            Catch ex As MySqlException
                    If (ex.Number = 0 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Or (ex.Number = 1042 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Then
                    MessageBox.Show(Me, " The database probably went offline.")

                    Return
                    Else
                    MessageBox.Show(Me, ex.Message)
                End If
                Catch ex As Exception
                MessageBox.Show(Me, ex.Message)
            End Try
            End If

            'Dim file As String
        'sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        'sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        'If sfd.ShowDialog = DialogResult.OK Then
        '    file = sfd.FileName
        '    Dim myProcess As New Process()
        '    myProcess.StartInfo.FileName = "cmd.exe"
        '    myProcess.StartInfo.UseShellExecute = False
        '    myProcess.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments & "/saodb/bin")
        '    myProcess.StartInfo.RedirectStandardInput = True
        '    myProcess.StartInfo.RedirectStandardOutput = True
        '    myProcess.Start()
        '    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        '    Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '    myStreamWriter.WriteLine("mysqldump -u " & My.Settings.SUsername & " --password=" & My.Settings.SPassword & " -h " & My.Settings.Server & " """ & My.Settings.Database & """ > """ + file + """ ")
        '    myStreamWriter.Close()
        '    myProcess.WaitForExit()
        '    myProcess.Close()
        '    MetroMessageBox.Show(Me, "Database Backup Created Successfully!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If

    End Sub

    Private Sub srmsRestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles srmsRestoreToolStripMenuItem.Click

        Dim loaddb_dialog As New OpenFileDialog()
        loaddb_dialog.Filter = "mySQL Database|*.sql"
            loaddb_dialog.Title = "Select a File"

        If loaddb_dialog.ShowDialog() = DialogResult.OK Then

            Try
                MysqlConn.ConnectionString = connstring
                Dim mysql_LOAD As New MySqlBackup(Command)
                mysql_LOAD.Command.Connection = MysqlConn
                MysqlConn.Open()
                mysql_LOAD.ImportInfo.EnableEncryption = True
                mysql_LOAD.ImportInfo.EncryptionPassword = "9Wy3Z3xTApDKUtPVN+TegRLTGR2mj8_M3*3ZJwSts83g9+pL?ZLEn?3xnuMR!2g"

                mysql_LOAD.ImportFromFile(loaddb_dialog.FileName.ToString)
                MysqlConn.Close()
                MetroMessageBox.Show(Me, "Database successfully loaded!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                If (ex.Number = 0 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Or (ex.Number = 1042 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Then
                    MessageBox.Show(Me, " The database probably went offline.")

                    Return
                Else
                    MessageBox.Show(Me, ex.Message)
                End If

            End Try

        End If

        'Dim file As String
        'opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        'If opd.ShowDialog = DialogResult.OK Then
        '    file = opd.FileName
        '    Dim myProcess As New Process()
        '    myProcess.StartInfo.FileName = "cmd.exe"
        '    myProcess.StartInfo.UseShellExecute = False
        '    myProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory = Environment.GetEnvironmentVariable("userprofile") & "\Documents\saodb\bin"
        '    myProcess.StartInfo.RedirectStandardInput = True
        '    myProcess.StartInfo.RedirectStandardOutput = True
        '    myProcess.Start()
        '    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        '    Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '    myStreamWriter.WriteLine("mysql -u " & My.Settings.SUsername & " --password=" & My.Settings.SPassword & " -h " & My.Settings.Server & " """ & My.Settings.Database & """ < """ + file + """ ")
        '    myStreamWriter.Close()
        '    myProcess.WaitForExit()
        '    myProcess.Close()
        '    MetroMessageBox.Show(Me, "Database Restored successfully!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub

    Private Sub rfmsBackupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles rfmsBackupToolStripMenuItem1.Click
        Dim savedb_dialog As New SaveFileDialog
        savedb_dialog.Filter = "mySQL Database|*.sql"
        savedb_dialog.Title = "Choose a Location to Save"
        Dim mysql_SAVE As New MySqlBackup(Command)
        mysql_SAVE.ExportInfo.AddCreateDatabase = True
        mysql_SAVE.ExportInfo.EnableEncryption = True
        mysql_SAVE.ExportInfo.EncryptionPassword = "9Wy3Z3xTApDKUtPVN+TegRLTGR2mj8_M3*3ZJwSts83g9+pL?ZLEn?3xnuMR!2g"

        If savedb_dialog.ShowDialog() = DialogResult.OK Then
            Try
                MysqlConn.ConnectionString = remozconnection
                Dim mysql_LOAD As New MySqlBackup(Command)
                mysql_LOAD.Command.Connection = MysqlConn
                MysqlConn.Open()
                mysql_SAVE.ExportToFile(savedb_dialog.FileName.ToString)
                MysqlConn.Close()
                MetroMessageBox.Show(Me, "Database successfully saved!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'RadMessageBox.Show("Error in Importing Database:" & Environment.NewLine & ex.Message, "TLTD Scheduling System", MessageBoxButtons.OK, RadMessageIcon.Error)
            Catch ex As MySqlException
                If (ex.Number = 0 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Or (ex.Number = 1042 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Then
                    MessageBox.Show(Me, " The database probably went offline.")

                    Return
                Else
                    MessageBox.Show(Me, ex.Message)
                End If
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message)
            End Try
        End If

        'Dim file As String
        'Dim remozdb As String = "ceuratingforms"
        'sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        'sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        'If sfd.ShowDialog = DialogResult.OK Then
        '    file = sfd.FileName
        '    Dim myProcess As New Process()
        '    myProcess.StartInfo.FileName = "cmd.exe"
        '    myProcess.StartInfo.UseShellExecute = False
        '    myProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory = Environment.GetEnvironmentVariable("userprofile") & "\Documents\saodb\bin"
        '    myProcess.StartInfo.RedirectStandardInput = True
        '    myProcess.StartInfo.RedirectStandardOutput = True
        '    myProcess.Start()
        '    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        '    Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '    myStreamWriter.WriteLine("mysqldump -u " & My.Settings.SUsername & " --password=" & My.Settings.SPassword & " -h " & My.Settings.Server & " """ & remozdb & """ > """ + file + """ ")
        '    myStreamWriter.Close()
        '    myProcess.WaitForExit()
        '    myProcess.Close()
        '    MetroMessageBox.Show(Me, "Database Backup Created Successfully!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If

        'Process.Start("C:\Program Files\MySQL\MySQL Server 5.7\bin\mysqldump.exe", " -u root -p root saoinfo -r ""C:\Users\Angelo Umali\Desktop\backup.sql""")
    End Sub

    Private Sub rfmsRestoreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles rfmsRestoreToolStripMenuItem1.Click
        Dim loaddb_dialog As New OpenFileDialog()
        loaddb_dialog.Filter = "mySQL Database|*.sql"
        loaddb_dialog.Title = "Select a File"

        If loaddb_dialog.ShowDialog() = DialogResult.OK Then

            Try
                MysqlConn.ConnectionString = remozconnection
                Dim mysql_LOAD As New MySqlBackup(Command)
                mysql_LOAD.Command.Connection = MysqlConn
                MysqlConn.Open()
                mysql_LOAD.ImportInfo.EnableEncryption = True
                mysql_LOAD.ImportInfo.EncryptionPassword = "9Wy3Z3xTApDKUtPVN+TegRLTGR2mj8_M3*3ZJwSts83g9+pL?ZLEn?3xnuMR!2g"
                mysql_LOAD.ImportFromFile(loaddb_dialog.FileName.ToString)
                MysqlConn.Close()
                MetroMessageBox.Show(Me, "Database successfully loaded!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                If (ex.Number = 0 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Or (ex.Number = 1042 And (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts") Or ex.Message.Contains("Reading from the stream has failed"))) Then
                    MessageBox.Show(Me, " The database probably went offline.")

                    Return
                Else
                    MessageBox.Show(Me, ex.Message)
                End If



            End Try

        End If

        'Dim file As String
        'Dim remozdb As String = "ceuratingforms"
        'opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        'If opd.ShowDialog = DialogResult.OK Then
        '    file = opd.FileName
        '    Dim myProcess As New Process()
        '    myProcess.StartInfo.FileName = "cmd.exe"
        '    myProcess.StartInfo.UseShellExecute = False
        '    myProcess.StartInfo.WorkingDirectory = Environment.CurrentDirectory = Environment.GetEnvironmentVariable("userprofile") & "\Documents\saodb\bin"
        '    myProcess.StartInfo.RedirectStandardInput = True
        '    myProcess.StartInfo.RedirectStandardOutput = True
        '    myProcess.Start()
        '    Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        '    Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '    myStreamWriter.WriteLine("mysql -u " & My.Settings.SUsername & " --password=" & My.Settings.SPassword & " -h " & My.Settings.Server & " """ & remozdb & """ < """ + file + """ ")
        '    myStreamWriter.Close()
        '    myProcess.WaitForExit()
        '    myProcess.Close()
        '    MetroMessageBox.Show(Me, "Database Restored successfully!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        ' SHOWING DATA FROM TABLE IN THE SPECIFIC TEXTBOX
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView2.Rows(e.RowIndex)

            tb_eventid.Text = row.Cells("EventID").Value.ToString
            time_picker_from.Text = row.Cells("From").Value.ToString
            time_picker_to.Text = row.Cells("To").Value.ToString
            event_datetimepicker.Text = row.Cells("Date").Value.ToString
            tb_location.Text = row.Cells("Location").Value.ToString
            tb_input_event.Text = row.Cells("Events").Value.ToString
            cb_eventschool.Text = row.Cells("School/Organization").Value.ToString
            cb_kpi.Text = row.Cells("KPI").Value.ToString
            cb_noa.Text = row.Cells("Nature of Activity").Value.ToString
            cb_remarks.Text = row.Cells("Remarks").Value.ToString

            ' tb_input_event.Enabled = False

        End If
    End Sub
End Class