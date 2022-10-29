Imports System.Data.OleDb
Imports System.Configuration

Public Class Booking
    Dim command As New OleDbCommand
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBookingNo.Enabled = False
        txtConName.Enabled = False
        txtMobile.Enabled = False
        txtAddress.Enabled = False
        txtBillAmount.Enabled = False

        command = New OleDbCommand
        command.Connection = Home.connection
        command.CommandText = "SELECT MAX(BookingNumber) FROM Transactions"
        Dim recordset = command.ExecuteReader()

        While recordset.Read()
            txtBookingNo.Text = Val(recordset(0).ToString()) + 1
        End While
        recordset.Close()
        command.Dispose()
    End Sub

    Private Sub mnHome_Click(sender As Object, e As EventArgs) Handles mnHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub mnBillReport_Click(sender As Object, e As EventArgs) Handles mnBillReport.Click
        Me.Hide()
        BillReport.Show()
    End Sub

    Private Sub txtConNo_LostFocus(sender As Object, e As EventArgs) Handles txtConNo.LostFocus
        Try
            Dim ConfigUnitPrice As Decimal = Convert.ToDecimal(ConfigurationManager.AppSettings("CylinderUnitRate"))
            command = New OleDbCommand
            command.Connection = Home.connection
            command.CommandText = "SELECT * FROM Consumer WHERE ConsumerNo = " + txtConNo.Text
            Dim recordset = command.ExecuteReader()
            Dim found As Boolean = False
            While recordset.Read()
                txtConName.Text = recordset("ConsumerName").ToString()
                txtMobile.Text = recordset("Mobile").ToString()
                txtAddress.Text = recordset("ConsumerAddress").ToString()

                'Since the Cylinder Unit Price may Vary and it should not be inserted manually during Billing,
                'It is set to take the Value from the Config File.
                '(Config Once use N no of times. You can change when ever in the config file; the system will work accordingly)
                txtBillAmount.Text = ConfigUnitPrice
                found = True
                txtConNo.Enabled = False
            End While
            recordset.Close()
            command.Dispose()

            If found <> True Then
                MsgBox("No Record Found.")
                txtConNo.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnBooking_Click(sender As Object, e As EventArgs) Handles mnBooking.Click
        Try
            command = New OleDbCommand
            command.Connection = Home.connection
            Dim fields As String = "(ConsumerNumber, ConsumerName, ConsumerAddress, Mobile, BookingNumber, BookingDate, DeliveryDate, BillAmount)"
            Dim params As String = "(@ConsumerNumber, @ConsumerName, @ConsumerAddress, @Mobile, @BookingNumber, @BookingDate, @DeliveryDate, @BillAmount)"
            command.CommandText = "INSERT INTO Transactions " + fields + " VALUES " + params
            command.Parameters.AddWithValue("@ConsumerNumber", Convert.ToInt32(txtConNo.Text))
            command.Parameters.AddWithValue("@ConsumerName", txtConName.Text)
            command.Parameters.AddWithValue("@ConsumerAddress", txtAddress.Text)
            command.Parameters.AddWithValue("@Mobile", Convert.ToDecimal(txtMobile.Text))
            command.Parameters.AddWithValue("@BookingNumber", Val(txtBookingNo.Text))
            command.Parameters.AddWithValue("@BookingDate", Convert.ToDateTime(dtpBookingDate.Value).ToShortDateString())
            command.Parameters.AddWithValue("@DeliveryDate", Convert.ToDateTime(dtpDeliveryDate.Value).ToShortDateString())
            command.Parameters.AddWithValue("@BillAmount", Val(txtBillAmount.Text))
            command.ExecuteNonQuery()
            command.Dispose()

            MsgBox("Billing Details Inserted for the Consumer Id - " + txtConNo.Text)
            txtConNo.Enabled = True
            ClearControls()
            Booking_Load(sender, e)
        Catch ex As Exception
            MsgBox("Enter a Valid Input.")
        End Try
    End Sub

    Private Sub ClearControls()
        txtBookingNo.Text = ""
        txtConNo.Text = ""
        txtConName.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        dtpBookingDate.Value = DateTime.Now
        dtpDeliveryDate.Value = DateTime.Now
        txtBillAmount.Text = ""
    End Sub
End Class