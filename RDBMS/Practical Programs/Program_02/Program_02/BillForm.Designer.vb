<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnAddBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnBillReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpReadingDate = New System.Windows.Forms.DateTimePicker()
        Me.txtConsumerNumber = New System.Windows.Forms.TextBox()
        Me.txtConsumerName = New System.Windows.Forms.TextBox()
        Me.txtConnectionType = New System.Windows.Forms.TextBox()
        Me.txtPreviousReading = New System.Windows.Forms.TextBox()
        Me.txtCurrentReading = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAddBill, Me.mnBillReceipt, Me.mnHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1132, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnAddBill
        '
        Me.mnAddBill.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnAddBill.Name = "mnAddBill"
        Me.mnAddBill.Size = New System.Drawing.Size(117, 31)
        Me.mnAddBill.Text = "Add Bill"
        '
        'mnBillReceipt
        '
        Me.mnBillReceipt.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBillReceipt.Name = "mnBillReceipt"
        Me.mnBillReceipt.Size = New System.Drawing.Size(157, 31)
        Me.mnBillReceipt.Text = "Bill Receipt"
        '
        'mnHome
        '
        Me.mnHome.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnHome.Name = "mnHome"
        Me.mnHome.Size = New System.Drawing.Size(92, 31)
        Me.mnHome.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ELECTRICITY BILL PREPARATION"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 62)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reading Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 59)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consumer Number"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 55)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Name"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 59)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Connection Type"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(605, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 67)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Previous Reading"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(605, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 59)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Current Reading"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(605, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 56)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "No.Of. Units"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(605, 466)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 34)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Amount"
        '
        'dtpReadingDate
        '
        Me.dtpReadingDate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReadingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReadingDate.Location = New System.Drawing.Point(265, 222)
        Me.dtpReadingDate.Name = "dtpReadingDate"
        Me.dtpReadingDate.Size = New System.Drawing.Size(267, 34)
        Me.dtpReadingDate.TabIndex = 10
        Me.dtpReadingDate.Value = New Date(2022, 9, 21, 0, 0, 0, 0)
        '
        'txtConsumerNumber
        '
        Me.txtConsumerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumerNumber.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumerNumber.Location = New System.Drawing.Point(265, 311)
        Me.txtConsumerNumber.Name = "txtConsumerNumber"
        Me.txtConsumerNumber.Size = New System.Drawing.Size(267, 34)
        Me.txtConsumerNumber.TabIndex = 11
        '
        'txtConsumerName
        '
        Me.txtConsumerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumerName.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumerName.Location = New System.Drawing.Point(265, 391)
        Me.txtConsumerName.Name = "txtConsumerName"
        Me.txtConsumerName.Size = New System.Drawing.Size(267, 34)
        Me.txtConsumerName.TabIndex = 12
        '
        'txtConnectionType
        '
        Me.txtConnectionType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConnectionType.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnectionType.Location = New System.Drawing.Point(265, 466)
        Me.txtConnectionType.Name = "txtConnectionType"
        Me.txtConnectionType.Size = New System.Drawing.Size(267, 34)
        Me.txtConnectionType.TabIndex = 13
        '
        'txtPreviousReading
        '
        Me.txtPreviousReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreviousReading.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousReading.Location = New System.Drawing.Point(795, 225)
        Me.txtPreviousReading.Name = "txtPreviousReading"
        Me.txtPreviousReading.Size = New System.Drawing.Size(267, 34)
        Me.txtPreviousReading.TabIndex = 14
        '
        'txtCurrentReading
        '
        Me.txtCurrentReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentReading.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentReading.Location = New System.Drawing.Point(795, 311)
        Me.txtCurrentReading.Name = "txtCurrentReading"
        Me.txtCurrentReading.Size = New System.Drawing.Size(267, 34)
        Me.txtCurrentReading.TabIndex = 15
        '
        'txtUnits
        '
        Me.txtUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnits.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(795, 391)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(267, 34)
        Me.txtUnits.TabIndex = 16
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(795, 463)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(267, 34)
        Me.txtAmount.TabIndex = 17
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtCurrentReading)
        Me.Controls.Add(Me.txtPreviousReading)
        Me.Controls.Add(Me.txtConnectionType)
        Me.Controls.Add(Me.txtConsumerName)
        Me.Controls.Add(Me.txtConsumerNumber)
        Me.Controls.Add(Me.dtpReadingDate)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmBill"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnAddBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnBillReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpReadingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConsumerNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumerName As System.Windows.Forms.TextBox
    Friend WithEvents txtConnectionType As System.Windows.Forms.TextBox
    Friend WithEvents txtPreviousReading As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentReading As System.Windows.Forms.TextBox
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
End Class
