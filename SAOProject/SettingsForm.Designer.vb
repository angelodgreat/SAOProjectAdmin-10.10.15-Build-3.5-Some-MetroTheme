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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mt_schoolyear = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mbtn_deletekpi = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updatekpi = New MetroFramework.Controls.MetroButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mg_kpi = New MetroFramework.Controls.MetroGrid()
        Me.mbtn_savekpi = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mbtn_deletelocations)
        Me.GroupBox1.Controls.Add(Me.mbtn_delete)
        Me.GroupBox1.Controls.Add(Me.mbtn_updatelocations)
        Me.GroupBox1.Controls.Add(Me.mbtn_updateorganizations)
        Me.GroupBox1.Controls.Add(Me.mbtn_locationsave)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.mbtn_saveorganization)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.tb_location)
        Me.GroupBox1.Controls.Add(Me.tb_organization)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 471)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Settings"
        '
        'mbtn_deletelocations
        '
        Me.mbtn_deletelocations.Location = New System.Drawing.Point(248, 395)
        Me.mbtn_deletelocations.Name = "mbtn_deletelocations"
        Me.mbtn_deletelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_deletelocations.TabIndex = 11
        Me.mbtn_deletelocations.Text = "Delete"
        Me.mbtn_deletelocations.UseSelectable = True
        '
        'mbtn_delete
        '
        Me.mbtn_delete.Location = New System.Drawing.Point(248, 187)
        Me.mbtn_delete.Name = "mbtn_delete"
        Me.mbtn_delete.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_delete.TabIndex = 10
        Me.mbtn_delete.Text = "Delete"
        Me.mbtn_delete.UseSelectable = True
        '
        'mbtn_updatelocations
        '
        Me.mbtn_updatelocations.Location = New System.Drawing.Point(329, 395)
        Me.mbtn_updatelocations.Name = "mbtn_updatelocations"
        Me.mbtn_updatelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updatelocations.TabIndex = 9
        Me.mbtn_updatelocations.Text = "Update"
        Me.mbtn_updatelocations.UseSelectable = True
        '
        'mbtn_updateorganizations
        '
        Me.mbtn_updateorganizations.Location = New System.Drawing.Point(329, 187)
        Me.mbtn_updateorganizations.Name = "mbtn_updateorganizations"
        Me.mbtn_updateorganizations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updateorganizations.TabIndex = 8
        Me.mbtn_updateorganizations.Text = "Update"
        Me.mbtn_updateorganizations.UseSelectable = True
        '
        'mbtn_locationsave
        '
        Me.mbtn_locationsave.Location = New System.Drawing.Point(410, 395)
        Me.mbtn_locationsave.Name = "mbtn_locationsave"
        Me.mbtn_locationsave.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_locationsave.TabIndex = 7
        Me.mbtn_locationsave.Text = "Save"
        Me.mbtn_locationsave.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mg_locations)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(581, 136)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "&Locations"
        '
        'mg_locations
        '
        Me.mg_locations.AllowUserToAddRows = False
        Me.mg_locations.AllowUserToDeleteRows = False
        Me.mg_locations.AllowUserToResizeRows = False
        Me.mg_locations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_locations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mg_locations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mg_locations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mg_locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_locations.DefaultCellStyle = DataGridViewCellStyle2
        Me.mg_locations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_locations.EnableHeadersVisualStyles = False
        Me.mg_locations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_locations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_locations.Location = New System.Drawing.Point(3, 16)
        Me.mg_locations.Name = "mg_locations"
        Me.mg_locations.ReadOnly = True
        Me.mg_locations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mg_locations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_locations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_locations.Size = New System.Drawing.Size(575, 117)
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
        Me.GroupBox3.Text = "&Organizations"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.mg_organizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_organizations.DefaultCellStyle = DataGridViewCellStyle5
        Me.mg_organizations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_organizations.EnableHeadersVisualStyles = False
        Me.mg_organizations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_organizations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_organizations.Location = New System.Drawing.Point(3, 16)
        Me.mg_organizations.Name = "mg_organizations"
        Me.mg_organizations.ReadOnly = True
        Me.mg_organizations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.mg_organizations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_organizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_organizations.Size = New System.Drawing.Size(575, 117)
        Me.mg_organizations.TabIndex = 0
        '
        'mbtn_saveorganization
        '
        Me.mbtn_saveorganization.Location = New System.Drawing.Point(410, 187)
        Me.mbtn_saveorganization.Name = "mbtn_saveorganization"
        Me.mbtn_saveorganization.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_saveorganization.TabIndex = 4
        Me.mbtn_saveorganization.Text = "Save"
        Me.mbtn_saveorganization.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(108, 369)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Location:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(81, 162)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Organization:"
        '
        'tb_location
        '
        Me.tb_location.Location = New System.Drawing.Point(175, 368)
        Me.tb_location.Name = "tb_location"
        Me.tb_location.Size = New System.Drawing.Size(310, 20)
        Me.tb_location.TabIndex = 1
        '
        'tb_organization
        '
        Me.tb_organization.Location = New System.Drawing.Point(175, 161)
        Me.tb_organization.Name = "tb_organization"
        Me.tb_organization.Size = New System.Drawing.Size(310, 20)
        Me.tb_organization.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mbtn_deletekpi)
        Me.GroupBox2.Controls.Add(Me.mbtn_updatekpi)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.mbtn_savekpi)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(622, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 230)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Settings"
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
        Me.GroupBox5.Text = "&KPI"
        '
        'mg_kpi
        '
        Me.mg_kpi.AllowUserToAddRows = False
        Me.mg_kpi.AllowUserToDeleteRows = False
        Me.mg_kpi.AllowUserToResizeRows = False
        Me.mg_kpi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_kpi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mg_kpi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mg_kpi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.mg_kpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_kpi.DefaultCellStyle = DataGridViewCellStyle8
        Me.mg_kpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_kpi.EnableHeadersVisualStyles = False
        Me.mg_kpi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_kpi.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_kpi.Location = New System.Drawing.Point(3, 16)
        Me.mg_kpi.Name = "mg_kpi"
        Me.mg_kpi.ReadOnly = True
        Me.mg_kpi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.mg_kpi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_kpi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_kpi.Size = New System.Drawing.Size(575, 117)
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
        Me.MetroLabel3.Location = New System.Drawing.Point(139, 162)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "KPI:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(175, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(310, 20)
        Me.TextBox3.TabIndex = 6
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 610)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mt_schoolyear)
        Me.Name = "SettingsForm"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mt_schoolyear As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents TextBox3 As TextBox
End Class
