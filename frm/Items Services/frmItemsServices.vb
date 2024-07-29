Public Class frmItemsServices
    'Var
    Private XCLS As New ClsMain
    'Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    'Private MyVarDT_Countries As DataTable = New DataTable
    Private MyVarDT_ItemsServices As DataTable = New DataTable
    Private MyVarDV_ItemsServices As DataView = New DataView
    Private VarCategory_DT As DataTable = New DataTable
    Private VarBrandCompany_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable
    Private Var_Warehouse_DT As DataTable = New DataTable


    Private VarSelAdjective As String
    Private VarSpecializationName As String
    Public VarDocSpecializationID As Integer
    Public VarSpecializationStatus As Integer = 1
    Private VarCount As String
    Private dt As New DataTable




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

    Private sQLItemsServices As String = "SELECT [ItemID]
                                                  ,[ItemCode]
                                                  ,[CategoryName]
                                                  ,[ItemName]
                                                  ,[ItemLatin]
                                                  ,[GroupItemName]
                                                  ,[WarehouseName]
                                                  ,[BranCompName]
                                                  ,[ItemType]
                                                  ,[PercDoctor]
                                                  ,[AmountDoctor]
                                                  ,[Price1]
                                                  ,[Price2]
                                                  ,[Price3]
                                                  ,[Price4]
                                                  ,[Price5]
                                                  ,[Price6]
                                              FROM [vItemsServices]"
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
    Private Sub btnAddEmploye_Click(sender As Object, e As EventArgs) Handles btnAddEmploye.Click
        cmsAdd.Show(btnAddEmploye, 1, btnAddEmploye.Height)
    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_ItemsServices.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLItemsServices, MyVarDT_ItemsServices)
                Call XCLS.MyCodes_Fill_DataTable(sQLCategory, VarCategory_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLBrandCompany, VarBrandCompany_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLGroupItem, VarGroupItems_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLWarehouse, Var_Warehouse_DT)

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
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            Call XCLS.MyCodes_CmbFill(Me.cmbCategory, VarCategory_DT, "CategoryName", "CategoryID")
            Call XCLS.MyCodes_CmbFill(Me.cmbCompanyMother, VarBrandCompany_DT, "BranCompName", "BranCompID")
            Call XCLS.MyCodes_CmbFill(Me.cmbGroups, VarGroupItems_DT, "GroupItemName", "GroupItemID")
            Call XCLS.MyCodes_CmbFill(Me.cmbWarehouse, Var_Warehouse_DT, "WarehouseName", "WarehouseID")

            Dim VarCategory_DS As New AutoCompleteStringCollection
            Dim Var_Warehouse_DS As New AutoCompleteStringCollection

            Call XCLS.MyCode_Fill_DS(Me.TextBox1, VarCategory_DT, "CategoryName", VarCategory_DS)
            Call XCLS.MyCode_Fill_DS(Me.TextBox2, Var_Warehouse_DT, "WarehouseName", Var_Warehouse_DS)

            Me.cmbItemType.DataSource = VarItemType
            Me.cmbWarehouse.SelectedIndex = -1
            Me.cmbCategory.SelectedIndex = -1
            Me.cmbCompanyMother.SelectedIndex = -1
            Me.cmbGroups.SelectedIndex = -1
            Me.cmbItemType.SelectedIndex = -1


            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If
    End Sub

    Private Sub frmItemsServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub tmsAddItems_Click(sender As Object, e As EventArgs) Handles tmsAddItems.Click
        Dim xForm As New frmAddItemsServices
        xForm.ShowDialog()

    End Sub

    Private Sub tmsAddCate_Click(sender As Object, e As EventArgs) Handles tmsAddCate.Click
        Dim xForm As New frmCategory
        xForm.ShowDialog()
    End Sub

    Private Sub tmsAddCat_Click(sender As Object, e As EventArgs) Handles tmsAddCat.Click
        Dim xForm As New frmCategory
        xForm.ShowDialog()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "CategoryName like '%" & Me.TextBox1.Text & "%' Or WarehouseName Like '%" & Me.TextBox2.Text & "%' "
            'MyPubVar_Filter = "CategoryName like '%" & xCate & "%' "
            'Or
            '            GroupItemName Like '%" & Trim(Me.cmbGroups.Text) & "%'OR 
            '            ItemType Like '%" & Trim(Me.cmbItemType.Text) & "%'OR 
            '            WarehouseName Like '%" & Trim(Me.cmbWarehouse.Text) & "%'OR 
            '            BranCompName Like '%" & Trim(Me.cmbCompanyMother.Text) & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim xCate As String = Me.cmbCategory.Text
            MyPubVar_Filter = ""
            MyPubVar_Filter = "ItemCode+ItemName+ItemLatin like '%" & Me.txtSearch.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        'Try
        '    Dim xCate As String = Me.cmbCategory.Text
        '    MyPubVar_Filter = ""
        '    MyPubVar_Filter = "CategoryName like '%" & xCate & "%'"
        '    Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
        '    MyPubVar_Filter = ""
        'Catch ex As Exception
        '    MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        'End Try

    End Sub
End Class