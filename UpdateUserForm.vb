Public Class UpdateUserForm
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersDropdown()
    End Sub

    Private Sub UserDropdown_Change(sender As Object, e As EventArgs) Handles SelectUserDropdown.SelectedValueChanged
        Dim user As UserDropdownItem = SelectUserDropdown.SelectedItem

        Dim query = $"SELECT * from Users where userId={user.userId}"

        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery(query)

        Dim fullName = dataTable.Rows(0)("fullName").ToString()
        Dim email = dataTable.Rows(0)("email").ToString()
        Dim phone = dataTable.Rows(0)("phone").ToString()
        Dim address = dataTable.Rows(0)("address").ToString()

        UserFullnameField.Text = fullName
        UserEmailField.Text = email
        UserPhoneField.Text = phone
        UserAddressField.Text = address
    End Sub

    Private Sub UpdateUserButton_Click(sender As Object, e As EventArgs) Handles UpdateUserButton.Click
        Dim user As UserDropdownItem = SelectUserDropdown.SelectedItem

        Dim fullName = UserFullnameField.Text
        Dim email = UserEmailField.Text
        Dim phone = UserPhoneField.Text
        Dim address = UserAddressField.Text

        If String.IsNullOrEmpty(fullName) Then
            MessageBox.Show("Fullname is required!")
            Return
        End If

        Dim query = $"UPDATE Users 
                    set fullName='{fullName}',
                    email='{email}',
                    phone='{phone}',
                    address='{address}'
                    where userId={user.userId}"

        DatabaseHelper.InsertData(query)

        Dashboard.PopulateUsersTable()
        Me.Close()
        MessageBox.Show("User updated successfully")
    End Sub

    Private Sub LoadUsersDropdown()
        Dim users As DataTable = DatabaseHelper.ExecuteQuery("SELECT userId, fullName from Users")
        If users.Rows.Count > 0 Then
            For Each row As DataRow In users.Rows
                Dim userId = Convert.ToInt32(row("userId"))
                Dim fullName = Convert.ToString(row("fullName"))

                Dim dropdownItem As New UserDropdownItem(userId, fullName)
                SelectUserDropdown.Items.Add(dropdownItem)
            Next
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class