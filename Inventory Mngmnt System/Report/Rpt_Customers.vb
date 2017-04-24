Imports CrystalDecisions.CrystalReports.Engine
Public Class Rpt_Customers

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New ReportDocument
        a.Load("E:\Software\Kumar_BCA\My Projects\Inventory Mngmnt System\Inventory Mngmnt System\Report\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = a
        CrystalReportViewer1.Refresh()

    End Sub
End Class