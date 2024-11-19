<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addDrug
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
        Dim D_IDLabel As System.Windows.Forms.Label
        Dim D_NameLabel As System.Windows.Forms.Label
        Dim D_DescripLabel As System.Windows.Forms.Label
        Dim D_DoseLabel As System.Windows.Forms.Label
        Dim D_MOALabel As System.Windows.Forms.Label
        Dim D_QuantityLabel As System.Windows.Forms.Label
        Dim D_reorderLevelLabel As System.Windows.Forms.Label
        Dim D_costPerunitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addDrug))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Hospital = New Wellmedow.Hospital()
        Me.DrugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugTableAdapter = New Wellmedow.HospitalTableAdapters.DrugTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.D_IDTextBox = New System.Windows.Forms.TextBox()
        Me.D_NameTextBox = New System.Windows.Forms.TextBox()
        Me.D_DescripTextBox = New System.Windows.Forms.TextBox()
        Me.D_DoseTextBox = New System.Windows.Forms.TextBox()
        Me.D_MOATextBox = New System.Windows.Forms.TextBox()
        Me.D_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.D_reorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.D_costPerunitTextBox = New System.Windows.Forms.TextBox()
        Me.DrugDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        D_IDLabel = New System.Windows.Forms.Label()
        D_NameLabel = New System.Windows.Forms.Label()
        D_DescripLabel = New System.Windows.Forms.Label()
        D_DoseLabel = New System.Windows.Forms.Label()
        D_MOALabel = New System.Windows.Forms.Label()
        D_QuantityLabel = New System.Windows.Forms.Label()
        D_reorderLevelLabel = New System.Windows.Forms.Label()
        D_costPerunitLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'D_IDLabel
        '
        D_IDLabel.AutoSize = True
        D_IDLabel.Location = New System.Drawing.Point(208, 149)
        D_IDLabel.Name = "D_IDLabel"
        D_IDLabel.Size = New System.Drawing.Size(62, 13)
        D_IDLabel.TabIndex = 60
        D_IDLabel.Text = "หมายเลขยา"
        '
        'D_NameLabel
        '
        D_NameLabel.AutoSize = True
        D_NameLabel.Location = New System.Drawing.Point(208, 175)
        D_NameLabel.Name = "D_NameLabel"
        D_NameLabel.Size = New System.Drawing.Size(32, 13)
        D_NameLabel.TabIndex = 62
        D_NameLabel.Text = "ชื่อยา"
        '
        'D_DescripLabel
        '
        D_DescripLabel.AutoSize = True
        D_DescripLabel.Location = New System.Drawing.Point(208, 201)
        D_DescripLabel.Name = "D_DescripLabel"
        D_DescripLabel.Size = New System.Drawing.Size(50, 13)
        D_DescripLabel.TabIndex = 64
        D_DescripLabel.Text = "คำอธิบาย"
        '
        'D_DoseLabel
        '
        D_DoseLabel.AutoSize = True
        D_DoseLabel.Location = New System.Drawing.Point(208, 227)
        D_DoseLabel.Name = "D_DoseLabel"
        D_DoseLabel.Size = New System.Drawing.Size(51, 13)
        D_DoseLabel.TabIndex = 66
        D_DoseLabel.Text = "ขนาดโดส"
        '
        'D_MOALabel
        '
        D_MOALabel.AutoSize = True
        D_MOALabel.Location = New System.Drawing.Point(208, 253)
        D_MOALabel.Name = "D_MOALabel"
        D_MOALabel.Size = New System.Drawing.Size(50, 13)
        D_MOALabel.TabIndex = 68
        D_MOALabel.Text = "วิธีการใช้"
        '
        'D_QuantityLabel
        '
        D_QuantityLabel.AutoSize = True
        D_QuantityLabel.Location = New System.Drawing.Point(208, 279)
        D_QuantityLabel.Name = "D_QuantityLabel"
        D_QuantityLabel.Size = New System.Drawing.Size(40, 13)
        D_QuantityLabel.TabIndex = 70
        D_QuantityLabel.Text = "จำนวน"
        '
        'D_reorderLevelLabel
        '
        D_reorderLevelLabel.AutoSize = True
        D_reorderLevelLabel.Location = New System.Drawing.Point(208, 305)
        D_reorderLevelLabel.Name = "D_reorderLevelLabel"
        D_reorderLevelLabel.Size = New System.Drawing.Size(76, 13)
        D_reorderLevelLabel.TabIndex = 72
        D_reorderLevelLabel.Text = "ระดับสั่งซื้อใหม่"
        '
        'D_costPerunitLabel
        '
        D_costPerunitLabel.AutoSize = True
        D_costPerunitLabel.Location = New System.Drawing.Point(208, 331)
        D_costPerunitLabel.Name = "D_costPerunitLabel"
        D_costPerunitLabel.Size = New System.Drawing.Size(63, 13)
        D_costPerunitLabel.TabIndex = 74
        D_costPerunitLabel.Text = "ราคา/หน่วย"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1202, 113)
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
        Me.Label2.Location = New System.Drawing.Point(59, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(550, 86)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hospital Supply"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(454, 3)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 52)
        Me.Panel1.TabIndex = 59
        '
        'Hospital
        '
        Me.Hospital.DataSetName = "Hospital"
        Me.Hospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrugBindingSource
        '
        Me.DrugBindingSource.DataMember = "Drug"
        Me.DrugBindingSource.DataSource = Me.Hospital
        '
        'DrugTableAdapter
        '
        Me.DrugTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugTableAdapter = Me.DrugTableAdapter
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
        'D_IDTextBox
        '
        Me.D_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_ID", True))
        Me.D_IDTextBox.Location = New System.Drawing.Point(297, 146)
        Me.D_IDTextBox.Name = "D_IDTextBox"
        Me.D_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_IDTextBox.TabIndex = 61
        '
        'D_NameTextBox
        '
        Me.D_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_Name", True))
        Me.D_NameTextBox.Location = New System.Drawing.Point(297, 172)
        Me.D_NameTextBox.Name = "D_NameTextBox"
        Me.D_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_NameTextBox.TabIndex = 63
        '
        'D_DescripTextBox
        '
        Me.D_DescripTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_Descrip", True))
        Me.D_DescripTextBox.Location = New System.Drawing.Point(297, 198)
        Me.D_DescripTextBox.Name = "D_DescripTextBox"
        Me.D_DescripTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_DescripTextBox.TabIndex = 65
        '
        'D_DoseTextBox
        '
        Me.D_DoseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_Dose", True))
        Me.D_DoseTextBox.Location = New System.Drawing.Point(297, 224)
        Me.D_DoseTextBox.Name = "D_DoseTextBox"
        Me.D_DoseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_DoseTextBox.TabIndex = 67
        '
        'D_MOATextBox
        '
        Me.D_MOATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_MOA", True))
        Me.D_MOATextBox.Location = New System.Drawing.Point(297, 250)
        Me.D_MOATextBox.Name = "D_MOATextBox"
        Me.D_MOATextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_MOATextBox.TabIndex = 69
        '
        'D_QuantityTextBox
        '
        Me.D_QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_Quantity", True))
        Me.D_QuantityTextBox.Location = New System.Drawing.Point(297, 276)
        Me.D_QuantityTextBox.Name = "D_QuantityTextBox"
        Me.D_QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_QuantityTextBox.TabIndex = 71
        '
        'D_reorderLevelTextBox
        '
        Me.D_reorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_reorderLevel", True))
        Me.D_reorderLevelTextBox.Location = New System.Drawing.Point(297, 302)
        Me.D_reorderLevelTextBox.Name = "D_reorderLevelTextBox"
        Me.D_reorderLevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_reorderLevelTextBox.TabIndex = 73
        '
        'D_costPerunitTextBox
        '
        Me.D_costPerunitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugBindingSource, "D_costPerunit", True))
        Me.D_costPerunitTextBox.Location = New System.Drawing.Point(297, 328)
        Me.D_costPerunitTextBox.Name = "D_costPerunitTextBox"
        Me.D_costPerunitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.D_costPerunitTextBox.TabIndex = 75
        '
        'DrugDataGridView
        '
        Me.DrugDataGridView.AutoGenerateColumns = False
        Me.DrugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DrugDataGridView.DataSource = Me.DrugBindingSource
        Me.DrugDataGridView.Location = New System.Drawing.Point(403, 146)
        Me.DrugDataGridView.Name = "DrugDataGridView"
        Me.DrugDataGridView.Size = New System.Drawing.Size(645, 202)
        Me.DrugDataGridView.TabIndex = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "D_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "D_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "D_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "D_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "D_Descrip"
        Me.DataGridViewTextBoxColumn3.HeaderText = "D_Descrip"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "D_Dose"
        Me.DataGridViewTextBoxColumn4.HeaderText = "D_Dose"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "D_MOA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "D_MOA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "D_Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "D_Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "D_reorderLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "D_reorderLevel"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "D_costPerunit"
        Me.DataGridViewTextBoxColumn8.HeaderText = "D_costPerunit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(391, 354)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 50)
        Me.btnAdd.TabIndex = 76
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Location = New System.Drawing.Point(456, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 77
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(326, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 50)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "SUBMIT EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(261, 354)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 50)
        Me.btnDelete.TabIndex = 94
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'addDrug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DrugDataGridView)
        Me.Controls.Add(D_IDLabel)
        Me.Controls.Add(Me.D_IDTextBox)
        Me.Controls.Add(D_NameLabel)
        Me.Controls.Add(Me.D_NameTextBox)
        Me.Controls.Add(D_DescripLabel)
        Me.Controls.Add(Me.D_DescripTextBox)
        Me.Controls.Add(D_DoseLabel)
        Me.Controls.Add(Me.D_DoseTextBox)
        Me.Controls.Add(D_MOALabel)
        Me.Controls.Add(Me.D_MOATextBox)
        Me.Controls.Add(D_QuantityLabel)
        Me.Controls.Add(Me.D_QuantityTextBox)
        Me.Controls.Add(D_reorderLevelLabel)
        Me.Controls.Add(Me.D_reorderLevelTextBox)
        Me.Controls.Add(D_costPerunitLabel)
        Me.Controls.Add(Me.D_costPerunitTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "addDrug"
        Me.Text = "addDrug"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DrugBindingSource As BindingSource
    Friend WithEvents DrugTableAdapter As HospitalTableAdapters.DrugTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents D_IDTextBox As TextBox
    Friend WithEvents D_NameTextBox As TextBox
    Friend WithEvents D_DescripTextBox As TextBox
    Friend WithEvents D_DoseTextBox As TextBox
    Friend WithEvents D_MOATextBox As TextBox
    Friend WithEvents D_QuantityTextBox As TextBox
    Friend WithEvents D_reorderLevelTextBox As TextBox
    Friend WithEvents D_costPerunitTextBox As TextBox
    Friend WithEvents DrugDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDelete As Button
End Class
