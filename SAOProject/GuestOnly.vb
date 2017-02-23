Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework


Public Class GuestOnly
    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim reader As MySqlDataReader

    Private Sub GuestOnly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1_guest.Enabled = True
        load_locs()
        load_orgANDschool()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
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
    End Sub

    Private Sub GuestOnly_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to Log-out?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            Me.Dispose()
            Login.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to Log-out?", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            Me.Dispose()
            Login.Show()
        Else


        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub



    Private Sub btn_searchbydate_Click(sender As Object, e As EventArgs) Handles btn_searchbydate.Click
        'Dim DV As New DataView(dbdataset)
        'DV.RowFilter = "date >='" & filter_dtp2.Value & "' and date <='" & filter_dtp3.Value & "' "
        'DataGridView1.DataSource = DV

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
        '    query = "select * from `saoevent" & My.Settings.schoolyear & "` where school like '" & cb_filterschool.Text & "'"
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





    Private Sub Timer1_guest_Tick(sender As Object, e As EventArgs) Handles Timer1_guest.Tick
        lbl_time.Text = Date.Now.ToString("MMMM dd yyyy     hh:mm:ss tt")

    End Sub

    Private Sub load_schedule_Click(sender As Object, e As EventArgs) Handles load_schedule.Click
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
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filterlocation.SelectedIndexChanged
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
        DV.RowFilter = String.Format("location Like'%{0}%'", cb_filterlocation.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cb_filterlocation.TextChanged
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
        DV.RowFilter = String.Format("location Like'%{0}%'", cb_filterlocation.Text)
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

    Public Sub load_orgANDschool()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring


            cb_filterschool.Items.Clear()


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            MysqlConn.Open()
            query = "SELECT DISTINCT school FROM tbl_organizations_school ORDER BY school ASC"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader


            cb_filterschool.Items.Clear()


            While reader.Read

                cb_filterschool.Items.Add(reader.GetString("school"))
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


            cb_filterlocation.Items.Clear()


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            MysqlConn.Open()
            query = "SELECT DISTINCT Location FROM tbl_locations ORDER BY Location ASC"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader


            cb_filterlocation.Items.Clear()


            While reader.Read
                cb_filterlocation.Items.Add(reader.GetString("Location"))
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class