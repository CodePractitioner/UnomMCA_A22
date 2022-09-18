Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentMarksDBDataSet.StudentMarks' table. You can move, or remove it, as needed.
        Me.StudentMarksTableAdapter.Fill(Me.StudentMarksDBDataSet.StudentMarks)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class