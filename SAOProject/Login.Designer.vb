<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.label_status = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mbtn_bypass = New MetroFramework.Controls.MetroButton()
        Me.tb_password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tb_username = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_time_login = New System.Windows.Forms.Label()
        Me.Timer_Login = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ml_minimize = New MetroFramework.Controls.MetroLink()
        Me.ml_exit = New MetroFramework.Controls.MetroLink()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_status
        '
        Me.label_status.AutoSize = True
        Me.label_status.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label_status.Location = New System.Drawing.Point(455, 326)
        Me.label_status.Name = "label_status"
        Me.label_status.Size = New System.Drawing.Size(42, 15)
        Me.label_status.TabIndex = 7
        Me.label_status.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mbtn_bypass)
        Me.GroupBox1.Controls.Add(Me.tb_password)
        Me.GroupBox1.Controls.Add(Me.tb_username)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 185)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'mbtn_bypass
        '
        Me.mbtn_bypass.Location = New System.Drawing.Point(64, 156)
        Me.mbtn_bypass.Name = "mbtn_bypass"
        Me.mbtn_bypass.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_bypass.TabIndex = 12
        Me.mbtn_bypass.Text = "Bypass"
        Me.mbtn_bypass.UseSelectable = True
        '
        'tb_password
        '
        '
        '
        '
        Me.tb_password.Border.Class = "TextBoxBorder"
        Me.tb_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_password.Location = New System.Drawing.Point(9, 112)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.PreventEnterBeep = True
        Me.tb_password.Size = New System.Drawing.Size(211, 23)
        Me.tb_password.TabIndex = 11
        Me.tb_password.WatermarkText = "Password"
        '
        'tb_username
        '
        '
        '
        '
        Me.tb_username.Border.Class = "TextBoxBorder"
        Me.tb_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_username.Location = New System.Drawing.Point(9, 58)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PreventEnterBeep = True
        Me.tb_username.Size = New System.Drawing.Size(211, 23)
        Me.tb_username.TabIndex = 10
        Me.tb_username.WatermarkText = "Username/00-00000"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(145, 156)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Log-in"
        Me.MetroButton1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_time_login
        '
        Me.lbl_time_login.AutoSize = True
        Me.lbl_time_login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_time_login.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_time_login.Location = New System.Drawing.Point(25, 326)
        Me.lbl_time_login.Name = "lbl_time_login"
        Me.lbl_time_login.Size = New System.Drawing.Size(34, 15)
        Me.lbl_time_login.TabIndex = 10
        Me.lbl_time_login.Text = "Date"
        '
        'Timer_Login
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SAOProject.My.Resources.Resources.ceu
        Me.PictureBox1.Location = New System.Drawing.Point(23, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Welcome to CEU-SAO Consolidated Calendar System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ml_minimize
        '
        Me.ml_minimize.Image = CType(resources.GetObject("ml_minimize.Image"), System.Drawing.Image)
        Me.ml_minimize.ImageSize = 32
        Me.ml_minimize.Location = New System.Drawing.Point(438, 6)
        Me.ml_minimize.Name = "ml_minimize"
        Me.ml_minimize.Size = New System.Drawing.Size(41, 39)
        Me.ml_minimize.TabIndex = 90
        Me.ml_minimize.UseSelectable = True
        '
        'ml_exit
        '
        Me.ml_exit.Image = CType(resources.GetObject("ml_exit.Image"), System.Drawing.Image)
        Me.ml_exit.ImageSize = 32
        Me.ml_exit.Location = New System.Drawing.Point(481, 6)
        Me.ml_exit.Name = "ml_exit"
        Me.ml_exit.Size = New System.Drawing.Size(41, 39)
        Me.ml_exit.TabIndex = 89
        Me.ml_exit.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.ImageSize = 32
        Me.MetroLink1.Location = New System.Drawing.Point(5, 6)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.NoFocusImage = CType(resources.GetObject("MetroLink1.NoFocusImage"), System.Drawing.Image)
        Me.MetroLink1.Size = New System.Drawing.Size(83, 39)
        Me.MetroLink1.TabIndex = 91
        Me.MetroLink1.Text = "Restart"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLink1.UseSelectable = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(520, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.ml_minimize)
        Me.Controls.Add(Me.ml_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_time_login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_status)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_status As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_time_login As Label
    Friend WithEvents Timer_Login As Timer
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ml_minimize As MetroFramework.Controls.MetroLink
    Friend WithEvents ml_exit As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents mbtn_bypass As MetroFramework.Controls.MetroButton
    Private WithEvents tb_password As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents tb_username As DevComponents.DotNetBar.Controls.TextBoxX
End Class
