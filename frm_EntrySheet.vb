Imports System.Data.SqlClient

Public Class frm_EntrySheet
    Dim dt As New DataTable
    Public VarEntrySheetID As Integer
    Private sQLSelEntrySheet As String = "SELECT EntrySheetID,EntrySheetDate,tbDoctors.DocterName,tbPatient.PatientName,tbSections.SectionsName FROM tbEntrySheet INNER JOIN tbDoctors ON tbEntrySheet.DoctorID  = tbDoctors.DocterID INNER JOIN tbPatient ON tbEntrySheet.PatientID = tbPatient.PatientID INNER JOIN tbSections ON tbEntrySheet.SectionsID = tbSections.SectionsID"


    Private Sub FillCMBdoctor()
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select DocterID,DocterName FROM tbDoctors ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbDoctorID.DataSource = DT
            cmbDoctorID.ValueMember = "DocterID"
            cmbDoctorID.DisplayMember = "DocterName"
        Else
            cmbDoctorID.DataSource = Nothing
        End If

    End Sub
    Private Sub FillCMMBpatient()
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select PatientID,PatientName FROM tbPatient ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbPatientID.DataSource = DT
            cmbPatientID.ValueMember = "PatientID"
            cmbPatientID.DisplayMember = "PatientName"
        Else
            cmbPatientID.DataSource = Nothing
        End If
    End Sub
    Private Sub FillCMBsections()
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select SectionsID,SectionsName FROM tbSections ", sQlConnection)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbSectionsID.DataSource = DT
            cmbSectionsID.ValueMember = "SectionsID"
            cmbSectionsID.DisplayMember = "SectionsName"
        Else
            cmbSectionsID.DataSource = Nothing
        End If

    End Sub
    Private Sub fillDGV()
        Dim sQlDataAdapter As New SqlDataAdapter(sQLSelEntrySheet, sQlConnection)

        sQlDataAdapter.Fill(dt)
        DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).HeaderText = "رقم الملف"
        Me.DataGridView1.Columns(1).HeaderText = "تاريخ الدخول"
        Me.DataGridView1.Columns(2).HeaderText = "اسم الدكتور/ة"
        Me.DataGridView1.Columns(3).HeaderText = "اسم المريض/ة"
        Me.DataGridView1.Columns(4).HeaderText = "القسم"

    End Sub
    Private Sub ClearCN()
        dtpEntrySheetDate.Text = ""
        cmbDoctorID.Text = ""
        cmbPatientID.Text = ""
        cmbSectionsID.Text = ""
    End Sub

    Private Sub frm_EntrySheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDGV()
        FillCMBsections()
        FillCMMBpatient()
        FillCMBdoctor()
        ClearCN()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) 
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "Insert Into tbEntrySheet (EntrySheetDate,DoctorID,PatientID,SectionsID)values(@EntrySheetDate,@DoctorID,@PatientID,@SectionsID)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@EntrySheetDate", SqlDbType.DateTime).Value = dtpEntrySheetDate.Value
                .Parameters.AddWithValue("@DoctorID", SqlDbType.Int).Value = cmbDoctorID.SelectedValue
                .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = cmbPatientID.SelectedValue
                .Parameters.AddWithValue("@SectionsID", SqlDbType.Int).Value = cmbSectionsID.SelectedValue
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing

            fillDGV()
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) 
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = sQlConnection
                .CommandType = CommandType.Text
                .CommandText = "Update tbEntrySheet Set EntrySheetDate = @EntrySheetDate,DoctorID = @DoctorID,PatientID = @PatientID,SectionsID = @SectionsID Where EntrySheetID = @EntrySheetID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@EntrySheetDate", SqlDbType.Date).Value = dtpEntrySheetDate.Value
                .Parameters.AddWithValue("@DoctorID", SqlDbType.Int).Value = cmbDoctorID.SelectedValue
                .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = cmbPatientID.SelectedValue
                .Parameters.AddWithValue("@SectionsID", SqlDbType.Int).Value = cmbSectionsID.SelectedValue
                .Parameters.AddWithValue("@EntrySheetID", SqlDbType.Int).Value = VarEntrySheetID
            End With
            If sQlConnection.State = 1 Then sQlConnection.Close()
            sQlConnection.Open()
            Cmd.ExecuteNonQuery()
            sQlConnection.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        VarEntrySheetID = Me.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
        dtpEntrySheetDate.Value = Me.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        cmbDoctorID.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value.ToString
        cmbPatientID.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value.ToString
        cmbSectionsID.Text = Me.DataGridView1.CurrentRow.Cells.Item(4).Value.ToString
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " PatientName LIKE '%" & txtSearch.Text & "%' "
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class