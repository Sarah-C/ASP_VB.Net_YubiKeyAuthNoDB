Namespace YubikeyAuth
Public Class storageExceptions

    Public Class YubiKeyStorageExceptionPublicIDNotFound : Inherits YubiKeyStorageException
		Public Sub New(message As String)
			MyBase.New(message)
		End Sub
	End Class

    Public Class YubiKeyStorageException
		Inherits ApplicationException
		Public Sub New(message As String)
			MyBase.New("YubiKey authenticator exception: " & message)
		End Sub
	End Class

End Class
End Namespace