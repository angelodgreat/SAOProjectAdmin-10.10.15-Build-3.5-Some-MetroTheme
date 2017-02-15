<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfAdminHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfAdminHome))
        Me.lnkNotif = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tilList = New MetroFramework.Controls.MetroTile()
        Me.tilHome = New MetroFramework.Controls.MetroTile()
        Me.tilStudents = New MetroFramework.Controls.MetroTile()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrDay = New System.Windows.Forms.Timer(Me.components)
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkNotif
        '
        Me.lnkNotif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkNotif.Location = New System.Drawing.Point(218, 192)
        Me.lnkNotif.Name = "lnkNotif"
        Me.lnkNotif.Size = New System.Drawing.Size(357, 23)
        Me.lnkNotif.Style = MetroFramework.MetroColorStyle.Pink
        Me.lnkNotif.TabIndex = 38
        Me.lnkNotif.Text = "Notification"
        Me.lnkNotif.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel1.BackColor = System.Drawing.Color.LightPink
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.lblUsername)
        Me.MetroPanel1.Controls.Add(Me.lblTime)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(218, 122)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(357, 31)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroPanel1.TabIndex = 36
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(3, 5)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(64, 19)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.Text = "Welcome"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(259, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 19)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(257, 411)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(260, 20)
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "©BSIT3A 2016"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(305, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(172, 25)
        Me.MetroLabel2.TabIndex = 31
        Me.MetroLabel2.Text = "Student Affairs Office"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(551, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'tilList
        '
        Me.tilList.ActiveControl = Nothing
        Me.tilList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilList.Location = New System.Drawing.Point(334, 227)
        Me.tilList.Name = "tilList"
        Me.tilList.Size = New System.Drawing.Size(110, 110)
        Me.tilList.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilList.TabIndex = 37
        Me.tilList.Text = "Reports"
        Me.tilList.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tilList.TileImage = Global.SAOProject.My.Resources.Resources.ic_description_white_48dp_1x1
        Me.tilList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilList.UseSelectable = True
        Me.tilList.UseTileImage = True
        '
        'tilHome
        '
        Me.tilHome.ActiveControl = Nothing
        Me.tilHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilHome.Location = New System.Drawing.Point(450, 227)
        Me.tilHome.Name = "tilHome"
        Me.tilHome.Size = New System.Drawing.Size(110, 110)
        Me.tilHome.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilHome.TabIndex = 35
        Me.tilHome.Text = "Back"
        Me.tilHome.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tilHome.TileImage = Global.SAOProject.My.Resources.Resources.ic_arrow_back_white_48dp_1x
        Me.tilHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilHome.UseSelectable = True
        Me.tilHome.UseTileImage = True
        '
        'tilStudents
        '
        Me.tilStudents.ActiveControl = Nothing
        Me.tilStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tilStudents.Location = New System.Drawing.Point(218, 227)
        Me.tilStudents.Name = "tilStudents"
        Me.tilStudents.Size = New System.Drawing.Size(110, 110)
        Me.tilStudents.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilStudents.TabIndex = 34
        Me.tilStudents.Text = "Students"
        Me.tilStudents.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tilStudents.TileImage = CType(resources.GetObject("tilStudents.TileImage"), System.Drawing.Image)
        Me.tilStudents.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilStudents.UseSelectable = True
        Me.tilStudents.UseTileImage = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(134, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'tmrDay
        '
        '
        'rfAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(757, 451)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lnkNotif)
        Me.Controls.Add(Me.tilList)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.tilHome)
        Me.Controls.Add(Me.tilStudents)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "rfAdminHome"
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
    Friend WithEvents lnkNotif As MetroFramework.Controls.MetroLink
    Friend WithEvents tilList As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents tilHome As MetroFramework.Controls.MetroTile
    Friend WithEvents tilStudents As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tmrDay As Timer
End Class
