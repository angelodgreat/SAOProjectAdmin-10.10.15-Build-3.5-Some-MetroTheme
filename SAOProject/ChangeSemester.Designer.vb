<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeSemester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeSemester))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_loadSCYS = New System.Windows.Forms.Button()
        Me.btn_deleteSCYS = New System.Windows.Forms.Button()
        Me.btn_createSCYS = New System.Windows.Forms.Button()
        Me.cb_selectyearndsem = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_loadSCYS)
        Me.GroupBox1.Controls.Add(Me.btn_deleteSCYS)
        Me.GroupBox1.Controls.Add(Me.btn_createSCYS)
        Me.GroupBox1.Controls.Add(Me.cb_selectyearndsem)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 110)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'btn_loadSCYS
        '
        Me.btn_loadSCYS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_loadSCYS.Location = New System.Drawing.Point(6, 63)
        Me.btn_loadSCYS.Name = "btn_loadSCYS"
        Me.btn_loadSCYS.Size = New System.Drawing.Size(75, 32)
        Me.btn_loadSCYS.TabIndex = 4
        Me.btn_loadSCYS.Text = "Load"
        Me.btn_loadSCYS.UseVisualStyleBackColor = True
        '
        'btn_deleteSCYS
        '
        Me.btn_deleteSCYS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_deleteSCYS.Location = New System.Drawing.Point(87, 63)
        Me.btn_deleteSCYS.Name = "btn_deleteSCYS"
        Me.btn_deleteSCYS.Size = New System.Drawing.Size(75, 32)
        Me.btn_deleteSCYS.TabIndex = 3
        Me.btn_deleteSCYS.Text = "Delete"
        Me.btn_deleteSCYS.UseVisualStyleBackColor = True
        '
        'btn_createSCYS
        '
        Me.btn_createSCYS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_createSCYS.Location = New System.Drawing.Point(190, 63)
        Me.btn_createSCYS.Name = "btn_createSCYS"
        Me.btn_createSCYS.Size = New System.Drawing.Size(75, 32)
        Me.btn_createSCYS.TabIndex = 2
        Me.btn_createSCYS.Text = "Create"
        Me.btn_createSCYS.UseVisualStyleBackColor = True
        '
        'cb_selectyearndsem
        '
        Me.cb_selectyearndsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_selectyearndsem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_selectyearndsem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cb_selectyearndsem.FormattingEnabled = True
        Me.cb_selectyearndsem.Items.AddRange(New Object() {"2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "2022-2023", "2023-2024"})
        Me.cb_selectyearndsem.Location = New System.Drawing.Point(6, 22)
        Me.cb_selectyearndsem.Name = "cb_selectyearndsem"
        Me.cb_selectyearndsem.Size = New System.Drawing.Size(259, 23)
        Me.cb_selectyearndsem.TabIndex = 1
        '
        'ChangeSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 207)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeSemester"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "School Year"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_loadSCYS As Button
    Friend WithEvents btn_deleteSCYS As Button
    Friend WithEvents btn_createSCYS As Button
    Friend WithEvents cb_selectyearndsem As ComboBox
End Class
