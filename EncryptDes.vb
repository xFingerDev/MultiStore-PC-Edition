Imports System.IO

Module EncryptDes
	Public Function AES_Encrypt(ByVal input As String) As String
		Dim AES As New System.Security.Cryptography.RijndaelManaged
		Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
		Dim encrypted As String = ""
		Try
			Dim hash(31) As Byte
			Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes("Pepe1234LokioL"))
			Array.Copy(temp, 0, hash, 0, 16)
			Array.Copy(temp, 0, hash, 15, 16)
			AES.Key = hash
			AES.Mode = Security.Cryptography.CipherMode.ECB
			Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
			Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
			encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
			Return encrypted
		Catch ex As Exception
		End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
	End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

	Public Function AES_Decrypt(ByVal input As String) As String
		Dim AES As New System.Security.Cryptography.RijndaelManaged
		Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
		Dim decrypted As String = ""
		Try
			Dim hash(31) As Byte
			Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes("Pepe1234LokioL"))
			Array.Copy(temp, 0, hash, 0, 16)
			Array.Copy(temp, 0, hash, 15, 16)
			AES.Key = hash
			AES.Mode = Security.Cryptography.CipherMode.ECB
			Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
			Dim Buffer As Byte() = Convert.FromBase64String(input)
			decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
			Return decrypted
		Catch ex As Exception
		End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
	End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

End Module
