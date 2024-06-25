<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Receipt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.عرضاسعارالخدماتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةخدمةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةدكتورToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtPatientPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtReceiptID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClinicName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lblCountPatientByDoctor = New System.Windows.Forms.Label()
        Me.txtPatientCount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbDoctorName = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "بيانات المريض "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServices
        '
        Me.lblServices.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServices.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(187, 12)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(107, 24)
        Me.lblServices.TabIndex = 17
        Me.lblServices.Text = "رقم الهاتف :"
        Me.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDoctorName
        '
        Me.lblDoctorName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoctorName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorName.Location = New System.Drawing.Point(573, 13)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(109, 24)
        Me.lblDoctorName.TabIndex = 16
        Me.lblDoctorName.Text = "اسم المريض :"
        Me.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPatientName
        '
        Me.cmbPatientName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.Location = New System.Drawing.Point(300, 12)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(267, 24)
        Me.cmbPatientName.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPatientPhone)
        Me.Panel1.Controls.Add(Me.lblServices)
        Me.Panel1.Controls.Add(Me.lblDoctorName)
        Me.Panel1.Controls.Add(Me.cmbPatientName)
        Me.Panel1.Location = New System.Drawing.Point(18, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 52)
        Me.Panel1.TabIndex = 22
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 40)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(357, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 40)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(615, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 40)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(443, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 40)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(529, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnNew)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 73)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'lblDateTime
        '
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0, 3, 80, 2)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel3.Text = "التاريخ :"
        '
        'lblUsername
        '
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(0, 3, 150, 2)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 17)
        Me.lblUsername.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel1.Text = "المستخدم :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(734, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'عرضاسعارالخدماتToolStripMenuItem
        '
        Me.عرضاسعارالخدماتToolStripMenuItem.Name = "عرضاسعارالخدماتToolStripMenuItem"
        Me.عرضاسعارالخدماتToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.عرضاسعارالخدماتToolStripMenuItem.Text = "عرض اسعار الخدمات "
        '
        'اضافةخدمةToolStripMenuItem
        '
        Me.اضافةخدمةToolStripMenuItem.Name = "اضافةخدمةToolStripMenuItem"
        Me.اضافةخدمةToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.اضافةخدمةToolStripMenuItem.Text = "اضافة خدمة"
        '
        'اضافةدكتورToolStripMenuItem
        '
        Me.اضافةدكتورToolStripMenuItem.Name = "اضافةدكتورToolStripMenuItem"
        Me.اضافةدكتورToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.اضافةدكتورToolStripMenuItem.Text = "اضافة دكتور "
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةدكتورToolStripMenuItem, Me.اضافةخدمةToolStripMenuItem, Me.عرضاسعارالخدماتToolStripMenuItem})
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtPatientPhone
        '
        Me.txtPatientPhone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientPhone.Location = New System.Drawing.Point(11, 13)
        Me.txtPatientPhone.Name = "txtPatientPhone"
        Me.txtPatientPhone.Size = New System.Drawing.Size(170, 23)
        Me.txtPatientPhone.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 30)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "تفاصيل الايصال"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPatientCount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblCountPatientByDoctor)
        Me.Panel2.Controls.Add(Me.dtpDateTime)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtReceiptID)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmbClinicName)
        Me.Panel2.Location = New System.Drawing.Point(18, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 106)
        Me.Panel2.TabIndex = 24
        '
        'txtReceiptID
        '
        Me.txtReceiptID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptID.Location = New System.Drawing.Point(435, 42)
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Size = New System.Drawing.Size(141, 23)
        Me.txtReceiptID.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "الكود :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(582, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "العيادة :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbClinicName
        '
        Me.cmbClinicName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClinicName.FormattingEnabled = True
        Me.cmbClinicName.Location = New System.Drawing.Point(435, 12)
        Me.cmbClinicName.Name = "cmbClinicName"
        Me.cmbClinicName.Size = New System.Drawing.Size(141, 24)
        Me.cmbClinicName.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "التاريخ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTime.Location = New System.Drawing.Point(187, 13)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(136, 23)
        Me.dtpDateTime.TabIndex = 21
        '
        'lblCountPatientByDoctor
        '
        Me.lblCountPatientByDoctor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCountPatientByDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountPatientByDoctor.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountPatientByDoctor.ForeColor = System.Drawing.Color.Red
        Me.lblCountPatientByDoctor.Location = New System.Drawing.Point(11, 11)
        Me.lblCountPatientByDoctor.Name = "lblCountPatientByDoctor"
        Me.lblCountPatientByDoctor.Size = New System.Drawing.Size(170, 85)
        Me.lblCountPatientByDoctor.TabIndex = 22
        Me.lblCountPatientByDoctor.Text = "001"
        Me.lblCountPatientByDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPatientCount
        '
        Me.txtPatientCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientCount.Location = New System.Drawing.Point(187, 42)
        Me.txtPatientCount.Name = "txtPatientCount"
        Me.txtPatientCount.Size = New System.Drawing.Size(136, 23)
        Me.txtPatientCount.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "عدد الحالات :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 30)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "بيانات الدكتور/ة"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cmbDoctorName)
        Me.Panel3.Location = New System.Drawing.Point(18, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(701, 52)
        Me.Panel3.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(573, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "اسم الدكتور/ة :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDoctorName
        '
        Me.cmbDoctorName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctorName.FormattingEnabled = True
        Me.cmbDoctorName.Location = New System.Drawing.Point(11, 12)
        Me.cmbDoctorName.Name = "cmbDoctorName"
        Me.cmbDoctorName.Size = New System.Drawing.Size(556, 24)
        Me.cmbDoctorName.TabIndex = 15
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(271, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frm_Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "frm_Receipt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ايصال عيادات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblDoctorName As Label
    Friend WithEvents cmbPatientName As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents عرضاسعارالخدماتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اضافةخدمةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اضافةدكتورToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtPatientPhone As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPatientCount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCountPatientByDoctor As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReceiptID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbClinicName As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbDoctorName As ComboBox
    Friend WithEvents dtpDateTime As DateTimePicker
End Class
