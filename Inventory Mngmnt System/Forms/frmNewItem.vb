Imports System.Data
Imports System.Data.OleDb
Public Class frmNewItem
    Dim cn As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim dr As DataRow
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim f, i As Integer
    Dim ex As OleDbException
    Dim a As Integer
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Dispose(True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        ' TextBox1.Text = "Vikash"
        'TextBox1.Enabled = False
        ' Button2.Enabled = False
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_add.MouseMove
        Dim b1, c1 As String
        b1 = "Sourabh"
        c1 = "Kumar"
        txt_pname.Text = b1 + c1
    End Sub

    Private Sub frmNewItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\IMS.mdb"
            da = New OleDb.OleDbDataAdapter("select * from New_Item ", cn)
            da.Fill(ds, "New_Item")
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    cbbx_id.Items.Add(dr.Item("Product_ID"))
                Next
            End If
            btn_save.Enabled = True
            btn_cancel.Enabled = True

        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

    End Sub

    Private Sub cbbx_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbx_id.SelectedIndexChanged
        Try
            da = New OleDb.OleDbDataAdapter("select * from New_Item where Product_ID=" & cbbx_id.Text & "", cn)
            da.Fill(ds, "New_Item")
            dt = ds.Tables("New_Item")
            dr = dt.Rows(0)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    ' cbbx_id.Text = dr.Item("Customer_id")
                    txt_pname.Text = dr.Item("Product_Name")
                    cbbx_category.Text = dr.Item("Category")
                    cbbx_supplier.Text = dr.Item("Supplier")
                    txt_costprice.Text = dr.Item("Cost_Price")
                    txt_mrp.Text = dr.Item("MRP_Price")
                    txt_noofproduct.Text = dr.Item("No_of_Prodcut")
                    'txt_total.Text = dr.Item("Total")
                    txt_description.Text = dr.Item("Description")
                Next
            End If
        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub
End Class
