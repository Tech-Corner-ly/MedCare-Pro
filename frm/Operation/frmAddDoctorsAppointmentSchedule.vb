Imports System.Data.SqlClient

Public Class frmAddDoctorsAppointmentSchedule
#Region "Variable"
    Private XCLS As New ClsMain
    Private MyVarDT_Employe As DataTable = New DataTable
    Private MyVarDV_Employe As DataView = New DataView
    Private VarClinc_DT As DataTable = New DataTable
    Private VarBrandCompany_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable
    Private Var_Warehouse_DT As DataTable = New DataTable
    Private Var_ItemNamw_DT As DataTable = New DataTable

    Private VarCategory_DS As New AutoCompleteStringCollection
    Private Var_Warehouse_DS As New AutoCompleteStringCollection
    Private VarGroupItems_DS As New AutoCompleteStringCollection
    Private VarBrandCompany_DS As New AutoCompleteStringCollection
    Private VarItemName_DS As New AutoCompleteStringCollection

    Private ClincID As Integer
    Private DoctorID As Integer
    Private VarDay As String
    Private AllowNumCases As Integer
    Private ReviewAllowedNum As Integer
    Private AppoinScheStatus As Integer
    Private AppoinScheFromTime As DateTime = DateTime.Now.ToString("hh:mm t")
    Private AppoinScheToTime As DateTime = DateTime.Now.ToString("hh:mm t")
#End Region
#Region "SQL"
    Private sQLInsert As String = "Insert Into tbAppointmentSchedule (ClincID,DoctorID,Day,AppoinScheFromTime,AppoinScheToTime,AllowNumCases,ReviewAllowedNum
                                                                     ,AppoinScheStatus,InsertTime,UserID_Insert)values(@ClincID,@DoctorID,@Day,@AppoinScheFromTime
                                                                     ,@AppoinScheToTime,@AllowNumCases,@ReviewAllowedNum,@AppoinScheStatus,@InsertTime,@UserID_Insert)"
    Private sQLClinc As String = "SELECT [ClinicID]
                                          ,[ClinicName]
                                      FROM [Clinics]
                                      Where [ClinicStatus]=1"
    Private sQLBrandCompany As String = "SELECT [BranCompID]
                                                  ,[BranCompName]
                                              FROM [BrandCompany]
                                              Where [BranCompStatus]=1"
    Private sQLGroupItem As String = "SELECT [GroupItemID]
                                              ,[GroupItemName]
                                          FROM [GroupItems]
                                          Where [GroupItemStatus]=1"

    Private sQLItemsName As String = "SELECT [ItemID]
                                                  ,[ItemName]
                                              FROM [vItemsServices]"
    Private sQLEmploye As String = "SELECT [EmployeID]
                                              ,CONCAT([EmpFirstName],' ',[EmpFathName],' ',[EmpGranFathName],' ',[EmpSurName]) as EmpName
                                          FROM [tbEmploye]
                                          Where [EmployeStatus]=1"
#End Region
#Region "Function"
    Private Sub MYSP_Show()
        Me.Timer1.Start()
        Me.PB.Visible = True
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
    End Sub
    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
    End Sub
#End Region
#Region "Load"
    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_Employe.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLEmploye, MyVarDT_Employe)
                Call XCLS.MyCodes_Fill_DataTable(sQLClinc, VarClinc_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLBrandCompany, VarBrandCompany_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLGroupItem, VarGroupItems_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLItemsName, Var_ItemNamw_DT)

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
            Call XCLS.MyCodes_CmbFill(cmbDoctor, MyVarDT_Employe, "EmpName", "EmployeID")
            Call XCLS.MyCodes_CmbFill(cmbClinc, VarClinc_DT, "ClinicName", "ClinicID")




            For i As Integer = 0 To 6
                cmbDay.Items.Add(DateTime.Now.AddDays(i).ToString("dddd"))
            Next
            Me.cmbDoctor.SelectedIndex = -1
            Me.cmbDay.SelectedIndex = -1
            Me.cmbClinc.SelectedIndex = -1


            lblUsername.Text = VarUserName
        End If
        Call MYSP_Hide()

    End Sub
    Private Sub frmAddDoctorsAppointmentSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            Dim Cmd As New SqlCommand(sQLInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@ClincID", SqlDbType.Int).Value = ClincID
                .Parameters.AddWithValue("@DoctorID", SqlDbType.Int).Value = DoctorID
                .Parameters.AddWithValue("@Day", SqlDbType.NVarChar).Value = VarDay
                .Parameters.AddWithValue("@AppoinScheFromTime", SqlDbType.Time).Value = AppoinScheFromTime
                .Parameters.AddWithValue("@AppoinScheToTime", SqlDbType.Time).Value = AppoinScheToTime
                .Parameters.AddWithValue("@AllowNumCases", SqlDbType.Int).Value = AllowNumCases
                .Parameters.AddWithValue("@ReviewAllowedNum", SqlDbType.Int).Value = ReviewAllowedNum
                .Parameters.AddWithValue("@AppoinScheStatus", SqlDbType.Int).Value = AppoinScheStatus
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
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.cmbDoctor.Text = Nothing Then
            ErrorProvider1.SetError(Me.cmbDoctor, "يرجي تحديد اسم الطبيب")
            Exit Sub
        Else
            ErrorProvider1.SetError(Me.cmbDoctor, String.Empty)
            DoctorID = CInt(Me.cmbDoctor.SelectedValue)
        End If
        If Me.cmbClinc.Text = Nothing Then
            ErrorProvider1.SetError(Me.cmbClinc, "يرجي تحديد العيادة")
            Exit Sub
        Else
            ErrorProvider1.SetError(Me.cmbClinc, String.Empty)
            ClincID = CInt(Me.cmbClinc.SelectedValue)
        End If

        If Me.cmbDay.Text = Nothing Then
            ErrorProvider1.SetError(Me.cmbDay, "يرجي تحديد العيادة")
            Exit Sub
        Else
            ErrorProvider1.SetError(Me.cmbDay, String.Empty)
            VarDay = CStr(Me.cmbDay.SelectedItem)
        End If

        AppoinScheToTime = Me.dtpFromTime.Value
        AppoinScheFromTime = Me.dtpToTime.Value

        If Me.txtNumberCases.Text = Nothing Then
            ErrorProvider1.SetError(Me.txtNumberCases, "يرجي ادخال عدد الحالات")
            Call XCLS.MyCodes_TextNotNull(Me.txtNumberCases, "عدد الحالات")
            Exit Sub
        Else
            ErrorProvider1.SetError(Me.txtNumberCases, String.Empty)
            AllowNumCases = CInt(Trim(Me.txtNumberCases.Text))
        End If

        If Me.txtReviewAllowed.Text = Nothing Then
            ErrorProvider1.SetError(Me.txtReviewAllowed, "يرجي ادخال ايام المراجعة")
            Call XCLS.MyCodes_TextNotNull(Me.txtReviewAllowed, "سماحية المراجعة")
            Exit Sub
        Else
            ErrorProvider1.SetError(Me.txtReviewAllowed, String.Empty)
            ReviewAllowedNum = CInt(Trim(Me.txtReviewAllowed.Text))
        End If
        AppoinScheStatus = 1
        Call MYSP_Show()
        BGW_Save.RunWorkerAsync()

    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            Call MYSP_Hide()
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()

    End Sub

#End Region
End Class