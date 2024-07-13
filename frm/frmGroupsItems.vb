Public Class frmGroupsItems
    'Var
    Private XCLS As New ClsMain
    Private MyVarDT_GroupItem As DataTable = New DataTable
    Private MyVarDT_ALLGroupItem As DataTable = New DataTable
    Private MyVarDV_ALLGroupItem As DataView


    Private sQLGroupItem As String = "SELECT [GroupItemID]
                                              ,CONCAT ([GroupItemName] ,' ',[GroupItemLatin]) as GorupsName
                                          FROM [GroupItems]
                                          Where [GroupItemStatus]=1"
    Private sQLAllGroupItem As String = "SELECT * FROM [GroupItems] Where [GroupItemStatus]=1"



    Private Sub FillTV()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()

        Dim xDV As DataView = MyVarDT_GroupItem.DefaultView
        xDV.Sort = "GroupItemID"
        For Each dr As DataRow In xDV.ToTable.Rows
            Me.TreeView1.Nodes.Add(dr("GroupItemID"), dr("GorupsName"))
        Next

        TreeView1.EndUpdate()

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

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_GroupItem.Clear()
                MyVarDT_ALLGroupItem.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLGroupItem, MyVarDT_GroupItem)
                Call XCLS.MyCodes_Fill_DataTable(sQLAllGroupItem, MyVarDT_ALLGroupItem)
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
                MyVarDV_ALLGroupItem = MyVarDT_ALLGroupItem.DefaultView
                lblCount.Text = MyVarDV_ALLGroupItem.Count
                FillTV()
            End If
            Call MYSP_Hide()

        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub

        End Try

        If VarBGW_Status = True Then

        End If


    End Sub

    Private Sub frmGroupsItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()

    End Sub

    Private Sub btnAddBrandCompany_Click(sender As Object, e As EventArgs) Handles btnAddBrandCompany.Click
        frmAddGroupItems.Show()
    End Sub
End Class