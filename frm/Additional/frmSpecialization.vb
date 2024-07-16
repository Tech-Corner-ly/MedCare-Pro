Imports System.Data.SqlClient

Public Class frmSpecialization

    'Var
    Private XCLS As New ClsMain
    'Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    'Private MyVarDT_Countries As DataTable = New DataTable
    Private MyVarDT_Specialization As DataTable = New DataTable
    Private MyVarDV_Specialization As DataView = New DataView
    'Private VarAdministrativeTypeDT As DataTable = New DataTable


    Private VarSelAdjective As String
    Private VarSpecializationName As String
    Public VarDocSpecializationID As Integer
    Public VarSpecializationStatus As Integer = 1
    Private VarCount As String
    Private dt As New DataTable

    Private sQLDeleteSpeci As String = "Update tbSpecialization Set SpecializationStatus=@SpecializationStatus,DeleteTime=@DeleteTime,UserID_Delete=@UserID_Delete Where SpecializationID=@SpecializationID"
    Private sQLUpdateSpeci As String = "Update tbSpecialization Set SpecializationName=@SpecializationName,Adjective=@Adjective,UpdateTime=@UpdateTime,UserID_Update=@UserID_Update Where SpecializationID=@SpecializationID"
    Private sQLInsertSpeci As String = "Insert Into tbSpecialization (SpecializationName,Adjective,SpecializationStatus,InsertTime,UserID_Insert)values(@SpecializationName,@Adjective,@SpecializationStatus,@InsertTime,@UserID_Insert)"
    Private sQLSpecialization As String = "SELECT SpecializationID ,SpecializationName,Adjective FROM tbSpecialization Where SpecializationStatus=1"

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

    Private Sub btnNewSave()
        Me.btnNew.Enabled = False
        Me.btnSave.Enabled = False
        Me.btnUpdate.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnClose.Enabled = False
    End Sub

    Private Sub btnDeleteUpdate()
        Me.btnNew.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnClose.Enabled = True

    End Sub
    Private Sub ClearCN()
        Me.txtSpecializationName.Text = ""
        Me.cmbAdjective.Text = ""
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        VarDocSpecializationID = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        Me.txtSpecializationName.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        Me.cmbAdjective.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        btnNewSave()
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
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_Specialization.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLSpecialization, MyVarDT_Specialization)
                VarBGW_Status = True
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex.Message)
        Finally
            sQlConnection.Close()
        End Try
    End Sub
    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        If VarBGW_Status = True Then

            Me.cmbAdjective.DataSource = VarAdjective
            Call XCLS.MyCodes_Fill_Dgv(Me.DataGridView1, lblCount, MyVarDT_Specialization, MyVarDV_Specialization)
            lblUsername.Text = VarUserName
            btnDeleteUpdate()
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
        VarSpecializationName = Me.txtSpecializationName.Text
        VarSelAdjective = Me.cmbAdjective.Text


    End Sub
    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            VarBGW_Status = True
            Dim Cmd As New SqlCommand(sQLInsertSpeci, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@SpecializationName", SqlDbType.VarChar).Value = VarSpecializationName
                .Parameters.AddWithValue("@Adjective", SqlDbType.VarChar).Value = VarSelAdjective
                .Parameters.AddWithValue("@SpecializationStatus", SqlDbType.Int).Value = VarSpecializationStatus
                .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
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
        btnDeleteUpdate()
    End Sub

    Private Sub BGW_Edit_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Edit.DoWork
        Try
            MessageBox.Show("هل تريد التعديل؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                Dim Cmd As New SqlCommand(sQLUpdateSpeci, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@SpecializationName", SqlDbType.VarChar).Value = VarSpecializationName
                    .Parameters.AddWithValue("@Adjective", SqlDbType.VarChar).Value = VarSelAdjective
                    .Parameters.AddWithValue("@UpdateTime", SqlDbType.DateTime).Value = VarUpdateTime
                    .Parameters.AddWithValue("@UserID_Update", SqlDbType.Int).Value = VarUserID
                    .Parameters.AddWithValue("@SpecializationID", SqlDbType.Int).Value = VarDocSpecializationID
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
        btnDeleteUpdate()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call MYSP_Show()
        VarSpecializationName = Me.txtSpecializationName.Text
        VarSelAdjective = Me.cmbAdjective.Text
        BGW_Edit.RunWorkerAsync()
    End Sub

    Private Sub BGW_Delete_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Delete.DoWork
        Try
            MessageBox.Show("هل تريد الحذف؟", "تحذير!", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                VarBGW_Status = True
                VarSpecializationStatus = 0
                Dim Cmd As New SqlCommand(sQLDeleteSpeci, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@SpecializationStatus", SqlDbType.Int).Value = VarSpecializationStatus
                    .Parameters.AddWithValue("@DeleteTime", SqlDbType.DateTime).Value = VarDeleteTime
                    .Parameters.AddWithValue("@UserID_Delete", SqlDbType.Int).Value = VarUserID
                    .Parameters.AddWithValue("@SpecializationID", SqlDbType.Int).Value = VarDocSpecializationID
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
        btnDeleteUpdate()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call MYSP_Show()
        BGW_Delete.RunWorkerAsync()
    End Sub

    Private Sub frmSpecialization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub
End Class