Public Class frmAddNewEventType
    Private Sub btnSubmitNewEventType_Click(sender As Object, e As EventArgs) Handles btnSubmitNewEventType.Click
        Using conn As New OleDb.OleDbConnection With {
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mdeservi\OneDrive - Lowe's Companies Inc\Desktop\PTO\TroutmanPTO_DB.accdb"}

            conn.Open()
            ' MessageBox.Show("Fix Plz")    'works...
            Dim SQL As String

            SQL = "INSERT INTO [ctb_EventList] ([EventName]) VALUES (@EventName)"

            Using command As New OleDb.OleDbCommand(SQL, conn)
                command.Connection = conn

                command.Parameters.AddWithValue("@EventName", txtNewEventType.Text)

                If (command.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Your record has been submitted successfully!")
                End If
                conn.Close()

                txtNewEventType.Clear()


            End Using
        End Using
    End Sub

    Private Sub btnCancelCreditEntry_Click(sender As Object, e As EventArgs) Handles btnCancelCreditEntry.Click
        frmAddNewEventType.ActiveForm.Close()
    End Sub

End Class