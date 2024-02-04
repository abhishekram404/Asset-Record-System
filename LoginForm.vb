Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PasswordField.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameField.Text
        Dim password As String = PasswordField.Text

        Dim query As String = $"SELECT top 1 * from Admins where username='{username}'"

        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery(query)

        ' If no users found then return after showing a message
        If dataTable.Rows.Count = 0 Then
            MessageBox.Show("No admin found with given username!", "Invalid credentials", MessageBoxButtons.OK)
            Return
        End If

        Dim storedHashPassword = dataTable.Rows(0)("passwordHash").ToString()

        Dim isPasswordCorrect As Boolean = PasswordHasher.VerifyPassword(password, storedHashPassword)

        ' If password is not correct then return
        If Not isPasswordCorrect Then
            MessageBox.Show("Password is incorrect", "Error")
            Return
        End If

        LocalSession.username = username

        ' If execution reached here then the credentials are valid, and the user is authenticated
        Me.Hide()
        Dashboard.Show()
    End Sub
End Class
