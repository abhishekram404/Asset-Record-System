Public Class AssetDropdownItem
    Public Property assetId As Integer
    Public Property assetName As String
    Public Property assetType As String

    Public Sub New(assetId As Integer, assetName As String, assetType As String)
        Me.assetId = assetId
        Me.assetName = assetName
        Me.assetType = assetType
    End Sub

    Public Overrides Function ToString() As String
        Return assetName & " " & $"('{assetType}')"
    End Function
End Class
