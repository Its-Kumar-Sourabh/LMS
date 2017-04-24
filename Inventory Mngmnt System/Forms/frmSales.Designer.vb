<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_sale = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_register = New System.Windows.Forms.Button
        Me.cbbx_cid = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbbx_id = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.txt_noofproduct = New System.Windows.Forms.TextBox
        Me.txt_mrp = New System.Windows.Forms.TextBox
        Me.txt_costprice = New System.Windows.Forms.TextBox
        Me.txt_category = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(17, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(11, 92)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(109, 57)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 116
        Me.PictureBox8.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(138, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 40)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Click on 'Add' to add new and 'Edit' to modify current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "record.After completing " & _
            "click 'Save' to save record."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(108, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 42)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_cancel)
        Me.GroupBox2.Controls.Add(Me.btn_sale)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_register)
        Me.GroupBox2.Controls.Add(Me.cbbx_cid)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cbbx_id)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.txt_noofproduct)
        Me.GroupBox2.Controls.Add(Me.txt_mrp)
        Me.GroupBox2.Controls.Add(Me.txt_costprice)
        Me.GroupBox2.Controls.Add(Me.txt_category)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 256)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Coral
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cancel.Location = New System.Drawing.Point(495, 182)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(94, 52)
        Me.btn_cancel.TabIndex = 112
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_sale
        '
        Me.btn_sale.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_sale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_sale.Location = New System.Drawing.Point(369, 182)
        Me.btn_sale.Name = "btn_sale"
        Me.btn_sale.Size = New System.Drawing.Size(120, 52)
        Me.btn_sale.TabIndex = 111
        Me.btn_sale.Text = "Sale"
        Me.btn_sale.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(403, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 40)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "If New Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Add Here"""
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_register.Location = New System.Drawing.Point(369, 120)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(220, 52)
        Me.btn_register.TabIndex = 109
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'cbbx_cid
        '
        Me.cbbx_cid.FormattingEnabled = True
        Me.cbbx_cid.Location = New System.Drawing.Point(391, 25)
        Me.cbbx_cid.Name = "cbbx_cid"
        Me.cbbx_cid.Size = New System.Drawing.Size(185, 21)
        Me.cbbx_cid.TabIndex = 108
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(338, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 20)
        Me.Label19.TabIndex = 107
        Me.Label19.Text = "C_Id"
        '
        'cbbx_id
        '
        Me.cbbx_id.FormattingEnabled = True
        Me.cbbx_id.Location = New System.Drawing.Point(148, 25)
        Me.cbbx_id.Name = "cbbx_id"
        Me.cbbx_id.Size = New System.Drawing.Size(156, 21)
        Me.cbbx_id.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(65, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(1, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "No. of Product"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(28, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "MRP Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(30, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Cost Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(36, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Product ID"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(148, 214)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(156, 20)
        Me.txt_total.TabIndex = 36
        '
        'txt_noofproduct
        '
        Me.txt_noofproduct.Location = New System.Drawing.Point(148, 176)
        Me.txt_noofproduct.Name = "txt_noofproduct"
        Me.txt_noofproduct.Size = New System.Drawing.Size(156, 20)
        Me.txt_noofproduct.TabIndex = 35
        '
        'txt_mrp
        '
        Me.txt_mrp.Location = New System.Drawing.Point(148, 139)
        Me.txt_mrp.Name = "txt_mrp"
        Me.txt_mrp.Size = New System.Drawing.Size(156, 20)
        Me.txt_mrp.TabIndex = 34
        '
        'txt_costprice
        '
        Me.txt_costprice.Location = New System.Drawing.Point(148, 100)
        Me.txt_costprice.Name = "txt_costprice"
        Me.txt_costprice.Size = New System.Drawing.Size(156, 20)
        Me.txt_costprice.TabIndex = 33
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(148, 62)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(156, 20)
        Me.txt_category.TabIndex = 32
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(649, 419)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSales"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbx_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_noofproduct As System.Windows.Forms.TextBox
    Friend WithEvents txt_mrp As System.Windows.Forms.TextBox
    Friend WithEvents txt_costprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_category As System.Windows.Forms.TextBox
    Friend WithEvents cbbx_cid As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_register As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_sale As System.Windows.Forms.Button
End Class
