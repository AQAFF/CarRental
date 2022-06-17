<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCar
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
        Dim CarNameLabel As System.Windows.Forms.Label
        Dim CarModelLabel As System.Windows.Forms.Label
        Dim CarStstusLabel As System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvcar = New System.Windows.Forms.DataGridView()
        CarNameLabel = New System.Windows.Forms.Label()
        CarModelLabel = New System.Windows.Forms.Label()
        CarStstusLabel = New System.Windows.Forms.Label()
        CType(Me.dgvcar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarNameLabel
        '
        CarNameLabel.AutoSize = True
        CarNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarNameLabel.Location = New System.Drawing.Point(22, 90)
        CarNameLabel.Name = "CarNameLabel"
        CarNameLabel.Size = New System.Drawing.Size(99, 20)
        CarNameLabel.TabIndex = 3
        CarNameLabel.Text = "Car Name:"
        '
        'CarModelLabel
        '
        CarModelLabel.AutoSize = True
        CarModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarModelLabel.Location = New System.Drawing.Point(22, 118)
        CarModelLabel.Name = "CarModelLabel"
        CarModelLabel.Size = New System.Drawing.Size(101, 20)
        CarModelLabel.TabIndex = 5
        CarModelLabel.Text = "Car Model:"
        '
        'CarStstusLabel
        '
        CarStstusLabel.AutoSize = True
        CarStstusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarStstusLabel.Location = New System.Drawing.Point(18, 165)
        CarStstusLabel.Name = "CarStstusLabel"
        CarStstusLabel.Size = New System.Drawing.Size(105, 20)
        CarStstusLabel.TabIndex = 9
        CarStstusLabel.Text = "Car Status:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(155, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 22)
        Me.txtName.TabIndex = 4
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(155, 115)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(191, 22)
        Me.txtModel.TabIndex = 6
        '
        'comboStatus
        '
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        Me.comboStatus.Location = New System.Drawing.Point(155, 165)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(191, 24)
        Me.comboStatus.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Category Add New Car"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 51)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add New "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvcar
        '
        Me.dgvcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcar.Location = New System.Drawing.Point(352, 72)
        Me.dgvcar.Name = "dgvcar"
        Me.dgvcar.RowHeadersWidth = 51
        Me.dgvcar.RowTemplate.Height = 24
        Me.dgvcar.Size = New System.Drawing.Size(616, 295)
        Me.dgvcar.TabIndex = 13
        '
        'FormCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(980, 388)
        Me.Controls.Add(Me.dgvcar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CarStstusLabel)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(CarNameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(CarModelLabel)
        Me.Controls.Add(Me.txtModel)
        Me.Name = "FormCar"
        Me.Text = "FormCar"
        CType(Me.dgvcar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvcar As DataGridView
End Class
