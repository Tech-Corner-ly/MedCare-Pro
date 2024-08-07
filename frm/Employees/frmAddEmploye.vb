Imports System.Data.SqlClient

Public Class frmAddEmploye
#Region "Variable"
    Private XCLS As New ClsMain
    Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    Private MyVarDT_Countries As DataTable = New DataTable
    Private MyVarDT_Specialization As DataTable = New DataTable
    Private MyVarDT_Users As DataTable = New DataTable
    Private MyVarDT_Cities As DataTable = New DataTable
    Private VarAdministrativeTypeDT As DataTable = New DataTable
    Private VarJobTitleDT As DataTable = New DataTable
    Private VarJobTitleDTE As DataTable = New DataTable
    Private VarClinicDT As DataTable = New DataTable
    Private VarItemsServicesDT1 As DataTable = New DataTable
    Private VarItemsServicesDT2 As DataTable = New DataTable
    Private VarItemsServicesDT3 As DataTable = New DataTable

    Private EmployeCode, EmpFirstName, EmpFathName, EmpGranFathName, EmpSurName, AdjectiveID, EmpGender, EmpZone, EmpAddress, EmpPhone1, EmpPhone2, EmpEmail, EmpNote, EmpPlaceNumRegist, EmpPlaceBirth As String
    Private EmpCardObtaiPlace, EmpPassportID, EmpPassportGetPlace, EmpEntryPlace, EmpResidencyPlace, EmpFatherName, EmpMotherName, EmpMaritalStatus As String
    Private EmpDateBirth As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private EmpCardObtaiDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private EmpObtaiPassportDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private EmpExpiryPassportDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private EmpEntryDate As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private EmpResidencyExpiry As DateTime = DateTime.Now.ToString("yyyy/MM/dd")
    Private IsActive, SpecializationID, JobTitleID, AdministrativeID, NationalityID, UserID, CityID, EmpCardNum, EmpIDNum, EmpResidencyNum, EmpFamilyNum, ClinicID, ItemExaminID1, ItemExaminID2, ItemExaminID3, EmpIsActive, EmployeStatus As Integer
#End Region
#Region "SQL"
    Private sQLClincic As String = "SELECT ClinicID,ClinicName FROM Clinics Where ClinicStatus=1"
    Private sQLItemsServices As String = "SELECT [ItemID],[ItemName] FROM [ItemsServices] Where [IsActive]=1 AND [ItemType]='خدمة'"
    Private sQLCities As String = "SELECT CityID,CityName FROM tbCities"
    Private sQLUsers As String = "SELECT UserID,Username FROM tblUsers Where UserStatus=1 AND UserIsActive=1"
    Private sQLAdministrative As String = "SELECT [AdministrativeID]
                                                  ,[AdministrativeName]
                                              FROM [tbAdministrative]
                                              Where [AdministrativeStatus]=1"
    Private sQLSpecialization As String = "SELECT [SpecializationID],[SpecializationName] FROM [tbSpecialization] Where [SpecializationStatus]=1 AND [Adjective]='طبي'"
    Private sQLtbEmploye As String = "SELECT * FROM tbEmploye Where EmployeStatus=1 "
    Private Sql_Dt_AllAccounts As String = "SELECT * From tbAdministrative Where AdministrativeStatus=1"
    Private sQLInsert As String = "Insert Into tbEmploye (EmployeCode,EmpFirstName,EmpFathName,EmpGranFathName,EmpSurName,AdjectiveID,SpecializationID,JobTitleID,AdministrativeID,EmpGender
                                   ,NationalityID,UserID,CityID,EmpZone,EmpAddress,EmpPhone1,EmpPhone2,EmpEmail,EmpNote,EmpPlaceNumRegist,EmpPlaceBirth,EmpDateBirth,EmpCardNum,EmpIDNum
                                   ,EmpCardObtaiDate,EmpCardObtaiPlace,EmpPassportID,EmpPassportGetPlace,EmpObtaiPassportDate,EmpExpiryPassportDate,EmpEntryPlace,EmpEntryDate,EmpResidencyNum
                                   ,EmpResidencyPlace,EmpResidencyExpiry,EmpFatherName,EmpMotherName,EmpMaritalStatus,EmpFamilyNum,ClinicID,ItemExaminID1,ItemExaminID2,ItemExaminID3,EmpIsActive
                                   ,EmployeStatus,InsertTime,UserID_Insert)
                                   values(@EmployeCode,@EmpFirstName,@EmpFathName,@EmpGranFathName,@EmpSurName,@AdjectiveID,@SpecializationID,@JobTitleID,@AdministrativeID,@EmpGender,
                                   @NationalityID,@UserID,@CityID,@EmpZone,@EmpAddress,@EmpPhone1,@EmpPhone2,@EmpEmail,@EmpNote,@EmpPlaceNumRegist,@EmpPlaceBirth,@EmpDateBirth,@EmpCardNum
                                   ,@EmpIDNum,@EmpCardObtaiDate,@EmpCardObtaiPlace,@EmpPassportID,@EmpPassportGetPlace,@EmpObtaiPassportDate,@EmpExpiryPassportDate,@EmpEntryPlace,@EmpEntryDate
                                   ,@EmpResidencyNum,@EmpResidencyPlace,@EmpResidencyExpiry,@EmpFatherName,@EmpMotherName,@EmpMaritalStatus,@EmpFamilyNum,@ClinicID,@ItemExaminID1,@ItemExaminID2
                                   ,@ItemExaminID3,@EmpIsActive,@EmployeStatus,@InsertTime,@UserID_Insert)"
    Private sQLJobTitle As String = "SELECT [JobTitleID]
                                              ,[JobTitle]
                                          FROM [tbJobTitle]
                                          Where [JobTitleStatus]=1 AND [Adjective]='طبي'"
    Private sQLJobTitleE As String = "SELECT [JobTitleID]
                                              ,[JobTitle]
                                          FROM [tbJobTitle]
                                          Where [JobTitleStatus]=1 AND [Adjective]='مدني'"
#End Region
#Region "Other Event"
    Private Sub cmbAdjective_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAdjective.SelectionChangeCommitted
        If Me.cmbAdjective.Text = "طبي" Then
            Me.cmbSpecialization.Enabled = True
            Call XCLS.MyCodes_CmbFill(Me.cmbJobTitle, VarJobTitleDT, "JobTitle", "JobTitleID")
            Me.TabClinicsServices.Enabled = True
            Me.cmbJobTitle.SelectedIndex = -1
        ElseIf Me.cmbAdjective.Text = "مدني" Then
            Me.cmbSpecialization.Enabled = False
            Me.TabClinicsServices.Enabled = False
            Call XCLS.MyCodes_CmbFill(Me.cmbJobTitle, VarJobTitleDTE, "JobTitle", "JobTitleID")
            Me.cmbJobTitle.SelectedIndex = -1
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub
#End Region
#Region "Save"
    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            Dim Cmd As New SqlCommand(sQLInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@EmployeCode", SqlDbType.Int).Value = EmployeCode
                .Parameters.AddWithValue("@EmpFirstName", SqlDbType.NVarChar).Value = EmpFirstName
                .Parameters.AddWithValue("@EmpFathName", SqlDbType.NVarChar).Value = EmpFathName
                .Parameters.AddWithValue("@EmpGranFathName", SqlDbType.NVarChar).Value = EmpGranFathName
                .Parameters.AddWithValue("@EmpSurName", SqlDbType.NVarChar).Value = EmpSurName
                .Parameters.AddWithValue("@AdjectiveID", SqlDbType.NVarChar).Value = AdjectiveID
                .Parameters.AddWithValue("@SpecializationID", SqlDbType.Int).Value = SpecializationID
                .Parameters.AddWithValue("@JobTitleID", SqlDbType.Int).Value = JobTitleID
                .Parameters.AddWithValue("@AdministrativeID", SqlDbType.Int).Value = AdministrativeID
                .Parameters.AddWithValue("@EmpGender", SqlDbType.NVarChar).Value = EmpGender
                .Parameters.AddWithValue("@NationalityID", SqlDbType.Int).Value = NationalityID
                .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
                .Parameters.AddWithValue("@CityID", SqlDbType.Int).Value = CityID
                .Parameters.AddWithValue("@EmpZone", SqlDbType.NVarChar).Value = EmpZone
                .Parameters.AddWithValue("@EmpAddress", SqlDbType.NVarChar).Value = EmpAddress
                .Parameters.AddWithValue("@EmpPhone1", SqlDbType.NVarChar).Value = EmpPhone1
                .Parameters.AddWithValue("@EmpPhone2", SqlDbType.NVarChar).Value = EmpPhone2
                .Parameters.AddWithValue("@EmpEmail", SqlDbType.NVarChar).Value = EmpEmail
                .Parameters.AddWithValue("@EmpNote", SqlDbType.NVarChar).Value = EmpNote
                .Parameters.AddWithValue("@EmpPlaceNumRegist", SqlDbType.NVarChar).Value = EmpPlaceNumRegist
                .Parameters.AddWithValue("@EmpPlaceBirth", SqlDbType.NVarChar).Value = EmpPlaceBirth
                .Parameters.AddWithValue("@EmpDateBirth", SqlDbType.Date).Value = EmpDateBirth
                .Parameters.AddWithValue("@EmpCardNum", SqlDbType.Int).Value = EmpCardNum
                .Parameters.AddWithValue("@EmpIDNum", SqlDbType.Int).Value = EmpIDNum
                .Parameters.AddWithValue("@EmpCardObtaiDate", SqlDbType.DateTime).Value = EmpCardObtaiDate
                .Parameters.AddWithValue("@EmpCardObtaiPlace", SqlDbType.NVarChar).Value = EmpCardObtaiPlace
                .Parameters.AddWithValue("@EmpPassportID", SqlDbType.NVarChar).Value = EmpPassportID
                .Parameters.AddWithValue("@EmpPassportGetPlace", SqlDbType.NVarChar).Value = EmpPassportGetPlace
                .Parameters.AddWithValue("@EmpObtaiPassportDate", SqlDbType.DateTime).Value = EmpObtaiPassportDate
                .Parameters.AddWithValue("@EmpExpiryPassportDate", SqlDbType.DateTime).Value = EmpExpiryPassportDate
                .Parameters.AddWithValue("@EmpEntryPlace", SqlDbType.NVarChar).Value = EmpEntryPlace
                .Parameters.AddWithValue("@EmpEntryDate", SqlDbType.DateTime).Value = EmpEntryDate
                .Parameters.AddWithValue("@EmpResidencyNum", SqlDbType.Int).Value = EmpResidencyNum
                .Parameters.AddWithValue("@EmpResidencyPlace", SqlDbType.NVarChar).Value = EmpResidencyPlace
                .Parameters.AddWithValue("@EmpResidencyExpiry", SqlDbType.DateTime).Value = EmpResidencyExpiry
                .Parameters.AddWithValue("@EmpFatherName", SqlDbType.NVarChar).Value = EmpFatherName
                .Parameters.AddWithValue("@EmpMotherName", SqlDbType.NVarChar).Value = EmpMotherName
                .Parameters.AddWithValue("@EmpMaritalStatus", SqlDbType.NVarChar).Value = EmpMaritalStatus
                .Parameters.AddWithValue("@EmpFamilyNum", SqlDbType.Int).Value = EmpFamilyNum
                .Parameters.AddWithValue("@ClinicID", SqlDbType.Int).Value = ClinicID
                .Parameters.AddWithValue("@ItemExaminID1", SqlDbType.Int).Value = ItemExaminID1
                .Parameters.AddWithValue("@ItemExaminID2", SqlDbType.Int).Value = ItemExaminID2
                .Parameters.AddWithValue("@ItemExaminID3", SqlDbType.Int).Value = ItemExaminID3
                .Parameters.AddWithValue("@EmpIsActive", SqlDbType.Int).Value = EmpIsActive
                .Parameters.AddWithValue("@EmployeStatus", SqlDbType.Int).Value = EmployeStatus
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
    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            Call MYSP_Hide()
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'IsActive
            If cmbIsActive.Checked Then
                IsActive = 1
            Else
                IsActive = 0
            End If
            'txtEmployeID
            If Me.txtEmployeID.Text = Nothing Then
                ErrorProvider1.SetError(Me.txtEmployeID, "يرجي ادخال اسم المادة")
                Call XCLS.MyCodes_TextNotNull(Me.txtEmployeID, "اسم المادة")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.txtEmployeID, String.Empty)
                EmployeCode = CStr(Trim(Me.txtEmployeID.Text))
            End If
            'EmpFirstName
            If Me.txtName.Text = Nothing Then
                ErrorProvider1.SetError(Me.txtName, "يرجي ادخال اسم المادة")
                Call XCLS.MyCodes_TextNotNull(Me.txtName, "اسم المادة")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.txtName, String.Empty)
                EmpFirstName = CStr(Trim(Me.txtName.Text))
            End If

            EmpFathName = CStr(Trim(Me.txtFather.Text))
            EmpGranFathName = CStr(Trim(Me.txtGrandFather.Text))
            EmpSurName = CStr(Trim(Me.txtSurname.Text))

            'AdjectiveID
            If Me.cmbAdjective.Text = Nothing Then
                ErrorProvider1.SetError(Me.cmbAdjective, "يرجي تحديد الصفة")
                Call XCLS.MyCodes_CboNotNull_Index(Me.cmbAdjective, "يرجي تحديد صفة الموظف")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.cmbAdjective, String.Empty)
                AdjectiveID = CStr(Me.cmbAdjective.Text).Trim
            End If
            'SpecializationID
            If Me.cmbSpecialization.Text = Nothing Then
                ErrorProvider1.SetError(Me.cmbSpecialization, "يرجي تحديد التخصص")
                Call XCLS.MyCodes_CboNotNull_Index(Me.cmbSpecialization, "يرجي تحديد تخصص الموظف")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.cmbSpecialization, String.Empty)
                If Me.cmbAdjective.SelectedIndex = 1 Then
                    ErrorProvider1.SetError(Me.cmbSpecialization, String.Empty)

                    SpecializationID = CInt(Me.cmbSpecialization.SelectedValue)
                ElseIf Me.cmbAdjective.SelectedIndex = 2 Then
                    ErrorProvider1.SetError(Me.cmbSpecialization, String.Empty)

                    SpecializationID = CInt(Me.cmbSpecialization.SelectedValue)
                Else
                    ErrorProvider1.SetError(Me.cmbSpecialization, String.Empty)
                    SpecializationID = CInt(Me.cmbSpecialization.SelectedValue)

                End If
            End If
            'JobTitleID
            If Me.cmbJobTitle.Text = Nothing Then
                ErrorProvider1.SetError(Me.cmbJobTitle, "يرجي تحديد التخصص")
                Call XCLS.MyCodes_CboNotNull_Index(Me.cmbJobTitle, "يرجي تحديد تخصص الموظف")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.cmbJobTitle, String.Empty)
                If Me.cmbAdjective.SelectedIndex = 1 Then
                    ErrorProvider1.SetError(Me.cmbJobTitle, String.Empty)
                    Me.cmbJobTitle.SelectedIndex = 1
                    JobTitleID = CInt(Me.cmbJobTitle.SelectedValue)
                ElseIf Me.cmbAdjective.SelectedIndex = 2 Then
                    ErrorProvider1.SetError(Me.cmbJobTitle, String.Empty)
                    Me.cmbJobTitle.SelectedIndex = 1
                    JobTitleID = CInt(Me.cmbJobTitle.SelectedValue)
                Else
                    ErrorProvider1.SetError(Me.cmbJobTitle, String.Empty)
                    JobTitleID = CInt(Me.cmbJobTitle.SelectedValue)
                End If
            End If
            'AdministrativeID
            If Me.cmbAdministrative.Text = Nothing Then
                ErrorProvider1.SetError(Me.cmbAdministrative, "يرجي تحديد الادارة")
                Call XCLS.MyCodes_CboNotNull_Index(Me.cmbAdministrative, "يرجي تحديد ادارة الموظف")
                Exit Sub
            Else
                ErrorProvider1.SetError(Me.cmbAdministrative, String.Empty)
                AdministrativeID = CInt(Me.cmbAdministrative.SelectedValue)
            End If

            EmpGender = CStr(Me.cmbGender.SelectedItem).Trim
            NationalityID = CInt(Me.cmbNationality.SelectedValue)
            UserID = CInt(Me.cmbUser.SelectedValue)
            CityID = CInt(Me.cmbCity.SelectedValue)
            EmpZone = CStr(Trim(Me.txtZone.Text))
            EmpAddress = CStr(Trim(Me.txtAddress.Text))
            EmpPhone1 = CStr(Trim(Me.txtPhone1.Text))
            EmpPhone2 = CStr(Trim(Me.txtPhone2.Text))
            EmpEmail = CStr(Trim(Me.txtPhone2.Text))
            EmpNote = CStr(Trim(Me.txtNote.Text))

            EmpPlaceNumRegist = CStr(Trim(Me.txtPlaceAndNumberRegistration.Text))
            EmpPlaceBirth = CStr(Trim(Me.txtPlaceBirth.Text))


            EmpDateBirth = Me.dtpDateBirth.Value
            'EmpCardNum = CInt(Me.txtCardNumber.Text)
            'EmpIDNum = CInt(Me.txtIDNumber.Text)
            'EmpCardObtaiDate = Me.dtpObtainingDate.Value
            EmpCardObtaiPlace = CStr(Trim(Me.txtObtainingPlace.Text))
            EmpPassportID = CStr(Trim(Me.txtPassportID.Text))
            EmpPassportGetPlace = CStr(Trim(Me.txtPassportGetPlace.Text))
            'EmpObtaiPassportDate = Me.dtpObtainingPassportDate.Value
            'EmpExpiryPassportDate = Me.dtpExpiryPassportDate.Value
            EmpEntryPlace = CStr(Trim(Me.txtEntryPlace.Text))
            'EmpEntryDate = Me.dtpEntryDate.Value
            'EmpResidencyNum = CInt(Trim(Me.txtResidencyNum.Text))
            EmpResidencyPlace = CStr(Trim(Me.txtResidencyPlace.Text))
            EmpFatherName = CStr(Trim(Me.txtFatherName.Text))
            EmpMotherName = CStr(Trim(Me.txtMotherName.Text))
            EmpMaritalStatus = CStr(Trim(Me.cmbMaritalStatus.SelectedItem))
            'EmpFamilyNum = CInt(Trim(Me.txtFamilyNum.Text))

            EmployeStatus = 1
            'ClinicID And ItemExaminID1,ItemExaminID2,ItemExaminID3
            If Me.cmbAdjective.SelectedIndex = 1 Then
                ClinicID = CInt(Me.cmbClinic.SelectedValue)
                ItemExaminID1 = CInt(Me.cmbService1.SelectedValue)
                ItemExaminID2 = CInt(Me.cmbService2.SelectedValue)
                ItemExaminID3 = CInt(Me.cmbService3.SelectedValue)
            Else
                Exit Sub
            End If

            Call MYSP_Show()
            BGW_Save.RunWorkerAsync()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

#End Region
#Region "Load"
    Private Sub frmAddEmploye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                Call XCLS.MyCodes_Fill_DataTable(sQLtbEmploye, MyVar_Dt_AllAccounts)
                Call XCLS.MyCodes_Fill_DataTable(VarSQLCountries, MyVarDT_Countries)
                Call XCLS.MyCodes_Fill_DataTable(sQLSpecialization, MyVarDT_Specialization)
                Call XCLS.MyCodes_Fill_DataTable(sQLAdministrative, VarAdministrativeTypeDT)
                Call XCLS.MyCodes_Fill_DataTable(sQLUsers, MyVarDT_Users)
                Call XCLS.MyCodes_Fill_DataTable(sQLCities, MyVarDT_Cities)
                Call XCLS.MyCodes_Fill_DataTable(sQLJobTitle, VarJobTitleDT)
                Call XCLS.MyCodes_Fill_DataTable(sQLJobTitleE, VarJobTitleDTE)
                Call XCLS.MyCodes_Fill_DataTable(sQLClincic, VarClinicDT)
                Call XCLS.MyCodes_Fill_DataTable(sQLItemsServices, VarItemsServicesDT1)
                Call XCLS.MyCodes_Fill_DataTable(sQLItemsServices, VarItemsServicesDT2)
                Call XCLS.MyCodes_Fill_DataTable(sQLItemsServices, VarItemsServicesDT3)
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
            Me.cmbGender.DataSource = VarGenderList
            Me.cmbAdjective.DataSource = VarAdjective
            Call XCLS.MyCodes_CmbFill(Me.cmbNationality, MyVarDT_Countries, "arName", "CountriesID")
            Call XCLS.MyCodes_CmbFill(Me.cmbSpecialization, MyVarDT_Specialization, "SpecializationName", "SpecializationID")
            Call XCLS.MyCodes_CmbFill(Me.cmbAdministrative, VarAdministrativeTypeDT, "AdministrativeName", "AdministrativeID")
            Call XCLS.MyCodes_CmbFill(Me.cmbUser, MyVarDT_Users, "Username", "UserID")
            Call XCLS.MyCodes_CmbFill(Me.cmbCity, MyVarDT_Cities, "CityName", "CityID")
            Call XCLS.MyCodes_CmbFill(Me.cmbClinic, VarClinicDT, "ClinicName", "ClinicID")
            Call XCLS.MyCodes_CmbFill(Me.cmbService1, VarItemsServicesDT1, "ItemName", "ItemID")
            Call XCLS.MyCodes_CmbFill(Me.cmbService2, VarItemsServicesDT2, "ItemName", "ItemID")
            Call XCLS.MyCodes_CmbFill(Me.cmbService3, VarItemsServicesDT3, "ItemName", "ItemID")
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
            Me.cmbNationality.SelectedIndex = 0
            Me.cmbSpecialization.SelectedIndex = -1
            Me.cmbAdministrative.SelectedIndex = -1
            Me.cmbService1.SelectedIndex = -1
            Me.cmbService2.SelectedIndex = -1
            Me.cmbService3.SelectedIndex = -1
            Me.cmbUser.SelectedIndex = -1
            Me.cmbCity.SelectedIndex = -1
            Me.cmbJobTitle.SelectedIndex = -1
            Me.cmbClinic.SelectedIndex = -1
            Me.cmbSpecialization.Enabled = False
            Me.TabClinicsServices.Enabled = False

            'Me.dtpDateBirth.Value = DateTime.Now.ToString("yyyy/MM/dd")
            'Me.dtpEntryDate.Value = Today
            'Me.dtpExpiryPassportDate.Value = Today
            'Me.dtpObtainingDate.Value = Today
            'Me.dtpObtainingPassportDate.Value = Today
            'Me.dtpResidencyExpiry.Value = Today

        End If
        Call MYSP_Hide()
    End Sub
#End Region
#Region "Function"
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
#End Region
End Class