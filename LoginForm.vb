Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PasswordField.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameField.Text
        Dim password As String = PasswordField.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please enter the username!", "Invalid crendentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(password) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter the password!", "Invalid crendentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = $"SELECT top 1 * from Admins where username='{username}'"

        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery(query)

        ' If no users found then return after showing a message
        If dataTable.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid credentials!", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim storedHashPassword = dataTable.Rows(0)("passwordHash").ToString()

        Dim isPasswordCorrect As Boolean = PasswordHasher.VerifyPassword(password, storedHashPassword)

        ' If password is not correct then return
        If Not isPasswordCorrect Then
            MessageBox.Show("Password is incorrect!", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        LocalSession.username = username
        ClearForm()

        ' If execution reached here then the credentials are valid, and the user is authenticated
        Me.Hide()
        Dashboard.Show()
    End Sub

    Public Sub ClearForm()
        UsernameField.Clear()
        PasswordField.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
