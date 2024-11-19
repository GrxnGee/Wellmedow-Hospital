<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addQualification
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
        Dim Q_IDLabel As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim Q_TypeLabel As System.Windows.Forms.Label
        Dim Q_DateLabel As System.Windows.Forms.Label
        Dim Q_InstitutionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addQualification))
        Me.Hospital = New Wellmedow.Hospital()
        Me.QualificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualificationTableAdapter = New Wellmedow.HospitalTableAdapters.QualificationTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.Q_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Q_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Q_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Q_InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Q_IDLabel = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        Q_TypeLabel = New System.Windows.Forms.Label()
        Q_DateLabel = New System.Windows.Forms.Label()
        Q_InstitutionLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q_IDLabel
        '
        Q_IDLabel.AutoSize = True
        Q_IDLabel.Location = New System.Drawing.Point(193, 159)
        Q_IDLabel.Name = "Q_IDLabel"
        Q_IDLabel.Size = New System.Drawing.Size(87, 13)
        Q_IDLabel.TabIndex = 1
        Q_IDLabel.Text = "รหัส Qualification"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(193, 185)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 3
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'Q_TypeLabel
        '
        Q_TypeLabel.AutoSize = True
        Q_TypeLabel.Location = New System.Drawing.Point(214, 211)
        Q_TypeLabel.Name = "Q_TypeLabel"
        Q_TypeLabel.Size = New System.Drawing.Size(44, 13)
        Q_TypeLabel.TabIndex = 5
        Q_TypeLabel.Text = "ประเภท"
        '
        'Q_DateLabel
        '
        Q_DateLabel.AutoSize = True
        Q_DateLabel.Location = New System.Drawing.Point(214, 238)
        Q_DateLabel.Name = "Q_DateLabel"
        Q_DateLabel.Size = New System.Drawing.Size(54, 13)
        Q_DateLabel.TabIndex = 7
        Q_DateLabel.Text = "วันที่ได้รับ"
        '
        'Q_InstitutionLabel
        '
        Q_InstitutionLabel.AutoSize = True
        Q_InstitutionLabel.Location = New System.Drawing.Point(214, 263)
        Q_InstitutionLabel.Name = "Q_InstitutionLabel"
        Q_InstitutionLabel.Size = New System.Drawing.Size(40, 13)
        Q_InstitutionLabel.TabIndex = 9
        Q_InstitutionLabel.Text = "สถาบัน"
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QualificationBindingSource
        '
        Me.QualificationBindingSource.DataMember = "Qualification"
        Me.QualificationBindingSource.DataSource = Me.Hospital
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
        'Q_IDTextBox
        '
        Me.Q_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "Q_ID", True))
        Me.Q_IDTextBox.Location = New System.Drawing.Point(286, 156)
        Me.Q_IDTextBox.Name = "Q_IDTextBox"
        Me.Q_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Q_IDTextBox.TabIndex = 2
        '
        'Q_TypeTextBox
        '
        Me.Q_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "Q_Type", True))
        Me.Q_TypeTextBox.Location = New System.Drawing.Point(286, 208)
        Me.Q_TypeTextBox.Name = "Q_TypeTextBox"
        Me.Q_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Q_TypeTextBox.TabIndex = 6
        '
        'Q_DateDateTimePicker
        '
        Me.Q_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QualificationBindingSource, "Q_Date", True))
        Me.Q_DateDateTimePicker.Location = New System.Drawing.Point(286, 234)
        Me.Q_DateDateTimePicker.Name = "Q_DateDateTimePicker"
        Me.Q_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Q_DateDateTimePicker.TabIndex = 8
        '
        'Q_InstitutionTextBox
        '
        Me.Q_InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "Q_Institution", True))
        Me.Q_InstitutionTextBox.Location = New System.Drawing.Point(286, 260)
        Me.Q_InstitutionTextBox.Name = "Q_InstitutionTextBox"
        Me.Q_InstitutionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Q_InstitutionTextBox.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 114)
        Me.Panel3.TabIndex = 26
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
        Me.Panel1.Location = New System.Drawing.Point(0, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 20)
        Me.Panel1.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(358, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 50)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(286, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'addQualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Q_IDLabel)
        Me.Controls.Add(Me.Q_IDTextBox)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(Q_TypeLabel)
        Me.Controls.Add(Me.Q_TypeTextBox)
        Me.Controls.Add(Q_DateLabel)
        Me.Controls.Add(Me.Q_DateDateTimePicker)
        Me.Controls.Add(Q_InstitutionLabel)
        Me.Controls.Add(Me.Q_InstitutionTextBox)
        Me.Name = "addQualification"
        Me.Text = "addQualification"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hospital As Hospital
    Friend WithEvents QualificationBindingSource As BindingSource
    Friend WithEvents QualificationTableAdapter As HospitalTableAdapters.QualificationTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents Q_IDTextBox As TextBox
    Friend WithEvents Q_TypeTextBox As TextBox
    Friend WithEvents Q_DateDateTimePicker As DateTimePicker
    Friend WithEvents Q_InstitutionTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
