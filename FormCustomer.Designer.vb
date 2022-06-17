<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim IDCardLabel As System.Windows.Forms.Label
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        CustomerLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        IDCardLabel = New System.Windows.Forms.Label()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerLabel.Location = New System.Drawing.Point(22, 84)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(92, 22)
        CustomerLabel.TabIndex = 4
        CustomerLabel.Text = "Customer:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(49, 120)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(67, 22)
        PhoneLabel.TabIndex = 6
        PhoneLabel.Text = "Phone:"
        '
        'IDCardLabel
        '
        IDCardLabel.AutoSize = True
        IDCardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDCardLabel.Location = New System.Drawing.Point(45, 151)
        IDCardLabel.Name = "IDCardLabel"
        IDCardLabel.Size = New System.Drawing.Size(72, 22)
        IDCardLabel.TabIndex = 8
        IDCardLabel.Text = "ICNUM:"
        '
        'txtCust
        '
        Me.txtCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust.Location = New System.Drawing.Point(131, 79)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(286, 30)
        Me.txtCust.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(131, 115)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(286, 30)
        Me.txtPhone.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(131, 151)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(286, 30)
        Me.txtID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Category Add Customer"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(131, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(182, 57)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Add New "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(460, 63)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 51
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.Size = New System.Drawing.Size(579, 332)
        Me.dgvCustomer.TabIndex = 16
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1093, 450)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.txtCust)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(IDCardLabel)
        Me.Controls.Add(Me.txtID)
        Me.Name = "FormCustomer"
        Me.Text = "FormCustomer"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCust As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvCustomer As DataGridView
End Class
