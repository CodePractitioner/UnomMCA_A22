<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRDBMSMarks = New System.Windows.Forms.TextBox()
        Me.txtCPPMarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnitemAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnitmUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnitmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnitmClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCalculation = New System.Windows.Forms.Button()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cbxSessions = New System.Windows.Forms.ComboBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.txtOSMarks = New System.Windows.Forms.TextBox()
        Me.txtEnrNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbxEnrNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGrade
        '
        Me.txtGrade.BackColor = System.Drawing.Color.White
        Me.txtGrade.Enabled = False
        Me.txtGrade.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(186, 162)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(251, 39)
        Me.txtGrade.TabIndex = 13
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAverage
        '
        Me.txtAverage.BackColor = System.Drawing.Color.White
        Me.txtAverage.Enabled = False
        Me.txtAverage.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAverage.Location = New System.Drawing.Point(186, 101)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(251, 39)
        Me.txtAverage.TabIndex = 12
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(186, 41)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(251, 39)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtResult)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtGrade)
        Me.GroupBox2.Controls.Add(Me.txtAverage)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(769, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 259)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total and Result"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.White
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(186, 214)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(251, 39)
        Me.txtResult.TabIndex = 15
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(46, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 33)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Result"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 33)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Average"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 33)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 33)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Grade"
        '
        'txtRDBMSMarks
        '
        Me.txtRDBMSMarks.BackColor = System.Drawing.Color.White
        Me.txtRDBMSMarks.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDBMSMarks.Location = New System.Drawing.Point(314, 220)
        Me.txtRDBMSMarks.Name = "txtRDBMSMarks"
        Me.txtRDBMSMarks.Size = New System.Drawing.Size(251, 39)
        Me.txtRDBMSMarks.TabIndex = 12
        Me.txtRDBMSMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCPPMarks
        '
        Me.txtCPPMarks.BackColor = System.Drawing.Color.White
        Me.txtCPPMarks.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPPMarks.Location = New System.Drawing.Point(314, 162)
        Me.txtCPPMarks.Name = "txtCPPMarks"
        Me.txtCPPMarks.Size = New System.Drawing.Size(251, 39)
        Me.txtCPPMarks.TabIndex = 11
        Me.txtCPPMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(271, 33)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Operating Systems"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnReport, Me.mnExit, Me.mnRefresh})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1283, 41)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnitemAdd, Me.mnitmUpdate, Me.mnitmDelete, Me.mnitmClear})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 37)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnitemAdd
        '
        Me.mnitemAdd.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnitemAdd.Name = "mnitemAdd"
        Me.mnitemAdd.Size = New System.Drawing.Size(290, 38)
        Me.mnitemAdd.Text = "Add Record"
        '
        'mnitmUpdate
        '
        Me.mnitmUpdate.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnitmUpdate.Name = "mnitmUpdate"
        Me.mnitmUpdate.Size = New System.Drawing.Size(290, 38)
        Me.mnitmUpdate.Text = "Update Record"
        '
        'mnitmDelete
        '
        Me.mnitmDelete.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnitmDelete.Name = "mnitmDelete"
        Me.mnitmDelete.Size = New System.Drawing.Size(290, 38)
        Me.mnitmDelete.Text = "Delete Record"
        '
        'mnitmClear
        '
        Me.mnitmClear.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnitmClear.Name = "mnitmClear"
        Me.mnitmClear.Size = New System.Drawing.Size(290, 38)
        Me.mnitmClear.Text = "Clear Record"
        '
        'mnReport
        '
        Me.mnReport.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnReport.Name = "mnReport"
        Me.mnReport.Size = New System.Drawing.Size(117, 37)
        Me.mnReport.Text = "Report"
        '
        'mnExit
        '
        Me.mnExit.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(81, 37)
        Me.mnExit.Text = "Exit"
        '
        'mnRefresh
        '
        Me.mnRefresh.Name = "mnRefresh"
        Me.mnRefresh.Size = New System.Drawing.Size(129, 37)
        Me.mnRefresh.Text = "Refresh"
        '
        'btnCalculation
        '
        Me.btnCalculation.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculation.Location = New System.Drawing.Point(769, 665)
        Me.btnCalculation.Name = "btnCalculation"
        Me.btnCalculation.Size = New System.Drawing.Size(245, 42)
        Me.btnCalculation.TabIndex = 30
        Me.btnCalculation.Text = "CALCULATION"
        Me.btnCalculation.UseVisualStyleBackColor = True
        '
        'txtStudName
        '
        Me.txtStudName.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudName.Location = New System.Drawing.Point(395, 263)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(250, 29)
        Me.txtStudName.TabIndex = 29
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(955, 250)
        Me.dtpDOB.MaxDate = New Date(2002, 12, 31, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(251, 39)
        Me.dtpDOB.TabIndex = 28
        Me.dtpDOB.Value = New Date(2002, 12, 31, 0, 0, 0, 0)
        '
        'cbxSessions
        '
        Me.cbxSessions.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSessions.FormattingEnabled = True
        Me.cbxSessions.Location = New System.Drawing.Point(394, 311)
        Me.cbxSessions.Name = "cbxSessions"
        Me.cbxSessions.Size = New System.Drawing.Size(251, 28)
        Me.cbxSessions.TabIndex = 27
        '
        'cbxGender
        '
        Me.cbxGender.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Location = New System.Drawing.Point(955, 301)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(251, 40)
        Me.cbxGender.TabIndex = 26
        '
        'txtOSMarks
        '
        Me.txtOSMarks.BackColor = System.Drawing.Color.White
        Me.txtOSMarks.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOSMarks.Location = New System.Drawing.Point(314, 101)
        Me.txtOSMarks.Name = "txtOSMarks"
        Me.txtOSMarks.Size = New System.Drawing.Size(251, 39)
        Me.txtOSMarks.TabIndex = 10
        Me.txtOSMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEnrNo
        '
        Me.txtEnrNo.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnrNo.Location = New System.Drawing.Point(395, 212)
        Me.txtEnrNo.Name = "txtEnrNo"
        Me.txtEnrNo.Size = New System.Drawing.Size(250, 29)
        Me.txtEnrNo.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRDBMSMarks)
        Me.GroupBox1.Controls.Add(Me.txtCPPMarks)
        Me.GroupBox1.Controls.Add(Me.txtOSMarks)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 323)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marks Entry"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 32)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Subject"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 33)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "RDBMS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 33)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "C ++"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Marks Obtained"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(727, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 33)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(727, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 33)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 33)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "No. Sessions Attended"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 33)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Enrollment Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "UNIVERSITY OF CHENNAI"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1053, 665)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(175, 42)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cbxEnrNo
        '
        Me.cbxEnrNo.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEnrNo.FormattingEnabled = True
        Me.cbxEnrNo.Location = New System.Drawing.Point(733, 212)
        Me.cbxEnrNo.Name = "cbxEnrNo"
        Me.cbxEnrNo.Size = New System.Drawing.Size(251, 28)
        Me.cbxEnrNo.TabIndex = 33
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 771)
        Me.Controls.Add(Me.cbxEnrNo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCalculation)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cbxSessions)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.txtEnrNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1283, 771)
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRDBMSMarks As System.Windows.Forms.TextBox
    Friend WithEvents txtCPPMarks As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnitemAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnitmUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnitmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnitmClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCalculation As System.Windows.Forms.Button
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxSessions As System.Windows.Forms.ComboBox
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtOSMarks As System.Windows.Forms.TextBox
    Friend WithEvents txtEnrNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxEnrNo As System.Windows.Forms.ComboBox
    Friend WithEvents mnRefresh As System.Windows.Forms.ToolStripMenuItem

End Class
