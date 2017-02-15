<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfPoints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfPoints))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtNum = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtRemarks = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtPoints = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tilVForms = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.tilAdd = New MetroFramework.Controls.MetroTile()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 111)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Award"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.Location = New System.Drawing.Point(181, 402)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel11.TabIndex = 41
        Me.MetroLabel11.Text = "©BSIT3A 2016"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum
        '
        '
        '
        '
        Me.txtNum.CustomButton.Image = Nothing
        Me.txtNum.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.txtNum.CustomButton.Name = ""
        Me.txtNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNum.CustomButton.TabIndex = 1
        Me.txtNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNum.CustomButton.UseSelectable = True
        Me.txtNum.CustomButton.Visible = False
        Me.txtNum.Lines = New String(-1) {}
        Me.txtNum.Location = New System.Drawing.Point(101, 24)
        Me.txtNum.MaxLength = 32767
        Me.txtNum.Name = "txtNum"
        Me.txtNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNum.SelectedText = ""
        Me.txtNum.SelectionLength = 0
        Me.txtNum.SelectionStart = 0
        Me.txtNum.ShortcutsEnabled = True
        Me.txtNum.Size = New System.Drawing.Size(146, 23)
        Me.txtNum.TabIndex = 7
        Me.txtNum.UseSelectable = True
        Me.txtNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 24)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Student No."
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.txtNum)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.txtRemarks)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtPoints)
        Me.MetroPanel1.Controls.Add(Me.txtName)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(179, 230)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(264, 160)
        Me.MetroPanel1.TabIndex = 38
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtRemarks
        '
        '
        '
        '
        Me.txtRemarks.CustomButton.Image = Nothing
        Me.txtRemarks.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.txtRemarks.CustomButton.Name = ""
        Me.txtRemarks.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRemarks.CustomButton.TabIndex = 1
        Me.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRemarks.CustomButton.UseSelectable = True
        Me.txtRemarks.CustomButton.Visible = False
        Me.txtRemarks.Lines = New String(-1) {}
        Me.txtRemarks.Location = New System.Drawing.Point(101, 111)
        Me.txtRemarks.MaxLength = 32767
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.SelectionLength = 0
        Me.txtRemarks.SelectionStart = 0
        Me.txtRemarks.ShortcutsEnabled = True
        Me.txtRemarks.Size = New System.Drawing.Size(146, 23)
        Me.txtRemarks.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.UseSelectable = True
        Me.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRemarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 81)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Points"
        '
        'txtPoints
        '
        '
        '
        '
        Me.txtPoints.CustomButton.Image = Nothing
        Me.txtPoints.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.txtPoints.CustomButton.Name = ""
        Me.txtPoints.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPoints.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoints.CustomButton.TabIndex = 1
        Me.txtPoints.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoints.CustomButton.UseSelectable = True
        Me.txtPoints.CustomButton.Visible = False
        Me.txtPoints.Lines = New String(-1) {}
        Me.txtPoints.Location = New System.Drawing.Point(101, 81)
        Me.txtPoints.MaxLength = 32767
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoints.ReadOnly = True
        Me.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoints.SelectedText = ""
        Me.txtPoints.SelectionLength = 0
        Me.txtPoints.SelectionStart = 0
        Me.txtPoints.ShortcutsEnabled = True
        Me.txtPoints.Size = New System.Drawing.Size(146, 23)
        Me.txtPoints.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtPoints.TabIndex = 2
        Me.txtPoints.UseSelectable = True
        Me.txtPoints.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPoints.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(101, 52)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ReadOnly = True
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(146, 23)
        Me.txtName.Style = MetroFramework.MetroColorStyle.Pink
        Me.txtName.TabIndex = 1
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 52)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(531, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(38, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'tilVForms
        '
        Me.tilVForms.ActiveControl = Nothing
        Me.tilVForms.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilVForms.Location = New System.Drawing.Point(195, 129)
        Me.tilVForms.Name = "tilVForms"
        Me.tilVForms.Size = New System.Drawing.Size(75, 75)
        Me.tilVForms.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilVForms.TabIndex = 44
        Me.tilVForms.Text = "View"
        Me.tilVForms.TileImage = Global.SAOProject.My.Resources.Resources.ic_description_white_48dp_1x
        Me.tilVForms.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilVForms.UseSelectable = True
        Me.tilVForms.UseTileImage = True
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tilHome.Location = New System.Drawing.Point(357, 129)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(75, 75)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 40
        Me.tilHome.Text = "Home"
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_home_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'tilAdd
        '
        Me.tilAdd.ActiveControl = Nothing
        Me.tilAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilAdd.Location = New System.Drawing.Point(276, 129)
        Me.tilAdd.Name = "tilAdd"
        Me.tilAdd.Size = New System.Drawing.Size(75, 75)
        Me.tilAdd.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilAdd.TabIndex = 39
        Me.tilAdd.Text = "Add"
        Me.tilAdd.TileImage = Global.SAOProject.My.Resources.Resources.ic_note_add_white_48dp_1x
        Me.tilAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilAdd.UseSelectable = True
        Me.tilAdd.UseTileImage = True
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(140, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(374, 66)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office"
        '
        'rfPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(647, 448)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tilVForms)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.tilAdd)
        Me.Name = "rfPoints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Affairs Office Rating Forms"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents tilVForms As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtRemarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPoints As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents tilAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents Label25 As Label
End Class
