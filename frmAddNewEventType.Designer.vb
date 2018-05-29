<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewEventType
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
        Me.txtNewEventType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelCreditEntry = New System.Windows.Forms.Button()
        Me.btnSubmitNewEventType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNewEventType
        '
        Me.txtNewEventType.Location = New System.Drawing.Point(85, 30)
        Me.txtNewEventType.Name = "txtNewEventType"
        Me.txtNewEventType.Size = New System.Drawing.Size(195, 20)
        Me.txtNewEventType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(116, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "New Event Type"
        '
        'btnCancelCreditEntry
        '
        Me.btnCancelCreditEntry.BackColor = System.Drawing.Color.Red
        Me.btnCancelCreditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelCreditEntry.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelCreditEntry.ForeColor = System.Drawing.Color.White
        Me.btnCancelCreditEntry.Location = New System.Drawing.Point(200, 71)
        Me.btnCancelCreditEntry.Name = "btnCancelCreditEntry"
        Me.btnCancelCreditEntry.Size = New System.Drawing.Size(147, 56)
        Me.btnCancelCreditEntry.TabIndex = 15
        Me.btnCancelCreditEntry.Text = "Cancel"
        Me.btnCancelCreditEntry.UseVisualStyleBackColor = False
        '
        'btnSubmitNewEventType
        '
        Me.btnSubmitNewEventType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmitNewEventType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmitNewEventType.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmitNewEventType.ForeColor = System.Drawing.Color.White
        Me.btnSubmitNewEventType.Location = New System.Drawing.Point(12, 71)
        Me.btnSubmitNewEventType.Name = "btnSubmitNewEventType"
        Me.btnSubmitNewEventType.Size = New System.Drawing.Size(147, 56)
        Me.btnSubmitNewEventType.TabIndex = 14
        Me.btnSubmitNewEventType.Text = "Submit New Event Type"
        Me.btnSubmitNewEventType.UseVisualStyleBackColor = False
        '
        'frmAddNewEventType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 153)
        Me.Controls.Add(Me.btnCancelCreditEntry)
        Me.Controls.Add(Me.btnSubmitNewEventType)
        Me.Controls.Add(Me.txtNewEventType)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmAddNewEventType"
        Me.Text = "New Event Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewEventType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancelCreditEntry As Button
    Friend WithEvents btnSubmitNewEventType As Button
End Class
