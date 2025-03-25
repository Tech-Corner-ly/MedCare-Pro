Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Public Class frm_main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = VarUserName
        lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Me.Text = "MedCare Pro"
        lblCompany.Text = VarCompanyName

        Thread.CurrentThread.CurrentCulture = New CultureInfo("ar-LY")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar-LY")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frm_EntrySheet.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frm_BillPatient.Show()
    End Sub

    Private Sub msDoctors_Click(sender As Object, e As EventArgs)
        frm_Doctors.Show()
    End Sub

    Private Sub msServices_Click(sender As Object, e As EventArgs)
        frm_DocServices.Show()
    End Sub

    Private Sub msDocPriceServices_Click(sender As Object, e As EventArgs)
        frm_DocPriceServices.Show()
    End Sub

    Private Sub msSpecialization_Click(sender As Object, e As EventArgs)
        frmSpecialization.Show()
    End Sub

    Private Sub msPatient_Click(sender As Object, e As EventArgs) Handles msPatient.Click
        frm_Patient.Show()
    End Sub

    Private Sub msClinics_Click(sender As Object, e As EventArgs)
        frm_Clinic.Show()
    End Sub

    Private Sub msReceipt_Click(sender As Object, e As EventArgs)

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

    Private Sub msJobTitle_Click(sender As Object, e As EventArgs) Handles msJobTitle.Click
        frmJobTitle.Show()

    End Sub

    Private Sub التصنيفاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles التصنيفاتToolStripMenuItem.Click
        frmAddItemsServices.Show()
    End Sub

    Private Sub الفئاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الفئاتToolStripMenuItem.Click
        frmCategory.Show()
    End Sub

    Private Sub الشركاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الشركاتToolStripMenuItem.Click
        frmBrandCompany.Show()
    End Sub

    Private Sub مجموعاتالموادالخدماتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مجموعاتالموادالخدماتToolStripMenuItem.Click
        frmGroupsItems.Show()

    End Sub

    Private Sub المستودعاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المستودعاتToolStripMenuItem.Click
        frmWarehouses.Show()
    End Sub

    Private Sub بحثالموادToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بحثالموادToolStripMenuItem.Click
        frmItemsServices.Show()
    End Sub

    Private Sub مواعيدالاطباءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مواعيدالاطباءToolStripMenuItem.Click
        frmDoctorsAppointmentSchedule.Show()
    End Sub

    Private Sub حجزموعدالعياداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حجزموعدالعياداتToolStripMenuItem.Click
        frmBookingInquiries.Show()
    End Sub

    Private Sub العياداتToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles العياداتToolStripMenuItem1.Click
        Dim xForm As New frm_Clinic
        xForm.ShowDialog()
    End Sub

    Private Sub تسعيرالخدماتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسعيرالخدماتToolStripMenuItem.Click
        Dim xForm As New frm_DocPriceServices
        xForm.ShowDialog()

    End Sub
End Class
