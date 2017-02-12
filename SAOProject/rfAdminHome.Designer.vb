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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfAdminHome))
        Me.lnkNotif = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tilList = New MetroFramework.Controls.MetroTile()
        Me.tilBack = New MetroFramework.Controls.MetroTile()
        Me.tilStudents = New MetroFramework.Controls.MetroTile()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkNotif
        '
        Me.lnkNotif.Location = New System.Drawing.Point(225, 215)
        Me.lnkNotif.Name = "lnkNotif"
        Me.lnkNotif.Size = New System.Drawing.Size(357, 23)
        Me.lnkNotif.Style = MetroFramework.MetroColorStyle.Pink
        Me.lnkNotif.TabIndex = 38
        Me.lnkNotif.Text = "Notification"
        Me.lnkNotif.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.BackColor = System.Drawing.Color.LightPink
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.lblUsername)
        Me.MetroPanel1.Controls.Add(Me.lblTime)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(225, 133)
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
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox2.Location = New System.Drawing.Point(602, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'tilList
        '
        Me.tilList.ActiveControl = Nothing
        Me.tilList.Location = New System.Drawing.Point(348, 262)
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
        'tilBack
        '
        Me.tilBack.ActiveControl = Nothing
        Me.tilBack.Location = New System.Drawing.Point(472, 262)
        Me.tilBack.Name = "tilBack"
        Me.tilBack.Size = New System.Drawing.Size(110, 110)
        Me.tilBack.Style = MetroFramework.MetroColorStyle.Pink
        Me.tilBack.TabIndex = 35
        Me.tilBack.Text = "Back"
        Me.tilBack.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tilBack.TileImage = Global.SAOProject.My.Resources.Resources.ic_arrow_back_white_48dp_1x
        Me.tilBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tilBack.UseSelectable = True
        Me.tilBack.UseTileImage = True
        '
        'tilStudents
        '
        Me.tilStudents.ActiveControl = Nothing
        Me.tilStudents.Location = New System.Drawing.Point(225, 262)
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
        Me.PictureBox1.Location = New System.Drawing.Point(93, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(208, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(374, 66)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(686, 495)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 41
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'rfAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(765, 493)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lnkNotif)
        Me.Controls.Add(Me.tilList)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.tilBack)
        Me.Controls.Add(Me.tilStudents)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "rfAdminHome"
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
    Friend WithEvents tilBack As MetroFramework.Controls.MetroTile
    Friend WithEvents tilStudents As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
