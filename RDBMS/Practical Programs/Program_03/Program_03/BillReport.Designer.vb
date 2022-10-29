<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportLable = New System.Windows.Forms.Label()
        Me.BillRptViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Program_03DBDataSet = New Program_03.Program_03DBDataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New Program_03.Program_03DBDataSetTableAdapters.TransactionsTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Program_03DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 35)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnExit
        '
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(69, 31)
        Me.mnExit.Text = "Exit"
        '
        'ReportLable
        '
        Me.ReportLable.AutoSize = True
        Me.ReportLable.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportLable.Location = New System.Drawing.Point(73, 60)
        Me.ReportLable.Name = "ReportLable"
        Me.ReportLable.Size = New System.Drawing.Size(841, 36)
        Me.ReportLable.TabIndex = 22
        Me.ReportLable.Text = "DOMESTIC GAS CONSUMER INFORMATION REPORT"
        '
        'BillRptViewer
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TransactionsBindingSource
        Me.BillRptViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.BillRptViewer.LocalReport.ReportEmbeddedResource = "Program_03.Report2.rdlc"
        Me.BillRptViewer.Location = New System.Drawing.Point(0, 144)
        Me.BillRptViewer.Name = "BillRptViewer"
        Me.BillRptViewer.Size = New System.Drawing.Size(982, 246)
        Me.BillRptViewer.TabIndex = 23
        '
        'Program_03DBDataSet
        '
        Me.Program_03DBDataSet.DataSetName = "Program_03DBDataSet"
        Me.Program_03DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.Program_03DBDataSet
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 27)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "TNNO 12345"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(707, 114)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 27)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cylinder Weight : 39.9Kg"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 27)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Signature :"
        '
        'BillReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 457)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BillRptViewer)
        Me.Controls.Add(Me.ReportLable)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BillReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillReport"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Program_03DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnExit As ToolStripMenuItem
    Friend WithEvents ReportLable As Label
    Friend WithEvents BillRptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents Program_03DBDataSet As Program_03DBDataSet
    Friend WithEvents TransactionsTableAdapter As Program_03DBDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
