Imports System.Security
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class sha256
    Public Shared cmode = 1
    Public Shared pass As String

    Public Shared Function ByteArrayToString(ba As Byte()) As String
        Dim hex As New StringBuilder(ba.Length * 2)
        For Each b As Byte In ba
            hex.AppendFormat("{0:x2}", b)
        Next
        Return hex.ToString()
    End Function

    Public Shared Function StringToByteArray(hex As [String]) As Byte()
        Dim NumberChars As Integer = hex.Length
        Dim bytes As Byte() = New Byte(NumberChars / 2 - 1) {}
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return bytes
    End Function

    Public Shared Function Encrypt(ByVal input As String) As String
        cmode = 0
        Dim Sha256 As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_Sha256 As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim encrypted As String
        Try
            Dim hash(31) As Byte
            Dim iv(15) As Byte
            Dim temp As Byte() = Hash_Sha256.ComputeHash(System.Text.UnicodeEncoding.UTF8.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            Sha256.Key = hash
            Sha256.Mode = CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = Sha256.CreateEncryptor
            Dim Buffer As Byte() = System.Text.UnicodeEncoding.UTF8.GetBytes(input)
            encrypted = ByteArrayToString(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function Decrypt(ByVal input As String) As String
        cmode = 1
        Dim Sha256 As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_Sha256 As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim decrypted As String
        Try
            Dim hash(31) As Byte
            Dim iv(15) As Byte
            Dim temp As Byte() = Hash_Sha256.ComputeHash(System.Text.UnicodeEncoding.UTF8.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            Sha256.Key = hash
            Sha256.Mode = CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = Sha256.CreateDecryptor
            Dim Buffer As Byte() = StringToByteArray(input)
            decrypted = System.Text.UnicodeEncoding.UTF8.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function DecriptImage(file As String) As MemoryStream
        Dim objreader As New System.IO.StreamReader(file)
        Dim rbytes() As Byte = Convert.FromBase64String(Decrypt(objreader.ReadToEnd))
        Dim rms As New MemoryStream(rbytes, 0, rbytes.Length)
        objreader.Close()
        Return rms
    End Function

    Public Shared Function EncriptImage(ByVal imagetype As Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        mainform.criptedimage.Image.Save(ms, imagetype)
        Dim bytes() As Byte = ms.ToArray
        Dim image_base64String As String = Convert.ToBase64String(bytes)
        Return Encrypt(image_base64String)
    End Function

End Class
