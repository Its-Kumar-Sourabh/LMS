Imports System.Data.OleDb
Public Class frmLogin

    Dim cn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\IMS.mdb"
            cn.Open()
            cmd = New OleDbCommand("select * from Login", cn)
            dr = cmd.ExecuteReader

            While dr.Read()
                If dr(0) = UsernameTextBox.Text And dr(1) = PasswordTextBox.Text Then
                    MDImain.Enabled = True
                    MDImain.Show()
                    dr.Close()
                    cn.Close()
                    Me.Dispose(True)
                    Exit Sub
                ElseIf dr(0) <> UsernameTextBox.Text And dr(1) <> PasswordTextBox.Text Then
                    MsgBox("User name and Password Mismatch!!!Try Again", MsgBoxStyle.Critical, "Inventory Management System")
                ElseIf dr(0) = UsernameTextBox.Text And dr(1) <> PasswordTextBox.Text Then
                    MsgBox(" Wrong Password !!!Try Again", MsgBoxStyle.Critical, "Inventory Management System")
                ElseIf dr(0) <> UsernameTextBox.Text And dr(1) = PasswordTextBox.Text Then
                    MsgBox(" Worng UserName !!!Try Again", MsgBoxStyle.Critical, "Inventory Management System")
                End If
            End While

        Catch
            MsgBox(Err.Description & Err.Number)
        Finally
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Are You Sure you want to Exit ?", vbExclamation + vbOKCancel, "Inventory Management System") = vbOK Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDImain.Enabled = False
    End Sub
End Class
