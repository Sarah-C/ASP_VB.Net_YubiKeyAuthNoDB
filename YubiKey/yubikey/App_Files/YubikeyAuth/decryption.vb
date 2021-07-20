Imports System.Runtime.InteropServices
Imports System.Security.Cryptography

Namespace YubikeyAuth
Public Class decryption

    Private Shared ReadOnly EMPTY_IV As Byte() = New Byte(15) {}

    Public shared function decrypt(AESEncryptedOTP As Byte(), byref AESKey As Byte()) As byte()
	    Dim plainBytes As Byte()
	    Dim plainBytesPin As New GCHandle()
	    Using aes As Rijndael = Rijndael.Create()
		    aes.Padding = PaddingMode.None
		    aes.Mode = CipherMode.ECB
			Using xform As ICryptoTransform = aes.CreateDecryptor(AESKey,EMPTY_IV)
				plainBytes = New Byte(AESEncryptedOTP.Length - 1) {}
				plainBytesPin = GCHandle.Alloc(plainBytes, GCHandleType.Pinned)
				xform.TransformBlock(AESEncryptedOTP, 0, AESEncryptedOTP.Length, plainBytes, 0)
				xform.TransformFinalBlock(AESEncryptedOTP, 0, 0)
			End Using
	    End Using
        Return plainBytes
    End function

End Class
end Namespace