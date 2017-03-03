<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DBSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBSettings))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mb_savesettings = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_setpassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tb_setusername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tb_setport = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tb_setDB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tb_setserver = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(50, 36)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel1.TabIndex = 16
        Me.MetroLabel1.Text = "&Server:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(35, 75)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 17
        Me.MetroLabel2.Text = "&Database:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(64, 112)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel3.TabIndex = 18
        Me.MetroLabel3.Text = "&Port:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(30, 150)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 19
        Me.MetroLabel4.Text = "&Username:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(35, 184)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel5.TabIndex = 20
        Me.MetroLabel5.Text = "&Password:"
        '
        'mb_savesettings
        '
        Me.mb_savesettings.Location = New System.Drawing.Point(98, 231)
        Me.mb_savesettings.Name = "mb_savesettings"
        Me.mb_savesettings.Size = New System.Drawing.Size(75, 23)
        Me.mb_savesettings.TabIndex = 21
        Me.mb_savesettings.Text = "Save"
        Me.mb_savesettings.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(203, 231)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(108, 23)
        Me.MetroButton1.TabIndex = 22
        Me.MetroButton1.Text = "Continue to Login"
        Me.MetroButton1.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_setpassword)
        Me.GroupBox1.Controls.Add(Me.tb_setusername)
        Me.GroupBox1.Controls.Add(Me.tb_setport)
        Me.GroupBox1.Controls.Add(Me.tb_setDB)
        Me.GroupBox1.Controls.Add(Me.tb_setserver)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.mb_savesettings)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tb_setpassword
        '
        '
        '
        '
        Me.tb_setpassword.Border.Class = "TextBoxBorder"
        Me.tb_setpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_setpassword.Location = New System.Drawing.Point(107, 179)
        Me.tb_setpassword.Name = "tb_setpassword"
        Me.tb_setpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_setpassword.PreventEnterBeep = True
        Me.tb_setpassword.Size = New System.Drawing.Size(228, 24)
        Me.tb_setpassword.TabIndex = 27
        Me.tb_setpassword.WatermarkText = "dbpassword"
        '
        'tb_setusername
        '
        '
        '
        '
        Me.tb_setusername.Border.Class = "TextBoxBorder"
        Me.tb_setusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_setusername.Location = New System.Drawing.Point(107, 145)
        Me.tb_setusername.Name = "tb_setusername"
        Me.tb_setusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_setusername.PreventEnterBeep = True
        Me.tb_setusername.Size = New System.Drawing.Size(228, 24)
        Me.tb_setusername.TabIndex = 26
        Me.tb_setusername.WatermarkText = "dbusername"
        '
        'tb_setport
        '
        '
        '
        '
        Me.tb_setport.Border.Class = "TextBoxBorder"
        Me.tb_setport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_setport.Location = New System.Drawing.Point(107, 107)
        Me.tb_setport.Name = "tb_setport"
        Me.tb_setport.PreventEnterBeep = True
        Me.tb_setport.Size = New System.Drawing.Size(228, 24)
        Me.tb_setport.TabIndex = 25
        Me.tb_setport.WatermarkText = "3306"
        '
        'tb_setDB
        '
        '
        '
        '
        Me.tb_setDB.Border.Class = "TextBoxBorder"
        Me.tb_setDB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_setDB.Location = New System.Drawing.Point(107, 70)
        Me.tb_setDB.Name = "tb_setDB"
        Me.tb_setDB.PreventEnterBeep = True
        Me.tb_setDB.Size = New System.Drawing.Size(228, 24)
        Me.tb_setDB.TabIndex = 24
        Me.tb_setDB.WatermarkText = "saoinfo"
        '
        'tb_setserver
        '
        '
        '
        '
        Me.tb_setserver.Border.Class = "TextBoxBorder"
        Me.tb_setserver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tb_setserver.Location = New System.Drawing.Point(107, 31)
        Me.tb_setserver.Name = "tb_setserver"
        Me.tb_setserver.PreventEnterBeep = True
        Me.tb_setserver.Size = New System.Drawing.Size(228, 24)
        Me.tb_setserver.TabIndex = 23
        Me.tb_setserver.WatermarkText = "localhost"
        '
        'DBSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 368)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DBSettings"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "&Database Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mb_savesettings As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_setpassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tb_setusername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tb_setport As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tb_setDB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tb_setserver As DevComponents.DotNetBar.Controls.TextBoxX
End Class
