Public Class frmAddEmploye

    'Var
    Private XCLS As New ClsMain
    Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    Private MyVarDT_Countries As DataTable = New DataTable
    Private MyVarDT_Specialization As DataTable = New DataTable
    Private MyVarDT_Users As DataTable = New DataTable
    Private MyVarDT_Cities As DataTable = New DataTable
    Private VarAdministrativeTypeDT As DataTable = New DataTable
    Private VarJobTitleDT As DataTable = New DataTable

    Private VarAdministrative As String
    Private VarAdministrativeStatus As Integer = 1
    Private VarAdministrativeParentCode As Integer
    Private VarAdministrativeParentLatin, VarAdministrativeParent, VarAdministrativeFather, VarAdministrativeType As String

    'SQL
    Private sQLCities As String = "SELECT CityID,CityName FROM tbCities"
    Private sQLUsers As String = "SELECT UserID,Username FROM tblUsers Where UserStatus=1 AND UserIsActive=1"
    Private sQLAdministrative As String = "SELECT [AdministrativeID]
                                                  ,[AdministrativeName]
                                              FROM [tbAdministrative]
                                              Where [AdministrativeStatus]=1"
    Private sQLSpecialization As String = "SELECT SpecializationID,SpecializationName FROM tbSpecialization Where SpecializationStatus=1 AND Adjective='طبي'"
    Private sQLtbEmploye As String = "SELECT * FROM tbEmploye Where EmployeStatus=1 "
    Private Sql_Dt_AllAccounts As String = "SELECT * From tbAdministrative Where AdministrativeStatus=1"
    Private sQLInsert As String = "Insert Into tbEmploye (EmployeCode,EmpFirstName,EmpFathName,EmpGranFathName,EmpSurName,
                AdjectiveID,SpecializationID,JobTitleID,AdministrativeID,EmpGender,NationalityID,UserID,
                CityID,EmpZone,EmpAddress,EmpPhone1,EmpPhone2,EmpEmail,EmpNote,EmpPlaceNumRegist,EmpPlaceBirth,
                EmpDateBirth,EmpCardNum,EmpIDNum,EmpCardObtaiDate,EmpCardObtaiPlace,EmpPassportID,EmpPassportGetPlace,
                EmpObtaiPassportDate,EmpExpiryPassportDate,EmpEntryPlace,EmpEntryDate,EmpResidencyNum,EmpResidencyPlace,
                EmpResidencyExpiry,EmpFatherName,EmpMotherName,EmpMaritalStatus,EmpFamilyNum,ClinicID,ItemExaminID1,
                ItemExaminID2,ItemExaminID3,EmpIsActive,EmployeStatus,InsertTime,UserID_Insert)
                values
                (@EmployeCode,@EmpFirstName,@EmpFathName,@EmpGranFathName,@EmpSurName,@AdjectiveID,@SpecializationID,
                @JobTitleID,@AdministrativeID,@EmpGender,@NationalityID,@UserID,@CityID,@EmpZone,@EmpAddress,@EmpPhone1,
                @EmpPhone2,@EmpEmail,@EmpNote,@EmpPlaceNumRegist,@EmpPlaceBirth,@EmpDateBirth,@EmpCardNum,@EmpIDNum,
                @EmpCardObtaiDate,@EmpCardObtaiPlace,@EmpPassportID,@EmpPassportGetPlace,@EmpObtaiPassportDate,@EmpExpiryPassportDate,
                @EmpEntryPlace,@EmpEntryDate,@EmpResidencyNum,@EmpResidencyPlace,@EmpResidencyExpiry,@EmpFatherName,@EmpMotherName,
                @EmpMaritalStatus,@EmpFamilyNum,@ClinicID,@ItemExaminID1,@ItemExaminID2,@ItemExaminID3,
                @EmpIsActive,@EmployeStatus,@InsertTime,@UserID_Insert)"
    Private sQLJobTitle As String = "SELECT [JobTitleID]
                                              ,[JobTitle]
                                          FROM [tbJobTitle]
                                          Where [JobTitleStatus]=1 AND [Adjective]='مدني'"

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
            Call XCLS.MyCodes_CmbFill(Me.cmbJobTitle, VarJobTitleDT, "JobTitle", "JobTitleID")
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
            Me.cmbNationality.SelectedIndex = -1
            Me.cmbSpecialization.SelectedIndex = -1
            Me.cmbAdministrative.SelectedIndex = -1
            Me.cmbUser.SelectedIndex = -1
            Me.cmbCity.SelectedIndex = -1
            Me.cmbJobTitle.SelectedIndex = -1
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub cmbAdjective_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdjective.SelectedIndexChanged
        'Select Case Me.cmbAdjective.SelectedItem
        '    Case "طبي"
        '        Me.cmbAdministrativeFather.Enabled = False
        '        Me.txtAdministrativeID.Enabled = False
        '        Me.cmbAdministrativeFather.Text = " "
        '    Case "مدي"
        '        Me.cmbAdministrativeFather.Enabled = True
        '        Me.txtAdministrativeID.Enabled = False
        '        Me.cmbAdministrativeFather.Text = ""
        'End Select
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub
End Class