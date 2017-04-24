<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerList))
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Customer_ID = New System.Windows.Forms.ColumnHeader
        Me.First_name = New System.Windows.Forms.ColumnHeader
        Me.Last_name = New System.Windows.Forms.ColumnHeader
        Me.Gender = New System.Windows.Forms.ColumnHeader
        Me.City = New System.Windows.Forms.ColumnHeader
        Me.State = New System.Windows.Forms.ColumnHeader
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox7
        '
        resources.ApplyResources(Me.PictureBox7, "PictureBox7")
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.TabStop = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Name = "Label7"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Customer_ID, Me.First_name, Me.Last_name, Me.Gender, Me.City, Me.State})
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Customer_ID
        '
        resources.ApplyResources(Me.Customer_ID, "Customer_ID")
        '
        'First_name
        '
        resources.ApplyResources(Me.First_name, "First_name")
        '
        'Last_name
        '
        resources.ApplyResources(Me.Last_name, "Last_name")
        '
        'Gender
        '
        resources.ApplyResources(Me.Gender, "Gender")
        '
        'City
        '
        resources.ApplyResources(Me.City, "City")
        '
        'State
        '
        resources.ApplyResources(Me.State, "State")
        '
        'frmCustomerList
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerList"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Customer_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents First_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Last_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gender As System.Windows.Forms.ColumnHeader
    Friend WithEvents City As System.Windows.Forms.ColumnHeader
    Friend WithEvents State As System.Windows.Forms.ColumnHeader
End Class
