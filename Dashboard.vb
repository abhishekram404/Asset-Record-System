Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery($"select top 1 * from Admins where username='{LocalSession.username}'")

        If dataTable.Rows.Count = 0 Then
            Me.Hide()
            LoginForm.Show()
        Else
            AuthenticatedUsername.Text = dataTable.Rows(0)("username").ToString()
            PopulateAssetsTable()
            PopulateUsersTable()
            PopulateAssignmentsTable()
            LoadDashboardCardsData()
        End If

    End Sub

    Public Sub LoadDashboardCardsData()
        Dim usersCount As Integer = GetTotalCountFromTable("Users")
        Dim assetsCount As Integer = GetTotalCountFromTable("Assets")
        Dim assignmentCount As Integer = GetTotalCountFromTable("AssetUserAssignment")

        TotalUsersNumber.Text = usersCount
        TotalAssetsNumber.Text = assetsCount
        AssignedAssetsNumber.Text = assignmentCount
    End Sub

    Public Function GetTotalCountFromTable(ByVal tableName As String) As Integer
        Dim query As String = $"SELECT count(*) from {tableName}"

        Dim total As DataTable = DatabaseHelper.ExecuteQuery(query)
        Dim count As Integer = Convert.ToInt32(total.Rows(0)(0))
        Return count
    End Function

    Public Sub PopulateAssetsTable()
        Dim query As String = "select * from Assets"
        Dim assetsTable As DataTable = DatabaseHelper.ExecuteQuery(query)
        DashboardAssetsTable.DataSource = assetsTable
    End Sub

    Public Sub PopulateUsersTable()
        Dim query As String = "SELECT userId as ID, fullName as Name, email as Email, phone as Phone, address as Address from Users"
        Dim usersTable As DataTable = DatabaseHelper.ExecuteQuery(query)
        DashboardUsersTable.DataSource = usersTable
    End Sub
    Public Sub PopulateAssignmentsTable()
        Dim assignmentTableData As DataTable = DatabaseHelper.ExecuteQuery("select * from AssetUserAssignment")
        AssignmentTable.DataSource = assignmentTableData
    End Sub
    Private Sub AssignAssetButton_Click(sender As Object, e As EventArgs) Handles AssignAssetButton.Click
        AssignAssetForm.Show()
    End Sub

    Private Sub AddAssetButton_Click(sender As Object, e As EventArgs) Handles AddNewAssetButton.Click
        AddAssetForm.Show()
    End Sub

    Private Sub RegisterUserButton_Click(sender As Object, e As EventArgs) Handles RegisterUserButton.Click
        AddUserForm.Show()
    End Sub
End Class
