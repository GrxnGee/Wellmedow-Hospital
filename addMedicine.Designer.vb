<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addMedicine
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
        Dim M_IDLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim D_IDLabel As System.Windows.Forms.Label
        Dim D_UPDLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMedicine))
        Me.Hospital = New Wellmedow.Hospital()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.MedicationTableAdapter = New Wellmedow.HospitalTableAdapters.MedicationTableAdapter()
        Me.M_IDTextBox = New System.Windows.Forms.TextBox()
        Me.D_UPDTextBox = New System.Windows.Forms.TextBox()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.patientName = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        M_IDLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        D_IDLabel = New System.Windows.Forms.Label()
        D_UPDLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'M_IDLabel
        '
        M_IDLabel.AutoSize = True
        M_IDLabel.Location = New System.Drawing.Point(112, 136)
        M_IDLabel.Name = "M_IDLabel"
        M_IDLabel.Size = New System.Drawing.Size(62, 13)
        M_IDLabel.TabIndex = 46
        M_IDLabel.Text = "หมายเลขยา"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(93, 162)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(77, 13)
        P_IDLabel.TabIndex = 48
        P_IDLabel.Text = "หมายเลขผู้ป่วย"
        '
        'D_IDLabel
        '
        D_IDLabel.AutoSize = True
        D_IDLabel.Location = New System.Drawing.Point(112, 212)
        D_IDLabel.Name = "D_IDLabel"
        D_IDLabel.Size = New System.Drawing.Size(62, 13)
        D_IDLabel.TabIndex = 50
        D_IDLabel.Text = "หมายเลขยา"
        '
        'D_UPDLabel
        '
        D_UPDLabel.AutoSize = True
        D_UPDLabel.Location = New System.Drawing.Point(112, 266)
        D_UPDLabel.Name = "D_UPDLabel"
        D_UPDLabel.Size = New System.Drawing.Size(59, 13)
        D_UPDLabel.TabIndex = 52
        D_UPDLabel.Text = "จำนวน/วัน"
        '
        'Start_DateLabel
        '
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Location = New System.Drawing.Point(94, 295)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(76, 13)
        Start_DateLabel.TabIndex = 54
        Start_DateLabel.Text = "วันที่เรื่มจ่ายยา"
        '
        'End_DateLabel
        '
        End_DateLabel.AutoSize = True
        End_DateLabel.Location = New System.Drawing.Point(91, 321)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(79, 13)
        End_DateLabel.TabIndex = 56
        End_DateLabel.Text = "วันที่หยุดจ่ายยา"
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(245, 341)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 50)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'MedicationBindingSource
        '
        Me.MedicationBindingSource.DataMember = "Medication"
        Me.MedicationBindingSource.DataSource = Me.Hospital
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientAllocateTableAdapter = Nothing
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
        'MedicationTableAdapter
        '
        Me.MedicationTableAdapter.ClearBeforeFill = True
        '
        'M_IDTextBox
        '
        Me.M_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationBindingSource, "M_ID", True))
        Me.M_IDTextBox.Location = New System.Drawing.Point(176, 133)
        Me.M_IDTextBox.Name = "M_IDTextBox"
        Me.M_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.M_IDTextBox.TabIndex = 47
        '
        'D_UPDTextBox
        '
        Me.D_UPDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationBindingSource, "D_UPD", True))
        Me.D_UPDTextBox.Location = New System.Drawing.Point(176, 263)
        Me.D_UPDTextBox.Name = "D_UPDTextBox"
        Me.D_UPDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.D_UPDTextBox.TabIndex = 53
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicationBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(176, 289)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Start_DateDateTimePicker.TabIndex = 55
        '
        'End_DateDateTimePicker
        '
        Me.End_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicationBindingSource, "End_Date", True))
        Me.End_DateDateTimePicker.Location = New System.Drawing.Point(176, 315)
        Me.End_DateDateTimePicker.Name = "End_DateDateTimePicker"
        Me.End_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.End_DateDateTimePicker.TabIndex = 57
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(176, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox1.TabIndex = 58
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(176, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox2.TabIndex = 59
        '
        'patientName
        '
        Me.patientName.Location = New System.Drawing.Point(176, 186)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(200, 20)
        Me.patientName.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(176, 237)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Confirm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(545, 113)
        Me.Panel3.TabIndex = 64
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
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Medication"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(241, 6)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 62)
        Me.Panel1.TabIndex = 65
        '
        'addMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.patientName)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(M_IDLabel)
        Me.Controls.Add(Me.M_IDTextBox)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(D_IDLabel)
        Me.Controls.Add(D_UPDLabel)
        Me.Controls.Add(Me.D_UPDTextBox)
        Me.Controls.Add(Start_DateLabel)
        Me.Controls.Add(Me.Start_DateDateTimePicker)
        Me.Controls.Add(End_DateLabel)
        Me.Controls.Add(Me.End_DateDateTimePicker)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "addMedicine"
        Me.Text = "addMedicine"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hospital As Hospital
    Friend WithEvents MedicationBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents btnAdd As Button
    Friend WithEvents MedicationTableAdapter As HospitalTableAdapters.MedicationTableAdapter
    Friend WithEvents M_IDTextBox As TextBox
    Friend WithEvents D_UPDTextBox As TextBox
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents End_DateDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents patientName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
