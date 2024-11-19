<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewStaff
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
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.S_LNameTextBox = New System.Windows.Forms.TextBox()
        Me.S_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.S_TelTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.S_FNmeTextBox = New System.Windows.Forms.TextBox()
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
        Me.TableAdapterManager.PatientReferralTableAdapter = Nothing
        Me.TableAdapterManager.PatientRelativesTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(283, 78)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(31, 13)
        S_IDLabel.TabIndex = 0
        S_IDLabel.Text = "S ID:"
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(359, 75)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_IDTextBox.TabIndex = 1
        '
        'S_LNameLabel
        '
        S_LNameLabel.AutoSize = True
        S_LNameLabel.Location = New System.Drawing.Point(283, 104)
        S_LNameLabel.Name = "S_LNameLabel"
        S_LNameLabel.Size = New System.Drawing.Size(54, 13)
        S_LNameLabel.TabIndex = 2
        S_LNameLabel.Text = "S LName:"
        '
        'S_LNameTextBox
        '
        Me.S_LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_LName", True))
        Me.S_LNameTextBox.Location = New System.Drawing.Point(359, 101)
        Me.S_LNameTextBox.Name = "S_LNameTextBox"
        Me.S_LNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_LNameTextBox.TabIndex = 3
        '
        'S_BirthLabel
        '
        S_BirthLabel.AutoSize = True
        S_BirthLabel.Location = New System.Drawing.Point(283, 157)
        S_BirthLabel.Name = "S_BirthLabel"
        S_BirthLabel.Size = New System.Drawing.Size(41, 13)
        S_BirthLabel.TabIndex = 4
        S_BirthLabel.Text = "S Birth:"
        '
        'S_BirthDateTimePicker
        '
        Me.S_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "S_Birth", True))
        Me.S_BirthDateTimePicker.Location = New System.Drawing.Point(359, 153)
        Me.S_BirthDateTimePicker.Name = "S_BirthDateTimePicker"
        Me.S_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.S_BirthDateTimePicker.TabIndex = 5
        '
        'S_SexLabel
        '
        S_SexLabel.AutoSize = True
        S_SexLabel.Location = New System.Drawing.Point(283, 182)
        S_SexLabel.Name = "S_SexLabel"
        S_SexLabel.Size = New System.Drawing.Size(38, 13)
        S_SexLabel.TabIndex = 6
        S_SexLabel.Text = "S Sex:"
        '
        'S_AddressLabel
        '
        S_AddressLabel.AutoSize = True
        S_AddressLabel.Location = New System.Drawing.Point(283, 208)
        S_AddressLabel.Name = "S_AddressLabel"
        S_AddressLabel.Size = New System.Drawing.Size(58, 13)
        S_AddressLabel.TabIndex = 8
        S_AddressLabel.Text = "S Address:"
        '
        'S_AddressTextBox
        '
        Me.S_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Address", True))
        Me.S_AddressTextBox.Location = New System.Drawing.Point(359, 205)
        Me.S_AddressTextBox.Name = "S_AddressTextBox"
        Me.S_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_AddressTextBox.TabIndex = 9
        '
        'S_TelLabel
        '
        S_TelLabel.AutoSize = True
        S_TelLabel.Location = New System.Drawing.Point(283, 234)
        S_TelLabel.Name = "S_TelLabel"
        S_TelLabel.Size = New System.Drawing.Size(35, 13)
        S_TelLabel.TabIndex = 10
        S_TelLabel.Text = "S Tel:"
        '
        'S_TelTextBox
        '
        Me.S_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_Tel", True))
        Me.S_TelTextBox.Location = New System.Drawing.Point(359, 231)
        Me.S_TelTextBox.Name = "S_TelTextBox"
        Me.S_TelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_TelTextBox.TabIndex = 11
        '
        'S_GraduatedLabel
        '
        S_GraduatedLabel.AutoSize = True
        S_GraduatedLabel.Location = New System.Drawing.Point(283, 260)
        S_GraduatedLabel.Name = "S_GraduatedLabel"
        S_GraduatedLabel.Size = New System.Drawing.Size(70, 13)
        S_GraduatedLabel.TabIndex = 12
        S_GraduatedLabel.Text = "S Graduated:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(283, 286)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 14
        SalaryLabel.Text = "Salary:"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(359, 283)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalaryTextBox.TabIndex = 15
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(283, 312)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 16
        PositionLabel.Text = "Position:"
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(359, 309)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PositionTextBox.TabIndex = 17
        '
        'S_FNmeLabel
        '
        S_FNmeLabel.AutoSize = True
        S_FNmeLabel.Location = New System.Drawing.Point(283, 130)
        S_FNmeLabel.Name = "S_FNmeLabel"
        S_FNmeLabel.Size = New System.Drawing.Size(48, 13)
        S_FNmeLabel.TabIndex = 18
        S_FNmeLabel.Text = "S FNme:"
        '
        'S_FNmeTextBox
        '
        Me.S_FNmeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "S_FNme", True))
        Me.S_FNmeTextBox.Location = New System.Drawing.Point(359, 127)
        Me.S_FNmeTextBox.Name = "S_FNmeTextBox"
        Me.S_FNmeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_FNmeTextBox.TabIndex = 19
        '
        'AddNewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(S_LNameLabel)
        Me.Controls.Add(Me.S_LNameTextBox)
        Me.Controls.Add(S_BirthLabel)
        Me.Controls.Add(Me.S_BirthDateTimePicker)
        Me.Controls.Add(S_SexLabel)
        Me.Controls.Add(S_AddressLabel)
        Me.Controls.Add(Me.S_AddressTextBox)
        Me.Controls.Add(S_TelLabel)
        Me.Controls.Add(Me.S_TelTextBox)
        Me.Controls.Add(S_GraduatedLabel)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(S_FNmeLabel)
        Me.Controls.Add(Me.S_FNmeTextBox)
        Me.Name = "AddNewStaff"
        Me.Text = "AddNewStaff"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hospital As Hospital
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As HospitalTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents S_LNameTextBox As TextBox
    Friend WithEvents S_BirthDateTimePicker As DateTimePicker
    Friend WithEvents S_AddressTextBox As TextBox
    Friend WithEvents S_TelTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents S_FNmeTextBox As TextBox
End Class
