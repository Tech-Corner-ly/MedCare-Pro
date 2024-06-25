Imports System.Data.SqlClient

Public Class frm_Patient
    Dim dt As New DataTable
    Private VarPatientID As Integer
    Private VarCity As Integer
    Private VarPatientStatus As Integer = 1
    Private sQLSelPatient As String = "SELECT PatientID,PatientName,PatientPhone,PatientAddress,CityName FROM vPatient Where PatientStatus=1"

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
        DA = New SqlDataAdapter("Select CityID,CityName FROM tbCities ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbCityID.DataSource = DT
            cmbCityID.ValueMember = "CityID"
            cmbCityID.DisplayMember = "CityName"
        Else
            cmbCityID.DataSource = Nothing
        End If

    End Sub
    Private Sub fillDGV()
        Dim sQlDataAdapter As New SqlDataAdapter(sQLSelPatient, sQlConnection)
        dt.Clear()
        sQlDataAdapter.Fill(dt)
        DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).HeaderText = "الكود"
        Me.DataGridView1.Columns(1).HeaderText = "اسم المريض/ة"
        Me.DataGridView1.Columns(2).HeaderText = "رقم الهاتف"
        Me.DataGridView1.Columns(3).HeaderText = "العنوان"
        Me.DataGridView1.Columns(4).HeaderText = "المدينة"
    End Sub
    Private Sub ClearCN()
        txtPatientName.Text = ""
        txtPatientPhone.Text = ""
        txtPatientPhone.Text = ""
        cmbCityID.Text = ""

    End Sub


    Private Sub frm_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSave.Enabled = False
        btnNew.Enabled = False
        btnClose.Enabled = False
        VarPatientID = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        txtPatientName.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        txtPatientPhone.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtPatientAddress.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        cmbCityID.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " DocterName LIKE '%" & txtSearch.Text & "%' "
        Catch ex As Exception
            MsgBox(ex)
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

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            VarBGW_Status = True
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "Insert Into tbPatient (PatientName,PatientPhone,PatientAddress,CityID,PatientStatus,InsertTime,UserID)values(@PatientName,@PatientPhone,@PatientAddress,@CityID,@PatientStatus,@InsertTime,@UserID)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@PatientName", SqlDbType.VarChar).Value = Me.txtPatientName.Text
                .Parameters.AddWithValue("@PatientPhone", SqlDbType.Int).Value = Me.txtPatientPhone.Text
                .Parameters.AddWithValue("@PatientAddress", SqlDbType.VarChar).Value = Me.txtPatientAddress.Text
                .Parameters.AddWithValue("@CityID", SqlDbType.Int).Value = VarCity
                .Parameters.AddWithValue("@PatientStatus", SqlDbType.Int).Value = VarPatientStatus
                .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID", SqlDbType.DateTime).Value = VarUserID
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            BGW_Load.RunWorkerAsync()


        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()
        VarCity = Me.cmbCityID.SelectedValue
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
            FillCMB()
            fillDGV()
            ClearCN()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            btnSave.Enabled = True
            btnNew.Enabled = True
            btnClose.Enabled = True
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
                    .CommandText = "Update tbPatient Set PatientName = @PatientName,PatientPhone = @PatientPhone,PatientAddress = @PatientAddress,CityID = @CityID,EditTime=@EditTime Where PatientID = @PatientID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@PatientName", SqlDbType.VarChar).Value = txtPatientName.Text
                    .Parameters.AddWithValue("@PatientPhone", SqlDbType.Int).Value = txtPatientPhone.Text
                    .Parameters.AddWithValue("@PatientAddress", SqlDbType.VarChar).Value = txtPatientAddress.Text
                    .Parameters.AddWithValue("@CityID", SqlDbType.Int).Value = VarCity
                    .Parameters.AddWithValue("@EditTime", SqlDbType.DateTime).Value = VarUpdateTime
                    .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = VarPatientID
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
        VarCity = Me.cmbCityID.SelectedValue
    End Sub

    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الحذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                VarPatientStatus = 0
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tbPatient Set PatientStatus = @PatientStatus,DeleteTime = @DeleteTime Where PatientID = @PatientID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@PatientStatus", SqlDbType.VarChar).Value = VarPatientStatus
                    .Parameters.AddWithValue("@DeleteTime", SqlDbType.Int).Value = VarDeleteTime
                    .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = VarPatientID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "الحذف")
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()
    End Sub

    Private Sub BGW_Delete_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Delete.RunWorkerCompleted
        If VarBGW_Status = True Then
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
End Class