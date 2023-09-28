Imports System.Security.Cryptography
Imports System.Text
Module M_Criptografia
    Public Function Encriptar(senha As String) As String
        Dim resultado As Byte()
        Dim Sha1 As New MD5CryptoServiceProvider
        Dim utf8 As New Text.UTF8Encoding
        Dim key As Byte() = Sha1.ComputeHash(utf8.GetBytes("270815**"))
        Dim algoritimo As New TripleDESCryptoServiceProvider
        Dim criptografia As ICryptoTransform
        Dim data_encripta As Byte()

        algoritimo.Key = key
        algoritimo.Mode = CipherMode.ECB
        algoritimo.Padding = PaddingMode.PKCS7
        data_encripta = utf8.GetBytes(senha)

        Try
            criptografia = algoritimo.CreateEncryptor
            resultado = criptografia.TransformFinalBlock(data_encripta, 0, data_encripta.Length)
        Catch ex As Exception
            MsgBox("Erro ao criptografar" & vbNewLine & ex.Message,, "Aviso!")
            algoritimo.Clear()
            Sha1.Clear()
        Finally
            algoritimo.Clear()
            Sha1.Clear()
        End Try

        Return Convert.ToBase64String(resultado)
    End Function

    Public Function Descriptar(senha As String) As String
        Dim resultado As Byte()
        Dim hash As New MD5CryptoServiceProvider
        Dim utf8 As New Text.UTF8Encoding
        Dim key As Byte() = hash.ComputeHash(utf8.GetBytes("270815**"))
        Dim algoritimo As New TripleDESCryptoServiceProvider

        algoritimo.Key = key
        algoritimo.Mode = CipherMode.ECB
        algoritimo.Padding = PaddingMode.PKCS7

        Dim data_descripta As Byte() = Convert.FromBase64String(senha)

        Try
            Dim descriptografia As ICryptoTransform = algoritimo.CreateDecryptor
            resultado = descriptografia.TransformFinalBlock(data_descripta, 0, data_descripta.Length)
        Catch ex As Exception
            MsgBox("Erro ao Descriptografar os dados" & vbNewLine & ex.Message,, "Aviso!")
            algoritimo.Clear()
            hash.Clear()
        Finally
            algoritimo.Clear()
            hash.Clear()
        End Try

        Return utf8.GetString(resultado)
    End Function

End Module
