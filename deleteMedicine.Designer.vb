<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deleteMedicine
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
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim D_IDLabel As System.Windows.Forms.Label
        Dim D_UPDLabel As System.Windows.Forms.Label
        Dim M_IDLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteMedicine))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Hospital = New Wellmedow.Hospital()
        Me.MedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicationTableAdapter = New Wellmedow.HospitalTableAdapters.MedicationTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.D_IDTextBox = New System.Windows.Forms.TextBox()
        Me.D_UPDTextBox = New System.Windows.Forms.TextBox()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        D_IDLabel = New System.Windows.Forms.Label()
        D_UPDLabel = New System.Windows.Forms.Label()
        M_IDLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start_DateLabel
        '
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Location = New System.Drawing.Point(102, 246)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(64, 13)
        Start_DateLabel.TabIndex = 77
        Start_DateLabel.Text = "วันที่เริ่มจ่าย"
        '
        'End_DateLabel
        '
        End_DateLabel.AutoSize = True
        End_DateLabel.Location = New System.Drawing.Point(102, 272)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(67, 13)
        End_DateLabel.TabIndex = 78
        End_DateLabel.Text = "วันที่หยุดจ่าย"
        '
        'D_IDLabel
        '
        D_IDLabel.AutoSize = True
        D_IDLabel.Location = New System.Drawing.Point(128, 191)
        D_IDLabel.Name = "D_IDLabel"
        D_IDLabel.Size = New System.Drawing.Size(38, 13)
        D_IDLabel.TabIndex = 71
        D_IDLabel.Text = "รหัสยา"
        '
        'D_UPDLabel
        '
        D_UPDLabel.AutoSize = True
        D_UPDLabel.Location = New System.Drawing.Point(104, 217)
        D_UPDLabel.Name = "D_UPDLabel"
        D_UPDLabel.Size = New System.Drawing.Size(62, 13)
        D_UPDLabel.TabIndex = 76
        D_UPDLabel.Text = "หน่วยต่อวัน"
        '
        'M_IDLabel
        '
        M_IDLabel.AutoSize = True
        M_IDLabel.Location = New System.Drawing.Point(92, 137)
        M_IDLabel.Name = "M_IDLabel"
        M_IDLabel.Size = New System.Drawing.Size(74, 13)
        M_IDLabel.TabIndex = 65
        M_IDLabel.Text = "รหัสการจ่ายยา"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(113, 165)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(53, 13)
        P_IDLabel.TabIndex = 68
        P_IDLabel.Text = "รหัสผู้ป่วย"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(172, 292)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 50)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicationBindingSource
        '
        Me.MedicationBindingSource.DataMember = "Medication"
        Me.MedicationBindingSource.DataSource = Me.Hospital
        '
        'MedicationTableAdapter
        '
        Me.MedicationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Me.MedicationTableAdapter
        Me.TableAdapterManager.PatientReferralTableAdapter = Nothing
        Me.TableAdapterManager.PatientRelativesTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffShiftTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(378, 130)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 64
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(172, 162)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 81
        '
        'D_IDTextBox
        '
        Me.D_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationBindingSource, "D_ID", True))
        Me.D_IDTextBox.Location = New System.Drawing.Point(172, 188)
        Me.D_IDTextBox.Name = "D_IDTextBox"
        Me.D_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.D_IDTextBox.TabIndex = 83
        '
        'D_UPDTextBox
        '
        Me.D_UPDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicationBindingSource, "D_UPD", True))
        Me.D_UPDTextBox.Location = New System.Drawing.Point(172, 214)
        Me.D_UPDTextBox.Name = "D_UPDTextBox"
        Me.D_UPDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.D_UPDTextBox.TabIndex = 85
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicationBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(172, 240)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Start_DateDateTimePicker.TabIndex = 87
        '
        'End_DateDateTimePicker
        '
        Me.End_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicationBindingSource, "End_Date", True))
        Me.End_DateDateTimePicker.Location = New System.Drawing.Point(172, 266)
        Me.End_DateDateTimePicker.Name = "End_DateDateTimePicker"
        Me.End_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.End_DateDateTimePicker.TabIndex = 89
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(172, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 90
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(529, 113)
        Me.Panel3.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(140, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(637, 111)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 482)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 91)
        Me.Panel1.TabIndex = 92
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(313, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 50)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "SUBMIT EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(378, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "CAN'T CHANGE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(378, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "CAN'T CHANGE"
        '
        'deleteMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 573)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(Me.D_IDTextBox)
        Me.Controls.Add(Me.D_UPDTextBox)
        Me.Controls.Add(Me.Start_DateDateTimePicker)
        Me.Controls.Add(Me.End_DateDateTimePicker)
        Me.Controls.Add(Start_DateLabel)
        Me.Controls.Add(End_DateLabel)
        Me.Controls.Add(D_IDLabel)
        Me.Controls.Add(D_UPDLabel)
        Me.Controls.Add(M_IDLabel)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "deleteMedicine"
        Me.Text = "deleteMedicine"
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents MedicationBindingSource As BindingSource
    Friend WithEvents MedicationTableAdapter As HospitalTableAdapters.MedicationTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents btnSearch As Button
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents D_IDTextBox As TextBox
    Friend WithEvents D_UPDTextBox As TextBox
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents End_DateDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
