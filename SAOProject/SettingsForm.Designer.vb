<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mt_schoolyear = New MetroFramework.Controls.MetroTile()
        Me.grp_loc = New System.Windows.Forms.GroupBox()
        Me.mbtn_clearloc = New MetroFramework.Controls.MetroButton()
        Me.mbtn_clearorg = New MetroFramework.Controls.MetroButton()
        Me.mbtn_deletelocations = New MetroFramework.Controls.MetroButton()
        Me.mbtn_delete = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updatelocations = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updateorganizations = New MetroFramework.Controls.MetroButton()
        Me.mbtn_locationsave = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mg_locations = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mg_organizations = New MetroFramework.Controls.MetroGrid()
        Me.mbtn_saveorganization = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tb_location = New System.Windows.Forms.TextBox()
        Me.tb_organization = New System.Windows.Forms.TextBox()
        Me.grp_kpi = New System.Windows.Forms.GroupBox()
        Me.mbtn_clearkpi = New MetroFramework.Controls.MetroButton()
        Me.mbtn_deletekpi = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updatekpi = New MetroFramework.Controls.MetroButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mg_kpi = New MetroFramework.Controls.MetroGrid()
        Me.mbtn_savekpi = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tb_kpi = New System.Windows.Forms.TextBox()
        Me.ran_org = New System.Windows.Forms.Label()
        Me.ran_loc = New System.Windows.Forms.Label()
        Me.ran_kpi = New System.Windows.Forms.Label()
        Me.grp_mainsettings = New System.Windows.Forms.GroupBox()
        Me.grp_org = New System.Windows.Forms.GroupBox()
        Me.mt_showorg = New MetroFramework.Controls.MetroTile()
        Me.mt_showloc = New MetroFramework.Controls.MetroTile()
        Me.mt_showkpi = New MetroFramework.Controls.MetroTile()
        Me.grp_loc.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_kpi.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_mainsettings.SuspendLayout()
        Me.grp_org.SuspendLayout()
        Me.SuspendLayout()
        '
        'mt_schoolyear
        '
        Me.mt_schoolyear.ActiveControl = Nothing
        Me.mt_schoolyear.Location = New System.Drawing.Point(23, 28)
        Me.mt_schoolyear.Name = "mt_schoolyear"
        Me.mt_schoolyear.Size = New System.Drawing.Size(93, 94)
        Me.mt_schoolyear.TabIndex = 0
        Me.mt_schoolyear.Text = "School Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.mt_schoolyear.UseSelectable = True
        '
        'grp_loc
        '
        Me.grp_loc.Controls.Add(Me.mbtn_clearloc)
        Me.grp_loc.Controls.Add(Me.mbtn_deletelocations)
        Me.grp_loc.Controls.Add(Me.mbtn_updatelocations)
        Me.grp_loc.Controls.Add(Me.mbtn_locationsave)
        Me.grp_loc.Controls.Add(Me.GroupBox4)
        Me.grp_loc.Controls.Add(Me.MetroLabel2)
        Me.grp_loc.Controls.Add(Me.tb_location)
        Me.grp_loc.Location = New System.Drawing.Point(7, 19)
        Me.grp_loc.Name = "grp_loc"
        Me.grp_loc.Size = New System.Drawing.Size(597, 224)
        Me.grp_loc.TabIndex = 1
        Me.grp_loc.TabStop = False
        Me.grp_loc.Text = "&Location"
        '
        'mbtn_clearloc
        '
        Me.mbtn_clearloc.Location = New System.Drawing.Point(167, 185)
        Me.mbtn_clearloc.Name = "mbtn_clearloc"
        Me.mbtn_clearloc.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearloc.TabIndex = 13
        Me.mbtn_clearloc.Text = "Clear"
        Me.mbtn_clearloc.UseSelectable = True
        '
        'mbtn_clearorg
        '
        Me.mbtn_clearorg.Location = New System.Drawing.Point(164, 195)
        Me.mbtn_clearorg.Name = "mbtn_clearorg"
        Me.mbtn_clearorg.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearorg.TabIndex = 12
        Me.mbtn_clearorg.Text = "Clear"
        Me.mbtn_clearorg.UseSelectable = True
        '
        'mbtn_deletelocations
        '
        Me.mbtn_deletelocations.Location = New System.Drawing.Point(248, 185)
        Me.mbtn_deletelocations.Name = "mbtn_deletelocations"
        Me.mbtn_deletelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_deletelocations.TabIndex = 11
        Me.mbtn_deletelocations.Text = "Delete"
        Me.mbtn_deletelocations.UseSelectable = True
        '
        'mbtn_delete
        '
        Me.mbtn_delete.Location = New System.Drawing.Point(245, 195)
        Me.mbtn_delete.Name = "mbtn_delete"
        Me.mbtn_delete.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_delete.TabIndex = 10
        Me.mbtn_delete.Text = "Delete"
        Me.mbtn_delete.UseSelectable = True
        '
        'mbtn_updatelocations
        '
        Me.mbtn_updatelocations.Location = New System.Drawing.Point(329, 185)
        Me.mbtn_updatelocations.Name = "mbtn_updatelocations"
        Me.mbtn_updatelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updatelocations.TabIndex = 9
        Me.mbtn_updatelocations.Text = "Update"
        Me.mbtn_updatelocations.UseSelectable = True
        '
        'mbtn_updateorganizations
        '
        Me.mbtn_updateorganizations.Location = New System.Drawing.Point(326, 195)
        Me.mbtn_updateorganizations.Name = "mbtn_updateorganizations"
        Me.mbtn_updateorganizations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updateorganizations.TabIndex = 8
        Me.mbtn_updateorganizations.Text = "Update"
        Me.mbtn_updateorganizations.UseSelectable = True
        '
        'mbtn_locationsave
        '
        Me.mbtn_locationsave.Location = New System.Drawing.Point(410, 185)
        Me.mbtn_locationsave.Name = "mbtn_locationsave"
        Me.mbtn_locationsave.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_locationsave.TabIndex = 7
        Me.mbtn_locationsave.Text = "Save"
        Me.mbtn_locationsave.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mg_locations)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(581, 136)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'mg_locations
        '
        Me.mg_locations.AllowUserToAddRows = False
        Me.mg_locations.AllowUserToDeleteRows = False
        Me.mg_locations.AllowUserToResizeRows = False
        Me.mg_locations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.mg_locations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_locations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mg_locations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mg_locations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.mg_locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_locations.DefaultCellStyle = DataGridViewCellStyle20
        Me.mg_locations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_locations.EnableHeadersVisualStyles = False
        Me.mg_locations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_locations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_locations.Location = New System.Drawing.Point(3, 16)
        Me.mg_locations.MultiSelect = False
        Me.mg_locations.Name = "mg_locations"
        Me.mg_locations.ReadOnly = True
        Me.mg_locations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.mg_locations.RowHeadersVisible = False
        Me.mg_locations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_locations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_locations.Size = New System.Drawing.Size(575, 117)
        Me.mg_locations.Style = MetroFramework.MetroColorStyle.Orange
        Me.mg_locations.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mg_organizations)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 136)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'mg_organizations
        '
        Me.mg_organizations.AllowUserToAddRows = False
        Me.mg_organizations.AllowUserToDeleteRows = False
        Me.mg_organizations.AllowUserToResizeRows = False
        Me.mg_organizations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.mg_organizations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_organizations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mg_organizations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mg_organizations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.mg_organizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_organizations.DefaultCellStyle = DataGridViewCellStyle23
        Me.mg_organizations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_organizations.EnableHeadersVisualStyles = False
        Me.mg_organizations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_organizations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_organizations.Location = New System.Drawing.Point(3, 16)
        Me.mg_organizations.MultiSelect = False
        Me.mg_organizations.Name = "mg_organizations"
        Me.mg_organizations.ReadOnly = True
        Me.mg_organizations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.mg_organizations.RowHeadersVisible = False
        Me.mg_organizations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_organizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_organizations.Size = New System.Drawing.Size(575, 117)
        Me.mg_organizations.Style = MetroFramework.MetroColorStyle.Green
        Me.mg_organizations.TabIndex = 0
        '
        'mbtn_saveorganization
        '
        Me.mbtn_saveorganization.Location = New System.Drawing.Point(407, 195)
        Me.mbtn_saveorganization.Name = "mbtn_saveorganization"
        Me.mbtn_saveorganization.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_saveorganization.TabIndex = 4
        Me.mbtn_saveorganization.Text = "Save"
        Me.mbtn_saveorganization.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(100, 159)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Location:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(70, 170)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Organization:"
        '
        'tb_location
        '
        Me.tb_location.Location = New System.Drawing.Point(167, 158)
        Me.tb_location.Name = "tb_location"
        Me.tb_location.Size = New System.Drawing.Size(318, 20)
        Me.tb_location.TabIndex = 1
        '
        'tb_organization
        '
        Me.tb_organization.Location = New System.Drawing.Point(164, 169)
        Me.tb_organization.Name = "tb_organization"
        Me.tb_organization.Size = New System.Drawing.Size(318, 20)
        Me.tb_organization.TabIndex = 0
        '
        'grp_kpi
        '
        Me.grp_kpi.Controls.Add(Me.mbtn_clearkpi)
        Me.grp_kpi.Controls.Add(Me.mbtn_deletekpi)
        Me.grp_kpi.Controls.Add(Me.mbtn_updatekpi)
        Me.grp_kpi.Controls.Add(Me.GroupBox5)
        Me.grp_kpi.Controls.Add(Me.mbtn_savekpi)
        Me.grp_kpi.Controls.Add(Me.MetroLabel3)
        Me.grp_kpi.Controls.Add(Me.tb_kpi)
        Me.grp_kpi.Location = New System.Drawing.Point(7, 19)
        Me.grp_kpi.Name = "grp_kpi"
        Me.grp_kpi.Size = New System.Drawing.Size(597, 224)
        Me.grp_kpi.TabIndex = 2
        Me.grp_kpi.TabStop = False
        Me.grp_kpi.Text = "&KPI"
        '
        'mbtn_clearkpi
        '
        Me.mbtn_clearkpi.Location = New System.Drawing.Point(167, 187)
        Me.mbtn_clearkpi.Name = "mbtn_clearkpi"
        Me.mbtn_clearkpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearkpi.TabIndex = 14
        Me.mbtn_clearkpi.Text = "Clear"
        Me.mbtn_clearkpi.UseSelectable = True
        '
        'mbtn_deletekpi
        '
        Me.mbtn_deletekpi.Location = New System.Drawing.Point(248, 187)
        Me.mbtn_deletekpi.Name = "mbtn_deletekpi"
        Me.mbtn_deletekpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_deletekpi.TabIndex = 13
        Me.mbtn_deletekpi.Text = "Delete"
        Me.mbtn_deletekpi.UseSelectable = True
        '
        'mbtn_updatekpi
        '
        Me.mbtn_updatekpi.Location = New System.Drawing.Point(329, 187)
        Me.mbtn_updatekpi.Name = "mbtn_updatekpi"
        Me.mbtn_updatekpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updatekpi.TabIndex = 12
        Me.mbtn_updatekpi.Text = "Update"
        Me.mbtn_updatekpi.UseSelectable = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.mg_kpi)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(581, 136)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'mg_kpi
        '
        Me.mg_kpi.AllowUserToAddRows = False
        Me.mg_kpi.AllowUserToDeleteRows = False
        Me.mg_kpi.AllowUserToResizeRows = False
        Me.mg_kpi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.mg_kpi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_kpi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mg_kpi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mg_kpi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.mg_kpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_kpi.DefaultCellStyle = DataGridViewCellStyle26
        Me.mg_kpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_kpi.EnableHeadersVisualStyles = False
        Me.mg_kpi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_kpi.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_kpi.Location = New System.Drawing.Point(3, 16)
        Me.mg_kpi.MultiSelect = False
        Me.mg_kpi.Name = "mg_kpi"
        Me.mg_kpi.ReadOnly = True
        Me.mg_kpi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.mg_kpi.RowHeadersVisible = False
        Me.mg_kpi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_kpi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_kpi.Size = New System.Drawing.Size(575, 117)
        Me.mg_kpi.Style = MetroFramework.MetroColorStyle.Red
        Me.mg_kpi.TabIndex = 0
        '
        'mbtn_savekpi
        '
        Me.mbtn_savekpi.Location = New System.Drawing.Point(410, 187)
        Me.mbtn_savekpi.Name = "mbtn_savekpi"
        Me.mbtn_savekpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_savekpi.TabIndex = 8
        Me.mbtn_savekpi.Text = "Save"
        Me.mbtn_savekpi.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(131, 161)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "KPI:"
        '
        'tb_kpi
        '
        Me.tb_kpi.Location = New System.Drawing.Point(167, 161)
        Me.tb_kpi.Name = "tb_kpi"
        Me.tb_kpi.Size = New System.Drawing.Size(318, 20)
        Me.tb_kpi.TabIndex = 6
        '
        'ran_org
        '
        Me.ran_org.AutoSize = True
        Me.ran_org.Location = New System.Drawing.Point(623, 9)
        Me.ran_org.Name = "ran_org"
        Me.ran_org.Size = New System.Drawing.Size(39, 13)
        Me.ran_org.TabIndex = 3
        Me.ran_org.Text = "Label1"
        Me.ran_org.Visible = False
        '
        'ran_loc
        '
        Me.ran_loc.AutoSize = True
        Me.ran_loc.Location = New System.Drawing.Point(623, 30)
        Me.ran_loc.Name = "ran_loc"
        Me.ran_loc.Size = New System.Drawing.Size(39, 13)
        Me.ran_loc.TabIndex = 4
        Me.ran_loc.Text = "Label2"
        Me.ran_loc.Visible = False
        '
        'ran_kpi
        '
        Me.ran_kpi.AutoSize = True
        Me.ran_kpi.Location = New System.Drawing.Point(623, 52)
        Me.ran_kpi.Name = "ran_kpi"
        Me.ran_kpi.Size = New System.Drawing.Size(39, 13)
        Me.ran_kpi.TabIndex = 5
        Me.ran_kpi.Text = "Label3"
        Me.ran_kpi.Visible = False
        '
        'grp_mainsettings
        '
        Me.grp_mainsettings.Controls.Add(Me.grp_org)
        Me.grp_mainsettings.Controls.Add(Me.grp_kpi)
        Me.grp_mainsettings.Controls.Add(Me.grp_loc)
        Me.grp_mainsettings.Location = New System.Drawing.Point(41, 131)
        Me.grp_mainsettings.Name = "grp_mainsettings"
        Me.grp_mainsettings.Size = New System.Drawing.Size(610, 249)
        Me.grp_mainsettings.TabIndex = 6
        Me.grp_mainsettings.TabStop = False
        Me.grp_mainsettings.Text = "&Settings"
        '
        'grp_org
        '
        Me.grp_org.Controls.Add(Me.GroupBox3)
        Me.grp_org.Controls.Add(Me.mbtn_clearorg)
        Me.grp_org.Controls.Add(Me.tb_organization)
        Me.grp_org.Controls.Add(Me.MetroLabel1)
        Me.grp_org.Controls.Add(Me.mbtn_delete)
        Me.grp_org.Controls.Add(Me.mbtn_saveorganization)
        Me.grp_org.Controls.Add(Me.mbtn_updateorganizations)
        Me.grp_org.Location = New System.Drawing.Point(6, 19)
        Me.grp_org.Name = "grp_org"
        Me.grp_org.Size = New System.Drawing.Size(597, 224)
        Me.grp_org.TabIndex = 0
        Me.grp_org.TabStop = False
        Me.grp_org.Text = "&Organizations"
        '
        'mt_showorg
        '
        Me.mt_showorg.ActiveControl = Nothing
        Me.mt_showorg.Location = New System.Drawing.Point(122, 28)
        Me.mt_showorg.Name = "mt_showorg"
        Me.mt_showorg.Size = New System.Drawing.Size(93, 94)
        Me.mt_showorg.TabIndex = 7
        Me.mt_showorg.Text = "Organization"
        Me.mt_showorg.UseSelectable = True
        '
        'mt_showloc
        '
        Me.mt_showloc.ActiveControl = Nothing
        Me.mt_showloc.Location = New System.Drawing.Point(221, 28)
        Me.mt_showloc.Name = "mt_showloc"
        Me.mt_showloc.Size = New System.Drawing.Size(93, 94)
        Me.mt_showloc.TabIndex = 8
        Me.mt_showloc.Text = "Location"
        Me.mt_showloc.UseSelectable = True
        '
        'mt_showkpi
        '
        Me.mt_showkpi.ActiveControl = Nothing
        Me.mt_showkpi.Location = New System.Drawing.Point(320, 28)
        Me.mt_showkpi.Name = "mt_showkpi"
        Me.mt_showkpi.Size = New System.Drawing.Size(93, 94)
        Me.mt_showkpi.TabIndex = 9
        Me.mt_showkpi.Text = "KPI"
        Me.mt_showkpi.UseSelectable = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 403)
        Me.Controls.Add(Me.mt_showkpi)
        Me.Controls.Add(Me.mt_showloc)
        Me.Controls.Add(Me.mt_showorg)
        Me.Controls.Add(Me.grp_mainsettings)
        Me.Controls.Add(Me.ran_kpi)
        Me.Controls.Add(Me.ran_loc)
        Me.Controls.Add(Me.ran_org)
        Me.Controls.Add(Me.mt_schoolyear)
        Me.Name = "SettingsForm"
        Me.Text = " "
        Me.grp_loc.ResumeLayout(False)
        Me.grp_loc.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_kpi.ResumeLayout(False)
        Me.grp_kpi.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_mainsettings.ResumeLayout(False)
        Me.grp_org.ResumeLayout(False)
        Me.grp_org.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mt_schoolyear As MetroFramework.Controls.MetroTile
    Friend WithEvents grp_loc As GroupBox
    Friend WithEvents grp_kpi As GroupBox
    Friend WithEvents mbtn_deletelocations As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_delete As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updatelocations As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updateorganizations As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_locationsave As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents mg_locations As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mg_organizations As MetroFramework.Controls.MetroGrid
    Friend WithEvents mbtn_saveorganization As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_location As TextBox
    Friend WithEvents tb_organization As TextBox
    Friend WithEvents mbtn_deletekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updatekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents mg_kpi As MetroFramework.Controls.MetroGrid
    Friend WithEvents mbtn_savekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_kpi As TextBox
    Friend WithEvents mbtn_clearloc As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_clearorg As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_clearkpi As MetroFramework.Controls.MetroButton
    Friend WithEvents ran_org As Label
    Friend WithEvents ran_loc As Label
    Friend WithEvents ran_kpi As Label
    Friend WithEvents grp_mainsettings As GroupBox
    Friend WithEvents grp_org As GroupBox
    Friend WithEvents mt_showorg As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_showloc As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_showkpi As MetroFramework.Controls.MetroTile
End Class
