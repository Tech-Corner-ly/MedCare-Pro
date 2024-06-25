Imports System.Data.SqlClient

Public Class frm_Clinic
    Private VarClinicID As Integer
    Private VarClinicStatus As Integer = 1

    Private sQLSelClincic As String = "SELECT ClinicID,ClinicName FROM tblClinics Where ClinicStatus=1"
    Private Sub MYSP_Show()
        Me.Timer1.Start()
        Me.PB.Visible = True
    End Sub

    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1

    End Sub
    Private Sub ClearCN()
        txtClinicName.Text = ""
        VarClinicStatus = 1
    End Sub

    Private Sub FillDGV()
        Dim cmd = New SqlCommand(sQLSelClincic, sQlConnection)
        Dim ad = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()
    End Sub

    Private Sub frm_Clinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call MYSP_Show()
        BGW_Edit.RunWorkerAsync()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        VarClinicID = DataGridView1.CurrentRow.Cells.Item(0).Value
        txtClinicName.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearCN()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            VarBGW_Status = True
        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub
        End Try
    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        If VarBGW_Status = True Then
            FillDGV()
            ClearCN()
        End If
        Call MYSP_Hide()


    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            VarBGW_Status = True
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblClinics (ClinicName,ClinicStatus) VALUES (@ClinicName,@ClinicStatus)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@ClinicName", SqlDbType.VarChar).Value = txtClinicName.Text
                .Parameters.AddWithValue("@ClinicStatus", SqlDbType.Int).Value = VarClinicStatus
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex)
        End Try
    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            FillDGV()
            ClearCN()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub BGW_Edit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Edit.DoWork
        Try
            MessageBox.Show("هل تريد التعديل؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tblClinics Set ClinicName = @ClinicName Where ClinicID=@ClinicID"
                    .Parameters.AddWithValue("@ClinicName", SqlDbType.VarChar).Value = txtClinicName.Text
                    .Parameters.AddWithValue("@ClinicID", SqlDbType.Int).Value = VarClinicID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
                Cmd = Nothing
            Else
                Exit Sub
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex)
        End Try
    End Sub

    Private Sub BGW_Edit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Edit.RunWorkerCompleted
        If VarBGW_Status = True Then
            FillDGV()
            ClearCN()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الخذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                VarClinicStatus = 0
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tblClinics Set ClinicStatus = @ClinicStatus Where ClinicID=@ClinicID"
                    .Parameters.AddWithValue("@ClinicStatus", SqlDbType.Int).Value = 0
                    .Parameters.AddWithValue("@ClinicID", SqlDbType.Int).Value = VarClinicID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "حذف")
                Cmd = Nothing
            Else
                Exit Sub
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex)
        End Try
    End Sub

    Private Sub BGW_Delete_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Delete.RunWorkerCompleted
        If VarBGW_Status = True Then
            FillDGV()
            ClearCN()
        End If
        Call MYSP_Hide()
    End Sub
End Class