Imports System.Data.SqlClient

Public Class frmAddWarehouse
    Private XCLS As New ClsMain

    Private Var_City_DT As DataTable = New DataTable

    Private VarWarehouseID, VarCityID As Integer
    Private VarWarehouseLatin, VarWarehouseName, VarWarehouseAddress As String
    Private VarWarehouseStatus As Integer = 1


    Private sQLCity As String = "SELECT [CityID],[CityName] FROM [tbCities]"

    Private sQLInsert As String = "Insert Into Warehouses (WarehouseName,WarehouseLatin,CityID,WarehouseAddress,WarehouseStatus,InsertTime,UserID_Insert)values(@WarehouseName,@WarehouseLatin,@CityID,@WarehouseAddress,@WarehouseStatus,@InsertTime,@UserID_Insert)"
    Private sQLUpdate As String
    Private sQLDelete As String
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

    Private Sub NewSaveStatus()
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub ClearCN()
        Me.txtWarehouseID.Text = ""
        Me.txtWarehouseName.Text = ""
        Me.txtWarehouseLatin.Text = ""
        Me.txtWarehouseAddress.Text = ""
    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                Call XCLS.MyCodes_Fill_DataTable(sQLCity, Var_City_DT)
                VarBGW_Status = False
            Else
                VarBGW_Status = True
            End If
        Catch ex As Exception
            VarBGW_Status = False
            MsgBox(ex.Message)
        Finally
            sQlConnection.Close()
        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call MYSP_Show()
        'VarWarehouseID = CInt(Me.txtBranCompID.Text)
        VarWarehouseName = Trim(Me.txtWarehouseName.Text)
        VarWarehouseLatin = Trim(Me.txtWarehouseLatin.Text)
        VarCityID = CInt(Me.cmbCityID.SelectedValue)
        VarWarehouseAddress = Trim(Me.txtWarehouseAddress.Text)
        VarWarehouseStatus = 1
        BGW_Save.RunWorkerAsync()

    End Sub

    Private Sub frmAddWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        Try
            If VarBGW_Status = True Then
                lblUsername.Text = VarUserName
                Call XCLS.MyCodes_CmbFill(Me.cmbCityID, Var_City_DT, "CityName", "CityID")
                Me.cmbCityID.SelectedIndex = -1

                NewSaveStatus()
                ClearCN()
                Call MYSP_Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BGW_Save_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Save.DoWork
        Try
            Dim Cmd As New SqlCommand(sQLInsert, sQlConnection)
            With Cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@WarehouseName", SqlDbType.VarChar).Value = VarWarehouseName
                .Parameters.AddWithValue("@WarehouseLatin", SqlDbType.VarChar).Value = VarWarehouseLatin
                .Parameters.AddWithValue("@CityID", SqlDbType.Int).Value = VarCityID
                .Parameters.AddWithValue("@WarehouseAddress", SqlDbType.VarChar).Value = VarWarehouseAddress
                .Parameters.AddWithValue("@WarehouseStatus", SqlDbType.Int).Value = VarWarehouseStatus
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.PB.Value < 100 Then
            Me.PB.Value += 1
        Else
            Me.PB.Value = 1

        End If

    End Sub

End Class