Imports System.Data.SqlClient

Public Class DatabaseHelper

    Private Shared Function GetConnectionString() As String
        Return "Data Source=DESKTOP-FSR73SI;Initial Catalog=ars;Integrated Security=True;TrustServerCertificate=True"
    End Function

    Public Shared Function ExecuteQuery(query As String) As DataTable
        Using con As New SqlConnection(GetConnectionString())
            Dim cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable

            con.Open()
            adapter.Fill(dataTable)

            Return dataTable
        End Using
    End Function

    Public Shared Sub InsertData(query As String)
        Using con As New SqlConnection(GetConnectionString())
            Dim cmd As New SqlCommand(query, con)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
