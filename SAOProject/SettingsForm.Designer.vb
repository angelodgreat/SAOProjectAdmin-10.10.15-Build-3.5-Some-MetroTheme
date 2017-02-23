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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.ran_org = New System.Windows.Forms.Label()
        Me.ran_loc = New System.Windows.Forms.Label()
        Me.ran_kpi = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mb_functionchoice = New MetroFramework.Controls.MetroComboBox()
        Me.grp_mainsettings = New System.Windows.Forms.GroupBox()
        Me.grp_kpi = New System.Windows.Forms.GroupBox()
        Me.mbtn_clearkpi = New MetroFramework.Controls.MetroButton()
        Me.mbtn_deletekpi = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updatekpi = New MetroFramework.Controls.MetroButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mg_kpi = New MetroFramework.Controls.MetroGrid()
        Me.mbtn_savekpi = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tb_kpi = New System.Windows.Forms.TextBox()
        Me.grp_org = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mg_organizations = New MetroFramework.Controls.MetroGrid()
        Me.mbtn_clearorg = New MetroFramework.Controls.MetroButton()
        Me.tb_organization = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mbtn_delete = New MetroFramework.Controls.MetroButton()
        Me.mbtn_saveorganization = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updateorganizations = New MetroFramework.Controls.MetroButton()
        Me.grp_loc = New System.Windows.Forms.GroupBox()
        Me.mbtn_clearloc = New MetroFramework.Controls.MetroButton()
        Me.mbtn_deletelocations = New MetroFramework.Controls.MetroButton()
        Me.mbtn_updatelocations = New MetroFramework.Controls.MetroButton()
        Me.mbtn_locationsave = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mg_locations = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tb_location = New System.Windows.Forms.TextBox()
        Me.mt_schoolyear = New MetroFramework.Controls.MetroTile()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rfPointSettings = New System.Windows.Forms.GroupBox()
        Me.rfsBtnCancel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.rfsBtnSave = New MetroFramework.Controls.MetroButton()
        Me.rfsBtnEditSave = New MetroFramework.Controls.MetroButton()
        Me.tipErrors = New MetroFramework.Components.MetroToolTip()
        Me.rfstxtminGold = New MetroFramework.Controls.MetroTextBox()
        Me.rfstxtminSilver = New MetroFramework.Controls.MetroTextBox()
        Me.rfstxtminBronze = New MetroFramework.Controls.MetroTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grp_mainsettings.SuspendLayout()
        Me.grp_kpi.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_org.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_loc.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.rfPointSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ran_org
        '
        Me.ran_org.AutoSize = True
        Me.ran_org.Location = New System.Drawing.Point(562, 15)
        Me.ran_org.Name = "ran_org"
        Me.ran_org.Size = New System.Drawing.Size(39, 13)
        Me.ran_org.TabIndex = 3
        Me.ran_org.Text = "Label1"
        Me.ran_org.Visible = False
        '
        'ran_loc
        '
        Me.ran_loc.AutoSize = True
        Me.ran_loc.Location = New System.Drawing.Point(652, 15)
        Me.ran_loc.Name = "ran_loc"
        Me.ran_loc.Size = New System.Drawing.Size(39, 13)
        Me.ran_loc.TabIndex = 4
        Me.ran_loc.Text = "Label2"
        Me.ran_loc.Visible = False
        '
        'ran_kpi
        '
        Me.ran_kpi.AutoSize = True
        Me.ran_kpi.Location = New System.Drawing.Point(607, 15)
        Me.ran_kpi.Name = "ran_kpi"
        Me.ran_kpi.Size = New System.Drawing.Size(39, 13)
        Me.ran_kpi.TabIndex = 5
        Me.ran_kpi.Text = "Label3"
        Me.ran_kpi.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(20, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(686, 415)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroLabel4)
        Me.TabPage1.Controls.Add(Me.mb_functionchoice)
        Me.TabPage1.Controls.Add(Me.grp_mainsettings)
        Me.TabPage1.Controls.Add(Me.mt_schoolyear)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(678, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Organization Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(319, 46)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel4.TabIndex = 16
        Me.MetroLabel4.Text = "Settings for:"
        '
        'mb_functionchoice
        '
        Me.mb_functionchoice.FormattingEnabled = True
        Me.mb_functionchoice.ItemHeight = 23
        Me.mb_functionchoice.Location = New System.Drawing.Point(404, 36)
        Me.mb_functionchoice.Name = "mb_functionchoice"
        Me.mb_functionchoice.Size = New System.Drawing.Size(263, 29)
        Me.mb_functionchoice.TabIndex = 15
        Me.mb_functionchoice.UseSelectable = True
        '
        'grp_mainsettings
        '
        Me.grp_mainsettings.Controls.Add(Me.grp_kpi)
        Me.grp_mainsettings.Controls.Add(Me.grp_org)
        Me.grp_mainsettings.Controls.Add(Me.grp_loc)
        Me.grp_mainsettings.Location = New System.Drawing.Point(28, 97)
        Me.grp_mainsettings.Name = "grp_mainsettings"
        Me.grp_mainsettings.Size = New System.Drawing.Size(639, 260)
        Me.grp_mainsettings.TabIndex = 11
        Me.grp_mainsettings.TabStop = False
        Me.grp_mainsettings.Text = "&Settings"
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
        Me.grp_kpi.Location = New System.Drawing.Point(23, 19)
        Me.grp_kpi.Name = "grp_kpi"
        Me.grp_kpi.Size = New System.Drawing.Size(597, 224)
        Me.grp_kpi.TabIndex = 2
        Me.grp_kpi.TabStop = False
        Me.grp_kpi.Text = "&KPI"
        '
        'mbtn_clearkpi
        '
        Me.mbtn_clearkpi.Location = New System.Drawing.Point(159, 187)
        Me.mbtn_clearkpi.Name = "mbtn_clearkpi"
        Me.mbtn_clearkpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearkpi.TabIndex = 14
        Me.mbtn_clearkpi.Text = "Clear"
        Me.mbtn_clearkpi.UseSelectable = True
        '
        'mbtn_deletekpi
        '
        Me.mbtn_deletekpi.Location = New System.Drawing.Point(240, 187)
        Me.mbtn_deletekpi.Name = "mbtn_deletekpi"
        Me.mbtn_deletekpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_deletekpi.TabIndex = 13
        Me.mbtn_deletekpi.Text = "Delete"
        Me.mbtn_deletekpi.UseSelectable = True
        '
        'mbtn_updatekpi
        '
        Me.mbtn_updatekpi.Location = New System.Drawing.Point(321, 187)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mg_kpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_kpi.DefaultCellStyle = DataGridViewCellStyle2
        Me.mg_kpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_kpi.EnableHeadersVisualStyles = False
        Me.mg_kpi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_kpi.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_kpi.Location = New System.Drawing.Point(3, 16)
        Me.mg_kpi.MultiSelect = False
        Me.mg_kpi.Name = "mg_kpi"
        Me.mg_kpi.ReadOnly = True
        Me.mg_kpi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_kpi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mg_kpi.RowHeadersVisible = False
        Me.mg_kpi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_kpi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_kpi.Size = New System.Drawing.Size(575, 117)
        Me.mg_kpi.Style = MetroFramework.MetroColorStyle.Red
        Me.mg_kpi.TabIndex = 0
        '
        'mbtn_savekpi
        '
        Me.mbtn_savekpi.Location = New System.Drawing.Point(402, 187)
        Me.mbtn_savekpi.Name = "mbtn_savekpi"
        Me.mbtn_savekpi.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_savekpi.TabIndex = 8
        Me.mbtn_savekpi.Text = "Save"
        Me.mbtn_savekpi.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(123, 162)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "KPI:"
        '
        'tb_kpi
        '
        Me.tb_kpi.Location = New System.Drawing.Point(159, 161)
        Me.tb_kpi.Name = "tb_kpi"
        Me.tb_kpi.Size = New System.Drawing.Size(318, 20)
        Me.tb_kpi.TabIndex = 6
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
        Me.grp_org.Location = New System.Drawing.Point(23, 19)
        Me.grp_org.Name = "grp_org"
        Me.grp_org.Size = New System.Drawing.Size(597, 224)
        Me.grp_org.TabIndex = 0
        Me.grp_org.TabStop = False
        Me.grp_org.Text = "&Organizations"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.mg_organizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_organizations.DefaultCellStyle = DataGridViewCellStyle5
        Me.mg_organizations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_organizations.EnableHeadersVisualStyles = False
        Me.mg_organizations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_organizations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_organizations.Location = New System.Drawing.Point(3, 16)
        Me.mg_organizations.MultiSelect = False
        Me.mg_organizations.Name = "mg_organizations"
        Me.mg_organizations.ReadOnly = True
        Me.mg_organizations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_organizations.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.mg_organizations.RowHeadersVisible = False
        Me.mg_organizations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_organizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_organizations.Size = New System.Drawing.Size(575, 117)
        Me.mg_organizations.Style = MetroFramework.MetroColorStyle.Green
        Me.mg_organizations.TabIndex = 0
        '
        'mbtn_clearorg
        '
        Me.mbtn_clearorg.Location = New System.Drawing.Point(159, 187)
        Me.mbtn_clearorg.Name = "mbtn_clearorg"
        Me.mbtn_clearorg.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearorg.TabIndex = 12
        Me.mbtn_clearorg.Text = "Clear"
        Me.mbtn_clearorg.UseSelectable = True
        '
        'tb_organization
        '
        Me.tb_organization.Location = New System.Drawing.Point(159, 161)
        Me.tb_organization.Name = "tb_organization"
        Me.tb_organization.Size = New System.Drawing.Size(318, 20)
        Me.tb_organization.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(65, 162)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Organization:"
        '
        'mbtn_delete
        '
        Me.mbtn_delete.Location = New System.Drawing.Point(240, 187)
        Me.mbtn_delete.Name = "mbtn_delete"
        Me.mbtn_delete.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_delete.TabIndex = 10
        Me.mbtn_delete.Text = "Delete"
        Me.mbtn_delete.UseSelectable = True
        '
        'mbtn_saveorganization
        '
        Me.mbtn_saveorganization.Location = New System.Drawing.Point(402, 187)
        Me.mbtn_saveorganization.Name = "mbtn_saveorganization"
        Me.mbtn_saveorganization.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_saveorganization.TabIndex = 4
        Me.mbtn_saveorganization.Text = "Save"
        Me.mbtn_saveorganization.UseSelectable = True
        '
        'mbtn_updateorganizations
        '
        Me.mbtn_updateorganizations.Location = New System.Drawing.Point(321, 187)
        Me.mbtn_updateorganizations.Name = "mbtn_updateorganizations"
        Me.mbtn_updateorganizations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updateorganizations.TabIndex = 8
        Me.mbtn_updateorganizations.Text = "Update"
        Me.mbtn_updateorganizations.UseSelectable = True
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
        Me.grp_loc.Location = New System.Drawing.Point(23, 19)
        Me.grp_loc.Name = "grp_loc"
        Me.grp_loc.Size = New System.Drawing.Size(597, 224)
        Me.grp_loc.TabIndex = 1
        Me.grp_loc.TabStop = False
        Me.grp_loc.Text = "&Location"
        '
        'mbtn_clearloc
        '
        Me.mbtn_clearloc.Location = New System.Drawing.Point(159, 187)
        Me.mbtn_clearloc.Name = "mbtn_clearloc"
        Me.mbtn_clearloc.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clearloc.TabIndex = 13
        Me.mbtn_clearloc.Text = "Clear"
        Me.mbtn_clearloc.UseSelectable = True
        '
        'mbtn_deletelocations
        '
        Me.mbtn_deletelocations.Location = New System.Drawing.Point(240, 187)
        Me.mbtn_deletelocations.Name = "mbtn_deletelocations"
        Me.mbtn_deletelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_deletelocations.TabIndex = 11
        Me.mbtn_deletelocations.Text = "Delete"
        Me.mbtn_deletelocations.UseSelectable = True
        '
        'mbtn_updatelocations
        '
        Me.mbtn_updatelocations.Location = New System.Drawing.Point(321, 187)
        Me.mbtn_updatelocations.Name = "mbtn_updatelocations"
        Me.mbtn_updatelocations.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_updatelocations.TabIndex = 9
        Me.mbtn_updatelocations.Text = "Update"
        Me.mbtn_updatelocations.UseSelectable = True
        '
        'mbtn_locationsave
        '
        Me.mbtn_locationsave.Location = New System.Drawing.Point(402, 187)
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.mg_locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mg_locations.DefaultCellStyle = DataGridViewCellStyle8
        Me.mg_locations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mg_locations.EnableHeadersVisualStyles = False
        Me.mg_locations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mg_locations.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mg_locations.Location = New System.Drawing.Point(3, 16)
        Me.mg_locations.MultiSelect = False
        Me.mg_locations.Name = "mg_locations"
        Me.mg_locations.ReadOnly = True
        Me.mg_locations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mg_locations.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.mg_locations.RowHeadersVisible = False
        Me.mg_locations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mg_locations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mg_locations.Size = New System.Drawing.Size(575, 117)
        Me.mg_locations.Style = MetroFramework.MetroColorStyle.Orange
        Me.mg_locations.TabIndex = 0
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(92, 162)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Location:"
        '
        'tb_location
        '
        Me.tb_location.Location = New System.Drawing.Point(159, 161)
        Me.tb_location.Name = "tb_location"
        Me.tb_location.Size = New System.Drawing.Size(318, 20)
        Me.tb_location.TabIndex = 1
        '
        'mt_schoolyear
        '
        Me.mt_schoolyear.ActiveControl = Nothing
        Me.mt_schoolyear.Location = New System.Drawing.Point(6, 6)
        Me.mt_schoolyear.Name = "mt_schoolyear"
        Me.mt_schoolyear.Size = New System.Drawing.Size(93, 51)
        Me.mt_schoolyear.TabIndex = 10
        Me.mt_schoolyear.Text = "School Year"
        Me.mt_schoolyear.UseSelectable = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rfPointSettings)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(678, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rating Forms Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rfPointSettings
        '
        Me.rfPointSettings.Controls.Add(Me.rfstxtminBronze)
        Me.rfPointSettings.Controls.Add(Me.rfstxtminSilver)
        Me.rfPointSettings.Controls.Add(Me.rfstxtminGold)
        Me.rfPointSettings.Controls.Add(Me.rfsBtnCancel)
        Me.rfPointSettings.Controls.Add(Me.MetroLabel8)
        Me.rfPointSettings.Controls.Add(Me.MetroLabel7)
        Me.rfPointSettings.Controls.Add(Me.MetroLabel6)
        Me.rfPointSettings.Controls.Add(Me.MetroLabel5)
        Me.rfPointSettings.Controls.Add(Me.rfsBtnSave)
        Me.rfPointSettings.Controls.Add(Me.rfsBtnEditSave)
        Me.rfPointSettings.Location = New System.Drawing.Point(3, 49)
        Me.rfPointSettings.Name = "rfPointSettings"
        Me.rfPointSettings.Size = New System.Drawing.Size(672, 290)
        Me.rfPointSettings.TabIndex = 0
        Me.rfPointSettings.TabStop = False
        Me.rfPointSettings.Text = "&Points Settings"
        '
        'rfsBtnCancel
        '
        Me.rfsBtnCancel.Location = New System.Drawing.Point(538, 256)
        Me.rfsBtnCancel.Name = "rfsBtnCancel"
        Me.rfsBtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.rfsBtnCancel.TabIndex = 8
        Me.rfsBtnCancel.Text = "&Cancel"
        Me.rfsBtnCancel.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 175)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(72, 25)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "Bronze"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 122)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(59, 25)
        Me.MetroLabel7.TabIndex = 2
        Me.MetroLabel7.Text = "Silver"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 74)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(52, 25)
        Me.MetroLabel6.TabIndex = 1
        Me.MetroLabel6.Text = "Gold"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 36)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Awards:"
        '
        'rfsBtnSave
        '
        Me.rfsBtnSave.Location = New System.Drawing.Point(455, 256)
        Me.rfsBtnSave.Name = "rfsBtnSave"
        Me.rfsBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.rfsBtnSave.TabIndex = 9
        Me.rfsBtnSave.Text = "Save"
        Me.rfsBtnSave.UseSelectable = True
        '
        'rfsBtnEditSave
        '
        Me.rfsBtnEditSave.Location = New System.Drawing.Point(455, 256)
        Me.rfsBtnEditSave.Name = "rfsBtnEditSave"
        Me.rfsBtnEditSave.Size = New System.Drawing.Size(75, 23)
        Me.rfsBtnEditSave.TabIndex = 7
        Me.rfsBtnEditSave.Text = "&Edit"
        Me.rfsBtnEditSave.UseSelectable = True
        '
        'tipErrors
        '
        Me.tipErrors.Style = MetroFramework.MetroColorStyle.Blue
        Me.tipErrors.StyleManager = Nothing
        Me.tipErrors.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'rfstxtminGold
        '
        '
        '
        '
        Me.rfstxtminGold.CustomButton.Image = Nothing
        Me.rfstxtminGold.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.rfstxtminGold.CustomButton.Name = ""
        Me.rfstxtminGold.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.rfstxtminGold.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.rfstxtminGold.CustomButton.TabIndex = 1
        Me.rfstxtminGold.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.rfstxtminGold.CustomButton.UseSelectable = True
        Me.rfstxtminGold.CustomButton.Visible = False
        Me.rfstxtminGold.Lines = New String(-1) {}
        Me.rfstxtminGold.Location = New System.Drawing.Point(130, 76)
        Me.rfstxtminGold.MaxLength = 32767
        Me.rfstxtminGold.Name = "rfstxtminGold"
        Me.rfstxtminGold.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rfstxtminGold.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rfstxtminGold.SelectedText = ""
        Me.rfstxtminGold.SelectionLength = 0
        Me.rfstxtminGold.SelectionStart = 0
        Me.rfstxtminGold.ShortcutsEnabled = True
        Me.rfstxtminGold.Size = New System.Drawing.Size(195, 23)
        Me.rfstxtminGold.TabIndex = 10
        Me.rfstxtminGold.UseSelectable = True
        Me.rfstxtminGold.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.rfstxtminGold.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'rfstxtminSilver
        '
        '
        '
        '
        Me.rfstxtminSilver.CustomButton.Image = Nothing
        Me.rfstxtminSilver.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.rfstxtminSilver.CustomButton.Name = ""
        Me.rfstxtminSilver.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.rfstxtminSilver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.rfstxtminSilver.CustomButton.TabIndex = 1
        Me.rfstxtminSilver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.rfstxtminSilver.CustomButton.UseSelectable = True
        Me.rfstxtminSilver.CustomButton.Visible = False
        Me.rfstxtminSilver.Lines = New String(-1) {}
        Me.rfstxtminSilver.Location = New System.Drawing.Point(130, 124)
        Me.rfstxtminSilver.MaxLength = 32767
        Me.rfstxtminSilver.Name = "rfstxtminSilver"
        Me.rfstxtminSilver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rfstxtminSilver.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rfstxtminSilver.SelectedText = ""
        Me.rfstxtminSilver.SelectionLength = 0
        Me.rfstxtminSilver.SelectionStart = 0
        Me.rfstxtminSilver.ShortcutsEnabled = True
        Me.rfstxtminSilver.Size = New System.Drawing.Size(195, 23)
        Me.rfstxtminSilver.TabIndex = 11
        Me.rfstxtminSilver.UseSelectable = True
        Me.rfstxtminSilver.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.rfstxtminSilver.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'rfstxtminBronze
        '
        '
        '
        '
        Me.rfstxtminBronze.CustomButton.Image = Nothing
        Me.rfstxtminBronze.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.rfstxtminBronze.CustomButton.Name = ""
        Me.rfstxtminBronze.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.rfstxtminBronze.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.rfstxtminBronze.CustomButton.TabIndex = 1
        Me.rfstxtminBronze.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.rfstxtminBronze.CustomButton.UseSelectable = True
        Me.rfstxtminBronze.CustomButton.Visible = False
        Me.rfstxtminBronze.Lines = New String(-1) {}
        Me.rfstxtminBronze.Location = New System.Drawing.Point(130, 177)
        Me.rfstxtminBronze.MaxLength = 32767
        Me.rfstxtminBronze.Name = "rfstxtminBronze"
        Me.rfstxtminBronze.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rfstxtminBronze.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rfstxtminBronze.SelectedText = ""
        Me.rfstxtminBronze.SelectionLength = 0
        Me.rfstxtminBronze.SelectionStart = 0
        Me.rfstxtminBronze.ShortcutsEnabled = True
        Me.rfstxtminBronze.Size = New System.Drawing.Size(195, 23)
        Me.rfstxtminBronze.TabIndex = 12
        Me.rfstxtminBronze.UseSelectable = True
        Me.rfstxtminBronze.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.rfstxtminBronze.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ran_kpi)
        Me.Controls.Add(Me.ran_loc)
        Me.Controls.Add(Me.ran_org)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.Resizable = False
        Me.Text = " "
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grp_mainsettings.ResumeLayout(False)
        Me.grp_kpi.ResumeLayout(False)
        Me.grp_kpi.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.mg_kpi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_org.ResumeLayout(False)
        Me.grp_org.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.mg_organizations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_loc.ResumeLayout(False)
        Me.grp_loc.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.mg_locations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.rfPointSettings.ResumeLayout(False)
        Me.rfPointSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ran_org As Label
    Friend WithEvents ran_loc As Label
    Friend WithEvents ran_kpi As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents mb_functionchoice As MetroFramework.Controls.MetroComboBox
    Friend WithEvents grp_mainsettings As GroupBox
    Friend WithEvents grp_kpi As GroupBox
    Friend WithEvents mbtn_clearkpi As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_deletekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updatekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents mg_kpi As MetroFramework.Controls.MetroGrid
    Friend WithEvents mbtn_savekpi As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_kpi As TextBox
    Friend WithEvents grp_org As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mg_organizations As MetroFramework.Controls.MetroGrid
    Friend WithEvents mbtn_clearorg As MetroFramework.Controls.MetroButton
    Friend WithEvents tb_organization As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtn_delete As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_saveorganization As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updateorganizations As MetroFramework.Controls.MetroButton
    Friend WithEvents grp_loc As GroupBox
    Friend WithEvents mbtn_clearloc As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_deletelocations As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_updatelocations As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_locationsave As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents mg_locations As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tb_location As TextBox
    Friend WithEvents mt_schoolyear As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rfPointSettings As GroupBox
    Friend WithEvents rfsBtnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents rfsBtnEditSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipErrors As MetroFramework.Components.MetroToolTip
    Friend WithEvents rfsBtnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents rfstxtminBronze As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rfstxtminSilver As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rfstxtminGold As MetroFramework.Controls.MetroTextBox
End Class
