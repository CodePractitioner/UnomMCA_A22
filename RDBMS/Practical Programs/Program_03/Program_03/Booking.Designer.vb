<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBookingNo = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtConNo = New System.Windows.Forms.TextBox()
        Me.txtConName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnBillReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DOMESTIC GAS CONSUMER CARD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Booking Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consumer Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mobile Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Consumer Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 27)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Booking Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(600, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Delivery Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(600, 513)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 27)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Bill Amount"
        '
        'txtBookingNo
        '
        Me.txtBookingNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookingNo.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingNo.Location = New System.Drawing.Point(272, 162)
        Me.txtBookingNo.Name = "txtBookingNo"
        Me.txtBookingNo.Size = New System.Drawing.Size(264, 34)
        Me.txtBookingNo.TabIndex = 10
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(272, 248)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(264, 34)
        Me.txtMobile.TabIndex = 11
        '
        'txtConNo
        '
        Me.txtConNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConNo.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConNo.Location = New System.Drawing.Point(816, 162)
        Me.txtConNo.Name = "txtConNo"
        Me.txtConNo.Size = New System.Drawing.Size(264, 34)
        Me.txtConNo.TabIndex = 12
        '
        'txtConName
        '
        Me.txtConName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConName.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConName.Location = New System.Drawing.Point(816, 255)
        Me.txtConName.Name = "txtConName"
        Me.txtConName.Size = New System.Drawing.Size(264, 34)
        Me.txtConName.TabIndex = 13
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(272, 335)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(808, 34)
        Me.txtAddress.TabIndex = 14
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingDate.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dtpBookingDate.Location = New System.Drawing.Point(272, 430)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(264, 34)
        Me.dtpBookingDate.TabIndex = 15
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(816, 427)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(264, 34)
        Me.dtpDeliveryDate.TabIndex = 16
        '
        'txtBillAmount
        '
        Me.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillAmount.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillAmount.Location = New System.Drawing.Point(816, 506)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(216, 34)
        Me.txtBillAmount.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1038, 513)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 27)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Rs."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnBooking, Me.mnBillReport, Me.mnHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1106, 35)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnBooking
        '
        Me.mnBooking.Name = "mnBooking"
        Me.mnBooking.Size = New System.Drawing.Size(119, 31)
        Me.mnBooking.Text = "Booking"
        '
        'mnBillReport
        '
        Me.mnBillReport.Name = "mnBillReport"
        Me.mnBillReport.Size = New System.Drawing.Size(149, 31)
        Me.mnBillReport.Text = "Bill Report"
        '
        'mnHome
        '
        Me.mnHome.Name = "mnHome"
        Me.mnHome.Size = New System.Drawing.Size(92, 31)
        Me.mnHome.Text = "Home"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 603)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.dtpDeliveryDate)
        Me.Controls.Add(Me.dtpBookingDate)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtConName)
        Me.Controls.Add(Me.txtConNo)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtBookingNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBookingNo As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtConNo As TextBox
    Friend WithEvents txtConName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents dtpDeliveryDate As DateTimePicker
    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnBooking As ToolStripMenuItem
    Friend WithEvents mnBillReport As ToolStripMenuItem
    Friend WithEvents mnHome As ToolStripMenuItem
End Class
