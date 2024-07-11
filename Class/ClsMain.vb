Imports System.Data.SqlClient

Public Class ClsMain
    Public Sub MyCodes_Fill_DataTable(ByVal xSqlStr As String, ByVal xDt As DataTable)
        Dim xDa As SqlDataAdapter
        xDa = New SqlDataAdapter(xSqlStr, sQlConnection)
        xDa.Fill(xDt)
        xDa.Dispose()
    End Sub

    Public Sub MyCodes_Fill_Dgv(ByVal xDgv As DataGridView, ByVal xLbl As ToolStripStatusLabel, ByVal xDt As DataTable, ByVal xDv As DataView)

        xDv = xDt.DefaultView
        xDv.RowFilter = MyPubVar_Filter
        xDgv.DataSource = xDv
        xLbl.Text = CStr(xDv.Count)
    End Sub

    Public Sub MyCodes_CmbFill(ByVal xCbo As ComboBox, ByVal xDt As DataTable, ByVal xDm As String, ByVal xVm As String)
        xCbo.DataSource = xDt
        xCbo.DisplayMember = xDm
        xCbo.ValueMember = xVm
    End Sub
    Public Sub MyCodes_CmbFillByID(ByVal xCbo As ComboBox, ByVal xDt As DataTable, ByVal xDm As String, ByVal xVm As String, ByVal xLevel As String)
        xCbo.DataSource = xDt
        xCbo.DisplayMember = xDm
        xCbo.ValueMember = xVm
        xLevel = xDt.Rows.Item(0).Item("Level")
    End Sub


    Public Sub MyCodes_CboFill_CatgeroyFather(ByVal xCbo As ComboBox, ByVal xDt As DataTable, ByVal xDm As String, ByVal xVm As String)
        xCbo.DataSource = xDt
        xCbo.DisplayMember = xDm
        xCbo.ValueMember = xVm
    End Sub

    Public Sub AddComboBoxItems(cbox As ComboBox, ByVal items As List(Of Integer), ByVal descriptions As List(Of String))
        For i As Integer = 0 To items.Count - 1
            cbox.Items.Add(New KeyValuePair(Of Integer, String)(items(i), descriptions(i)))
        Next
        cbox.ValueMember = "Key"
        cbox.DisplayMember = "Value"
    End Sub
End Class
