    Imports System.Data.SqlClient

    Public Class AddUserForm
    Private Sub RegisterUserButton_Click(sender As Object, e As EventArgs) Handles RegisterUserButton.Click
        Dim fullName As String = UserFullnameField.Text
        Dim email As String = UserEmailField.Text
        Dim phone As String = UserPhoneField.Text
        Dim address As String = UserAddressField.Text

        Dim query As String = $"INSERT INTO Users (fullName, email, phone, address) VALUES ('{fullName}', '{email}', '{phone}', '{address}') "

        DatabaseHelper.InsertData(query)
        Dashboard.PopulateUsersTable()

        Me.Hide()

        MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK)
    End Sub
End Class