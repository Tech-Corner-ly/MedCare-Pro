<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_addDocPriceServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addDocPriceServices))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةدكتورToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةخدمةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عرضاسعارالخدماتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDoctorsRate = New System.Windows.Forms.Label()
        Me.lblPatientPrice = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.cmbDocterName = New System.Windows.Forms.ComboBox()
        Me.cmbDocServices = New System.Windows.Forms.ComboBox()
        Me.txtDoctorsRate = New System.Windows.Forms.TextBox()
        Me.txtPatientPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BGW_Edit = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Save = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_Delete = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةدكتورToolStripMenuItem, Me.اضافةخدمةToolStripMenuItem, Me.عرضاسعارالخدماتToolStripMenuItem})
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'اضافةدكتورToolStripMenuItem
        '
        Me.اضافةدكتورToolStripMenuItem.Name = "اضافةدكتورToolStripMenuItem"
        Me.اضافةدكتورToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.اضافةدكتورToolStripMenuItem.Text = "اضافة دكتور "
        '
        'اضافةخدمةToolStripMenuItem
        '
        Me.اضافةخدمةToolStripMenuItem.Name = "اضافةخدمةToolStripMenuItem"
        Me.اضافةخدمةToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.اضافةخدمةToolStripMenuItem.Text = "اضافة خدمة"
        '
        'عرضاسعارالخدماتToolStripMenuItem
        '
        Me.عرضاسعارالخدماتToolStripMenuItem.Name = "عرضاسعارالخدماتToolStripMenuItem"
        Me.عرضاسعارالخدماتToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.عرضاسعارالخدماتToolStripMenuItem.Text = "عرض اسعار الخدمات "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(722, 22)
        Me.StatusStrip1.TabIndex = 10
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
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(0, 3, 150, 2)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 17)
        Me.lblUsername.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel3.Text = "التاريخ :"
        '
        'lblDateTime
        '
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0, 3, 80, 2)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel4"
        '
        'PB
        '
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        Me.PB.Step = 1
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 436)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(6, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(689, 23)
        Me.txtSearch.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(689, 384)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnNew)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 643)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 73)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(6, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 40)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(209, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(578, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(117, 40)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(332, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(455, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 40)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDoctorsRate)
        Me.Panel1.Controls.Add(Me.lblPatientPrice)
        Me.Panel1.Controls.Add(Me.lblServices)
        Me.Panel1.Controls.Add(Me.lblDoctorName)
        Me.Panel1.Controls.Add(Me.cmbDocterName)
        Me.Panel1.Controls.Add(Me.cmbDocServices)
        Me.Panel1.Controls.Add(Me.txtDoctorsRate)
        Me.Panel1.Controls.Add(Me.txtPatientPrice)
        Me.Panel1.Location = New System.Drawing.Point(12, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 116)
        Me.Panel1.TabIndex = 13
        '
        'lblDoctorsRate
        '
        Me.lblDoctorsRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDoctorsRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoctorsRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorsRate.Location = New System.Drawing.Point(196, 75)
        Me.lblDoctorsRate.Name = "lblDoctorsRate"
        Me.lblDoctorsRate.Size = New System.Drawing.Size(141, 23)
        Me.lblDoctorsRate.TabIndex = 19
        Me.lblDoctorsRate.Text = "نسبة الدكتورة :"
        Me.lblDoctorsRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPatientPrice
        '
        Me.lblPatientPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPatientPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPatientPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientPrice.Location = New System.Drawing.Point(541, 75)
        Me.lblPatientPrice.Name = "lblPatientPrice"
        Me.lblPatientPrice.Size = New System.Drawing.Size(141, 23)
        Me.lblPatientPrice.TabIndex = 18
        Me.lblPatientPrice.Text = "السعر للمريض :"
        Me.lblPatientPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServices
        '
        Me.lblServices.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServices.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(541, 41)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(141, 24)
        Me.lblServices.TabIndex = 17
        Me.lblServices.Text = "الخدمة :"
        Me.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDoctorName
        '
        Me.lblDoctorName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoctorName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorName.Location = New System.Drawing.Point(541, 12)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(141, 24)
        Me.lblDoctorName.TabIndex = 16
        Me.lblDoctorName.Text = "اسم الدكتور :"
        Me.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDocterName
        '
        Me.cmbDocterName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocterName.FormattingEnabled = True
        Me.cmbDocterName.Location = New System.Drawing.Point(6, 12)
        Me.cmbDocterName.Name = "cmbDocterName"
        Me.cmbDocterName.Size = New System.Drawing.Size(529, 24)
        Me.cmbDocterName.TabIndex = 15
        '
        'cmbDocServices
        '
        Me.cmbDocServices.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocServices.FormattingEnabled = True
        Me.cmbDocServices.Location = New System.Drawing.Point(6, 42)
        Me.cmbDocServices.Name = "cmbDocServices"
        Me.cmbDocServices.Size = New System.Drawing.Size(529, 24)
        Me.cmbDocServices.TabIndex = 14
        '
        'txtDoctorsRate
        '
        Me.txtDoctorsRate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorsRate.Location = New System.Drawing.Point(6, 75)
        Me.txtDoctorsRate.Name = "txtDoctorsRate"
        Me.txtDoctorsRate.Size = New System.Drawing.Size(185, 23)
        Me.txtDoctorsRate.TabIndex = 13
        '
        'txtPatientPrice
        '
        Me.txtPatientPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientPrice.Location = New System.Drawing.Point(343, 75)
        Me.txtPatientPrice.Name = "txtPatientPrice"
        Me.txtPatientPrice.Size = New System.Drawing.Size(192, 23)
        Me.txtPatientPrice.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 44)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "بيانات الخدمة "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BGW_Edit
        '
        Me.BGW_Edit.WorkerReportsProgress = True
        Me.BGW_Edit.WorkerSupportsCancellation = True
        '
        'BGW_Save
        '
        Me.BGW_Save.WorkerReportsProgress = True
        Me.BGW_Save.WorkerSupportsCancellation = True
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'BGW_Delete
        '
        Me.BGW_Delete.WorkerReportsProgress = True
        Me.BGW_Delete.WorkerSupportsCancellation = True
        '
        'frm_addDocPriceServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 745)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_addDocPriceServices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "اسعار الخدمات"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اضافةدكتورToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اضافةخدمةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents عرضاسعارالخدماتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDoctorsRate As Label
    Friend WithEvents lblPatientPrice As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblDoctorName As Label
    Friend WithEvents cmbDocterName As ComboBox
    Friend WithEvents cmbDocServices As ComboBox
    Friend WithEvents txtDoctorsRate As TextBox
    Friend WithEvents txtPatientPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BGW_Edit As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Save As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BGW_Delete As System.ComponentModel.BackgroundWorker
End Class
