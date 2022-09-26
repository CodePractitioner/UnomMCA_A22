Public Class Report

    Private Sub ReportHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EBDBDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.EBDBDataSet.Transactions)
        'TODO: This line of code loads data into the 'EBDBDataSet.EB_Home' table. You can move, or remove it, as needed.
        Me.EB_HomeTableAdapter.Fill(Me.EBDBDataSet.EB_Home)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class