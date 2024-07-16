Public Class frmCategory
    Private XCLS As New ClsMain
    Private MyVar_Dt_Category As DataTable = New DataTable
    Private MyVar_DV_Category As DataView = MyVar_Dt_Category.DefaultView


    Private Sql_Category As String = "SELECT [CategoryID]
                                                  ,[CategoryName]
                                                  ,[ParentCategoryID]
                                                  ,[Level]
                                              FROM [Categories]"

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


    Private Sub FillTV()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()

        Dim xDV As DataView = MyVar_Dt_Category.DefaultView
        xDV.RowFilter = "Level=0"
        xDV.Sort = "CategoryID"
        For Each dr As DataRow In xDV.ToTable.Rows
            Me.TreeView1.Nodes.Add(dr("CategoryID"), dr("CategoryName"))
        Next

        xDV.RowFilter = "Level <> 0"
        xDV.Sort = "CategoryID,ParentCategoryID"
        For Each dr_Parent As DataRow In xDV.ToTable.Rows
            Dim xFinde() As TreeNode
            xFinde = TreeView1.Nodes.Find(dr_Parent("ParentCategoryID").ToString, True)
            Me.TreeView1.SelectedNode = xFinde(0)
            Me.TreeView1.SelectedNode.Nodes.Add(dr_Parent("CategoryID"), dr_Parent("CategoryName"))
        Next
        TreeView1.EndUpdate()

    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                XCLS.MyCodes_Fill_DataTable(Sql_Category, MyVar_Dt_Category)
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
                FillTV()
                Call MYSP_Hide()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        frmAddCategory.Show()

    End Sub
End Class