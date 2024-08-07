<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddEmploye = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EmployeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSurName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdjectiveID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdministrativeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPhone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPhone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeID, Me.EmployeCode, Me.EmpFirstName, Me.EmpSurName, Me.AdjectiveID, Me.JobTitle, Me.AdministrativeName, Me.EmpGender, Me.arName, Me.EmpPhone1, Me.EmpPhone2})
        Me.DGV.Location = New System.Drawing.Point(12, 72)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(971, 470)
        Me.DGV.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnAddEmploye)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 548)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnAddEmploye
        '
        Me.btnAddEmploye.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmploye.Location = New System.Drawing.Point(871, 19)
        Me.btnAddEmploye.Name = "btnAddEmploye"
        Me.btnAddEmploye.Size = New System.Drawing.Size(94, 37)
        Me.btnAddEmploye.TabIndex = 2
        Me.btnAddEmploye.Text = "اضافة موظف"
        Me.btnAddEmploye.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(6, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(972, 29)
        Me.txtSearch.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
        Me.MenuStrip1.TabIndex = 4
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
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 790, 0)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel2, Me.lblDateTime, Me.ToolStripStatusLabel3, Me.lblCount, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip1.TabIndex = 5
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
        Me.lblUsername.Size = New System.Drawing.Size(87, 17)
        Me.lblUsername.Text = "lblUsernametxt"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(150, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "التاريخ :"
        '
        'lblDateTime
        '
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(119, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(150, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel3.Text = "العدد :"
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(119, 17)
        Me.lblCount.Text = "ToolStripStatusLabel4"
        '
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(70, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'EmployeID
        '
        Me.EmployeID.DataPropertyName = "EmployeID"
        Me.EmployeID.HeaderText = "الكود"
        Me.EmployeID.Name = "EmployeID"
        Me.EmployeID.ReadOnly = True
        '
        'EmployeCode
        '
        Me.EmployeCode.DataPropertyName = "EmployeCode"
        Me.EmployeCode.HeaderText = "كود الموظف"
        Me.EmployeCode.Name = "EmployeCode"
        Me.EmployeCode.ReadOnly = True
        '
        'EmpFirstName
        '
        Me.EmpFirstName.DataPropertyName = "EmpFirstName"
        Me.EmpFirstName.HeaderText = "الاسم الاول"
        Me.EmpFirstName.Name = "EmpFirstName"
        Me.EmpFirstName.ReadOnly = True
        '
        'EmpSurName
        '
        Me.EmpSurName.DataPropertyName = "EmpSurName"
        Me.EmpSurName.HeaderText = "اللقب"
        Me.EmpSurName.Name = "EmpSurName"
        Me.EmpSurName.ReadOnly = True
        '
        'AdjectiveID
        '
        Me.AdjectiveID.DataPropertyName = "AdjectiveID"
        Me.AdjectiveID.HeaderText = "الصفة"
        Me.AdjectiveID.Name = "AdjectiveID"
        Me.AdjectiveID.ReadOnly = True
        '
        'JobTitle
        '
        Me.JobTitle.DataPropertyName = "JobTitle"
        Me.JobTitle.HeaderText = "المسمي الوظيفي"
        Me.JobTitle.Name = "JobTitle"
        Me.JobTitle.ReadOnly = True
        '
        'AdministrativeName
        '
        Me.AdministrativeName.DataPropertyName = "AdministrativeName"
        Me.AdministrativeName.HeaderText = "الادارة"
        Me.AdministrativeName.Name = "AdministrativeName"
        Me.AdministrativeName.ReadOnly = True
        '
        'EmpGender
        '
        Me.EmpGender.DataPropertyName = "EmpGender"
        Me.EmpGender.HeaderText = "الجنس"
        Me.EmpGender.Name = "EmpGender"
        Me.EmpGender.ReadOnly = True
        '
        'arName
        '
        Me.arName.DataPropertyName = "arName"
        Me.arName.HeaderText = "الجنسية"
        Me.arName.Name = "arName"
        Me.arName.ReadOnly = True
        '
        'EmpPhone1
        '
        Me.EmpPhone1.DataPropertyName = "EmpPhone1"
        Me.EmpPhone1.HeaderText = "الجوال"
        Me.EmpPhone1.Name = "EmpPhone1"
        Me.EmpPhone1.ReadOnly = True
        '
        'EmpPhone2
        '
        Me.EmpPhone2.DataPropertyName = "EmpPhone2"
        Me.EmpPhone2.HeaderText = "الجوال"
        Me.EmpPhone2.Name = "EmpPhone2"
        Me.EmpPhone2.ReadOnly = True
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 650)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEmployees"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الموظفين "
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents btnAddEmploye As Button
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblCount As ToolStripStatusLabel
    Friend WithEvents EmployeID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeCode As DataGridViewTextBoxColumn
    Friend WithEvents EmpFirstName As DataGridViewTextBoxColumn
    Friend WithEvents EmpSurName As DataGridViewTextBoxColumn
    Friend WithEvents AdjectiveID As DataGridViewTextBoxColumn
    Friend WithEvents JobTitle As DataGridViewTextBoxColumn
    Friend WithEvents AdministrativeName As DataGridViewTextBoxColumn
    Friend WithEvents EmpGender As DataGridViewTextBoxColumn
    Friend WithEvents arName As DataGridViewTextBoxColumn
    Friend WithEvents EmpPhone1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpPhone2 As DataGridViewTextBoxColumn
End Class
