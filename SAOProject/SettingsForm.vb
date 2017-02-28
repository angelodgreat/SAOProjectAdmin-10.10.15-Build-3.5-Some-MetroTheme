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
        loadpoints()

        mb_functionchoice.Items.Add("KPI")
        mb_functionchoice.Items.Add("Location")
        mb_functionchoice.Items.Add("School and Organization")

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

    Private Sub mbtn_saveorganization_Click(sender As Object, e As EventArgs) Handles mbtn_saveorganization.Click
        Try
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = connstring

            If (MysqlConn.State = ConnectionState.Open) Then
                MysqlConn.Close()
            End If

            If (tb_organization.Text = "") Then
                MetroMessageBox.Show(Me, "Please fill the fields", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else


                question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
                        MetroMessageBox.Show(Me, "The School/Organization " & tb_organization.Text & " is already registered.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else
                        MysqlConn.Close()
                        MysqlConn.Open()
                        query = "INSERT INTO tbl_organizations_school VALUES (@school,@orgid)"
                        Command = New MySqlCommand(query, MysqlConn)
                        Command.Parameters.AddWithValue("school", tb_organization.Text)
                        Command.Parameters.AddWithValue("orgid", ran_org.Text)
                        reader = Command.ExecuteReader

                        MetroMessageBox.Show(Me, "Successfully Saved!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MetroMessageBox.Show(Me, "Please fill the fields", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_organizations_school SET school=@school WHERE orgid=@orgid "
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("school", tb_organization.Text)
                    Command.Parameters.AddWithValue("orgid", ran_org.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MetroMessageBox.Show(Me, "Please choose from the table.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_organizations_school WHERE school=@school AND orgid=@orgid"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("school", tb_organization.Text)
                    Command.Parameters.AddWithValue("orgid", ran_org.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
                    MetroMessageBox.Show(Me, "The Location " & tb_location.Text & " is already registered.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MysqlConn.Close()
                    MysqlConn.Open()
                    query = "INSERT INTO tbl_locations VALUES (@location,@loc_id)"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Saved!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                MetroMessageBox.Show(Me, "Please fill the fields", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_locations SET Location=@location WHERE loc_id=@loc_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MetroMessageBox.Show(Me, "Please choose from the table.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_locations WHERE Location=@location AND loc_id=@loc_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("location", tb_location.Text)
                    Command.Parameters.AddWithValue("loc_id", ran_loc.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
                    MetroMessageBox.Show(Me, "The KPI " & tb_kpi.Text & " is already registered.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MysqlConn.Close()
                    MysqlConn.Open()
                    query = "INSERT INTO tbl_kpi VALUES (@kpi,@kpi_id)"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Saved!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                MetroMessageBox.Show(Me, "Please fill the fields", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to update this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "UPDATE tbl_kpi SET kpi=@kpi WHERE kpi_id=@kpi_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Updated!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                MetroMessageBox.Show(Me, "Please choose from the table.", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                question = MetroMessageBox.Show(Me, "Are you sure you want to delete this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If (question = DialogResult.Yes) Then


                    MysqlConn.Open()
                    query = "DELETE FROM tbl_kpi WHERE kpi=@kpi AND kpi_id=@kpi_id"
                    Command = New MySqlCommand(query, MysqlConn)
                    Command.Parameters.AddWithValue("kpi", tb_kpi.Text)
                    Command.Parameters.AddWithValue("kpi_id", ran_kpi.Text)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Successfully Deleted!", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Hide()
    End Sub


    Private Sub mt_schoolyear_Click(sender As Object, e As EventArgs) Handles mt_schoolyear.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to change the School Year?", "CEU Student Organization Record And Rating Forms Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = vbYes Then
            ChangeSemester.Show()
            ChangeSemester.cb_selectyearndsem.Text = My.Settings.schoolyear
        Else

            Exit Sub
        End If
    End Sub

    Private Sub mb_functionchoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mb_functionchoice.SelectedIndexChanged
        If mb_functionchoice.SelectedItem = "KPI" Then
            grp_kpi.Show()
            grp_loc.Hide()
            grp_org.Hide()

        ElseIf mb_functionchoice.SelectedItem = "Location" Then
            grp_loc.Show()
            grp_kpi.Hide()
            grp_org.Hide()
        ElseIf mb_functionchoice.SelectedItem = "School and Organization" Then
            grp_org.Show()
            grp_loc.Hide()
            grp_kpi.Hide()

        End If

    End Sub
    Private Sub loadpoints()
        Dim ct As Integer
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Gold'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim geld = RetrieveQuery(query, 1)
            rfstxtminGold.Text = geld(0)(0).ToString
        End If
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Silver'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim sil = RetrieveQuery(query, 1)
            rfstxtminSilver.Text = sil(0)(0).ToString
        End If
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Bronze'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim bro = RetrieveQuery(query, 1)
            rfstxtminBronze.Text = bro(0)(0).ToString
        End If

    End Sub

    Private Sub rfsBtnEdit_Click(sender As Object, e As EventArgs) Handles rfsBtnEditSave.Click
        rfstxtminGold.Enabled = True
        rfstxtminSilver.Enabled = True
        rfstxtminBronze.Enabled = True
        rfsBtnEditSave.Visible = False
        rfsBtnSave.Visible = True
        rfsBtnEditSave.Visible = False
    End Sub

    Private Sub rfsBtnSave_Click(sender As Object, e As EventArgs) Handles rfsBtnSave.Click
        rfstxtminBronze.Enabled = False
        rfstxtminGold.Enabled = False
        rfstxtminSilver.Enabled = False
        rfsBtnEditSave.Visible = True
        rfsBtnSave.Visible = False


        If String.IsNullOrEmpty(rfstxtminGold.Text) Then
            tipErrors.Show("Please enter the minimum point.", rfstxtminGold)
            rfstxtminGold.Select()
        ElseIf String.IsNullOrEmpty(rfstxtminSilver.Text) Then
            tipErrors.Show("Please enter the minimum point.", rfstxtminSilver)
            rfstxtminSilver.Select()
        ElseIf String.IsNullOrEmpty(rfstxtminSilver.Text) Then
            tipErrors.Show("Please enter the minimum point.", rfstxtminBronze)
            rfstxtminBronze.Select()
        Else
            Dim goldp As Integer = Val(rfstxtminGold.Text)
            Dim silp As Integer = Val(rfstxtminSilver.Text)
            Dim brop As Integer = Val(rfstxtminBronze.Text)

            question = MetroMessageBox.Show(Me, "Are you sure you want to save this?", "CEU Student Organization Record and Rating Forms Management System ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If question = vbYes Then
                query = "UPDATE ceuratingforms.points_ranges SET minPoint = '" & goldp & "' WHERE award = 'Gold'; "
                ExecuteQuery(query)

                query = "UPDATE ceuratingforms.points_ranges SET minPoint = '" & silp & "' WHERE award = 'Silver'; "
                ExecuteQuery(query)

                query = "UPDATE ceuratingforms.points_ranges SET minPoint = '" & brop & "' WHERE award = 'Bronze'; "
                ExecuteQuery(query)

                MetroMessageBox.Show(Me, "Changes were saved successfully!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK)

                UpdatePointsInfo()
            Else
                MetroMessageBox.Show(Me, "Changes were not saved!", "CEU Student Organization Record and Rating Forms Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If
    End Sub

    Private Sub UpdatePointsInfo()
        query = "SELECT award, minPoint FROM ceuratingforms.points_ranges"

        If Count(query, 2) <> 0 Then
            Dim minPoints As ArrayList = RetrieveQuery(query, 2)
            Dim batchQuery As ArrayList = New ArrayList

            query = "SELECT StudNo, TotalPoints FROM ceuratingforms.pointsinfo"

            If Count(query, 2) Then
                Dim allPoints As ArrayList = RetrieveQuery(query, 2)

                For Each points As ArrayList In allPoints
                    Dim studNo As String = points(0).ToString
                    Dim point As Integer = Integer.Parse(points(1).ToString)
                    Dim remarks As String = String.Empty

                    Dim minGold = minPoints(0)(1)
                    Dim minSilver = minPoints(1)(1)
                    Dim minBronze = minPoints(2)(1)

                    If point >= minGold Then
                        remarks = minPoints(0)(0)
                    ElseIf point >= minSilver Then
                        remarks = minPoints(1)(0)
                    ElseIf point >= minBronze Then
                        remarks = minPoints(2)(0)
                    End If

                    batchQuery.Add("UPDATE pointsinfo SET remarks = '" & remarks & "' WHERE StudNo = '" & studNo & "'")
                Next
            End If

            If batchQuery.Count() > 0 Then
                For Each query In batchQuery
                    ExecuteQuery(query)
                Next
            End If
        End If
    End Sub

    Private Sub rfsBtnCancel_Click(sender As Object, e As EventArgs) Handles rfsBtnCancel.Click
        loadpoints()
        rfstxtminGold.Enabled = False
        rfstxtminSilver.Enabled = False
        rfstxtminBronze.Enabled = False
        rfsBtnEditSave.Visible = True
        rfsBtnSave.Visible = False
    End Sub


End Class