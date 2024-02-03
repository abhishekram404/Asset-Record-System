Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHasher
    Public Shared Function HashPassword(password As String) As String
        ' Generate a unique salt for each user
        Dim saltBytes(15) As Byte
        Using rngCsp As New RNGCryptoServiceProvider()
            rngCsp.GetBytes(saltBytes)
        End Using

        ' Combine password and salt
        Dim combinedBytes = Encoding.UTF8.GetBytes(password).Concat(saltBytes).ToArray()

        ' Hash the combined bytes using SHA-256
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(combinedBytes)
            Dim hashedPassword As String = Convert.ToBase64String(hashedBytes)

            ' Combine the salt and hashed password for storage in the database
            Dim saltedHashedPassword As String = Convert.ToBase64String(saltBytes) & ":" & hashedPassword

            Return saltedHashedPassword
        End Using
    End Function

    Public Shared Function VerifyPassword(password As String, storedHashedPassword As String) As Boolean
        ' Extract the salt and hashed password from the stored value
        Dim parts As String() = storedHashedPassword.Split(":")
        If parts.Length <> 2 Then
            Return False
        End If

        Dim saltBytes As Byte() = Convert.FromBase64String(parts(0))
        Dim storedHashedBytes As Byte() = Convert.FromBase64String(parts(1))

        ' Combine input password and extracted salt
        Dim combinedBytes = Encoding.UTF8.GetBytes(password).Concat(saltBytes).ToArray()

        ' Hash the combined bytes using SHA-256
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(combinedBytes)

            ' Compare the computed hash with the stored hash
            Return hashedBytes.SequenceEqual(storedHashedBytes)
        End Using
    End Function
End Class