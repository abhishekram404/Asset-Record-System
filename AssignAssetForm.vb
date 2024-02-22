Public Class AssignAssetForm
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersDropdown()
        LoadAssetsDropdown()
    End Sub

    Private Sub AssignButton_Click(sender As Object, e As EventArgs) Handles AssignButton.Click
        Dim asset As AssetDropdownItem = SelectAssetDropdown.SelectedItem
        Dim user As UserDropdownItem = SelectUserDropdown.SelectedItem
        Dim assignmentDate As String = AssignmentDateField.Value.ToString("yyyy-MM-dd")
        Dim estimatedReturnDate As String = ReturnDateField.Value.ToString("yyyy-MM-dd")
        Dim notes As String = NotesField.Text

        If asset Is Nothing Then
            MessageBox.Show("Please select an asset!")
            Return
        End If

        If user Is Nothing Then
            MessageBox.Show("Please select a user!")
            Return
        End If

        Dim query = $"INSERT INTO AssetUserAssignment (assetId, userId, assignmentDate, estimatedReturnDate, notes) values ('{asset.assetId}', '{user.userId}', '{assignmentDate}', '{estimatedReturnDate}', '{notes}')"
        DatabaseHelper.InsertData(query)

        Dashboard.PopulateAssignmentsTable()
        Dashboard.LoadDashboardCardsData()

        Me.Close()

        MessageBox.Show("Assignment successful")
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

    Private Sub LoadAssetsDropdown()
        Dim query = "SELECT assetId, assetName, assetType from Assets
                     where assetId not in (select assetId from AssetUserAssignment)"
        Dim assets As DataTable = DatabaseHelper.ExecuteQuery(query)
        If assets.Rows.Count > 0 Then
            For Each row As DataRow In assets.Rows
                Dim assetId = Convert.ToInt32(row("assetId"))
                Dim assetName = Convert.ToString(row("assetName"))
                Dim assetType = Convert.ToString(row("assetType"))

                Dim dropdownItem As New AssetDropdownItem(assetId, assetName, assetType)
                SelectAssetDropdown.Items.Add(dropdownItem)
            Next
        End If
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class