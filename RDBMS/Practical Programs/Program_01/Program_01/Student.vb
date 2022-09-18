Imports System.Data.OleDb
Imports System.Configuration

Public Class Student
    Dim connection As New OleDbConnection()
    Dim command As New OleDbCommand

    Dim connectionstring = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.StudentMarksDBConnectionString").ToString()

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionstring)
        connection.Open()
        MsgBox("Database Connected")

        Dim itm As Integer
        For itm = 1 To 31
            cbxSessions.Items.Add(itm)
        Next

        cbxGender.Items.Add("Male")
        cbxGender.Items.Add("Female")

        LoadForm()

    End Sub

    Private Sub cbxSessions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxSessions.LostFocus
        Dim check As Double
        check = Val(cbxSessions.SelectedItem) / 32 * 100
        If check < 50.0 Then
            MsgBox("Attendance Lag")
            txtOSMarks.Enabled = False
            txtCPPMarks.Enabled = False
            txtRDBMSMarks.Enabled = False
        Else
            txtOSMarks.Enabled = True
            txtCPPMarks.Enabled = True
            txtRDBMSMarks.Enabled = True
        End If
    End Sub

    Private Sub btnCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculation.Click
        txtTotal.Text = Convert.ToInt16(txtOSMarks.Text) + Convert.ToInt16(txtCPPMarks.Text) + Convert.ToInt16(txtRDBMSMarks.Text)
        txtAverage.Text = Convert.ToDouble(Val(txtTotal.Text) / 3)

        If Val(txtOSMarks.Text) < 50 Or Val(txtCPPMarks.Text) < 50 Or Val(txtRDBMSMarks.Text) < 50 Then
            txtGrade.Text = "Fail"
        ElseIf Val(txtAverage.Text) > 49 And Val(txtAverage.Text) < 60 Then
            txtGrade.Text = "Second Class"
        ElseIf Val(txtAverage.Text) > 59 And Val(txtAverage.Text) < 70 Then
            txtGrade.Text = "First Class"
        ElseIf Val(txtAverage.Text) > 69 Then
            txtGrade.Text = "Distinction"
        End If
    End Sub

    Private Sub mnitemAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnitemAdd.Click
        command = New OleDbCommand
        command.Connection = connection

        If Val(txtOSMarks.Text) < 50 Or Val(txtCPPMarks.Text) < 50 Or Val(txtRDBMSMarks.Text) < 50 Then
            txtResult.Text = "Fail"
        ElseIf Val(txtOSMarks.Text) > 49 Or Val(txtCPPMarks.Text) > 49 Or Val(txtRDBMSMarks.Text) > 49 Then
            txtResult.Text = "Pass"
        End If
        Dim Attributes As String
        Attributes = "(Enr_No, Stud_Name, DOB, Gender, Marks1, Marks2, Marks3, Session_Nos, Total, Average, Result, Grade)"
        command.CommandText = "INSERT INTO StudentMarks " + Attributes + " Values (@Enr_No, @Stud_Name, @DOB, @Gender, @Marks1, @Marks2, @Marks3, @Session_Nos, @Total, @Average, @Result, @Grade)"
        command.Parameters.AddWithValue("@Enr_No", txtEnrNo.Text)
        command.Parameters.AddWithValue("@Stud_Name", txtStudName.Text)
        command.Parameters.AddWithValue("@DOB", dtpDOB.Value)
        command.Parameters.AddWithValue("@Gender", cbxGender.SelectedItem())
        command.Parameters.AddWithValue("@Marks1", Convert.ToInt32(txtOSMarks.Text))
        command.Parameters.AddWithValue("@Marks2", Convert.ToInt32(txtCPPMarks.Text))
        command.Parameters.AddWithValue("@Marks3", Convert.ToInt32(txtRDBMSMarks.Text))
        command.Parameters.AddWithValue("@Session_Nos", Convert.ToInt32(cbxSessions.SelectedItem))
        command.Parameters.AddWithValue("@Total", Convert.ToInt32(txtTotal.Text))
        command.Parameters.AddWithValue("@Average", Convert.ToDecimal(txtOSMarks.Text))
        command.Parameters.AddWithValue("@Result", txtResult.Text)
        command.Parameters.AddWithValue("@Grade", txtGrade.Text)
        command.ExecuteNonQuery()
        MsgBox("Student Record Added Successfully")
        ClearControls()
        LoadForm()
    End Sub

    Private Sub mnitmUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnitmUpdate.Click
        btnUpdate.Visible = True
        cbxEnrNo.Visible = True
        txtEnrNo.Visible = False
        command = New OleDbCommand("SELECT * FROM StudentMarks", connection)
        Dim dr = command.ExecuteReader()
        While dr.Read()
            cbxEnrNo.Items.Add(Val(dr("Enr_No").ToString()))
        End While
        dr.Close()
    End Sub

    Private Sub cbxEnrNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEnrNo.SelectedIndexChanged
        command = New OleDbCommand("SELECT * FROM StudentMarks WHERE Enr_No = @Enr_No", connection)
        command.Parameters.AddWithValue("@Enr_No", cbxEnrNo.SelectedItem())
        Dim dr = command.ExecuteReader()

        While dr.Read()
            txtStudName.Text = dr("Stud_Name").ToString()
            dtpDOB.Value = dr("DOB")
            cbxGender.Text = dr("Gender").ToString()
            cbxSessions.Text = dr("Session_Nos").ToString()
            txtOSMarks.Text = dr("Marks1").ToString()
            txtCPPMarks.Text = dr("Marks2").ToString()
            txtRDBMSMarks.Text = dr("Marks3").ToString()
        End While
        dr.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Val(txtOSMarks.Text) < 50 Or Val(txtCPPMarks.Text) < 50 Or Val(txtRDBMSMarks.Text) < 50 Then
            txtResult.Text = "Fail"
        ElseIf Val(txtOSMarks.Text) > 49 Or Val(txtCPPMarks.Text) > 49 Or Val(txtRDBMSMarks.Text) > 49 Then
            txtResult.Text = "Pass"
        End If

        Dim Attributes As String
        command = New OleDbCommand
        command.Connection = connection
        Attributes = " Stud_Name = @Stud_Name, DOB = @DOB, Gender = @Gender, Marks1 = @Marks1, Marks2 = @Marks2, Marks3 = @Marks3, Session_Nos = @Session_Nos, Total = @Total, Average = @Average, Result = @Result, Grade = @Grade"
        command.CommandText = "UPDATE StudentMarks SET " + Attributes + " WHERE Enr_No = @Enr_No"
        command.Parameters.AddWithValue("@Stud_Name", txtStudName.Text)
        command.Parameters.AddWithValue("@DOB", dtpDOB.Value)
        command.Parameters.AddWithValue("@Gender", cbxGender.SelectedItem())
        command.Parameters.AddWithValue("@Marks1", Convert.ToDouble(txtOSMarks.Text))
        command.Parameters.AddWithValue("@Marks2", Convert.ToInt32(txtCPPMarks.Text))
        command.Parameters.AddWithValue("@Marks3", Convert.ToInt32(txtRDBMSMarks.Text))
        command.Parameters.AddWithValue("@Session_Nos", Convert.ToInt32(cbxSessions.SelectedItem))
        command.Parameters.AddWithValue("@Total", Convert.ToInt32(txtTotal.Text))
        command.Parameters.AddWithValue("@Average", Convert.ToDecimal(txtOSMarks.Text))
        command.Parameters.AddWithValue("@Result", txtResult.Text)
        command.Parameters.AddWithValue("@Grade", txtGrade.Text)
        command.Parameters.AddWithValue("@Enr_No", Convert.ToInt32(cbxEnrNo.SelectedItem()))
        command.ExecuteNonQuery()
        MsgBox("Student Record Updated Successfully")

        txtEnrNo.Visible = True
        ClearControls()
        LoadForm()
    End Sub

    Private Sub mnitmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnitmDelete.Click
        Dim enr As Integer, found As Integer
        Try
            enr = InputBox("Enter the Student Roll No to be Deleted")
            command = New OleDbCommand("SELECT * FROM StudentMarks", connection)
            Dim dr = command.ExecuteReader()
            While (dr.Read())
                If Val(dr("Enr_No").ToString()) = enr Then
                    command = New OleDbCommand("DELETE FROM StudentMarks WHERE Enr_No = @Enr_No", connection)
                    command.Parameters.AddWithValue("@Enr_No", enr)
                    command.ExecuteNonQuery()
                    MsgBox("Record Deleted")
                    LoadForm()
                    found = 1
                End If
            End While
            dr.Close()

            If (found = 0) Then
                MsgBox("Record Not Found")
            End If
        Catch exec As InvalidCastException
            MsgBox("No Valid Input Given")
        Finally
            ClearControls()
            LoadForm()
        End Try

    End Sub

    Private Sub mnitmClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnitmClear.Click
        ClearControls()
    End Sub

    Private Sub mnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReport.Click
        Report.Show()
    End Sub

    Private Sub mnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnExit.Click
        connection.Close()
        End
    End Sub

    Private Sub mnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnRefresh.Click
        txtEnrNo.Visible = True
        ClearControls()
        LoadForm()
    End Sub

    Private Sub LoadForm()
        cbxEnrNo.Visible = False
        btnUpdate.Visible = False
        txtOSMarks.Enabled = False
        txtCPPMarks.Enabled = False
        txtRDBMSMarks.Enabled = False

        command.Connection = connection
        command.CommandText = "SELECT MAX(Enr_No) FROM StudentMarks"

        Dim dr = command.ExecuteReader()
        While (dr.Read())
            txtEnrNo.Text = Val(dr(0).ToString()) + 1
        End While
        dr.Close()
    End Sub

    Private Sub ClearControls()
        txtEnrNo.Text = ""
        txtStudName.Text = ""
        cbxSessions.SelectedIndex = -1
        dtpDOB.Value = dtpDOB.MaxDate
        cbxGender.SelectedIndex = -1
        txtOSMarks.Text = ""
        txtCPPMarks.Text = ""
        txtRDBMSMarks.Text = ""
        txtTotal.Text = ""
        txtAverage.Text = ""
        txtGrade.Text = ""
        txtResult.Text = ""
        cbxEnrNo.Items.Clear()
    End Sub
End Class
