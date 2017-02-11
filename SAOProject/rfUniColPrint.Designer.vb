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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lstStudcmCS = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LScmbYG = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.LScmbFilter = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroLabel6
        '
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(342, 644)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel6.TabIndex = 43
        Me.MetroLabel6.Text = "©BSIT3A 2016"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstStudcmCS
        '
        Me.lstStudcmCS.FormattingEnabled = True
        Me.lstStudcmCS.ItemHeight = 23
        Me.lstStudcmCS.Items.AddRange(New Object() {"School of Accountancy and Management", "School of Dentistry", "School of Education, Liberal Arts, Music, and Social Work", "College of Medical Technology", "College of Nursing", "College of Optometry", "School of Pharmacy", "School of Science and Technology", "School of Nutrition and Hospitality Management"})
        Me.lstStudcmCS.Location = New System.Drawing.Point(255, 91)
        Me.lstStudcmCS.Name = "lstStudcmCS"
        Me.lstStudcmCS.Size = New System.Drawing.Size(499, 29)
        Me.lstStudcmCS.TabIndex = 41
        Me.lstStudcmCS.UseSelectable = True
        Me.lstStudcmCS.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(151, 96)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel5.TabIndex = 40
        Me.MetroLabel5.Text = "College/School"
        Me.MetroLabel5.Visible = False
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "ceuratingforms.Report5.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(82, 91)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(769, 458)
        Me.ReportViewer2.TabIndex = 42
        '
        'LScmbYG
        '
        Me.LScmbYG.FormattingEnabled = True
        Me.LScmbYG.ItemHeight = 23
        Me.LScmbYG.Location = New System.Drawing.Point(650, 50)
        Me.LScmbYG.Name = "LScmbYG"
        Me.LScmbYG.Size = New System.Drawing.Size(155, 29)
        Me.LScmbYG.TabIndex = 38
        Me.LScmbYG.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(525, 56)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel4.TabIndex = 37
        Me.MetroLabel4.Text = "Year of Graduation"
        '
        'LScmbFilter
        '
        Me.LScmbFilter.FormattingEnabled = True
        Me.LScmbFilter.ItemHeight = 23
        Me.LScmbFilter.Items.AddRange(New Object() {"University-Wide", "College/School-Wide"})
        Me.LScmbFilter.Location = New System.Drawing.Point(123, 56)
        Me.LScmbFilter.Name = "LScmbFilter"
        Me.LScmbFilter.Size = New System.Drawing.Size(267, 29)
        Me.LScmbFilter.TabIndex = 36
        Me.LScmbFilter.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(66, 59)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel1.TabIndex = 35
        Me.MetroLabel1.Text = "Filter"
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Location = New System.Drawing.Point(695, 555)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(75, 75)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 39
        Me.tilHome.Text = "Back"
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_arrow_back_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroTile1.Location = New System.Drawing.Point(776, 555)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(75, 75)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroTile1.TabIndex = 53
        Me.MetroTile1.Text = "Home"
        Me.MetroTile1.TileImage = Global.SAOProject.My.Resources.Resources.ic_home_white_48dp_1x
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'rfUniColPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 684)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lstStudcmCS)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.LScmbYG)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.LScmbFilter)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "rfUniColPrint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstStudcmCS As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents LScmbYG As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LScmbFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
End Class
