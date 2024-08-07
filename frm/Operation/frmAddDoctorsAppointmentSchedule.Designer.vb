<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddDoctorsAppointmentSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDoctorsAppointmentSchedule))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_Save = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Edit = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Delete = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.txtReviewAllowed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumberCases = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpToTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.lblAdministrative = New System.Windows.Forms.Label()
        Me.cmbClinc = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 70)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(162, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 37)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(231, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 37)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(300, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 37)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(6, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(63, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(391, 24)
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
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 180, 0)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 287)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
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
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(50, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        Me.PB.Step = 1
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDay)
        Me.GroupBox1.Controls.Add(Me.txtReviewAllowed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNumberCases)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpToTime)
        Me.GroupBox1.Controls.Add(Me.dtpFromTime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDoctor)
        Me.GroupBox1.Controls.Add(Me.lblAdministrative)
        Me.GroupBox1.Controls.Add(Me.cmbClinc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 177)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(6, 85)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(276, 23)
        Me.cmbDay.TabIndex = 30
        '
        'txtReviewAllowed
        '
        Me.txtReviewAllowed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtReviewAllowed.Location = New System.Drawing.Point(6, 140)
        Me.txtReviewAllowed.Name = "txtReviewAllowed"
        Me.txtReviewAllowed.Size = New System.Drawing.Size(85, 22)
        Me.txtReviewAllowed.TabIndex = 29
        Me.txtReviewAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "مسموح بالمراجعة :"
        '
        'txtNumberCases
        '
        Me.txtNumberCases.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNumberCases.Location = New System.Drawing.Point(197, 140)
        Me.txtNumberCases.Name = "txtNumberCases"
        Me.txtNumberCases.Size = New System.Drawing.Size(85, 22)
        Me.txtNumberCases.TabIndex = 27
        Me.txtNumberCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "عدد الحالات :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "الي الساعة :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "من الساعة :"
        '
        'dtpToTime
        '
        Me.dtpToTime.CustomFormat = "hh:mm:t"
        Me.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToTime.Location = New System.Drawing.Point(6, 114)
        Me.dtpToTime.Name = "dtpToTime"
        Me.dtpToTime.RightToLeftLayout = True
        Me.dtpToTime.ShowUpDown = True
        Me.dtpToTime.Size = New System.Drawing.Size(85, 20)
        Me.dtpToTime.TabIndex = 23
        '
        'dtpFromTime
        '
        Me.dtpFromTime.CustomFormat = "HH:mm t"
        Me.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromTime.Location = New System.Drawing.Point(196, 114)
        Me.dtpFromTime.Name = "dtpFromTime"
        Me.dtpFromTime.RightToLeftLayout = True
        Me.dtpFromTime.ShowUpDown = True
        Me.dtpFromTime.Size = New System.Drawing.Size(85, 20)
        Me.dtpFromTime.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "اليوم :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "اسم الطبيب :"
        '
        'cmbDoctor
        '
        Me.cmbDoctor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(6, 56)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(276, 23)
        Me.cmbDoctor.TabIndex = 16
        '
        'lblAdministrative
        '
        Me.lblAdministrative.AutoSize = True
        Me.lblAdministrative.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdministrative.Location = New System.Drawing.Point(288, 30)
        Me.lblAdministrative.Name = "lblAdministrative"
        Me.lblAdministrative.Size = New System.Drawing.Size(40, 15)
        Me.lblAdministrative.TabIndex = 15
        Me.lblAdministrative.Text = "العيادة :"
        '
        'cmbClinc
        '
        Me.cmbClinc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClinc.FormattingEnabled = True
        Me.cmbClinc.Location = New System.Drawing.Point(6, 27)
        Me.cmbClinc.Name = "cmbClinc"
        Me.cmbClinc.Size = New System.Drawing.Size(276, 23)
        Me.cmbClinc.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAddDoctorsAppointmentSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddDoctorsAppointmentSchedule"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة موعد طبيب"
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BGW_Save As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Edit As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Delete As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents lblAdministrative As Label
    Friend WithEvents cmbClinc As ComboBox
    Friend WithEvents txtReviewAllowed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNumberCases As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpToTime As DateTimePicker
    Friend WithEvents dtpFromTime As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
