Public Class DeleteUserForm

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersDropdown()
    End Sub

    Public Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        Dim user As UserDropdownItem = SelectUserDropdown.SelectedItem

        If user Is Nothing Then
            MessageBox.Show("Please select a user!")
            Return
        End If
        Dim query As String =
            $"DELETE FROM AssetUserAssignment where userId={user.userId}
            DELETE from Users where userId={user.userId}"

        Me.Close()
        DatabaseHelper.InsertData(query)
        Dashboard.LoadDashboardCardsData()
        Dashboard.PopulateUsersTable()
        Dashboard.PopulateAssignmentsTable()

        MessageBox.Show("User deleted successfully")
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
End Class