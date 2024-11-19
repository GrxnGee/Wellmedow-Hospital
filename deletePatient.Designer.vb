<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deletePatient
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
        Dim L_IDLabel As System.Windows.Forms.Label
        Dim L_FNameLabel As System.Windows.Forms.Label
        Dim L_LNameLabel As System.Windows.Forms.Label
        Dim L_AddressLabel As System.Windows.Forms.Label
        Dim L_TelLabel As System.Windows.Forms.Label
        Dim L_ClinicIDLabel As System.Windows.Forms.Label
        Dim Pr_IDLabel As System.Windows.Forms.Label
        Dim Pr_FNameLabel As System.Windows.Forms.Label
        Dim Pr_LNameLabel As System.Windows.Forms.Label
        Dim Pr_AddressLabel As System.Windows.Forms.Label
        Dim Pr_TelLabel As System.Windows.Forms.Label
        Dim Pr_RelationshipLabel As System.Windows.Forms.Label
        Dim W_LocationLabel As System.Windows.Forms.Label
        Dim W_ExtTelLabel As System.Windows.Forms.Label
        Dim W_TypeLabel As System.Windows.Forms.Label
        Dim W_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deletePatient))
        Me.Hospital = New Wellmedow.Hospital()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New Wellmedow.HospitalTableAdapters.PatientTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.PatientReferralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientReferralTableAdapter = New Wellmedow.HospitalTableAdapters.PatientReferralTableAdapter()
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.W_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.W_TypeTextBox1 = New System.Windows.Forms.TextBox()
        Me.W_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.W_ExtTelTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
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
        L_IDLabel = New System.Windows.Forms.Label()
        L_FNameLabel = New System.Windows.Forms.Label()
        L_LNameLabel = New System.Windows.Forms.Label()
        L_AddressLabel = New System.Windows.Forms.Label()
        L_TelLabel = New System.Windows.Forms.Label()
        L_ClinicIDLabel = New System.Windows.Forms.Label()
        Pr_IDLabel = New System.Windows.Forms.Label()
        Pr_FNameLabel = New System.Windows.Forms.Label()
        Pr_LNameLabel = New System.Windows.Forms.Label()
        Pr_AddressLabel = New System.Windows.Forms.Label()
        Pr_TelLabel = New System.Windows.Forms.Label()
        Pr_RelationshipLabel = New System.Windows.Forms.Label()
        W_LocationLabel = New System.Windows.Forms.Label()
        W_ExtTelLabel = New System.Windows.Forms.Label()
        W_TypeLabel = New System.Windows.Forms.Label()
        W_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        PRF_IDLabel.Location = New System.Drawing.Point(181, 183)
        PRF_IDLabel.Name = "PRF_IDLabel"
        PRF_IDLabel.Size = New System.Drawing.Size(45, 13)
        PRF_IDLabel.TabIndex = 107
        PRF_IDLabel.Text = "PRF ID:"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(181, 209)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(53, 13)
        P_IDLabel.TabIndex = 108
        P_IDLabel.Text = "รหัสผู้ป่วย"
        '
        'P_FNameLabel
        '
        P_FNameLabel.AutoSize = True
        P_FNameLabel.Location = New System.Drawing.Point(191, 235)
        P_FNameLabel.Name = "P_FNameLabel"
        P_FNameLabel.Size = New System.Drawing.Size(20, 13)
        P_FNameLabel.TabIndex = 109
        P_FNameLabel.Text = "ชื่อ"
        '
        'P_LNameLabel
        '
        P_LNameLabel.AutoSize = True
        P_LNameLabel.Location = New System.Drawing.Point(181, 261)
        P_LNameLabel.Name = "P_LNameLabel"
        P_LNameLabel.Size = New System.Drawing.Size(46, 13)
        P_LNameLabel.TabIndex = 110
        P_LNameLabel.Text = "นามสกุล"
        '
        'P_AddressLabel
        '
        P_AddressLabel.AutoSize = True
        P_AddressLabel.Location = New System.Drawing.Point(189, 290)
        P_AddressLabel.Name = "P_AddressLabel"
        P_AddressLabel.Size = New System.Drawing.Size(27, 13)
        P_AddressLabel.TabIndex = 111
        P_AddressLabel.Text = "ที่อยู่"
        '
        'P_SexLabel
        '
        P_SexLabel.AutoSize = True
        P_SexLabel.Location = New System.Drawing.Point(191, 313)
        P_SexLabel.Name = "P_SexLabel"
        P_SexLabel.Size = New System.Drawing.Size(28, 13)
        P_SexLabel.TabIndex = 112
        P_SexLabel.Text = "เพศ"
        '
        'P_TypeLabel
        '
        P_TypeLabel.AutoSize = True
        P_TypeLabel.Location = New System.Drawing.Point(173, 339)
        P_TypeLabel.Name = "P_TypeLabel"
        P_TypeLabel.Size = New System.Drawing.Size(71, 13)
        P_TypeLabel.TabIndex = 113
        P_TypeLabel.Text = "ประเภทผู้ป่วย"
        '
        'P_BirthLabel
        '
        P_BirthLabel.AutoSize = True
        P_BirthLabel.Location = New System.Drawing.Point(161, 368)
        P_BirthLabel.Name = "P_BirthLabel"
        P_BirthLabel.Size = New System.Drawing.Size(83, 13)
        P_BirthLabel.TabIndex = 114
        P_BirthLabel.Text = "วัน/เดือน/ปีเกิด"
        '
        'P_TelLabel
        '
        P_TelLabel.AutoSize = True
        P_TelLabel.Location = New System.Drawing.Point(181, 391)
        P_TelLabel.Name = "P_TelLabel"
        P_TelLabel.Size = New System.Drawing.Size(49, 13)
        P_TelLabel.TabIndex = 115
        P_TelLabel.Text = "เบอร์โทร"
        '
        'P_SymptomLabel
        '
        P_SymptomLabel.AutoSize = True
        P_SymptomLabel.Location = New System.Drawing.Point(189, 417)
        P_SymptomLabel.Name = "P_SymptomLabel"
        P_SymptomLabel.Size = New System.Drawing.Size(36, 13)
        P_SymptomLabel.TabIndex = 116
        P_SymptomLabel.Text = "อาการ"
        '
        'L_IDLabel
        '
        L_IDLabel.AutoSize = True
        L_IDLabel.Location = New System.Drawing.Point(173, 489)
        L_IDLabel.Name = "L_IDLabel"
        L_IDLabel.Size = New System.Drawing.Size(75, 13)
        L_IDLabel.TabIndex = 117
        L_IDLabel.Text = "รหัสหมอประจำ"
        '
        'L_FNameLabel
        '
        L_FNameLabel.AutoSize = True
        L_FNameLabel.Location = New System.Drawing.Point(196, 519)
        L_FNameLabel.Name = "L_FNameLabel"
        L_FNameLabel.Size = New System.Drawing.Size(20, 13)
        L_FNameLabel.TabIndex = 118
        L_FNameLabel.Text = "ชื่อ"
        '
        'L_LNameLabel
        '
        L_LNameLabel.AutoSize = True
        L_LNameLabel.Location = New System.Drawing.Point(181, 541)
        L_LNameLabel.Name = "L_LNameLabel"
        L_LNameLabel.Size = New System.Drawing.Size(46, 13)
        L_LNameLabel.TabIndex = 119
        L_LNameLabel.Text = "นามสกุล"
        '
        'L_AddressLabel
        '
        L_AddressLabel.AutoSize = True
        L_AddressLabel.Location = New System.Drawing.Point(192, 567)
        L_AddressLabel.Name = "L_AddressLabel"
        L_AddressLabel.Size = New System.Drawing.Size(27, 13)
        L_AddressLabel.TabIndex = 120
        L_AddressLabel.Text = "ที่อยู่"
        '
        'L_TelLabel
        '
        L_TelLabel.AutoSize = True
        L_TelLabel.Location = New System.Drawing.Point(181, 593)
        L_TelLabel.Name = "L_TelLabel"
        L_TelLabel.Size = New System.Drawing.Size(49, 13)
        L_TelLabel.TabIndex = 121
        L_TelLabel.Text = "เบอร์โทร"
        '
        'L_ClinicIDLabel
        '
        L_ClinicIDLabel.AutoSize = True
        L_ClinicIDLabel.Location = New System.Drawing.Point(181, 619)
        L_ClinicIDLabel.Name = "L_ClinicIDLabel"
        L_ClinicIDLabel.Size = New System.Drawing.Size(54, 13)
        L_ClinicIDLabel.TabIndex = 122
        L_ClinicIDLabel.Text = "รหัสคลินิค"
        '
        'Pr_IDLabel
        '
        Pr_IDLabel.AutoSize = True
        Pr_IDLabel.Location = New System.Drawing.Point(506, 160)
        Pr_IDLabel.Name = "Pr_IDLabel"
        Pr_IDLabel.Size = New System.Drawing.Size(74, 13)
        Pr_IDLabel.TabIndex = 123
        Pr_IDLabel.Text = "รหัสญาติผู้ป่วย"
        '
        'Pr_FNameLabel
        '
        Pr_FNameLabel.AutoSize = True
        Pr_FNameLabel.Location = New System.Drawing.Point(532, 187)
        Pr_FNameLabel.Name = "Pr_FNameLabel"
        Pr_FNameLabel.Size = New System.Drawing.Size(20, 13)
        Pr_FNameLabel.TabIndex = 124
        Pr_FNameLabel.Text = "ชื่อ"
        '
        'Pr_LNameLabel
        '
        Pr_LNameLabel.AutoSize = True
        Pr_LNameLabel.Location = New System.Drawing.Point(518, 212)
        Pr_LNameLabel.Name = "Pr_LNameLabel"
        Pr_LNameLabel.Size = New System.Drawing.Size(46, 13)
        Pr_LNameLabel.TabIndex = 125
        Pr_LNameLabel.Text = "นามสกุล"
        '
        'Pr_AddressLabel
        '
        Pr_AddressLabel.AutoSize = True
        Pr_AddressLabel.Location = New System.Drawing.Point(528, 239)
        Pr_AddressLabel.Name = "Pr_AddressLabel"
        Pr_AddressLabel.Size = New System.Drawing.Size(27, 13)
        Pr_AddressLabel.TabIndex = 126
        Pr_AddressLabel.Text = "ที่อยู่"
        '
        'Pr_TelLabel
        '
        Pr_TelLabel.AutoSize = True
        Pr_TelLabel.Location = New System.Drawing.Point(518, 265)
        Pr_TelLabel.Name = "Pr_TelLabel"
        Pr_TelLabel.Size = New System.Drawing.Size(49, 13)
        Pr_TelLabel.TabIndex = 127
        Pr_TelLabel.Text = "เบอร์โทร"
        '
        'Pr_RelationshipLabel
        '
        Pr_RelationshipLabel.AutoSize = True
        Pr_RelationshipLabel.Location = New System.Drawing.Point(513, 290)
        Pr_RelationshipLabel.Name = "Pr_RelationshipLabel"
        Pr_RelationshipLabel.Size = New System.Drawing.Size(67, 13)
        Pr_RelationshipLabel.TabIndex = 128
        Pr_RelationshipLabel.Text = "ความสัมพันธ์"
        '
        'W_LocationLabel
        '
        W_LocationLabel.AutoSize = True
        W_LocationLabel.Location = New System.Drawing.Point(528, 387)
        W_LocationLabel.Name = "W_LocationLabel"
        W_LocationLabel.Size = New System.Drawing.Size(26, 13)
        W_LocationLabel.TabIndex = 154
        W_LocationLabel.Text = "ที่ตั้ง"
        '
        'W_ExtTelLabel
        '
        W_ExtTelLabel.AutoSize = True
        W_ExtTelLabel.Location = New System.Drawing.Point(517, 413)
        W_ExtTelLabel.Name = "W_ExtTelLabel"
        W_ExtTelLabel.Size = New System.Drawing.Size(45, 13)
        W_ExtTelLabel.TabIndex = 156
        W_ExtTelLabel.Text = "เบอร์ตึก"
        '
        'W_TypeLabel
        '
        W_TypeLabel.AutoSize = True
        W_TypeLabel.Location = New System.Drawing.Point(520, 361)
        W_TypeLabel.Name = "W_TypeLabel"
        W_TypeLabel.Size = New System.Drawing.Size(58, 13)
        W_TypeLabel.TabIndex = 150
        W_TypeLabel.Text = "ประเภทตึก"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(517, 335)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 149
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.Hospital
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
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(252, 449)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 31)
        Me.TextBox4.TabIndex = 104
        Me.TextBox4.Text = "LOCAL DOCTOR"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(588, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 31)
        Me.TextBox3.TabIndex = 103
        Me.TextBox3.Text = "RELATIVE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(252, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 31)
        Me.TextBox2.TabIndex = 102
        Me.TextBox2.Text = "PATIENT"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(377, 154)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 154)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 99
        '
        'PRF_IDTextBox
        '
        Me.PRF_IDTextBox.Location = New System.Drawing.Point(252, 180)
        Me.PRF_IDTextBox.Name = "PRF_IDTextBox"
        Me.PRF_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRF_IDTextBox.TabIndex = 56
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.Location = New System.Drawing.Point(252, 206)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 58
        '
        'P_FNameTextBox
        '
        Me.P_FNameTextBox.Location = New System.Drawing.Point(252, 232)
        Me.P_FNameTextBox.Name = "P_FNameTextBox"
        Me.P_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_FNameTextBox.TabIndex = 60
        '
        'P_LNameTextBox
        '
        Me.P_LNameTextBox.Location = New System.Drawing.Point(252, 258)
        Me.P_LNameTextBox.Name = "P_LNameTextBox"
        Me.P_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_LNameTextBox.TabIndex = 62
        '
        'P_AddressTextBox
        '
        Me.P_AddressTextBox.Location = New System.Drawing.Point(252, 284)
        Me.P_AddressTextBox.Name = "P_AddressTextBox"
        Me.P_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_AddressTextBox.TabIndex = 64
        '
        'P_SexTextBox
        '
        Me.P_SexTextBox.Location = New System.Drawing.Point(252, 310)
        Me.P_SexTextBox.Name = "P_SexTextBox"
        Me.P_SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SexTextBox.TabIndex = 66
        '
        'P_TypeTextBox
        '
        Me.P_TypeTextBox.Location = New System.Drawing.Point(252, 336)
        Me.P_TypeTextBox.Name = "P_TypeTextBox"
        Me.P_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_TypeTextBox.TabIndex = 68
        '
        'P_BirthDateTimePicker
        '
        Me.P_BirthDateTimePicker.Location = New System.Drawing.Point(252, 362)
        Me.P_BirthDateTimePicker.Name = "P_BirthDateTimePicker"
        Me.P_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.P_BirthDateTimePicker.TabIndex = 70
        '
        'P_TelTextBox
        '
        Me.P_TelTextBox.Location = New System.Drawing.Point(252, 388)
        Me.P_TelTextBox.Name = "P_TelTextBox"
        Me.P_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_TelTextBox.TabIndex = 72
        '
        'P_SymptomTextBox
        '
        Me.P_SymptomTextBox.Location = New System.Drawing.Point(252, 414)
        Me.P_SymptomTextBox.Name = "P_SymptomTextBox"
        Me.P_SymptomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SymptomTextBox.TabIndex = 74
        '
        'Pr_IDTextBox
        '
        Me.Pr_IDTextBox.Location = New System.Drawing.Point(588, 157)
        Me.Pr_IDTextBox.Name = "Pr_IDTextBox"
        Me.Pr_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_IDTextBox.TabIndex = 76
        '
        'Pr_FNameTextBox
        '
        Me.Pr_FNameTextBox.Location = New System.Drawing.Point(588, 183)
        Me.Pr_FNameTextBox.Name = "Pr_FNameTextBox"
        Me.Pr_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_FNameTextBox.TabIndex = 78
        '
        'Pr_LNameTextBox
        '
        Me.Pr_LNameTextBox.Location = New System.Drawing.Point(588, 209)
        Me.Pr_LNameTextBox.Name = "Pr_LNameTextBox"
        Me.Pr_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_LNameTextBox.TabIndex = 80
        '
        'Pr_AddressTextBox
        '
        Me.Pr_AddressTextBox.Location = New System.Drawing.Point(588, 235)
        Me.Pr_AddressTextBox.Name = "Pr_AddressTextBox"
        Me.Pr_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_AddressTextBox.TabIndex = 82
        '
        'Pr_TelTextBox
        '
        Me.Pr_TelTextBox.Location = New System.Drawing.Point(588, 261)
        Me.Pr_TelTextBox.Name = "Pr_TelTextBox"
        Me.Pr_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_TelTextBox.TabIndex = 84
        '
        'Pr_RelationshipTextBox
        '
        Me.Pr_RelationshipTextBox.Location = New System.Drawing.Point(588, 287)
        Me.Pr_RelationshipTextBox.Name = "Pr_RelationshipTextBox"
        Me.Pr_RelationshipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_RelationshipTextBox.TabIndex = 86
        '
        'L_IDTextBox
        '
        Me.L_IDTextBox.Location = New System.Drawing.Point(252, 486)
        Me.L_IDTextBox.Name = "L_IDTextBox"
        Me.L_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_IDTextBox.TabIndex = 88
        '
        'L_FNameTextBox
        '
        Me.L_FNameTextBox.Location = New System.Drawing.Point(252, 512)
        Me.L_FNameTextBox.Name = "L_FNameTextBox"
        Me.L_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_FNameTextBox.TabIndex = 90
        '
        'L_LNameTextBox
        '
        Me.L_LNameTextBox.Location = New System.Drawing.Point(252, 538)
        Me.L_LNameTextBox.Name = "L_LNameTextBox"
        Me.L_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_LNameTextBox.TabIndex = 92
        '
        'L_AddressTextBox
        '
        Me.L_AddressTextBox.Location = New System.Drawing.Point(252, 564)
        Me.L_AddressTextBox.Name = "L_AddressTextBox"
        Me.L_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_AddressTextBox.TabIndex = 94
        '
        'L_TelTextBox
        '
        Me.L_TelTextBox.Location = New System.Drawing.Point(252, 590)
        Me.L_TelTextBox.Name = "L_TelTextBox"
        Me.L_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_TelTextBox.TabIndex = 96
        '
        'L_ClinicIDTextBox
        '
        Me.L_ClinicIDTextBox.Location = New System.Drawing.Point(252, 616)
        Me.L_ClinicIDTextBox.Name = "L_ClinicIDTextBox"
        Me.L_ClinicIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_ClinicIDTextBox.TabIndex = 98
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
        'PatientReferralDataGridView
        '
        Me.PatientReferralDataGridView.AutoGenerateColumns = False
        Me.PatientReferralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientReferralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PatientReferralDataGridView.DataSource = Me.PatientReferralBindingSource
        Me.PatientReferralDataGridView.Location = New System.Drawing.Point(12, 120)
        Me.PatientReferralDataGridView.Name = "PatientReferralDataGridView"
        Me.PatientReferralDataGridView.Size = New System.Drawing.Size(146, 215)
        Me.PatientReferralDataGridView.TabIndex = 104
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
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(588, 525)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 20)
        Me.btnDelete.TabIndex = 105
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'W_NumberTextBox1
        '
        Me.W_NumberTextBox1.Location = New System.Drawing.Point(588, 332)
        Me.W_NumberTextBox1.Name = "W_NumberTextBox1"
        Me.W_NumberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.W_NumberTextBox1.TabIndex = 152
        '
        'W_TypeTextBox1
        '
        Me.W_TypeTextBox1.Location = New System.Drawing.Point(588, 358)
        Me.W_TypeTextBox1.Name = "W_TypeTextBox1"
        Me.W_TypeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.W_TypeTextBox1.TabIndex = 153
        '
        'W_LocationTextBox
        '
        Me.W_LocationTextBox.Location = New System.Drawing.Point(588, 384)
        Me.W_LocationTextBox.Name = "W_LocationTextBox"
        Me.W_LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_LocationTextBox.TabIndex = 155
        '
        'W_ExtTelTextBox
        '
        Me.W_ExtTelTextBox.Location = New System.Drawing.Point(588, 410)
        Me.W_ExtTelTextBox.Name = "W_ExtTelTextBox"
        Me.W_ExtTelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_ExtTelTextBox.TabIndex = 157
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(964, 113)
        Me.Panel3.TabIndex = 158
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(588, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 20)
        Me.Button2.TabIndex = 159
        Me.Button2.Text = "SUBMIT EDIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'deletePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 615)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.W_NumberTextBox1)
        Me.Controls.Add(Me.W_TypeTextBox1)
        Me.Controls.Add(W_LocationLabel)
        Me.Controls.Add(Me.W_LocationTextBox)
        Me.Controls.Add(W_ExtTelLabel)
        Me.Controls.Add(Me.W_ExtTelTextBox)
        Me.Controls.Add(W_TypeLabel)
        Me.Controls.Add(W_NumberLabel)
        Me.Controls.Add(Pr_IDLabel)
        Me.Controls.Add(Pr_FNameLabel)
        Me.Controls.Add(Pr_LNameLabel)
        Me.Controls.Add(Pr_AddressLabel)
        Me.Controls.Add(Pr_TelLabel)
        Me.Controls.Add(Pr_RelationshipLabel)
        Me.Controls.Add(PRF_IDLabel)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(P_FNameLabel)
        Me.Controls.Add(P_LNameLabel)
        Me.Controls.Add(P_AddressLabel)
        Me.Controls.Add(P_SexLabel)
        Me.Controls.Add(P_TypeLabel)
        Me.Controls.Add(P_BirthLabel)
        Me.Controls.Add(P_TelLabel)
        Me.Controls.Add(P_SymptomLabel)
        Me.Controls.Add(L_IDLabel)
        Me.Controls.Add(L_FNameLabel)
        Me.Controls.Add(L_LNameLabel)
        Me.Controls.Add(L_AddressLabel)
        Me.Controls.Add(L_TelLabel)
        Me.Controls.Add(L_ClinicIDLabel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.PatientReferralDataGridView)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PRF_IDTextBox)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(Me.P_FNameTextBox)
        Me.Controls.Add(Me.P_LNameTextBox)
        Me.Controls.Add(Me.P_AddressTextBox)
        Me.Controls.Add(Me.P_SexTextBox)
        Me.Controls.Add(Me.P_TypeTextBox)
        Me.Controls.Add(Me.P_BirthDateTimePicker)
        Me.Controls.Add(Me.P_TelTextBox)
        Me.Controls.Add(Me.P_SymptomTextBox)
        Me.Controls.Add(Me.Pr_IDTextBox)
        Me.Controls.Add(Me.Pr_FNameTextBox)
        Me.Controls.Add(Me.Pr_LNameTextBox)
        Me.Controls.Add(Me.Pr_AddressTextBox)
        Me.Controls.Add(Me.Pr_TelTextBox)
        Me.Controls.Add(Me.Pr_RelationshipTextBox)
        Me.Controls.Add(Me.L_IDTextBox)
        Me.Controls.Add(Me.L_FNameTextBox)
        Me.Controls.Add(Me.L_LNameTextBox)
        Me.Controls.Add(Me.L_AddressTextBox)
        Me.Controls.Add(Me.L_TelTextBox)
        Me.Controls.Add(Me.L_ClinicIDTextBox)
        Me.Name = "deletePatient"
        Me.Text = "deletePatient"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Hospital As Hospital
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As HospitalTableAdapters.PatientTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
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
    Friend WithEvents PatientReferralBindingSource As BindingSource
    Friend WithEvents PatientReferralTableAdapter As HospitalTableAdapters.PatientReferralTableAdapter
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents W_NumberTextBox1 As TextBox
    Friend WithEvents W_TypeTextBox1 As TextBox
    Friend WithEvents W_LocationTextBox As TextBox
    Friend WithEvents W_ExtTelTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
