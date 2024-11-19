<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientAllocate
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
        Dim A_IDLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim W_NumberLabel As System.Windows.Forms.Label
        Dim A_DateLabel As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim P_SymptomLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAllocate))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Hospital = New Wellmedow.Hospital()
        Me.PatientAllocateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientAllocateTableAdapter = New Wellmedow.HospitalTableAdapters.PatientAllocateTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.PatientAllocateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.W_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.A_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.P_SymptomTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        A_IDLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        W_NumberLabel = New System.Windows.Forms.Label()
        A_DateLabel = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        P_SymptomLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientAllocateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientAllocateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A_IDLabel
        '
        A_IDLabel.AutoSize = True
        A_IDLabel.Location = New System.Drawing.Point(363, 133)
        A_IDLabel.Name = "A_IDLabel"
        A_IDLabel.Size = New System.Drawing.Size(85, 13)
        A_IDLabel.TabIndex = 61
        A_IDLabel.Text = "รหัสการนัดหมาย"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(363, 158)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(77, 13)
        P_IDLabel.TabIndex = 63
        P_IDLabel.Text = "หมายเลขผู้ป่วย"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(377, 184)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 65
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'A_DateLabel
        '
        A_DateLabel.AutoSize = True
        A_DateLabel.Location = New System.Drawing.Point(377, 211)
        A_DateLabel.Name = "A_DateLabel"
        A_DateLabel.Size = New System.Drawing.Size(69, 13)
        A_DateLabel.TabIndex = 67
        A_DateLabel.Text = "วันที่นัดหมาย"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(352, 236)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 69
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'P_SymptomLabel
        '
        P_SymptomLabel.AutoSize = True
        P_SymptomLabel.Location = New System.Drawing.Point(377, 262)
        P_SymptomLabel.Name = "P_SymptomLabel"
        P_SymptomLabel.Size = New System.Drawing.Size(63, 13)
        P_SymptomLabel.TabIndex = 71
        P_SymptomLabel.Text = "ผลการตรวจ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1051, 113)
        Me.Panel3.TabIndex = 57
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
        Me.Label2.Location = New System.Drawing.Point(0, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(548, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Allocate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(393, 6)
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
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientAllocateBindingSource
        '
        Me.PatientAllocateBindingSource.DataMember = "PatientAllocate"
        Me.PatientAllocateBindingSource.DataSource = Me.Hospital
        '
        'PatientAllocateTableAdapter
        '
        Me.PatientAllocateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientAllocateTableAdapter = Me.PatientAllocateTableAdapter
        Me.TableAdapterManager.PatientReferralTableAdapter = Nothing
        Me.TableAdapterManager.PatientRelativesTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardRequestTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'PatientAllocateDataGridView
        '
        Me.PatientAllocateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientAllocateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.P_Fname, Me.P_Lname, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.S_Fname, Me.S_Lname, Me.DataGridViewTextBoxColumn6})
        Me.PatientAllocateDataGridView.Location = New System.Drawing.Point(3, 314)
        Me.PatientAllocateDataGridView.Name = "PatientAllocateDataGridView"
        Me.PatientAllocateDataGridView.Size = New System.Drawing.Size(1047, 202)
        Me.PatientAllocateDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "A_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'P_Fname
        '
        Me.P_Fname.HeaderText = "Pfname"
        Me.P_Fname.Name = "P_Fname"
        '
        'P_Lname
        '
        Me.P_Lname.HeaderText = "P_lname"
        Me.P_Lname.Name = "P_Lname"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "W_Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "A_Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "S_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'S_Fname
        '
        Me.S_Fname.HeaderText = "S_Fname"
        Me.S_Fname.Name = "S_Fname"
        '
        'S_Lname
        '
        Me.S_Lname.HeaderText = "S_Lname"
        Me.S_Lname.Name = "S_Lname"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Resault"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(498, 545)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 50)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "Allocate"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(511, 523)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 60
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 614)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 14)
        Me.Panel1.TabIndex = 61
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(446, 155)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 64
        '
        'W_NumberTextBox
        '
        Me.W_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "W_Number", True))
        Me.W_NumberTextBox.Location = New System.Drawing.Point(446, 181)
        Me.W_NumberTextBox.Name = "W_NumberTextBox"
        Me.W_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.W_NumberTextBox.TabIndex = 66
        '
        'A_DateDateTimePicker
        '
        Me.A_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientAllocateBindingSource, "A_Date", True))
        Me.A_DateDateTimePicker.Location = New System.Drawing.Point(446, 207)
        Me.A_DateDateTimePicker.Name = "A_DateDateTimePicker"
        Me.A_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.A_DateDateTimePicker.TabIndex = 68
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(446, 233)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_IDTextBox.TabIndex = 70
        '
        'P_SymptomTextBox
        '
        Me.P_SymptomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_Symptom", True))
        Me.P_SymptomTextBox.Location = New System.Drawing.Point(446, 259)
        Me.P_SymptomTextBox.Name = "P_SymptomTextBox"
        Me.P_SymptomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SymptomTextBox.TabIndex = 72
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(652, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(446, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "DELETE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(560, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 23)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "SUBMIT EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(446, 130)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 83
        '
        'PatientAllocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 628)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(A_IDLabel)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(W_NumberLabel)
        Me.Controls.Add(Me.W_NumberTextBox)
        Me.Controls.Add(A_DateLabel)
        Me.Controls.Add(Me.A_DateDateTimePicker)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(P_SymptomLabel)
        Me.Controls.Add(Me.P_SymptomTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PatientAllocateDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "PatientAllocate"
        Me.Text = "PatientAllocate"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientAllocateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientAllocateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Hospital As Hospital
    Friend WithEvents PatientAllocateBindingSource As BindingSource
    Friend WithEvents PatientAllocateTableAdapter As HospitalTableAdapters.PatientAllocateTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents PatientAllocateDataGridView As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents W_NumberTextBox As TextBox
    Friend WithEvents A_DateDateTimePicker As DateTimePicker
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents P_SymptomTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents P_Fname As DataGridViewTextBoxColumn
    Friend WithEvents P_Lname As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents S_Fname As DataGridViewTextBoxColumn
    Friend WithEvents S_Lname As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
