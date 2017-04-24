Imports System.Data
Imports System.Data.OleDb
Public Class frmNewCustomer
    Dim cn As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim dr As DataRow
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim f, i As Integer
    Dim ex As OleDbException

    Private Sub frmNewCustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose(True)
    End Sub
    Private Sub male_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pb4.Visible = True
        pb3.Visible = False
    End Sub
    Private Sub female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pb3.Visible = True
        pb4.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Dispose(True)
    End Sub
    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbx_gender.TextChanged
        If cbbx_gender.Text = "Male" Then
            pb4.Visible = True
            pb3.Visible = False
        ElseIf cbbx_gender.Text = "gender" Then
            pb2.Visible = True
            pb4.Visible = False
            pb4.Visible = False
        Else
            pb3.Visible = True
            pb4.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Try
            f = 1
            cbbx_id.Enabled = False
            Call ClearCustomers()
            Call EnableButtons()
        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Try
            f = 2
            Call EnableButtons()
        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            f = 3
            Call EnableButtons()
        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        On Error GoTo errorlabel
        If f = 1 Then
            If cbbx_id.Text <> "" Then
                Dim stquery As String = String.Empty
                stquery = "Insert Into Customers(F_name,L_name,Gender,City,State,Zipcode,Country,Ph_no,E_mail) values('" & txt_fname.Text & "','" & txt_lname.Text & "', '" & cbbx_gender.Text & "','" & txt_city.Text & "','" & txt_state.Text & "'," & txt_zipcode.Text & ",'" & txt_country.Text & "'," & txt_phno.Text & ",'" & txt_email.Text & "')"
                Dim cm As New OleDbCommand(stquery)
                cm.Connection = cn
                cn.Open()
                cm.ExecuteNonQuery()
                cm.Connection.Close()
                MsgBox("Record Entered ", , "Inventory Management System")
                'Call ClearBooks()
                cn.Close()
                Exit Sub
            Else
                MsgBox("Enter the required values:" & vbNewLine & "1. Customer", , "Inventory Management System")

            End If

        ElseIf f = 2 Then
            If cbbx_id.Text <> "" Then
                Dim stquery As String = String.Empty
                stquery = "(Update Customers SET F_name='" & txt_fname.Text & "',L_name='" & txt_lname.Text & "',Gender='" & cbbx_gender.Text & "',City='" & txt_city.Text & "',State='" & txt_state.Text & "',Zipcode=" & txt_zipcode.Text & " ,Country='" & txt_country.Text & "' ,Ph_no=" & txt_phno.Text & ",E_mail='" & txt_email.Text & "'where Customer_id=" & cbbx_id.Text & ")"
                Dim cm As New OleDbCommand(stquery)
                cm.Connection = cn
                cn.Open()
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("RECORD UPDATED!! ", , "Inventory Management System")
                cbbx_id.Update()
                cn.Close()
                Exit Sub
            Else
                MsgBox("Enter the required values:" & vbNewLine & "1. Customer_id", , "Inventory Management System")
            End If


        ElseIf f = 3 Then
            If cbbx_id.Text <> "" Then
                Dim stquery As String = String.Empty
                stquery = "DELETE FROM Customers WHERE Customer_id = " & cbbx_id.Text & ";"
                Dim cm As New OleDbCommand(stquery)
                cm.Connection = cn
                cn.Open()
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record Deleterd", , "Inventory Management System")
                Call ClearCustomers()
                cbbx_id.Refresh()
                cn.Close()
                Exit Sub
            Else
                MsgBox("Enter the required values:" & vbNewLine & "1. Customer_id", , "Inventory Management System")
            End If
            End If
errorlabel:
            If (Err.Number = -2147467259) Then
                MsgBox("Customer of same id is available", MsgBoxStyle.Critical, "Inventory Management System")
            ElseIf Err.Number <> 0 Then
                MsgBox(Err.Number & Err.Description)
                cn.Close()
            End If
    End Sub

    Private Sub frmNewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\IMS.mdb"
            da = New OleDb.OleDbDataAdapter("select * from Customers ", cn)
            da.Fill(ds, "Customers")
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)

                    cbbx_id.Items.Add(dr.Item("Customer_id"))
                Next
            End If
            btn_save.Enabled = True
            btn_cancel.Enabled = True

        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub cbbx_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbx_id.SelectedIndexChanged
        Try
            da = New OleDb.OleDbDataAdapter("select * from Customers where customer_id=" & cbbx_id.Text & "", cn)
            da.Fill(ds, "Customers")
            dt = ds.Tables("Customers")
            dr = dt.Rows(0)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    ' cbbx_id.Text = dr.Item("Customer_id")
                    txt_fname.Text = dr.Item("F_name")
                    txt_lname.Text = dr.Item("L_name")
                    cbbx_gender.Text = dr.Item("Gender")
                    txt_city.Text = dr.Item("City")
                    txt_state.Text = dr.Item("State")
                    txt_zipcode.Text = dr.Item("Zipcode")
                    txt_country.Text = dr.Item("Country")
                    txt_phno.Text = dr.Item("Ph_no")
                    txt_email.Text = dr.Item("E_mail")
                Next
            End If
        Catch
            MsgBox(Err.Description & Err.Number, , "Inventory Management System")
        End Try
    End Sub

    Private Sub cbbx_gender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbx_gender.SelectedIndexChanged

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        cbbx_id.Enabled = True
        cbbx_id.ResetText()
        Call ClearCustomers()
        Call RefreshCustomer()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_fname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fname.TextChanged

    End Sub

    Private Sub txt_lname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_lname.TextChanged

    End Sub

    Private Sub txt_city_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_city.TextChanged

    End Sub

    Private Sub txt_state_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_state.TextChanged

    End Sub

    Private Sub txt_zipcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_zipcode.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub txt_country_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_country.TextChanged

    End Sub

    Private Sub txt_phno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_phno.TextChanged

    End Sub

    Private Sub txt_email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb2.Click

    End Sub

    Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb3.Click

    End Sub

    Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb4.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class