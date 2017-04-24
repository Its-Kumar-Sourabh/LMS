Imports System.Windows.Forms

Public Class MDImain

  

    Private Sub ItemMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Show()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub AdminMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminMenu.Click
        AdminToolStrip.Show()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub CustomerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Show()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub SaleMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Show()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub PurchaseMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Show()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub UtilitiesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilitiesMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Show()
        HelpToolStrip.Hide()
        ReportToolStrip.Hide()
    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Show()
        ReportToolStrip.Hide()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmNewItem.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogoff.Click
        If MsgBox("Are You Sure you want to logoff ?", vbExclamation + vbOKCancel, "Inventory Management System") = vbOK Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub MDImain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If MsgBox("Are You Sure you want to Exit ?", vbExclamation + vbOKCancel, "Inventory Management System") = vbOK Then
            Splash.Close()
            Me.Dispose(True)
        End If
    End Sub

    Private Sub MDImain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmItemList.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmOrderItem.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmReceiveOrder.ShowDialog()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        frmNewCustomer.ShowDialog()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        On Error GoTo errcode
        Shell("C:\WINDOWS\system32\calc.exe", vbNormalFocus)
        Exit Sub
errcode:
        MsgBox("Unable to run Caculator Utility on your computer", vbInformation, "Error in opening!!!")
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        On Error GoTo errcode
        Shell("C:\Program Files\Windows NT\Accessories\wordpad.exe", vbNormalFocus)
        Exit Sub
errcode:
        MsgBox("Unable to run wordpad Utility on your computer", vbInformation, "Error in opening!!!")
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        On Error GoTo errcode
        Shell("C:\WINDOWS\system32\notepad.exe", vbNormalFocus)
        Exit Sub
errcode:
        MsgBox("Unable to run Notepad Utility on your computer", vbInformation, "Error in opening!!!")
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        On Error GoTo errcode
        Shell("C:\Program Files\Internet Explorer\iexplore.exe", vbNormalFocus)
        Exit Sub
errcode:
        MsgBox("Unable to run Internet Explorer Utility on your computer", vbInformation, "Error in opening!!!")
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmCustomerList.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExit.Click
        If MsgBox("Are You Sure you want to Exit ?", vbExclamation + vbOKCancel, "Inventory Management System") = vbOK Then
            Splash.Close()
            Me.Dispose(True)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSetting.Click
        Setting.ShowDialog()
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        frmShortcut.ShowDialog()
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        frmSalesList.ShowDialog()
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        About.ShowDialog()
    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        Help.ShowDialog()
    End Sub

    Private Sub timelabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timelabel.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timelabel.Text = Now()
        Label1.Text = Now()
    End Sub

    Private Sub AdminToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles AdminToolStrip.ItemClicked

    End Sub

    Private Sub ReportMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMenu.Click
        AdminToolStrip.Hide()
        ItemToolStrip.Hide()
        CustomerToolStrip.Hide()
        SaleToolStrip.Hide()
        SupplierToolStrip.Hide()
        UtilitiesToolStrip.Hide()
        HelpToolStrip.Hide()
        ReportToolStrip.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub timelabel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles timelabel.MouseMove
        GroupBox1.Visible = True
    End Sub

    Private Sub MDImain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        GroupBox1.Visible = False
    End Sub

    Private Sub StatusStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub StatusStrip_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StatusStrip.MouseMove
        GroupBox1.Visible = False
    End Sub

    Private Sub MDImain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        GroupBox1.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Rpt_Customers.Show()
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        frmSales.Show()

    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmCategory.ShowDialog()
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        frmSupplier.ShowDialog()

    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        frmSupplierslist.ShowDialog()

    End Sub
End Class
