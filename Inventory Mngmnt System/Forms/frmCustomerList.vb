Imports System.Data
Imports System.Data.OleDb
Public Class frmCustomerList
    Dim cn As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim dr As DataRow
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        On Error GoTo errcode
        Help.ShowDialog()
        Exit Sub
errcode:
        MsgBox("Unable to run Help on your computer", vbInformation, "Error in opening!!!")
    End Sub

    Private Sub frmCustomerList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\IMS.mdb"
            cn.Open()
            da = New OleDbDataAdapter("select * from Customers ORDER BY Customer_id ASC", cn)
            da.Fill(ds, "Customers")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Customers"
            cn.Close()
            showmyRecord()
            Exit Sub
        Catch
            MsgBox(Err.Description & Err.Number)
        End Try
    End Sub
    Public Sub showmyRecord()
        '  ds.Tables.Add(dt)
        ' da = New OleDbDataAdapter("select Customer_id,F_name, L_name,Gender,City,State from Customers", cn)
        'da.Fill(dt)

        'Dim myrow As DataRow
        'For Each itm = 0 to ds.table.count-1
        'ListView1.Items.Add(myrow.Item(0))
        'ListView1.Items.Add(myrow.Item(1))

        'ListView1.Items.Add(ListView1.Items.Count - 1).SubItems.Add(myrow.Item(2))

        'Next
    End Sub
End Class