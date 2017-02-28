<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfIndivPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfIndivPrint))
        Me.allrfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rfPrints_tbl = New SAOProject.rfPrints_tbl()
        Me.tilBack = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_studentNames = New MetroFramework.Controls.MetroComboBox()
        Me.allrfTableAdapter = New SAOProject.rfPrints_tblTableAdapters.allrfTableAdapter()
        CType(Me.allrfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rfPrints_tbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'allrfBindingSource
        '
        Me.allrfBindingSource.DataMember = "allrf"
        Me.allrfBindingSource.DataSource = Me.rfPrints_tbl
        '
        'rfPrints_tbl
        '
        Me.rfPrints_tbl.DataSetName = "rfPrints_tbl"
        Me.rfPrints_tbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tilBack
        '
        Me.tilBack.ActiveControl = Nothing
        Me.tilBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tilBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tilBack.Location = New System.Drawing.Point(551, 414)
        Me.tilBack.Name = "tilBack"
        Me.tilBack.Size = New System.Drawing.Size(75, 75)
        Me.tilBack.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilBack.TabIndex = 53
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
        Me.tilHome.Location = New System.Drawing.Point(632, 414)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(75, 75)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 52
        Me.tilHome.Text = "Home"
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_home_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.DocumentMapWidth = 27
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.allrfBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SAOProject.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(35, 76)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 332)
        Me.ReportViewer1.TabIndex = 51
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(52, 45)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(139, 19)
        Me.MetroLabel8.TabIndex = 50
        Me.MetroLabel8.Text = "Search Student Name:"
        '
        'cmb_studentNames
        '
        Me.cmb_studentNames.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_studentNames.FormattingEnabled = True
        Me.cmb_studentNames.ItemHeight = 23
        Me.cmb_studentNames.Location = New System.Drawing.Point(197, 41)
        Me.cmb_studentNames.Name = "cmb_studentNames"
        Me.cmb_studentNames.Size = New System.Drawing.Size(216, 29)
        Me.cmb_studentNames.Style = MetroFramework.MetroColorStyle.Pink
        Me.cmb_studentNames.TabIndex = 49
        Me.cmb_studentNames.UseSelectable = True
        Me.cmb_studentNames.UseStyleColors = True
        '
        'allrfTableAdapter
        '
        Me.allrfTableAdapter.ClearBeforeFill = True
        '
        'rfIndivPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.tilBack)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cmb_studentNames)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rfIndivPrint"
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.allrfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rfPrints_tbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tilBack As MetroFramework.Controls.MetroTile
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_studentNames As MetroFramework.Controls.MetroComboBox
    Friend WithEvents allrfBindingSource As BindingSource
    Friend WithEvents rfPrints_tbl As rfPrints_tbl
    Friend WithEvents allrfTableAdapter As rfPrints_tblTableAdapters.allrfTableAdapter
End Class
