Imports MetroFramework
Imports MySql.Data.MySqlClient

Public Class SettingsForm

    Dim question As DialogResult



    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_organizations()
        load_location()
    End Sub

    Private Sub mt_schoolyear_Click(sender As Object, e As EventArgs) Handles mt_schoolyear.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to change the School Year?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            ChangeSemester.Show()
            ChangeSemester.cb_selectyearndsem.Text = My.Settings.schoolyear
        Else

            Exit Sub
        End If
    End Sub

    Private Sub mbtn_saveorganization_Click(sender As Object, e As EventArgs) Handles mbtn_saveorganization.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If (MysqlConn.State = ConnectionState.Open) Then
                MysqlConn.Close()
            End If

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (question = DialogResult.Yes) Then



                MysqlConn.Open()

                query = "SELECT * FROM tbl_organizations_school WHERE school=@school"
                Command = New MySqlCommand(query, MysqlConn)
                Command.Parameters.AddWithValue("school", tb_organization.Text)
                reader = Command.ExecuteReader

                Dim count As Integer
                count = 0

                While reader.Read
                    count += 1

                End While

                If count >= 1 Then
                    MetroMessageBox.Show(Me, "The School/Organization " & tb_organization.Text & " is already registered.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If (tb_organization.Text = "") Then
                        MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MysqlConn.Close()
                        MysqlConn.Open()
                        query = "INSERT INTO tbl_organizations_school VALUES (@school)"
                        Command = New MySqlCommand(query, MysqlConn)
                        Command.Parameters.AddWithValue("school", tb_organization.Text)
                        reader = Command.ExecuteReader

                        MetroMessageBox.Show(Me, "Successfully Saved!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_organizations()
        End Try

    End Sub

    Public Sub load_organizations()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            Dim SDA As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Dim dbdataset As New DataTable

            MysqlConn.Open()
            query = "SELECT school as 'School/Organization' FROM tbl_organizations_school"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            mg_organizations.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub load_location()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            Dim SDA As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Dim dbdataset As New DataTable

            MysqlConn.Open()
            query = "SELECT location as Location/s FROM tbl_locations"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            mg_locations.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub mbtn_locationsave_Click(sender As Object, e As EventArgs) Handles mbtn_locationsave.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If (MysqlConn.State = ConnectionState.Open) Then
                MysqlConn.Close()
            End If

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (question = DialogResult.Yes) Then

                MysqlConn.Open()

                query = "SELECT * FROM tbl_locations WHERE Location=@location"
                Command = New MySqlCommand(query, MysqlConn)
                Command.Parameters.AddWithValue("location", tb_location.Text)
                reader = Command.ExecuteReader

                Dim count As Integer
                count = 0

                While reader.Read
                    count += 1

                End While

                If count >= 1 Then
                    MetroMessageBox.Show(Me, "The Location " & tb_location.Text & " is already registered.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If (tb_location.Text = "") Then
                        MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MysqlConn.Close()
                        MysqlConn.Open()
                        query = "INSERT INTO tbl_locations VALUES (@location)"
                        Command = New MySqlCommand(query, MysqlConn)
                        Command.Parameters.AddWithValue("location", tb_location.Text)
                        reader = Command.ExecuteReader

                        MetroMessageBox.Show(Me, "Successfully Saved!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_location()
        End Try
    End Sub
End Class