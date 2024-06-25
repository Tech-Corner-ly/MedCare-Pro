Imports System.Data.SqlClient

Public Class frm_DocSpecialization
    Public VarDocSpecializationID As Integer
    Public VarDocSpecializationStatus As Integer = 1
    Private dt As New DataTable
    Private sQLSelDocSpecialization As String = "SELECT DocSpecializationID ,DocSpecializationName FROM tbDocSpecialization Where DocSpecializationStatus=1"

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
        txtSpecializationName.Text = ""
    End Sub
    Private Sub FillDGV()
        Dim sQlDataAdapter As New SqlDataAdapter(sQLSelDocSpecialization, sQlConnection)
        dt.Clear()
        sQlDataAdapter.Fill(dt)
        DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).HeaderText = "الكود"
        Me.DataGridView1.Columns(1).HeaderText = "التخصص"
    End Sub
    Private Sub frm_DocSpecialization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        VarDocSpecializationID = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtSpecializationName.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " DocSpecializationName LIKE '%" & txtSearch.Text & "%' "
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) 
        Me.Dispose()
        Me.Close()
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
            lblUsername.Text = VarUserName
        End If
        Call MYSP_Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()
    End Sub
    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            VarBGW_Status = True
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "Insert Into tbDocSpecialization (DocSpecializationName,DocSpecializationStatus,InsertTime,UserID)values(@DocSpecializationName,@DocSpecializationStatus,@InsertTime,@UserID)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@DocSpecializationName", SqlDbType.VarChar).Value = txtSpecializationName.Text
                .Parameters.AddWithValue("@DocSpecializationStatus", SqlDbType.Int).Value = VarDocSpecializationStatus
                .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = VarUserID
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
            BGW_Load.RunWorkerAsync()
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
                    .CommandText = "Update tbDocSpecialization Set DocSpecializationName=@DocSpecializationName,EditTime=@EditTime Where DocSpecializationID=@DocSpecializationID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocSpecializationName", SqlDbType.VarChar).Value = txtSpecializationName.Text
                    .Parameters.AddWithValue("@EditTime", SqlDbType.DateTime).Value = VarUpdateTime
                    .Parameters.AddWithValue("@DocSpecializationID", SqlDbType.Int).Value = VarDocSpecializationID
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
            sQlConnection.Close()
        End Try
    End Sub

    Private Sub BGW_Edit_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Edit.RunWorkerCompleted
        If VarBGW_Status = True Then
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call MYSP_Show()
        BGW_Edit.RunWorkerAsync()
    End Sub

    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الحذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                VarDocSpecializationStatus = 0
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tbDocSpecialization Set DocSpecializationStatus=@DocSpecializationStatus,DeleteTime=@DeleteTime Where DocSpecializationID=@DocSpecializationID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocSpecializationStatus", SqlDbType.Int).Value = VarDocSpecializationStatus
                    .Parameters.AddWithValue("@DeleteTime", SqlDbType.DateTime).Value = VarDeleteTime
                    .Parameters.AddWithValue("@DocSpecializationID", SqlDbType.Int).Value = VarDocSpecializationID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم الحذف السجل بنجاح", MsgBoxStyle.Information, "الحذف")
                Cmd = Nothing
            Else
                Exit Sub
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex)
            sQlConnection.Close()
        End Try
    End Sub

    Private Sub BGW_Delete_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Delete.RunWorkerCompleted
        If VarBGW_Status = True Then
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()
    End Sub
End Class