Imports System.Data.SqlClient

Public Class frmAddAdministrative

    Private XCLS As New ClsMain
    Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    Private VarAdministrativeTypeDT As DataTable = New DataTable
    Private VarSelAdministrativeType As New List(Of String)({" ", "رئيسي", "فرعي"})
    Private VarAdministrative As String
    Private VarAdministrativeStatus As Integer = 1
    Private VarAdministrativeParentCode As Integer
    Private MaxAdministrativeCode As Integer
    Private MaxAdministrativeParentCode As Integer
    Private VarAdministrativeParentLatin, VarAdministrativeParent, VarAdministrativeFather, VarAdministrativeType As String

    Private sQLFillCMBFather As String = "SELECT AdministrativeCode,AdministrativeName FROM tbAdministrative Where AdministrativeStatus=1"
    Private sQLFather As String = "Insert Into tbAdministrative (AdministrativeCode,AdministrativeName,AdministrativeType,AdministrativeStatus,InsertTime,UserID_Insert)values(@AdministrativeCode,@AdministrativeName,@AdministrativeType,@AdministrativeStatus,@InsertTime,@UserID_Insert)"
    Private sQLParent As String = "Insert Into tbAdministrative (AdministrativeRefre,AdministrativeType,AdministrativeParentCode,AdministrativeParent,AdministrativeStatus,InsertTime,UserID_Insert)values(@AdministrativeRefre,@AdministrativeType,@AdministrativeParentCode,@AdministrativeParent,@AdministrativeStatus,@InsertTime,@UserID_Insert)"
    Private Sql_Dt_AllAccounts As String = "SELECT * From tbAdministrative Where AdministrativeStatus=1"

    Public Function Max_AdministrativeCode()
        Try
            Dim cmd As New SqlCommand("Select Max(AdministrativeCode) From tbAdministrative Where AdministrativeType='رئيسي'", sQlConnection)
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            MaxAdministrativeCode = cmd.ExecuteScalar
            sQlConnection.Close()
        Catch ex As Exception
            MaxAdministrativeCode = 0
            sQlConnection.Close()
        End Try
        Return MaxAdministrativeCode
    End Function
    Public Function Max_AdministrativeParentCode()


        Try
            Dim cmd As New SqlCommand("Select Max(AdministrativeParentCode) From tbAdministrative Where AdministrativeType='فرعي'", sQlConnection)
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            MaxAdministrativeParentCode = cmd.ExecuteScalar
            sQlConnection.Close()
            MaxAdministrativeParentCode = MaxAdministrativeParentCode + 1
        Catch ex As Exception
            MaxAdministrativeParentCode = 1
            MsgBox(ex.Message)
            sQlConnection.Close()
        End Try
        Return MaxAdministrativeParentCode
    End Function
    '    Private Sub GetAccCode()
    '        'جلب كود الحساب
    '        'إذا لم يتم اختيار نوع الحساب قم بتفريغ مربع نص كود الحساب
    '        If Me.cmbAdministrativeFather.SelectedIndex = -1 Then
    '            Me.txtAdministrativeID.Text = String.Empty
    '            Exit Sub
    '        End If
    '        Dim xNewAdministrativeID As Int64
    '        Dim xAccType As String = CStr(Me.cmbAdministrativeType.Text)
    '        Dim xDv = New DataView(MyVar_Dt_AllAccounts)
    '        Dim xAccParent As Integer
    '        Select Case xAccType
    '            Case "رئيسي"
    '                If Me.cmbAdministrativeFather.SelectedIndex = -1 Or Me.cmbAdministrativeFather.Text = String.Empty Then
    '                    xDv.RowFilter = "AccType = رئيسي AND AccParent = 0"
    '                    xNewAdministrativeID = Convert.ToInt64(xDv.Count + 1)
    '                    GoTo FinalLine
    '                Else
    '                    xAccParent = Convert.ToInt32(cmbAdministrativeFather.SelectedValue)
    '                    Dim xFilter As String = "AccType = 'رئيسي' AND AdministrativeFather = " & xAccParent & " "
    '                    Dim xMaxAdministrativeID As Object = xDv.ToTable.Compute("MAX(AdministrativeID)", xDv.RowFilter)
    '                    If xMaxAdministrativeID Is DBNull.Value Then
    '                        xDv.RowFilter = "AdministrativeID = " & xAccParent & " "
    '                        Dim xAdministrativeParentCode As Int64 = Convert.ToInt64(xDv.Item(0)("AdministrativeParentCode"))
    '                        xNewAdministrativeID = Convert.ToUInt64(CStr(xAdministrativeParentCode & 1))
    '                    Else
    '                        xNewAdministrativeID = Convert.ToUInt64(xMaxAdministrativeID + 1)
    '                    End If
    '                    GoTo FinalLine
    '                End If

    '            Case "فرعي"
    '                Dim xFilter As String = "AccType = فرعي AND AccParent = & xAccParent & """
    '                Dim xMaxAccCode As Object = xDv.ToTable.Compute("MAX(AccCode)", xDv.RowFilter)
    '                If xMaxAccCode Is DBNull.Value Then
    '                    xDv.RowFilter = "AccID = & xAccParent & """
    '                    Dim xAccParent_Code As Int64 = Convert.ToInt64(xDv.Item(0)("AccCode"))
    '                    xNewAdministrativeID = Convert.ToUInt64(CStr(xAccParent_Code & "0001"))
    '                Else
    '                    xNewAdministrativeID = Convert.ToUInt64(xMaxAccCode + 1)
    '                End If
    '        End Select
    'FinalLine:
    '        Me.TxtAccCode.Text = CStr(xNewAdministrativeID)
    '    End Sub
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
                VarAdministrativeTypeDT.Clear()
                XCLS.MyCodes_Fill_DataTable(sQLFillCMBFather, VarAdministrativeTypeDT)
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
    Private Sub cmbAdministrativeFather_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdministrativeFather.SelectedIndexChanged
        Try
            Max_AdministrativeParentCode()
            Dim selectedFath As Integer
            selectedFath = Convert.ToInt64(Me.cmbAdministrativeFather.SelectedValue)
            txtAdministrativeParentCode.Text = selectedFath & "000" & MaxAdministrativeParentCode
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbAdministrativeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdministrativeType.SelectedIndexChanged
        Select Case Me.cmbAdministrativeType.SelectedItem
            Case "رئيسي"
                Me.cmbAdministrativeFather.Enabled = False
                Me.txtAdministrativeID.Enabled = False
                Me.cmbAdministrativeFather.Text = " "
                Max_AdministrativeCode()
                MaxAdministrativeCode += 1
                txtAdministrativeParentCode.Text = MaxAdministrativeCode
            Case "فرعي"
                Me.cmbAdministrativeFather.Enabled = True
                Me.txtAdministrativeID.Enabled = False
                Me.cmbAdministrativeFather.Text = ""
                Me.txtAdministrativeParentCode.Text = ""

        End Select
    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        Try
            If VarBGW_Status = True Then
                Call XCLS.MyCodes_CmbFill(Me.cmbAdministrativeFather, VarAdministrativeTypeDT, "AdministrativeName", "AdministrativeCode")
                Me.cmbAdministrativeType.DataSource = VarSelAdministrativeType
            Else
                Exit Sub
            End If
            lblUsername.Text = VarUserName

            Call MYSP_Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try

            Select Case VarAdministrativeType
                Case "رئيسي"

                    Dim Cmd As New SqlCommand(sQLFather, sQlConnection)
                    With Cmd
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@AdministrativeCode", SqlDbType.Int).Value = VarAdministrativeParentCode
                        .Parameters.AddWithValue("@AdministrativeName", SqlDbType.VarChar).Value = VarAdministrativeParent
                        .Parameters.AddWithValue("@AdministrativeType", SqlDbType.VarChar).Value = VarAdministrativeType
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


                Case "فرعي"
                    Dim Cmd As New SqlCommand(sQLParent, sQlConnection)
                    With Cmd
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@AdministrativeRefre", SqlDbType.Int).Value = VarAdministrativeFather
                        .Parameters.AddWithValue("@AdministrativeType", SqlDbType.VarChar).Value = VarAdministrativeType
                        .Parameters.AddWithValue("@AdministrativeParentCode", SqlDbType.Int).Value = VarAdministrativeParentCode
                        .Parameters.AddWithValue("@AdministrativeParent", SqlDbType.VarChar).Value = VarAdministrativeParent
                        .Parameters.AddWithValue("@AdministrativeStatus", SqlDbType.Int).Value = VarAdministrativeStatus
                        .Parameters.AddWithValue("@InsertTime", SqlDbType.Date).Value = VarInsertTime
                        .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
                    End With
                    If sQlConnection.State = 1 Then sQlConnection.Close()
                    sQlConnection.Open()
                    Cmd.ExecuteNonQuery()
                    sQlConnection.Close()
                    MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                    Cmd = Nothing
                Case Else
                    MsgBox("يرجي تحديد نوع الادارة", MsgBoxStyle.Information, "تحذير")
            End Select
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
        BGW_Save.RunWorkerAsync()
        VarAdministrativeType = Me.cmbAdministrativeType.SelectedItem
        VarAdministrativeFather = Me.cmbAdministrativeFather.SelectedValue
        VarAdministrativeParentCode = Convert.ToInt64(Me.txtAdministrativeParentCode.Text)
        VarAdministrativeParent = Me.txtAdministrativeParent.Text
        VarAdministrativeParentLatin = Me.txtAdministrativeLatin.Text
        VarAdministrativeStatus = 1

    End Sub
End Class