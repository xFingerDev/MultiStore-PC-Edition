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

	Public Function FindItem(ByVal LV As ListView, ByVal TextToFind As String) As Integer
		For i As Integer = 0 To LV.Items.Count - 1
			If Trim(LV.Items(i).Text).Contains(Trim(TextToFind)) Then
				Return i
			End If
			For subitem As Integer = 0 To LV.Items(i).SubItems.Count - 1
				If Trim(LV.Items(i).SubItems(subitem).Text).Contains(Trim(TextToFind)) Then
					' If found, return the row number
					Return (i)
				End If
			Next
		Next
		' If not found, then return -1.
		Return -1
	End Function

	Class ListViewItemComparer
		Implements IComparer

		Private col As Integer
		Private AscOrder As Boolean

		Public Sub New()
			col = 0
			AscOrder = True
		End Sub

		Public Sub New(ByVal column As Integer, ByVal Ascending As Boolean)
			col = column
			AscOrder = Ascending
		End Sub

		Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
				Implements IComparer.Compare
			Try
				If AscOrder Then
					Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
				Else
					Return [String].Compare(CType(y, ListViewItem).SubItems(col).Text, CType(x, ListViewItem).SubItems(col).Text)
				End If
			Catch
			End Try

		End Function

	End Class
	Class ListViewItemComparer2
		Implements IComparer

		Private col As Integer
		Private AscOrder As Boolean

		Public Sub New()
			col = 0
			AscOrder = True
		End Sub

		Public Sub New(ByVal column As Integer, ByVal Ascending As Boolean)
			col = column
			AscOrder = Ascending
		End Sub

		Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
				Implements IComparer.Compare
			Try
				If AscOrder Then
					Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
				Else
					Return [String].Compare(CType(y, ListViewItem).SubItems(col).Text, CType(x, ListViewItem).SubItems(col).Text)
				End If
			Catch
			End Try

		End Function

	End Class
	Class ListViewItemComparer3
		Implements IComparer

		Private col As Integer
		Private AscOrder As Boolean

		Public Sub New()
			col = 0
			AscOrder = True
		End Sub

		Public Sub New(ByVal column As Integer, ByVal Ascending As Boolean)
			col = column
			AscOrder = Ascending
		End Sub

		Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
				Implements IComparer.Compare
			Try
				If AscOrder Then
					Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
				Else
					Return [String].Compare(CType(y, ListViewItem).SubItems(col).Text, CType(x, ListViewItem).SubItems(col).Text)
				End If
			Catch
			End Try

		End Function

	End Class
End Module
