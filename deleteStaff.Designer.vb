<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteStaff))
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim S_LNameLabel As System.Windows.Forms.Label
        Dim S_BirthLabel As System.Windows.Forms.Label
        Dim S_SexLabel As System.Windows.Forms.Label
        Dim S_AddressLabel As System.Windows.Forms.Label
        Dim S_TelLabel As System.Windows.Forms.Label
        Dim S_GraduatedLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim S_FNmeLabel As System.Windows.Forms.Label
        Me.Hospital = New Wellmedow.Hospital()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Wellmedow.HospitalTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.S_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.S_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_SexTextBox = New System.Windows.Forms.TextBox()
        Me.S_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.S_TelTextBox = New System.Windows.Forms.TextBox()
        Me.S_GraduatedTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.S_FNmeTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        S_IDLabel = New System.Windows.Forms.Label()
        S_LNameLabel = New System.Windows.Forms.Label()
        S_BirthLabel = New System.Windows.Forms.Label()
        S_SexLabel = New System.Windows.Forms.Label()
        S_AddressLabel = New System.Windows.Forms.Label()
        S_TelLabel = New System.Windows.Forms.Label()
        S_GraduatedLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        S_FNmeLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Hospital
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardRequestTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(224, 386)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 50)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(430, 126)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'S_LNameTextBox
        '
        Me.S_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_LName", True))
        Me.S_LNameTextBox.Location = New System.Drawing.Point(224, 177)
        Me.S_LNameTextBox.Name = "S_LNameTextBox"
        Me.S_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_LNameTextBox.TabIndex = 25
        '
        'S_BirthDateTimePicker
        '
        Me.S_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "S_Birth", True))
        Me.S_BirthDateTimePicker.Location = New System.Drawing.Point(224, 203)
        Me.S_BirthDateTimePicker.Name = "S_BirthDateTimePicker"
        Me.S_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.S_BirthDateTimePicker.TabIndex = 27
        '
        'S_SexTextBox
        '
        Me.S_SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Sex", True))
        Me.S_SexTextBox.Location = New System.Drawing.Point(224, 229)
        Me.S_SexTextBox.Name = "S_SexTextBox"
        Me.S_SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_SexTextBox.TabIndex = 29
        '
        'S_AddressTextBox
        '
        Me.S_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Address", True))
        Me.S_AddressTextBox.Location = New System.Drawing.Point(224, 255)
        Me.S_AddressTextBox.Name = "S_AddressTextBox"
        Me.S_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_AddressTextBox.TabIndex = 31
        '
        'S_TelTextBox
        '
        Me.S_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Tel", True))
        Me.S_TelTextBox.Location = New System.Drawing.Point(224, 281)
        Me.S_TelTextBox.Name = "S_TelTextBox"
        Me.S_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_TelTextBox.TabIndex = 33
        '
        'S_GraduatedTextBox
        '
        Me.S_GraduatedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Graduated", True))
        Me.S_GraduatedTextBox.Location = New System.Drawing.Point(224, 307)
        Me.S_GraduatedTextBox.Name = "S_GraduatedTextBox"
        Me.S_GraduatedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_GraduatedTextBox.TabIndex = 35
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(224, 333)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalaryTextBox.TabIndex = 37
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(224, 359)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PositionTextBox.TabIndex = 39
        '
        'S_FNmeTextBox
        '
        Me.S_FNmeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_FNme", True))
        Me.S_FNmeTextBox.Location = New System.Drawing.Point(224, 153)
        Me.S_FNmeTextBox.Name = "S_FNmeTextBox"
        Me.S_FNmeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_FNmeTextBox.TabIndex = 41
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(224, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(633, 114)
        Me.Panel3.TabIndex = 43
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
        Me.Label2.Location = New System.Drawing.Point(3, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hospital Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(326, 6)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 484)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 63)
        Me.Panel1.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(365, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 50)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "SUBMIT EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(129, 130)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 46
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'S_LNameLabel
        '
        S_LNameLabel.AutoSize = True
        S_LNameLabel.Location = New System.Drawing.Point(147, 156)
        S_LNameLabel.Name = "S_LNameLabel"
        S_LNameLabel.Size = New System.Drawing.Size(20, 13)
        S_LNameLabel.TabIndex = 47
        S_LNameLabel.Text = "ชื่อ"
        '
        'S_BirthLabel
        '
        S_BirthLabel.AutoSize = True
        S_BirthLabel.Location = New System.Drawing.Point(147, 209)
        S_BirthLabel.Name = "S_BirthLabel"
        S_BirthLabel.Size = New System.Drawing.Size(40, 13)
        S_BirthLabel.TabIndex = 48
        S_BirthLabel.Text = "วันเกิด"
        '
        'S_SexLabel
        '
        S_SexLabel.AutoSize = True
        S_SexLabel.Location = New System.Drawing.Point(147, 234)
        S_SexLabel.Name = "S_SexLabel"
        S_SexLabel.Size = New System.Drawing.Size(28, 13)
        S_SexLabel.TabIndex = 49
        S_SexLabel.Text = "เพศ"
        '
        'S_AddressLabel
        '
        S_AddressLabel.AutoSize = True
        S_AddressLabel.Location = New System.Drawing.Point(147, 260)
        S_AddressLabel.Name = "S_AddressLabel"
        S_AddressLabel.Size = New System.Drawing.Size(27, 13)
        S_AddressLabel.TabIndex = 50
        S_AddressLabel.Text = "ที่อยู่"
        '
        'S_TelLabel
        '
        S_TelLabel.AutoSize = True
        S_TelLabel.Location = New System.Drawing.Point(147, 286)
        S_TelLabel.Name = "S_TelLabel"
        S_TelLabel.Size = New System.Drawing.Size(49, 13)
        S_TelLabel.TabIndex = 51
        S_TelLabel.Text = "เบอร์โทร"
        '
        'S_GraduatedLabel
        '
        S_GraduatedLabel.AutoSize = True
        S_GraduatedLabel.Location = New System.Drawing.Point(147, 312)
        S_GraduatedLabel.Name = "S_GraduatedLabel"
        S_GraduatedLabel.Size = New System.Drawing.Size(23, 13)
        S_GraduatedLabel.TabIndex = 52
        S_GraduatedLabel.Text = "วุฒิ"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(147, 338)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(51, 13)
        SalaryLabel.TabIndex = 53
        SalaryLabel.Text = "เงินเดือน"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(147, 364)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(74, 13)
        PositionLabel.TabIndex = 54
        PositionLabel.Text = "ตำแหน่งหน้าที่"
        '
        'S_FNmeLabel
        '
        S_FNmeLabel.AutoSize = True
        S_FNmeLabel.Location = New System.Drawing.Point(147, 182)
        S_FNmeLabel.Name = "S_FNmeLabel"
        S_FNmeLabel.Size = New System.Drawing.Size(46, 13)
        S_FNmeLabel.TabIndex = 55
        S_FNmeLabel.Text = "นามสกุล"
        '
        'deleteStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 547)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(S_LNameLabel)
        Me.Controls.Add(S_BirthLabel)
        Me.Controls.Add(S_SexLabel)
        Me.Controls.Add(S_AddressLabel)
        Me.Controls.Add(S_TelLabel)
        Me.Controls.Add(S_GraduatedLabel)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(S_FNmeLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.S_LNameTextBox)
        Me.Controls.Add(Me.S_BirthDateTimePicker)
        Me.Controls.Add(Me.S_SexTextBox)
        Me.Controls.Add(Me.S_AddressTextBox)
        Me.Controls.Add(Me.S_TelTextBox)
        Me.Controls.Add(Me.S_GraduatedTextBox)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Me.S_FNmeTextBox)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "deleteStaff"
        Me.Text = "deleteStaff"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hospital As Hospital
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As HospitalTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents S_LNameTextBox As TextBox
    Friend WithEvents S_BirthDateTimePicker As DateTimePicker
    Friend WithEvents S_SexTextBox As TextBox
    Friend WithEvents S_AddressTextBox As TextBox
    Friend WithEvents S_TelTextBox As TextBox
    Friend WithEvents S_GraduatedTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents S_FNmeTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
