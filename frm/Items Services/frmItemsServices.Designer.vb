<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemsServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemsServices))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnAddEmploye = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemLatin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranCompName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmsAddCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmsAddCate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmsAddItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompanyMother = New System.Windows.Forms.TextBox()
        Me.txtGroups = New System.Windows.Forms.TextBox()
        Me.txtWarehouse = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsAdd.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(90, 3, 1, 3)
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
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(250, 3, 0, 2)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel2, Me.lblDateTime, Me.ToolStripStatusLabel3, Me.lblCount, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(150, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel3.Text = "العدد : "
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(25, 17)
        Me.lblCount.Text = "000"
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
        Me.txtSearch.Location = New System.Drawing.Point(233, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(751, 29)
        Me.txtSearch.TabIndex = 8
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnAddEmploye
        '
        Me.btnAddEmploye.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddEmploye.Location = New System.Drawing.Point(650, 19)
        Me.btnAddEmploye.Name = "btnAddEmploye"
        Me.btnAddEmploye.Size = New System.Drawing.Size(94, 37)
        Me.btnAddEmploye.TabIndex = 2
        Me.btnAddEmploye.Text = "اضافة "
        Me.btnAddEmploye.UseVisualStyleBackColor = True
        '
        'btnClose
        '
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
        Me.GroupBox1.Controls.Add(Me.btnAddEmploye)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 555)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 70)
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
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.ItemCode, Me.ItemName, Me.ItemLatin, Me.WarehouseName, Me.BranCompName, Me.CategoryName, Me.ItemType, Me.PercDoctor, Me.AmountDoctor, Me.GroupItemName, Me.Price1, Me.Price2, Me.Price3, Me.Price4, Me.Price5, Me.Price6})
        Me.DGV.Location = New System.Drawing.Point(233, 72)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(750, 470)
        Me.DGV.TabIndex = 6
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "الرمز"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        '
        'ItemCode
        '
        Me.ItemCode.DataPropertyName = "ItemCode"
        Me.ItemCode.HeaderText = "كود المادة"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "اسم المادة"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemLatin
        '
        Me.ItemLatin.DataPropertyName = "ItemLatin"
        Me.ItemLatin.HeaderText = "الاسم لاتيني"
        Me.ItemLatin.Name = "ItemLatin"
        Me.ItemLatin.ReadOnly = True
        '
        'WarehouseName
        '
        Me.WarehouseName.DataPropertyName = "WarehouseName"
        Me.WarehouseName.HeaderText = "المستودع"
        Me.WarehouseName.Name = "WarehouseName"
        Me.WarehouseName.ReadOnly = True
        '
        'BranCompName
        '
        Me.BranCompName.DataPropertyName = "BranCompName"
        Me.BranCompName.HeaderText = "الشركة"
        Me.BranCompName.Name = "BranCompName"
        Me.BranCompName.ReadOnly = True
        '
        'CategoryName
        '
        Me.CategoryName.DataPropertyName = "CategoryName"
        Me.CategoryName.HeaderText = "الفئة"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        '
        'ItemType
        '
        Me.ItemType.DataPropertyName = "ItemType"
        Me.ItemType.HeaderText = "نوع المادة"
        Me.ItemType.Name = "ItemType"
        Me.ItemType.ReadOnly = True
        '
        'PercDoctor
        '
        Me.PercDoctor.DataPropertyName = "PercDoctor"
        Me.PercDoctor.HeaderText = "نسبة الطبيب"
        Me.PercDoctor.Name = "PercDoctor"
        Me.PercDoctor.ReadOnly = True
        '
        'AmountDoctor
        '
        Me.AmountDoctor.DataPropertyName = "AmountDoctor"
        Me.AmountDoctor.HeaderText = "حصة الطبيب"
        Me.AmountDoctor.Name = "AmountDoctor"
        Me.AmountDoctor.ReadOnly = True
        '
        'GroupItemName
        '
        Me.GroupItemName.DataPropertyName = "GroupItemName"
        Me.GroupItemName.HeaderText = "مجموعات المواد"
        Me.GroupItemName.Name = "GroupItemName"
        Me.GroupItemName.ReadOnly = True
        '
        'Price1
        '
        Me.Price1.DataPropertyName = "Price1"
        Me.Price1.HeaderText = "السعر الاول"
        Me.Price1.Name = "Price1"
        Me.Price1.ReadOnly = True
        '
        'Price2
        '
        Me.Price2.DataPropertyName = "Price2"
        Me.Price2.HeaderText = "السعر الثاني"
        Me.Price2.Name = "Price2"
        Me.Price2.ReadOnly = True
        '
        'Price3
        '
        Me.Price3.DataPropertyName = "Price3"
        Me.Price3.HeaderText = "السعر الثالث"
        Me.Price3.Name = "Price3"
        Me.Price3.ReadOnly = True
        '
        'Price4
        '
        Me.Price4.DataPropertyName = "Price4"
        Me.Price4.HeaderText = "السعر الرابع"
        Me.Price4.Name = "Price4"
        Me.Price4.ReadOnly = True
        '
        'Price5
        '
        Me.Price5.DataPropertyName = "Price5"
        Me.Price5.HeaderText = "السعر الخامس"
        Me.Price5.Name = "Price5"
        Me.Price5.ReadOnly = True
        '
        'Price6
        '
        Me.Price6.DataPropertyName = "Price6"
        Me.Price6.HeaderText = "السعر السادس"
        Me.Price6.Name = "Price6"
        Me.Price6.ReadOnly = True
        '
        'cmsAdd
        '
        Me.cmsAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmsAddCat, Me.tmsAddCate, Me.tmsAddItems})
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.Size = New System.Drawing.Size(161, 70)
        '
        'tmsAddCat
        '
        Me.tmsAddCat.Name = "tmsAddCat"
        Me.tmsAddCat.Size = New System.Drawing.Size(160, 22)
        Me.tmsAddCat.Text = "اضافة فئة رئيسية"
        '
        'tmsAddCate
        '
        Me.tmsAddCate.Name = "tmsAddCate"
        Me.tmsAddCate.Size = New System.Drawing.Size(160, 22)
        Me.tmsAddCate.Text = "اضافة فئة "
        '
        'tmsAddItems
        '
        Me.tmsAddItems.Name = "tmsAddItems"
        Me.tmsAddItems.Size = New System.Drawing.Size(160, 22)
        Me.tmsAddItems.Text = "اضافة مادة/خدمة"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCompanyMother)
        Me.GroupBox2.Controls.Add(Me.txtGroups)
        Me.GroupBox2.Controls.Add(Me.txtWarehouse)
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbItemType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 595)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بحث و فرز"
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.Location = New System.Drawing.Point(6, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(131, 20)
        Me.txtName.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(144, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "الاسم :"
        '
        'txtCompanyMother
        '
        Me.txtCompanyMother.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCompanyMother.Location = New System.Drawing.Point(6, 175)
        Me.txtCompanyMother.Name = "txtCompanyMother"
        Me.txtCompanyMother.Size = New System.Drawing.Size(131, 20)
        Me.txtCompanyMother.TabIndex = 17
        '
        'txtGroups
        '
        Me.txtGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGroups.Location = New System.Drawing.Point(6, 96)
        Me.txtGroups.Name = "txtGroups"
        Me.txtGroups.Size = New System.Drawing.Size(131, 20)
        Me.txtGroups.TabIndex = 16
        '
        'txtWarehouse
        '
        Me.txtWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtWarehouse.Location = New System.Drawing.Point(7, 149)
        Me.txtWarehouse.Name = "txtWarehouse"
        Me.txtWarehouse.Size = New System.Drawing.Size(131, 20)
        Me.txtWarehouse.TabIndex = 15
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCategory.Location = New System.Drawing.Point(6, 70)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(131, 20)
        Me.txtCategory.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "الشركة :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "المستودع :"
        '
        'cmbItemType
        '
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(6, 122)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(132, 21)
        Me.cmbItemType.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "نوع المادة :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "مجموعات :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "الفئة :"
        '
        'frmItemsServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 650)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmItemsServices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث المواد :"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsAdd.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnAddEmploye As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGV As DataGridView
    Friend WithEvents cmsAdd As ContextMenuStrip
    Friend WithEvents tmsAddCat As ToolStripMenuItem
    Friend WithEvents tmsAddCate As ToolStripMenuItem
    Friend WithEvents tmsAddItems As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblCount As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemLatin As DataGridViewTextBoxColumn
    Friend WithEvents WarehouseName As DataGridViewTextBoxColumn
    Friend WithEvents BranCompName As DataGridViewTextBoxColumn
    Friend WithEvents CategoryName As DataGridViewTextBoxColumn
    Friend WithEvents ItemType As DataGridViewTextBoxColumn
    Friend WithEvents PercDoctor As DataGridViewTextBoxColumn
    Friend WithEvents AmountDoctor As DataGridViewTextBoxColumn
    Friend WithEvents GroupItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price1 As DataGridViewTextBoxColumn
    Friend WithEvents Price2 As DataGridViewTextBoxColumn
    Friend WithEvents Price3 As DataGridViewTextBoxColumn
    Friend WithEvents Price4 As DataGridViewTextBoxColumn
    Friend WithEvents Price5 As DataGridViewTextBoxColumn
    Friend WithEvents Price6 As DataGridViewTextBoxColumn
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtWarehouse As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompanyMother As TextBox
    Friend WithEvents txtGroups As TextBox
End Class
