<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DocPriceServices
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DocPriceServicesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbDocServicesName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorsRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddDoctor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrintDoctorServices = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearchServices = New System.Windows.Forms.TextBox()
        Me.txtSearchDoctor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_SelectList = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocPriceServicesID, Me.tbDocServicesName, Me.PatientPrice, Me.DoctorsRate})
        Me.DataGridView1.Location = New System.Drawing.Point(262, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(605, 555)
        Me.DataGridView1.TabIndex = 1
        '
        'DocPriceServicesID
        '
        Me.DocPriceServicesID.DataPropertyName = "DocPriceServicesID"
        Me.DocPriceServicesID.HeaderText = "الكود "
        Me.DocPriceServicesID.Name = "DocPriceServicesID"
        Me.DocPriceServicesID.ReadOnly = True
        Me.DocPriceServicesID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DocPriceServicesID.Width = 50
        '
        'tbDocServicesName
        '
        Me.tbDocServicesName.DataPropertyName = "tbDocServicesName"
        Me.tbDocServicesName.HeaderText = "الخدمة"
        Me.tbDocServicesName.Name = "tbDocServicesName"
        Me.tbDocServicesName.ReadOnly = True
        Me.tbDocServicesName.Width = 330
        '
        'PatientPrice
        '
        Me.PatientPrice.DataPropertyName = "PatientPrice"
        Me.PatientPrice.HeaderText = "السعر"
        Me.PatientPrice.Name = "PatientPrice"
        Me.PatientPrice.ReadOnly = True
        Me.PatientPrice.Width = 80
        '
        'DoctorsRate
        '
        Me.DoctorsRate.DataPropertyName = "DoctorsRate"
        Me.DoctorsRate.HeaderText = "نسبة الدكتور"
        Me.DoctorsRate.Name = "DoctorsRate"
        Me.DoctorsRate.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "الدكاتيرة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(12, 100)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(244, 555)
        Me.ListBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "الخدمات و الاسعار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddDoctor)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnPrintDoctorServices)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 661)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 75)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnAddDoctor
        '
        Me.btnAddDoctor.Location = New System.Drawing.Point(634, 19)
        Me.btnAddDoctor.Name = "btnAddDoctor"
        Me.btnAddDoctor.Size = New System.Drawing.Size(100, 39)
        Me.btnAddDoctor.TabIndex = 7
        Me.btnAddDoctor.Text = "اضافة دكتور/ة"
        Me.btnAddDoctor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrintDoctorServices
        '
        Me.btnPrintDoctorServices.Location = New System.Drawing.Point(477, 19)
        Me.btnPrintDoctorServices.Name = "btnPrintDoctorServices"
        Me.btnPrintDoctorServices.Size = New System.Drawing.Size(151, 39)
        Me.btnPrintDoctorServices.TabIndex = 4
        Me.btnPrintDoctorServices.Text = "طباعة خدمات الدكتور "
        Me.btnPrintDoctorServices.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(740, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 39)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "اضافة خدمة "
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSearchServices
        '
        Me.txtSearchServices.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchServices.Location = New System.Drawing.Point(262, 79)
        Me.txtSearchServices.Name = "txtSearchServices"
        Me.txtSearchServices.Size = New System.Drawing.Size(605, 22)
        Me.txtSearchServices.TabIndex = 8
        '
        'txtSearchDoctor
        '
        Me.txtSearchDoctor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchDoctor.Location = New System.Drawing.Point(12, 79)
        Me.txtSearchDoctor.Name = "txtSearchDoctor"
        Me.txtSearchDoctor.Size = New System.Drawing.Size(244, 22)
        Me.txtSearchDoctor.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ملفToolStripMenuItem.Text = "ملف "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel2, Me.lblDateTime, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 748)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.StatusStrip1.TabIndex = 11
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
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "التاريخ :"
        '
        'lblDateTime
        '
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0, 3, 150, 2)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel3"
        '
        'PB
        '
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'BGW_SelectList
        '
        Me.BGW_SelectList.WorkerReportsProgress = True
        Me.BGW_SelectList.WorkerSupportsCancellation = True
        '
        'frm_DocPriceServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 770)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearchDoctor)
        Me.Controls.Add(Me.txtSearchServices)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_DocPriceServices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اسعار الخدمات "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrintDoctorServices As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearchServices As TextBox
    Friend WithEvents txtSearchDoctor As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents DocPriceServicesID As DataGridViewTextBoxColumn
    Friend WithEvents tbDocServicesName As DataGridViewTextBoxColumn
    Friend WithEvents PatientPrice As DataGridViewTextBoxColumn
    Friend WithEvents DoctorsRate As DataGridViewTextBoxColumn
    Friend WithEvents btnAddDoctor As Button
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BGW_SelectList As System.ComponentModel.BackgroundWorker
End Class
