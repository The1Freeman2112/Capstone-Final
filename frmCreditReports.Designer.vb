<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditReports))
        Me.grdCreditReports = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmountTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAmountTotal = New System.Windows.Forms.Button()
        Me.picboxCellImage = New System.Windows.Forms.PictureBox()
        Me.btnPrintData = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.grdCreditReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxCellImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCreditReports
        '
        Me.grdCreditReports.BackgroundColor = System.Drawing.Color.White
        Me.grdCreditReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCreditReports.Location = New System.Drawing.Point(12, 93)
        Me.grdCreditReports.Name = "grdCreditReports"
        Me.grdCreditReports.Size = New System.Drawing.Size(922, 337)
        Me.grdCreditReports.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(347, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Credit Reports"
        '
        'txtAmountTotal
        '
        Me.txtAmountTotal.Location = New System.Drawing.Point(12, 454)
        Me.txtAmountTotal.Name = "txtAmountTotal"
        Me.txtAmountTotal.Size = New System.Drawing.Size(200, 20)
        Me.txtAmountTotal.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(9, 433)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Amount Total"
        '
        'btnAmountTotal
        '
        Me.btnAmountTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAmountTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmountTotal.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAmountTotal.ForeColor = System.Drawing.Color.White
        Me.btnAmountTotal.Location = New System.Drawing.Point(218, 446)
        Me.btnAmountTotal.Name = "btnAmountTotal"
        Me.btnAmountTotal.Size = New System.Drawing.Size(147, 33)
        Me.btnAmountTotal.TabIndex = 22
        Me.btnAmountTotal.Text = "Get Total"
        Me.btnAmountTotal.UseVisualStyleBackColor = False
        '
        'picboxCellImage
        '
        Me.picboxCellImage.Location = New System.Drawing.Point(940, 22)
        Me.picboxCellImage.Name = "picboxCellImage"
        Me.picboxCellImage.Size = New System.Drawing.Size(573, 475)
        Me.picboxCellImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picboxCellImage.TabIndex = 23
        Me.picboxCellImage.TabStop = False
        '
        'btnPrintData
        '
        Me.btnPrintData.Location = New System.Drawing.Point(859, 433)
        Me.btnPrintData.Name = "btnPrintData"
        Me.btnPrintData.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintData.TabIndex = 24
        Me.btnPrintData.Text = "Print"
        Me.btnPrintData.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'frmCreditReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1525, 509)
        Me.Controls.Add(Me.btnPrintData)
        Me.Controls.Add(Me.picboxCellImage)
        Me.Controls.Add(Me.btnAmountTotal)
        Me.Controls.Add(Me.txtAmountTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdCreditReports)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreditReports"
        Me.Text = "Credit Reports"
        CType(Me.grdCreditReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxCellImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdCreditReports As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmountTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAmountTotal As Button
    Friend WithEvents picboxCellImage As PictureBox
    Friend WithEvents btnPrintData As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
