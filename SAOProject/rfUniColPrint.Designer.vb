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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.studsumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rfPrint_tbl = New SAOProject.rfPrint_tbl()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lstStudcmCS = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LScmbYG = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.LScmbFilter = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tilBack = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.studsumTableAdapter = New SAOProject.rfPrint_tblTableAdapters.studsumTableAdapter()
        CType(Me.studsumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rfPrint_tbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'studsumBindingSource
        '
        Me.studsumBindingSource.DataMember = "studsum"
        Me.studsumBindingSource.DataSource = Me.rfPrint_tbl
        '
        'rfPrint_tbl
        '
        Me.rfPrint_tbl.DataSetName = "rfPrint_tbl"
        Me.rfPrint_tbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroLabel6
        '
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(427, 643)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel6.TabIndex = 43
        Me.MetroLabel6.Text = "© Remos, Mahealani Joy G"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstStudcmCS
        '
        Me.lstStudcmCS.FormattingEnabled = True
        Me.lstStudcmCS.ItemHeight = 23
        Me.lstStudcmCS.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education, Liberal Arts, Music, and Social Work", "College of Medical Technology", "College of Nursing", "College of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Nutrition and Hospitality Management"})
        Me.lstStudcmCS.Location = New System.Drawing.Point(427, 82)
        Me.lstStudcmCS.Name = "lstStudcmCS"
        Me.lstStudcmCS.Size = New System.Drawing.Size(499, 29)
        Me.lstStudcmCS.TabIndex = 41
        Me.lstStudcmCS.UseSelectable = True
        Me.lstStudcmCS.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(322, 87)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel5.TabIndex = 40
        Me.MetroLabel5.Text = "College/School"
        Me.MetroLabel5.Visible = False
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.studsumBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SAOProject.Report3.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(322, 82)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(769, 458)
        Me.ReportViewer2.TabIndex = 42
        '
        'LScmbYG
        '
        Me.LScmbYG.FormattingEnabled = True
        Me.LScmbYG.ItemHeight = 23
        Me.LScmbYG.Location = New System.Drawing.Point(907, 47)
        Me.LScmbYG.Name = "LScmbYG"
        Me.LScmbYG.Size = New System.Drawing.Size(155, 29)
        Me.LScmbYG.TabIndex = 38
        Me.LScmbYG.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(777, 50)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel4.TabIndex = 37
        Me.MetroLabel4.Text = "Year of Graduation"
        '
        'LScmbFilter
        '
        Me.LScmbFilter.FormattingEnabled = True
        Me.LScmbFilter.ItemHeight = 23
        Me.LScmbFilter.Items.AddRange(New Object() {"University-Wide", "College/School-Wide"})
        Me.LScmbFilter.Location = New System.Drawing.Point(378, 47)
        Me.LScmbFilter.Name = "LScmbFilter"
        Me.LScmbFilter.Size = New System.Drawing.Size(267, 29)
        Me.LScmbFilter.TabIndex = 36
        Me.LScmbFilter.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(322, 50)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel1.TabIndex = 35
        Me.MetroLabel1.Text = "Filter"
        '
        'tilBack
        '
        Me.tilBack.ActiveControl = Nothing
        Me.tilBack.Location = New System.Drawing.Point(935, 546)
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
        Me.tilHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tilHome.Location = New System.Drawing.Point(1016, 546)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 228)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Help"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 33)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(237, 124)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "For College/School Filter: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select the Year of Graduation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first befor" &
    "e choosing a College/School." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'studsumTableAdapter
        '
        Me.studsumTableAdapter.ClearBeforeFill = True
        '
        'rfUniColPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lstStudcmCS)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.tilBack)
        Me.Controls.Add(Me.LScmbYG)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.LScmbFilter)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "rfUniColPrint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.studsumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rfPrint_tbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstStudcmCS As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tilBack As MetroFramework.Controls.MetroTile
    Friend WithEvents LScmbYG As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LScmbFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents studsumBindingSource As BindingSource
    Friend WithEvents rfPrint_tbl As rfPrint_tbl
    Friend WithEvents studsumTableAdapter As rfPrint_tblTableAdapters.studsumTableAdapter
End Class
