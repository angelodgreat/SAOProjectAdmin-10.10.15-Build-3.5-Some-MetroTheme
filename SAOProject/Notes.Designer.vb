<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notes

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notes))
        Me.tb_reminder = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btn_clear_reminder = New System.Windows.Forms.Button()
        Me.btn_delete_reminder = New System.Windows.Forms.Button()
        Me.btn_update_reminder = New System.Windows.Forms.Button()
        Me.btn_submit_reminder = New System.Windows.Forms.Button()
        Me.dtp_reminder = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.rtb_reminder = New System.Windows.Forms.RichTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_reminder
        '
        Me.tb_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tb_reminder.Location = New System.Drawing.Point(125, 163)
        Me.tb_reminder.Name = "tb_reminder"
        Me.tb_reminder.Size = New System.Drawing.Size(144, 23)
        Me.tb_reminder.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label35.Location = New System.Drawing.Point(70, 170)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 15)
        Me.Label35.TabIndex = 49
        Me.Label35.Text = "Note#:"
        '
        'btn_clear_reminder
        '
        Me.btn_clear_reminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_clear_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_clear_reminder.Location = New System.Drawing.Point(336, 340)
        Me.btn_clear_reminder.Name = "btn_clear_reminder"
        Me.btn_clear_reminder.Size = New System.Drawing.Size(74, 34)
        Me.btn_clear_reminder.TabIndex = 7
        Me.btn_clear_reminder.Text = "Clear"
        Me.btn_clear_reminder.UseVisualStyleBackColor = True
        '
        'btn_delete_reminder
        '
        Me.btn_delete_reminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_delete_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete_reminder.Location = New System.Drawing.Point(416, 340)
        Me.btn_delete_reminder.Name = "btn_delete_reminder"
        Me.btn_delete_reminder.Size = New System.Drawing.Size(74, 34)
        Me.btn_delete_reminder.TabIndex = 6
        Me.btn_delete_reminder.Text = "Delete"
        Me.btn_delete_reminder.UseVisualStyleBackColor = True
        '
        'btn_update_reminder
        '
        Me.btn_update_reminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_update_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update_reminder.Location = New System.Drawing.Point(496, 340)
        Me.btn_update_reminder.Name = "btn_update_reminder"
        Me.btn_update_reminder.Size = New System.Drawing.Size(74, 34)
        Me.btn_update_reminder.TabIndex = 5
        Me.btn_update_reminder.Text = "Update"
        Me.btn_update_reminder.UseVisualStyleBackColor = True
        '
        'btn_submit_reminder
        '
        Me.btn_submit_reminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_submit_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_submit_reminder.Location = New System.Drawing.Point(125, 340)
        Me.btn_submit_reminder.Name = "btn_submit_reminder"
        Me.btn_submit_reminder.Size = New System.Drawing.Size(74, 34)
        Me.btn_submit_reminder.TabIndex = 4
        Me.btn_submit_reminder.Text = "Save"
        Me.btn_submit_reminder.UseVisualStyleBackColor = True
        '
        'dtp_reminder
        '
        Me.dtp_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_reminder.Location = New System.Drawing.Point(125, 198)
        Me.dtp_reminder.Name = "dtp_reminder"
        Me.dtp_reminder.Size = New System.Drawing.Size(336, 23)
        Me.dtp_reminder.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(79, 238)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 15)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "Note:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(79, 204)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 15)
        Me.Label30.TabIndex = 41
        Me.Label30.Text = "Date:"
        '
        'rtb_reminder
        '
        Me.rtb_reminder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rtb_reminder.Location = New System.Drawing.Point(125, 238)
        Me.rtb_reminder.Name = "rtb_reminder"
        Me.rtb_reminder.Size = New System.Drawing.Size(445, 96)
        Me.rtb_reminder.TabIndex = 3
        Me.rtb_reminder.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(141, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(374, 99)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = " Centro Escolar University " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Student Affairs Office" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Mendiola, Manila"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.SAOProject.My.Resources.Resources.fff_CROP_RES_
        Me.PictureBox9.Location = New System.Drawing.Point(521, 33)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox9.TabIndex = 52
        Me.PictureBox9.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SAOProject.My.Resources.Resources.oie_transparent
        Me.PictureBox4.Location = New System.Drawing.Point(35, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 386)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.tb_reminder)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.btn_clear_reminder)
        Me.Controls.Add(Me.btn_delete_reminder)
        Me.Controls.Add(Me.btn_update_reminder)
        Me.Controls.Add(Me.btn_submit_reminder)
        Me.Controls.Add(Me.dtp_reminder)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.rtb_reminder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notes"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.TopMost = True
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_reminder As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_clear_reminder As Button
    Friend WithEvents btn_delete_reminder As Button
    Friend WithEvents btn_update_reminder As Button
    Friend WithEvents btn_submit_reminder As Button
    Friend WithEvents dtp_reminder As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents rtb_reminder As RichTextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label29 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
