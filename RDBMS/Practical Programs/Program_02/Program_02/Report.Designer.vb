<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EB_HomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EBDBDataSet = New Program_02.EBDBDataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EB_HomeTableAdapter = New Program_02.EBDBDataSetTableAdapters.EB_HomeTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TransactionsTableAdapter = New Program_02.EBDBDataSetTableAdapters.TransactionsTableAdapter()
        Me.ReportLabel = New System.Windows.Forms.Label()
        CType(Me.EB_HomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EBDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EB_HomeBindingSource
        '
        Me.EB_HomeBindingSource.DataMember = "EB_Home"
        Me.EB_HomeBindingSource.DataSource = Me.EBDBDataSet
        '
        'EBDBDataSet
        '
        Me.EBDBDataSet.DataSetName = "EBDBDataSet"
        Me.EBDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.EBDBDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "EBHomeDataSet"
        ReportDataSource1.Value = Me.EB_HomeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Program_02.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 307)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1124, 241)
        Me.ReportViewer1.TabIndex = 0
        '
        'EB_HomeTableAdapter
        '
        Me.EB_HomeTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.TransactionsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Program_02.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 66)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1124, 241)
        Me.ReportViewer2.TabIndex = 1
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'ReportLabel
        '
        Me.ReportLabel.AutoSize = True
        Me.ReportLabel.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportLabel.Location = New System.Drawing.Point(246, 9)
        Me.ReportLabel.Name = "ReportLabel"
        Me.ReportLabel.Size = New System.Drawing.Size(0, 40)
        Me.ReportLabel.TabIndex = 2
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 548)
        Me.Controls.Add(Me.ReportLabel)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportHome"
        CType(Me.EB_HomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EBDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EB_HomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EBDBDataSet As Program_02.EBDBDataSet
    Friend WithEvents EB_HomeTableAdapter As Program_02.EBDBDataSetTableAdapters.EB_HomeTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As Program_02.EBDBDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents ReportLabel As System.Windows.Forms.Label
End Class
