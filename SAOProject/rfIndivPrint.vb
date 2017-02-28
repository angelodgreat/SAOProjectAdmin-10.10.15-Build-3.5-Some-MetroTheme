Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class rfIndivPrint
    Dim selectedNamee As String
    Private Sub rfIndivPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'rfPrints_tbl.allrf' table. You can move, or remove it, as needed.
        'Me.allrfTableAdapter.Fill(Me.rfPrints_tbl.allrf)
        Dim con As MySqlConnection = ConnectToDatabase()
        con.Open()
        'TODO: This line of code loads data into the 'rfPrint_tbl.allrf' table. You can move, or remove it, as needed.
        'Me.allrfTableAdapter.Fill(Me.rfPrints_tbl.allrf)
        populateStudentNames()
        Me.ReportViewer1.RefreshReport()
        con.Close()

    End Sub
    Private Sub populateStudentNames()
        Try
            cmb_studentNames.Items.Clear()
            Dim conn As MySqlConnection = ConnectToDatabase()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.studinfo"
            cmd.ExecuteNonQuery()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                cmb_studentNames.Items.Add(reader.GetString(1) & ", " & reader.GetString(2))
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_studentNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_studentNames.SelectedIndexChanged
        selectedNamee = cmb_studentNames.SelectedItem
        selectedName(selectedNamee)
    End Sub
    Private Sub selectedName(ByVal str As String)

        Dim lname As String = ""
        Dim fname As String = ""
        Dim studID As String = ""
        Dim query As String = ""
        Dim totalPoint As String = ""
        Dim award As String = ""
        Dim ctr, ctr2 As Integer
        Dim actTitle, point, weight, incPoints, totPoints As New ArrayList
        While ctr < str.Length
            If str.Chars(ctr) = "," Then
                ctr2 = ctr + 2
                While ctr2 < str.Length
                    fname &= str.Chars(ctr2)
                    ctr2 += 1
                End While
                Exit While
            End If
            lname &= str.Chars(ctr)
            ctr += 1
        End While


        Try
            Dim conn As MySqlConnection = ConnectToDatabase()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.studsum where LName ='" & lname & "' and FName = '" & fname & "'"
            cmd.ExecuteNonQuery()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                studID = reader.GetString(0)
            End If
            reader.Close()
            conn.Close()


            conn.Open()
            Dim com As MySqlCommand = New MySqlCommand()
            com.Connection = conn
            com.CommandText = "Select TotalPoints, Remarks from ceuratingforms.pointsinfo where StudNo = '" & studID & "'"
            com.ExecuteNonQuery()
            Dim readers As MySqlDataReader = com.ExecuteReader
            If readers.Read Then
                totalPoint = readers.GetString(0)
                award = readers.GetString(1)
            End If
            readers.Close()
            conn.Close()


            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM `ceuratingforms`.`allrf`"
            cmd.ExecuteNonQuery()
            conn.Close()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform1 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(2))
                point.Add(reader.GetString(6))
                weight.Add(reader.GetString(7))
                totPoints.Add(reader.GetString(8))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform2 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(2))
                point.Add(reader.GetString(7))
                weight.Add(reader.GetString(8))
                totPoints.Add(reader.GetString(9))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform3 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(2))
                point.Add(reader.GetString(7))
                weight.Add(reader.GetString(8))
                totPoints.Add(reader.GetString(9))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform4 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(2))
                point.Add(reader.GetString(6))
                weight.Add(reader.GetString(7))
                totPoints.Add(reader.GetString(8))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform5 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(2))
                point.Add(reader.GetString(10))
                weight.Add(5)
                totPoints.Add(reader.GetString(11))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform6 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(11))
                point.Add(reader.GetString(12))
                weight.Add(reader.GetString(13))
                totPoints.Add(reader.GetString(14))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While

            actTitle.Clear()
            point.Clear()
            weight.Clear()
            totPoints.Clear()

            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM ceuratingforms.ratingform7 where StudentNo = '" & studID & "' and appr = 1"
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader()
            While reader.Read
                actTitle.Add(reader.GetString(9))
                point.Add(reader.GetString(10))
                weight.Add(reader.GetString(11))
                incPoints.Add(reader.GetString(12))
                totPoints.Add(reader.GetString(13))
            End While
            reader.Close()
            conn.Close()

            ctr = 0
            While ctr < point.Count
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO `ceuratingforms`.`allrf` (`activity_title`, `point`, `weight`,`incp`, `total_point`) VALUES ('" & actTitle.Item(ctr) & "', '" & point.Item(ctr) & "', '" & weight.Item(ctr) & "','" & incPoints.Item(ctr) & "', '" & totPoints.Item(ctr) & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                ctr += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim par1 As New ReportParameter("studID", studID)
        Dim par2 As New ReportParameter("studName", selectedNamee)
        Dim par3 As New ReportParameter("StudTP", totalPoint)
        Dim par4 As New ReportParameter("studAward", award)
        Dim mysqlcon As MySqlConnection = ConnectToDatabase()
        query = "SELECT * FROM ceuratingforms.allrf;"
        Dim adapter As New MySqlDataAdapter
        Dim ds As New rfPrints_tbl
        adapter.SelectCommand = New MySqlCommand(query, mysqlcon)
        adapter.Fill(ds.Tables(0))
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report3.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.LocalReport.SetParameters(par1)
        ReportViewer1.LocalReport.SetParameters(par2)
        ReportViewer1.LocalReport.SetParameters(par3)
        ReportViewer1.LocalReport.SetParameters(par4)
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub tilHome_Click(sender As Object, e As EventArgs) Handles tilHome.Click
        Dim nextForm As New rfAdminHome()
        nextForm.Show()
        Hide()
    End Sub

    Private Sub tilBack_Click(sender As Object, e As EventArgs) Handles tilBack.Click
        Dim nextForm As New rfPrints()
        nextForm.Show()
        Hide()
    End Sub
End Class