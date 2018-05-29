<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewPaymentMethod
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
        Me.btnCancelCreditEntry = New System.Windows.Forms.Button()
        Me.btnSubmitNewPaymentMethod = New System.Windows.Forms.Button()
        Me.txtNewPaymentMethod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelCreditEntry
        '
        Me.btnCancelCreditEntry.BackColor = System.Drawing.Color.Red
        Me.btnCancelCreditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelCreditEntry.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelCreditEntry.ForeColor = System.Drawing.Color.White
        Me.btnCancelCreditEntry.Location = New System.Drawing.Point(217, 79)
        Me.btnCancelCreditEntry.Name = "btnCancelCreditEntry"
        Me.btnCancelCreditEntry.Size = New System.Drawing.Size(147, 62)
        Me.btnCancelCreditEntry.TabIndex = 19
        Me.btnCancelCreditEntry.Text = "Cancel"
        Me.btnCancelCreditEntry.UseVisualStyleBackColor = False
        '
        'btnSubmitNewPaymentMethod
        '
        Me.btnSubmitNewPaymentMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmitNewPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmitNewPaymentMethod.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmitNewPaymentMethod.ForeColor = System.Drawing.Color.White
        Me.btnSubmitNewPaymentMethod.Location = New System.Drawing.Point(29, 79)
        Me.btnSubmitNewPaymentMethod.Name = "btnSubmitNewPaymentMethod"
        Me.btnSubmitNewPaymentMethod.Size = New System.Drawing.Size(147, 62)
        Me.btnSubmitNewPaymentMethod.TabIndex = 18
        Me.btnSubmitNewPaymentMethod.Text = "Submit New Payment Method"
        Me.btnSubmitNewPaymentMethod.UseVisualStyleBackColor = False
        '
        'txtNewPaymentMethod
        '
        Me.txtNewPaymentMethod.Location = New System.Drawing.Point(102, 38)
        Me.txtNewPaymentMethod.Name = "txtNewPaymentMethod"
        Me.txtNewPaymentMethod.Size = New System.Drawing.Size(195, 20)
        Me.txtNewPaymentMethod.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(110, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "New Payment Method"
        '
        'frmAddNewPaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 153)
        Me.Controls.Add(Me.btnCancelCreditEntry)
        Me.Controls.Add(Me.btnSubmitNewPaymentMethod)
        Me.Controls.Add(Me.txtNewPaymentMethod)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmAddNewPaymentMethod"
        Me.Text = "New Payment Method"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelCreditEntry As Button
    Friend WithEvents btnSubmitNewPaymentMethod As Button
    Friend WithEvents txtNewPaymentMethod As TextBox
    Friend WithEvents Label5 As Label
End Class
