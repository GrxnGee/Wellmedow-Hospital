<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewRequest
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
        Dim Re_IDLabel As System.Windows.Forms.Label
        Dim W_NumberLabel As System.Windows.Forms.Label
        Dim D_IDLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Re_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addNewRequest))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Hospital = New Wellmedow.Hospital()
        Me.WardRequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardRequestTableAdapter = New Wellmedow.HospitalTableAdapters.WardRequestTableAdapter()
        Me.TableAdapterManager = New Wellmedow.HospitalTableAdapters.TableAdapterManager()
        Me.Re_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Re_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Re_IDLabel = New System.Windows.Forms.Label()
        W_NumberLabel = New System.Windows.Forms.Label()
        D_IDLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Re_DateLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardRequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Re_IDLabel
        '
        Re_IDLabel.AutoSize = True
        Re_IDLabel.Location = New System.Drawing.Point(195, 134)
        Re_IDLabel.Name = "Re_IDLabel"
        Re_IDLabel.Size = New System.Drawing.Size(73, 13)
        Re_IDLabel.TabIndex = 60
        Re_IDLabel.Text = "รหัสการร้องขอ"
        '
        'W_NumberLabel
        '
        W_NumberLabel.AutoSize = True
        W_NumberLabel.Location = New System.Drawing.Point(207, 160)
        W_NumberLabel.Name = "W_NumberLabel"
        W_NumberLabel.Size = New System.Drawing.Size(64, 13)
        W_NumberLabel.TabIndex = 62
        W_NumberLabel.Text = "หมายเลขตึก"
        '
        'D_IDLabel
        '
        D_IDLabel.AutoSize = True
        D_IDLabel.Location = New System.Drawing.Point(207, 186)
        D_IDLabel.Name = "D_IDLabel"
        D_IDLabel.Size = New System.Drawing.Size(62, 13)
        D_IDLabel.TabIndex = 64
        D_IDLabel.Text = "หมายเลขยา"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(208, 220)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(40, 13)
        QuantityLabel.TabIndex = 66
        QuantityLabel.Text = "จำนวน"
        '
        'Re_DateLabel
        '
        Re_DateLabel.AutoSize = True
        Re_DateLabel.Location = New System.Drawing.Point(207, 246)
        Re_DateLabel.Name = "Re_DateLabel"
        Re_DateLabel.Size = New System.Drawing.Size(57, 13)
        Re_DateLabel.TabIndex = 68
        Re_DateLabel.Text = "วันที่ร้องขอ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(727, 113)
        Me.Panel3.TabIndex = 59
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
        Me.Label2.Location = New System.Drawing.Point(0, 24)
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
        Me.Label1.Location = New System.Drawing.Point(400, 0)
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
        'WardRequestBindingSource
        '
        Me.WardRequestBindingSource.DataMember = "WardRequest"
        Me.WardRequestBindingSource.DataSource = Me.Hospital
        '
        'WardRequestTableAdapter
        '
        Me.WardRequestTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.WardRequestTableAdapter = Me.WardRequestTableAdapter
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.WorkExpTableAdapter = Nothing
        '
        'Re_IDTextBox
        '
        Me.Re_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardRequestBindingSource, "Re_ID", True))
        Me.Re_IDTextBox.Location = New System.Drawing.Point(274, 131)
        Me.Re_IDTextBox.Name = "Re_IDTextBox"
        Me.Re_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Re_IDTextBox.TabIndex = 61
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardRequestBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(274, 213)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuantityTextBox.TabIndex = 67
        '
        'Re_DateDateTimePicker
        '
        Me.Re_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WardRequestBindingSource, "Re_Date", True))
        Me.Re_DateDateTimePicker.Location = New System.Drawing.Point(274, 239)
        Me.Re_DateDateTimePicker.Name = "Re_DateDateTimePicker"
        Me.Re_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Re_DateDateTimePicker.TabIndex = 69
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(309, 265)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 50)
        Me.btnAdd.TabIndex = 70
        Me.btnAdd.Text = "New Request"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardRequestBindingSource, "Quantity", True))
        Me.TextBox1.Location = New System.Drawing.Point(350, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 20)
        Me.TextBox1.TabIndex = 71
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(274, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(70, 21)
        Me.ComboBox1.TabIndex = 72
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(274, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(70, 21)
        Me.ComboBox2.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 335)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 20)
        Me.Panel1.TabIndex = 75
        '
        'addNewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 355)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Re_IDLabel)
        Me.Controls.Add(Me.Re_IDTextBox)
        Me.Controls.Add(W_NumberLabel)
        Me.Controls.Add(D_IDLabel)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Re_DateLabel)
        Me.Controls.Add(Me.Re_DateDateTimePicker)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "addNewRequest"
        Me.Text = "addNewRequest"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardRequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents WardRequestBindingSource As BindingSource
    Friend WithEvents WardRequestTableAdapter As HospitalTableAdapters.WardRequestTableAdapter
    Friend WithEvents TableAdapterManager As HospitalTableAdapters.TableAdapterManager
    Friend WithEvents Re_IDTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Re_DateDateTimePicker As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
