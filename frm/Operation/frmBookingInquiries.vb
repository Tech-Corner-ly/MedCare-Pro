Imports System.Data.SqlClient

Public Class frmBookingInquiries
#Region "Variable"
    Private XCLS As New ClsMain
    Private MyVarDT_Employe As DataTable = New DataTable
    Private MyVarDV_Employe As DataView = New DataView
    Private MyVarDV_AppoinSche As DataView = New DataView
    Private VarClinc_DT As DataTable = New DataTable
    Private VarAppoinSche_DT As DataTable = New DataTable
    Private VarBooking_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable
    Private Var_Warehouse_DT As DataTable = New DataTable
    Private Var_ItemNamw_DT As DataTable = New DataTable

    Private VarCategory_DS As New AutoCompleteStringCollection
    Private Var_Warehouse_DS As New AutoCompleteStringCollection
    Private VarGroupItems_DS As New AutoCompleteStringCollection
    Private VarBrandCompany_DS As New AutoCompleteStringCollection
    Private VarItemName_DS As New AutoCompleteStringCollection

    Private VarClinicID, VarEmpoleeID, VarBookingID, VarAppoinScheID, VarPatientType, VarBookingATT, VarPaymentStatus, VarPatientID, VarStatus, VarCityID, VarBookingOrderID As Integer
    Private VarDay, VarDayCulome, VarP_Fname, VarP_Fathname, VarP_Gname, VarP_Sname, VarP_phone, VarP_Phone2, VarPatientAddress, VarFileNo, VarClincName, VarEmpoleeName, VarP_FullName, VarPatientTypeValue, VarBookingType As String
    Private VarBookingDate As Date = DateTime.Now.ToString("yyyy/MM/dd")
    Private VarBookingTimeAppo As DateTime = DateTime.Now.ToString("hh:mm t")
    Private AppoinScheFromTime As DateTime = DateTime.Now.ToString("hh:mm t")
    Private AppoinScheToTime As DateTime = DateTime.Now.ToString("hh:mm t")

    Private VarFromDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private VarMounth As Integer = 1
    Private VarToDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")

    Private Sub SetDataSRC()

        VarBooking_DT.Columns.Add("BooClincName")
        VarBooking_DT.Columns.Add("PatientName")
        VarBooking_DT.Columns.Add("BookingDay")
        VarBooking_DT.Columns.Add("BookingDate")
        VarBooking_DT.Columns.Add("BookingTime")
        VarBooking_DT.Columns.Add("PatientType")



        dgvBookingInquiries.DataSource = VarBooking_DT
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try


            Dim xCmdPatientInfo As New SqlCommand(sQL_PatientInsert, sQlConnection)
            With xCmdPatientInfo
                .Parameters.Clear()
                .Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = VarP_Fname
                .Parameters.AddWithValue("@FatherName", SqlDbType.NVarChar).Value = VarP_Fathname
                .Parameters.AddWithValue("@GrandName", SqlDbType.NVarChar).Value = VarP_Gname
                .Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = VarP_phone
                .Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = VarP_phone
                .Parameters.AddWithValue("@Phone2", SqlDbType.NVarChar).Value = VarP_Phone2
                .Parameters.AddWithValue("@PatientAddress", SqlDbType.NVarChar).Value = VarPatientAddress
                .Parameters.AddWithValue("@CityID", SqlDbType.Int).Value = VarCityID
                .Parameters.AddWithValue("@Status", SqlDbType.Int).Value = VarStatus
                .Parameters.AddWithValue("@InsertTime", SqlDbType.DateTime).Value = VarInsertTime
                .Parameters.AddWithValue("@UserID_Insert", SqlDbType.Int).Value = VarUserID
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            xCmdPatientInfo.ExecuteNonQuery()
            sQlConnection.Close()
            xCmdPatientInfo = Nothing



            Dim Cmd As New SqlCommand(sQL_BookingInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@BookingOrderID", SqlDbType.Int).Value = VarBookingOrderID
                .Parameters.AddWithValue("@BookingDate", SqlDbType.Date).Value = VarBookingDate
                .Parameters.AddWithValue("@BookingDay", SqlDbType.NVarChar).Value = VarDay
                .Parameters.AddWithValue("@PatientType", SqlDbType.NVarChar).Value = VarPatientType
                .Parameters.AddWithValue("@FileNo", SqlDbType.NVarChar).Value = VarFileNo
                .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = VarPatientID
                .Parameters.AddWithValue("@BookingType", SqlDbType.NVarChar).Value = VarBookingType
                .Parameters.AddWithValue("@BookingATT", SqlDbType.Int).Value = VarBookingATT
                .Parameters.AddWithValue("@PaymentStatus", SqlDbType.Int).Value = VarPaymentStatus
                .Parameters.AddWithValue("@ClinicID", SqlDbType.Int).Value = VarClinicID
                .Parameters.AddWithValue("@EmpoleeID", SqlDbType.Int).Value = VarEmpoleeID
                .Parameters.AddWithValue("@Status", SqlDbType.Int).Value = VarStatus
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
#End Region
#Region "SQL"

    Private sQLMAX_BookingOrderID As String = "Select Case MAX([BookingOrderID]) From [Booking] Where [BookingDate] =@BookingDate AND [ClinicID]=@ClinicID AND [EmpoleeID]=@EmpoleeID AND [Status]=1"
    Private sQLMAX_PatientID As String = "SELECT MAX([PatientID]) as xMAxID FROM [Patient] Where [Status]=1"
    Private sQL_BookingInsert As String = "Insert Into Booking (BookingOrderID,BookingDate,BookingHour,BookingDay,PatientType,FileNo,PatientID,BookingType,BookingATT
                                                       ,PaymentStatus,ClinicID,EmpoleeID,Status,InsertTime,UserID_Insert)
                                                       values(@BookingOrderID,@BookingDate,@BookingHour,@BookingDay,@PatientType,@FileNo,@PatientID,@BookingType
                                                       ,@BookingATT,@PaymentStatus,@ClinicID,@EmpoleeID,@Status,@InsertTime,@UserID_Insert)"

    Private sQL_PatientInsert As String = "Insert Into Patient (FirstName,FatherName,GrandName,LastName,Phone,Phone2,PatientAddress,CityID,Status,InsertTime,UserID_Insert)
                                                       values(@FirstName,@FatherName,@GrandName,@LastName,@Phone,@Phone2,@PatientAddress,@CityID,@Status,@InsertTime,@UserID_Insert)"


    Private sQLClinc As String = "SELECT [ClinicID]
                                          ,[ClinicName]
                                      FROM [Clinics]
                                      Where [ClinicStatus]=1"
    Private sQLAppoinSche As String = "SELECT [AppoinScheID]
                                      ,[DoctorID]
                                      ,CONCAT([EmpFirstName],' ',[EmpFathName],' ',[EmpGranFathName],' ',[EmpSurName]) AS FullName
                                      ,[ClincID]
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

            For i As Integer = 0 To 6
                cmbDay.Items.Add(DateTime.Now.AddDays(i).ToString("dddd"))
            Next

            Me.cmbDoctor.SelectedIndex = -1
            Me.cmbDay.SelectedIndex = -1
            Me.cmbClinc.SelectedIndex = -1
            'Me.dtpBookingDate.MinDate = DateTime.Now

            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()

    End Sub
    Private Sub frmBookingInquiries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataSRC()
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub cmbClinc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbClinc.SelectionChangeCommitted
        Try
            Dim xClinc As Integer = Me.cmbClinc.SelectedValue
            MyPubVar_Filter = ""
            MyPubVar_Filter = "ClincID =" & xClinc
            Call XCLS.MyCodes_Fill_Dgv(Me.dgvDoctorsAppointmentSchedule, Me.lblBookingCount, VarAppoinSche_DT, MyVarDV_AppoinSche)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub
    Private Sub cmbDoctor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDoctor.SelectionChangeCommitted
        Try
            Dim xDoctorID As Integer = Me.cmbDoctor.SelectedValue
            MyPubVar_Filter = ""
            MyPubVar_Filter = "DoctorID =" & xDoctorID
            Call XCLS.MyCodes_Fill_Dgv(Me.dgvDoctorsAppointmentSchedule, Me.lblBookingCount, VarAppoinSche_DT, MyVarDV_AppoinSche)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub cmbDay_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDay.SelectionChangeCommitted
        Try
            Dim xDoctorID As String = Me.cmbDay.SelectedItem
            MyPubVar_Filter = ""
            MyPubVar_Filter = "Day Like'%" & xDoctorID & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.dgvDoctorsAppointmentSchedule, Me.lblBookingCount, VarAppoinSche_DT, MyVarDV_AppoinSche)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Dim NowDate As Date = DateTime.Now.ToString("yyyy/MM/dd")
        VarAppoinScheID = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item(0).Value
        VarClinicID = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item(1).Value
        VarEmpoleeID = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item("DoctorI").Value
        VarClincName = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item(4).Value
        VarEmpoleeName = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item(5).Value
        VarDayCulome = Me.dgvDoctorsAppointmentSchedule.CurrentRow.Cells.Item("Day").Value
        VarDay = Me.dtpBookingDate.Value.ToString("dddd")
        VarBookingDate = Me.dtpBookingDate.Value
        VarP_Fname = Me.txtFirstName.Text
        VarP_Fathname = Me.txtFatherName.Text
        VarP_Gname = Me.txtGrandFatherName.Text
        VarP_Sname = Me.txtSurename.Text
        VarP_phone = Me.txtPhone.Text
        VarFileNo = Me.txtFileNo.Text
        VarBookingTimeAppo = Me.dtpBookingHours.Value
        VarP_FullName = VarP_Fname & " " & VarP_Fathname & " " & VarP_Gname & " " & VarP_Sname

        Select Case VarPatientType
            Case Me.rbShelterCase.Checked
                VarPatientType = 1
                VarPatientTypeValue = "OPD"
            Case Me.rbOPD.Checked
                VarPatientType = 0
                VarPatientTypeValue = "ايواء"
        End Select

        If VarDay = VarDayCulome Then
            If NowDate < VarBookingDate Then
                Dim row As DataRow = VarBooking_DT.NewRow
                row("BooClincName") = VarClincName
                row("PatientName") = VarP_FullName
                row("BookingDay") = VarDay
                row("BookingDate") = VarBookingDate
                row("BookingTime") = VarBookingTimeAppo
                row("PatientType") = VarPatientTypeValue
                VarBooking_DT.Rows.Add(row)
            Else
                MsgBox("التاريخ المحدد اقدم من التاريخ الحالي ")
            End If

        Else
            MsgBox("يرجي تحديد اليوم ")
            Exit Sub
        End If


    End Sub
#End Region

End Class