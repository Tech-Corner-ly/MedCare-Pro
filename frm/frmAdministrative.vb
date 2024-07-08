Public Class frmAdministrative
    'Var
    Private XCLS As New ClsMain
    'Private MyVar_Dt_AllAccounts As DataTable = New DataTable
    'Private MyVarDT_Countries As DataTable = New DataTable
    Private MyVarDT_Specialization As DataTable = New DataTable
    Private MyVarDV_Specialization As DataView = New DataView
    'Private VarAdministrativeTypeDT As DataTable = New DataTable


    Private VarSelAdjective As String
    Private VarSpecializationName As String
    Public VarDocSpecializationID As Integer
    Public VarSpecializationStatus As Integer = 1
    Private VarCount As String
    Private dt As New DataTable

    Private sQLDeleteSpeci As String = "Update tbSpecialization Set SpecializationStatus=@SpecializationStatus,DeleteTime=@DeleteTime,UserID_Delete=@UserID_Delete Where SpecializationID=@SpecializationID"
    Private sQLUpdateSpeci As String = "Update tbSpecialization Set SpecializationName=@SpecializationName,Adjective=@Adjective,UpdateTime=@UpdateTime,UserID_Update=@UserID_Update Where SpecializationID=@SpecializationID"
    Private sQLInsertSpeci As String = "Insert Into tbSpecialization (SpecializationName,Adjective,SpecializationStatus,InsertTime,UserID_Insert)values(@SpecializationName,@Adjective,@SpecializationStatus,@InsertTime,@UserID_Insert)"
    Private sQLAdministrative As String = "SELECT [AdministrativeID]
                                                  ,[AdministrativeName]
                                                  ,[AdministrativeParentCode]
                                                  ,[AdministrativeParent]
                                              FROM [tbAdministrative]
                                              Where [AdministrativeStatus]=1
                                              AND [AdministrativeType]='فرعي'"

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
                MyVarDT_Specialization.Clear()
                Call XCLS.MyCodes_Fill_DataTable(sQLAdministrative, MyVarDT_Specialization)
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
            Call XCLS.MyCodes_Fill_Dgv(Me.DGV, lblCount, MyVarDT_Specialization, MyVarDV_Specialization)
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub frmAdministrative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub
End Class