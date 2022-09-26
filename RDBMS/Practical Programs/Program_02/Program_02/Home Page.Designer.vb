<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMonthlyReading = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtConsumerNumber = New System.Windows.Forms.TextBox()
        Me.txtConsumerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDepositAmount = New System.Windows.Forms.TextBox()
        Me.cbxConnectionType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STATE EB CUSTOMER APPLICATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(588, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "North District EB Distribution Circle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Consumer Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 599)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Deposit Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Consumer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Connection Type"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecordToolStripMenuItem, Me.mnMonthlyReading, Me.mnReport, Me.mnExit, Me.mnSearch})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1132, 35)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddRecordToolStripMenuItem
        '
        Me.AddRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnItmAdd, Me.mnItmDelete, Me.mnItmClear})
        Me.AddRecordToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem"
        Me.AddRecordToolStripMenuItem.Size = New System.Drawing.Size(66, 31)
        Me.AddRecordToolStripMenuItem.Text = "File"
        '
        'mnItmAdd
        '
        Me.mnItmAdd.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnItmAdd.Name = "mnItmAdd"
        Me.mnItmAdd.Size = New System.Drawing.Size(273, 38)
        Me.mnItmAdd.Text = "Add Record"
        '
        'mnItmDelete
        '
        Me.mnItmDelete.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnItmDelete.Name = "mnItmDelete"
        Me.mnItmDelete.Size = New System.Drawing.Size(273, 38)
        Me.mnItmDelete.Text = "Delete Record"
        '
        'mnItmClear
        '
        Me.mnItmClear.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnItmClear.Name = "mnItmClear"
        Me.mnItmClear.Size = New System.Drawing.Size(273, 38)
        Me.mnItmClear.Text = "Clear All"
        '
        'mnMonthlyReading
        '
        Me.mnMonthlyReading.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnMonthlyReading.Name = "mnMonthlyReading"
        Me.mnMonthlyReading.Size = New System.Drawing.Size(223, 31)
        Me.mnMonthlyReading.Text = "Monthly Reading"
        '
        'mnReport
        '
        Me.mnReport.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnReport.Name = "mnReport"
        Me.mnReport.Size = New System.Drawing.Size(102, 31)
        Me.mnReport.Text = "Report"
        '
        'mnExit
        '
        Me.mnExit.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(69, 31)
        Me.mnExit.Text = "Exit"
        '
        'mnSearch
        '
        Me.mnSearch.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnSearch.Name = "mnSearch"
        Me.mnSearch.Size = New System.Drawing.Size(106, 31)
        Me.mnSearch.Text = "Search"
        '
        'txtConsumerNumber
        '
        Me.txtConsumerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumerNumber.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumerNumber.Location = New System.Drawing.Point(416, 245)
        Me.txtConsumerNumber.Name = "txtConsumerNumber"
        Me.txtConsumerNumber.Size = New System.Drawing.Size(438, 39)
        Me.txtConsumerNumber.TabIndex = 8
        '
        'txtConsumerName
        '
        Me.txtConsumerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumerName.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumerName.Location = New System.Drawing.Point(416, 332)
        Me.txtConsumerName.Name = "txtConsumerName"
        Me.txtConsumerName.Size = New System.Drawing.Size(438, 39)
        Me.txtConsumerName.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(416, 414)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(438, 39)
        Me.txtAddress.TabIndex = 10
        '
        'txtDepositAmount
        '
        Me.txtDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepositAmount.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositAmount.Location = New System.Drawing.Point(416, 599)
        Me.txtDepositAmount.Name = "txtDepositAmount"
        Me.txtDepositAmount.Size = New System.Drawing.Size(373, 39)
        Me.txtDepositAmount.TabIndex = 12
        '
        'cbxConnectionType
        '
        Me.cbxConnectionType.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConnectionType.FormattingEnabled = True
        Me.cbxConnectionType.Location = New System.Drawing.Point(416, 506)
        Me.cbxConnectionType.Name = "cbxConnectionType"
        Me.cbxConnectionType.Size = New System.Drawing.Size(438, 40)
        Me.cbxConnectionType.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(795, 605)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 33)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Rs."
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbxConnectionType)
        Me.Controls.Add(Me.txtDepositAmount)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtConsumerName)
        Me.Controls.Add(Me.txtConsumerNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmHomePage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItmAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItmClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMonthlyReading As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtConsumerNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumerName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositAmount As System.Windows.Forms.TextBox
    Friend WithEvents cbxConnectionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
