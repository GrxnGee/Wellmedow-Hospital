<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAllocate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAllocate))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Hospital = New Wellmedow.Hospital()
        Me.PatientAllocateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientAllocateTableAdapter = New Wellmedow.HospitalTableAdapters.PatientAllocateTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.A_IDTextBox = New System.Windows.Forms.TextBox()
        Me.A_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_SymptomTextBox = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Wnum = New System.Windows.Forms.ComboBox()
        Me.Slname = New System.Windows.Forms.TextBox()
        Me.Sfname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pnum = New System.Windows.Forms.ComboBox()
        Me.S_num = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'A_IDLabel
        '
        A_IDLabel.AutoSize = True
        A_IDLabel.Location = New System.Drawing.Point(181, 145)
        A_IDLabel.Name = "A_IDLabel"
        A_IDLabel.Size = New System.Drawing.Size(109, 13)
        A_IDLabel.TabIndex = 61
        A_IDLabel.Text = "หมายเลขการนัดหมาย"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(213, 171)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(77, 13)
        P_IDLabel.TabIndex = 63
        P_IDLabel.Text = "หมายเลขผู้ป่วย"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(227, 223)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 65
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'A_DateLabel
        '
        A_DateLabel.AutoSize = True
        A_DateLabel.Location = New System.Drawing.Point(222, 252)
        A_DateLabel.Name = "A_DateLabel"
        A_DateLabel.Size = New System.Drawing.Size(69, 13)
        A_DateLabel.TabIndex = 67
        A_DateLabel.Text = "วันที่นัดหมาย"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(203, 275)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 69
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'P_SymptomLabel
        '
        P_SymptomLabel.AutoSize = True
        P_SymptomLabel.Location = New System.Drawing.Point(227, 327)
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
        Me.Panel3.Size = New System.Drawing.Size(800, 113)
        Me.Panel3.TabIndex = 58
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
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(346, 350)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 50)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Allocate"
        Me.btnAdd.UseVisualStyleBackColor = False
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
        'A_IDTextBox
        '
        Me.A_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "A_ID", True))
        Me.A_IDTextBox.Location = New System.Drawing.Point(296, 142)
        Me.A_IDTextBox.Name = "A_IDTextBox"
        Me.A_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.A_IDTextBox.TabIndex = 62
        '
        'A_DateDateTimePicker
        '
        Me.A_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientAllocateBindingSource, "A_Date", True))
        Me.A_DateDateTimePicker.Location = New System.Drawing.Point(296, 246)
        Me.A_DateDateTimePicker.Name = "A_DateDateTimePicker"
        Me.A_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.A_DateDateTimePicker.TabIndex = 68
        '
        'P_SymptomTextBox
        '
        Me.P_SymptomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_Symptom", True))
        Me.P_SymptomTextBox.Location = New System.Drawing.Point(296, 324)
        Me.P_SymptomTextBox.Name = "P_SymptomTextBox"
        Me.P_SymptomTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_SymptomTextBox.TabIndex = 72
        '
        'Fname
        '
        Me.Fname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_ID", True))
        Me.Fname.Location = New System.Drawing.Point(296, 194)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(95, 20)
        Me.Fname.TabIndex = 73
        '
        'Lname
        '
        Me.Lname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_ID", True))
        Me.Lname.Location = New System.Drawing.Point(401, 194)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(95, 20)
        Me.Lname.TabIndex = 74
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(502, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Wnum
        '
        Me.Wnum.FormattingEnabled = True
        Me.Wnum.Location = New System.Drawing.Point(296, 220)
        Me.Wnum.Name = "Wnum"
        Me.Wnum.Size = New System.Drawing.Size(121, 21)
        Me.Wnum.TabIndex = 82
        '
        'Slname
        '
        Me.Slname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_ID", True))
        Me.Slname.Location = New System.Drawing.Point(401, 298)
        Me.Slname.Name = "Slname"
        Me.Slname.Size = New System.Drawing.Size(95, 20)
        Me.Slname.TabIndex = 84
        '
        'Sfname
        '
        Me.Sfname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientAllocateBindingSource, "P_ID", True))
        Me.Sfname.Location = New System.Drawing.Point(296, 298)
        Me.Sfname.Name = "Sfname"
        Me.Sfname.Size = New System.Drawing.Size(95, 20)
        Me.Sfname.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 412)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 14)
        Me.Panel1.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(502, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pnum
        '
        Me.Pnum.FormattingEnabled = True
        Me.Pnum.Location = New System.Drawing.Point(296, 168)
        Me.Pnum.Name = "Pnum"
        Me.Pnum.Size = New System.Drawing.Size(121, 21)
        Me.Pnum.TabIndex = 87
        '
        'S_num
        '
        Me.S_num.FormattingEnabled = True
        Me.S_num.Location = New System.Drawing.Point(296, 272)
        Me.S_num.Name = "S_num"
        Me.S_num.Size = New System.Drawing.Size(121, 21)
        Me.S_num.TabIndex = 88
        '
        'addAllocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 426)
        Me.Controls.Add(Me.S_num)
        Me.Controls.Add(Me.Pnum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Slname)
        Me.Controls.Add(Me.Sfname)
        Me.Controls.Add(Me.Wnum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(A_IDLabel)
        Me.Controls.Add(Me.A_IDTextBox)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(W_NumberLabel)
        Me.Controls.Add(A_DateLabel)
        Me.Controls.Add(Me.A_DateDateTimePicker)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(P_SymptomLabel)
        Me.Controls.Add(Me.P_SymptomTextBox)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "addAllocate"
        Me.Text = "addAllocate"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientAllocateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Hospital As Hospital
    Friend WithEvents PatientAllocateBindingSource As BindingSource
    Friend WithEvents PatientAllocateTableAdapter As HospitalTableAdapters.PatientAllocateTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents A_IDTextBox As TextBox
    Friend WithEvents A_DateDateTimePicker As DateTimePicker
    Friend WithEvents P_SymptomTextBox As TextBox
    Friend WithEvents Fname As TextBox
    Friend WithEvents Lname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Wnum As ComboBox
    Friend WithEvents Slname As TextBox
    Friend WithEvents Sfname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Pnum As ComboBox
    Friend WithEvents S_num As ComboBox
End Class
