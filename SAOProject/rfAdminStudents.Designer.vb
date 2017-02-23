<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rfAdminStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfAdminStudents))
        Me.tilAdd = New MetroFramework.Controls.MetroTile()
        Me.tipError = New MetroFramework.Components.MetroToolTip()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnPoints = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.comYear = New MetroFramework.Controls.MetroComboBox()
        Me.comCourse = New MetroFramework.Controls.MetroComboBox()
        Me.comCollege = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtMid = New MetroFramework.Controls.MetroTextBox()
        Me.txtFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.txtSurname = New MetroFramework.Controls.MetroTextBox()
        Me.txtNum = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tilAdd
        '
        Me.tilAdd.ActiveControl = Nothing
        Me.tilAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilAdd.Location = New System.Drawing.Point(437, 140)
        Me.tilAdd.Name = "tilAdd"
        Me.tilAdd.Size = New System.Drawing.Size(75, 75)
        Me.tilAdd.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilAdd.TabIndex = 44
        Me.tilAdd.Text = "Add"
        Me.tilAdd.TileImage = Global.SAOProject.My.Resources.Resources.ic_person_add_white_48dp_1x
        Me.tilAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.tilAdd.UseSelectable = True
        Me.tilAdd.UseTileImage = True
        '
        'tipError
        '
        Me.tipError.Style = MetroFramework.MetroColorStyle.Blue
        Me.tipError.StyleManager = Nothing
        Me.tipError.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseSelectable = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(138, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseSelectable = True
        Me.btnSave.Visible = False
        '
        'btnPoints
        '
        Me.btnPoints.Enabled = False
        Me.btnPoints.Location = New System.Drawing.Point(184, 282)
        Me.btnPoints.Name = "btnPoints"
        Me.btnPoints.Size = New System.Drawing.Size(75, 23)
        Me.btnPoints.TabIndex = 44
        Me.btnPoints.Text = "POINTS"
        Me.btnPoints.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(220, 252)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(138, 253)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 42
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(46, 212)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel10.TabIndex = 39
        Me.MetroLabel10.Text = "Year of Graduation"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(46, 176)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel9.TabIndex = 38
        Me.MetroLabel9.Text = "Course"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(46, 140)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel8.TabIndex = 37
        Me.MetroLabel8.Text = "College/School"
        '
        'comYear
        '
        Me.comYear.Enabled = False
        Me.comYear.FormattingEnabled = True
        Me.comYear.ItemHeight = 23
        Me.comYear.Location = New System.Drawing.Point(170, 212)
        Me.comYear.Name = "comYear"
        Me.comYear.Size = New System.Drawing.Size(121, 29)
        Me.comYear.Style = MetroFramework.MetroColorStyle.Pink
        Me.comYear.TabIndex = 36
        Me.comYear.UseSelectable = True
        Me.comYear.UseStyleColors = True
        '
        'comCourse
        '
        Me.comCourse.Enabled = False
        Me.comCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comCourse.FormattingEnabled = True
        Me.comCourse.ItemHeight = 23
        Me.comCourse.Location = New System.Drawing.Point(170, 176)
        Me.comCourse.Name = "comCourse"
        Me.comCourse.Size = New System.Drawing.Size(216, 29)
        Me.comCourse.Style = MetroFramework.MetroColorStyle.Pink
        Me.comCourse.TabIndex = 35
        Me.comCourse.UseSelectable = True
        Me.comCourse.UseStyleColors = True
        '
        'comCollege
        '
        Me.comCollege.Enabled = False
        Me.comCollege.FormattingEnabled = True
        Me.comCollege.ItemHeight = 23
        Me.comCollege.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education, Liberal Arts, Music, and Social Work", "College of Medical Technology", "College of Nursing", "College of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Nutrition and Hospitality Management"})
        Me.comCollege.Location = New System.Drawing.Point(170, 140)
        Me.comCollege.Name = "comCollege"
        Me.comCollege.Size = New System.Drawing.Size(216, 29)
        Me.comCollege.Style = MetroFramework.MetroColorStyle.Pink
        Me.comCollege.TabIndex = 34
        Me.comCollege.UseSelectable = True
        Me.comCollege.UseStyleColors = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(46, 110)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel7.TabIndex = 33
        Me.MetroLabel7.Text = "Middle Initial"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(46, 80)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel6.TabIndex = 32
        Me.MetroLabel6.Text = "First Name"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(46, 50)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel5.TabIndex = 31
        Me.MetroLabel5.Text = "Last Name"
        '
        'txtMid
        '
        '
        '
        '
        Me.txtMid.CustomButton.Image = Nothing
        Me.txtMid.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtMid.CustomButton.Name = ""
        Me.txtMid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMid.CustomButton.TabIndex = 1
        Me.txtMid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMid.CustomButton.UseSelectable = True
        Me.txtMid.CustomButton.Visible = False
        Me.txtMid.Enabled = False
        Me.txtMid.Lines = New String(-1) {}
        Me.txtMid.Location = New System.Drawing.Point(170, 110)
        Me.txtMid.MaxLength = 32767
        Me.txtMid.Name = "txtMid"
        Me.txtMid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMid.SelectedText = ""
        Me.txtMid.SelectionLength = 0
        Me.txtMid.SelectionStart = 0
        Me.txtMid.ShortcutsEnabled = True
        Me.txtMid.Size = New System.Drawing.Size(155, 23)
        Me.txtMid.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtMid.TabIndex = 29
        Me.txtMid.UseSelectable = True
        Me.txtMid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFirstname
        '
        '
        '
        '
        Me.txtFirstname.CustomButton.Image = Nothing
        Me.txtFirstname.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtFirstname.CustomButton.Name = ""
        Me.txtFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstname.CustomButton.TabIndex = 1
        Me.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstname.CustomButton.UseSelectable = True
        Me.txtFirstname.CustomButton.Visible = False
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Lines = New String(-1) {}
        Me.txtFirstname.Location = New System.Drawing.Point(170, 80)
        Me.txtFirstname.MaxLength = 32767
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.SelectionLength = 0
        Me.txtFirstname.SelectionStart = 0
        Me.txtFirstname.ShortcutsEnabled = True
        Me.txtFirstname.Size = New System.Drawing.Size(155, 23)
        Me.txtFirstname.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtFirstname.TabIndex = 28
        Me.txtFirstname.UseSelectable = True
        Me.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSurname
        '
        '
        '
        '
        Me.txtSurname.CustomButton.Image = Nothing
        Me.txtSurname.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtSurname.CustomButton.Name = ""
        Me.txtSurname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSurname.CustomButton.TabIndex = 1
        Me.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSurname.CustomButton.UseSelectable = True
        Me.txtSurname.CustomButton.Visible = False
        Me.txtSurname.Enabled = False
        Me.txtSurname.Lines = New String(-1) {}
        Me.txtSurname.Location = New System.Drawing.Point(170, 50)
        Me.txtSurname.MaxLength = 32767
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.SelectionLength = 0
        Me.txtSurname.SelectionStart = 0
        Me.txtSurname.ShortcutsEnabled = True
        Me.txtSurname.Size = New System.Drawing.Size(155, 23)
        Me.txtSurname.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtSurname.TabIndex = 27
        Me.txtSurname.UseSelectable = True
        Me.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSurname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNum
        '
        '
        '
        '
        Me.txtNum.CustomButton.Image = Nothing
        Me.txtNum.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtNum.CustomButton.Name = ""
        Me.txtNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNum.CustomButton.TabIndex = 1
        Me.txtNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNum.CustomButton.UseSelectable = True
        Me.txtNum.CustomButton.Visible = False
        Me.txtNum.Enabled = False
        Me.txtNum.Lines = New String(-1) {}
        Me.txtNum.Location = New System.Drawing.Point(170, 20)
        Me.txtNum.MaxLength = 32767
        Me.txtNum.Name = "txtNum"
        Me.txtNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNum.SelectedText = ""
        Me.txtNum.SelectionLength = 0
        Me.txtNum.SelectionStart = 0
        Me.txtNum.ShortcutsEnabled = True
        Me.txtNum.Size = New System.Drawing.Size(155, 23)
        Me.txtNum.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtNum.TabIndex = 26
        Me.txtNum.UseSelectable = True
        Me.txtNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(46, 20)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel4.TabIndex = 25
        Me.MetroLabel4.Text = "Student Number"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(6, 37)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(154, 23)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtSearch.TabIndex = 24
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.txtSearch)
        Me.MetroPanel1.Controls.Add(Me.btnSearch)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(169, 140)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(251, 75)
        Me.MetroPanel1.TabIndex = 41
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(166, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "&GO"
        Me.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSearch.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(250, 19)
        Me.MetroLabel1.TabIndex = 23
        Me.MetroLabel1.Text = "Search by Last Name or Student Number"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.btnCancel)
        Me.MetroPanel2.Controls.Add(Me.btnSave)
        Me.MetroPanel2.Controls.Add(Me.btnPoints)
        Me.MetroPanel2.Controls.Add(Me.btnDelete)
        Me.MetroPanel2.Controls.Add(Me.btnEdit)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel2.Controls.Add(Me.comYear)
        Me.MetroPanel2.Controls.Add(Me.comCourse)
        Me.MetroPanel2.Controls.Add(Me.comCollege)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.txtMid)
        Me.MetroPanel2.Controls.Add(Me.txtFirstname)
        Me.MetroPanel2.Controls.Add(Me.txtSurname)
        Me.MetroPanel2.Controls.Add(Me.txtNum)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(169, 254)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(434, 317)
        Me.MetroPanel2.TabIndex = 42
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(609, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(82, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilHome.Location = New System.Drawing.Point(518, 140)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(75, 75)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 43
        Me.tilHome.Text = "Home"
        Me.tilHome.TileImage = CType(resources.GetObject("tilHome.TileImage"), System.Drawing.Image)
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(192, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(374, 66)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office"
        '
        'rfAdminStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(773, 741)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tilAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rfAdminStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CEU-SAO Rating Forms Management System"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tilAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tipError As MetroFramework.Components.MetroToolTip
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPoints As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comCollege As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSurname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label25 As Label
End Class
