<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Experiences
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
        Dim Ex_IDLabel As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Ex_StartDateLabel As System.Windows.Forms.Label
        Dim Ex_EndDateLabel As System.Windows.Forms.Label
        Dim Ex_OrganizationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Experiences))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Hospital = New Wellmedow.Hospital()
        Me.WorkExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkExpTableAdapter = New Wellmedow.HospitalTableAdapters.WorkExpTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Ex_StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ex_EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ex_OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WorkExpDataGridView = New System.Windows.Forms.DataGridView()
        Me.ExIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExOrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Q_IDLabel = New System.Windows.Forms.Label()
        Ex_IDLabel = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Ex_StartDateLabel = New System.Windows.Forms.Label()
        Ex_EndDateLabel = New System.Windows.Forms.Label()
        Ex_OrganizationLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkExpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Q_IDLabel
        '
        Q_IDLabel.AutoSize = True
        Q_IDLabel.Location = New System.Drawing.Point(272, 323)
        Q_IDLabel.Name = "Q_IDLabel"
        Q_IDLabel.Size = New System.Drawing.Size(47, 13)
        Q_IDLabel.TabIndex = 69
        Q_IDLabel.Text = "ตำแหน่ง"
        '
        'Ex_IDLabel
        '
        Ex_IDLabel.AutoSize = True
        Ex_IDLabel.Location = New System.Drawing.Point(250, 152)
        Ex_IDLabel.Name = "Ex_IDLabel"
        Ex_IDLabel.Size = New System.Drawing.Size(50, 13)
        Ex_IDLabel.TabIndex = 84
        Ex_IDLabel.Text = "รหัส EXP"
        '
        'S_IDLabel
        '
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(250, 178)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(88, 13)
        S_IDLabel.TabIndex = 85
        S_IDLabel.Text = "หมายเลขบุคลากร"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(250, 204)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(86, 13)
        PositionLabel.TabIndex = 86
        PositionLabel.Text = "ตำแหน่งที่เคยรับ"
        '
        'Ex_StartDateLabel
        '
        Ex_StartDateLabel.AutoSize = True
        Ex_StartDateLabel.Location = New System.Drawing.Point(250, 231)
        Ex_StartDateLabel.Name = "Ex_StartDateLabel"
        Ex_StartDateLabel.Size = New System.Drawing.Size(58, 13)
        Ex_StartDateLabel.TabIndex = 87
        Ex_StartDateLabel.Text = "วันที่เริ่มทำ"
        '
        'Ex_EndDateLabel
        '
        Ex_EndDateLabel.AutoSize = True
        Ex_EndDateLabel.Location = New System.Drawing.Point(250, 257)
        Ex_EndDateLabel.Name = "Ex_EndDateLabel"
        Ex_EndDateLabel.Size = New System.Drawing.Size(83, 13)
        Ex_EndDateLabel.TabIndex = 88
        Ex_EndDateLabel.Text = "วันที่ออกจากงาน"
        '
        'Ex_OrganizationLabel
        '
        Ex_OrganizationLabel.AutoSize = True
        Ex_OrganizationLabel.Location = New System.Drawing.Point(250, 282)
        Ex_OrganizationLabel.Name = "Ex_OrganizationLabel"
        Ex_OrganizationLabel.Size = New System.Drawing.Size(38, 13)
        Ex_OrganizationLabel.TabIndex = 89
        Ex_OrganizationLabel.Text = "องค์กร"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(864, 114)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 689)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 20)
        Me.Panel1.TabIndex = 27
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
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(344, 175)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_IDTextBox.TabIndex = 31
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(344, 201)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PositionTextBox.TabIndex = 33
        '
        'Ex_StartDateDateTimePicker
        '
        Me.Ex_StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkExpBindingSource, "Ex_StartDate", True))
        Me.Ex_StartDateDateTimePicker.Location = New System.Drawing.Point(344, 227)
        Me.Ex_StartDateDateTimePicker.Name = "Ex_StartDateDateTimePicker"
        Me.Ex_StartDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Ex_StartDateDateTimePicker.TabIndex = 35
        '
        'Ex_EndDateDateTimePicker
        '
        Me.Ex_EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkExpBindingSource, "Ex_EndDate", True))
        Me.Ex_EndDateDateTimePicker.Location = New System.Drawing.Point(344, 253)
        Me.Ex_EndDateDateTimePicker.Name = "Ex_EndDateDateTimePicker"
        Me.Ex_EndDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Ex_EndDateDateTimePicker.TabIndex = 37
        '
        'Ex_OrganizationTextBox
        '
        Me.Ex_OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkExpBindingSource, "Ex_Organization", True))
        Me.Ex_OrganizationTextBox.Location = New System.Drawing.Point(344, 279)
        Me.Ex_OrganizationTextBox.Name = "Ex_OrganizationTextBox"
        Me.Ex_OrganizationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ex_OrganizationTextBox.TabIndex = 39
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(344, 321)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 71
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WorkExpDataGridView
        '
        Me.WorkExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkExpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExIDDataGridViewTextBoxColumn, Me.SIDDataGridViewTextBoxColumn, Me.S_Fname, Me.S_Lname, Me.PositionDataGridViewTextBoxColumn, Me.ExStartDateDataGridViewTextBoxColumn, Me.ExEndDateDataGridViewTextBoxColumn, Me.ExOrganizationDataGridViewTextBoxColumn})
        Me.WorkExpDataGridView.Location = New System.Drawing.Point(12, 374)
        Me.WorkExpDataGridView.Name = "WorkExpDataGridView"
        Me.WorkExpDataGridView.Size = New System.Drawing.Size(843, 220)
        Me.WorkExpDataGridView.TabIndex = 71
        '
        'ExIDDataGridViewTextBoxColumn
        '
        Me.ExIDDataGridViewTextBoxColumn.HeaderText = "Ex_ID"
        Me.ExIDDataGridViewTextBoxColumn.Name = "ExIDDataGridViewTextBoxColumn"
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
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
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'ExStartDateDataGridViewTextBoxColumn
        '
        Me.ExStartDateDataGridViewTextBoxColumn.HeaderText = "Ex_StartDate"
        Me.ExStartDateDataGridViewTextBoxColumn.Name = "ExStartDateDataGridViewTextBoxColumn"
        '
        'ExEndDateDataGridViewTextBoxColumn
        '
        Me.ExEndDateDataGridViewTextBoxColumn.HeaderText = "Ex_EndDate"
        Me.ExEndDateDataGridViewTextBoxColumn.Name = "ExEndDateDataGridViewTextBoxColumn"
        '
        'ExOrganizationDataGridViewTextBoxColumn
        '
        Me.ExOrganizationDataGridViewTextBoxColumn.HeaderText = "Ex_Organization"
        Me.ExOrganizationDataGridViewTextBoxColumn.Name = "ExOrganizationDataGridViewTextBoxColumn"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(390, 600)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 73
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(364, 626)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(130, 56)
        Me.TableLayoutPanel1.TabIndex = 72
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(550, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Confirm Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(550, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(344, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 83
        '
        'Experiences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 709)
        Me.Controls.Add(Ex_IDLabel)
        Me.Controls.Add(S_IDLabel)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Ex_StartDateLabel)
        Me.Controls.Add(Ex_EndDateLabel)
        Me.Controls.Add(Ex_OrganizationLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.WorkExpDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Q_IDLabel)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Me.Ex_StartDateDateTimePicker)
        Me.Controls.Add(Me.Ex_EndDateDateTimePicker)
        Me.Controls.Add(Me.Ex_OrganizationTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Experiences"
        Me.Text = "Experiences"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkExpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents WorkExpBindingSource As BindingSource
    Friend WithEvents WorkExpTableAdapter As HospitalTableAdapters.WorkExpTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Ex_StartDateDateTimePicker As DateTimePicker
    Friend WithEvents Ex_EndDateDateTimePicker As DateTimePicker
    Friend WithEvents Ex_OrganizationTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WorkExpDataGridView As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ExIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents S_Fname As DataGridViewTextBoxColumn
    Friend WithEvents S_Lname As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExOrganizationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
