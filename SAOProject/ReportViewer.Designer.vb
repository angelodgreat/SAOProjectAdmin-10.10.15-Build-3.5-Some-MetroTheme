<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportViewer
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportViewer))
        Me.SAOEventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SAOProject.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New MetroFramework.Controls.MetroDateTime()
        Me.DateTimePicker2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cb_filterschool = New System.Windows.Forms.ComboBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.SAOEventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SAOEventBindingSource
        '
        Me.SAOEventBindingSource.DataMember = "SAOEvent"
        Me.SAOEventBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SAOEventBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SAOProject.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1254, 459)
        Me.ReportViewer1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1254, 4)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(174, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "College/Organization:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(596, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(101, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Search  by:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(639, 35)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(231, 29)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(876, 34)
        Me.DateTimePicker2.MinimumSize = New System.Drawing.Size(4, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(228, 29)
        Me.DateTimePicker2.TabIndex = 4
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(1110, 37)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(98, 23)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Search by Date"
        Me.MetroButton1.UseSelectable = True
        '
        'cb_filterschool
        '
        Me.cb_filterschool.AutoCompleteCustomSource.AddRange(New String() {"School of Accountancy and Management", "School of Dentistry", "School of Education—Liberal Arts—Music—Social Work", "School of Medical Technology", "School of Nursing", "School of Nutrition and Hospitality Management", "School of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Graduate School", "School of Senior High School (Grades 11 & 12)", "Community Outreach Movement Proactive Student Services (COMPASS)", "Dramatic Guild (DG)", "English Guild", "Honors Society (HonSoc)", "International Students Association (ISA)", "Math Club", "Oratorical and Debate Society (ORADES)", "Photographers Club (Photo Club)", "Red Cross Youth (RCY)", "Science Club", "Student Catholic Action (SCA)", "Social Sciences Society (SSS)", "CEU Student Chapter of the American Society of Microbiology", "CEU Marketing Society (CEMARS)", "Junior Financial Executives (JFINEX)", "Junior Philippine Institute of Accountants (JPIA)", "Management Students Association (MASA)", "Dental Clinicians Club (DCC)", "Philippine Dental Students Association (PDSA)", "Association of Tourism Students (ATS)", "Association of Hotel & Restaurants Management Students (AHRMS)", "Philippine Association of Nutritionists (PAN-DELTA)", "Philippine Nursing Research Society (PNRS)", "Optometry Clinicians Club (OCC)", "Junior Philippine Pharmacists Association (JPPhA)", "CEU Psychology Society (Psych Soc)", "Junior Philippine Computer Society (JPCS)", "Philippine Society of Medical Technology Students (PHISMETS)", "CEU Communication Arts Society (CoMaSoc)", "Junior Social Work Association of the Philippines (JSWAP) ", "Other"})
        Me.cb_filterschool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_filterschool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cb_filterschool.FormattingEnabled = True
        Me.cb_filterschool.Location = New System.Drawing.Point(308, 37)
        Me.cb_filterschool.Name = "cb_filterschool"
        Me.cb_filterschool.Size = New System.Drawing.Size(282, 22)
        Me.cb_filterschool.TabIndex = 2
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(20, 39)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 1
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 543)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.cb_filterschool)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ReportViewer"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.SAOEventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SAOEventBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DateTimePicker2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cb_filterschool As ComboBox
    Friend WithEvents btn_refresh As Button
End Class
