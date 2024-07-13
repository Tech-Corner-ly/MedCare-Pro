Public Class frmWarehouses
    'Var
    Private XCLS As New ClsMain
    Private MyVarDT_Warehouses As DataTable = New DataTable
    Private MyVarDV_Warehouses As DataView


    Private sQLWarehouses As String = "SELECT [WarehouseID]
                                              ,[WarehouseName]
                                              ,[WarehouseLatin]
                                              ,[CityID]
                                              ,[WarehouseAddress]
                                          FROM [Warehouses]
                                          Where [WarehouseStatus]=1"

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

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_Warehouses.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLWarehouses, MyVarDT_Warehouses)
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
        Try
            If VarBGW_Status = True Then
                lblUsername.Text = VarUserName
                lblDateTime.Text = VarDateTimeNow
                Call XCLS.MyCodes_Fill_Dgv(DataGridView1, lblCount, MyVarDT_Warehouses, MyVarDV_Warehouses)
            End If
            Call MYSP_Hide()

        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub

        End Try

        If VarBGW_Status = True Then

        End If

    End Sub

    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub btnAddBrandCompany_Click(sender As Object, e As EventArgs) Handles btnAddBrandCompany.Click
        frmAddWarehouse.Show()
    End Sub
End Class