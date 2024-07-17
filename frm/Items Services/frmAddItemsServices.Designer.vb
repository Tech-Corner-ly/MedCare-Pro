<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItemsServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItemsServices))
        Me.BGW_Save = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.BGW_Delete = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Edit = New System.ComponentModel.BackgroundWorker()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.btnMovementOfItem = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtItemLatin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbIsActive = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cmbCalcuMethod = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.btnCreateBarcode = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtSixthProfitPerc = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtSixthPrice = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtFifthProfitPerc = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtFifthPrice = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtFourthProfitPerc = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtThirdProfitPerce = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtSecondProfitPerc = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtFirstProfitPerc = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtLastCostPrice = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtLastPurchPrice = New System.Windows.Forms.TextBox()
        Me.cmbUnitType = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtUnitEqu = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFourthPrice = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtThirdPrice = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSecondPrice = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtFirstPrice = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtPurchPrice = New System.Windows.Forms.TextBox()
        Me.btnVirtualUnit = New System.Windows.Forms.Button()
        Me.btnDeleteUnit = New System.Windows.Forms.Button()
        Me.btnAddUnit = New System.Windows.Forms.Button()
        Me.dgvUnits = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtHigh = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSizeUnit = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.cbStopEditPrice = New System.Windows.Forms.CheckBox()
        Me.cbStopSelling = New System.Windows.Forms.CheckBox()
        Me.cbPreventingNegativeWithdrawals = New System.Windows.Forms.CheckBox()
        Me.cbCheckExpiryDate = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbCostCalc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbGroups = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbLastSupplier = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.cmbCompanyMother = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSpecifications = New System.Windows.Forms.TextBox()
        Me.TabAlternativeBarcode = New System.Windows.Forms.TabPage()
        Me.dgvBarcode = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvUnit = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCompositeMaterial = New System.Windows.Forms.TabPage()
        Me.btnAddToCompositeMaterial = New System.Windows.Forms.Button()
        Me.txtSearchCompositeMaterial = New System.Windows.Forms.TextBox()
        Me.dgvCompositeMaterial = New System.Windows.Forms.DataGridView()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        CType(Me.dgvUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlternativeBarcode.SuspendLayout()
        CType(Me.dgvBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCompositeMaterial.SuspendLayout()
        CType(Me.dgvCompositeMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BGW_Save
        '
        Me.BGW_Save.WorkerReportsProgress = True
        Me.BGW_Save.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
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
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 730, 0)
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
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(934, 22)
        Me.StatusStrip1.TabIndex = 33
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
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(200, 3, 0, 2)
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
        Me.PB.Margin = New System.Windows.Forms.Padding(250, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        Me.PB.Step = 1
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'BGW_Delete
        '
        Me.BGW_Delete.WorkerReportsProgress = True
        Me.BGW_Delete.WorkerSupportsCancellation = True
        '
        'BGW_Edit
        '
        Me.BGW_Edit.WorkerReportsProgress = True
        Me.BGW_Edit.WorkerSupportsCancellation = True
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtItemName.Location = New System.Drawing.Point(131, 64)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(474, 22)
        Me.txtItemName.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(92, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "الفئة :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnPrintBarcode)
        Me.GroupBox2.Controls.Add(Me.btnMovementOfItem)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 622)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(906, 70)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(281, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 37)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Location = New System.Drawing.Point(372, 19)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(85, 37)
        Me.btnPrintBarcode.TabIndex = 6
        Me.btnPrintBarcode.Text = "طباعة باركود"
        Me.btnPrintBarcode.UseVisualStyleBackColor = True
        '
        'btnMovementOfItem
        '
        Me.btnMovementOfItem.Location = New System.Drawing.Point(463, 19)
        Me.btnMovementOfItem.Name = "btnMovementOfItem"
        Me.btnMovementOfItem.Size = New System.Drawing.Size(85, 37)
        Me.btnMovementOfItem.TabIndex = 5
        Me.btnMovementOfItem.Text = "حركة مادة"
        Me.btnMovementOfItem.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(626, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 37)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(695, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 37)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(764, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 37)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(833, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(63, 37)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = True
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
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtItemCode.Location = New System.Drawing.Point(408, 37)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(134, 22)
        Me.txtItemCode.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "الكود :"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(131, 37)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(230, 21)
        Me.cmbCategory.TabIndex = 38
        '
        'txtItemLatin
        '
        Me.txtItemLatin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtItemLatin.Location = New System.Drawing.Point(131, 92)
        Me.txtItemLatin.Name = "txtItemLatin"
        Me.txtItemLatin.Size = New System.Drawing.Size(474, 22)
        Me.txtItemLatin.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "الاسم :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "الاسم لاتيني :"
        '
        'cmbIsActive
        '
        Me.cmbIsActive.AutoSize = True
        Me.cmbIsActive.Checked = True
        Me.cmbIsActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmbIsActive.Location = New System.Drawing.Point(553, 40)
        Me.cmbIsActive.Name = "cmbIsActive"
        Me.cmbIsActive.Size = New System.Drawing.Size(52, 17)
        Me.cmbIsActive.TabIndex = 42
        Me.cmbIsActive.Text = "نشط "
        Me.cmbIsActive.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGeneral)
        Me.TabControl1.Controls.Add(Me.TabAlternativeBarcode)
        Me.TabControl1.Controls.Add(Me.TabCompositeMaterial)
        Me.TabControl1.Location = New System.Drawing.Point(12, 121)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(910, 495)
        Me.TabControl1.TabIndex = 43
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.TabGeneral.Controls.Add(Me.LinkLabel1)
        Me.TabGeneral.Controls.Add(Me.Label45)
        Me.TabGeneral.Controls.Add(Me.Label44)
        Me.TabGeneral.Controls.Add(Me.cmbCalcuMethod)
        Me.TabGeneral.Controls.Add(Me.Label43)
        Me.TabGeneral.Controls.Add(Me.txtAmount)
        Me.TabGeneral.Controls.Add(Me.Label42)
        Me.TabGeneral.Controls.Add(Me.txtPerc)
        Me.TabGeneral.Controls.Add(Me.btnCreateBarcode)
        Me.TabGeneral.Controls.Add(Me.Label41)
        Me.TabGeneral.Controls.Add(Me.txtBarcode)
        Me.TabGeneral.Controls.Add(Me.Label39)
        Me.TabGeneral.Controls.Add(Me.txtSixthProfitPerc)
        Me.TabGeneral.Controls.Add(Me.Label40)
        Me.TabGeneral.Controls.Add(Me.txtSixthPrice)
        Me.TabGeneral.Controls.Add(Me.Label37)
        Me.TabGeneral.Controls.Add(Me.txtFifthProfitPerc)
        Me.TabGeneral.Controls.Add(Me.Label38)
        Me.TabGeneral.Controls.Add(Me.txtFifthPrice)
        Me.TabGeneral.Controls.Add(Me.Label31)
        Me.TabGeneral.Controls.Add(Me.txtFourthProfitPerc)
        Me.TabGeneral.Controls.Add(Me.Label32)
        Me.TabGeneral.Controls.Add(Me.txtThirdProfitPerce)
        Me.TabGeneral.Controls.Add(Me.Label33)
        Me.TabGeneral.Controls.Add(Me.txtSecondProfitPerc)
        Me.TabGeneral.Controls.Add(Me.Label34)
        Me.TabGeneral.Controls.Add(Me.txtFirstProfitPerc)
        Me.TabGeneral.Controls.Add(Me.Label35)
        Me.TabGeneral.Controls.Add(Me.txtLastCostPrice)
        Me.TabGeneral.Controls.Add(Me.Label36)
        Me.TabGeneral.Controls.Add(Me.txtLastPurchPrice)
        Me.TabGeneral.Controls.Add(Me.cmbUnitType)
        Me.TabGeneral.Controls.Add(Me.Label30)
        Me.TabGeneral.Controls.Add(Me.txtUnitEqu)
        Me.TabGeneral.Controls.Add(Me.Label29)
        Me.TabGeneral.Controls.Add(Me.Label23)
        Me.TabGeneral.Controls.Add(Me.txtFourthPrice)
        Me.TabGeneral.Controls.Add(Me.Label24)
        Me.TabGeneral.Controls.Add(Me.txtThirdPrice)
        Me.TabGeneral.Controls.Add(Me.Label25)
        Me.TabGeneral.Controls.Add(Me.txtSecondPrice)
        Me.TabGeneral.Controls.Add(Me.Label26)
        Me.TabGeneral.Controls.Add(Me.txtFirstPrice)
        Me.TabGeneral.Controls.Add(Me.Label27)
        Me.TabGeneral.Controls.Add(Me.txtCostPrice)
        Me.TabGeneral.Controls.Add(Me.Label28)
        Me.TabGeneral.Controls.Add(Me.txtPurchPrice)
        Me.TabGeneral.Controls.Add(Me.btnVirtualUnit)
        Me.TabGeneral.Controls.Add(Me.btnDeleteUnit)
        Me.TabGeneral.Controls.Add(Me.btnAddUnit)
        Me.TabGeneral.Controls.Add(Me.dgvUnits)
        Me.TabGeneral.Controls.Add(Me.Label22)
        Me.TabGeneral.Controls.Add(Me.txtHigh)
        Me.TabGeneral.Controls.Add(Me.Label21)
        Me.TabGeneral.Controls.Add(Me.txtWidth)
        Me.TabGeneral.Controls.Add(Me.Label20)
        Me.TabGeneral.Controls.Add(Me.txtHeight)
        Me.TabGeneral.Controls.Add(Me.Label19)
        Me.TabGeneral.Controls.Add(Me.txtSizeUnit)
        Me.TabGeneral.Controls.Add(Me.Label18)
        Me.TabGeneral.Controls.Add(Me.txtWeight)
        Me.TabGeneral.Controls.Add(Me.Label17)
        Me.TabGeneral.Controls.Add(Me.txtColor)
        Me.TabGeneral.Controls.Add(Me.Label16)
        Me.TabGeneral.Controls.Add(Me.cmbItemType)
        Me.TabGeneral.Controls.Add(Me.cbStopEditPrice)
        Me.TabGeneral.Controls.Add(Me.cbStopSelling)
        Me.TabGeneral.Controls.Add(Me.cbPreventingNegativeWithdrawals)
        Me.TabGeneral.Controls.Add(Me.cbCheckExpiryDate)
        Me.TabGeneral.Controls.Add(Me.Label15)
        Me.TabGeneral.Controls.Add(Me.txtNote)
        Me.TabGeneral.Controls.Add(Me.Label14)
        Me.TabGeneral.Controls.Add(Me.cmbCostCenter)
        Me.TabGeneral.Controls.Add(Me.Label13)
        Me.TabGeneral.Controls.Add(Me.cmbCostCalc)
        Me.TabGeneral.Controls.Add(Me.Label12)
        Me.TabGeneral.Controls.Add(Me.cmbWarehouse)
        Me.TabGeneral.Controls.Add(Me.Label11)
        Me.TabGeneral.Controls.Add(Me.cmbGroups)
        Me.TabGeneral.Controls.Add(Me.Label10)
        Me.TabGeneral.Controls.Add(Me.cmbLastSupplier)
        Me.TabGeneral.Controls.Add(Me.Label8)
        Me.TabGeneral.Controls.Add(Me.cmbSupplier)
        Me.TabGeneral.Controls.Add(Me.Label7)
        Me.TabGeneral.Controls.Add(Me.txtMeasurement)
        Me.TabGeneral.Controls.Add(Me.cmbCompanyMother)
        Me.TabGeneral.Controls.Add(Me.Label5)
        Me.TabGeneral.Controls.Add(Me.txtSource)
        Me.TabGeneral.Controls.Add(Me.Label4)
        Me.TabGeneral.Controls.Add(Me.txtSpecifications)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGeneral.Size = New System.Drawing.Size(902, 469)
        Me.TabGeneral.TabIndex = 0
        Me.TabGeneral.Text = "عام"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.Location = New System.Drawing.Point(793, 74)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel1.TabIndex = 137
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "الشركة الام :"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(442, 272)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(208, 15)
        Me.Label45.TabIndex = 136
        Me.Label45.Text = "حصص الاطباء : --------------------------------"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(572, 297)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(82, 15)
        Me.Label44.TabIndex = 135
        Me.Label44.Text = "طريقة الاحتساب :"
        '
        'cmbCalcuMethod
        '
        Me.cmbCalcuMethod.FormattingEnabled = True
        Me.cmbCalcuMethod.Location = New System.Drawing.Point(442, 295)
        Me.cmbCalcuMethod.Name = "cmbCalcuMethod"
        Me.cmbCalcuMethod.Size = New System.Drawing.Size(124, 21)
        Me.cmbCalcuMethod.TabIndex = 134
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(572, 353)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(32, 15)
        Me.Label43.TabIndex = 133
        Me.Label43.Text = "قيمة :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.Location = New System.Drawing.Point(442, 350)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(124, 22)
        Me.txtAmount.TabIndex = 132
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(572, 325)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 15)
        Me.Label42.TabIndex = 131
        Me.Label42.Text = "نسبة % :"
        '
        'txtPerc
        '
        Me.txtPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPerc.Location = New System.Drawing.Point(442, 322)
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(124, 22)
        Me.txtPerc.TabIndex = 130
        '
        'btnCreateBarcode
        '
        Me.btnCreateBarcode.Location = New System.Drawing.Point(25, 410)
        Me.btnCreateBarcode.Name = "btnCreateBarcode"
        Me.btnCreateBarcode.Size = New System.Drawing.Size(24, 22)
        Me.btnCreateBarcode.TabIndex = 129
        Me.btnCreateBarcode.Text = "--"
        Me.btnCreateBarcode.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(297, 413)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(42, 15)
        Me.Label41.TabIndex = 128
        Me.Label41.Text = "باركود :"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtBarcode.Location = New System.Drawing.Point(55, 410)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(236, 22)
        Me.txtBarcode.TabIndex = 127
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(113, 384)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 15)
        Me.Label39.TabIndex = 126
        Me.Label39.Text = "نسبة الربح :"
        '
        'txtSixthProfitPerc
        '
        Me.txtSixthProfitPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSixthProfitPerc.Location = New System.Drawing.Point(25, 381)
        Me.txtSixthProfitPerc.Name = "txtSixthProfitPerc"
        Me.txtSixthProfitPerc.Size = New System.Drawing.Size(82, 22)
        Me.txtSixthProfitPerc.TabIndex = 125
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(297, 385)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 15)
        Me.Label40.TabIndex = 124
        Me.Label40.Text = "السعر السادس :"
        '
        'txtSixthPrice
        '
        Me.txtSixthPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSixthPrice.Location = New System.Drawing.Point(197, 382)
        Me.txtSixthPrice.Name = "txtSixthPrice"
        Me.txtSixthPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtSixthPrice.TabIndex = 123
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(113, 356)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(61, 15)
        Me.Label37.TabIndex = 122
        Me.Label37.Text = "نسبة الربح :"
        '
        'txtFifthProfitPerc
        '
        Me.txtFifthProfitPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFifthProfitPerc.Location = New System.Drawing.Point(25, 353)
        Me.txtFifthProfitPerc.Name = "txtFifthProfitPerc"
        Me.txtFifthProfitPerc.Size = New System.Drawing.Size(82, 22)
        Me.txtFifthProfitPerc.TabIndex = 121
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(297, 357)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 15)
        Me.Label38.TabIndex = 120
        Me.Label38.Text = "السعر الخامس :"
        '
        'txtFifthPrice
        '
        Me.txtFifthPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFifthPrice.Location = New System.Drawing.Point(197, 354)
        Me.txtFifthPrice.Name = "txtFifthPrice"
        Me.txtFifthPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtFifthPrice.TabIndex = 119
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(113, 328)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 15)
        Me.Label31.TabIndex = 118
        Me.Label31.Text = "نسبة الربح :"
        '
        'txtFourthProfitPerc
        '
        Me.txtFourthProfitPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFourthProfitPerc.Location = New System.Drawing.Point(25, 325)
        Me.txtFourthProfitPerc.Name = "txtFourthProfitPerc"
        Me.txtFourthProfitPerc.Size = New System.Drawing.Size(82, 22)
        Me.txtFourthProfitPerc.TabIndex = 117
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(113, 300)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(61, 15)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "نسبة الربح :"
        '
        'txtThirdProfitPerce
        '
        Me.txtThirdProfitPerce.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtThirdProfitPerce.Location = New System.Drawing.Point(25, 297)
        Me.txtThirdProfitPerce.Name = "txtThirdProfitPerce"
        Me.txtThirdProfitPerce.Size = New System.Drawing.Size(82, 22)
        Me.txtThirdProfitPerce.TabIndex = 115
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(113, 272)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(61, 15)
        Me.Label33.TabIndex = 114
        Me.Label33.Text = "نسبة الربح :"
        '
        'txtSecondProfitPerc
        '
        Me.txtSecondProfitPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSecondProfitPerc.Location = New System.Drawing.Point(25, 269)
        Me.txtSecondProfitPerc.Name = "txtSecondProfitPerc"
        Me.txtSecondProfitPerc.Size = New System.Drawing.Size(82, 22)
        Me.txtSecondProfitPerc.TabIndex = 113
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(113, 244)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 15)
        Me.Label34.TabIndex = 112
        Me.Label34.Text = "نسبة الربح :"
        '
        'txtFirstProfitPerc
        '
        Me.txtFirstProfitPerc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFirstProfitPerc.Location = New System.Drawing.Point(25, 241)
        Me.txtFirstProfitPerc.Name = "txtFirstProfitPerc"
        Me.txtFirstProfitPerc.Size = New System.Drawing.Size(82, 22)
        Me.txtFirstProfitPerc.TabIndex = 111
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(113, 216)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(76, 15)
        Me.Label35.TabIndex = 110
        Me.Label35.Text = "اخر سعر تكلفة :"
        '
        'txtLastCostPrice
        '
        Me.txtLastCostPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtLastCostPrice.Location = New System.Drawing.Point(25, 213)
        Me.txtLastCostPrice.Name = "txtLastCostPrice"
        Me.txtLastCostPrice.ReadOnly = True
        Me.txtLastCostPrice.Size = New System.Drawing.Size(82, 22)
        Me.txtLastCostPrice.TabIndex = 109
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(113, 188)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(75, 15)
        Me.Label36.TabIndex = 108
        Me.Label36.Text = "اخر سعر شراء:"
        '
        'txtLastPurchPrice
        '
        Me.txtLastPurchPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtLastPurchPrice.Location = New System.Drawing.Point(25, 185)
        Me.txtLastPurchPrice.Name = "txtLastPurchPrice"
        Me.txtLastPurchPrice.ReadOnly = True
        Me.txtLastPurchPrice.Size = New System.Drawing.Size(82, 22)
        Me.txtLastPurchPrice.TabIndex = 107
        '
        'cmbUnitType
        '
        Me.cmbUnitType.FormattingEnabled = True
        Me.cmbUnitType.Location = New System.Drawing.Point(197, 159)
        Me.cmbUnitType.Name = "cmbUnitType"
        Me.cmbUnitType.Size = New System.Drawing.Size(94, 21)
        Me.cmbUnitType.TabIndex = 106
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(113, 161)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 15)
        Me.Label30.TabIndex = 105
        Me.Label30.Text = "تعادل:"
        '
        'txtUnitEqu
        '
        Me.txtUnitEqu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtUnitEqu.Location = New System.Drawing.Point(25, 157)
        Me.txtUnitEqu.Name = "txtUnitEqu"
        Me.txtUnitEqu.ReadOnly = True
        Me.txtUnitEqu.Size = New System.Drawing.Size(82, 22)
        Me.txtUnitEqu.TabIndex = 104
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(297, 161)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 15)
        Me.Label29.TabIndex = 103
        Me.Label29.Text = "الوحدة :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(297, 329)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 15)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "السعر الرابع :"
        '
        'txtFourthPrice
        '
        Me.txtFourthPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFourthPrice.Location = New System.Drawing.Point(197, 326)
        Me.txtFourthPrice.Name = "txtFourthPrice"
        Me.txtFourthPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtFourthPrice.TabIndex = 100
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(297, 301)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 15)
        Me.Label24.TabIndex = 99
        Me.Label24.Text = "السعر الثالث :"
        '
        'txtThirdPrice
        '
        Me.txtThirdPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtThirdPrice.Location = New System.Drawing.Point(197, 298)
        Me.txtThirdPrice.Name = "txtThirdPrice"
        Me.txtThirdPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtThirdPrice.TabIndex = 98
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(297, 273)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 15)
        Me.Label25.TabIndex = 97
        Me.Label25.Text = "السعر الثاني :"
        '
        'txtSecondPrice
        '
        Me.txtSecondPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSecondPrice.Location = New System.Drawing.Point(197, 270)
        Me.txtSecondPrice.Name = "txtSecondPrice"
        Me.txtSecondPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtSecondPrice.TabIndex = 96
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(297, 245)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 15)
        Me.Label26.TabIndex = 95
        Me.Label26.Text = "السعر الاول :"
        '
        'txtFirstPrice
        '
        Me.txtFirstPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFirstPrice.Location = New System.Drawing.Point(197, 242)
        Me.txtFirstPrice.Name = "txtFirstPrice"
        Me.txtFirstPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtFirstPrice.TabIndex = 94
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(297, 217)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 15)
        Me.Label27.TabIndex = 93
        Me.Label27.Text = "سعر التكلفة :"
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCostPrice.Location = New System.Drawing.Point(197, 214)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.ReadOnly = True
        Me.txtCostPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtCostPrice.TabIndex = 92
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(297, 189)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 15)
        Me.Label28.TabIndex = 91
        Me.Label28.Text = "سعر الشراء :"
        '
        'txtPurchPrice
        '
        Me.txtPurchPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPurchPrice.Location = New System.Drawing.Point(197, 186)
        Me.txtPurchPrice.Name = "txtPurchPrice"
        Me.txtPurchPrice.ReadOnly = True
        Me.txtPurchPrice.Size = New System.Drawing.Size(94, 22)
        Me.txtPurchPrice.TabIndex = 90
        '
        'btnVirtualUnit
        '
        Me.btnVirtualUnit.Location = New System.Drawing.Point(297, 90)
        Me.btnVirtualUnit.Name = "btnVirtualUnit"
        Me.btnVirtualUnit.Size = New System.Drawing.Size(129, 31)
        Me.btnVirtualUnit.TabIndex = 89
        Me.btnVirtualUnit.Text = "وحدة افتراضية "
        Me.btnVirtualUnit.UseVisualStyleBackColor = True
        '
        'btnDeleteUnit
        '
        Me.btnDeleteUnit.Location = New System.Drawing.Point(297, 53)
        Me.btnDeleteUnit.Name = "btnDeleteUnit"
        Me.btnDeleteUnit.Size = New System.Drawing.Size(129, 31)
        Me.btnDeleteUnit.TabIndex = 88
        Me.btnDeleteUnit.Text = "حذف"
        Me.btnDeleteUnit.UseVisualStyleBackColor = True
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Location = New System.Drawing.Point(297, 16)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(129, 31)
        Me.btnAddUnit.TabIndex = 87
        Me.btnAddUnit.Text = "اضافة "
        Me.btnAddUnit.UseVisualStyleBackColor = True
        '
        'dgvUnits
        '
        Me.dgvUnits.AllowUserToAddRows = False
        Me.dgvUnits.AllowUserToDeleteRows = False
        Me.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvUnits.Location = New System.Drawing.Point(25, 16)
        Me.dgvUnits.Name = "dgvUnits"
        Me.dgvUnits.ReadOnly = True
        Me.dgvUnits.Size = New System.Drawing.Size(266, 135)
        Me.dgvUnits.TabIndex = 86
        '
        'Column1
        '
        Me.Column1.FillWeight = 149.2386!
        Me.Column1.HeaderText = "الوحدة "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 50.76142!
        Me.Column2.HeaderText = "تعادل"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(572, 216)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 15)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "الارتفاع/الوحدة"
        '
        'txtHigh
        '
        Me.txtHigh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtHigh.Location = New System.Drawing.Point(442, 213)
        Me.txtHigh.Name = "txtHigh"
        Me.txtHigh.Size = New System.Drawing.Size(124, 22)
        Me.txtHigh.TabIndex = 84
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(572, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 15)
        Me.Label21.TabIndex = 83
        Me.Label21.Text = "العرض/الوحدة :"
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtWidth.Location = New System.Drawing.Point(442, 185)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(124, 22)
        Me.txtWidth.TabIndex = 82
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(572, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 15)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "الطول/الوحدة :"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtHeight.Location = New System.Drawing.Point(442, 157)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(124, 22)
        Me.txtHeight.TabIndex = 80
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(572, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 15)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "الحجم/الوحدة :"
        '
        'txtSizeUnit
        '
        Me.txtSizeUnit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSizeUnit.Location = New System.Drawing.Point(442, 129)
        Me.txtSizeUnit.Name = "txtSizeUnit"
        Me.txtSizeUnit.Size = New System.Drawing.Size(124, 22)
        Me.txtSizeUnit.TabIndex = 78
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(572, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 15)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "الوزن/الوحدة :"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.Location = New System.Drawing.Point(442, 101)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(124, 22)
        Me.txtWeight.TabIndex = 76
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(572, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 15)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "اللون :"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtColor.Location = New System.Drawing.Point(442, 72)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(124, 22)
        Me.txtColor.TabIndex = 74
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(572, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "نوع المادة :"
        '
        'cmbItemType
        '
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(442, 241)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(124, 21)
        Me.cmbItemType.TabIndex = 72
        '
        'cbStopEditPrice
        '
        Me.cbStopEditPrice.AutoSize = True
        Me.cbStopEditPrice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbStopEditPrice.Location = New System.Drawing.Point(689, 431)
        Me.cbStopEditPrice.Name = "cbStopEditPrice"
        Me.cbStopEditPrice.Size = New System.Drawing.Size(98, 19)
        Me.cbStopEditPrice.TabIndex = 71
        Me.cbStopEditPrice.Text = "منع تعديل السعر "
        Me.cbStopEditPrice.UseVisualStyleBackColor = True
        '
        'cbStopSelling
        '
        Me.cbStopSelling.AutoSize = True
        Me.cbStopSelling.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbStopSelling.Location = New System.Drawing.Point(711, 406)
        Me.cbStopSelling.Name = "cbStopSelling"
        Me.cbStopSelling.Size = New System.Drawing.Size(76, 19)
        Me.cbStopSelling.TabIndex = 70
        Me.cbStopSelling.Text = "ايقاف البيع "
        Me.cbStopSelling.UseVisualStyleBackColor = True
        '
        'cbPreventingNegativeWithdrawals
        '
        Me.cbPreventingNegativeWithdrawals.AutoSize = True
        Me.cbPreventingNegativeWithdrawals.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbPreventingNegativeWithdrawals.Location = New System.Drawing.Point(676, 381)
        Me.cbPreventingNegativeWithdrawals.Name = "cbPreventingNegativeWithdrawals"
        Me.cbPreventingNegativeWithdrawals.Size = New System.Drawing.Size(111, 19)
        Me.cbPreventingNegativeWithdrawals.TabIndex = 69
        Me.cbPreventingNegativeWithdrawals.Text = "منع السحب بالسالب "
        Me.cbPreventingNegativeWithdrawals.UseVisualStyleBackColor = True
        '
        'cbCheckExpiryDate
        '
        Me.cbCheckExpiryDate.AutoSize = True
        Me.cbCheckExpiryDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbCheckExpiryDate.Location = New System.Drawing.Point(665, 356)
        Me.cbCheckExpiryDate.Name = "cbCheckExpiryDate"
        Me.cbCheckExpiryDate.Size = New System.Drawing.Size(122, 19)
        Me.cbCheckExpiryDate.TabIndex = 68
        Me.cbCheckExpiryDate.Text = "تدقيق تاريخ الصلاحية "
        Me.cbCheckExpiryDate.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(793, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 15)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "ملاحظة : "
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNote.Location = New System.Drawing.Point(663, 262)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(124, 88)
        Me.txtNote.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(793, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "مركز التكلفة :"
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.FormattingEnabled = True
        Me.cmbCostCenter.Location = New System.Drawing.Point(663, 235)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(124, 21)
        Me.cmbCostCenter.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(793, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 15)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "احتساب الكلفة :"
        '
        'cmbCostCalc
        '
        Me.cmbCostCalc.FormattingEnabled = True
        Me.cmbCostCalc.Location = New System.Drawing.Point(663, 208)
        Me.cmbCostCalc.Name = "cmbCostCalc"
        Me.cmbCostCalc.Size = New System.Drawing.Size(124, 21)
        Me.cmbCostCalc.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(793, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "المستودع :"
        '
        'cmbWarehouse
        '
        Me.cmbWarehouse.FormattingEnabled = True
        Me.cmbWarehouse.Location = New System.Drawing.Point(663, 181)
        Me.cmbWarehouse.Name = "cmbWarehouse"
        Me.cmbWarehouse.Size = New System.Drawing.Size(124, 21)
        Me.cmbWarehouse.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(793, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "المجموعة :"
        '
        'cmbGroups
        '
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.Location = New System.Drawing.Point(663, 154)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(124, 21)
        Me.cmbGroups.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(793, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "المورد/اخر شراء :"
        '
        'cmbLastSupplier
        '
        Me.cmbLastSupplier.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbLastSupplier.Location = New System.Drawing.Point(663, 126)
        Me.cmbLastSupplier.Name = "cmbLastSupplier"
        Me.cmbLastSupplier.ReadOnly = True
        Me.cmbLastSupplier.Size = New System.Drawing.Size(124, 22)
        Me.cmbLastSupplier.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(793, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "المورد :"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(663, 99)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(124, 21)
        Me.cmbSupplier.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "القياس/الوحدة :"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtMeasurement.Location = New System.Drawing.Point(442, 44)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(124, 22)
        Me.txtMeasurement.TabIndex = 52
        '
        'cmbCompanyMother
        '
        Me.cmbCompanyMother.FormattingEnabled = True
        Me.cmbCompanyMother.Location = New System.Drawing.Point(663, 72)
        Me.cmbCompanyMother.Name = "cmbCompanyMother"
        Me.cmbCompanyMother.Size = New System.Drawing.Size(124, 21)
        Me.cmbCompanyMother.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(793, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "المصدر :"
        '
        'txtSource
        '
        Me.txtSource.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSource.Location = New System.Drawing.Point(663, 44)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(124, 22)
        Me.txtSource.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(793, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "المواصفات :"
        '
        'txtSpecifications
        '
        Me.txtSpecifications.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSpecifications.Location = New System.Drawing.Point(442, 16)
        Me.txtSpecifications.Name = "txtSpecifications"
        Me.txtSpecifications.Size = New System.Drawing.Size(345, 22)
        Me.txtSpecifications.TabIndex = 46
        '
        'TabAlternativeBarcode
        '
        Me.TabAlternativeBarcode.BackColor = System.Drawing.SystemColors.Control
        Me.TabAlternativeBarcode.Controls.Add(Me.dgvBarcode)
        Me.TabAlternativeBarcode.Controls.Add(Me.dgvUnit)
        Me.TabAlternativeBarcode.Location = New System.Drawing.Point(4, 22)
        Me.TabAlternativeBarcode.Name = "TabAlternativeBarcode"
        Me.TabAlternativeBarcode.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlternativeBarcode.Size = New System.Drawing.Size(902, 469)
        Me.TabAlternativeBarcode.TabIndex = 1
        Me.TabAlternativeBarcode.Text = "الباركود البديل"
        '
        'dgvBarcode
        '
        Me.dgvBarcode.AllowUserToAddRows = False
        Me.dgvBarcode.AllowUserToDeleteRows = False
        Me.dgvBarcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBarcode.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7})
        Me.dgvBarcode.Location = New System.Drawing.Point(6, 6)
        Me.dgvBarcode.Name = "dgvBarcode"
        Me.dgvBarcode.ReadOnly = True
        Me.dgvBarcode.Size = New System.Drawing.Size(644, 457)
        Me.dgvBarcode.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.FillWeight = 5.0!
        Me.Column5.HeaderText = "#"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 25.0!
        Me.Column6.HeaderText = "الباركود "
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 20.0!
        Me.Column7.HeaderText = "التشفير"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'dgvUnit
        '
        Me.dgvUnit.AllowUserToAddRows = False
        Me.dgvUnit.AllowUserToDeleteRows = False
        Me.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4})
        Me.dgvUnit.Location = New System.Drawing.Point(656, 6)
        Me.dgvUnit.Name = "dgvUnit"
        Me.dgvUnit.ReadOnly = True
        Me.dgvUnit.Size = New System.Drawing.Size(240, 457)
        Me.dgvUnit.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.HeaderText = "#"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "الوحدة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'TabCompositeMaterial
        '
        Me.TabCompositeMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.TabCompositeMaterial.Controls.Add(Me.btnAddToCompositeMaterial)
        Me.TabCompositeMaterial.Controls.Add(Me.txtSearchCompositeMaterial)
        Me.TabCompositeMaterial.Controls.Add(Me.dgvCompositeMaterial)
        Me.TabCompositeMaterial.Location = New System.Drawing.Point(4, 22)
        Me.TabCompositeMaterial.Name = "TabCompositeMaterial"
        Me.TabCompositeMaterial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCompositeMaterial.Size = New System.Drawing.Size(902, 469)
        Me.TabCompositeMaterial.TabIndex = 2
        Me.TabCompositeMaterial.Text = "المادة او الخدمة المركبة"
        '
        'btnAddToCompositeMaterial
        '
        Me.btnAddToCompositeMaterial.Location = New System.Drawing.Point(6, 6)
        Me.btnAddToCompositeMaterial.Name = "btnAddToCompositeMaterial"
        Me.btnAddToCompositeMaterial.Size = New System.Drawing.Size(123, 22)
        Me.btnAddToCompositeMaterial.TabIndex = 136
        Me.btnAddToCompositeMaterial.Text = "اضافة "
        Me.btnAddToCompositeMaterial.UseVisualStyleBackColor = True
        '
        'txtSearchCompositeMaterial
        '
        Me.txtSearchCompositeMaterial.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSearchCompositeMaterial.Location = New System.Drawing.Point(135, 6)
        Me.txtSearchCompositeMaterial.Name = "txtSearchCompositeMaterial"
        Me.txtSearchCompositeMaterial.Size = New System.Drawing.Size(761, 22)
        Me.txtSearchCompositeMaterial.TabIndex = 135
        '
        'dgvCompositeMaterial
        '
        Me.dgvCompositeMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompositeMaterial.Location = New System.Drawing.Point(6, 34)
        Me.dgvCompositeMaterial.Name = "dgvCompositeMaterial"
        Me.dgvCompositeMaterial.Size = New System.Drawing.Size(890, 429)
        Me.dgvCompositeMaterial.TabIndex = 0
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(869, 92)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(24, 22)
        Me.btnLast.TabIndex = 130
        Me.btnLast.Text = "--"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(839, 92)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(24, 22)
        Me.btnPrevious.TabIndex = 131
        Me.btnPrevious.Text = "--"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(757, 92)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 22)
        Me.btnNext.TabIndex = 132
        Me.btnNext.Text = "--"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(727, 92)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(24, 22)
        Me.btnFirst.TabIndex = 133
        Me.btnFirst.Text = "--"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(693, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(225, 22)
        Me.txtSearch.TabIndex = 134
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(663, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 22)
        Me.btnSearch.TabIndex = 135
        Me.btnSearch.Text = "--"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmAddItemsServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 730)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbIsActive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemLatin)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddItemsServices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اضافة مادة / خدمة "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.TabGeneral.PerformLayout()
        CType(Me.dgvUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlternativeBarcode.ResumeLayout(False)
        CType(Me.dgvBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCompositeMaterial.ResumeLayout(False)
        Me.TabCompositeMaterial.PerformLayout()
        CType(Me.dgvCompositeMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BGW_Save As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents BGW_Delete As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Edit As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtItemLatin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbIsActive As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabGeneral As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbCostCenter As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbCostCalc As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbWarehouse As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbLastSupplier As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMeasurement As TextBox
    Friend WithEvents cmbCompanyMother As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSpecifications As TextBox
    Friend WithEvents TabAlternativeBarcode As TabPage
    Friend WithEvents Label44 As Label
    Friend WithEvents cmbCalcuMethod As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtPerc As TextBox
    Friend WithEvents btnCreateBarcode As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtSixthProfitPerc As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtSixthPrice As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtFifthProfitPerc As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtFifthPrice As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtFourthProfitPerc As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtThirdProfitPerce As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtSecondProfitPerc As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtFirstProfitPerc As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtLastCostPrice As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtLastPurchPrice As TextBox
    Friend WithEvents cmbUnitType As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtUnitEqu As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtFourthPrice As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtThirdPrice As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSecondPrice As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtFirstPrice As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtPurchPrice As TextBox
    Friend WithEvents btnVirtualUnit As Button
    Friend WithEvents btnDeleteUnit As Button
    Friend WithEvents btnAddUnit As Button
    Friend WithEvents dgvUnits As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents txtHigh As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtSizeUnit As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents cbStopEditPrice As CheckBox
    Friend WithEvents cbStopSelling As CheckBox
    Friend WithEvents cbPreventingNegativeWithdrawals As CheckBox
    Friend WithEvents cbCheckExpiryDate As CheckBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvBarcode As DataGridView
    Friend WithEvents dgvUnit As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label45 As Label
    Friend WithEvents TabCompositeMaterial As TabPage
    Friend WithEvents btnAddToCompositeMaterial As Button
    Friend WithEvents txtSearchCompositeMaterial As TextBox
    Friend WithEvents dgvCompositeMaterial As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrintBarcode As Button
    Friend WithEvents btnMovementOfItem As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
