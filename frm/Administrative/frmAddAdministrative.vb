Imports System.Data.SqlClient

Public Class frmAddAdministrative

    Private XCLS As New ClsMain
    Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    Private VarAdministrative_DT As DataTable = New DataTable
    Private VarSelAdministrativeType As New List(Of String)({" ", "رئيسي", "فرعي"})
    Private VarAdministrative As Integer
    Private VarAdministrativeStatus As Integer = 1

    Private MaxAdministrativeID, MaxAdministrativeParentID As Integer
    Private VarAdministrativeLatin, VarAdministrativeName As String
    Private VarLevelID As Integer


    Private sQLFillAdministrative As String = "SELECT [AdministrativeID]
                                                  ,[AdministrativeName]
                                              FROM [tbAdministrative]
                                              Where [AdministrativeStatus]=1
                                              AND [Level]=0"
    Private sQLFather As String = "Insert Into tbAdministrative (AdministrativeName,AdministrativeLatin,Level,AdministrativeStatus,InsertTime)values(@AdministrativeName,@AdministrativeLatin,@Level,@AdministrativeStatus,@InsertTime)"
    Private sQLParent As String = "Insert Into tbAdministrative (AdministrativeName,AdministrativeLatin,AdministrativeParentID,Level,AdministrativeStatus,InsertTime)values(@AdministrativeName,@AdministrativeLatin,@AdministrativeParentID,@Level,@AdministrativeStatus,@InsertTime)"
    Private Sql_Dt_AllAccounts As String = "SELECT * From tbAdministrative Where AdministrativeStatus=1"
    Private sQL_GetMaxParent As String = "SELECT  Max([AdministrativeParentCode])
                                      FROM [tbAdministrative]
                                      Where [AdministrativeStatus]=1 AND [AdministrativeType]='فرعي' AND [AdministrativeRefre]=@AdministrativeRefre
                                      Group By [AdministrativeRefre]"

    Private SQLSelectParentAdministrative As String = "SELECT [Level]
                                                      FROM [tbAdministrative]
                                                      Where [AdministrativeStatus]=1
                                                      AND [AdministrativeID]=@AdministrativeID"

    Private Sub ClearCN()
        Me.cmbAdministrativeParent.SelectedIndex = -1
        Me.cmbLevel.SelectedIndex = -1
        Me.txtAdministrativeID.Text = ""
        Me.txtAdministrativeName.Text = ""
        Me.txtAdministrativeLatin.Text = ""
    End Sub
    Private Sub NewSaveStatus()
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
    End Sub
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
    Private Sub frmAddAdministrative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                VarAdministrative_DT.Clear()
                XCLS.MyCodes_Fill_DataTable(sQLFillAdministrative, VarAdministrative_DT)
                VarBGW_Status = True
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex.Message)
        Finally
            sQlConnection.Close()
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


    Private Sub cmbLevel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLevel.SelectionChangeCommitted
        Try
            Select Case Me.cmbLevel.SelectedItem
                Case "رئيسي"
                    VarLevelID = 0
                    Me.cmbAdministrativeParent.Enabled = False
                Case "فرعي"
                    VarLevelID = 1
                    Me.cmbAdministrativeParent.Enabled = True
                Case Else
                    MsgBox("يرجي تحديد نوع الحساب", MsgBoxStyle.Information, "تحذير")
                    Exit Sub
            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        Try
            If VarBGW_Status = True Then
                If VarAdministrative_DT.Rows.Count <> 0 Then
                    Call XCLS.MyCodes_CmbFill(Me.cmbAdministrativeParent, VarAdministrative_DT, "AdministrativeName", "AdministrativeID")
                    Me.cmbLevel.DataSource = VarSelAdministrativeType
                    Me.cmbLevel.Text = -1
                    Me.cmbAdministrativeParent.Text = ""
                    Me.TextBox1.Visible = False
                End If

            Else
                Exit Sub
            End If
            lblUsername.Text = VarUserName
            ClearCN()
            NewSaveStatus()
            Call MYSP_Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try

            If VarLevelID = 0 Then
                VarAdministrativeStatus = 1
                Dim Cmd As New SqlCommand(sQLFather, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@AdministrativeName", SqlDbType.NVarChar).Value = VarAdministrativeName
                    .Parameters.AddWithValue("@AdministrativeLatin", SqlDbType.NVarChar).Value = VarAdministrativeLatin
                    .Parameters.AddWithValue("@Level", SqlDbType.Int).Value = VarLevelID
                    .Parameters.AddWithValue("@AdministrativeStatus", SqlDbType.Int).Value = VarAdministrativeStatus
                    .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                    .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                Cmd = Nothing


            ElseIf VarLevelID = 1 Then
                VarAdministrativeStatus = 1
                Dim Cmd As New SqlCommand(sQLParent, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@AdministrativeName", SqlDbType.Int).Value = VarAdministrativeName
                    .Parameters.AddWithValue("@AdministrativeLatin", SqlDbType.NVarChar).Value = VarAdministrativeLatin
                    .Parameters.AddWithValue("@AdministrativeParentID", SqlDbType.NVarChar).Value = VarAdministrative
                    .Parameters.AddWithValue("@Level", SqlDbType.Int).Value = VarLevelID
                    .Parameters.AddWithValue("@AdministrativeStatus", SqlDbType.Int).Value = VarAdministrativeStatus
                    .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                    .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                Cmd = Nothing
            Else
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbAdministrativeParent_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAdministrativeParent.SelectionChangeCommitted
        Try
            Me.TextBox1.Text = CInt(Me.cmbAdministrativeParent.SelectedValue)
            Dim XlevelID As Integer
            Dim xreader As SqlDataReader
            Dim Cmd As New SqlCommand(SQLSelectParentAdministrative, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@AdministrativeID", SqlDbType.Int).Value = CInt(Me.TextBox1.Text)
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            xreader = Cmd.ExecuteReader
            xreader.Read()

            XlevelID = xreader("Level")
            MyPubVar_CateLevel = CInt(XlevelID)
            sQlConnection.Close()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        VarAdministrative = Convert.ToInt64(Me.cmbAdministrativeParent.SelectedValue)
        VarAdministrativeName = Trim(Me.txtAdministrativeName.Text)
        VarAdministrativeLatin = Trim(Me.txtAdministrativeLatin.Text)
        VarAdministrativeStatus = 1
        MyPubVar_CateLevel = MyPubVar_CateLevel + 1
        BGW_Save.RunWorkerAsync()
    End Sub
End Class