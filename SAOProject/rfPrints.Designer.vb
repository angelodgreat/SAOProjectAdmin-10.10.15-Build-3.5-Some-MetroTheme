<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfPrints
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tilAll = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.tilStudents = New MetroFramework.Controls.MetroTile()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(250, 289)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "©Remos, Mahealani Joy G."
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tilAll
        '
        Me.tilAll.ActiveControl = Nothing
        Me.tilAll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilAll.Location = New System.Drawing.Point(441, 118)
        Me.tilAll.Name = "tilAll"
        Me.tilAll.Size = New System.Drawing.Size(110, 110)
        Me.tilAll.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilAll.TabIndex = 31
        Me.tilAll.Text = "All/College/School"
        Me.tilAll.TileImage = Global.SAOProject.My.Resources.Resources.ic_people_white_48dp_1x
        Me.tilAll.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilAll.UseSelectable = True
        Me.tilAll.UseTileImage = True
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilHome.Location = New System.Drawing.Point(209, 118)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(110, 110)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 32
        Me.tilHome.Text = "Home"
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_home_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'tilStudents
        '
        Me.tilStudents.ActiveControl = Nothing
        Me.tilStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilStudents.Location = New System.Drawing.Point(325, 118)
        Me.tilStudents.Name = "tilStudents"
        Me.tilStudents.Size = New System.Drawing.Size(110, 110)
        Me.tilStudents.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilStudents.TabIndex = 30
        Me.tilStudents.Text = "Student"
        Me.tilStudents.TileImage = Global.SAOProject.My.Resources.Resources.ic_school_white_48dp_1x
        Me.tilStudents.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilStudents.UseSelectable = True
        Me.tilStudents.UseTileImage = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(583, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(99, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(193, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(374, 66)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office"
        '
        'rfPrints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(760, 318)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.tilAll)
        Me.Controls.Add(Me.tilStudents)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "rfPrints"
        Me.Text = "CEU-SAO Rating Forms Management System"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents tilAll As MetroFramework.Controls.MetroTile
    Friend WithEvents tilStudents As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label25 As Label
End Class
