Imports System.Data.SqlClient

Public Class frmBookingInquiries
#Region "Variable"
    Private XCLS As New ClsMain
    Private MyVarDT_Employe As DataTable = New DataTable
    Private MyVarDV_Employe As DataView = New DataView
    Private MyVarDV_AppoinSche As DataView = New DataView
    Private VarClinc_DT As DataTable = New DataTable
    Private VarAppoinSche_DT As DataTable = New DataTable
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

    Private VarFromDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private VarMounth As Integer = 1
    Private VarToDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")

#End Region
#Region "SQL"
    Private sQLInsert As String = "Insert Into tbAppointmentSchedule (ClincID,DoctorID,Day,AppoinScheFromTime,AppoinScheToTime,AllowNumCases,ReviewAllowedNum
                                                                     ,AppoinScheStatus,InsertTime,UserID_Insert)values(@ClincID,@DoctorID,@Day,@AppoinScheFromTime
                                                                     ,@AppoinScheToTime,@AllowNumCases,@ReviewAllowedNum,@AppoinScheStatus,@InsertTime,@UserID_Insert)"
    Private sQLClinc As String = "SELECT [ClinicID]
                                          ,[ClinicName]
                                      FROM [Clinics]
                                      Where [ClinicStatus]=1"
    Private sQLAppoinSche As String = "SELECT TOP (1000) [AppoinScheID]
                                      ,CONCAT([EmpFirstName],' ',[EmpFathName],' ',[EmpGranFathName],' ',[EmpSurName]) AS FullName
                                      ,[ClinicName]
                                      ,[Day]
                                      ,[AppoinScheFromTime]
                                      ,[AppoinScheToTime]
                                      ,[AllowNumCases]
                                      ,[ReviewAllowedNum]
                                  FROM [clinic].[dbo].[vAppointmentSchedule]
                                  Where [AppoinScheStatus]=1"
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
        Me.GroupBox3.Enabled = False
        Me.GroupBox4.Enabled = False
    End Sub
    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.GroupBox4.Enabled = True
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
                Call XCLS.MyCodes_Fill_DataTable(sQLAppoinSche, VarAppoinSche_DT)
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
            Call XCLS.MyCodes_Fill_Dgv(dgvDoctorsAppointmentSchedule, lblCountAppoin, VarAppoinSche_DT, MyVarDV_AppoinSche)

            VarToDate = dtpFromDate.Value.AddMonths(VarMounth)
            dtpToDate.Value = VarToDate.ToString("yyyy/MM/dd")


            Me.cmbDoctor.SelectedIndex = -1
            Me.cmbDay.SelectedIndex = -1
            Me.cmbClinc.SelectedIndex = -1


            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()

    End Sub
    Private Sub frmBookingInquiries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
#End Region

End Class