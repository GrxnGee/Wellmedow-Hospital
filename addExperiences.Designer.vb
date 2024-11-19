<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addExperiences
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
        Dim Ex_IDLabel As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Ex_StartDateLabel As System.Windows.Forms.Label
        Dim Ex_EndDateLabel As System.Windows.Forms.Label
        Dim Ex_OrganizationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addExperiences))
        Me.Hospital = New Wellmedow.Hospital()
        Me.WorkExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkExpTableAdapter = New Wellmedow.HospitalTableAdapters.WorkExpTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.Ex_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Ex_StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ex_EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ex_OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Ex_IDLabel = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Ex_StartDateLabel = New System.Windows.Forms.Label()
        Ex_EndDateLabel = New System.Windows.Forms.Label()
        Ex_OrganizationLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ex_IDLabel
        '
        Ex_IDLabel.AutoSize = True
        Ex_IDLabel.Location = New System.Drawing.Point(200, 159)
        Ex_IDLabel.Name = "Ex_IDLabel"
        Ex_IDLabel.Size = New System.Drawing.Size(50, 13)
        Ex_IDLabel.TabIndex = 1
        Ex_IDLabel.Text = "รหัส EXP"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(200, 185)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 3
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(200, 211)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(86, 13)
        PositionLabel.TabIndex = 5
        PositionLabel.Text = "ตำแหน่งที่เคยรับ"
        '
        'Ex_StartDateLabel
        '
        Ex_StartDateLabel.AutoSize = True
        Ex_StartDateLabel.Location = New System.Drawing.Point(200, 238)
        Ex_StartDateLabel.Name = "Ex_StartDateLabel"
        Ex_StartDateLabel.Size = New System.Drawing.Size(58, 13)
        Ex_StartDateLabel.TabIndex = 7
        Ex_StartDateLabel.Text = "วันที่เริ่มทำ"
        '
        'Ex_EndDateLabel
        '
        Ex_EndDateLabel.AutoSize = True
        Ex_EndDateLabel.Location = New System.Drawing.Point(200, 264)
        Ex_EndDateLabel.Name = "Ex_EndDateLabel"
        Ex_EndDateLabel.Size = New System.Drawing.Size(83, 13)
        Ex_EndDateLabel.TabIndex = 9
        Ex_EndDateLabel.Text = "วันที่ออกจากงาน"
        '
        'Ex_OrganizationLabel
        '
        Ex_OrganizationLabel.AutoSize = True
        Ex_OrganizationLabel.Location = New System.Drawing.Point(200, 289)
        Ex_OrganizationLabel.Name = "Ex_OrganizationLabel"
        Ex_OrganizationLabel.Size = New System.Drawing.Size(38, 13)
        Ex_OrganizationLabel.TabIndex = 11
        Ex_OrganizationLabel.Text = "องค์กร"
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkExpBindingSource
        '
        Me.WorkExpBindingSource.DataMember = "WorkExp"
        Me.WorkExpBindingSource.DataSource = Me.Hospital
        '
        'WorkExpTableAdapter
        '
        Me.WorkExpTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Wellmedow.HospitalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardReportTableAdapter = Nothing
        Me.TableAdapterManager.WardRequestTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Me.WorkExpTableAdapter
        '
        'Ex_IDTextBox
        '
        Me.Ex_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "Ex_ID", True))
        Me.Ex_IDTextBox.Location = New System.Drawing.Point(290, 156)
        Me.Ex_IDTextBox.Name = "Ex_IDTextBox"
        Me.Ex_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ex_IDTextBox.TabIndex = 2
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(290, 208)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PositionTextBox.TabIndex = 6
        '
        'Ex_StartDateDateTimePicker
        '
        Me.Ex_StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkExpBindingSource, "Ex_StartDate", True))
        Me.Ex_StartDateDateTimePicker.Location = New System.Drawing.Point(290, 234)
        Me.Ex_StartDateDateTimePicker.Name = "Ex_StartDateDateTimePicker"
        Me.Ex_StartDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Ex_StartDateDateTimePicker.TabIndex = 8
        '
        'Ex_EndDateDateTimePicker
        '
        Me.Ex_EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkExpBindingSource, "Ex_EndDate", True))
        Me.Ex_EndDateDateTimePicker.Location = New System.Drawing.Point(290, 260)
        Me.Ex_EndDateDateTimePicker.Name = "Ex_EndDateDateTimePicker"
        Me.Ex_EndDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Ex_EndDateDateTimePicker.TabIndex = 10
        '
        'Ex_OrganizationTextBox
        '
        Me.Ex_OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "Ex_Organization", True))
        Me.Ex_OrganizationTextBox.Location = New System.Drawing.Point(290, 286)
        Me.Ex_OrganizationTextBox.Name = "Ex_OrganizationTextBox"
        Me.Ex_OrganizationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ex_OrganizationTextBox.TabIndex = 12
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
        Me.btnAdd.Location = New System.Drawing.Point(356, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 50)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(290, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'addExperiences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Ex_IDLabel)
        Me.Controls.Add(Me.Ex_IDTextBox)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Ex_StartDateLabel)
        Me.Controls.Add(Me.Ex_StartDateDateTimePicker)
        Me.Controls.Add(Ex_EndDateLabel)
        Me.Controls.Add(Me.Ex_EndDateDateTimePicker)
        Me.Controls.Add(Ex_OrganizationLabel)
        Me.Controls.Add(Me.Ex_OrganizationTextBox)
        Me.Name = "addExperiences"
        Me.Text = "addExperiences"
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hospital As Hospital
    Friend WithEvents WorkExpBindingSource As BindingSource
    Friend WithEvents WorkExpTableAdapter As HospitalTableAdapters.WorkExpTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents Ex_IDTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Ex_StartDateDateTimePicker As DateTimePicker
    Friend WithEvents Ex_EndDateDateTimePicker As DateTimePicker
    Friend WithEvents Ex_OrganizationTextBox As TextBox
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
