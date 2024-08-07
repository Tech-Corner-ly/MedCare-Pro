Public Class frmEmployees
#Region "Variable"
    Private XCLS As New ClsMain
    Private MyVarDT_Employe As DataTable = New DataTable
    Private MyVarDV_Employe As DataView = New DataView
    Private VarCategory_DT As DataTable = New DataTable
    Private VarBrandCompany_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable
    Private Var_Warehouse_DT As DataTable = New DataTable
    Private Var_ItemNamw_DT As DataTable = New DataTable

    Private VarCategory_DS As New AutoCompleteStringCollection
    Private Var_Warehouse_DS As New AutoCompleteStringCollection
    Private VarGroupItems_DS As New AutoCompleteStringCollection
    Private VarBrandCompany_DS As New AutoCompleteStringCollection
    Private VarItemName_DS As New AutoCompleteStringCollection


    Private VarSelAdjective As String
    Private VarSpecializationName As String
    Public VarDocSpecializationID As Integer
    Public VarSpecializationStatus As Integer = 1
    Private VarCount As String
    Private dt As New DataTable

#End Region
#Region "SQL"
    Private sQLWarehouse As String = "SELECT [WarehouseID]
                                      ,[WarehouseName]
                                  FROM [Warehouses]
                                  Where [WarehouseStatus]=1"
    Private sQLCategory As String = "SELECT [CategoryID]
                                          ,[CategoryName]
                                      FROM [Categories]
                                      Where [CategoryStatus]=1"
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
                                                  ,[EmployeCode]
                                                  ,[EmpFirstName]
                                                  ,[EmpSurName]
                                                  ,[AdjectiveID]
                                                  ,[SpecializationName]
                                                  ,[JobTitle]
                                                  ,[AdministrativeName]
                                                  ,[EmpGender]
                                                  ,[arName]
                                                  ,[EmpPhone1]
                                                  ,[EmpPhone2]
                                              FROM [vEmploye]"
#End Region
#Region "Function"
    Private Sub MYSP_Show()
        Me.Timer1.Start()
        Me.PB.Visible = True
        Me.GroupBox1.Enabled = False
        Me.DGV.Enabled = False
        Me.txtSearch.Enabled = False
    End Sub
    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1
        Me.GroupBox1.Enabled = True
        Me.DGV.Enabled = True
        Me.txtSearch.Enabled = True
    End Sub
#End Region
#Region "Event"
    Private Sub btnAddEmploye_Click(sender As Object, e As EventArgs) Handles btnAddEmploye.Click
        frmAddEmploye.Show()
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
                Call XCLS.MyCodes_Fill_DataTable(sQLCategory, VarCategory_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLBrandCompany, VarBrandCompany_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLGroupItem, VarGroupItems_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLWarehouse, Var_Warehouse_DT)
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
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, lblCount, MyVarDT_Employe, MyVarDV_Employe)
            'Call XCLS.MyCode_Fill_DS(Me.txtCategory, VarCategory_DT, "CategoryName", VarCategory_DS)
            'Call XCLS.MyCode_Fill_DS(Me.txtWarehouse, Var_Warehouse_DT, "WarehouseName", Var_Warehouse_DS)
            'Call XCLS.MyCode_Fill_DS(Me.txtGroups, VarGroupItems_DT, "GroupItemName", VarGroupItems_DS)
            'Call XCLS.MyCode_Fill_DS(Me.txtCompanyMother, VarBrandCompany_DT, "BranCompName", VarBrandCompany_DS)
            'Call XCLS.MyCode_Fill_DS(Me.txtName, Var_ItemNamw_DT, "ItemName", VarItemName_DS)

            'Me.cmbItemType.DataSource = VarItemType
            'Me.cmbItemType.SelectedIndex = -1


            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()

    End Sub

    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
#End Region
End Class