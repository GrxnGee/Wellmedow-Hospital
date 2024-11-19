<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addPatient
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Pr_IDLabel As System.Windows.Forms.Label
        Dim Pr_FNameLabel As System.Windows.Forms.Label
        Dim Pr_LNameLabel As System.Windows.Forms.Label
        Dim Pr_AddressLabel As System.Windows.Forms.Label
        Dim Pr_TelLabel As System.Windows.Forms.Label
        Dim Pr_RelationshipLabel As System.Windows.Forms.Label
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
        Dim W_NumberLabel As System.Windows.Forms.Label
        Dim W_TypeLabel As System.Windows.Forms.Label
        Dim W_LocationLabel As System.Windows.Forms.Label
        Dim W_ExtTelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addPatient))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Hospital = New Wellmedow.Hospital()
        Me.PatientReferralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.P_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.P_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.P_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.P_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_TelTextBox = New System.Windows.Forms.TextBox()
        Me.P_SymptomTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_TelTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.L_FNameTextBox = New System.Windows.Forms.TextBox()
        Me.L_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.L_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.L_TelTextBox = New System.Windows.Forms.TextBox()
        Me.L_ClinicIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pr_id = New System.Windows.Forms.TextBox()
        Me.btnSearchR = New System.Windows.Forms.Button()
        Me.Hospital1 = New Wellmedow.Hospital()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnSearchLD = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New Wellmedow.HospitalTableAdapters.WardsTableAdapter()
        Me.btnSearchWard = New System.Windows.Forms.Button()
        Me.W_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.W_TypeTextBox1 = New System.Windows.Forms.TextBox()
        Me.W_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.W_ExtTelTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        Pr_IDLabel = New System.Windows.Forms.Label()
        Pr_FNameLabel = New System.Windows.Forms.Label()
        Pr_LNameLabel = New System.Windows.Forms.Label()
        Pr_AddressLabel = New System.Windows.Forms.Label()
        Pr_TelLabel = New System.Windows.Forms.Label()
        Pr_RelationshipLabel = New System.Windows.Forms.Label()
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
        W_NumberLabel = New System.Windows.Forms.Label()
        W_TypeLabel = New System.Windows.Forms.Label()
        W_LocationLabel = New System.Windows.Forms.Label()
        W_ExtTelLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientReferralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(79, 140)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 55
        Label1.Text = "REFERRAL ID"
        '
        'Pr_IDLabel
        '
        Pr_IDLabel.AutoSize = True
        Pr_IDLabel.Location = New System.Drawing.Point(389, 189)
        Pr_IDLabel.Name = "Pr_IDLabel"
        Pr_IDLabel.Size = New System.Drawing.Size(74, 13)
        Pr_IDLabel.TabIndex = 58
        Pr_IDLabel.Text = "รหัสญาติผู้ป่วย"
        '
        'Pr_FNameLabel
        '
        Pr_FNameLabel.AutoSize = True
        Pr_FNameLabel.Location = New System.Drawing.Point(415, 216)
        Pr_FNameLabel.Name = "Pr_FNameLabel"
        Pr_FNameLabel.Size = New System.Drawing.Size(20, 13)
        Pr_FNameLabel.TabIndex = 59
        Pr_FNameLabel.Text = "ชื่อ"
        '
        'Pr_LNameLabel
        '
        Pr_LNameLabel.AutoSize = True
        Pr_LNameLabel.Location = New System.Drawing.Point(401, 241)
        Pr_LNameLabel.Name = "Pr_LNameLabel"
        Pr_LNameLabel.Size = New System.Drawing.Size(46, 13)
        Pr_LNameLabel.TabIndex = 60
        Pr_LNameLabel.Text = "นามสกุล"
        '
        'Pr_AddressLabel
        '
        Pr_AddressLabel.AutoSize = True
        Pr_AddressLabel.Location = New System.Drawing.Point(411, 268)
        Pr_AddressLabel.Name = "Pr_AddressLabel"
        Pr_AddressLabel.Size = New System.Drawing.Size(27, 13)
        Pr_AddressLabel.TabIndex = 61
        Pr_AddressLabel.Text = "ที่อยู่"
        '
        'Pr_TelLabel
        '
        Pr_TelLabel.AutoSize = True
        Pr_TelLabel.Location = New System.Drawing.Point(401, 294)
        Pr_TelLabel.Name = "Pr_TelLabel"
        Pr_TelLabel.Size = New System.Drawing.Size(49, 13)
        Pr_TelLabel.TabIndex = 62
        Pr_TelLabel.Text = "เบอร์โทร"
        '
        'Pr_RelationshipLabel
        '
        Pr_RelationshipLabel.AutoSize = True
        Pr_RelationshipLabel.Location = New System.Drawing.Point(396, 319)
        Pr_RelationshipLabel.Name = "Pr_RelationshipLabel"
        Pr_RelationshipLabel.Size = New System.Drawing.Size(67, 13)
        Pr_RelationshipLabel.TabIndex = 63
        Pr_RelationshipLabel.Text = "ความสัมพันธ์"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(119, 189)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(53, 13)
        P_IDLabel.TabIndex = 124
        P_IDLabel.Text = "รหัสผู้ป่วย"
        '
        'P_FNameLabel
        '
        P_FNameLabel.AutoSize = True
        P_FNameLabel.Location = New System.Drawing.Point(129, 215)
        P_FNameLabel.Name = "P_FNameLabel"
        P_FNameLabel.Size = New System.Drawing.Size(20, 13)
        P_FNameLabel.TabIndex = 125
        P_FNameLabel.Text = "ชื่อ"
        '
        'P_LNameLabel
        '
        P_LNameLabel.AutoSize = True
        P_LNameLabel.Location = New System.Drawing.Point(119, 241)
        P_LNameLabel.Name = "P_LNameLabel"
        P_LNameLabel.Size = New System.Drawing.Size(46, 13)
        P_LNameLabel.TabIndex = 126
        P_LNameLabel.Text = "นามสกุล"
        '
        'P_AddressLabel
        '
        P_AddressLabel.AutoSize = True
        P_AddressLabel.Location = New System.Drawing.Point(127, 270)
        P_AddressLabel.Name = "P_AddressLabel"
        P_AddressLabel.Size = New System.Drawing.Size(27, 13)
        P_AddressLabel.TabIndex = 127
        P_AddressLabel.Text = "ที่อยู่"
        '
        'P_SexLabel
        '
        P_SexLabel.AutoSize = True
        P_SexLabel.Location = New System.Drawing.Point(129, 293)
        P_SexLabel.Name = "P_SexLabel"
        P_SexLabel.Size = New System.Drawing.Size(28, 13)
        P_SexLabel.TabIndex = 128
        P_SexLabel.Text = "เพศ"
        '
        'P_TypeLabel
        '
        P_TypeLabel.AutoSize = True
        P_TypeLabel.Location = New System.Drawing.Point(111, 319)
        P_TypeLabel.Name = "P_TypeLabel"
        P_TypeLabel.Size = New System.Drawing.Size(71, 13)
        P_TypeLabel.TabIndex = 129
        P_TypeLabel.Text = "ประเภทผู้ป่วย"
        '
        'P_BirthLabel
        '
        P_BirthLabel.AutoSize = True
        P_BirthLabel.Location = New System.Drawing.Point(99, 348)
        P_BirthLabel.Name = "P_BirthLabel"
        P_BirthLabel.Size = New System.Drawing.Size(83, 13)
        P_BirthLabel.TabIndex = 130
        P_BirthLabel.Text = "วัน/เดือน/ปีเกิด"
        '
        'P_TelLabel
        '
        P_TelLabel.AutoSize = True
        P_TelLabel.Location = New System.Drawing.Point(119, 371)
        P_TelLabel.Name = "P_TelLabel"
        P_TelLabel.Size = New System.Drawing.Size(49, 13)
        P_TelLabel.TabIndex = 131
        P_TelLabel.Text = "เบอร์โทร"
        '
        'P_SymptomLabel
        '
        P_SymptomLabel.AutoSize = True
        P_SymptomLabel.Location = New System.Drawing.Point(127, 397)
        P_SymptomLabel.Name = "P_SymptomLabel"
        P_SymptomLabel.Size = New System.Drawing.Size(36, 13)
        P_SymptomLabel.TabIndex = 132
        P_SymptomLabel.Text = "อาการ"
        '
        'L_IDLabel
        '
        L_IDLabel.AutoSize = True
        L_IDLabel.Location = New System.Drawing.Point(111, 456)
        L_IDLabel.Name = "L_IDLabel"
        L_IDLabel.Size = New System.Drawing.Size(75, 13)
        L_IDLabel.TabIndex = 133
        L_IDLabel.Text = "รหัสหมอประจำ"
        '
        'L_FNameLabel
        '
        L_FNameLabel.AutoSize = True
        L_FNameLabel.Location = New System.Drawing.Point(134, 486)
        L_FNameLabel.Name = "L_FNameLabel"
        L_FNameLabel.Size = New System.Drawing.Size(20, 13)
        L_FNameLabel.TabIndex = 134
        L_FNameLabel.Text = "ชื่อ"
        '
        'L_LNameLabel
        '
        L_LNameLabel.AutoSize = True
        L_LNameLabel.Location = New System.Drawing.Point(119, 508)
        L_LNameLabel.Name = "L_LNameLabel"
        L_LNameLabel.Size = New System.Drawing.Size(46, 13)
        L_LNameLabel.TabIndex = 135
        L_LNameLabel.Text = "นามสกุล"
        '
        'L_AddressLabel
        '
        L_AddressLabel.AutoSize = True
        L_AddressLabel.Location = New System.Drawing.Point(130, 534)
        L_AddressLabel.Name = "L_AddressLabel"
        L_AddressLabel.Size = New System.Drawing.Size(27, 13)
        L_AddressLabel.TabIndex = 136
        L_AddressLabel.Text = "ที่อยู่"
        '
        'L_TelLabel
        '
        L_TelLabel.AutoSize = True
        L_TelLabel.Location = New System.Drawing.Point(119, 560)
        L_TelLabel.Name = "L_TelLabel"
        L_TelLabel.Size = New System.Drawing.Size(49, 13)
        L_TelLabel.TabIndex = 137
        L_TelLabel.Text = "เบอร์โทร"
        '
        'L_ClinicIDLabel
        '
        L_ClinicIDLabel.AutoSize = True
        L_ClinicIDLabel.Location = New System.Drawing.Point(119, 586)
        L_ClinicIDLabel.Name = "L_ClinicIDLabel"
        L_ClinicIDLabel.Size = New System.Drawing.Size(54, 13)
        L_ClinicIDLabel.TabIndex = 138
        L_ClinicIDLabel.Text = "รหัสคลินิค"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(398, 351)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 138
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'W_TypeLabel
        '
        W_TypeLabel.AutoSize = True
        W_TypeLabel.Location = New System.Drawing.Point(401, 377)
        W_TypeLabel.Name = "W_TypeLabel"
        W_TypeLabel.Size = New System.Drawing.Size(58, 13)
        W_TypeLabel.TabIndex = 139
        W_TypeLabel.Text = "ประเภทตึก"
        '
        'W_LocationLabel
        '
        W_LocationLabel.AutoSize = True
        W_LocationLabel.Location = New System.Drawing.Point(409, 403)
        W_LocationLabel.Name = "W_LocationLabel"
        W_LocationLabel.Size = New System.Drawing.Size(26, 13)
        W_LocationLabel.TabIndex = 145
        W_LocationLabel.Text = "ที่ตั้ง"
        '
        'W_ExtTelLabel
        '
        W_ExtTelLabel.AutoSize = True
        W_ExtTelLabel.Location = New System.Drawing.Point(398, 429)
        W_ExtTelLabel.Name = "W_ExtTelLabel"
        W_ExtTelLabel.Size = New System.Drawing.Size(45, 13)
        W_ExtTelLabel.TabIndex = 147
        W_ExtTelLabel.Text = "เบอร์ตึก"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(582, 560)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 20)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientReferralBindingSource
        '
        Me.PatientReferralBindingSource.DataMember = "PatientReferral"
        Me.PatientReferralBindingSource.DataSource = Me.Hospital
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientReferralTableAdapter = Nothing
        Me.TableAdapterManager.PatientRelativesTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(186, 185)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 3
        '
        'P_FNameTextBox
        '
        Me.P_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_FName", True))
        Me.P_FNameTextBox.Location = New System.Drawing.Point(186, 211)
        Me.P_FNameTextBox.Name = "P_FNameTextBox"
        Me.P_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_FNameTextBox.TabIndex = 5
        '
        'P_LNameTextBox
        '
        Me.P_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_LName", True))
        Me.P_LNameTextBox.Location = New System.Drawing.Point(186, 237)
        Me.P_LNameTextBox.Name = "P_LNameTextBox"
        Me.P_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_LNameTextBox.TabIndex = 7
        '
        'P_AddressTextBox
        '
        Me.P_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Address", True))
        Me.P_AddressTextBox.Location = New System.Drawing.Point(186, 263)
        Me.P_AddressTextBox.Name = "P_AddressTextBox"
        Me.P_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_AddressTextBox.TabIndex = 9
        '
        'P_BirthDateTimePicker
        '
        Me.P_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientReferralBindingSource, "P_Birth", True))
        Me.P_BirthDateTimePicker.Location = New System.Drawing.Point(186, 341)
        Me.P_BirthDateTimePicker.Name = "P_BirthDateTimePicker"
        Me.P_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.P_BirthDateTimePicker.TabIndex = 15
        '
        'P_TelTextBox
        '
        Me.P_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Tel", True))
        Me.P_TelTextBox.Location = New System.Drawing.Point(186, 367)
        Me.P_TelTextBox.Name = "P_TelTextBox"
        Me.P_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_TelTextBox.TabIndex = 17
        '
        'P_SymptomTextBox
        '
        Me.P_SymptomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_Symptom", True))
        Me.P_SymptomTextBox.Location = New System.Drawing.Point(186, 393)
        Me.P_SymptomTextBox.Name = "P_SymptomTextBox"
        Me.P_SymptomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SymptomTextBox.TabIndex = 19
        '
        'Pr_FNameTextBox
        '
        Me.Pr_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_FName", True))
        Me.Pr_FNameTextBox.Location = New System.Drawing.Point(469, 213)
        Me.Pr_FNameTextBox.Name = "Pr_FNameTextBox"
        Me.Pr_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_FNameTextBox.TabIndex = 23
        '
        'Pr_LNameTextBox
        '
        Me.Pr_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_LName", True))
        Me.Pr_LNameTextBox.Location = New System.Drawing.Point(469, 239)
        Me.Pr_LNameTextBox.Name = "Pr_LNameTextBox"
        Me.Pr_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_LNameTextBox.TabIndex = 25
        '
        'Pr_AddressTextBox
        '
        Me.Pr_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Address", True))
        Me.Pr_AddressTextBox.Location = New System.Drawing.Point(469, 265)
        Me.Pr_AddressTextBox.Name = "Pr_AddressTextBox"
        Me.Pr_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_AddressTextBox.TabIndex = 27
        '
        'Pr_TelTextBox
        '
        Me.Pr_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Tel", True))
        Me.Pr_TelTextBox.Location = New System.Drawing.Point(469, 291)
        Me.Pr_TelTextBox.Name = "Pr_TelTextBox"
        Me.Pr_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_TelTextBox.TabIndex = 29
        '
        'Pr_RelationshipTextBox
        '
        Me.Pr_RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_Relationship", True))
        Me.Pr_RelationshipTextBox.Location = New System.Drawing.Point(469, 317)
        Me.Pr_RelationshipTextBox.Name = "Pr_RelationshipTextBox"
        Me.Pr_RelationshipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pr_RelationshipTextBox.TabIndex = 31
        '
        'L_FNameTextBox
        '
        Me.L_FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_FName", True))
        Me.L_FNameTextBox.Location = New System.Drawing.Point(186, 479)
        Me.L_FNameTextBox.Name = "L_FNameTextBox"
        Me.L_FNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_FNameTextBox.TabIndex = 35
        '
        'L_LNameTextBox
        '
        Me.L_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_LName", True))
        Me.L_LNameTextBox.Location = New System.Drawing.Point(186, 505)
        Me.L_LNameTextBox.Name = "L_LNameTextBox"
        Me.L_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_LNameTextBox.TabIndex = 37
        '
        'L_AddressTextBox
        '
        Me.L_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_Address", True))
        Me.L_AddressTextBox.Location = New System.Drawing.Point(186, 531)
        Me.L_AddressTextBox.Name = "L_AddressTextBox"
        Me.L_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_AddressTextBox.TabIndex = 39
        '
        'L_TelTextBox
        '
        Me.L_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_Tel", True))
        Me.L_TelTextBox.Location = New System.Drawing.Point(186, 557)
        Me.L_TelTextBox.Name = "L_TelTextBox"
        Me.L_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_TelTextBox.TabIndex = 41
        '
        'L_ClinicIDTextBox
        '
        Me.L_ClinicIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "L_ClinicID", True))
        Me.L_ClinicIDTextBox.Location = New System.Drawing.Point(186, 583)
        Me.L_ClinicIDTextBox.Name = "L_ClinicIDTextBox"
        Me.L_ClinicIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.L_ClinicIDTextBox.TabIndex = 43
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(186, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 31)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "PATIENT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(469, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 31)
        Me.TextBox2.TabIndex = 45
        Me.TextBox2.Text = "RELATIVE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(186, 416)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 31)
        Me.TextBox3.TabIndex = 46
        Me.TextBox3.Text = "LOCAL DOCTOR"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(582, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 20)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pr_id
        '
        Me.pr_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_FName", True))
        Me.pr_id.Location = New System.Drawing.Point(469, 186)
        Me.pr_id.Name = "pr_id"
        Me.pr_id.Size = New System.Drawing.Size(200, 20)
        Me.pr_id.TabIndex = 50
        Me.pr_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchR
        '
        Me.btnSearchR.Location = New System.Drawing.Point(675, 186)
        Me.btnSearchR.Name = "btnSearchR"
        Me.btnSearchR.Size = New System.Drawing.Size(66, 20)
        Me.btnSearchR.TabIndex = 51
        Me.btnSearchR.Text = "SEARCH"
        Me.btnSearchR.UseVisualStyleBackColor = True
        '
        'Hospital1
        '
        Me.Hospital1.DataSetName = "Hospital"
        Me.Hospital1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "Pr_FName", True))
        Me.TextBox5.Location = New System.Drawing.Point(186, 453)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 52
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchLD
        '
        Me.btnSearchLD.Location = New System.Drawing.Point(392, 453)
        Me.btnSearchLD.Name = "btnSearchLD"
        Me.btnSearchLD.Size = New System.Drawing.Size(66, 20)
        Me.btnSearchLD.TabIndex = 53
        Me.btnSearchLD.Text = "SEARCH"
        Me.btnSearchLD.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientReferralBindingSource, "P_FName", True))
        Me.TextBox6.Location = New System.Drawing.Point(60, 156)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 20)
        Me.TextBox6.TabIndex = 54
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(186, 288)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 56
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(186, 314)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 57
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.Hospital
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'btnSearchWard
        '
        Me.btnSearchWard.Location = New System.Drawing.Point(575, 348)
        Me.btnSearchWard.Name = "btnSearchWard"
        Me.btnSearchWard.Size = New System.Drawing.Size(66, 20)
        Me.btnSearchWard.TabIndex = 141
        Me.btnSearchWard.Text = "SEARCH"
        Me.btnSearchWard.UseVisualStyleBackColor = True
        '
        'W_NumberTextBox1
        '
        Me.W_NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "W_Number", True))
        Me.W_NumberTextBox1.Location = New System.Drawing.Point(469, 348)
        Me.W_NumberTextBox1.Name = "W_NumberTextBox1"
        Me.W_NumberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.W_NumberTextBox1.TabIndex = 142
        '
        'W_TypeTextBox1
        '
        Me.W_TypeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "W_Type", True))
        Me.W_TypeTextBox1.Location = New System.Drawing.Point(469, 374)
        Me.W_TypeTextBox1.Name = "W_TypeTextBox1"
        Me.W_TypeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.W_TypeTextBox1.TabIndex = 144
        '
        'W_LocationTextBox
        '
        Me.W_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "W_Location", True))
        Me.W_LocationTextBox.Location = New System.Drawing.Point(469, 400)
        Me.W_LocationTextBox.Name = "W_LocationTextBox"
        Me.W_LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_LocationTextBox.TabIndex = 146
        '
        'W_ExtTelTextBox
        '
        Me.W_ExtTelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "W_ExtTel", True))
        Me.W_ExtTelTextBox.Location = New System.Drawing.Point(469, 426)
        Me.W_ExtTelTextBox.Name = "W_ExtTelTextBox"
        Me.W_ExtTelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_ExtTelTextBox.TabIndex = 148
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(794, 113)
        Me.Panel3.TabIndex = 149
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label3)
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
        Me.Label2.Location = New System.Drawing.Point(50, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Referral"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(435, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Wellmedows Hospital"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'addPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 616)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.W_NumberTextBox1)
        Me.Controls.Add(Me.W_TypeTextBox1)
        Me.Controls.Add(W_LocationLabel)
        Me.Controls.Add(Me.W_LocationTextBox)
        Me.Controls.Add(W_ExtTelLabel)
        Me.Controls.Add(Me.W_ExtTelTextBox)
        Me.Controls.Add(Me.btnSearchWard)
        Me.Controls.Add(W_TypeLabel)
        Me.Controls.Add(W_NumberLabel)
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
        Me.Controls.Add(Pr_IDLabel)
        Me.Controls.Add(Pr_FNameLabel)
        Me.Controls.Add(Pr_LNameLabel)
        Me.Controls.Add(Pr_AddressLabel)
        Me.Controls.Add(Pr_TelLabel)
        Me.Controls.Add(Pr_RelationshipLabel)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.btnSearchLD)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnSearchR)
        Me.Controls.Add(Me.pr_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(Me.P_FNameTextBox)
        Me.Controls.Add(Me.P_LNameTextBox)
        Me.Controls.Add(Me.P_AddressTextBox)
        Me.Controls.Add(Me.P_BirthDateTimePicker)
        Me.Controls.Add(Me.P_TelTextBox)
        Me.Controls.Add(Me.P_SymptomTextBox)
        Me.Controls.Add(Me.Pr_FNameTextBox)
        Me.Controls.Add(Me.Pr_LNameTextBox)
        Me.Controls.Add(Me.Pr_AddressTextBox)
        Me.Controls.Add(Me.Pr_TelTextBox)
        Me.Controls.Add(Me.Pr_RelationshipTextBox)
        Me.Controls.Add(Me.L_FNameTextBox)
        Me.Controls.Add(Me.L_LNameTextBox)
        Me.Controls.Add(Me.L_AddressTextBox)
        Me.Controls.Add(Me.L_TelTextBox)
        Me.Controls.Add(Me.L_ClinicIDTextBox)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "addPatient"
        Me.Text = "addPatient"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientReferralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents PatientReferralBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents P_FNameTextBox As TextBox
    Friend WithEvents P_LNameTextBox As TextBox
    Friend WithEvents P_AddressTextBox As TextBox
    Friend WithEvents P_BirthDateTimePicker As DateTimePicker
    Friend WithEvents P_TelTextBox As TextBox
    Friend WithEvents P_SymptomTextBox As TextBox
    Friend WithEvents Pr_FNameTextBox As TextBox
    Friend WithEvents Pr_LNameTextBox As TextBox
    Friend WithEvents Pr_AddressTextBox As TextBox
    Friend WithEvents Pr_TelTextBox As TextBox
    Friend WithEvents Pr_RelationshipTextBox As TextBox
    Friend WithEvents L_FNameTextBox As TextBox
    Friend WithEvents L_LNameTextBox As TextBox
    Friend WithEvents L_AddressTextBox As TextBox
    Friend WithEvents L_TelTextBox As TextBox
    Friend WithEvents L_ClinicIDTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pr_id As TextBox
    Friend WithEvents btnSearchR As Button
    Friend WithEvents Hospital1 As Hospital
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnSearchLD As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As HospitalTableAdapters.WardsTableAdapter
    Friend WithEvents btnSearchWard As Button
    Friend WithEvents W_NumberTextBox1 As TextBox
    Friend WithEvents W_TypeTextBox1 As TextBox
    Friend WithEvents W_LocationTextBox As TextBox
    Friend WithEvents W_ExtTelTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
