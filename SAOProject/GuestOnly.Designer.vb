<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestOnly
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestOnly))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_filterlocation = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cb_filterschool = New System.Windows.Forms.ComboBox()
        Me.btn_searchbydate = New System.Windows.Forms.Button()
        Me.filter_dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.filter_dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.load_schedule = New System.Windows.Forms.Button()
        Me.welcomeguest = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1_guest = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_showsem = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.Location = New System.Drawing.Point(330, 150)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(946, 507)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Schedule"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(940, 485)
        Me.DataGridView1.Style = MetroFramework.MetroColorStyle.Orange
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox8.Location = New System.Drawing.Point(892, 27)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(104, 99)
        Me.PictureBox8.TabIndex = 39
        Me.PictureBox8.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(512, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(374, 99)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Mendiola, Manila"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.oie_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(398, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 99)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightPink
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1288, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.cb_filterlocation)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.cb_filterschool)
        Me.GroupBox2.Controls.Add(Me.btn_searchbydate)
        Me.GroupBox2.Controls.Add(Me.filter_dtp3)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.filter_dtp2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 241)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'cb_filterlocation
        '
        Me.cb_filterlocation.AutoCompleteCustomSource.AddRange(New String() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle"})
        Me.cb_filterlocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_filterlocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_filterlocation.FormattingEnabled = True
        Me.cb_filterlocation.Items.AddRange(New Object() {"CARMEN DE LUNA (CDL)", "Multimedia Instructional Room (MIR)", "LIBRADA AVELINO HALL (LAH)", "Chapel/Adoration Chapel", "Executive Meeting Room (EMR)", "LAH Seminar Room #1", "LAH Seminar Room #2", "LAH Seminar Room #3", "GENEROSA DE LEON SCIENCE CENTER (GDLSC)", "Bulwagang Maestra Osang (BMO)", "SOFIA DE VEYRA HALL (SDVH)", "SDV Conference Room (SDVCR)", "SDV Lanai", "FELISA FRANCISCO HALL (FFH)", "Assembly Hall (3rd Flr)", "MARIA VILLACERAN HALL (MVH)", "LA Auditorium", "MVH Lanai", "DIONISIO C. TIONGCO (DCT)", "Student Activity Center (Ground flr)", "Student Activity Center (Second flr)", "PILAR HIDALGO LIM HALL (PHL)", "PHL Lanai", "TECHNOLOGY CENTER", "TechCenter Gym", "TechCenter Lanai with Lights", "FGH DENTRISTRY", "FGH Lanai", "INFORMATION SCIENCE CENTER", "Friends Cafe", "ISC Mezzanine #1", "ISC Mezzanine #2", "DentScience Lanai", "GYM (Classroom)", "North Quadrangle", "South Quadrangle"})
        Me.cb_filterlocation.Location = New System.Drawing.Point(17, 37)
        Me.cb_filterlocation.Name = "cb_filterlocation"
        Me.cb_filterlocation.Size = New System.Drawing.Size(289, 23)
        Me.cb_filterlocation.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(68, 178)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(177, 15)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "Search by School/Organization" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cb_filterschool
        '
        Me.cb_filterschool.AutoCompleteCustomSource.AddRange(New String() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "Other"})
        Me.cb_filterschool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_filterschool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_filterschool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_filterschool.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cb_filterschool.FormattingEnabled = True
        Me.cb_filterschool.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "Other"})
        Me.cb_filterschool.Location = New System.Drawing.Point(17, 196)
        Me.cb_filterschool.Name = "cb_filterschool"
        Me.cb_filterschool.Size = New System.Drawing.Size(289, 23)
        Me.cb_filterschool.TabIndex = 5
        '
        'btn_searchbydate
        '
        Me.btn_searchbydate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_searchbydate.Location = New System.Drawing.Point(84, 142)
        Me.btn_searchbydate.Name = "btn_searchbydate"
        Me.btn_searchbydate.Size = New System.Drawing.Size(149, 29)
        Me.btn_searchbydate.TabIndex = 4
        Me.btn_searchbydate.Text = "Search by Date"
        Me.btn_searchbydate.UseVisualStyleBackColor = True
        '
        'filter_dtp3
        '
        Me.filter_dtp3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.filter_dtp3.Location = New System.Drawing.Point(32, 114)
        Me.filter_dtp3.Name = "filter_dtp3"
        Me.filter_dtp3.Size = New System.Drawing.Size(248, 23)
        Me.filter_dtp3.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(109, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 15)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Search by Location"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(109, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 15)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Search by Date"
        '
        'filter_dtp2
        '
        Me.filter_dtp2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.filter_dtp2.Location = New System.Drawing.Point(32, 86)
        Me.filter_dtp2.Name = "filter_dtp2"
        Me.filter_dtp2.Size = New System.Drawing.Size(248, 23)
        Me.filter_dtp2.TabIndex = 2
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox14.Controls.Add(Me.Label37)
        Me.GroupBox14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox14.Location = New System.Drawing.Point(12, 397)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(312, 184)
        Me.GroupBox14.TabIndex = 42
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Help"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(9, 19)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(303, 150)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = resources.GetString("Label37.Text")
        '
        'load_schedule
        '
        Me.load_schedule.AutoSize = True
        Me.load_schedule.FlatAppearance.BorderSize = 2
        Me.load_schedule.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.load_schedule.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.load_schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.load_schedule.Location = New System.Drawing.Point(330, 660)
        Me.load_schedule.Name = "load_schedule"
        Me.load_schedule.Size = New System.Drawing.Size(98, 27)
        Me.load_schedule.TabIndex = 6
        Me.load_schedule.Text = "Refresh "
        Me.load_schedule.UseVisualStyleBackColor = True
        '
        'welcomeguest
        '
        Me.welcomeguest.AutoSize = True
        Me.welcomeguest.BackColor = System.Drawing.Color.LightPink
        Me.welcomeguest.Font = New System.Drawing.Font("Trajan Pro 3", 12.0!, System.Drawing.FontStyle.Bold)
        Me.welcomeguest.ForeColor = System.Drawing.Color.Navy
        Me.welcomeguest.Location = New System.Drawing.Point(482, 1)
        Me.welcomeguest.Name = "welcomeguest"
        Me.welcomeguest.Size = New System.Drawing.Size(154, 25)
        Me.welcomeguest.TabIndex = 44
        Me.welcomeguest.Text = "welcomeguest"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.LightPink
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_time.Location = New System.Drawing.Point(1042, 7)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(35, 15)
        Me.lbl_time.TabIndex = 45
        Me.lbl_time.Text = "Time"
        '
        'Timer1_guest
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbl_showsem)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(1066, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 112)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "School Year"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(63, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_showsem
        '
        Me.lbl_showsem.AutoSize = True
        Me.lbl_showsem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_showsem.Location = New System.Drawing.Point(40, 19)
        Me.lbl_showsem.Name = "lbl_showsem"
        Me.lbl_showsem.Size = New System.Drawing.Size(133, 30)
        Me.lbl_showsem.TabIndex = 5
        Me.lbl_showsem.Text = "School Year "
        '
        'GuestOnly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1288, 690)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.welcomeguest)
        Me.Controls.Add(Me.load_schedule)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "GuestOnly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Affairs Office Consolidated Calendar"
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents cb_filterschool As ComboBox
    Friend WithEvents btn_searchbydate As Button
    Friend WithEvents filter_dtp3 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents filter_dtp2 As DateTimePicker
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents load_schedule As Button
    Friend WithEvents welcomeguest As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1_guest As Timer
    Friend WithEvents Label37 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_showsem As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents cb_filterlocation As ComboBox
End Class
