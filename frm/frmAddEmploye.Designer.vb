<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmploye
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmploye))
        Me.TabIdentity = New System.Windows.Forms.TabControl()
        Me.TabAddress = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPhone1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.txtZone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpObtainingDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtObtainingPlace = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPlaceBirth = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPlaceAndNumberRegistration = New System.Windows.Forms.TextBox()
        Me.TabPassport = New System.Windows.Forms.TabPage()
        Me.dtpResidencyExpiry = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtResidencyPlace = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtResidencyNum = New System.Windows.Forms.TextBox()
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtEntryPlace = New System.Windows.Forms.TextBox()
        Me.dtpExpiryPassportDate = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtpObtainingPassportDate = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPassportGetPlace = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPassportID = New System.Windows.Forms.TextBox()
        Me.TabVacations = New System.Windows.Forms.TabPage()
        Me.TabFamily = New System.Windows.Forms.TabPage()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtFamilyNum = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtMotherName = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.TabPhoto = New System.Windows.Forms.TabPage()
        Me.btnDeletePic = New System.Windows.Forms.Button()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabClinicsServices = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TabOnline = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_Save = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Edit = New System.ComponentModel.BackgroundWorker()
        Me.BGW_Delete = New System.ComponentModel.BackgroundWorker()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BGW_Load = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.hgh = New System.Windows.Forms.Label()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خياراتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSpecialization = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbIsActive = New System.Windows.Forms.CheckBox()
        Me.txtEmployeID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbNationality = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAdministrative = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbJobTitle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAdjective = New System.Windows.Forms.ComboBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGrandFather = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFather = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabIdentity.SuspendLayout()
        Me.TabAddress.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPassport.SuspendLayout()
        Me.TabFamily.SuspendLayout()
        Me.TabPhoto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabClinicsServices.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabIdentity
        '
        Me.TabIdentity.Controls.Add(Me.TabAddress)
        Me.TabIdentity.Controls.Add(Me.TabPage1)
        Me.TabIdentity.Controls.Add(Me.TabPassport)
        Me.TabIdentity.Controls.Add(Me.TabVacations)
        Me.TabIdentity.Controls.Add(Me.TabFamily)
        Me.TabIdentity.Controls.Add(Me.TabPhoto)
        Me.TabIdentity.Controls.Add(Me.TabClinicsServices)
        Me.TabIdentity.Controls.Add(Me.TabOnline)
        Me.TabIdentity.Location = New System.Drawing.Point(335, 40)
        Me.TabIdentity.Multiline = True
        Me.TabIdentity.Name = "TabIdentity"
        Me.TabIdentity.RightToLeftLayout = True
        Me.TabIdentity.SelectedIndex = 0
        Me.TabIdentity.Size = New System.Drawing.Size(427, 361)
        Me.TabIdentity.TabIndex = 0
        '
        'TabAddress
        '
        Me.TabAddress.BackColor = System.Drawing.SystemColors.Control
        Me.TabAddress.Controls.Add(Me.Label17)
        Me.TabAddress.Controls.Add(Me.txtNote)
        Me.TabAddress.Controls.Add(Me.Label16)
        Me.TabAddress.Controls.Add(Me.txtEmail)
        Me.TabAddress.Controls.Add(Me.Label15)
        Me.TabAddress.Controls.Add(Me.txtPhone2)
        Me.TabAddress.Controls.Add(Me.Label14)
        Me.TabAddress.Controls.Add(Me.txtPhone1)
        Me.TabAddress.Controls.Add(Me.Label13)
        Me.TabAddress.Controls.Add(Me.txtAddress)
        Me.TabAddress.Controls.Add(Me.Label12)
        Me.TabAddress.Controls.Add(Me.cmbCity)
        Me.TabAddress.Controls.Add(Me.txtZone)
        Me.TabAddress.Controls.Add(Me.Label11)
        Me.TabAddress.Location = New System.Drawing.Point(4, 22)
        Me.TabAddress.Name = "TabAddress"
        Me.TabAddress.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAddress.Size = New System.Drawing.Size(419, 335)
        Me.TabAddress.TabIndex = 1
        Me.TabAddress.Text = "العنوان"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(337, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "ملاحظة :"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNote.Location = New System.Drawing.Point(19, 186)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(312, 115)
        Me.txtNote.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(337, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 15)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "بريد الكتروني :"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.Location = New System.Drawing.Point(19, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(312, 22)
        Me.txtEmail.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(337, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "هاتف :"
        '
        'txtPhone2
        '
        Me.txtPhone2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPhone2.Location = New System.Drawing.Point(19, 130)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(312, 22)
        Me.txtPhone2.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(337, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "هاتف :"
        '
        'txtPhone1
        '
        Me.txtPhone1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPhone1.Location = New System.Drawing.Point(19, 102)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(312, 22)
        Me.txtPhone1.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(337, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "العنوان :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.Location = New System.Drawing.Point(19, 74)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(312, 22)
        Me.txtAddress.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(337, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "المنطقة :"
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(19, 19)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(312, 21)
        Me.cmbCity.TabIndex = 21
        '
        'txtZone
        '
        Me.txtZone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtZone.Location = New System.Drawing.Point(19, 46)
        Me.txtZone.Name = "txtZone"
        Me.txtZone.Size = New System.Drawing.Size(312, 22)
        Me.txtZone.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(337, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "المدينة :"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.dtpObtainingDate)
        Me.TabPage1.Controls.Add(Me.dtpDateBirth)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.txtObtainingPlace)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtIDNumber)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtCardNumber)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtPlaceBirth)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txtPlaceAndNumberRegistration)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(419, 335)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "الهوية"
        '
        'dtpObtainingDate
        '
        Me.dtpObtainingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpObtainingDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpObtainingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpObtainingDate.Location = New System.Drawing.Point(204, 159)
        Me.dtpObtainingDate.Name = "dtpObtainingDate"
        Me.dtpObtainingDate.RightToLeftLayout = True
        Me.dtpObtainingDate.Size = New System.Drawing.Size(116, 22)
        Me.dtpObtainingDate.TabIndex = 46
        '
        'dtpDateBirth
        '
        Me.dtpDateBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDateBirth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateBirth.Location = New System.Drawing.Point(204, 75)
        Me.dtpDateBirth.Name = "dtpDateBirth"
        Me.dtpDateBirth.RightToLeftLayout = True
        Me.dtpDateBirth.Size = New System.Drawing.Size(116, 22)
        Me.dtpDateBirth.TabIndex = 45
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(326, 190)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 15)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "مكان الحصول :"
        '
        'txtObtainingPlace
        '
        Me.txtObtainingPlace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtObtainingPlace.Location = New System.Drawing.Point(20, 187)
        Me.txtObtainingPlace.Name = "txtObtainingPlace"
        Me.txtObtainingPlace.Size = New System.Drawing.Size(300, 22)
        Me.txtObtainingPlace.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(326, 162)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 15)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "تاريخ الحصول :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(326, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 15)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "الرقم الوطني :"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtIDNumber.Location = New System.Drawing.Point(20, 131)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(300, 22)
        Me.txtIDNumber.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(326, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "رقم البطاقة :"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCardNumber.Location = New System.Drawing.Point(20, 103)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(300, 22)
        Me.txtCardNumber.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(326, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 15)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "تاريخ الولادة :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(326, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 15)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "مكان الولادة :"
        '
        'txtPlaceBirth
        '
        Me.txtPlaceBirth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPlaceBirth.Location = New System.Drawing.Point(20, 47)
        Me.txtPlaceBirth.Name = "txtPlaceBirth"
        Me.txtPlaceBirth.Size = New System.Drawing.Size(300, 22)
        Me.txtPlaceBirth.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(326, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 15)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "محل و رقم القيد :"
        '
        'txtPlaceAndNumberRegistration
        '
        Me.txtPlaceAndNumberRegistration.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPlaceAndNumberRegistration.Location = New System.Drawing.Point(20, 19)
        Me.txtPlaceAndNumberRegistration.Name = "txtPlaceAndNumberRegistration"
        Me.txtPlaceAndNumberRegistration.Size = New System.Drawing.Size(300, 22)
        Me.txtPlaceAndNumberRegistration.TabIndex = 31
        '
        'TabPassport
        '
        Me.TabPassport.BackColor = System.Drawing.SystemColors.Control
        Me.TabPassport.Controls.Add(Me.dtpResidencyExpiry)
        Me.TabPassport.Controls.Add(Me.Label33)
        Me.TabPassport.Controls.Add(Me.Label32)
        Me.TabPassport.Controls.Add(Me.txtResidencyPlace)
        Me.TabPassport.Controls.Add(Me.Label31)
        Me.TabPassport.Controls.Add(Me.txtResidencyNum)
        Me.TabPassport.Controls.Add(Me.dtpEntryDate)
        Me.TabPassport.Controls.Add(Me.Label30)
        Me.TabPassport.Controls.Add(Me.Label29)
        Me.TabPassport.Controls.Add(Me.txtEntryPlace)
        Me.TabPassport.Controls.Add(Me.dtpExpiryPassportDate)
        Me.TabPassport.Controls.Add(Me.Label28)
        Me.TabPassport.Controls.Add(Me.dtpObtainingPassportDate)
        Me.TabPassport.Controls.Add(Me.Label25)
        Me.TabPassport.Controls.Add(Me.Label26)
        Me.TabPassport.Controls.Add(Me.txtPassportGetPlace)
        Me.TabPassport.Controls.Add(Me.Label27)
        Me.TabPassport.Controls.Add(Me.txtPassportID)
        Me.TabPassport.Location = New System.Drawing.Point(4, 22)
        Me.TabPassport.Name = "TabPassport"
        Me.TabPassport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPassport.Size = New System.Drawing.Size(419, 335)
        Me.TabPassport.TabIndex = 3
        Me.TabPassport.Text = "جواز السفر "
        '
        'dtpResidencyExpiry
        '
        Me.dtpResidencyExpiry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpResidencyExpiry.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpResidencyExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpResidencyExpiry.Location = New System.Drawing.Point(178, 243)
        Me.dtpResidencyExpiry.Name = "dtpResidencyExpiry"
        Me.dtpResidencyExpiry.RightToLeftLayout = True
        Me.dtpResidencyExpiry.Size = New System.Drawing.Size(134, 22)
        Me.dtpResidencyExpiry.TabIndex = 63
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(318, 246)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 15)
        Me.Label33.TabIndex = 62
        Me.Label33.Text = "تاريخ انتهاء الاقامة :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(318, 218)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 15)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "مكان الاقامة :"
        '
        'txtResidencyPlace
        '
        Me.txtResidencyPlace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtResidencyPlace.Location = New System.Drawing.Point(16, 215)
        Me.txtResidencyPlace.Name = "txtResidencyPlace"
        Me.txtResidencyPlace.Size = New System.Drawing.Size(296, 22)
        Me.txtResidencyPlace.TabIndex = 60
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(318, 190)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(58, 15)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "رقم الاقامة :"
        '
        'txtResidencyNum
        '
        Me.txtResidencyNum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtResidencyNum.Location = New System.Drawing.Point(16, 187)
        Me.txtResidencyNum.Name = "txtResidencyNum"
        Me.txtResidencyNum.Size = New System.Drawing.Size(296, 22)
        Me.txtResidencyNum.TabIndex = 58
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEntryDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntryDate.Location = New System.Drawing.Point(178, 159)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.RightToLeftLayout = True
        Me.dtpEntryDate.Size = New System.Drawing.Size(134, 22)
        Me.dtpEntryDate.TabIndex = 57
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(318, 162)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 15)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "تاريخ الدخول :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(318, 134)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 15)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "مكان الدخول :"
        '
        'txtEntryPlace
        '
        Me.txtEntryPlace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtEntryPlace.Location = New System.Drawing.Point(16, 131)
        Me.txtEntryPlace.Name = "txtEntryPlace"
        Me.txtEntryPlace.Size = New System.Drawing.Size(296, 22)
        Me.txtEntryPlace.TabIndex = 54
        '
        'dtpExpiryPassportDate
        '
        Me.dtpExpiryPassportDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpExpiryPassportDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpExpiryPassportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpiryPassportDate.Location = New System.Drawing.Point(178, 103)
        Me.dtpExpiryPassportDate.Name = "dtpExpiryPassportDate"
        Me.dtpExpiryPassportDate.RightToLeftLayout = True
        Me.dtpExpiryPassportDate.Size = New System.Drawing.Size(134, 22)
        Me.dtpExpiryPassportDate.TabIndex = 53
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(318, 106)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 15)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "تاريخ الانتهاء :"
        '
        'dtpObtainingPassportDate
        '
        Me.dtpObtainingPassportDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpObtainingPassportDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtpObtainingPassportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpObtainingPassportDate.Location = New System.Drawing.Point(178, 75)
        Me.dtpObtainingPassportDate.Name = "dtpObtainingPassportDate"
        Me.dtpObtainingPassportDate.RightToLeftLayout = True
        Me.dtpObtainingPassportDate.Size = New System.Drawing.Size(134, 22)
        Me.dtpObtainingPassportDate.TabIndex = 51
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(318, 78)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 15)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "تاريخ الاصدار :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(318, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 15)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "مكان الاصدار :"
        '
        'txtPassportGetPlace
        '
        Me.txtPassportGetPlace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPassportGetPlace.Location = New System.Drawing.Point(16, 47)
        Me.txtPassportGetPlace.Name = "txtPassportGetPlace"
        Me.txtPassportGetPlace.Size = New System.Drawing.Size(296, 22)
        Me.txtPassportGetPlace.TabIndex = 48
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(318, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 15)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "رقم الجواز :"
        '
        'txtPassportID
        '
        Me.txtPassportID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPassportID.Location = New System.Drawing.Point(16, 19)
        Me.txtPassportID.Name = "txtPassportID"
        Me.txtPassportID.Size = New System.Drawing.Size(296, 22)
        Me.txtPassportID.TabIndex = 46
        '
        'TabVacations
        '
        Me.TabVacations.BackColor = System.Drawing.SystemColors.Control
        Me.TabVacations.Location = New System.Drawing.Point(4, 22)
        Me.TabVacations.Name = "TabVacations"
        Me.TabVacations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVacations.Size = New System.Drawing.Size(419, 335)
        Me.TabVacations.TabIndex = 4
        Me.TabVacations.Text = "الاجازات"
        '
        'TabFamily
        '
        Me.TabFamily.BackColor = System.Drawing.SystemColors.Control
        Me.TabFamily.Controls.Add(Me.ComboBox5)
        Me.TabFamily.Controls.Add(Me.Label42)
        Me.TabFamily.Controls.Add(Me.Label36)
        Me.TabFamily.Controls.Add(Me.txtFamilyNum)
        Me.TabFamily.Controls.Add(Me.Label34)
        Me.TabFamily.Controls.Add(Me.txtMotherName)
        Me.TabFamily.Controls.Add(Me.Label35)
        Me.TabFamily.Controls.Add(Me.txtFatherName)
        Me.TabFamily.Location = New System.Drawing.Point(4, 22)
        Me.TabFamily.Name = "TabFamily"
        Me.TabFamily.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFamily.Size = New System.Drawing.Size(419, 335)
        Me.TabFamily.TabIndex = 5
        Me.TabFamily.Text = "عائلي"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(189, 76)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(132, 21)
        Me.ComboBox5.TabIndex = 57
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(327, 79)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(85, 15)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "الحالة الاجتماعية :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(102, 78)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(81, 15)
        Me.Label36.TabIndex = 55
        Me.Label36.Text = "عدد افراد العائلة :"
        '
        'txtFamilyNum
        '
        Me.txtFamilyNum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFamilyNum.Location = New System.Drawing.Point(23, 75)
        Me.txtFamilyNum.Name = "txtFamilyNum"
        Me.txtFamilyNum.Size = New System.Drawing.Size(73, 22)
        Me.txtFamilyNum.TabIndex = 54
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(327, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 15)
        Me.Label34.TabIndex = 53
        Me.Label34.Text = "اسم الام :"
        '
        'txtMotherName
        '
        Me.txtMotherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtMotherName.Location = New System.Drawing.Point(23, 47)
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.Size = New System.Drawing.Size(298, 22)
        Me.txtMotherName.TabIndex = 52
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(327, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(50, 15)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "اسم الاب :"
        '
        'txtFatherName
        '
        Me.txtFatherName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFatherName.Location = New System.Drawing.Point(23, 19)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(298, 22)
        Me.txtFatherName.TabIndex = 50
        '
        'TabPhoto
        '
        Me.TabPhoto.BackColor = System.Drawing.SystemColors.Control
        Me.TabPhoto.Controls.Add(Me.btnDeletePic)
        Me.TabPhoto.Controls.Add(Me.btnAddPic)
        Me.TabPhoto.Controls.Add(Me.PictureBox1)
        Me.TabPhoto.Location = New System.Drawing.Point(4, 22)
        Me.TabPhoto.Name = "TabPhoto"
        Me.TabPhoto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPhoto.Size = New System.Drawing.Size(419, 335)
        Me.TabPhoto.TabIndex = 6
        Me.TabPhoto.Text = "الصورة "
        '
        'btnDeletePic
        '
        Me.btnDeletePic.Location = New System.Drawing.Point(275, 47)
        Me.btnDeletePic.Name = "btnDeletePic"
        Me.btnDeletePic.Size = New System.Drawing.Size(52, 26)
        Me.btnDeletePic.TabIndex = 3
        Me.btnDeletePic.Text = "حذف"
        Me.btnDeletePic.UseVisualStyleBackColor = True
        '
        'btnAddPic
        '
        Me.btnAddPic.Location = New System.Drawing.Point(275, 16)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(52, 26)
        Me.btnAddPic.TabIndex = 2
        Me.btnAddPic.Text = "جديد"
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(46, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 274)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabClinicsServices
        '
        Me.TabClinicsServices.BackColor = System.Drawing.SystemColors.Control
        Me.TabClinicsServices.Controls.Add(Me.TextBox4)
        Me.TabClinicsServices.Controls.Add(Me.ComboBox4)
        Me.TabClinicsServices.Controls.Add(Me.Label41)
        Me.TabClinicsServices.Controls.Add(Me.TextBox3)
        Me.TabClinicsServices.Controls.Add(Me.ComboBox3)
        Me.TabClinicsServices.Controls.Add(Me.Label40)
        Me.TabClinicsServices.Controls.Add(Me.TextBox2)
        Me.TabClinicsServices.Controls.Add(Me.TextBox1)
        Me.TabClinicsServices.Controls.Add(Me.ComboBox2)
        Me.TabClinicsServices.Controls.Add(Me.Label39)
        Me.TabClinicsServices.Controls.Add(Me.ComboBox1)
        Me.TabClinicsServices.Controls.Add(Me.Label38)
        Me.TabClinicsServices.Location = New System.Drawing.Point(4, 22)
        Me.TabClinicsServices.Name = "TabClinicsServices"
        Me.TabClinicsServices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabClinicsServices.Size = New System.Drawing.Size(419, 335)
        Me.TabClinicsServices.TabIndex = 7
        Me.TabClinicsServices.Text = " العيادات"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(256, 99)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(78, 22)
        Me.TextBox4.TabIndex = 38
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(15, 100)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox4.TabIndex = 37
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(340, 104)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(68, 15)
        Me.Label41.TabIndex = 36
        Me.Label41.Text = "مرور الايواء :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(256, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(78, 22)
        Me.TextBox3.TabIndex = 35
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(15, 73)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox3.TabIndex = 34
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(340, 77)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(43, 15)
        Me.Label40.TabIndex = 33
        Me.Label40.Text = "الكشف :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(256, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(78, 22)
        Me.TextBox2.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(256, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 22)
        Me.TextBox1.TabIndex = 31
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(15, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox2.TabIndex = 26
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(340, 50)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 15)
        Me.Label39.TabIndex = 25
        Me.Label39.Text = "الكشف :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(340, 22)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 15)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "العيادة :"
        '
        'TabOnline
        '
        Me.TabOnline.BackColor = System.Drawing.SystemColors.Control
        Me.TabOnline.Location = New System.Drawing.Point(4, 22)
        Me.TabOnline.Name = "TabOnline"
        Me.TabOnline.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOnline.Size = New System.Drawing.Size(419, 335)
        Me.TabOnline.TabIndex = 8
        Me.TabOnline.Text = "اونلاين"
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
        'PB
        '
        Me.PB.Margin = New System.Windows.Forms.Padding(120, 3, 1, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(100, 16)
        Me.PB.Step = 1
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'lblUsername
        '
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblDateTime, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(774, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(150, 3, 0, 2)
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
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(474, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 37)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(543, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 37)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BGW_Load
        '
        Me.BGW_Load.WorkerReportsProgress = True
        Me.BGW_Load.WorkerSupportsCancellation = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 70)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(612, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 37)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(681, 19)
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
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(6, 60)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 22)
        Me.txtName.TabIndex = 9
        '
        'hgh
        '
        Me.hgh.AutoSize = True
        Me.hgh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgh.Location = New System.Drawing.Point(222, 63)
        Me.hgh.Name = "hgh"
        Me.hgh.Size = New System.Drawing.Size(36, 15)
        Me.hgh.TabIndex = 8
        Me.hgh.Text = "الاسم :"
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        Me.خروجToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.خروجToolStripMenuItem.Text = "خروج"
        '
        'مساعدةToolStripMenuItem
        '
        Me.مساعدةToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 560, 0)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.خياراتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.خروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "الصفة :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSpecialization)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.cmbUser)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbIsActive)
        Me.GroupBox1.Controls.Add(Me.txtEmployeID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbNationality)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbAdministrative)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbJobTitle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbAdjective)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGrandFather)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFather)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.hgh)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 352)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'cmbSpecialization
        '
        Me.cmbSpecialization.FormattingEnabled = True
        Me.cmbSpecialization.Location = New System.Drawing.Point(6, 201)
        Me.cmbSpecialization.Name = "cmbSpecialization"
        Me.cmbSpecialization.Size = New System.Drawing.Size(210, 23)
        Me.cmbSpecialization.TabIndex = 35
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(222, 204)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 15)
        Me.Label37.TabIndex = 34
        Me.Label37.Text = "التخصص :"
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(6, 317)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(210, 23)
        Me.cmbUser.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "المستخدم :"
        '
        'cbIsActive
        '
        Me.cbIsActive.AutoSize = True
        Me.cbIsActive.Location = New System.Drawing.Point(26, 34)
        Me.cbIsActive.Name = "cbIsActive"
        Me.cbIsActive.Size = New System.Drawing.Size(45, 19)
        Me.cbIsActive.TabIndex = 31
        Me.cbIsActive.Text = "نشط"
        Me.cbIsActive.UseVisualStyleBackColor = True
        '
        'txtEmployeID
        '
        Me.txtEmployeID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtEmployeID.Location = New System.Drawing.Point(121, 32)
        Me.txtEmployeID.Name = "txtEmployeID"
        Me.txtEmployeID.Size = New System.Drawing.Size(95, 22)
        Me.txtEmployeID.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(222, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "الرقم الوظيفي :"
        '
        'cmbNationality
        '
        Me.cmbNationality.FormattingEnabled = True
        Me.cmbNationality.Location = New System.Drawing.Point(6, 288)
        Me.cmbNationality.Name = "cmbNationality"
        Me.cmbNationality.Size = New System.Drawing.Size(88, 23)
        Me.cmbNationality.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "الجنسية :"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(154, 288)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(62, 23)
        Me.cmbGender.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "الجنس :"
        '
        'cmbAdministrative
        '
        Me.cmbAdministrative.FormattingEnabled = True
        Me.cmbAdministrative.Location = New System.Drawing.Point(6, 259)
        Me.cmbAdministrative.Name = "cmbAdministrative"
        Me.cmbAdministrative.Size = New System.Drawing.Size(210, 23)
        Me.cmbAdministrative.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "الادارة :"
        '
        'cmbJobTitle
        '
        Me.cmbJobTitle.FormattingEnabled = True
        Me.cmbJobTitle.Location = New System.Drawing.Point(6, 230)
        Me.cmbJobTitle.Name = "cmbJobTitle"
        Me.cmbJobTitle.Size = New System.Drawing.Size(210, 23)
        Me.cmbJobTitle.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "المسمي الوظيفي :"
        '
        'cmbAdjective
        '
        Me.cmbAdjective.FormattingEnabled = True
        Me.cmbAdjective.Location = New System.Drawing.Point(6, 172)
        Me.cmbAdjective.Name = "cmbAdjective"
        Me.cmbAdjective.Size = New System.Drawing.Size(210, 23)
        Me.cmbAdjective.TabIndex = 20
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSurname.Location = New System.Drawing.Point(6, 144)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(210, 22)
        Me.txtSurname.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "اللقب :"
        '
        'txtGrandFather
        '
        Me.txtGrandFather.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGrandFather.Location = New System.Drawing.Point(6, 116)
        Me.txtGrandFather.Name = "txtGrandFather"
        Me.txtGrandFather.Size = New System.Drawing.Size(210, 22)
        Me.txtGrandFather.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "اسم الجد :"
        '
        'txtFather
        '
        Me.txtFather.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFather.Location = New System.Drawing.Point(6, 88)
        Me.txtFather.Name = "txtFather"
        Me.txtFather.Size = New System.Drawing.Size(210, 22)
        Me.txtFather.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "اسم الاب :"
        '
        'frmAddEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 506)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabIdentity)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddEmploye"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الموظف"
        Me.TabIdentity.ResumeLayout(False)
        Me.TabAddress.ResumeLayout(False)
        Me.TabAddress.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPassport.ResumeLayout(False)
        Me.TabPassport.PerformLayout()
        Me.TabFamily.ResumeLayout(False)
        Me.TabFamily.PerformLayout()
        Me.TabPhoto.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabClinicsServices.ResumeLayout(False)
        Me.TabClinicsServices.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabIdentity As TabControl
    Friend WithEvents TabAddress As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BGW_Save As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Edit As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_Delete As System.ComponentModel.BackgroundWorker
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblDateTime As ToolStripStatusLabel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BGW_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents hgh As Label
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents خياراتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbAdministrative As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbJobTitle As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbAdjective As ComboBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGrandFather As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFather As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPassport As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPhone2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhone1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents txtZone As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabVacations As TabPage
    Friend WithEvents TabFamily As TabPage
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbIsActive As CheckBox
    Friend WithEvents txtEmployeID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbNationality As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpObtainingDate As DateTimePicker
    Friend WithEvents dtpDateBirth As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents txtObtainingPlace As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPlaceBirth As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPlaceAndNumberRegistration As TextBox
    Friend WithEvents dtpResidencyExpiry As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtResidencyPlace As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtResidencyNum As TextBox
    Friend WithEvents dtpEntryDate As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEntryPlace As TextBox
    Friend WithEvents dtpExpiryPassportDate As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents dtpObtainingPassportDate As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPassportGetPlace As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtPassportID As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtFamilyNum As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtMotherName As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents TabPhoto As TabPage
    Friend WithEvents btnDeletePic As Button
    Friend WithEvents btnAddPic As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbSpecialization As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents TabClinicsServices As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TabOnline As TabPage
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label42 As Label
End Class
