<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfUniColPrint
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.studsumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rfPrints_tbl = New SAOProject.rfPrints_tbl()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tilBack = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.LScmbYG = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.LScmbFilter = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lstStudcmCS = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.studsumTableAdapter = New SAOProject.rfPrints_tblTableAdapters.studsumTableAdapter()
        CType(Me.studsumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rfPrints_tbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'studsumBindingSource
        '
        Me.studsumBindingSource.DataMember = "studsum"
        Me.studsumBindingSource.DataSource = Me.rfPrints_tbl
        '
        'rfPrints_tbl
        '
        Me.rfPrints_tbl.DataSetName = "rfPrints_tbl"
        Me.rfPrints_tbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.studsumBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SAOProject.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(339, 112)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(769, 471)
        Me.ReportViewer2.TabIndex = 42
        '
        'tilBack
        '
        Me.tilBack.ActiveControl = Nothing
        Me.tilBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tilBack.Location = New System.Drawing.Point(952, 588)
        Me.tilBack.Name = "tilBack"
        Me.tilBack.Size = New System.Drawing.Size(75, 75)
        Me.tilBack.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilBack.TabIndex = 39
        Me.tilBack.Text = "Back"
        Me.tilBack.TileImage = Global.SAOProject.My.Resources.Resources.ic_arrow_back_white_48dp_1x
        Me.tilBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilBack.UseSelectable = True
        Me.tilBack.UseTileImage = True
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tilHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tilHome.Location = New System.Drawing.Point(1033, 589)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(75, 75)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 53
        Me.tilHome.Text = "Home"
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_home_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'LScmbYG
        '
        Me.LScmbYG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LScmbYG.FormattingEnabled = True
        Me.LScmbYG.ItemHeight = 23
        Me.LScmbYG.Location = New System.Drawing.Point(914, 43)
        Me.LScmbYG.Name = "LScmbYG"
        Me.LScmbYG.Size = New System.Drawing.Size(155, 29)
        Me.LScmbYG.TabIndex = 57
        Me.LScmbYG.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(784, 52)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel4.TabIndex = 56
        Me.MetroLabel4.Text = "Year of Graduation"
        '
        'LScmbFilter
        '
        Me.LScmbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LScmbFilter.FormattingEnabled = True
        Me.LScmbFilter.ItemHeight = 23
        Me.LScmbFilter.Items.AddRange(New Object() {"University-Wide", "College/School-Wide"})
        Me.LScmbFilter.Location = New System.Drawing.Point(432, 42)
        Me.LScmbFilter.Name = "LScmbFilter"
        Me.LScmbFilter.Size = New System.Drawing.Size(267, 29)
        Me.LScmbFilter.TabIndex = 55
        Me.LScmbFilter.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(387, 53)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel1.TabIndex = 54
        Me.MetroLabel1.Text = "Filter"
        '
        'lstStudcmCS
        '
        Me.lstStudcmCS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lstStudcmCS.FormattingEnabled = True
        Me.lstStudcmCS.ItemHeight = 23
        Me.lstStudcmCS.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education, Liberal Arts, Music, and Social Work", "College of Medical Technology", "College of Nursing", "College of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Nutrition and Hospitality Management"})
        Me.lstStudcmCS.Location = New System.Drawing.Point(432, 77)
        Me.lstStudcmCS.Name = "lstStudcmCS"
        Me.lstStudcmCS.Size = New System.Drawing.Size(499, 29)
        Me.lstStudcmCS.TabIndex = 59
        Me.lstStudcmCS.UseSelectable = True
        Me.lstStudcmCS.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(327, 82)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel5.TabIndex = 58
        Me.MetroLabel5.Text = "College/School"
        Me.MetroLabel5.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 228)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Help"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 33)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(237, 166)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "For University Filter:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select a Year of Graduation first." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Colleg" &
    "e/School Filter: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select a Year of Graduation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first before choosing " &
    "a College/School." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(439, 662)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel6.TabIndex = 61
        Me.MetroLabel6.Text = "© Remos, Mahealani Joy G"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studsumTableAdapter
        '
        Me.studsumTableAdapter.ClearBeforeFill = True
        '
        'rfUniColPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 686)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstStudcmCS)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.LScmbYG)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.LScmbFilter)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.tilBack)
        Me.Name = "rfUniColPrint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.studsumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rfPrints_tbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tilBack As MetroFramework.Controls.MetroTile
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents LScmbYG As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LScmbFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstStudcmCS As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents studsumBindingSource As BindingSource
    Friend WithEvents rfPrints_tbl As rfPrints_tbl
    Friend WithEvents studsumTableAdapter As rfPrints_tblTableAdapters.studsumTableAdapter
End Class
