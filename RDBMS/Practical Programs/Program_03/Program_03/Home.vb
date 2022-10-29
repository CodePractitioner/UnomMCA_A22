Imports System.Data.OleDb
Imports System.Configuration

Public Class Home
    Public connection As New OleDbConnection
    Dim command As New OleDbCommand
    ReadOnly connectionstring As String = ConfigurationManager.ConnectionStrings("Program_03.My.MySettings.Program_03DB").ConnectionString

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionstring)
        connection.Open()
        MsgBox("Database Connected.")
        LoadHome()
    End Sub

    Private Sub LoadHome()
        txtConNo.Enabled = False
        btnUpdate.Visible = False
        txtConName.Select()
        ClearControls()

        command = New OleDbCommand
        command.Connection = connection
        command.CommandText = "SELECT MAX(ConsumerNo) FROM Consumer"
        Dim recordset = command.ExecuteReader()

        While recordset.Read()
            txtConNo.Text = Val(recordset(0).ToString()) + 1
        End While
        recordset.Close()
        command.Dispose()
    End Sub

    Private Sub ClearControls()
        txtConName.Text = ""
        txtMobile.Text = ""
        txtAddress.Text = ""
        txtCylinders.Text = ""
        txtDepositAmt.Text = ""
    End Sub

    Private Sub mnTrans_Click(sender As Object, e As EventArgs) Handles mnTrans.Click
        Me.Hide()
        Booking.Show()
    End Sub

    Private Sub mnItmAdd_Click(sender As Object, e As EventArgs) Handles mnItmAdd.Click
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.CommandText = "INSERT INTO Consumer (ConsumerNo ,ConsumerName, ConsumerAddress, Mobile, CylinderNos, DepositAmount) VALUES (@ConsumerNo, @ConsumerName, @ConsumerAddress, @Mobile, @CylinderNos, @DepositAmount)"
            command.Parameters.AddWithValue("@ConsumerNo", Val(txtConNo.Text))
            command.Parameters.AddWithValue("@ConsumerName", txtConName.Text)
            command.Parameters.AddWithValue("@ConsumerAddress", txtAddress.Text)
            command.Parameters.AddWithValue("@Mobile", Convert.ToDecimal(txtMobile.Text))
            command.Parameters.AddWithValue("@CylinderNos", Convert.ToByte(txtCylinders.Text))
            command.Parameters.AddWithValue("@DepositAmount", Convert.ToDecimal(txtDepositAmt.Text))
            Dim result As DialogResult = MessageBox.Show("Please verify the Details. Do you want to Proceed?", "Info", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                command.ExecuteNonQuery()
                MsgBox("Consumer Number - " + txtConNo.Text + " Added Successdully.")
                LoadHome()
            Else
                MsgBox("Request Aborted.")
            End If
            command.Dispose()
        Catch ex As Exception
            command.Dispose()
            MsgBox("Enter a Valid Input")
        End Try
    End Sub

    Private Sub mnShowConsumer_Click(sender As Object, e As EventArgs) Handles mnShowConsumer.Click
        Me.Hide()
        Report.Show()
    End Sub

    Private Sub mnExit_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        command.Dispose()
        connection.Close()
        End
    End Sub

    Private Sub mnItmDelete_Click(sender As Object, e As EventArgs) Handles mnItmDelete.Click
        Dim ConNumber As Integer
        Dim found As Boolean = False
        Try
            ConNumber = InputBox("Enter the Consumer Number Record to be Deleted")
            command = New OleDbCommand("SELECT * FROM Consumer", connection)
            Dim dr = command.ExecuteReader()
            While dr.Read()
                If (Val(dr("ConsumerNo").ToString()) = ConNumber) Then
                    command = New OleDbCommand("DELETE FROM Consumer WHERE ConsumerNo = @ConsumerNo", connection)
                    command.Parameters.AddWithValue("@ConsumerNo", ConNumber)
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

    Private Sub mnItmUpdate_Click(sender As Object, e As EventArgs) Handles mnItmUpdate.Click
        Dim ConNumber As Integer
        Dim found As Boolean = False
        Try
            ConNumber = InputBox("Enter the Consumer Number Record to be Updated")
            command = New OleDbCommand("SELECT * FROM Consumer WHERE ConsumerNo = @ConsumerNo", connection)
            command.Parameters.AddWithValue("@ConsumerNo", ConNumber)
            Dim dr = command.ExecuteReader()
            While dr.Read()
                txtConNo.Text = ConNumber.ToString()
                txtConName.Text = dr("ConsumerName").ToString()
                txtMobile.Text = dr("Mobile").ToString()
                txtAddress.Text = dr("ConsumerAddress").ToString()
                txtCylinders.Text = dr("CylinderNos").ToString()
                txtDepositAmt.Text = dr("DepositAmount").ToString()
                found = True
                btnUpdate.Visible = True
            End While
            dr.Close()
            command.Dispose()
            If (found <> True) Then
                MsgBox("Record Not Found")
            End If
        Catch exception As InvalidCastException
            MsgBox("Enter a Valid Consumer Number")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        command = New OleDbCommand()
        command.Connection = connection
        command.CommandText = "UPDATE Consumer SET ConsumerName=@ConsumerName, ConsumerAddress=@ConsumerAddress, Mobile=@Mobile, CylinderNos=@CylinderNos, DepositAmount=@DepositAmount WHERE ConsumerNo=@ConsumerNo"
        command.Parameters.AddWithValue("@ConsumerName", txtConName.Text)
        command.Parameters.AddWithValue("@ConsumerAddress", txtAddress.Text)
        command.Parameters.AddWithValue("@Mobile", Val(txtMobile.Text))
        command.Parameters.AddWithValue("@CylinderNos", Val(txtCylinders.Text))
        command.Parameters.AddWithValue("@DepositAmount", Val(txtDepositAmt.Text))
        command.Parameters.AddWithValue("@ConsumerNo", Val(txtConNo.Text))
        command.ExecuteNonQuery()

        command.CommandText = "SELECT * FROM Transactions WHERE ConsumerNumber = " + txtConNo.Text
        Dim reader = command.ExecuteReader()
        While reader.Read()
            command = New OleDbCommand()
            command.Connection = connection
            command.CommandText = "UPDATE Transactions SET ConsumerName=@ConsumerName, ConsumerAddress=@ConsumerAddress, Mobile=@Mobile WHERE ConsumerNumber=@ConsumerNumber"
            command.Parameters.AddWithValue("@ConsumerName", txtConName.Text)
            command.Parameters.AddWithValue("@ConsumerAddress", txtAddress.Text)
            command.Parameters.AddWithValue("@Mobile", Val(txtMobile.Text))
            command.Parameters.AddWithValue("@ConsumerNumber", Val(txtConNo.Text))
            command.ExecuteNonQuery()
        End While
        reader.Close()
        command.Dispose()
        MsgBox("Consumer Details Updated.")
        LoadHome()
    End Sub

    Private Sub txtConName_DoubleClick(sender As Object, e As EventArgs) Handles txtConName.DoubleClick
        command = New OleDbCommand()
        command.Connection = connection
        command.CommandText = "ALTER TABLE Consumer ALTER COLUMN ConsumerNo COUNTER(1,1)"
        command.ExecuteNonQuery()
    End Sub
End Class
