Imports System.Data.OleDb

Public Class Setting
    Dim cn As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand


    Private Sub Setting_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose(True)
        

    End Sub

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=C:\IMS.mdb"
        cn.Open()
        cmd = New OleDbCommand("select Password from Login", cn)
        dr = cmd.ExecuteReader


    End Sub

    Private Sub btn_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_change.Click
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

       
        If dr(0) = txt_oldpass.Text Then

        ElseIf txt_newpass.Text = txt_newconfirm.Text Then
            cmd1 = New OleDbCommand("update Login SET Password= '" & txt_newpass.Text & "' where U_name = 'Admin' ")
            cmd1.ExecuteNonQuery()
            MsgBox("Password Change Successfully")
        ElseIf txt_newpass.Text <> txt_newconfirm.Text Then
            MsgBox(" New Password not match")
        Else
            MsgBox(" Password not match")
        End If
        Try
        Catch
            MsgBox("bye")
        Finally
            dr.Close()
            cn.Close()
        End Try


    End Sub
End Class