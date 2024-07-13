Imports System.Data.SqlClient

Public Class frmAddBrandCompany
    Private XCLS As New ClsMain

    Private VarBranCompID As Integer
    Private VarBranCompName, VarBranCompLatin As String
    Private VarBranCompStatus As Integer = 1



    Private sQLInsert As String = "Insert Into BrandCompany (BranCompName,BranCompLatin,BranCompStatus,InsertTime,UserID_Insert)values(@BranCompName,@BranCompLatin,@BranCompStatus,@InsertTime,@UserID_Insert)"
    Private sQLUpdate As String
    Private sQLDelete As String

    Private Sub NewSaveStatus()
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub ClearCN()
        Me.txtBranCompName.Text = ""
        Me.txtBranCompLatin.Text = ""
        Me.txtBranCompID.Text = ""
    End Sub


    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                VarBGW_Status = True
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex.Message)
        Finally
            sQlConnection.Close()
        End Try

    End Sub

    Private Sub frmAddBrandCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        Try
            If VarBGW_Status = True Then
                lblUsername.Text = VarUserName
                NewSaveStatus()
                ClearCN()
                Call MYSP_Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        'VarBranCompID = CInt(Me.txtBranCompID.Text)
        VarBranCompName = Trim(Me.txtBranCompName.Text)
        VarBranCompLatin = Trim(Me.txtBranCompLatin.Text)
        VarBranCompStatus = 1
        BGW_Save.RunWorkerAsync()
    End Sub

    Private Sub MYSP_Show()
        Me.Timer1.Start()
        Me.PB.Visible = True
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            Dim Cmd As New SqlCommand(sQLInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@BranCompName", SqlDbType.VarChar).Value = VarBranCompName
                .Parameters.AddWithValue("@BranCompLatin", SqlDbType.VarChar).Value = VarBranCompLatin
                .Parameters.AddWithValue("@BranCompStatus", SqlDbType.Int).Value = VarBranCompStatus
                .Parameters.AddWithValue("@InsertTime", SqlDbType.Date).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            Call MYSP_Hide()
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If

    End Sub

    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1
    End Sub

End Class