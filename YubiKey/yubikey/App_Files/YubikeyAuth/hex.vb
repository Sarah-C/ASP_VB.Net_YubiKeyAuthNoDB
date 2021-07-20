Namespace YubikeyAuth
Public NotInheritable Class hex

	Public Shared Function Decode(hexString As String) As Byte()
		If hexString Is Nothing Then
			Throw New ArgumentNullException("hexString")
		End If
		If hexString.Length Mod 2 <> 0 Then
			hexString = "0"C & hexString
		End If
		Dim sb As New StringBuilder(hexString)
		Dim bytes As Byte() = New Byte(hexString.Length \ 2 - 1) {}
		Dim j As Integer = 0
		For i As Integer = 0 To hexString.Length - 1 Step 2
			bytes(j) = Convert.ToByte(sb.ToString(i, 2), 16)
            j=j+1
		Next
		Return bytes
	End Function

	Public Shared Function Encode(bytes As Byte()) As String
		If bytes Is Nothing Then
			Throw New ArgumentNullException("bytes")
		End If
		Dim sb As New StringBuilder(bytes.Length * 2)
		For i As Integer = 0 To bytes.Length - 1
			Dim b As Byte = bytes(i)
			sb.Append(b.ToString("x2"))
		Next
		Return sb.ToString()
	End Function

End Class
End Namespace