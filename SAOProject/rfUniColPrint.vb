Imports System.Collections.Generic
Imports MySql.Data.MySqlClient
Public Class rfUniColPrint

    Private Sub rfUniColPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection = ConnectToDatabase()
        conn.Open()
        'TODO: This line of code loads data into the 'rfPrint_tbl.studsum' table. You can move, or remove it, as needed.
        Me.studsumTableAdapter.Fill(Me.rfPrint_tbl.studsum)
        Me.ReportViewer2.RefreshReport()
        conn.Close()
        Dim year As Integer = Integer.Parse(Date.Now.Year)
        For year = year + 10 To year Step -1
            LScmbYG.Items.Add(year.ToString())
        Next
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles tilHome.Click
        rfAdminHome.Show()
        Hide()
    End Sub

    Private Sub tilBack_Click(sender As Object, e As EventArgs) Handles tilBack.Click
        rfPrints.Show()
        Hide()
    End Sub

    Private Sub LScmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LScmbFilter.SelectedIndexChanged
        Select Case LScmbFilter.SelectedIndex
            Case 0
                MetroLabel5.Visible = False
                lstStudcmCS.Visible = False
                ReportViewer2.Location = New Point(322, 82)
                ActiveForm.Size = New Size(1121, 673)
                tilHome.Location = New Point(1016, 546)
                tilBack.Location = New Point(935, 546)
                MetroLabel6.Location = New Point(427, 643)

                updateReport()
                Dim year As String = LScmbYG.SelectedItem.ToString()
                Dim query As String = "Select * from studsum where YearGrad = '" & year & "' order by TotalPoints desc"
                Dim adapter As New MySqlDataAdapter
                Dim ds As New rfPrint_tbl
                adapter.SelectCommand = New MySqlCommand(query, ConnectToDatabase())
                adapter.Fill(ds.Tables(10))
                ReportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                ReportViewer2.LocalReport.ReportPath = "C:\Users\Joy\Documents\SAOProject\SAOProject\Report3.rdlc"
                ReportViewer2.LocalReport.DataSources.Clear()
                ReportViewer2.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(10)))
                ReportViewer2.DocumentMapCollapsed = True
                Me.ReportViewer2.RefreshReport()

            Case 1
                MetroLabel5.Visible = True
                lstStudcmCS.Visible = True
                ReportViewer2.Location = New Point(322, 117)
                tilHome.Location = New Point(1016, 581)
                tilBack.Location = New Point(935, 581)
                ActiveForm.Size = New Size(1121, 731)
                MetroLabel6.Location = New Point(426, 697)
        End Select
    End Sub
    Private Sub lstStudcmCS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudcmCS.SelectedIndexChanged
        updateReport()
        Dim year As String = LScmbYG.SelectedItem.ToString()
        Dim mysqlcon As MySqlConnection = ConnectToDatabase()
        Dim query = "SELECT * FROM studsum where College_School = '" & lstStudcmCS.SelectedItem & "' and YearGrad = '" & year & "' order by TotalPoints desc"
        Dim adapter As New MySqlDataAdapter
        Dim ds As New rfPrint_tbl
        adapter.SelectCommand = New MySqlCommand(query, mysqlcon)
        adapter.Fill(ds.Tables(10))
        ReportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer2.LocalReport.ReportPath = "C:\Users\Joy\Documents\SAOProject\SAOProject\Report3.rdlc"
        ReportViewer2.LocalReport.DataSources.Clear()
        ReportViewer2.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(10)))
        ReportViewer2.DocumentMapCollapsed = True
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub updateReport()
        Dim ctr As Integer
        Dim con As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim mysqlcon As MySqlConnection = ConnectToDatabase()
        Dim studNum, studLName, studFname, studMI, college, course, yearGrad, totPoints, remarks As New ArrayList
        mysqlcon.Open()
        Dim query As String = "delete from `ceuratingforms`.`studsum`"
        con = New MySqlCommand(query, mysqlcon)
        con.ExecuteNonQuery()
        mysqlcon.Close()
        mysqlcon.Open()
        query = "SELECT studinfo.StudentNo, studinfo.LName, studinfo.FName, studinfo.MiddleIni, studinfo.College_School, studinfo.Course, studinfo.YearGrad, pointsinfo.TotalPoints, pointsinfo.Remarks
    FROM            pointsinfo INNER JOIN
                             studinfo ON pointsinfo.StudNo = studinfo.StudentNo order by pointsinfo.TotalPoints desc"
        con = New MySqlCommand(query, mysqlcon)
        reader = con.ExecuteReader
        While reader.Read
            studNum.Add(reader.GetString("StudentNo"))
            studLName.Add(reader.GetString("LName"))
            studFname.Add(reader.GetString("FName"))
            studMI.Add(reader.GetString("MiddleIni"))
            college.Add(reader.GetString("College_School"))
            course.Add(reader.GetString("Course"))
            yearGrad.Add(reader.GetString("YearGrad"))
            totPoints.Add(reader.GetString("TotalPoints"))
            remarks.Add(reader.GetString("Remarks"))
        End While
        mysqlcon.Close()


        While ctr < studNum.Count
            mysqlcon.Open()
            query = "INSERT INTO `ceuratingforms`.`studsum` (`StudentNo`, `LName`, `FName`, `MiddleIni`, `College_School`, `Course`, `YearGrad`, `TotalPoints`, `Remarks`) VALUES ('" & studNum.Item(ctr) & "', '" & studLName.Item(ctr) & "', '" & studFname.Item(ctr) & "', '" & studMI.Item(ctr) & "', '" & college.Item(ctr) & "', '" & course.Item(ctr) & "', '" & yearGrad.Item(ctr) & "', '" & totPoints.Item(ctr) & "', '" & remarks.Item(ctr) & "');"
            con = New MySqlCommand(query, mysqlcon)
            con.ExecuteNonQuery()
            mysqlcon.Close()
            ctr += 1
        End While


    End Sub
End Class