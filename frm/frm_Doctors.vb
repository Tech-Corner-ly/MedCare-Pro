Imports System.Data.SqlClient

Public Class frm_Doctors
    Dim dt As New DataTable
    Public VarDoctorID As Integer
    Public VarDocSpecialization As Integer
    Private sQLSelDoctors As String = "SELECT DocterID,DocterName,DocSpecializationName,DocterPhone FROM vDoctors Where DocterStatus=1"
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
    Private Sub FillCMB()
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select DocSpecializationID,DocSpecializationName FROM tbDocSpecialization ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            Me.cmbDocSpecializationID.DataSource = DT
            Me.cmbDocSpecializationID.ValueMember = "DocSpecializationID"
            Me.cmbDocSpecializationID.DisplayMember = "DocSpecializationName"
        Else
            Me.cmbDocSpecializationID.DataSource = Nothing
        End If

    End Sub
    Private Sub fillDGV()
        Dim sQlDataAdapter As New SqlDataAdapter(sQLSelDoctors, sQlConnection)
        dt.Clear()
        sQlDataAdapter.Fill(dt)

        DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).HeaderText = "الكود"
        Me.DataGridView1.Columns(1).HeaderText = "اسم الدكتور/ة"
        Me.DataGridView1.Columns(2).HeaderText = "التخصص"
        Me.DataGridView1.Columns(3).HeaderText = "الهاتف"
    End Sub
    Private Sub ClearCN()
        txtDocterName.Text = ""
        Me.cmbDocSpecializationID.Text = ""
        txtDocterPhone.Text = ""

    End Sub
    Private Sub frm_Doctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        VarDoctorID = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtDocterName.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        cmbDocSpecializationID.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtDocterPhone.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " DocterName LIKE '%" & TextBox1.Text & "%' "
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub
    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        If VarBGW_Status = True Then
            fillDGV()
            FillCMB()
            ClearCN()
            lblUsername.Text = VarUserName
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
                .CommandText = "Insert Into tbDoctors (DocterName,DocterPhone,DocSpecializationID,InsertTime,UserID)values(@DocterName,@DocterPhone,@DocSpecializationID,@InsertTime,@UserID)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@DocterName", SqlDbType.VarChar).Value = Me.txtDocterName.Text
                .Parameters.AddWithValue("@DocterPhone", SqlDbType.Int).Value = Me.txtDocterPhone.Text
                .Parameters.AddWithValue("@DocSpecializationID", SqlDbType.Int).Value = VarDocSpecialization
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
            sQlConnection.Close()
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
                    .CommandText = "Update tbDoctors Set DocterName = @DocterName,DocterPhone = @DocterPhone,DocSpecializationID = @DocSpecializationID,EditTime = @EditTime Where DocterID = @DocterID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocterName", SqlDbType.VarChar).Value = txtDocterName.Text
                    .Parameters.AddWithValue("@DocterPhone", SqlDbType.Int).Value = txtDocterPhone.Text
                    .Parameters.AddWithValue("@DocSpecializationID", SqlDbType.Int).Value = VarDocSpecialization
                    .Parameters.AddWithValue("@EditTime", SqlDbType.Date).Value = VarUpdateTime
                    .Parameters.AddWithValue("@DocterID", SqlDbType.Int).Value = VarDoctorID
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
            BGW_Load.RunWorkerAsync()

        End If
        Call MYSP_Hide()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()
        VarDocSpecialization = Me.cmbDocSpecializationID.SelectedValue

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        VarDocSpecialization = Me.cmbDocSpecializationID.SelectedValue
        Call MYSP_Show()
        BGW_Edit.RunWorkerAsync()
    End Sub
    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الحذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                Dim VarDocterStatus As Integer = 0
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tbDoctors Set DocterStatus = @DocterStatus,DeleteTime = @DeleteTime Where DocterID = @DocterID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocterStatus", SqlDbType.Int).Value = VarDocterStatus
                    .Parameters.AddWithValue("@DeleteTime", SqlDbType.Date).Value = VarDeleteTime
                    .Parameters.AddWithValue("@DocterID", SqlDbType.Int).Value = VarDoctorID
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
        End Try
    End Sub
    Private Sub BGW_Delete_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Delete.RunWorkerCompleted
        If VarBGW_Status = True Then
            BGW_Load.RunWorkerAsync()

        End If
        Call MYSP_Hide()
    End Sub
End Class