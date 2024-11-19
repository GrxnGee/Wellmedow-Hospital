<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient
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
        Dim PRF_IDLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim P_FNameLabel As System.Windows.Forms.Label
        Dim P_LNameLabel As System.Windows.Forms.Label
        Dim P_AddressLabel As System.Windows.Forms.Label
        Dim P_SexLabel As System.Windows.Forms.Label
        Dim P_TypeLabel As System.Windows.Forms.Label
        Dim P_BirthLabel As System.Windows.Forms.Label
        Dim P_TelLabel As System.Windows.Forms.Label
        Dim P_SymptomLabel As System.Windows.Forms.Label
        Dim Pr_IDLabel As System.Windows.Forms.Label
        Dim Pr_FNameLabel As System.Windows.Forms.Label
        Dim Pr_LNameLabel As System.Windows.Forms.Label
        Dim Pr_AddressLabel As System.Windows.Forms.Label
        Dim Pr_TelLabel As System.Windows.Forms.Label
        Dim Pr_RelationshipLabel As System.Windows.Forms.Label
        Dim L_IDLabel As System.Windows.Forms.Label
        Dim L_FNameLabel As System.Windows.Forms.Label
        Dim L_LNameLabel As System.Windows.Forms.Label
        Dim L_AddressLabel As System.Windows.Forms.Label
        Dim L_TelLabel As System.Windows.Forms.Label
        Dim L_ClinicIDLabel As System.Windows.Forms.Label
        Dim W_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital = New Wellmedow.Hospital()
        Me.PatientTableAdapter = New Wellmedow.HospitalTableAdapters.PatientTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.PatientReferralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientReferralTableAdapter = New Wellmedow.HospitalTableAdapters.PatientReferralTableAdapter()
        Me.PRF_IDTextBox = New System.Windows.Forms.TextBox()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.P_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.P_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.P_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.P_SexTextBox = New System.Windows.Forms.TextBox()
        Me.P_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.P_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_TelTextBox = New System.Windows.Forms.TextBox()
        Me.P_SymptomTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_TelTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.L_IDTextBox = New System.Windows.Forms.TextBox()
        Me.L_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.L_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.L_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.L_TelTextBox = New System.Windows.Forms.TextBox()
        Me.L_ClinicIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.W_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.PatientReferralDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        PRF_IDLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        P_FNameLabel = New System.Windows.Forms.Label()
        P_LNameLabel = New System.Windows.Forms.Label()
        P_AddressLabel = New System.Windows.Forms.Label()
        P_SexLabel = New System.Windows.Forms.Label()
        P_TypeLabel = New System.Windows.Forms.Label()
        P_BirthLabel = New System.Windows.Forms.Label()
        P_TelLabel = New System.Windows.Forms.Label()
        P_SymptomLabel = New System.Windows.Forms.Label()
        Pr_IDLabel = New System.Windows.Forms.Label()
        Pr_FNameLabel = New System.Windows.Forms.Label()
        Pr_LNameLabel = New System.Windows.Forms.Label()
        Pr_AddressLabel = New System.Windows.Forms.Label()
        Pr_TelLabel = New System.Windows.Forms.Label()
        Pr_RelationshipLabel = New System.Windows.Forms.Label()
        L_IDLabel = New System.Windows.Forms.Label()
        L_FNameLabel = New System.Windows.Forms.Label()
        L_LNameLabel = New System.Windows.Forms.Label()
        L_AddressLabel = New System.Windows.Forms.Label()
        L_TelLabel = New System.Windows.Forms.Label()
        L_ClinicIDLabel = New System.Windows.Forms.Label()
        W_NumberLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientReferralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientReferralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRF_IDLabel
        '
        PRF_IDLabel.AutoSize = True
        PRF_IDLabel.Location = New System.Drawing.Point(192, 121)
        PRF_IDLabel.Name = "PRF_IDLabel"
        PRF_IDLabel.Size = New System.Drawing.Size(45, 13)
        PRF_IDLabel.TabIndex = 6
        PRF_IDLabel.Text = "PRF ID:"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(192, 147)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(53, 13)
        P_IDLabel.TabIndex = 8
        P_IDLabel.Text = "รหัสผู้ป่วย"
        '
        'P_FNameLabel
        '
        P_FNameLabel.AutoSize = True
        P_FNameLabel.Location = New System.Drawing.Point(202, 173)
        P_FNameLabel.Name = "P_FNameLabel"
        P_FNameLabel.Size = New System.Drawing.Size(20, 13)
        P_FNameLabel.TabIndex = 10
        P_FNameLabel.Text = "ชื่อ"
        '
        'P_LNameLabel
        '
        P_LNameLabel.AutoSize = True
        P_LNameLabel.Location = New System.Drawing.Point(192, 199)
        P_LNameLabel.Name = "P_LNameLabel"
        P_LNameLabel.Size = New System.Drawing.Size(46, 13)
        P_LNameLabel.TabIndex = 12
        P_LNameLabel.Text = "นามสกุล"
        '
        'P_AddressLabel
        '
        P_AddressLabel.AutoSize = True
        P_AddressLabel.Location = New System.Drawing.Point(200, 228)
        P_AddressLabel.Name = "P_AddressLabel"
        P_AddressLabel.Size = New System.Drawing.Size(27, 13)
        P_AddressLabel.TabIndex = 14
        P_AddressLabel.Text = "ที่อยู่"
        '
        'P_SexLabel
        '
        P_SexLabel.AutoSize = True
        P_SexLabel.Location = New System.Drawing.Point(202, 251)
        P_SexLabel.Name = "P_SexLabel"
        P_SexLabel.Size = New System.Drawing.Size(28, 13)
        P_SexLabel.TabIndex = 16
        P_SexLabel.Text = "เพศ"
        '
        'P_TypeLabel
        '
        P_TypeLabel.AutoSize = True
        P_TypeLabel.Location = New System.Drawing.Point(184, 277)
        P_TypeLabel.Name = "P_TypeLabel"
        P_TypeLabel.Size = New System.Drawing.Size(71, 13)
        P_TypeLabel.TabIndex = 18
        P_TypeLabel.Text = "ประเภทผู้ป่วย"
        '
        'P_BirthLabel
        '
        P_BirthLabel.AutoSize = True
        P_BirthLabel.Location = New System.Drawing.Point(172, 306)
        P_BirthLabel.Name = "P_BirthLabel"
        P_BirthLabel.Size = New System.Drawing.Size(83, 13)
        P_BirthLabel.TabIndex = 20
        P_BirthLabel.Text = "วัน/เดือน/ปีเกิด"
        '
        'P_TelLabel
        '
        P_TelLabel.AutoSize = True
        P_TelLabel.Location = New System.Drawing.Point(192, 329)
        P_TelLabel.Name = "P_TelLabel"
        P_TelLabel.Size = New System.Drawing.Size(49, 13)
        P_TelLabel.TabIndex = 22
        P_TelLabel.Text = "เบอร์โทร"
        '
        'P_SymptomLabel
        '
        P_SymptomLabel.AutoSize = True
        P_SymptomLabel.Location = New System.Drawing.Point(200, 355)
        P_SymptomLabel.Name = "P_SymptomLabel"
        P_SymptomLabel.Size = New System.Drawing.Size(36, 13)
        P_SymptomLabel.TabIndex = 24
        P_SymptomLabel.Text = "อาการ"
        '
        'Pr_IDLabel
        '
        Pr_IDLabel.AutoSize = True
        Pr_IDLabel.Location = New System.Drawing.Point(446, 93)
        Pr_IDLabel.Name = "Pr_IDLabel"
        Pr_IDLabel.Size = New System.Drawing.Size(74, 13)
        Pr_IDLabel.TabIndex = 26
        Pr_IDLabel.Text = "รหัสญาติผู้ป่วย"
        '
        'Pr_FNameLabel
        '
        Pr_FNameLabel.AutoSize = True
        Pr_FNameLabel.Location = New System.Drawing.Point(551, 122)
        Pr_FNameLabel.Name = "Pr_FNameLabel"
        Pr_FNameLabel.Size = New System.Drawing.Size(20, 13)
        Pr_FNameLabel.TabIndex = 28
        Pr_FNameLabel.Text = "ชื่อ"
        '
        'Pr_LNameLabel
        '
        Pr_LNameLabel.AutoSize = True
        Pr_LNameLabel.Location = New System.Drawing.Point(537, 147)
        Pr_LNameLabel.Name = "Pr_LNameLabel"
        Pr_LNameLabel.Size = New System.Drawing.Size(46, 13)
        Pr_LNameLabel.TabIndex = 30
        Pr_LNameLabel.Text = "นามสกุล"
        '
        'Pr_AddressLabel
        '
        Pr_AddressLabel.AutoSize = True
        Pr_AddressLabel.Location = New System.Drawing.Point(547, 174)
        Pr_AddressLabel.Name = "Pr_AddressLabel"
        Pr_AddressLabel.Size = New System.Drawing.Size(27, 13)
        Pr_AddressLabel.TabIndex = 32
        Pr_AddressLabel.Text = "ที่อยู่"
        '
        'Pr_TelLabel
        '
        Pr_TelLabel.AutoSize = True
        Pr_TelLabel.Location = New System.Drawing.Point(537, 200)
        Pr_TelLabel.Name = "Pr_TelLabel"
        Pr_TelLabel.Size = New System.Drawing.Size(49, 13)
        Pr_TelLabel.TabIndex = 34
        Pr_TelLabel.Text = "เบอร์โทร"
        '
        'Pr_RelationshipLabel
        '
        Pr_RelationshipLabel.AutoSize = True
        Pr_RelationshipLabel.Location = New System.Drawing.Point(532, 225)
        Pr_RelationshipLabel.Name = "Pr_RelationshipLabel"
        Pr_RelationshipLabel.Size = New System.Drawing.Size(67, 13)
        Pr_RelationshipLabel.TabIndex = 36
        Pr_RelationshipLabel.Text = "ความสัมพันธ์"
        '
        'L_IDLabel
        '
        L_IDLabel.AutoSize = True
        L_IDLabel.Location = New System.Drawing.Point(517, 280)
        L_IDLabel.Name = "L_IDLabel"
        L_IDLabel.Size = New System.Drawing.Size(75, 13)
        L_IDLabel.TabIndex = 38
        L_IDLabel.Text = "รหัสหมอประจำ"
        '
        'L_FNameLabel
        '
        L_FNameLabel.AutoSize = True
        L_FNameLabel.Location = New System.Drawing.Point(540, 310)
        L_FNameLabel.Name = "L_FNameLabel"
        L_FNameLabel.Size = New System.Drawing.Size(20, 13)
        L_FNameLabel.TabIndex = 40
        L_FNameLabel.Text = "ชื่อ"
        '
        'L_LNameLabel
        '
        L_LNameLabel.AutoSize = True
        L_LNameLabel.Location = New System.Drawing.Point(525, 332)
        L_LNameLabel.Name = "L_LNameLabel"
        L_LNameLabel.Size = New System.Drawing.Size(46, 13)
        L_LNameLabel.TabIndex = 42
        L_LNameLabel.Text = "นามสกุล"
        '
        'L_AddressLabel
        '
        L_AddressLabel.AutoSize = True
        L_AddressLabel.Location = New System.Drawing.Point(536, 358)
        L_AddressLabel.Name = "L_AddressLabel"
        L_AddressLabel.Size = New System.Drawing.Size(27, 13)
        L_AddressLabel.TabIndex = 44
        L_AddressLabel.Text = "ที่อยู่"
        '
        'L_TelLabel
        '
        L_TelLabel.AutoSize = True
        L_TelLabel.Location = New System.Drawing.Point(525, 384)
        L_TelLabel.Name = "L_TelLabel"
        L_TelLabel.Size = New System.Drawing.Size(49, 13)
        L_TelLabel.TabIndex = 46
        L_TelLabel.Text = "เบอร์โทร"
        '
        'L_ClinicIDLabel
        '
        L_ClinicIDLabel.AutoSize = True
        L_ClinicIDLabel.Location = New System.Drawing.Point(525, 410)
        L_ClinicIDLabel.Name = "L_ClinicIDLabel"
        L_ClinicIDLabel.Size = New System.Drawing.Size(54, 13)
        L_ClinicIDLabel.TabIndex = 48
        L_ClinicIDLabel.Text = "รหัสคลินิค"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(185, 381)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 54
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.Location = New System.Drawing.Point(107, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 50)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "DELETE/EDIT"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 50)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelete, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(384, 468)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(208, 56)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(451, 439)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.Hospital
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientAllocateTableAdapter = Nothing
        Me.TableAdapterManager.PatientReferralTableAdapter = Nothing
        Me.TableAdapterManager.PatientRelativesTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'PatientReferralBindingSource
        '
        Me.PatientReferralBindingSource.DataMember = "PatientReferral"
        Me.PatientReferralBindingSource.DataSource = Me.Hospital
        '
        'PatientReferralTableAdapter
        '
        Me.PatientReferralTableAdapter.ClearBeforeFill = True
        '
        'PRF_IDTextBox
        '
        Me.PRF_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "PRF_ID", True))
        Me.PRF_IDTextBox.Location = New System.Drawing.Point(279, 118)
        Me.PRF_IDTextBox.Name = "PRF_IDTextBox"
        Me.PRF_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRF_IDTextBox.TabIndex = 7
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(279, 144)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 9
        '
        'P_FNameTextBox
        '
        Me.P_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_FName", True))
        Me.P_FNameTextBox.Location = New System.Drawing.Point(279, 170)
        Me.P_FNameTextBox.Name = "P_FNameTextBox"
        Me.P_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_FNameTextBox.TabIndex = 11
        '
        'P_LNameTextBox
        '
        Me.P_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_LName", True))
        Me.P_LNameTextBox.Location = New System.Drawing.Point(279, 196)
        Me.P_LNameTextBox.Name = "P_LNameTextBox"
        Me.P_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_LNameTextBox.TabIndex = 13
        '
        'P_AddressTextBox
        '
        Me.P_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Address", True))
        Me.P_AddressTextBox.Location = New System.Drawing.Point(279, 222)
        Me.P_AddressTextBox.Name = "P_AddressTextBox"
        Me.P_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_AddressTextBox.TabIndex = 15
        '
        'P_SexTextBox
        '
        Me.P_SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Sex", True))
        Me.P_SexTextBox.Location = New System.Drawing.Point(279, 248)
        Me.P_SexTextBox.Name = "P_SexTextBox"
        Me.P_SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SexTextBox.TabIndex = 17
        '
        'P_TypeTextBox
        '
        Me.P_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Type", True))
        Me.P_TypeTextBox.Location = New System.Drawing.Point(279, 274)
        Me.P_TypeTextBox.Name = "P_TypeTextBox"
        Me.P_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_TypeTextBox.TabIndex = 19
        '
        'P_BirthDateTimePicker
        '
        Me.P_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientReferralBindingSource, "P_Birth", True))
        Me.P_BirthDateTimePicker.Location = New System.Drawing.Point(279, 300)
        Me.P_BirthDateTimePicker.Name = "P_BirthDateTimePicker"
        Me.P_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.P_BirthDateTimePicker.TabIndex = 21
        '
        'P_TelTextBox
        '
        Me.P_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Tel", True))
        Me.P_TelTextBox.Location = New System.Drawing.Point(279, 326)
        Me.P_TelTextBox.Name = "P_TelTextBox"
        Me.P_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_TelTextBox.TabIndex = 23
        '
        'P_SymptomTextBox
        '
        Me.P_SymptomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Symptom", True))
        Me.P_SymptomTextBox.Location = New System.Drawing.Point(279, 352)
        Me.P_SymptomTextBox.Name = "P_SymptomTextBox"
        Me.P_SymptomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SymptomTextBox.TabIndex = 25
        '
        'Pr_IDTextBox
        '
        Me.Pr_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_ID", True))
        Me.Pr_IDTextBox.Location = New System.Drawing.Point(533, 90)
        Me.Pr_IDTextBox.Name = "Pr_IDTextBox"
        Me.Pr_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_IDTextBox.TabIndex = 27
        '
        'Pr_FNameTextBox
        '
        Me.Pr_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_FName", True))
        Me.Pr_FNameTextBox.Location = New System.Drawing.Point(612, 118)
        Me.Pr_FNameTextBox.Name = "Pr_FNameTextBox"
        Me.Pr_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_FNameTextBox.TabIndex = 29
        '
        'Pr_LNameTextBox
        '
        Me.Pr_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_LName", True))
        Me.Pr_LNameTextBox.Location = New System.Drawing.Point(612, 144)
        Me.Pr_LNameTextBox.Name = "Pr_LNameTextBox"
        Me.Pr_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_LNameTextBox.TabIndex = 31
        '
        'Pr_AddressTextBox
        '
        Me.Pr_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Address", True))
        Me.Pr_AddressTextBox.Location = New System.Drawing.Point(612, 170)
        Me.Pr_AddressTextBox.Name = "Pr_AddressTextBox"
        Me.Pr_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_AddressTextBox.TabIndex = 33
        '
        'Pr_TelTextBox
        '
        Me.Pr_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Tel", True))
        Me.Pr_TelTextBox.Location = New System.Drawing.Point(612, 196)
        Me.Pr_TelTextBox.Name = "Pr_TelTextBox"
        Me.Pr_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_TelTextBox.TabIndex = 35
        '
        'Pr_RelationshipTextBox
        '
        Me.Pr_RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Relationship", True))
        Me.Pr_RelationshipTextBox.Location = New System.Drawing.Point(612, 222)
        Me.Pr_RelationshipTextBox.Name = "Pr_RelationshipTextBox"
        Me.Pr_RelationshipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_RelationshipTextBox.TabIndex = 37
        '
        'L_IDTextBox
        '
        Me.L_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_ID", True))
        Me.L_IDTextBox.Location = New System.Drawing.Point(612, 277)
        Me.L_IDTextBox.Name = "L_IDTextBox"
        Me.L_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_IDTextBox.TabIndex = 39
        '
        'L_FNameTextBox
        '
        Me.L_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_FName", True))
        Me.L_FNameTextBox.Location = New System.Drawing.Point(612, 303)
        Me.L_FNameTextBox.Name = "L_FNameTextBox"
        Me.L_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_FNameTextBox.TabIndex = 41
        '
        'L_LNameTextBox
        '
        Me.L_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_LName", True))
        Me.L_LNameTextBox.Location = New System.Drawing.Point(612, 329)
        Me.L_LNameTextBox.Name = "L_LNameTextBox"
        Me.L_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_LNameTextBox.TabIndex = 43
        '
        'L_AddressTextBox
        '
        Me.L_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_Address", True))
        Me.L_AddressTextBox.Location = New System.Drawing.Point(612, 355)
        Me.L_AddressTextBox.Name = "L_AddressTextBox"
        Me.L_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_AddressTextBox.TabIndex = 45
        '
        'L_TelTextBox
        '
        Me.L_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_Tel", True))
        Me.L_TelTextBox.Location = New System.Drawing.Point(612, 381)
        Me.L_TelTextBox.Name = "L_TelTextBox"
        Me.L_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_TelTextBox.TabIndex = 47
        '
        'L_ClinicIDTextBox
        '
        Me.L_ClinicIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_ClinicID", True))
        Me.L_ClinicIDTextBox.Location = New System.Drawing.Point(612, 407)
        Me.L_ClinicIDTextBox.Name = "L_ClinicIDTextBox"
        Me.L_ClinicIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_ClinicIDTextBox.TabIndex = 49
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "PRF_ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(200, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 50
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(325, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'W_NumberTextBox
        '
        Me.W_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "W_Number", True))
        Me.W_NumberTextBox.Location = New System.Drawing.Point(279, 378)
        Me.W_NumberTextBox.Name = "W_NumberTextBox"
        Me.W_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.W_NumberTextBox.TabIndex = 55
        '
        'PatientReferralDataGridView
        '
        Me.PatientReferralDataGridView.AutoGenerateColumns = False
        Me.PatientReferralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientReferralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.PatientReferralDataGridView.DataSource = Me.PatientReferralBindingSource
        Me.PatientReferralDataGridView.Location = New System.Drawing.Point(3, 118)
        Me.PatientReferralDataGridView.Name = "PatientReferralDataGridView"
        Me.PatientReferralDataGridView.Size = New System.Drawing.Size(145, 220)
        Me.PatientReferralDataGridView.TabIndex = 55
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PRF_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRF_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "P_FName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "P_FName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "P_LName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "P_LName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "P_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "P_Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "P_Sex"
        Me.DataGridViewTextBoxColumn6.HeaderText = "P_Sex"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "P_Type"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P_Type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "P_Birth"
        Me.DataGridViewTextBoxColumn8.HeaderText = "P_Birth"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "P_Tel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "P_Tel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "P_Symptom"
        Me.DataGridViewTextBoxColumn10.HeaderText = "P_Symptom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Pr_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pr_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Pr_FName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Pr_FName"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Pr_LName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Pr_LName"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Pr_Address"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Pr_Address"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Pr_Tel"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Pr_Tel"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Pr_Relationship"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Pr_Relationship"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "L_ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "L_ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "L_FName"
        Me.DataGridViewTextBoxColumn18.HeaderText = "L_FName"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "L_LName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "L_LName"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "L_Address"
        Me.DataGridViewTextBoxColumn20.HeaderText = "L_Address"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "L_Tel"
        Me.DataGridViewTextBoxColumn21.HeaderText = "L_Tel"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "L_ClinicID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "L_ClinicID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "W_Number"
        Me.DataGridViewTextBoxColumn23.HeaderText = "W_Number"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 113)
        Me.Panel3.TabIndex = 56
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(140, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(932, 111)
        Me.Panel6.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Referral"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(527, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wellmedows Hospital"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(131, 111)
        Me.Panel5.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 586)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 52)
        Me.Panel1.TabIndex = 57
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 530)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Local Doctor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(491, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Patient Relatives"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PatientReferralDataGridView)
        Me.Controls.Add(W_NumberLabel)
        Me.Controls.Add(Me.W_NumberTextBox)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(PRF_IDLabel)
        Me.Controls.Add(Me.PRF_IDTextBox)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(P_FNameLabel)
        Me.Controls.Add(Me.P_FNameTextBox)
        Me.Controls.Add(P_LNameLabel)
        Me.Controls.Add(Me.P_LNameTextBox)
        Me.Controls.Add(P_AddressLabel)
        Me.Controls.Add(Me.P_AddressTextBox)
        Me.Controls.Add(P_SexLabel)
        Me.Controls.Add(Me.P_SexTextBox)
        Me.Controls.Add(P_TypeLabel)
        Me.Controls.Add(Me.P_TypeTextBox)
        Me.Controls.Add(P_BirthLabel)
        Me.Controls.Add(Me.P_BirthDateTimePicker)
        Me.Controls.Add(P_TelLabel)
        Me.Controls.Add(Me.P_TelTextBox)
        Me.Controls.Add(P_SymptomLabel)
        Me.Controls.Add(Me.P_SymptomTextBox)
        Me.Controls.Add(Pr_IDLabel)
        Me.Controls.Add(Me.Pr_IDTextBox)
        Me.Controls.Add(Pr_FNameLabel)
        Me.Controls.Add(Me.Pr_FNameTextBox)
        Me.Controls.Add(Pr_LNameLabel)
        Me.Controls.Add(Me.Pr_LNameTextBox)
        Me.Controls.Add(Pr_AddressLabel)
        Me.Controls.Add(Me.Pr_AddressTextBox)
        Me.Controls.Add(Pr_TelLabel)
        Me.Controls.Add(Me.Pr_TelTextBox)
        Me.Controls.Add(Pr_RelationshipLabel)
        Me.Controls.Add(Me.Pr_RelationshipTextBox)
        Me.Controls.Add(L_IDLabel)
        Me.Controls.Add(Me.L_IDTextBox)
        Me.Controls.Add(L_FNameLabel)
        Me.Controls.Add(Me.L_FNameTextBox)
        Me.Controls.Add(L_LNameLabel)
        Me.Controls.Add(Me.L_LNameTextBox)
        Me.Controls.Add(L_AddressLabel)
        Me.Controls.Add(Me.L_AddressTextBox)
        Me.Controls.Add(L_TelLabel)
        Me.Controls.Add(Me.L_TelTextBox)
        Me.Controls.Add(L_ClinicIDLabel)
        Me.Controls.Add(Me.L_ClinicIDTextBox)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Patient"
        Me.Text = "Patient"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientReferralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientReferralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As HospitalTableAdapters.PatientTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents PatientReferralBindingSource As BindingSource
    Friend WithEvents PatientReferralTableAdapter As HospitalTableAdapters.PatientReferralTableAdapter
    Friend WithEvents PRF_IDTextBox As TextBox
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents P_FNameTextBox As TextBox
    Friend WithEvents P_LNameTextBox As TextBox
    Friend WithEvents P_AddressTextBox As TextBox
    Friend WithEvents P_SexTextBox As TextBox
    Friend WithEvents P_TypeTextBox As TextBox
    Friend WithEvents P_BirthDateTimePicker As DateTimePicker
    Friend WithEvents P_TelTextBox As TextBox
    Friend WithEvents P_SymptomTextBox As TextBox
    Friend WithEvents Pr_IDTextBox As TextBox
    Friend WithEvents Pr_FNameTextBox As TextBox
    Friend WithEvents Pr_LNameTextBox As TextBox
    Friend WithEvents Pr_AddressTextBox As TextBox
    Friend WithEvents Pr_TelTextBox As TextBox
    Friend WithEvents Pr_RelationshipTextBox As TextBox
    Friend WithEvents L_IDTextBox As TextBox
    Friend WithEvents L_FNameTextBox As TextBox
    Friend WithEvents L_LNameTextBox As TextBox
    Friend WithEvents L_AddressTextBox As TextBox
    Friend WithEvents L_TelTextBox As TextBox
    Friend WithEvents L_ClinicIDTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents W_NumberTextBox As TextBox
    Friend WithEvents PatientReferralDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
