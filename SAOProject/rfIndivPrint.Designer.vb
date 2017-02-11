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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tilBack = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_studentNames = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(245, 502)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel1.TabIndex = 54
        Me.MetroLabel1.Text = "©BSIT3A 2016"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tilBack
        '
        Me.tilBack.ActiveControl = Nothing
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
        Me.ReportViewer1.DocumentMapWidth = 27
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ceuratingforms.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(35, 76)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 332)
        Me.ReportViewer1.TabIndex = 51
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(52, 45)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(139, 19)
        Me.MetroLabel8.TabIndex = 50
        Me.MetroLabel8.Text = "Search Student Name:"
        '
        'cmb_studentNames
        '
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
        'rfIndivPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 556)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tilBack)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cmb_studentNames)
        Me.Name = "rfIndivPrint"
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilBack As MetroFramework.Controls.MetroTile
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_studentNames As MetroFramework.Controls.MetroComboBox
End Class
