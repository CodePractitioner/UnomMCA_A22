Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Program_03DBDataSet.Consumer' table. You can move, or remove it, as needed.
        Me.ConsumerTableAdapter.Fill(Me.Program_03DBDataSet.Consumer)
        'TODO: This line of code loads data into the 'Program_03DBDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.Program_03DBDataSet.Transactions)
        Me.HomeReport.RefreshReport()
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        Home.Show()
        Me.Close()
    End Sub
End Class