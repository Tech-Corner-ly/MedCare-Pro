Imports System.Data.SqlClient

Public Class frm_main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = VarUserName
        lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frm_EntrySheet.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frm_BillPatient.Show()
    End Sub

    Private Sub msDoctors_Click(sender As Object, e As EventArgs) Handles msDoctors.Click
        frm_Doctors.Show()
    End Sub

    Private Sub msServices_Click(sender As Object, e As EventArgs) Handles msServices.Click
        frm_DocServices.Show()
    End Sub

    Private Sub msDocPriceServices_Click(sender As Object, e As EventArgs) Handles msDocPriceServices.Click
        frm_DocPriceServices.Show()
    End Sub

    Private Sub msSpecialization_Click(sender As Object, e As EventArgs)
        frmSpecialization.Show()
    End Sub

    Private Sub msPatient_Click(sender As Object, e As EventArgs) Handles msPatient.Click
        frm_Patient.Show()
    End Sub

    Private Sub msClinics_Click(sender As Object, e As EventArgs) Handles msClinics.Click
        frm_Clinic.Show()
    End Sub

    Private Sub msReceipt_Click(sender As Object, e As EventArgs) Handles msReceipt.Click

    End Sub

    Private Sub msBillStatment_Click(sender As Object, e As EventArgs) Handles msBillStatment.Click
        frm_BillingStatement.Show()

    End Sub

    Private Sub msAddDocPriceServices_Click(sender As Object, e As EventArgs) Handles msAddDocPriceServices.Click
        frm_addDocPriceServices.Show()
    End Sub

    Private Sub msEmployees_Click(sender As Object, e As EventArgs) Handles msEmployees.Click
        frmEmployees.Show()

    End Sub

    Private Sub msAdministrative_Click(sender As Object, e As EventArgs) Handles msAdministrative.Click
        frmAdministrative.Show()
    End Sub

    Private Sub msSpecialization_Click_1(sender As Object, e As EventArgs) Handles msSpecialization.Click
        frmSpecialization.Show()

    End Sub
End Class
