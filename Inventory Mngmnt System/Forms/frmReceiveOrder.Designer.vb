<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiveOrder))
        Me.txt_costprice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_category = New System.Windows.Forms.TextBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.txt_pname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_mrp = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbx_id = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_supplier = New System.Windows.Forms.TextBox
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_receive = New System.Windows.Forms.Button
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.txt_noofproduct = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_costprice
        '
        Me.txt_costprice.Location = New System.Drawing.Point(138, 167)
        Me.txt_costprice.Name = "txt_costprice"
        Me.txt_costprice.Size = New System.Drawing.Size(166, 20)
        Me.txt_costprice.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Broadway", 27.75!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(107, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 42)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Order Receive"
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(138, 99)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(166, 20)
        Me.txt_category.TabIndex = 32
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox7.Location = New System.Drawing.Point(591, 10)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(49, 44)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 117
        Me.PictureBox7.TabStop = False
        '
        'txt_pname
        '
        Me.txt_pname.Location = New System.Drawing.Point(138, 62)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.Size = New System.Drawing.Size(166, 20)
        Me.txt_pname.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(344, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "MRP Price"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(10, 87)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(109, 57)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 119
        Me.PictureBox8.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(122, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(347, 17)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Click on 'Receive' to receive the order"
        '
        'txt_mrp
        '
        Me.txt_mrp.Location = New System.Drawing.Point(464, 25)
        Me.txt_mrp.Name = "txt_mrp"
        Me.txt_mrp.Size = New System.Drawing.Size(156, 20)
        Me.txt_mrp.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(321, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 17)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "No. of Product"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(28, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Cost Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(36, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Product ID"
        '
        'cbbx_id
        '
        Me.cbbx_id.FormattingEnabled = True
        Me.cbbx_id.Location = New System.Drawing.Point(138, 25)
        Me.cbbx_id.Name = "cbbx_id"
        Me.cbbx_id.Size = New System.Drawing.Size(166, 21)
        Me.cbbx_id.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(399, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_supplier)
        Me.GroupBox2.Controls.Add(Me.btn_cancel)
        Me.GroupBox2.Controls.Add(Me.btn_receive)
        Me.GroupBox2.Controls.Add(Me.cbbx_id)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.txt_noofproduct)
        Me.GroupBox2.Controls.Add(Me.txt_mrp)
        Me.GroupBox2.Controls.Add(Me.txt_costprice)
        Me.GroupBox2.Controls.Add(Me.txt_category)
        Me.GroupBox2.Controls.Add(Me.txt_pname)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 217)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(36, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 17)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Supplier"
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(138, 134)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(166, 20)
        Me.txt_supplier.TabIndex = 123
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Coral
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cancel.Location = New System.Drawing.Point(516, 134)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 52)
        Me.btn_cancel.TabIndex = 122
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_receive
        '
        Me.btn_receive.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_receive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_receive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_receive.Location = New System.Drawing.Point(402, 135)
        Me.btn_receive.Name = "btn_receive"
        Me.btn_receive.Size = New System.Drawing.Size(104, 52)
        Me.btn_receive.TabIndex = 121
        Me.btn_receive.Text = "Receive"
        Me.btn_receive.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(464, 99)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(156, 20)
        Me.txt_total.TabIndex = 36
        '
        'txt_noofproduct
        '
        Me.txt_noofproduct.Location = New System.Drawing.Point(464, 62)
        Me.txt_noofproduct.Name = "txt_noofproduct"
        Me.txt_noofproduct.Size = New System.Drawing.Size(156, 20)
        Me.txt_noofproduct.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(16, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'frmReceiveOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(645, 363)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceiveOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Receive"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_costprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_category As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_pname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_mrp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbx_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_noofproduct As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_receive As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_supplier As System.Windows.Forms.TextBox
End Class
