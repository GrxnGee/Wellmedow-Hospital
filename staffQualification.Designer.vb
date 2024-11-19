<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffQualification
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
        Dim Q_IDLabel As System.Windows.Forms.Label
        Dim Q_IDLabel1 As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim Q_TypeLabel As System.Windows.Forms.Label
        Dim Q_DateLabel As System.Windows.Forms.Label
        Dim Q_InstitutionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffQualification))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QualificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital = New Wellmedow.Hospital()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.QualificationTableAdapter = New Wellmedow.HospitalTableAdapters.QualificationTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Wellmedow.HospitalTableAdapters.StaffTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.QualificationDataGridView = New System.Windows.Forms.DataGridView()
        Me.QIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_Fnme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_LName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QInstitutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Q_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Q_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Q_InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Q_IDLabel = New System.Windows.Forms.Label()
        Q_IDLabel1 = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        Q_TypeLabel = New System.Windows.Forms.Label()
        Q_DateLabel = New System.Windows.Forms.Label()
        Q_InstitutionLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.QualificationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q_IDLabel
        '
        Q_IDLabel.AutoSize = True
        Q_IDLabel.Location = New System.Drawing.Point(276, 298)
        Q_IDLabel.Name = "Q_IDLabel"
        Q_IDLabel.Size = New System.Drawing.Size(44, 13)
        Q_IDLabel.TabIndex = 54
        Q_IDLabel.Text = "ประเภท"
        '
        'Q_IDLabel1
        '
        Q_IDLabel1.AutoSize = True
        Q_IDLabel1.Location = New System.Drawing.Point(242, 144)
        Q_IDLabel1.Name = "Q_IDLabel1"
        Q_IDLabel1.Size = New System.Drawing.Size(87, 13)
        Q_IDLabel1.TabIndex = 68
        Q_IDLabel1.Text = "รหัส Qualification"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(242, 171)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 70
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'Q_TypeLabel
        '
        Q_TypeLabel.AutoSize = True
        Q_TypeLabel.Location = New System.Drawing.Point(263, 197)
        Q_TypeLabel.Name = "Q_TypeLabel"
        Q_TypeLabel.Size = New System.Drawing.Size(44, 13)
        Q_TypeLabel.TabIndex = 72
        Q_TypeLabel.Text = "ประเภท"
        '
        'Q_DateLabel
        '
        Q_DateLabel.AutoSize = True
        Q_DateLabel.Location = New System.Drawing.Point(263, 224)
        Q_DateLabel.Name = "Q_DateLabel"
        Q_DateLabel.Size = New System.Drawing.Size(54, 13)
        Q_DateLabel.TabIndex = 74
        Q_DateLabel.Text = "วันที่ได้รับ"
        '
        'Q_InstitutionLabel
        '
        Q_InstitutionLabel.AutoSize = True
        Q_InstitutionLabel.Location = New System.Drawing.Point(263, 249)
        Q_InstitutionLabel.Name = "Q_InstitutionLabel"
        Q_InstitutionLabel.Size = New System.Drawing.Size(40, 13)
        Q_InstitutionLabel.TabIndex = 76
        Q_InstitutionLabel.Text = "สถาบัน"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(892, 114)
        Me.Panel3.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(140, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(517, 111)
        Me.Panel6.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(77, 25)
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
        Me.Label1.Location = New System.Drawing.Point(381, 6)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 649)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 20)
        Me.Panel1.TabIndex = 26
        '
        'QualificationBindingSource
        '
        Me.QualificationBindingSource.DataMember = "Qualification"
        Me.QualificationBindingSource.DataSource = Me.Hospital
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(381, 547)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 67
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(355, 573)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(130, 56)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 50)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'QualificationTableAdapter
        '
        Me.QualificationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.QualificationTableAdapter = Me.QualificationTableAdapter
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardRequestTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_LName", True))
        Me.TextBox1.Location = New System.Drawing.Point(335, 295)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 68
        '
        'QualificationDataGridView
        '
        Me.QualificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualificationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QIDDataGridViewTextBoxColumn, Me.SIDDataGridViewTextBoxColumn, Me.S_Fnme, Me.S_LName, Me.QTypeDataGridViewTextBoxColumn, Me.QDateDataGridViewTextBoxColumn, Me.QInstitutionDataGridViewTextBoxColumn})
        Me.QualificationDataGridView.Location = New System.Drawing.Point(66, 321)
        Me.QualificationDataGridView.Name = "QualificationDataGridView"
        Me.QualificationDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.QualificationDataGridView.TabIndex = 68
        '
        'QIDDataGridViewTextBoxColumn
        '
        Me.QIDDataGridViewTextBoxColumn.HeaderText = "Q_ID"
        Me.QIDDataGridViewTextBoxColumn.Name = "QIDDataGridViewTextBoxColumn"
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        '
        'S_Fnme
        '
        Me.S_Fnme.HeaderText = "S_Fname"
        Me.S_Fnme.Name = "S_Fnme"
        '
        'S_LName
        '
        Me.S_LName.HeaderText = "S_LName"
        Me.S_LName.Name = "S_LName"
        '
        'QTypeDataGridViewTextBoxColumn
        '
        Me.QTypeDataGridViewTextBoxColumn.HeaderText = "Q_Type"
        Me.QTypeDataGridViewTextBoxColumn.Name = "QTypeDataGridViewTextBoxColumn"
        '
        'QDateDataGridViewTextBoxColumn
        '
        Me.QDateDataGridViewTextBoxColumn.HeaderText = "Q_Date"
        Me.QDateDataGridViewTextBoxColumn.Name = "QDateDataGridViewTextBoxColumn"
        '
        'QInstitutionDataGridViewTextBoxColumn
        '
        Me.QInstitutionDataGridViewTextBoxColumn.HeaderText = "Q_Institution"
        Me.QInstitutionDataGridViewTextBoxColumn.Name = "QInstitutionDataGridViewTextBoxColumn"
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(335, 168)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_IDTextBox.TabIndex = 71
        '
        'Q_TypeTextBox
        '
        Me.Q_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "Q_Type", True))
        Me.Q_TypeTextBox.Location = New System.Drawing.Point(335, 194)
        Me.Q_TypeTextBox.Name = "Q_TypeTextBox"
        Me.Q_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Q_TypeTextBox.TabIndex = 73
        '
        'Q_DateDateTimePicker
        '
        Me.Q_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QualificationBindingSource, "Q_Date", True))
        Me.Q_DateDateTimePicker.Location = New System.Drawing.Point(335, 220)
        Me.Q_DateDateTimePicker.Name = "Q_DateDateTimePicker"
        Me.Q_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Q_DateDateTimePicker.TabIndex = 75
        '
        'Q_InstitutionTextBox
        '
        Me.Q_InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "Q_Institution", True))
        Me.Q_InstitutionTextBox.Location = New System.Drawing.Point(335, 246)
        Me.Q_InstitutionTextBox.Name = "Q_InstitutionTextBox"
        Me.Q_InstitutionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Q_InstitutionTextBox.TabIndex = 77
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(335, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 78
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(541, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Confirm Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'staffQualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 669)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Q_IDLabel1)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(Q_TypeLabel)
        Me.Controls.Add(Me.Q_TypeTextBox)
        Me.Controls.Add(Q_DateLabel)
        Me.Controls.Add(Me.Q_DateDateTimePicker)
        Me.Controls.Add(Q_InstitutionLabel)
        Me.Controls.Add(Me.Q_InstitutionTextBox)
        Me.Controls.Add(Me.QualificationDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Q_IDLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "staffQualification"
        Me.Text = " "
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.QualificationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Hospital As Hospital
    Friend WithEvents QualificationBindingSource As BindingSource
    Friend WithEvents QualificationTableAdapter As HospitalTableAdapters.QualificationTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As HospitalTableAdapters.StaffTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents QualificationDataGridView As DataGridView
    Friend WithEvents QIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents S_Fnme As DataGridViewTextBoxColumn
    Friend WithEvents S_LName As DataGridViewTextBoxColumn
    Friend WithEvents QTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QInstitutionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents Q_TypeTextBox As TextBox
    Friend WithEvents Q_DateDateTimePicker As DateTimePicker
    Friend WithEvents Q_InstitutionTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAdd As Button
End Class
