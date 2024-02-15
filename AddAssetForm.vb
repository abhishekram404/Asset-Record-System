Imports System.Data.SqlClient

Public Class AddAssetForm
    Private Sub AssAssetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssetTypeDropdownField.SelectedIndex = 0
    End Sub


    Private Sub SubmitNewAssetButton_Click(sender As Object, e As EventArgs) Handles SubmitNewAssetButton.Click
        Dim isFormValid As Boolean = ValidateForm()
        If isFormValid Then
            Dim assetInfo As Asset = GetFormDetails()

            Dim query As String = $"INSERT INTO Assets (assetName, assetType, assetWorth, purchaseDate, description) VALUES ('{assetInfo.Name}', '{assetInfo.Type}', '{assetInfo.Worth}', '{assetInfo.PurchaseDate}', '{assetInfo.Description}')"
            DatabaseHelper.InsertData(query)

            Dashboard.PopulateAssetsTable()
            ClearForm()
            Me.Hide()

            MessageBox.Show("Asset added successfully")
        End If

    End Sub

    Private Function ValidateForm()
        Dim assetInfo As Asset = GetFormDetails()

        If String.IsNullOrWhiteSpace(assetInfo.Name) Then
            MessageBox.Show("Asset name cannot be empty!")
            Return False
        End If

        If String.IsNullOrEmpty(assetInfo.Type) Then
            MessageBox.Show("Asset type cannot be empty!")
            Return False
        End If

        Return True
    End Function

    Private Function GetFormDetails()
        Dim assetInfo As New Asset()

        assetInfo.Name = AssetNameField.Text
        assetInfo.Type = AssetTypeDropdownField.SelectedItem.ToString()
        assetInfo.Worth = AssetWorthField.Value
        assetInfo.PurchaseDate = AssetPurchaseDateField.Value.ToString("yyyy-MM-dd")
        assetInfo.Description = AssetDescriptionField.Text

        Return assetInfo
    End Function

    Private Sub ClearForm()
        AssetNameField.Clear()
        AssetTypeDropdownField.SelectedIndex = -1
        AssetWorthField.Value = 0
        AssetPurchaseDateField.Value = Today
        AssetDescriptionField.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ClearForm()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles AssetPurchaseDateField.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AssetNameField.TextChanged

    End Sub
End Class