<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfAddStudent
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
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.comCourse = New MetroFramework.Controls.MetroComboBox()
        Me.comCollege = New MetroFramework.Controls.MetroComboBox()
        Me.comYear = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtMi = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.txtNum = New MetroFramework.Controls.MetroTextBox()
        Me.txtSurname = New MetroFramework.Controls.MetroTextBox()
        Me.tipError = New MetroFramework.Components.MetroToolTip()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel9
        '
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.Location = New System.Drawing.Point(213, 253)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel9.TabIndex = 28
        Me.MetroLabel9.Text = "©BSIT3A 2016"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(596, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&CLOSE"
        Me.btnCancel.UseSelectable = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(515, 208)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "R&ESET"
        Me.btnReset.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(434, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(215, 14)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(258, 25)
        Me.MetroLabel7.TabIndex = 24
        Me.MetroLabel7.Text = "ENTER STUDENT INFORMATION"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(18, 52)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Course"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(18, 20)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "College/School"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.comCourse)
        Me.MetroPanel2.Controls.Add(Me.comCollege)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(281, 52)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(390, 99)
        Me.MetroPanel2.TabIndex = 23
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'comCourse
        '
        Me.comCourse.FormattingEnabled = True
        Me.comCourse.ItemHeight = 23
        Me.comCourse.Location = New System.Drawing.Point(139, 52)
        Me.comCourse.Name = "comCourse"
        Me.comCourse.Size = New System.Drawing.Size(231, 29)
        Me.comCourse.Style = MetroFramework.MetroColorStyle.Pink
        Me.comCourse.TabIndex = 8
        Me.comCourse.UseSelectable = True
        '
        'comCollege
        '
        Me.comCollege.FormattingEnabled = True
        Me.comCollege.ItemHeight = 23
        Me.comCollege.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education, Liberal Arts, Music, and Social Work", "College of Medical Technology", "College of Nursing", "College of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Nutrition and Hospitality Management"})
        Me.comCollege.Location = New System.Drawing.Point(139, 15)
        Me.comCollege.Name = "comCollege"
        Me.comCollege.Size = New System.Drawing.Size(231, 29)
        Me.comCollege.Style = MetroFramework.MetroColorStyle.Pink
        Me.comCollege.TabIndex = 7
        Me.comCollege.UseSelectable = True
        '
        'comYear
        '
        Me.comYear.FormattingEnabled = True
        Me.comYear.ItemHeight = 23
        Me.comYear.Location = New System.Drawing.Point(140, 134)
        Me.comYear.Name = "comYear"
        Me.comYear.Size = New System.Drawing.Size(100, 29)
        Me.comYear.Style = MetroFramework.MetroColorStyle.Pink
        Me.comYear.TabIndex = 13
        Me.comYear.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(15, 134)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "Year of Graduation"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.comYear)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtMi)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.txtFirstname)
        Me.MetroPanel1.Controls.Add(Me.txtNum)
        Me.MetroPanel1.Controls.Add(Me.txtSurname)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(17, 52)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(258, 179)
        Me.MetroPanel1.TabIndex = 22
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Middle Initial"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Student Number"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 45)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Last Name"
        '
        'txtMi
        '
        '
        '
        '
        Me.txtMi.CustomButton.Image = Nothing
        Me.txtMi.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.txtMi.CustomButton.Name = ""
        Me.txtMi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMi.CustomButton.TabIndex = 1
        Me.txtMi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMi.CustomButton.UseSelectable = True
        Me.txtMi.CustomButton.Visible = False
        Me.txtMi.Lines = New String(-1) {}
        Me.txtMi.Location = New System.Drawing.Point(140, 105)
        Me.txtMi.MaxLength = 32767
        Me.txtMi.Name = "txtMi"
        Me.txtMi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMi.SelectedText = ""
        Me.txtMi.SelectionLength = 0
        Me.txtMi.SelectionStart = 0
        Me.txtMi.ShortcutsEnabled = True
        Me.txtMi.Size = New System.Drawing.Size(101, 23)
        Me.txtMi.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtMi.TabIndex = 6
        Me.txtMi.UseSelectable = True
        Me.txtMi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 75)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "First Name"
        '
        'txtFirstname
        '
        '
        '
        '
        Me.txtFirstname.CustomButton.Image = Nothing
        Me.txtFirstname.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.txtFirstname.CustomButton.Name = ""
        Me.txtFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstname.CustomButton.TabIndex = 1
        Me.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstname.CustomButton.UseSelectable = True
        Me.txtFirstname.CustomButton.Visible = False
        Me.txtFirstname.Lines = New String(-1) {}
        Me.txtFirstname.Location = New System.Drawing.Point(140, 75)
        Me.txtFirstname.MaxLength = 32767
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.SelectionLength = 0
        Me.txtFirstname.SelectionStart = 0
        Me.txtFirstname.ShortcutsEnabled = True
        Me.txtFirstname.Size = New System.Drawing.Size(101, 23)
        Me.txtFirstname.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtFirstname.TabIndex = 5
        Me.txtFirstname.UseSelectable = True
        Me.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNum
        '
        '
        '
        '
        Me.txtNum.CustomButton.Image = Nothing
        Me.txtNum.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.txtNum.CustomButton.Name = ""
        Me.txtNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNum.CustomButton.TabIndex = 1
        Me.txtNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNum.CustomButton.UseSelectable = True
        Me.txtNum.CustomButton.Visible = False
        Me.txtNum.Lines = New String(-1) {}
        Me.txtNum.Location = New System.Drawing.Point(140, 13)
        Me.txtNum.MaxLength = 32767
        Me.txtNum.Name = "txtNum"
        Me.txtNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNum.SelectedText = ""
        Me.txtNum.SelectionLength = 0
        Me.txtNum.SelectionStart = 0
        Me.txtNum.ShortcutsEnabled = True
        Me.txtNum.Size = New System.Drawing.Size(101, 23)
        Me.txtNum.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtNum.TabIndex = 3
        Me.txtNum.UseSelectable = True
        Me.txtNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSurname
        '
        '
        '
        '
        Me.txtSurname.CustomButton.Image = Nothing
        Me.txtSurname.CustomButton.Location = New System.Drawing.Point(79, 1)
        Me.txtSurname.CustomButton.Name = ""
        Me.txtSurname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSurname.CustomButton.TabIndex = 1
        Me.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSurname.CustomButton.UseSelectable = True
        Me.txtSurname.CustomButton.Visible = False
        Me.txtSurname.Lines = New String(-1) {}
        Me.txtSurname.Location = New System.Drawing.Point(140, 45)
        Me.txtSurname.MaxLength = 32767
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.SelectionLength = 0
        Me.txtSurname.SelectionStart = 0
        Me.txtSurname.ShortcutsEnabled = True
        Me.txtSurname.Size = New System.Drawing.Size(101, 23)
        Me.txtSurname.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtSurname.TabIndex = 4
        Me.txtSurname.UseSelectable = True
        Me.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSurname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tipError
        '
        Me.tipError.Style = MetroFramework.MetroColorStyle.Pink
        Me.tipError.StyleManager = Nothing
        Me.tipError.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'rfAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 287)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.Name = "rfAddStudent"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.TopMost = True
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents comCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comCollege As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSurname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tipError As MetroFramework.Components.MetroToolTip
End Class
