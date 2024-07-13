Imports System.Data.SqlClient

Public Class frmAdministrative
    'Var
    Private XCLS As New ClsMain
    Private MyVarDT_Administrative As DataTable = New DataTable


    Public VarDocSpecializationID As Integer
    Public VarSpecializationStatus As Integer = 1

    Private sQLAdministrative As String = "SELECT [AdministrativeID]
                                                  ,[AdministrativeName]
                                                  ,[AdministrativeLatin]
                                                  ,[AdministrativeParentID]
                                                  ,[Level]
                                              FROM [clinic].[dbo].[tbAdministrative]
                                              Where [AdministrativeStatus]=1"
    Private Sub FillTV()
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()

        Dim xDV As DataView = MyVarDT_Administrative.DefaultView
        xDV.RowFilter = "Level=0"
        xDV.Sort = "AdministrativeID"
        For Each dr As DataRow In xDV.ToTable.Rows
            Me.TreeView1.Nodes.Add(dr("AdministrativeID"), dr("AdministrativeName"))
        Next

        xDV.RowFilter = "Level <> 0"
        xDV.Sort = "AdministrativeID,AdministrativeParentID"
        For Each dr_Parent As DataRow In xDV.ToTable.Rows
            Dim xFinde() As TreeNode
            xFinde = TreeView1.Nodes.Find(dr_Parent("AdministrativeParentID").ToString, True)
            Me.TreeView1.SelectedNode = xFinde(0)
            Me.TreeView1.SelectedNode.Nodes.Add(dr_Parent("AdministrativeID"), dr_Parent("AdministrativeName"))
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
    Private Sub btnAddAdministrative_Click(sender As Object, e As EventArgs) Handles btnAddAdministrative.Click
        frmAddAdministrative.Show()
    End Sub

    Private Sub BGW_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_Load.DoWork
        Try
            If CheckConn() = False Then
                VarBGW_Status = False
            Else
                MyVarDT_Administrative.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLAdministrative, MyVarDT_Administrative)
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
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
            FillTV()
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub frmAdministrative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Dim xDgvCount As Integer = Convert.ToInt64(Me.DGV.Rows.Count)
        'Dim xAdministrativeType As String
        'Dim xFathCode, xParentCode As Integer
        'Dim xFathName, xParentName, xParenLatin As String

        'If xDgvCount = 0 Then Exit Sub

        'Dim xForm As frmAddAdministrative
        'MyPubVar_adminID = Convert.ToInt64(Me.DGV.CurrentRow.Cells("AdministrativeID").Value.ToString)

        'Dim Cmd As New SqlCommand(sQL_Update, sQlConnection)
        'With Cmd
        '    .Parameters.Clear()
        '    .Parameters.AddWithValue("@AdministrativeID", SqlDbType.Int).Value = MyPubVar_adminID
        'End With
        'If sQlConnection.State = 1 Then sQlConnection.Close()
        'sQlConnection.Open()
        'MyVarDT_Administrative.Load(Cmd.ExecuteReader())
        'sQlConnection.Close()
        'If MyVarDT_Administrative.Rows.Count <> 0 Then
        '    With MyVarDT_Administrative.Rows.Item(0)
        '        xAdministrativeType = .Item("AdministrativeType").ToString
        '        xFathCode = Convert.ToInt64(.Item("AdministrativeRefre"))
        '        xFathName = CStr(.Item("AdministrativeRefreName"))
        '        xParentCode = Convert.ToInt64(.Item("AdministrativeParentCode"))
        '        xParentName = CStr(.Item("AdministrativeParent"))
        '        xParenLatin = CStr(.Item("AdministrativeParentLatin"))
        '    End With
        '    With xForm
        '        .txtAdministrativeID.Text = xFathCode
        '        .cmbAdministrativeParent.Text = xFathName
        '        .txtAdministrativeID.Text = xParentCode
        '        .txtAdministrativeName.Text = xParentName
        '        .txtAdministrativeLatin.Text = xParenLatin
        '        .btnNew.Visible = False
        '        .btnSave.Visible = False
        '        .ShowDialog()
        '    End With
        'End If
        'Call MYSP_Show()
        'BGW_Load.RunWorkerAsync()
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