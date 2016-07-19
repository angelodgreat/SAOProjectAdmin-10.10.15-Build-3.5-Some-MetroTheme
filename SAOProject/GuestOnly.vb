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

        a = MetroMessageBox.Show(Me, "Are you sure you want to Log-out?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            Me.Dispose()
            Login.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to Log-out?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
        lbl_showsem.Text = My.Settings.schoolyear
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to change the School Year?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Question)


        If a = vbYes Then
            ChangeSemester.Show()
            ChangeSemester.cb_selectyearndsem.Text = My.Settings.schoolyear
        Else

            Exit Sub
        End If
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
End Class