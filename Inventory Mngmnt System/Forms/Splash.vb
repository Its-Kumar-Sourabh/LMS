Public Class Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pb.Value = pb.Value + 4
        Me.Opacity = Me.Opacity + 0.1

        ' Me.Height = Me.Height + 10
        ' Me.Width = Me.Width + 20
        If pb.Value = pb.Maximum Then
            Timer1.Enabled = False
            MDImain.Show()
            MDImain.Enabled = False
            frmLogin.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Height = 0
        'Me.Width = 0
    End Sub
End Class