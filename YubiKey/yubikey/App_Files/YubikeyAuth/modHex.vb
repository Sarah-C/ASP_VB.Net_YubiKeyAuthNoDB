Namespace YubikeyAuth
Public NotInheritable partial Class modHex

	''' <summary>
	''' Utility class for encoding and decoding Yubico's MODHex
	''' format.
	''' </summary>
	''' <remarks>
	''' <para>MODHex is the format used to encode Yubikey authentication
	''' strings.  Rather than the typical encoding formats, the
	''' alphabet used by MODHex (<c>cbdefghijklnrtuv</c>) has the advantage
	''' of being in the same location on all known keyboard layouts (or so
	''' YubiCo syas).  This makes it ideal for encoding, since the YubiKey
	''' generates fake keyboard events to simulate typing by the user.</para>
	''' <para>The general idea here are pretty much taken from the
	''' YubiCo-J project.  However, the lookup-table-based implementation is
	''' new to this C# port.</para>
	''' </remarks>

		Public Const ALPHABET As String = "cbdefghijklnrtuv"
		Public Const DVORAK_ALPHABET As String = "jxe.uidchtnbpygk"
		Private Shared ReadOnly charTable As Char() = ALPHABET.ToCharArray()
		Private Const INVALID As Short = -1
		Private Const TABLE_OFFSET As Integer = CInt(AscW("A"C))

		''' <summary>
		''' Encodes an octet stream in MODHex.
		''' </summary>
		''' <param name="bytes">The bytes to be encoded.  Must not be null.</param>
		''' <returns>The encoded bytes.  An empty array will return an empty string.</returns>
		Public shared Function Encode(bytes As Byte()) As [String]
			If bytes Is Nothing Then
				Throw New ArgumentNullException("bytes")
			End If
			Dim sb As New StringBuilder(bytes.Length * 2)
			For i As Integer = 0 To bytes.Length - 1
				sb.Append(charTable((bytes(i) >> 4) And &Hf))
				sb.Append(charTable(bytes(i) And &Hf))
			Next
			Return sb.ToString()
		End Function

		''' <summary>
		''' Decodes a MODHex-encoded string back into an octet array.
		''' </summary>
		''' <param name="encodedBytes">The bytes to be decoded.  May not be null,
		''' but an empty string is acceptable.</param>
		''' <returns>The decoded data.  If an empty string is passed in, then an empty
		''' array will be returned.</returns>
		Public shared Function Decode(encodedBytes As String) As Byte()
			If encodedBytes Is Nothing Then
				Throw New ArgumentNullException("Can't decode 'nothing'")
			End If

			If encodedBytes.Length Mod 2 <> 0 Then
				Throw New ModHexEncodingException("Bad encoding. Length is not even.")
			End If

			Dim bytes As Byte() = New Byte(encodedBytes.Length \ 2 - 1) {}
			Dim ptr As Integer = 0
			For i As Integer = 0 To bytes.Length - 1


                'Find the first half of the nybble
				Dim c1 As Integer = AscW(encodedBytes(ptr)) - TABLE_OFFSET
                ptr+=1
				If c1 < 0 OrElse c1 > LOOKUP_WIDTH Then
					Throw New ModHexEncodingException(String.Format("Bad encoding: {0}", encodedBytes(ptr - 1)))
				End If

				
                'Find the second half of the nybble
                Dim c2 As Integer = AscW(encodedBytes(ptr)) - TABLE_OFFSET
                ptr+=1
				If c2 < 0 OrElse c2 > LOOKUP_HEIGHT Then
					Throw New ModHexEncodingException(String.Format("Bad encoding: {0}", encodedBytes(ptr - 1)))
				End If


                'Look up the byte value using the x,y values in the lookup table of the two nybbles
				Dim v As Short = LOOKUP(c1, c2)
				If v = INVALID Then
					Throw New ModHexEncodingException("Bad encoding.")
				End If


				bytes(i) = CByte(v)
			Next

			Return bytes
		End Function

		Public shared Function ConvertToDvorak(qwerty As String) As String
			Dim sb As New StringBuilder(qwerty.Length)
			Dim cs As Char() = qwerty.ToLower().ToCharArray()
			For i As Integer = 0 To cs.Length - 1
				Dim index As Integer = ALPHABET.IndexOf(cs(i))
				If index < 0 Then
					Throw New ModHexEncodingException("Bad character: " & cs(i))
				End If
				sb.Append(DVORAK_ALPHABET(index))
			Next
			Return sb.ToString()
		End Function

		Public shared Function ConvertFromDvorak(dvorak As String) As String
			Dim sb As New StringBuilder(dvorak.Length)
			Dim cs As Char() = dvorak.ToLower().ToCharArray()

			For i As Integer = 0 To cs.Length - 1
				Dim index As Integer = DVORAK_ALPHABET.IndexOf(cs(i))
				If index < 0 Then
					Throw New DvorakEncodingException("Bad character: " & cs(i))
				End If
				sb.Append(ALPHABET(index))
			Next

			Return sb.ToString()
		End Function


	Public Class ModHexEncodingException
		Inherits Exception
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

	Public Class DvorakEncodingException
		Inherits ModHexEncodingException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

End Class

end namespace