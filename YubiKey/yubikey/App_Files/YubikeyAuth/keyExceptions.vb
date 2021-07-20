Namespace YubikeyAuth

Public Class keyExceptions
    'If the OTP is grossly wrong - too few characters for instance
	Public Class YubiKeyWrongOTPLengthException
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    'If the OTP is grossly wrong - too few characters for instance
	Public Class YubiKeyInvalidOTPCharacterException
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    'If the OTP CRC check fails
    Public Class YubiKeyCRCException
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    'If the YubiKey has been previously used
    Public Class YubiKeyReplayException
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    'If the YubiKey has been previously used
    Public Class YubiKeyInvalidPrivateID
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    'If the storage object is empty
    Public Class YubiKeyStorageException
		Inherits YubiKeyException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    Public Class YubiKeyException
		Inherits ApplicationException
		Public Sub New(message As String)
			MyBase.New("YubiKey authenticator exception: " & message)
		End Sub
	End Class
End Class
End Namespace