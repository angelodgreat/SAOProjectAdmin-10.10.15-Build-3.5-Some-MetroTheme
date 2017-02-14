Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportViewer



    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printreport()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub printreport()
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        SDA.SelectCommand = New MySqlCommand("Select date_format(date, '%W, %M %d %Y ')as 'Date',Location, TimeFrom ,TimeTo , Events,School,kpi,noa,remarks from `saoevent" & My.Settings.schoolyear & "`", MysqlConn)
        SDA.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()



    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        Dim Query As String
        Query = "select * from `saoevent" & My.Settings.schoolyear & "` where Date BETWEEN '" & Format(CDate(DateTimePicker1.Value), "yyyy-MM-dd") & "' AND '" & Format(CDate(DateTimePicker2.Value), "yyyy-MM-dd") & "'"


        Command = New MySqlCommand(Query, MysqlConn)



        SDA.SelectCommand = Command
        SDA.Fill(ds.Tables(0))
        'bSource.DataSource = ds
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cb_filterschool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filterschool.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        Dim Query As String
        Query = "select * from `saoevent" & My.Settings.schoolyear & "` where school like '" & cb_filterschool.Text & "'"
        Command = New MySqlCommand(Query, MysqlConn)
        SDA.SelectCommand = Command
        SDA.Fill(ds.Tables(0))
        'bSource.DataSource = ds
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cb_filterschool_TextChanged(sender As Object, e As EventArgs) Handles cb_filterschool.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        Dim Query As String
        Query = "select * from `saoevent" & My.Settings.schoolyear & "` where school like '" & cb_filterschool.Text & "'"
        Command = New MySqlCommand(Query, MysqlConn)
        SDA.SelectCommand = Command
        SDA.Fill(ds.Tables(0))
        'bSource.DataSource = ds
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        SDA.SelectCommand = New MySqlCommand("Select date_format(date, '%W, %M %d %Y ')as 'Date',Location, TimeFrom ,TimeTo , Events,School,kpi,noa,remarks from `saoevent" & My.Settings.schoolyear & "`", MysqlConn)
        SDA.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
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
End Class