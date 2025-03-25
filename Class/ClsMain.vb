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
    Public Sub MyCode_Fill_DS(ByVal xTxt As TextBox, ByVal xDT As DataTable, ByVal xColum As String, ByVal xDS As AutoCompleteStringCollection)

        For i As Integer = 0 To xDT.Rows.Count - 1
            xDS.Add(xDT.Rows(i)(xColum))
        Next
        xTxt.AutoCompleteCustomSource = xDS
        xTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        xTxt.AutoCompleteSource = AutoCompleteSource.CustomSource

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

    Public Function MyCodes_TextNotNull(ByVal xTxt As TextBox, ByVal xTitle As String) As Boolean
        If xTxt.Text = String.Empty Or xTxt.Text = "" Then
            MsgBox("حقل '" & xTitle & "' " & "مطلوب", Me_MsgInfoStyle, Me_MsgCaptionStr)
            xTxt.Text = String.Empty
            xTxt.Focus()
            Return True
        Else
            xTxt.Text = Trim(xTxt.Text)
            Return False
        End If
    End Function

    Public Function MyCodes_CboNotNull_Index(ByVal Cbo As ComboBox, ByVal CboCaption As String) As Boolean
        If Cbo.SelectedIndex = -1 Or Cbo.Text = String.Empty Then
            MsgBox("يرجى اختيار " & Space(1) & " " & CboCaption & " " & Space(1) & "من القائمة", Me_MsgInfoStyle, Me_MsgCaptionStr)
            Cbo.Focus()
            Return True
        Else
            Return False
        End If

    End Function
    Public Function MyCodes_TextNotNullAndNum(ByVal TXT As TextBox, ByVal Caption As String) As Boolean
        If TXT.Text = String.Empty Or TXT.Text = "" Then
            MsgBox("حقل '" & Caption & "' " & "مطلوب", Me_MsgInfoStyle, Me_MsgCaptionStr)
            TXT.Text = String.Empty
            TXT.Focus()
            Return True
        ElseIf Not IsNumeric(TXT.Text) Then
            MsgBox("حقل'" & Caption & "' " & "يجب أن يكون أرقام فقط", Me_MsgInfoStyle, Me_MsgCaptionStr)
            TXT.Text = CType(0, String)
            TXT.Focus()
            Return True
        Else
            TXT.Text = Trim(TXT.Text)
            Return False
        End If
    End Function
    Public Function MyCodes_OnlyNumeric(ByVal TXT As TextBox, ByVal Caption As String) As Boolean

        If Not IsNumeric(TXT.Text) Then
            MsgBox("حقل'" & Caption & "' " & "يجب أن يكون أرقام فقط", Me_MsgInfoStyle, Me_MsgCaptionStr)
            TXT.Text = CType(0, String)
            TXT.Focus()
            Return True
        Else
            TXT.Text = Trim(TXT.Text)
            Return False
        End If
    End Function

    Public Function MyCode_Decmeil(ByVal xtxt As TextBox)
        Dim number As Decimal
        If Decimal.TryParse(xtxt.Text, number) Then
            xtxt.Text = Format(number, "0.00")
        Else
            'You can put your own logic here
            xtxt.Text = "0.00"
        End If

    End Function



    Public Function GetItemExaminID(employeID As Integer) As Integer?
        Dim itemExaminID As Integer? = Nothing
        Dim sQLExam As String = "SELECT [ItemExaminID1] FROM [clinic].[dbo].[tbEmploye] WHERE [EmployeStatus] = 1 AND [EmployeID] = @EmployeID"


        Using command As New SqlCommand(sQLExam, sQlConnection)
            command.Parameters.AddWithValue("@EmployeID", employeID)

            Try
                sQlConnection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    itemExaminID = Convert.ToInt64(result)
                End If
            Catch ex As Exception
                ' Handle exceptions (e.g., log the error)
            End Try
        End Using


        Return itemExaminID
    End Function
End Class
