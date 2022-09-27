Imports System.Data.OleDb
Public Class frmBill
    Dim Command As OleDbCommand

    Private Sub BillForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnableControls(False, False)
        dtpReadingDate.Value = DateAndTime.Now()
        txtPreviousReading.Select()
    End Sub

    Private Sub txtCurrentReading_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrentReading.LostFocus
        Try
            If (Convert.ToDouble(txtCurrentReading.Text) - Convert.ToDouble(txtPreviousReading.Text)) >= 0 Then
                txtUnits.Text = Convert.ToDouble(txtCurrentReading.Text) - Convert.ToDouble(txtPreviousReading.Text)
                Calculate()
            Else
                MsgBox("Current Reading should be greater than Previous Reading.")
                txtCurrentReading.Text = ""
            End If
        Catch exc As Exception
        End Try
    End Sub

    Private Sub mnAddBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAddBill.Click
        Command = New OleDbCommand()
        Command.Connection = frmHomePage.connection
        Dim params As String
        Try
            params = "(@ConsumerNumber, @ConsumerName, @ConnectionType, @ReadingDate, @PreviousReading, @CurrentReading, @Units, @Amount)"
            Command.CommandText = "INSERT INTO Transactions VALUES " + params
            Command.Parameters.AddWithValue("@ConsumerNumber", Convert.ToInt64(txtConsumerNumber.Text))
            Command.Parameters.AddWithValue("@ConsumerName", txtConsumerName.Text)
            Command.Parameters.AddWithValue("@ConnectionType", txtConnectionType.Text)
            Command.Parameters.AddWithValue("@ReadingDate", Convert.ToDateTime(dtpReadingDate.Value).ToShortDateString())
            Command.Parameters.AddWithValue("@PreviousReading", Convert.ToInt32(txtPreviousReading.Text))
            Command.Parameters.AddWithValue("@CurrentReading", Convert.ToInt32(txtCurrentReading.Text))
            Command.Parameters.AddWithValue("@Units", Convert.ToInt32(txtUnits.Text))
            Command.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text))
            MsgBox("Do you want to Bill for the Consumer ?", MessageBoxButtons.YesNo, "Confirmation")
            If MsgBoxResult.Yes Then
                Command.ExecuteNonQuery()
                MsgBox("Bill Added for the Consumer - " + txtConsumerName.Text)
                EnableControls(True, False)
            Else
                Command.Dispose()
                MsgBox("Transaction Cancelled.")
            End If
        Catch
            MsgBox("Enter a valid Input!")
        End Try
    End Sub

    Private Sub mnBillReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBillReceipt.Click
        Report.Show()
        Report.ReportViewer1.Hide()
        Report.ReportViewer2.Show()
        Report.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom
        Report.ReportViewer2.Size = New System.Drawing.Size(1124, 300)
        Report.ReportLabel.Text = "Bill Receipt"
    End Sub

    Private Sub mnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnHome.Click
        frmHomePage.Show()
        Me.Close()
    End Sub

    Private Sub Calculate()
        If txtConnectionType.Text.ToString() = "Domestic" Then
            If Val(txtUnits.Text) <= 100 Then
                txtAmount.Text = 2 * Val(txtUnits.Text)
            ElseIf Val(txtUnits.Text) > 100 And Val(txtUnits.Text) <= 200 Then
                txtAmount.Text = 100 + ((Val(txtUnits.Text) - 100) * 3)
            ElseIf Val(txtUnits.Text) > 200 Then
                txtAmount.Text = 400 + ((Val(txtUnits.Text) - 200) * 5)
            End If

        ElseIf txtConnectionType.Text.ToString() = "Commercial" Then
            If Val(txtUnits.Text) <= 100 Then
                txtAmount.Text = 4.5 * Val(txtUnits.Text)
            ElseIf Val(txtUnits.Text) > 100 And Val(txtUnits.Text) <= 200 Then
                txtAmount.Text = 450 + ((Val(txtUnits.Text) - 100) * 3.5)
            ElseIf Val(txtUnits.Text) > 200 Then
                txtAmount.Text = 450 + 750 + ((Val(txtUnits.Text) - 200) * 10)
            End If
        End If
    End Sub

    Private Sub EnableControls(ByVal type As Boolean, ByVal enable As Boolean)
        If (type) Then
            dtpReadingDate.Enabled = enable
            txtConsumerNumber.Enabled = enable
            txtConsumerName.Enabled = enable
            txtConnectionType.Enabled = enable
            txtPreviousReading.Enabled = enable
            txtCurrentReading.Enabled = enable
            txtUnits.Enabled = enable
            txtAmount.Enabled = enable
            mnAddBill.Enabled = enable
        Else
            dtpReadingDate.Enabled = enable
            txtConsumerNumber.Enabled = enable
            txtConsumerName.Enabled = enable
            txtConnectionType.Enabled = enable
            txtUnits.Enabled = enable
            txtAmount.Enabled = enable
        End If
    End Sub
End Class