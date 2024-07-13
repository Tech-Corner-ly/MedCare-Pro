Public Class frmAddItemsServices

    Private XCLS As New ClsMain

    Private VarClinicID As Integer
    Private VarItemsStatus As Integer = 1


    Private VarCategory_DT As DataTable = New DataTable
    Private VarBrandCompany_DT As DataTable = New DataTable
    Private VarGroupItems_DT As DataTable = New DataTable




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

                Me.cmbCategory.SelectedIndex = -1
                Me.cmbCompanyMother.SelectedIndex = -1
                Me.cmbGroups.SelectedIndex = -1
            End If
            Call MYSP_Hide()

        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub

        End Try
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        frmAddBrandCompany.Show()
    End Sub
End Class