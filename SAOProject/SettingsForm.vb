Imports MetroFramework
Imports MySql.Data.MySqlClient

Public Class SettingsForm

    Dim question As DialogResult

    Public identifier_rankpi As String
    Public identifier_ranorg As String
    Public identifier_ranloc As String
    Public random As System.Random = New System.Random



    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_organizations()
        load_location()
        load_kpi()
        auto_generate_id()
    End Sub
    Public Sub auto_generate_id()
        identifier_rankpi = Now.ToString("mmddyyy" + "-")
        identifier_rankpi = identifier_rankpi + random.Next(1, 100000).ToString

        identifier_ranloc = Now.ToString("mmddyyy" + "-")
        identifier_ranloc = identifier_ranloc + random.Next(1, 100000).ToString

        identifier_ranorg = Now.ToString("mmddyyy" + "-")
        identifier_ranorg = identifier_ranorg + random.Next(1, 100000).ToString

        ran_kpi.Text = identifier_rankpi
        ran_loc.Text = identifier_ranloc
        ran_org.Text = identifier_ranorg
    End Sub

    Public Sub load_organizations()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            Dim SDA As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Dim dbdataset As New DataTable

            MysqlConn.Open()
            query = "SELECT orgid as 'ID',school as 'School/Organization' FROM tbl_organizations_school"
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

            Dim columndrugname = mg_organizations.Columns(0)
            columndrugname.Width = 100
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
            query = "SELECT loc_id as 'ID',location as 'Location/s' FROM tbl_locations"
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

            Dim columndrugname = mg_locations.Columns(0)
            columndrugname.Width = 100
        End Try
    End Sub

    Public Sub load_kpi()
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            Dim SDA As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Dim dbdataset As New DataTable

            MysqlConn.Open()
            query = "SELECT kpi_id as 'ID',kpi as 'KPI' FROM tbl_kpi"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            mg_kpi.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

            Dim columndrugname = mg_kpi.Columns(0)
            columndrugname.Width = 100
        End Try
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

            If (tb_organization.Text = "") Then
                MetroMessageBox.Show(Me, "Please fill the fields", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else


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
                        MysqlConn.Close()
                        MysqlConn.Open()
                        query = "INSERT INTO tbl_organizations_school VALUES (@school,@orgid)"
                        Command = New MySqlCommand(query, MysqlConn)
                        Command.Parameters.AddWithValue("school", tb_organization.Text)
                        Command.Parameters.AddWithValue("orgid", ran_org.Text)
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
            auto_generate_id()
        End Try

    End Sub

    Private Sub mbtn_updateorganizations_Click(sender As Object, e As EventArgs) Handles mbtn_updateorganizations.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            If (tb_organization.Text = "") Then
                MetroMessageBox.Show(Me, "Please fill the fields", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_organizations_school SET school=@school WHERE orgid=@orgid "
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("school", tb_organization.Text)
                    Command.Parameters.AddWithValue("orgid", ran_org.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            auto_generate_id()
            load_organizations()
        End Try
    End Sub

    Private Sub mbtn_delete_Click(sender As Object, e As EventArgs) Handles mbtn_delete.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If


            If (tb_organization.Text = "") Then
                MetroMessageBox.Show(Me, "Please choose from the table.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_organizations_school WHERE school=@school AND orgid=@orgid"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("school", tb_organization.Text)
                    Command.Parameters.AddWithValue("orgid", ran_org.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            tb_organization.Clear()
            auto_generate_id()
            load_organizations()
        End Try
    End Sub
    Private Sub mbtn_clearorg_Click(sender As Object, e As EventArgs) Handles mbtn_clearorg.Click
        tb_organization.Clear()
        auto_generate_id()
    End Sub
    Private Sub mg_organizations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mg_organizations.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.mg_organizations.Rows(e.RowIndex)

            tb_organization.Text = row.Cells("School/Organization").Value.ToString
            ran_org.Text = row.Cells("ID").Value.ToString
        End If
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

                    MysqlConn.Close()
                    MysqlConn.Open()
                    query = "INSERT INTO tbl_locations VALUES (@location,@loc_id)"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Saved!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_location()
            auto_generate_id()
        End Try
    End Sub

    Private Sub mbtn_updatelocations_Click(sender As Object, e As EventArgs) Handles mbtn_updatelocations.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If


            If (tb_location.Text = "") Then
                MetroMessageBox.Show(Me, "Please fill the fields", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_locations SET Location=@location WHERE loc_id=@loc_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_location()
            auto_generate_id()
        End Try
    End Sub

    Private Sub mbtn_deletelocations_Click(sender As Object, e As EventArgs) Handles mbtn_deletelocations.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If


            If (tb_location.Text = "") Then
                MetroMessageBox.Show(Me, "Please choose from the table.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_locations WHERE Location=@location AND loc_id=@loc_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            tb_location.Clear()
            auto_generate_id()
            load_location()
        End Try
    End Sub

    Private Sub mbtn_clearloc_Click(sender As Object, e As EventArgs) Handles mbtn_clearloc.Click
        auto_generate_id()
        tb_location.Clear()
    End Sub

    Private Sub mg_locations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mg_locations.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.mg_locations.Rows(e.RowIndex)

            tb_location.Text = row.Cells("Location/s").Value.ToString
            ran_loc.Text = row.Cells("ID").Value.ToString
        End If
    End Sub

    Private Sub mbtn_savekpi_Click(sender As Object, e As EventArgs) Handles mbtn_savekpi.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If (MysqlConn.State = ConnectionState.Open) Then
                MysqlConn.Close()
            End If

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (question = DialogResult.Yes) Then

                MysqlConn.Open()

                query = "SELECT * FROM tbl_kpi WHERE kpi=@kpi"
                Command = New MySqlCommand(query, MysqlConn)
                Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                reader = Command.ExecuteReader

                Dim count As Integer
                count = 0

                While reader.Read
                    count += 1

                End While

                If count >= 1 Then
                    MetroMessageBox.Show(Me, "The KPI " & tb_kpi.Text & " is already registered.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MysqlConn.Close()
                    MysqlConn.Open()
                    query = "INSERT INTO tbl_kpi VALUES (@kpi,@kpi_id)"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Saved!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_kpi()
            auto_generate_id()
        End Try
    End Sub

    Private Sub mbtn_updatekpi_Click(sender As Object, e As EventArgs) Handles mbtn_updatekpi.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If


            If (tb_kpi.Text = "") Then
                MetroMessageBox.Show(Me, "Please fill the fields", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_kpi SET kpi=@kpi WHERE kpi_id=@kpi_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            load_kpi()
            auto_generate_id()
        End Try
    End Sub

    Private Sub mbtn_deletekpi_Click(sender As Object, e As EventArgs) Handles mbtn_deletekpi.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If


            If (tb_kpi.Text = "") Then
                MetroMessageBox.Show(Me, "Please choose from the table.", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_kpi WHERE kpi=@kpi AND kpi_id=@kpi_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "Students Affairs Office Consolidated Calendar ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            tb_kpi.Clear()
            auto_generate_id()
            load_kpi()
        End Try
    End Sub

    Private Sub mbtn_clearkpi_Click(sender As Object, e As EventArgs) Handles mbtn_clearkpi.Click
        auto_generate_id()
        tb_kpi.Clear()
    End Sub

    Private Sub mg_kpi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mg_kpi.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.mg_kpi.Rows(e.RowIndex)

            tb_kpi.Text = row.Cells("KPI").Value.ToString
            ran_kpi.Text = row.Cells("ID").Value.ToString
        End If
    End Sub

    Private Sub SettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Private Sub mt_showkpi_Click(sender As Object, e As EventArgs) Handles mt_showkpi.Click
        grp_kpi.Show()
        grp_loc.Hide()
        grp_org.Hide()
    End Sub

    Private Sub mt_showloc_Click(sender As Object, e As EventArgs) Handles mt_showloc.Click
        grp_loc.Show()
        grp_kpi.Hide()
        grp_org.Hide()
    End Sub

    Private Sub mt_showorg_Click(sender As Object, e As EventArgs) Handles mt_showorg.Click
        grp_org.Show()
        grp_loc.Hide()
        grp_kpi.Hide()
    End Sub
End Class