Module Module1
    Public Sub ClearCustomers()
        With frmNewCustomer
            .txt_fname.Text = ""
            .txt_lname.Text = ""
            .cbbx_gender.Text = "gender"
            .txt_city.Text = ""
            .txt_state.Text = ""
            .txt_country.Text = ""
            .txt_zipcode.Text = ""
            .txt_phno.Text = ""
            .txt_email.Text = ""
        End With
    End Sub
    Public Sub EnableButtons()
        With frmNewCustomer
            .btn_add.Enabled = False
            .btn_edit.Enabled = False
            .btn_delete.Enabled = False
            .btn_save.Enabled = True
            .btn_cancel.Enabled = True
        End With

    End Sub
    Public Sub RefreshCustomer()
        With frmNewCustomer
            .btn_add.Enabled = True
            .btn_edit.Enabled = True
            .btn_delete.Enabled = True
            .btn_save.Enabled = False
            .btn_cancel.Enabled = False
        End With
    End Sub
    Public Sub Clearproduct()
        With frmNewItem
            

        End With
    End Sub
  
End Module
