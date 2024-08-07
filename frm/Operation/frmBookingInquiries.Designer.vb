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
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.csOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.csConfirmAttend = New System.Windows.Forms.ToolStripMenuItem()
        Me.csCancelAttend = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDoctorsAppointmentSchedule = New System.Windows.Forms.DataGridView()
        Me.hhj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFileNo = New System.Windows.Forms.TextBox()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.PB, Me.ToolStripStatusLabel2, Me.lblBookingCount})
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
        Me.dtpBookingHours.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingHours.Format = System.Windows.Forms.DateTimePickerFormat.Custom
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
        Me.dgvBookingInquiries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.Column6, Me.DataGridViewTextBoxColumn2, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvBookingInquiries.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvBookingInquiries.Location = New System.Drawing.Point(12, 373)
        Me.dgvBookingInquiries.Name = "dgvBookingInquiries"
        Me.dgvBookingInquiries.ReadOnly = True
        Me.dgvBookingInquiries.Size = New System.Drawing.Size(1210, 400)
        Me.dgvBookingInquiries.TabIndex = 45
        '
        'Column5
        '
        Me.Column5.FillWeight = 80.0!
        Me.Column5.HeaderText = "رفم الحجز"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "الساعة"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "اليوم"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 80.0!
        Me.Column6.HeaderText = "رقم الملف"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم الحالة"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 80.0!
        Me.Column7.HeaderText = "نوع الحجز"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 70.0!
        Me.Column8.HeaderText = "الحضور"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.FillWeight = 50.0!
        Me.Column9.HeaderText = "السداد"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
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
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnBooking)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1210, 63)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(6, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(63, 38)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1072, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(63, 38)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(1141, 15)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(63, 38)
        Me.btnBooking.TabIndex = 2
        Me.btnBooking.Text = "حجز"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpToDate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dtpFromDate)
        Me.GroupBox3.Controls.Add(Me.Label11)
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
        Me.dgvDoctorsAppointmentSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hhj, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvDoctorsAppointmentSchedule.Location = New System.Drawing.Point(6, 48)
        Me.dgvDoctorsAppointmentSchedule.Name = "dgvDoctorsAppointmentSchedule"
        Me.dgvDoctorsAppointmentSchedule.ReadOnly = True
        Me.dgvDoctorsAppointmentSchedule.Size = New System.Drawing.Size(737, 216)
        Me.dgvDoctorsAppointmentSchedule.TabIndex = 34
        '
        'hhj
        '
        Me.hhj.HeaderText = "اليوم"
        Me.hhj.Name = "hhj"
        Me.hhj.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "عدد الحالات"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الطبيب"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "من الساعة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "الي الساعة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(408, 20)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.RightToLeftLayout = True
        Me.dtpFromDate.Size = New System.Drawing.Size(126, 23)
        Me.dtpFromDate.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(539, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "من تاريخ :"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(194, 19)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.RightToLeftLayout = True
        Me.dtpToDate.Size = New System.Drawing.Size(142, 23)
        Me.dtpToDate.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(341, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "الي تاريخ :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtFileNo)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(162, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "رقم الملف :"
        '
        'txtFileNo
        '
        Me.txtFileNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFileNo.Location = New System.Drawing.Point(7, 89)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(149, 22)
        Me.txtFileNo.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "رقم الهاتف :"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPhone.Location = New System.Drawing.Point(231, 89)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 22)
        Me.txtPhone.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "اللقب :"
        '
        'txtSurename
        '
        Me.txtSurename.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSurename.Location = New System.Drawing.Point(7, 61)
        Me.txtSurename.Name = "txtSurename"
        Me.txtSurename.Size = New System.Drawing.Size(149, 22)
        Me.txtSurename.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(387, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "اسم الجد :"
        '
        'txtGrandFatherName
        '
        Me.txtGrandFatherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGrandFatherName.Location = New System.Drawing.Point(231, 61)
        Me.txtGrandFatherName.Name = "txtGrandFatherName"
        Me.txtGrandFatherName.Size = New System.Drawing.Size(150, 22)
        Me.txtGrandFatherName.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "اسم الاب :"
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFatherName.Location = New System.Drawing.Point(7, 33)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(149, 22)
        Me.txtFatherName.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "الاسم :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFirstName.Location = New System.Drawing.Point(231, 33)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 22)
        Me.txtFirstName.TabIndex = 66
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents csOpenFile As ToolStripMenuItem
    Friend WithEvents csConfirmAttend As ToolStripMenuItem
    Friend WithEvents csCancelAttend As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDoctorsAppointmentSchedule As DataGridView
    Friend WithEvents hhj As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFileNo As TextBox
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
End Class
