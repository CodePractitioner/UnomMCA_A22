Public Class BillReport
    Private Sub BillReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Program_03DBDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.Program_03DBDataSet.Transactions)

        Me.BillRptViewer.RefreshReport()

        lblDate.Text = lblDate.Text + DateAndTime.Now.ToShortDateString()
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        Booking.Show()
        Me.Close()
    End Sub
End Class