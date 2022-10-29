<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Program_03DBDataSet = New Program_03.Program_03DBDataSet()
        Me.ConsumerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportLable = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsumerTableAdapter = New Program_03.Program_03DBDataSetTableAdapters.ConsumerTableAdapter()
        Me.TransactionsTableAdapter = New Program_03.Program_03DBDataSetTableAdapters.TransactionsTableAdapter()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Program_03DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.Program_03DBDataSet
        '
        'Program_03DBDataSet
        '
        Me.Program_03DBDataSet.DataSetName = "Program_03DBDataSet"
        Me.Program_03DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsumerBindingSource
        '
        Me.ConsumerBindingSource.DataMember = "Consumer"
        Me.ConsumerBindingSource.DataSource = Me.Program_03DBDataSet
        '
        'ReportLable
        '
        Me.ReportLable.AutoSize = True
        Me.ReportLable.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportLable.Location = New System.Drawing.Point(161, 79)
        Me.ReportLable.Name = "ReportLable"
        Me.ReportLable.Size = New System.Drawing.Size(841, 36)
        Me.ReportLable.TabIndex = 1
        Me.ReportLable.Text = "DOMESTIC GAS CONSUMER INFORMATION REPORT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1096, 35)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnExit
        '
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(69, 31)
        Me.mnExit.Text = "Exit"
        '
        'HomeReport
        '
        Me.HomeReport.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ConsumerBindingSource
        Me.HomeReport.LocalReport.DataSources.Add(ReportDataSource2)
        Me.HomeReport.LocalReport.ReportEmbeddedResource = "Program_03.Report1.rdlc"
        Me.HomeReport.Location = New System.Drawing.Point(0, 169)
        Me.HomeReport.Name = "HomeReport"
        Me.HomeReport.Size = New System.Drawing.Size(1096, 236)
        Me.HomeReport.TabIndex = 21
        '
        'ConsumerTableAdapter
        '
        Me.ConsumerTableAdapter.ClearBeforeFill = True
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 405)
        Me.Controls.Add(Me.HomeReport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReportLable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Program_03DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportLable As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnExit As ToolStripMenuItem
    Friend WithEvents HomeReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsumerBindingSource As BindingSource
    Friend WithEvents Program_03DBDataSet As Program_03DBDataSet
    Friend WithEvents ConsumerTableAdapter As Program_03DBDataSetTableAdapters.ConsumerTableAdapter
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As Program_03DBDataSetTableAdapters.TransactionsTableAdapter
End Class
