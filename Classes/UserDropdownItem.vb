Public Class UserDropdownItem
    Public Property userId As Integer
    Public Property fullName As String

    Public Sub New(userId As Integer, fullName As String)
        Me.userId = userId
        Me.fullName = fullName
    End Sub

    Public Overrides Function ToString() As String
        Return fullName
    End Function

End Class
