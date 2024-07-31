Public Class frmItemsServices
    'Var
    Private XCLS As New ClsMain
    Private MyVarDT_ItemsServices As DataTable = New DataTable
    Private MyVarDV_ItemsServices As DataView = New DataView
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
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.txtSearch.Enabled = False
    End Sub

    Private Sub MYSP_Hide()
        Me.Timer1.Stop()
        Me.PB.Value = 100
        System.Threading.Thread.Sleep(200)
        Me.PB.Visible = False
        Me.PB.Value = 1
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.txtSearch.Enabled = True
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
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            Call XCLS.MyCode_Fill_DS(Me.txtCategory, VarCategory_DT, "CategoryName", VarCategory_DS)
            Call XCLS.MyCode_Fill_DS(Me.txtWarehouse, Var_Warehouse_DT, "WarehouseName", Var_Warehouse_DS)
            Call XCLS.MyCode_Fill_DS(Me.txtGroups, VarGroupItems_DT, "GroupItemName", VarGroupItems_DS)
            Call XCLS.MyCode_Fill_DS(Me.txtCompanyMother, VarBrandCompany_DT, "BranCompName", VarBrandCompany_DS)
            Call XCLS.MyCode_Fill_DS(Me.txtName, Var_ItemNamw_DT, "ItemName", VarItemName_DS)

            Me.cmbItemType.DataSource = VarItemType
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


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "ItemCode+ItemName+ItemLatin like '%" & Me.txtSearch.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub


    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "CategoryName like '%" & Me.txtCategory.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub txtGroups_TextChanged(sender As Object, e As EventArgs) Handles txtGroups.TextChanged
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "GroupItemName like '%" & Me.txtGroups.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try

    End Sub

    Private Sub txtWarehouse_TextChanged(sender As Object, e As EventArgs) Handles txtWarehouse.TextChanged
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "WarehouseName like '%" & Me.txtWarehouse.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try

    End Sub

    Private Sub txtCompanyMother_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyMother.TextChanged
        Try
            MyPubVar_Filter = ""
            MyPubVar_Filter = "BranCompName like '%" & Me.txtCompanyMother.Text & "%'"
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
            MyPubVar_Filter = ""
        Catch ex As Exception
            MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        End Try
    End Sub

    Private Sub cmbItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemType.SelectedIndexChanged
        'Try
        '    MyPubVar_Filter = ""
        '    MyPubVar_Filter = "CategoryName like '%" & Me.txtCategory.Text & "%'"
        '    Call XCLS.MyCodes_Fill_Dgv(Me.DGV, Me.lblCount, MyVarDT_ItemsServices, MyVarDV_ItemsServices)
        '    MyPubVar_Filter = ""
        'Catch ex As Exception
        '    MsgBox(Me_MsgErrorStr + vbNewLine + vbNewLine + ex.Message, Me_MsgInfoStyle, Me_MsgCaptionStr)
        'End Try
    End Sub
End Class