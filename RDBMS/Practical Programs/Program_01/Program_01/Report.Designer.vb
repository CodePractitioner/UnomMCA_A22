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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentMarksDBDataSet = New WindowsApplication1.StudentMarksDBDataSet()
        Me.StudentMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentMarksTableAdapter = New WindowsApplication1.StudentMarksDBDataSetTableAdapters.StudentMarksTableAdapter()
        CType(Me.StudentMarksDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.StudentMarksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 131)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1127, 258)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT MARKS REPORT"
        '
        'StudentMarksDBDataSet
        '
        Me.StudentMarksDBDataSet.DataSetName = "StudentMarksDBDataSet"
        Me.StudentMarksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentMarksBindingSource
        '
        Me.StudentMarksBindingSource.DataMember = "StudentMarks"
        Me.StudentMarksBindingSource.DataSource = Me.StudentMarksDBDataSet
        '
        'StudentMarksTableAdapter
        '
        Me.StudentMarksTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1127, 389)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.StudentMarksDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentMarksDBDataSet As WindowsApplication1.StudentMarksDBDataSet
    Friend WithEvents StudentMarksTableAdapter As WindowsApplication1.StudentMarksDBDataSetTableAdapters.StudentMarksTableAdapter
End Class
