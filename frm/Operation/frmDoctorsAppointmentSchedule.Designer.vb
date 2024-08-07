<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctorsAppointmentSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoctorsAppointmentSchedule))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.AppoinScheID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppoinScheFromTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppoinScheToTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowNumCases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReviewAllowedNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(150, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        '
        'lblDateTime
        '
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(150, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "التاريخ :"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 17)
        Me.lblUsername.Text = "lblUsernametxt"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel1.Text = "المستخدم :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel2, Me.lblDateTime, Me.PB, Me.ToolStripStatusLabel3, Me.lblCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(100, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel3.Text = "عدد السجلات :"
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(37, 17)
        Me.lblCount.Text = "00000"
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        Me.خروجToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.خروجToolStripMenuItem.Text = "خروج"
        '
        'مساعدةToolStripMenuItem
        '
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 790, 0)
        Me.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem"
        Me.مساعدةToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.مساعدةToolStripMenuItem.Text = "مساعدة"
        '
        'خياراتToolStripMenuItem
        '
        Me.خياراتToolStripMenuItem.Name = "خياراتToolStripMenuItem"
        Me.خياراتToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.خياراتToolStripMenuItem.Text = "خيارات "
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(972, 29)
        Me.txtSearch.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddAppointment.Location = New System.Drawing.Point(871, 19)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(94, 37)
        Me.btnAddAppointment.TabIndex = 2
        Me.btnAddAppointment.Text = "اضافة موعد "
        Me.btnAddAppointment.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClose.Location = New System.Drawing.Point(6, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnAddAppointment)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 548)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 70)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppoinScheID, Me.ClinicName, Me.EmpName, Me.Column7, Me.AppoinScheFromTime, Me.AppoinScheToTime, Me.AllowNumCases, Me.ReviewAllowedNum})
        Me.DGV.Location = New System.Drawing.Point(12, 72)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(971, 470)
        Me.DGV.TabIndex = 6
        '
        'AppoinScheID
        '
        Me.AppoinScheID.DataPropertyName = "AppoinScheID"
        Me.AppoinScheID.HeaderText = "#"
        Me.AppoinScheID.Name = "AppoinScheID"
        Me.AppoinScheID.ReadOnly = True
        '
        'ClinicName
        '
        Me.ClinicName.DataPropertyName = "ClinicName"
        Me.ClinicName.HeaderText = "اسم العيادة"
        Me.ClinicName.Name = "ClinicName"
        Me.ClinicName.ReadOnly = True
        '
        'EmpName
        '
        Me.EmpName.DataPropertyName = "EmpName"
        Me.EmpName.HeaderText = "اسم الطبيب"
        Me.EmpName.Name = "EmpName"
        Me.EmpName.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Day"
        Me.Column7.HeaderText = "البوم"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'AppoinScheFromTime
        '
        Me.AppoinScheFromTime.DataPropertyName = "AppoinScheFromTime"
        Me.AppoinScheFromTime.HeaderText = "بداية العمل"
        Me.AppoinScheFromTime.Name = "AppoinScheFromTime"
        Me.AppoinScheFromTime.ReadOnly = True
        '
        'AppoinScheToTime
        '
        Me.AppoinScheToTime.DataPropertyName = "AppoinScheToTime"
        Me.AppoinScheToTime.HeaderText = "نهاية العمل"
        Me.AppoinScheToTime.Name = "AppoinScheToTime"
        Me.AppoinScheToTime.ReadOnly = True
        '
        'AllowNumCases
        '
        Me.AllowNumCases.DataPropertyName = "AllowNumCases"
        Me.AllowNumCases.HeaderText = "عدد الحالات المسموح به"
        Me.AllowNumCases.Name = "AllowNumCases"
        Me.AllowNumCases.ReadOnly = True
        '
        'ReviewAllowedNum
        '
        Me.ReviewAllowedNum.DataPropertyName = "ReviewAllowedNum"
        Me.ReviewAllowedNum.HeaderText = "سماحية المراجعة خلال"
        Me.ReviewAllowedNum.Name = "ReviewAllowedNum"
        Me.ReviewAllowedNum.ReadOnly = True
        '
        'frmDoctorsAppointmentSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 650)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDoctorsAppointmentSchedule"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جدول مواعيد الاطباء "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblCount As ToolStripStatusLabel
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGV As DataGridView
    Friend WithEvents AppoinScheID As DataGridViewTextBoxColumn
    Friend WithEvents ClinicName As DataGridViewTextBoxColumn
    Friend WithEvents EmpName As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents AppoinScheFromTime As DataGridViewTextBoxColumn
    Friend WithEvents AppoinScheToTime As DataGridViewTextBoxColumn
    Friend WithEvents AllowNumCases As DataGridViewTextBoxColumn
    Friend WithEvents ReviewAllowedNum As DataGridViewTextBoxColumn
End Class
