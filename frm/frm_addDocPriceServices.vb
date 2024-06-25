Imports System.Data.SqlClient
Public Class frm_addDocPriceServices
    Dim ad As New SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable

    Private VarDocPriceServicesStatus As Integer
    Private VarDocPriceServicesID As Integer
    Private VarDocterName As Decimal
    Private VarDocServices As Decimal

    Private sqlDocPriceServices As String = "SELECT DocPriceServicesID,tbDocServicesName,PatientPrice,DoctorsRate,DocterName FROM vDocPriceServices Where DocPriceServicesStatus=1"
    Private sQLDoctor As String = "SELECT DocterID ,DocterName FROM tbDoctors Where DocterStatus=1"
    Private sQLDocServices As String = "SELECT tbDocServicesID,tbDocServicesName FROM tbDocServices Where tbDocServicesStatus=1"

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

    Private Sub FILLCMB_Doc()
        Dim cmd1 = New SqlCommand(sQLDoctor, sQlConnection)
        Dim ad1 = New SqlDataAdapter(cmd1)
        Dim dt1 = New DataTable
        ad1.Fill(dt1)
        cmbDocterName.DataSource = dt1

        cmbDocterName.DisplayMember = "DocterName"
        cmbDocterName.ValueMember = "DocterID"
    End Sub
    Private Sub FILLCMB_DocServices()
        Dim cmd2 = New SqlCommand(sQLDocServices, sQlConnection)
        Dim ad2 = New SqlDataAdapter(cmd2)
        Dim dt2 = New DataTable
        ad2.Fill(dt2)

        cmbDocServices.DataSource = dt2
        cmbDocServices.DisplayMember = "tbDocServicesName"
        cmbDocServices.ValueMember = "tbDocServicesID"
    End Sub
    Private Sub FillDGV()

        Dim cmd = New SqlCommand(sqlDocPriceServices, sQlConnection)
        Dim ad = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        ad.Fill(dt)
        DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).HeaderText = "كود الخدمة"
        Me.DataGridView1.Columns(1).HeaderText = "اسم الخدمة"
        Me.DataGridView1.Columns(2).HeaderText = "سعر المريض"
        Me.DataGridView1.Columns(3).HeaderText = "نسبة الدكتور"
        Me.DataGridView1.Columns(4).HeaderText = "اسم الدكتور"
    End Sub
    Private Sub frm_addDocPriceServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub ClearCN()
        cmbDocServices.Text = ""
        txtPatientPrice.Text = ""
        txtDoctorsRate.Text = ""
        cmbDocterName.Text = ""
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
            FILLCMB_Doc()
            FILLCMB_DocServices()
            FillDGV()
            ClearCN()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            VarBGW_Status = True
            VarDocPriceServicesID = 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tbDocPriceServices (DocServicesID,PatientPrice,DoctorsRate,DocterID,DocPriceServicesStatus,InsertTime,UserID) VALUES (@DocServicesID,@PatientPrice,@DoctorsRate,@DocterID,@DocPriceServicesStatus,@InsertTime,@UserID)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@DocServicesID", SqlDbType.Decimal).Value = VarDocServices
                .Parameters.AddWithValue("@PatientPrice", SqlDbType.Decimal).Value = Me.txtPatientPrice.Text
                .Parameters.AddWithValue("@DoctorsRate", SqlDbType.Int).Value = Me.txtDoctorsRate.Text
                .Parameters.AddWithValue("@DocterID", SqlDbType.Int).Value = VarDocterName
                .Parameters.AddWithValue("@DocPriceServicesStatus", SqlDbType.Int).Value = VarDocPriceServicesID
                .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = VarUserID
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم حفظ السجل بنجاح", MsgBoxStyle.Information, "الحفظ")
            Cmd = Nothing

        Catch ex As Exception
            MsgBox(ex)
            sQlConnection.Close()
        Finally
            sQlConnection.Close()
        End Try
    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            FILLCMB_Doc()
            FILLCMB_DocServices()
            FillDGV()
            ClearCN()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()
        VarDocterName = Me.cmbDocterName.SelectedValue
        VarDocServices = Me.cmbDocServices.SelectedValue
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
                    .CommandText = "Update tbDocPriceServices Set DocServicesID=@DocServicesID,PatientPrice=@PatientPrice,DoctorsRate=@DoctorsRate,DocterID=@DocterID,EditTime=@EditTime Where DocPriceServicesID=@DocPriceServicesID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocServicesID", SqlDbType.Int).Value = VarDocServices
                    .Parameters.AddWithValue("@PatientPrice", SqlDbType.Decimal).Value = Me.txtPatientPrice.Text
                    .Parameters.AddWithValue("@DoctorsRate", SqlDbType.Int).Value = Me.txtDoctorsRate.Text
                    .Parameters.AddWithValue("@DocterID", SqlDbType.Int).Value = VarDocterName
                    .Parameters.AddWithValue("@EditTime", SqlDbType.DateTime).Value = VarUpdateTime
                    .Parameters.AddWithValue("@DocPriceServicesID", SqlDbType.Int).Value = VarDocPriceServicesID
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
            FILLCMB_Doc()
            FILLCMB_DocServices()
            FillDGV()
            ClearCN()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call MYSP_Show()
        BGW_Edit.RunWorkerAsync()
        VarDocterName = Me.cmbDocterName.SelectedValue
        VarDocServices = Me.cmbDocServices.SelectedValue
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        VarDocPriceServicesID = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        cmbDocServices.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        txtPatientPrice.Text = DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        txtDoctorsRate.Text = DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        cmbDocterName.Text = DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الحذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                VarDocPriceServicesStatus = 0
                Dim Cmd As New SqlCommand
                With Cmd
                    .Connection = sQlConnection
                    .CommandType = CommandType.Text
                    .CommandText = "Update tbDocPriceServices Set DocPriceServicesStatus=@DocPriceServicesStatus,DeleteTime=@DeleteTime Where DocPriceServicesID=@DocPriceServicesID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@DocPriceServicesStatus", SqlDbType.Int).Value = VarDocPriceServicesStatus
                    .Parameters.AddWithValue("@DeleteTime", SqlDbType.DateTime).Value = VarDeleteTime
                    .Parameters.AddWithValue("@DocPriceServicesID", SqlDbType.Int).Value = VarDocPriceServicesID
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

    Private Sub BGW_Delete_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Delete.RunWorkerCompleted
        If VarBGW_Status = True Then
            FILLCMB_Doc()
            FILLCMB_DocServices()
            FillDGV()
            ClearCN()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
End Class