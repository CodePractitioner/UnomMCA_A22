Imports System.Data.OleDb
Imports System.Configuration

Public Class frmHomePage

    Public connection As New OleDbConnection
    Dim command As New OleDbCommand
    Public connectionstring = ConfigurationManager.ConnectionStrings("Program_02.My.MySettings.EBConnectionString").ToString()

    Private Sub frmHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxConnectionType.Items.Add("Domestic")
        cbxConnectionType.Items.Add("Commercial")
        connection = New OleDbConnection(connectionstring)
        connection.Open()
        MsgBox("DataBase Connected")
        LoadHome()
    End Sub

    Private Sub mnItmAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItmAdd.Click
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.CommandText = "INSERT INTO EB_HOME VALUES (@ConsumerNumber, @ConsumerName, @Address, @ConnectionType, @DepositAmount)"
            command.Parameters.AddWithValue("@ConsumerNumber", Convert.ToInt64(txtConsumerNumber.Text))
            command.Parameters.AddWithValue("@ConsumerName", txtConsumerName.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@ConnectionType", cbxConnectionType.SelectedItem().ToString())
            command.Parameters.AddWithValue("@DepositAmount", Convert.ToDecimal(txtDepositAmount.Text))
            Dim result As DialogResult = MessageBox.Show("Please Verify the Details. After adding the Consumer Info, it will only be updated by DB Admin. Do you want to Proceed", "Info", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                command.ExecuteNonQuery()
                MsgBox("Consumer Numer - " + txtConsumerNumber.Text + " Added Successfully.")
            Else
                MsgBox("Request Aborted")
            End If
        Catch ex As Exception
            MsgBox("Enter a valid Input")
        End Try
    End Sub

    Private Sub mnItmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItmDelete.Click

        Dim ConNumber As Integer
        Dim found As Boolean = False
        Try
            ConNumber = InputBox("Enter the Consumer Number Record to be Deleted")
            command = New OleDbCommand("SELECT * FROM EB_Home", connection)
            Dim dr = command.ExecuteReader()
            While dr.Read()
                If (Val(dr("ConsumerNumber").ToString()) = ConNumber) Then
                    command = New OleDbCommand("DELETE FROM EB_Home WHERE ConsumerNumber = @ConsumerNumber", connection)
                    command.Parameters.AddWithValue("@ConsumerNumber", ConNumber)
                    command.ExecuteNonQuery()

                    command = New OleDbCommand("SELECT * FROM Transactions", connection)
                    Dim datar = command.ExecuteReader()
                    While datar.Read()
                        If (Val(datar("ConsumerNumber").ToString()) = ConNumber) Then
                            command = New OleDbCommand("DELETE FROM Transactions WHERE ConsumerNumber = @ConsumerNumber", connection)
                            command.Parameters.AddWithValue("@ConsumerNumber", ConNumber)
                            command.ExecuteNonQuery()
                        End If
                    End While
                    datar.Close()
                    MsgBox("Record Deleted")
                    found = True
                    LoadHome()
                End If
            End While
            dr.Close()
            If (found <> True) Then
                MsgBox("Record Not Found")
            End If
        Catch exception As InvalidCastException
            MsgBox("Enter a Valid Consumer Number")
        End Try
    End Sub

    Private Sub mnItmClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItmClear.Click
        Clear()
        LoadHome()
    End Sub

    Private Sub mnMonthlyReading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMonthlyReading.Click
        Me.Hide()
        frmBill.txtConsumerNumber.Text = Me.txtConsumerNumber.Text
        frmBill.txtConsumerName.Text = Me.txtConsumerName.Text
        frmBill.txtConnectionType.Text = Me.cbxConnectionType.Text
        frmBill.Show()
    End Sub

    Private Sub mnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReport.Click
        Report.Show()
        Report.ReportViewer2.Hide()
        Report.ReportViewer1.Show()
        Report.ReportViewer1.Size = New System.Drawing.Size(1124, 300)
        Report.ReportLabel.Text = "EB Account Holder Report"
    End Sub

    Private Sub mnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnExit.Click
        connection.Close()
        End
    End Sub

    Private Sub mnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSearch.Click
        Dim ConNumber As Integer
        Dim found As Boolean = False
        Try
            ConNumber = InputBox("Enter the Consumer Number Record to be Searched")
            command = New OleDbCommand("SELECT * FROM EB_Home WHERE ConsumerNumber = @ConsumerNumber", connection)
            command.Parameters.AddWithValue("@ConsumerNumber", ConNumber)
            Dim dr = command.ExecuteReader()
            While dr.Read()
                If (Val(dr("ConsumerNumber").ToString()) = ConNumber) Then
                    txtConsumerNumber.Text = Val(dr("ConsumerNumber").ToString())
                    txtConsumerName.Text = dr("ConsumerName").ToString()
                    txtAddress.Text = dr("Address").ToString()
                    cbxConnectionType.Text = dr("ConnectionType").ToString()
                    txtDepositAmount.Text = Val(dr("DepositAmount").ToString())
                    found = True
                    EnableControls(True, False)
                End If
            End While
            If (found <> True) Then
                MsgBox("Record Not Found")
            End If
            dr.Close()
        Catch exception As InvalidCastException
            MsgBox("Enter a Valid Consumer Number")
        End Try
    End Sub

    Private Sub LoadHome()
        EnableControls(True, True)
        txtConsumerNumber.Enabled = False
        command = New OleDbCommand
        command.Connection = connection
        command.CommandText = "SELECT MAX(ConsumerNumber) FROM EB_Home"
        Dim recordset = command.ExecuteReader()

        While recordset.Read()
            txtConsumerNumber.Text = Val(recordset(0).ToString()) + 1
        End While
    End Sub

    Private Sub Clear()
        txtConsumerNumber.Text = ""
        txtConsumerName.Text = ""
        txtAddress.Text = ""
        cbxConnectionType.SelectedIndex = -1
        txtDepositAmount.Text = ""
    End Sub

    Private Sub EnableControls(ByVal type As Boolean, ByVal enable As Boolean)
        If (type) Then
            txtConsumerNumber.Enabled = enable
            txtConsumerName.Enabled = enable
            cbxConnectionType.Enabled = enable
            txtAddress.Enabled = enable
            txtDepositAmount.Enabled = enable
            mnItmAdd.Enabled = enable
        Else
            txtConsumerNumber.Enabled = enable
        End If
    End Sub
End Class