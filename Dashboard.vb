﻿Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable = DatabaseHelper.ExecuteQuery($"select top 1 * from Admins where username='{LocalSession.username}'")

        If dataTable.Rows.Count = 0 Then
            Me.Hide()
            LoginForm.Show()
        Else
            AuthenticatedUsername.Text = dataTable.Rows(0)("username").ToString()
        End If

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
