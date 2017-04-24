<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbbx_id = New System.Windows.Forms.ComboBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(104, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(129, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Category ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(246, 62)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(223, 20)
        Me.txt_name.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cbbx_id)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_name)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 105)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        '
        'cbbx_id
        '
        Me.cbbx_id.FormattingEnabled = True
        Me.cbbx_id.Location = New System.Drawing.Point(246, 21)
        Me.cbbx_id.Name = "cbbx_id"
        Me.cbbx_id.Size = New System.Drawing.Size(223, 21)
        Me.cbbx_id.TabIndex = 40
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(6, 89)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(109, 57)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 121
        Me.PictureBox8.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(125, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 40)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Click on 'Add' to add new and 'Edit' to modify current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "record.After completing " & _
            "click 'Save' to save record."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(95, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 42)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 79)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(480, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = " Close   "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(403, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 18)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Cancel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(320, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 18)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "  Save   "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(194, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Delete"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(111, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 18)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = " Edit   "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(17, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 18)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "  Add"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(473, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 39)
        Me.Button6.TabIndex = 15
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_delete.Location = New System.Drawing.Point(183, 16)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(66, 40)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_edit.Location = New System.Drawing.Point(98, 16)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(66, 40)
        Me.btn_edit.TabIndex = 12
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cancel.Location = New System.Drawing.Point(393, 16)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(66, 39)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_add.Location = New System.Drawing.Point(11, 16)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(63, 40)
        Me.btn_add.TabIndex = 3
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_save.Location = New System.Drawing.Point(311, 16)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 39)
        Me.btn_save.TabIndex = 4
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(598, 354)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmCategory"
        Me.Text = "Category"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents cbbx_id As System.Windows.Forms.ComboBox
End Class
