Public Class AssignAssetForm
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim users As DataTable = DatabaseHelper.ExecuteQuery("SELECT userId, fullName from Users")
        If users.Rows.Count > 0 Then
            For Each row As DataRow In users.Rows
                Dim userId = Convert.ToInt32(row("userId"))
                Dim fullName = Convert.ToString(row("fullName"))

                Dim dropdownItem As New UserDropdownItem(userId, fullName)
                SelectUserDropdown.Items.Add(dropdownItem)
            Next
        End If

        Dim assets As DataTable = DatabaseHelper.ExecuteQuery("SELECT assetId, assetName, assetType from Assets")
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
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class