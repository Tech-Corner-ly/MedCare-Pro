Imports System.Data.SqlClient

Public Class frmAddItemsServices

    Private XCLS As New ClsMain

    Private VarClinicID As Integer
    Private VarItemsStatus As Integer = 1

    Private ItemNote, CalcuMethod, ColorUnit, CostCalcType, ItemCode, ItemName, ItemLatin, Specifications, ItemSource, ItemBarcode, ItemType As String
    Private CompanyMother, IsActive, CategoryID, SupplierID, LastSupplierID, GroupsID, WarehouseID, CostCenterID, CheckExpiryDate, PreventingNegativeWithdrawals, StopSelling, StopEditPrice, UnitTypeID As Integer
    Private PercPrice1, PercPrice2, PercPrice3, PercPrice4, PercPrice5, PercPrice6, Price1, Price2, Price3, Price4, Price5, Price6, LastCostPrice, CostPrice, LastPurchPrice, PurchPrice, UnitEqu, AmountDoctor, PercDoctor, HighUnit, WidthUnit, HeightUnit, SizeUnit, WeightUnit, MeasurementUnit As Decimal

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()

        If cmbIsActive.Checked Then
            IsActive = 1
        Else
            IsActive = 0
        End If
        If cbCheckExpiryDate.Checked Then
            CheckExpiryDate = 1
        Else
            CheckExpiryDate = 0
        End If
        If cbPreventingNegativeWithdrawals.Checked Then
            PreventingNegativeWithdrawals = 1
        Else
            PreventingNegativeWithdrawals = 0
        End If
        If cbStopSelling.Checked Then
            StopSelling = 1
        Else
            StopSelling = 0
        End If
        If cbStopEditPrice.Checked Then
            StopEditPrice = 1
        Else
            StopEditPrice = 0
        End If
        ItemNote = CStr(Trim(Me.txtNote.Text))
        CalcuMethod = CStr(Trim(Me.cmbCalcuMethod.Text))
        ColorUnit = CStr(Trim(Me.txtColor.Text))
        CostCalcType = CStr(Trim(Me.cmbCostCalc.Text))
        ItemCode = CStr(Trim(Me.txtItemCode.Text))
        ItemName = CStr(Trim(Me.txtItemName.Text))
        ItemLatin = CStr(Trim(Me.txtItemLatin.Text))
        Specifications = CStr(Trim(Me.txtSpecifications.Text))
        ItemSource = CStr(Trim(Me.txtSource.Text))
        ItemBarcode = CStr(Trim(Me.txtBarcode.Text))
        If Me.cmbCategory.SelectedIndex = -1 Then
            MsgBox("يرجي تحديد فئة المنتج !")
            Exit Sub
        Else
            CategoryID = CInt(Me.cmbCategory.SelectedValue)
        End If
        If Me.cmbItemType.SelectedIndex = -1 Then
            MsgBox("يرجي تحديد نوع المنتج !")
            Exit Sub
        Else
            ItemType = CStr(Me.cmbItemType.SelectedItem)
        End If

        'SupplierID = CInt(Me.cmbSupplier.SelectedValue)
        'LastSupplierID = CStr(Me.cmbLastSupplier.Text)
        GroupsID = CInt(Me.cmbGroups.SelectedValue)
        WarehouseID = CInt(Me.cmbWarehouse.SelectedValue)
        'CostCenterID = CInt(Me.cmbCostCenter.SelectedValue)

        'UnitTypeID = CInt(Me.cmbUnitType.SelectedValue)
        CompanyMother = CInt(Me.cmbCompanyMother.SelectedValue)

        IsActive = 1

        Call XCLS.MyCodes_OnlyNumeric(Me.txtFirstPrice, "يجب ان يكون رقم ")
        PercPrice1 = Convert.ToDecimal(Me.txtFirstProfitPerc.Text)
        PercPrice2 = Convert.ToDecimal(Me.txtSecondProfitPerc.Text)
        PercPrice3 = Convert.ToDecimal(Me.txtThirdProfitPerce.Text)
        PercPrice4 = Convert.ToDecimal(Me.txtFourthProfitPerc.Text)
        PercPrice5 = Convert.ToDecimal(Me.txtFifthProfitPerc.Text)
        PercPrice6 = Convert.ToDecimal(Me.txtSixthProfitPerc.Text)
        Price1 = Convert.ToDecimal(Me.txtFirstPrice.Text)
        Price2 = Convert.ToDecimal(Me.txtSecondPrice.Text)
        Price3 = Convert.ToDecimal(Me.txtThirdPrice.Text)
        Price4 = Convert.ToDecimal(Me.txtFourthPrice.Text)
        Price5 = Convert.ToDecimal(Me.txtFifthPrice.Text)
        Price6 = Convert.ToDecimal(Me.txtSixthPrice.Text)
        LastCostPrice = Convert.ToDecimal(Me.txtLastCostPrice.Text)
        CostPrice = Convert.ToDecimal(Me.txtCostPrice.Text)
        LastPurchPrice = Convert.ToDecimal(Me.txtLastPurchPrice.Text)
        PurchPrice = Convert.ToDecimal(Me.txtPurchPrice.Text)
        'UnitEqu = Convert.ToDecimal(Me.txtUnitEqu.Text)
        'AmountDoctor = Convert.ToDecimal(Me.txtAmount.Text)
        'PercDoctor = Convert.ToDecimal(Me.txtPerc.Text)
        'HighUnit = Convert.ToDecimal(Me.txtHigh.Text)
        'WidthUnit = Convert.ToDecimal(Me.txtWidth.Text)
        'HeightUnit = Convert.ToDecimal(Me.txtHeight.Text)
        'SizeUnit = Convert.ToDecimal(Me.txtSizeUnit.Text)
        'WeightUnit = Convert.ToDecimal(Me.txtWeight.Text)
        'MeasurementUnit = Convert.ToDecimal(Me.txtMeasurement.Text)
        BGW_Save.RunWorkerAsync()

    End Sub

    Private Sub BGW_Save_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Save.RunWorkerCompleted
        If VarBGW_Status = True Then
            Call MYSP_Hide()
            BGW_Load.RunWorkerAsync()
        End If
        Call MYSP_Hide()
    End Sub



    Private VarCategory_DT As DataTable = New DataTable
    Private VarBrandCompany_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable
    Private Var_Warehouse_DT As DataTable = New DataTable

    Private sQLInsert As String = "Insert Into ItemsServices (IsActive,ItemCode,CategoryID,ItemName,ItemLatin,Specifications,ItemSource,CompanyMother,SupplierID,LastSupplierID,GroupsID,WarehouseID,CostCalcType,CostCenterID,CheckExpiryDate,PreventingNegativeWithdrawals,StopSelling,StopEditPrice,MeasurementUnit,ColorUnit,WeightUnit,SizeUnit,HeightUnit,WidthUnit,HighUnit,ItemType,CalcuMethod,PercDoctor,AmountDoctor,UnitTypeID,UnitEqu,PurchPrice,LastPurchPrice,CostPrice,LastCostPrice,Price1,Price2,Price3,Price4,Price5,Price6,PercPrice1,PercPrice2,PercPrice3,PercPrice4,PercPrice5,PercPrice6,ItemBarcode,ItemNote,InsertTime,UserID_Insert)values(@IsActive,@ItemCode,@CategoryID,@ItemName,@ItemLatin,@Specifications,@ItemSource,@CompanyMother,@SupplierID,@LastSupplierID,@GroupsID,@WarehouseID,@CostCalcType,@CostCenterID,@CheckExpiryDate,@PreventingNegativeWithdrawals,@StopSelling,@StopEditPrice,@MeasurementUnit,@ColorUnit,@WeightUnit,@SizeUnit,@HeightUnit,@WidthUnit,@HighUnit,@ItemType,@CalcuMethod,@PercDoctor,@AmountDoctor,@UnitTypeID,@UnitEqu,@PurchPrice,@LastPurchPrice,@CostPrice,@LastCostPrice,@Price1,@Price2,@Price3,@Price4,@Price5,@Price6,@PercPrice1,@PercPrice2,@PercPrice3,@PercPrice4,@PercPrice5,@PercPrice6,@ItemBarcode,@ItemNote,@InsertTime,@UserID_Insert)"



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

    Private Sub frmAddItemsServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                Call XCLS.MyCodes_Fill_DataTable(sQLCategory, VarCategory_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLBrandCompany, VarBrandCompany_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLGroupItem, VarGroupItems_DT)
                Call XCLS.MyCodes_Fill_DataTable(sQLWarehouse, Var_Warehouse_DT)

                VarBGW_Status = True
            End If

        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub
        End Try

    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        Try
            If VarBGW_Status = True Then
                Call XCLS.MyCodes_CmbFill(Me.cmbCategory, VarCategory_DT, "CategoryName", "CategoryID")
                Call XCLS.MyCodes_CmbFill(Me.cmbCompanyMother, VarBrandCompany_DT, "BranCompName", "BranCompID")
                Call XCLS.MyCodes_CmbFill(Me.cmbGroups, VarGroupItems_DT, "GroupItemName", "GroupItemID")
                Call XCLS.MyCodes_CmbFill(Me.cmbWarehouse, Var_Warehouse_DT, "WarehouseName", "WarehouseID")

                Me.cmbItemType.DataSource = VarItemType
                Me.cmbWarehouse.SelectedIndex = -1
                Me.cmbCategory.SelectedIndex = -1
                Me.cmbCompanyMother.SelectedIndex = -1
                Me.cmbGroups.SelectedIndex = -1
                Me.cmbItemType.SelectedIndex = -1

                Call XCLS.MyCode_Decmeil(Me.txtSecondProfitPerc)
                Call MYSP_Hide()
            End If
        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub

        End Try
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        frmAddBrandCompany.Show()
    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            Dim Cmd As New SqlCommand(sQLInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@IsActive", SqlDbType.Int).Value = IsActive
                .Parameters.AddWithValue("@ItemCode", SqlDbType.VarChar).Value = ItemCode
                .Parameters.AddWithValue("@CategoryID", SqlDbType.Int).Value = CategoryID
                .Parameters.AddWithValue("@ItemName", SqlDbType.NVarChar).Value = ItemName
                .Parameters.AddWithValue("@ItemLatin", SqlDbType.NVarChar).Value = ItemLatin
                .Parameters.AddWithValue("@Specifications", SqlDbType.VarChar).Value = Specifications
                .Parameters.AddWithValue("@ItemSource", SqlDbType.VarChar).Value = ItemSource
                .Parameters.AddWithValue("@CompanyMother", SqlDbType.Int).Value = CompanyMother
                .Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = SupplierID
                .Parameters.AddWithValue("@LastSupplierID", SqlDbType.Int).Value = LastSupplierID
                .Parameters.AddWithValue("@GroupsID", SqlDbType.Int).Value = GroupsID
                .Parameters.AddWithValue("@WarehouseID", SqlDbType.Int).Value = WarehouseID
                .Parameters.AddWithValue("@CostCalcType", SqlDbType.VarChar).Value = CostCalcType
                .Parameters.AddWithValue("@CostCenterID", SqlDbType.Int).Value = CostCenterID
                .Parameters.AddWithValue("@CheckExpiryDate", SqlDbType.Int).Value = CheckExpiryDate
                .Parameters.AddWithValue("@PreventingNegativeWithdrawals", SqlDbType.Int).Value = PreventingNegativeWithdrawals
                .Parameters.AddWithValue("@StopSelling", SqlDbType.Int).Value = StopSelling
                .Parameters.AddWithValue("@StopEditPrice", SqlDbType.Int).Value = StopEditPrice
                .Parameters.AddWithValue("@MeasurementUnit", SqlDbType.Decimal).Value = MeasurementUnit
                .Parameters.AddWithValue("@ColorUnit", SqlDbType.VarChar).Value = ColorUnit
                .Parameters.AddWithValue("@WeightUnit", SqlDbType.Decimal).Value = WeightUnit
                .Parameters.AddWithValue("@SizeUnit", SqlDbType.Decimal).Value = SizeUnit
                .Parameters.AddWithValue("@HeightUnit", SqlDbType.Decimal).Value = HeightUnit
                .Parameters.AddWithValue("@WidthUnit", SqlDbType.Decimal).Value = WidthUnit
                .Parameters.AddWithValue("@HighUnit", SqlDbType.Decimal).Value = HighUnit
                .Parameters.AddWithValue("@ItemType", SqlDbType.NVarChar).Value = ItemType
                .Parameters.AddWithValue("@CalcuMethod", SqlDbType.VarChar).Value = CalcuMethod
                .Parameters.AddWithValue("@PercDoctor", SqlDbType.Decimal).Value = PercDoctor
                .Parameters.AddWithValue("@AmountDoctor", SqlDbType.Decimal).Value = AmountDoctor
                .Parameters.AddWithValue("@UnitTypeID", SqlDbType.Int).Value = UnitTypeID
                .Parameters.AddWithValue("@UnitEqu", SqlDbType.Decimal).Value = UnitEqu
                .Parameters.AddWithValue("@PurchPrice", SqlDbType.Decimal).Value = PurchPrice
                .Parameters.AddWithValue("@LastPurchPrice", SqlDbType.Decimal).Value = LastPurchPrice
                .Parameters.AddWithValue("@CostPrice", SqlDbType.Decimal).Value = CostPrice
                .Parameters.AddWithValue("@LastCostPrice", SqlDbType.Decimal).Value = LastCostPrice
                .Parameters.AddWithValue("@Price1", SqlDbType.Decimal).Value = Price1
                .Parameters.AddWithValue("@Price2", SqlDbType.Decimal).Value = Price2
                .Parameters.AddWithValue("@Price3", SqlDbType.Decimal).Value = Price3
                .Parameters.AddWithValue("@Price4", SqlDbType.Decimal).Value = Price4
                .Parameters.AddWithValue("@Price5", SqlDbType.Decimal).Value = Price5
                .Parameters.AddWithValue("@Price6", SqlDbType.Decimal).Value = Price6
                .Parameters.AddWithValue("@PercPrice1", SqlDbType.Decimal).Value = PercPrice1
                .Parameters.AddWithValue("@PercPrice2", SqlDbType.Decimal).Value = PercPrice2
                .Parameters.AddWithValue("@PercPrice3", SqlDbType.Decimal).Value = PercPrice3
                .Parameters.AddWithValue("@PercPrice4", SqlDbType.Decimal).Value = PercPrice4
                .Parameters.AddWithValue("@PercPrice5", SqlDbType.Decimal).Value = PercPrice5
                .Parameters.AddWithValue("@PercPrice6", SqlDbType.Decimal).Value = PercPrice6
                .Parameters.AddWithValue("@ItemBarcode", SqlDbType.VarChar).Value = ItemBarcode
                .Parameters.AddWithValue("@ItemNote", SqlDbType.VarChar).Value = ItemNote
                .Parameters.AddWithValue("@InsertTime", SqlDbType.Date).Value = VarInsertTime
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


End Class