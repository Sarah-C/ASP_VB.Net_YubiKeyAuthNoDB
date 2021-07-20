Namespace YubikeyAuth
Public Class YubiKeyDeSerialise : Inherits keyExceptions :

    public Structure YubiKeyType
        Public bytes_privateID As Byte()
        Public hex_privateID As String
	    Public int_sessionCounter As UInt16
	    Public int_timeStamp As UInt32
	    Public int_useCounter As [Byte]
	    Public int_random As UInt16
	    Public int_CRC As UInt16
        Public bool_CRCValid As boolean
    End Structure

    public aYubiKey As new YubiKeyType

    Public Sub new(ByRef plainBytes() As byte)
	    aYubiKey.int_sessionCounter = 0
	    aYubiKey.int_timeStamp = 0
	    aYubiKey.int_useCounter = 0
	    aYubiKey.int_random = 0
	    aYubiKey.int_CRC = 0
        aYubiKey.bool_CRCValid=CheckCRC(plainBytes)
        If Not aYubiKey.bool_CRCValid then Throw New YubiKeyCRCException("Yubikey data incorrect!")
	    aYubiKey.bytes_privateID = New Byte() {plainBytes(0), plainBytes(1), plainBytes(2), plainBytes(3), plainBytes(4), plainBytes(5)}
        aYubiKey.hex_privateID=hex.Encode(aYubiKey.bytes_privateID)
	    InitializeField(plainBytes, aYubiKey.int_sessionCounter, 6, 7)
	    InitializeField(plainBytes, aYubiKey.int_timeStamp, 8, 10)
	    aYubiKey.int_useCounter = plainBytes(11)
	    InitializeField(plainBytes, aYubiKey.int_random, 12, 13)
	    InitializeField(plainBytes, aYubiKey.int_CRC, 14, 15)
    End Sub

    public function CheckCRC(bytes As Byte())
	    Const VALID_CRC As UShort = &Hf0b8
	    Dim crc As UShort = &Hffff
	    For i As Integer = 0 To bytes.Length - 1
		    crc = crc Xor bytes(i)
		    For j As Integer = 0 To 7
			    Dim n As Integer = crc And &H1
			    crc >>= 1
			    If n <> 0 Then
				    crc = crc Xor &H8408
			    End If
		    Next
	    Next
	    Return(crc=VALID_CRC)
    End function

	Private Sub InitializeField(b As Byte(), ByRef value As UInt64, start As Integer, [end] As Integer)
		Dim shift As Integer = 0
		value = 0
		For i As Integer = [end] To start Step -1
			value = value Or CType(b(i), UInt64) << (([end] - start - shift) * 8)
            shift+=1
		Next
	End Sub

	Private Sub InitializeField(b As Byte(), ByRef value As UInt16, start As Integer, [end] As Integer)
		Dim shift As Integer = 0
		value = 0
		For i As Integer = [end] To start Step -1
			value = value Or CType(CType(b(i), UInt16) << (([end] - start - shift) * 8), UInt16)
            shift+=1
		Next
	End Sub

	Private Sub InitializeField(b As Byte(), ByRef value As UInt32, start As Integer, [end] As Integer)
		Dim shift As Integer = 0
		value = 0
		For i As Integer = [end] To start Step -1
			value = value Or CType(b(i), UInt32) << (([end] - start - shift) * 8)
            shift+=1
		Next
	End Sub
End Class
End Namespace