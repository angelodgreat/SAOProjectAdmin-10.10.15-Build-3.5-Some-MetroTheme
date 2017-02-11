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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.tilStudents = New MetroFramework.Controls.MetroTile()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(248, 236)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "©BSIT3A 2016"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tilAll
        '
        Me.tilAll.ActiveControl = Nothing
        Me.tilAll.Location = New System.Drawing.Point(441, 108)
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
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(294, 38)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(172, 25)
        Me.MetroLabel2.TabIndex = 28
        Me.MetroLabel2.Text = "Student Affairs Office"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Location = New System.Drawing.Point(209, 108)
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
        Me.tilStudents.Location = New System.Drawing.Point(325, 108)
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
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(516, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(168, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'rfPrints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(760, 261)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.tilAll)
        Me.Controls.Add(Me.tilStudents)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "rfPrints"
        Me.Text = "Student Affairs Office Rating Forms"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents tilAll As MetroFramework.Controls.MetroTile
    Friend WithEvents tilStudents As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
