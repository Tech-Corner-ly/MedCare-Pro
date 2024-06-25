
Imports System.Data.SqlClient

Public Class frm_BillPatient

    Dim DTBill As New DataTable
    Public VarDocPriceServicesID As Integer
    Public VarEntrySheetStatus As Integer = 1

    Private Sub FillCMBdoctor()
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select DocterID,DocterName FROM tbDoctors ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbDocterID.DataSource = DT
            cmbDocterID.ValueMember = "DocterID"
            cmbDocterID.DisplayMember = "DocterName"
        Else
            cmbDocterID.DataSource = Nothing
        End If
        cmbDocterID.Text = ""
    End Sub
    Private Sub SetDataSRC()
        DTBill.Columns.Add("الكود")
        DTBill.Columns.Add("الخدمة")
        DTBill.Columns.Add("العدد")
        DTBill.Columns.Add("السعر")
        DTBill.Columns.Add("الاجمالي")
        DTBill.Columns.Add("ملاحظة")
        DataGridView1.DataSource = DTBill
    End Sub
    Private Sub CAlcuAmount()
        txtBillDeatilsTotal.Text = Val(txtBillDeatilsQun.Text) * Val(txtBillDeatilsPrice.Text)

    End Sub
    Private Sub ClearCN()
        cmbDocServicesID.Text = ""
        cmbDocterID.Text = ""
        txtCode.Text = ""
        txtBillDeatilsQun.Text = ""
        txtBillDeatilsPrice.Text = ""
        txtBillDeatilsTotal.Text = ""
        txtBillDeatilsNote.Text = ""

    End Sub
    Private Sub FillPatientCMB()
        Dim cmd As New SqlCommand("SELECT PatientID,PatientName FROM vEntrySheet Where EntrySheetStatus=@EntrySheetStatus", sQlConnection)
        cmd.Parameters.AddWithValue("EntrySheetStatus", VarEntrySheetStatus)

        Dim da As New SqlDataAdapter(cmd)
        Dim DT As New DataTable
        da.Fill(DT)
        cmbPatientID.DataSource = DT
        cmbPatientID.ValueMember = "PatientID"
        cmbPatientID.DisplayMember = "PatientName"
        'txtEntrySheetID.Text = DT.Rows(0)(0).ToString
        '    txtDoctorID.Text = DT.Rows(0)(1).ToString
        '    txtSectionsID.Text = DT.Rows(0)(4).ToString



    End Sub

    Private Sub SumTotal()
        Dim sumTotal As Integer = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            sumTotal += DataGridView1.Rows(i).Cells(4).Value.ToString
        Next
        txtBillTotal.Text = sumTotal
    End Sub
    Private Sub frm_BillPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCMBdoctor()
        cmbDocServicesID.Text = ""
        SetDataSRC()
        FillPatientCMB()
    End Sub

    Private Sub cmbDocterID_SelectionChangeCommitted(sender As Object, e As EventArgs)

        Try
            Dim cmd As New SqlCommand("SELECT DocPriceServicesID,tbDocServicesName FROM vDocPriceServics Where DocterID =@DocterID", sQlConnection)
            cmd.Parameters.AddWithValue("DocterID", cmbDocterID.SelectedValue)
            Dim da As New SqlDataAdapter(cmd)
            Dim DT As New DataTable
            da.Fill(DT)
            cmbDocServicesID.DataSource = DT
            cmbDocServicesID.ValueMember = "DocPriceServicesID"
            cmbDocServicesID.DisplayMember = "tbDocServicesName"

            cmbDocServicesID.Text = ""

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cmbDocServicesID_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Dim cmd As New SqlCommand("SELECT DocPriceServicesID,PatientPrice FROM vDocPriceServics Where DocPriceServicesID=@DocPriceServicesID AND DocterID =@DocterID", sQlConnection)
            cmd.Parameters.AddWithValue("DocterID", cmbDocterID.SelectedValue)
            cmd.Parameters.AddWithValue("DocPriceServicesID", cmbDocServicesID.SelectedValue)
            Dim da As New SqlDataAdapter(cmd)
            Dim DT As New DataTable
            da.Fill(DT)
            txtCode.Text = DT.Rows(0)(0).ToString
            txtBillDeatilsPrice.Text = DT.Rows(0)(1).ToString


        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub txtBillDeatilsQun_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Dim row As DataRow = DTBill.NewRow
                row(0) = cmbDocServicesID.SelectedValue
                row(1) = cmbDocServicesID.Text
                row(2) = txtBillDeatilsQun.Text
                row(3) = txtBillDeatilsPrice.Text
                row(4) = txtBillDeatilsTotal.Text
                row(5) = txtBillNote.Text
                DTBill.Rows.Add(row)
                DataGridView1.DataSource = DTBill
                SumTotal()
                ClearCN()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtBillDeatilsQun_TextChanged(sender As Object, e As EventArgs)
        CAlcuAmount()
    End Sub

    Private Sub cmbPatientID_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand("SELECT EntrySheetID,DocterName,SectionsName FROM vEntrySheet Where PatientID=@PatientID", sQlConnection)
        cmd.Parameters.AddWithValue("PatientID", cmbPatientID.SelectedValue)

        Dim da As New SqlDataAdapter(cmd)
        Dim DT As New DataTable
        da.Fill(DT)
        txtEntrySheetID.Text = DT.Rows(0)(0).ToString
        txtDoctorID.Text = DT.Rows(0)(1).ToString
        txtSectionsID.Text = DT.Rows(0)(2).ToString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbPatientID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientID.SelectedIndexChanged

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
End Class