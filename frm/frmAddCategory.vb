Imports System.Data.SqlClient

Public Class frmAddCategory
    Private XCLS As New ClsMain
    Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    Private VarCategorDT As DataTable = New DataTable
    Private VarSelectParentCategoryDT As DataTable = New DataTable
    Private VarListLevel As New List(Of String)({"رئيسي", "فرعي"})
    Private VarAdministrative As String
    Private VarAdministrativeStatus As Integer = 1
    Private VarLevelID As Integer
    Private VarCategoryID, VarParentCategoryID As Integer
    Private VarCategoryName As String


    Private sQLParent As String = "Insert Into tbAdministrative (AdministrativeRefre,AdministrativeRefreName,AdministrativeType,AdministrativeParentCode,AdministrativeParent,AdministrativeParentLatin,AdministrativeStatus,InsertTime,UserID_Insert)values(@AdministrativeRefre,@AdministrativeRefreName,@AdministrativeType,@AdministrativeParentCode,@AdministrativeParent,@AdministrativeParentLatin,@AdministrativeStatus,@InsertTime,@UserID_Insert)"
    Private sQLFillCMBFather As String = "SELECT AdministrativeCode,AdministrativeName FROM tbAdministrative Where AdministrativeStatus=1 AND AdministrativeType='رئيسي'"
    Private sQLCategor As String = "SELECT [CategoryID]
                                          ,[CategoryName]
                                          ,[Level]
                                      FROM [Categories]"
    Private SQLInsertCategory As String = "Insert Into Categories (CategoryName,Level)values(@CategoryName,@Level)"
    Private SQLInsertParentCategory As String = "Insert Into Categories (CategoryName,ParentCategoryID,Level)values(@CategoryName,@ParentCategoryID,@Level)"
    Private SQLSelectParentCategory As String = "SELECT [Level]
                                                      FROM [Categories]
                                                      Where [CategoryID]=@CategoryID"
    Private Sql_Dt_AllAccounts As String = "SELECT * From tbAdministrative Where AdministrativeStatus=1"

    Private Sub CleaCN()
        cmbCategoryID.Text = ""
        txtCategoryLatin.Text = ""
        txtCategoryName.Text = ""
        txtParentCategoryID.Text = ""
    End Sub

    Private Sub NewSave()
        Me.btnNew.Enabled = True
        Me.btnSave.Enabled = True
        Me.btnDelete.Visible = False
        Me.btnUpdate.Visible = False
    End Sub
    Private Sub DeleteUpdate()


    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                XCLS.MyCodes_Fill_DataTable(sQLCategor, VarCategorDT)
                VarBGW_Status = True
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex.Message)
        Finally
            sQlConnection.Close()
        End Try

    End Sub

    Private Sub frmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

        Me.cmbLevel.DataSource = VarListLevel
        Me.cmbLevel.SelectedIndex = -1

    End Sub

    Private Sub cmbCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategory.SelectionChangeCommitted
        Try
            Me.cmbCategoryID.Text = CInt(Me.cmbCategory.SelectedValue)
            Dim XlevelID As Integer
            Dim xreader As SqlDataReader
            Dim Cmd As New SqlCommand(SQLSelectParentCategory, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@CategoryID", SqlDbType.Int).Value = CInt(Me.cmbCategoryID.Text)
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


    Private Sub cmbLevel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLevel.SelectionChangeCommitted

        Try
            Select Case Me.cmbLevel.SelectedItem
                Case "رئيسي"
                    VarLevelID = 0
                    Me.cmbCategory.Enabled = False
                Case "فرعي"
                    VarLevelID = 1
                    Me.cmbCategory.Enabled = True
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
                If VarCategorDT.Rows.Count <> 0 Then
                    Call XCLS.MyCodes_CmbFill(Me.cmbCategory, VarCategorDT, "CategoryName", "CategoryID")
                    Me.cmbCategory.DataSource = VarCategorDT
                    Me.cmbCategory.SelectedIndex = -1
                    Me.cmbLevel.Text = " يرجي تحديد نوع الفئة"
                End If

            Else
                Exit Sub
            End If
            lblUsername.Text = VarUserName
            Call MYSP_Hide()
            CleaCN()
            NewSave()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'VarLevelID = Convert.ToInt64(Me.cmbLevel.SelectedValue)
        lblUsername.Text = MyPubVar_CateLevel + 1
        'VarCategoryID = CInt(Me.txtParentCategoryID.Text)
        VarParentCategoryID = CInt(Me.cmbCategory.SelectedValue)
        VarCategoryName = CStr(Me.txtCategoryName.Text)
        BGW_Save.RunWorkerAsync()
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            If VarLevelID = 0 Then
                Dim Cmd As New SqlCommand(SQLInsertCategory, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@CategoryName", SqlDbType.VarChar).Value = VarCategoryName
                    .Parameters.AddWithValue("@Level", SqlDbType.Int).Value = VarLevelID
                End With
                If sQlConnection.State = 1 Then sQlConnection.Close()
                sQlConnection.Open()
                Cmd.ExecuteNonQuery()
                sQlConnection.Close()
                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                Cmd = Nothing
            ElseIf VarLevelID = 1 Then
                Dim Cmd As New SqlCommand(SQLInsertParentCategory, sQlConnection)
                With Cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@CategoryName", SqlDbType.VarChar).Value = VarCategoryName
                    .Parameters.AddWithValue("@ParentCategoryID", SqlDbType.Int).Value = VarParentCategoryID
                    .Parameters.AddWithValue("@Level", SqlDbType.Int).Value = MyPubVar_CateLevel
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

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            Call MYSP_Hide()
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub cmbLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevel.SelectedIndexChanged
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

End Class