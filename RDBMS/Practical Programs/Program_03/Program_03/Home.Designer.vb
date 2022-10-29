<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnMasterFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTrans = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnShowConsumer = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtConNo = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtCylinders = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtConName = New System.Windows.Forms.TextBox()
        Me.txtDepositAmt = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable1.Location = New System.Drawing.Point(276, 57)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(557, 36)
        Me.Lable1.TabIndex = 0
        Me.Lable1.Text = "DOMESTIC GAS CONSUMER CARD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Consumer Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(539, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Consumer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No of Cylinders"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(538, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Deposit Amount"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMasterFile, Me.mnTrans, Me.mnExit, Me.mnShowConsumer})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1107, 35)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnMasterFile
        '
        Me.mnMasterFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnItmAdd, Me.mnItmUpdate, Me.mnItmDelete})
        Me.mnMasterFile.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnMasterFile.Name = "mnMasterFile"
        Me.mnMasterFile.Size = New System.Drawing.Size(155, 31)
        Me.mnMasterFile.Text = "Master File"
        '
        'mnItmAdd
        '
        Me.mnItmAdd.Name = "mnItmAdd"
        Me.mnItmAdd.Size = New System.Drawing.Size(264, 32)
        Me.mnItmAdd.Text = "Add Record"
        '
        'mnItmUpdate
        '
        Me.mnItmUpdate.Name = "mnItmUpdate"
        Me.mnItmUpdate.Size = New System.Drawing.Size(264, 32)
        Me.mnItmUpdate.Text = "Update Record"
        '
        'mnItmDelete
        '
        Me.mnItmDelete.Name = "mnItmDelete"
        Me.mnItmDelete.Size = New System.Drawing.Size(264, 32)
        Me.mnItmDelete.Text = "Delete Record"
        '
        'mnTrans
        '
        Me.mnTrans.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnTrans.Name = "mnTrans"
        Me.mnTrans.Size = New System.Drawing.Size(174, 31)
        Me.mnTrans.Text = "Transactions"
        '
        'mnExit
        '
        Me.mnExit.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(69, 31)
        Me.mnExit.Text = "Exit"
        '
        'mnShowConsumer
        '
        Me.mnShowConsumer.Name = "mnShowConsumer"
        Me.mnShowConsumer.Size = New System.Drawing.Size(282, 31)
        Me.mnShowConsumer.Text = "Show Consumer Data"
        '
        'txtConNo
        '
        Me.txtConNo.BackColor = System.Drawing.Color.White
        Me.txtConNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConNo.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConNo.Location = New System.Drawing.Point(297, 149)
        Me.txtConNo.Name = "txtConNo"
        Me.txtConNo.Size = New System.Drawing.Size(176, 34)
        Me.txtConNo.TabIndex = 8
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(297, 218)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(176, 34)
        Me.txtMobile.TabIndex = 9
        '
        'txtCylinders
        '
        Me.txtCylinders.BackColor = System.Drawing.Color.White
        Me.txtCylinders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCylinders.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCylinders.Location = New System.Drawing.Point(297, 280)
        Me.txtCylinders.Name = "txtCylinders"
        Me.txtCylinders.Size = New System.Drawing.Size(176, 34)
        Me.txtCylinders.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(297, 353)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(676, 34)
        Me.txtAddress.TabIndex = 12
        '
        'txtConName
        '
        Me.txtConName.BackColor = System.Drawing.Color.White
        Me.txtConName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConName.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConName.Location = New System.Drawing.Point(797, 149)
        Me.txtConName.Name = "txtConName"
        Me.txtConName.Size = New System.Drawing.Size(176, 34)
        Me.txtConName.TabIndex = 13
        '
        'txtDepositAmt
        '
        Me.txtDepositAmt.BackColor = System.Drawing.Color.White
        Me.txtDepositAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepositAmt.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositAmt.Location = New System.Drawing.Point(797, 280)
        Me.txtDepositAmt.Name = "txtDepositAmt"
        Me.txtDepositAmt.Size = New System.Drawing.Size(176, 34)
        Me.txtDepositAmt.TabIndex = 14
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.BorderSize = 5
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(500, 439)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(180, 51)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 603)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDepositAmt)
        Me.Controls.Add(Me.txtConName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCylinders)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtConNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lable1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnMasterFile As ToolStripMenuItem
    Friend WithEvents mnTrans As ToolStripMenuItem
    Friend WithEvents mnExit As ToolStripMenuItem
    Friend WithEvents txtConNo As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtCylinders As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtConName As TextBox
    Friend WithEvents txtDepositAmt As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents mnItmAdd As ToolStripMenuItem
    Friend WithEvents mnItmUpdate As ToolStripMenuItem
    Friend WithEvents mnItmDelete As ToolStripMenuItem
    Friend WithEvents mnShowConsumer As ToolStripMenuItem
End Class
