<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingInquiries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingInquiries))
        Me.BGW_Edit = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Delete = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBookingCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCountAppoin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_Save = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpBookingHours = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbClinc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBookingInquiries = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.csOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.csConfirmAttend = New System.Windows.Forms.ToolStripMenuItem()
        Me.csCancelAttend = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDoctorsAppointmentSchedule = New System.Windows.Forms.DataGridView()
        Me.AppoinScheID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClincI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppoinScheFromTim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppoinScheToTim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowNumCase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReviewAllowedNu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbOPD = New System.Windows.Forms.RadioButton()
        Me.rbShelterCase = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFileNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSurename = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGrandFatherName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.BookingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamID01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingATT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooClincName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooClincID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooEmpoleeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBookingInquiries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDoctorsAppointmentSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BGW_Edit
        '
        Me.BGW_Edit.WorkerReportsProgress = True
        Me.BGW_Edit.WorkerSupportsCancellation = True
        '
        'BGW_Delete
        '
        Me.BGW_Delete.WorkerReportsProgress = True
        Me.BGW_Delete.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.PB, Me.ToolStripStatusLabel2, Me.lblBookingCount, Me.ToolStripStatusLabel4, Me.lblCountAppoin})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 776)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1234, 22)
        Me.StatusStrip1.TabIndex = 32
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel1.Text = "المستخدم :"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 17)
        Me.lblUsername.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(80, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel3.Text = "التاريخ :"
        '
        'lblDateTime
        '
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel2"
        '
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(100, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        Me.PB.Step = 1
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel2.Text = "عدد السجلات"
        '
        'lblBookingCount
        '
        Me.lblBookingCount.Name = "lblBookingCount"
        Me.lblBookingCount.Size = New System.Drawing.Size(37, 17)
        Me.lblBookingCount.Text = "00000"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel4.Text = "عدد الاطباء : "
        '
        'lblCountAppoin
        '
        Me.lblCountAppoin.Name = "lblCountAppoin"
        Me.lblCountAppoin.Size = New System.Drawing.Size(119, 17)
        Me.lblCountAppoin.Text = "ToolStripStatusLabel5"
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'خياراتToolStripMenuItem
        '
        Me.خياراتToolStripMenuItem.Name = "خياراتToolStripMenuItem"
        Me.خياراتToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.خياراتToolStripMenuItem.Text = "خيارات "
        '
        'مساعدةToolStripMenuItem
        '
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 560, 0)
        Me.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem"
        Me.مساعدةToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.مساعدةToolStripMenuItem.Text = "مساعدة"
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        Me.خروجToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.خروجToolStripMenuItem.Text = "خروج"
        '
        'BGW_Save
        '
        Me.BGW_Save.WorkerReportsProgress = True
        Me.BGW_Save.WorkerSupportsCancellation = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpBookingHours)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpBookingDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDoctor)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.cmbDay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbClinc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 119)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الطبيب :"
        '
        'dtpBookingHours
        '
        Me.dtpBookingHours.CustomFormat = "hh:mm:t"
        Me.dtpBookingHours.Enabled = False
        Me.dtpBookingHours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingHours.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBookingHours.Location = New System.Drawing.Point(6, 48)
        Me.dtpBookingHours.Name = "dtpBookingHours"
        Me.dtpBookingHours.RightToLeftLayout = True
        Me.dtpBookingHours.ShowUpDown = True
        Me.dtpBookingHours.Size = New System.Drawing.Size(84, 23)
        Me.dtpBookingHours.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "الساعة :"
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingDate.Location = New System.Drawing.Point(6, 19)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.RightToLeftLayout = True
        Me.dtpBookingDate.Size = New System.Drawing.Size(84, 23)
        Me.dtpBookingDate.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "التاريخ :"
        '
        'cmbDoctor
        '
        Me.cmbDoctor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(145, 51)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(253, 24)
        Me.cmbDoctor.TabIndex = 49
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(404, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 15)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "الطبيب :"
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(145, 81)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(253, 24)
        Me.cmbDay.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(404, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "اليوم :"
        '
        'cmbClinc
        '
        Me.cmbClinc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClinc.FormattingEnabled = True
        Me.cmbClinc.Location = New System.Drawing.Point(145, 22)
        Me.cmbClinc.Name = "cmbClinc"
        Me.cmbClinc.Size = New System.Drawing.Size(253, 24)
        Me.cmbClinc.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "العيادة :"
        '
        'dgvBookingInquiries
        '
        Me.dgvBookingInquiries.AllowUserToAddRows = False
        Me.dgvBookingInquiries.AllowUserToDeleteRows = False
        Me.dgvBookingInquiries.AllowUserToResizeColumns = False
        Me.dgvBookingInquiries.AllowUserToResizeRows = False
        Me.dgvBookingInquiries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookingInquiries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBookingInquiries.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvBookingInquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingInquiries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingID, Me.ExamID01, Me.BookingDate, Me.BookingTime, Me.BookingDay, Me.PatientType, Me.FileNo, Me.PatientName, Me.BookingType, Me.BookingATT, Me.PaymentStatus, Me.BooClincName, Me.BooClincID, Me.BooEmpoleeID})
        Me.dgvBookingInquiries.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvBookingInquiries.Location = New System.Drawing.Point(12, 403)
        Me.dgvBookingInquiries.Name = "dgvBookingInquiries"
        Me.dgvBookingInquiries.ReadOnly = True
        Me.dgvBookingInquiries.RowHeadersVisible = False
        Me.dgvBookingInquiries.Size = New System.Drawing.Size(1210, 370)
        Me.dgvBookingInquiries.TabIndex = 45
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.csOpenFile, Me.csConfirmAttend, Me.csCancelAttend})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 70)
        '
        'csOpenFile
        '
        Me.csOpenFile.Name = "csOpenFile"
        Me.csOpenFile.Size = New System.Drawing.Size(137, 22)
        Me.csOpenFile.Text = "فتح ملف"
        '
        'csConfirmAttend
        '
        Me.csConfirmAttend.Name = "csConfirmAttend"
        Me.csConfirmAttend.Size = New System.Drawing.Size(137, 22)
        Me.csConfirmAttend.Text = "تأكيد الحضور"
        '
        'csCancelAttend
        '
        Me.csCancelAttend.Name = "csCancelAttend"
        Me.csCancelAttend.Size = New System.Drawing.Size(137, 22)
        Me.csCancelAttend.Text = "الغاء الحجز"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.dtpToDate)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dtpFromDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnBooking)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1210, 93)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(351, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 24)
        Me.ComboBox1.TabIndex = 87
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(521, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 15)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "الطبيب :"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(569, 52)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox2.TabIndex = 85
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(749, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 15)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "العيادة :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(749, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "الاسم :"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(127, 53)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.RightToLeftLayout = True
        Me.dtpToDate.Size = New System.Drawing.Size(142, 23)
        Me.dtpToDate.TabIndex = 59
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(351, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(392, 22)
        Me.TextBox2.TabIndex = 82
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(275, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "الي تاريخ :"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(127, 24)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.RightToLeftLayout = True
        Me.dtpFromDate.Size = New System.Drawing.Size(142, 23)
        Me.dtpFromDate.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(275, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "من تاريخ :"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(6, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 72)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1030, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 72)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(1120, 15)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(84, 72)
        Me.btnBooking.TabIndex = 2
        Me.btnBooking.Text = "حجز"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDoctorsAppointmentSchedule)
        Me.GroupBox3.Location = New System.Drawing.Point(473, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(749, 270)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مواعيد الاطباء :"
        '
        'dgvDoctorsAppointmentSchedule
        '
        Me.dgvDoctorsAppointmentSchedule.AllowUserToAddRows = False
        Me.dgvDoctorsAppointmentSchedule.AllowUserToDeleteRows = False
        Me.dgvDoctorsAppointmentSchedule.AllowUserToResizeColumns = False
        Me.dgvDoctorsAppointmentSchedule.AllowUserToResizeRows = False
        Me.dgvDoctorsAppointmentSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvDoctorsAppointmentSchedule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvDoctorsAppointmentSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctorsAppointmentSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppoinScheID, Me.ClincI, Me.DoctorI, Me.Day, Me.ClinicName, Me.FullName, Me.AppoinScheFromTim, Me.AppoinScheToTim, Me.AllowNumCase, Me.ReviewAllowedNu})
        Me.dgvDoctorsAppointmentSchedule.Location = New System.Drawing.Point(6, 19)
        Me.dgvDoctorsAppointmentSchedule.Name = "dgvDoctorsAppointmentSchedule"
        Me.dgvDoctorsAppointmentSchedule.ReadOnly = True
        Me.dgvDoctorsAppointmentSchedule.RowHeadersVisible = False
        Me.dgvDoctorsAppointmentSchedule.Size = New System.Drawing.Size(737, 245)
        Me.dgvDoctorsAppointmentSchedule.TabIndex = 34
        '
        'AppoinScheID
        '
        Me.AppoinScheID.DataPropertyName = "AppoinScheID"
        Me.AppoinScheID.HeaderText = "المعرف"
        Me.AppoinScheID.Name = "AppoinScheID"
        Me.AppoinScheID.ReadOnly = True
        Me.AppoinScheID.Visible = False
        '
        'ClincI
        '
        Me.ClincI.DataPropertyName = "ClincID"
        Me.ClincI.HeaderText = "ClincID"
        Me.ClincI.Name = "ClincI"
        Me.ClincI.ReadOnly = True
        Me.ClincI.Visible = False
        '
        'DoctorI
        '
        Me.DoctorI.DataPropertyName = "DoctorID"
        Me.DoctorI.HeaderText = "DoctorID"
        Me.DoctorI.Name = "DoctorI"
        Me.DoctorI.ReadOnly = True
        Me.DoctorI.Visible = False
        '
        'Day
        '
        Me.Day.DataPropertyName = "Day"
        Me.Day.HeaderText = "اليوم"
        Me.Day.Name = "Day"
        Me.Day.ReadOnly = True
        '
        'ClinicName
        '
        Me.ClinicName.DataPropertyName = "ClinicName"
        Me.ClinicName.HeaderText = "العيادة"
        Me.ClinicName.Name = "ClinicName"
        Me.ClinicName.ReadOnly = True
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "FullName"
        Me.FullName.HeaderText = "الطبيب"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        '
        'AppoinScheFromTim
        '
        Me.AppoinScheFromTim.DataPropertyName = "AppoinScheFromTime"
        Me.AppoinScheFromTim.HeaderText = "من الساعة"
        Me.AppoinScheFromTim.Name = "AppoinScheFromTim"
        Me.AppoinScheFromTim.ReadOnly = True
        '
        'AppoinScheToTim
        '
        Me.AppoinScheToTim.DataPropertyName = "AppoinScheToTime"
        Me.AppoinScheToTim.HeaderText = "الي الساعة"
        Me.AppoinScheToTim.Name = "AppoinScheToTim"
        Me.AppoinScheToTim.ReadOnly = True
        '
        'AllowNumCase
        '
        Me.AllowNumCase.DataPropertyName = "AllowNumCases"
        Me.AllowNumCase.HeaderText = "عدد الحالات"
        Me.AllowNumCase.Name = "AllowNumCase"
        Me.AllowNumCase.ReadOnly = True
        '
        'ReviewAllowedNu
        '
        Me.ReviewAllowedNu.DataPropertyName = "ReviewAllowedNum"
        Me.ReviewAllowedNu.HeaderText = "سماحية المراجعة"
        Me.ReviewAllowedNu.Name = "ReviewAllowedNu"
        Me.ReviewAllowedNu.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbOPD)
        Me.GroupBox4.Controls.Add(Me.rbShelterCase)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtFileNo)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtSurename)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtGrandFatherName)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtFatherName)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtFirstName)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(455, 145)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "بيانات المريض :"
        '
        'rbOPD
        '
        Me.rbOPD.AutoSize = True
        Me.rbOPD.Checked = True
        Me.rbOPD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbOPD.Location = New System.Drawing.Point(317, 21)
        Me.rbOPD.Name = "rbOPD"
        Me.rbOPD.Size = New System.Drawing.Size(79, 19)
        Me.rbOPD.TabIndex = 81
        Me.rbOPD.TabStop = True
        Me.rbOPD.Text = "الحالة OPD"
        Me.rbOPD.UseVisualStyleBackColor = True
        '
        'rbShelterCase
        '
        Me.rbShelterCase.AutoSize = True
        Me.rbShelterCase.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbShelterCase.Location = New System.Drawing.Point(230, 21)
        Me.rbShelterCase.Name = "rbShelterCase"
        Me.rbShelterCase.Size = New System.Drawing.Size(72, 19)
        Me.rbShelterCase.TabIndex = 80
        Me.rbShelterCase.Text = "ايواء تحت "
        Me.rbShelterCase.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(163, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "رقم الملف :"
        '
        'txtFileNo
        '
        Me.txtFileNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFileNo.Location = New System.Drawing.Point(12, 19)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(150, 22)
        Me.txtFileNo.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(163, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "رقم الهاتف :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(12, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 22)
        Me.TextBox1.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(383, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "رقم الهاتف :"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPhone.Location = New System.Drawing.Point(230, 106)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 22)
        Me.txtPhone.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(163, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "اللقب :"
        '
        'txtSurename
        '
        Me.txtSurename.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSurename.Location = New System.Drawing.Point(12, 77)
        Me.txtSurename.Name = "txtSurename"
        Me.txtSurename.Size = New System.Drawing.Size(150, 22)
        Me.txtSurename.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(386, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "اسم الجد :"
        '
        'txtGrandFatherName
        '
        Me.txtGrandFatherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGrandFatherName.Location = New System.Drawing.Point(230, 77)
        Me.txtGrandFatherName.Name = "txtGrandFatherName"
        Me.txtGrandFatherName.Size = New System.Drawing.Size(150, 22)
        Me.txtGrandFatherName.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "اسم الاب :"
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFatherName.Location = New System.Drawing.Point(12, 48)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(150, 22)
        Me.txtFatherName.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "الاسم :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFirstName.Location = New System.Drawing.Point(230, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 22)
        Me.txtFirstName.TabIndex = 66
        '
        'BookingID
        '
        Me.BookingID.DataPropertyName = "BookingID"
        Me.BookingID.FillWeight = 80.0!
        Me.BookingID.HeaderText = "رفم الحجز"
        Me.BookingID.Name = "BookingID"
        Me.BookingID.ReadOnly = True
        '
        'ExamID01
        '
        Me.ExamID01.DataPropertyName = "ExamID01"
        Me.ExamID01.HeaderText = "ExamID01"
        Me.ExamID01.Name = "ExamID01"
        Me.ExamID01.ReadOnly = True
        Me.ExamID01.Visible = False
        '
        'BookingDate
        '
        Me.BookingDate.DataPropertyName = "BookingDate"
        DataGridViewCellStyle1.Format = "yyyy/MM/dd"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.BookingDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.BookingDate.HeaderText = "التاريخ"
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.ReadOnly = True
        '
        'BookingTime
        '
        Me.BookingTime.DataPropertyName = "BookingTime"
        DataGridViewCellStyle2.Format = "hh:mm:ss tt"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BookingTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.BookingTime.FillWeight = 60.0!
        Me.BookingTime.HeaderText = "الساعة"
        Me.BookingTime.Name = "BookingTime"
        Me.BookingTime.ReadOnly = True
        '
        'BookingDay
        '
        Me.BookingDay.DataPropertyName = "BookingDay"
        Me.BookingDay.FillWeight = 60.0!
        Me.BookingDay.HeaderText = "اليوم"
        Me.BookingDay.Name = "BookingDay"
        Me.BookingDay.ReadOnly = True
        '
        'PatientType
        '
        Me.PatientType.DataPropertyName = "PatientType"
        Me.PatientType.HeaderText = "نوع الحالة "
        Me.PatientType.Name = "PatientType"
        Me.PatientType.ReadOnly = True
        '
        'FileNo
        '
        Me.FileNo.DataPropertyName = "FileNo"
        Me.FileNo.FillWeight = 80.0!
        Me.FileNo.HeaderText = "رقم الملف"
        Me.FileNo.Name = "FileNo"
        Me.FileNo.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        Me.PatientName.FillWeight = 250.0!
        Me.PatientName.HeaderText = "اسم الحالة"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'BookingType
        '
        Me.BookingType.DataPropertyName = "BookingType"
        Me.BookingType.FillWeight = 80.0!
        Me.BookingType.HeaderText = "نوع الحجز"
        Me.BookingType.Name = "BookingType"
        Me.BookingType.ReadOnly = True
        '
        'BookingATT
        '
        Me.BookingATT.DataPropertyName = "BookingATT"
        Me.BookingATT.FillWeight = 70.0!
        Me.BookingATT.HeaderText = "الحضور"
        Me.BookingATT.Name = "BookingATT"
        Me.BookingATT.ReadOnly = True
        '
        'PaymentStatus
        '
        Me.PaymentStatus.DataPropertyName = "PaymentStatus"
        Me.PaymentStatus.FillWeight = 50.0!
        Me.PaymentStatus.HeaderText = "السداد"
        Me.PaymentStatus.Name = "PaymentStatus"
        Me.PaymentStatus.ReadOnly = True
        '
        'BooClincName
        '
        Me.BooClincName.DataPropertyName = "BooClincName"
        Me.BooClincName.HeaderText = "العيادة"
        Me.BooClincName.Name = "BooClincName"
        Me.BooClincName.ReadOnly = True
        '
        'BooClincID
        '
        Me.BooClincID.DataPropertyName = "BooClincID"
        Me.BooClincID.HeaderText = "BooClincID"
        Me.BooClincID.Name = "BooClincID"
        Me.BooClincID.ReadOnly = True
        Me.BooClincID.Visible = False
        '
        'BooEmpoleeID
        '
        Me.BooEmpoleeID.DataPropertyName = "BooEmpoleeID"
        Me.BooEmpoleeID.HeaderText = "BooEmpoleeID"
        Me.BooEmpoleeID.Name = "BooEmpoleeID"
        Me.BooEmpoleeID.ReadOnly = True
        Me.BooEmpoleeID.Visible = False
        '
        'frmBookingInquiries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 798)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvBookingInquiries)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBookingInquiries"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الحجز والاستعلام"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBookingInquiries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDoctorsAppointmentSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BGW_Edit As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Delete As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BGW_Save As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbClinc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBookingInquiries As DataGridView
    Friend WithEvents dtpBookingHours As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblBookingCount As ToolStripStatusLabel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents csOpenFile As ToolStripMenuItem
    Friend WithEvents csConfirmAttend As ToolStripMenuItem
    Friend WithEvents csCancelAttend As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvDoctorsAppointmentSchedule As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSurename As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGrandFatherName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lblCountAppoin As ToolStripStatusLabel
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents AppoinScheID As DataGridViewTextBoxColumn
    Friend WithEvents ClincI As DataGridViewTextBoxColumn
    Friend WithEvents DoctorI As DataGridViewTextBoxColumn
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents ClinicName As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents AppoinScheFromTim As DataGridViewTextBoxColumn
    Friend WithEvents AppoinScheToTim As DataGridViewTextBoxColumn
    Friend WithEvents AllowNumCase As DataGridViewTextBoxColumn
    Friend WithEvents ReviewAllowedNu As DataGridViewTextBoxColumn
    Friend WithEvents rbOPD As RadioButton
    Friend WithEvents rbShelterCase As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFileNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BookingID As DataGridViewTextBoxColumn
    Friend WithEvents ExamID01 As DataGridViewTextBoxColumn
    Friend WithEvents BookingDate As DataGridViewTextBoxColumn
    Friend WithEvents BookingTime As DataGridViewTextBoxColumn
    Friend WithEvents BookingDay As DataGridViewTextBoxColumn
    Friend WithEvents PatientType As DataGridViewTextBoxColumn
    Friend WithEvents FileNo As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents BookingType As DataGridViewTextBoxColumn
    Friend WithEvents BookingATT As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents BooClincName As DataGridViewTextBoxColumn
    Friend WithEvents BooClincID As DataGridViewTextBoxColumn
    Friend WithEvents BooEmpoleeID As DataGridViewTextBoxColumn
End Class
