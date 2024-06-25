Imports System.Data.SqlClient

Public Class frm_DocPriceServices
    Dim sQlCmd As New SqlCommand
    Dim sQlDataAdapter As New SqlDataAdapter

    Private VarDocterID As Integer

    Private Sql As String = "SELECT DocterID ,DocterName,docterPhone FROM tbDoctors Where DocterStatus=1"
    Private sqlDocPriceServices As String = "SELECT DocPriceServicesID,tbDocServicesName,PatientPrice,DoctorsRate FROM vDocPriceServices Where DocPriceServicesStatus=1 AND DocterID=@DocterID"

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

    Private Sub FillListDoc()
        sQlDataAdapter = New SqlDataAdapter(Sql, sQlConnection)
        Dim dt As New DataTable
        sQlDataAdapter.Fill(dt)
        ListBox1.DataSource = dt
        ListBox1.DisplayMember = "DocterName"
        ListBox1.ValueMember = "DocterID"

    End Sub

    Private Sub frm_DocPriceServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MYSP_Show()
        BGW_Load.RunWorkerAsync()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frm_addDocPriceServices.Show()
    End Sub

    Private Sub btnAddDoctor_Click(sender As Object, e As EventArgs) Handles btnAddDoctor.Click
        frm_Doctors.Show()
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
            VarBGW_Status = True
        Catch ex As Exception
            VarBGW_Status = False
            Exit Sub
        End Try
    End Sub

    Private Sub BGW_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_Load.RunWorkerCompleted
        If VarBGW_Status = True Then
            FillListDoc()
            lblUsername.Text = VarUserName
            lblDateTime.Text = VarDateTimeNow
        End If
        Call MYSP_Hide()
    End Sub

    Private Sub BGW_SelectList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW_SelectList.DoWork

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Try
            VarDocterID = ListBox1.SelectedValue
            sQlCmd = New SqlCommand(sqlDocPriceServices, sQlConnection)
            sQlCmd.Parameters.AddWithValue("@DocterID", SqlDbType.Int).Value = VarDocterID
            sQlDataAdapter.SelectCommand = sQlCmd
            Dim dt2 As New DataTable
            dt2.Clear()
            sQlDataAdapter.Fill(dt2)
            DataGridView1.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex)
        Finally
            sQlConnection.Close()
        End Try


    End Sub

    Private Sub BGW_SelectList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW_SelectList.RunWorkerCompleted

    End Sub
End Class