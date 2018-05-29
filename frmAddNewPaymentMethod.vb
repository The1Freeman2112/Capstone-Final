Public Class frmAddNewPaymentMethod
    Private Sub btnSubmitNewPaymentMethod_Click(sender As Object, e As EventArgs) Handles btnSubmitNewPaymentMethod.Click
        Using conn As New OleDb.OleDbConnection With {
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mdeservi\OneDrive - Lowe's Companies Inc\Desktop\PTO\TroutmanPTO_DB.accdb"}

            conn.Open()
            ' MessageBox.Show("Fix Plz")    'works...
            Dim SQL As String

            SQL = "INSERT INTO [ctb_PaymentMethod] ([PaymentMethod]) VALUES (@PaymentMethod)"

            Using command As New OleDb.OleDbCommand(SQL, conn)
                command.Connection = conn

                command.Parameters.AddWithValue("@PaymentMethod", txtNewPaymentMethod.Text)

                If (command.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Your record has been submitted successfully!")
                End If
                conn.Close()

                txtNewPaymentMethod.Clear()


            End Using
        End Using
    End Sub

    Private Sub btnCancelCreditEntry_Click(sender As Object, e As EventArgs) Handles btnCancelCreditEntry.Click
        frmAddNewPaymentMethod.ActiveForm.Close()
    End Sub
End Class