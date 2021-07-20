Namespace YubikeyAuth
Public Class checkYubiKey : Inherits keyExceptions
    
    Public validKey As boolean
    Public errorStatus As errorStatusTypes

    Public enum errorStatusTypes
        YubiKeyNoError
        YubiKeyWrongOTPLengthException
	    YubiKeyInvalidOTPCharacterException
        YubiKeyCRCException
        YubiKeyReplayException
    End Enum

    public hex_publicID As String
    Public hex_OTP As String
    Public hex_AESPrivateKey As String

    public bytes_OTPEncrypted() As byte
    public bytes_secretAESKey() As byte
    public bytes_OTPDecrypted() As byte

    Public storageLocation As storageFactory.storageSource
    public OTPContent as YubiKeyDeSerialise
    Public storage As IStorable

    Public Sub new(ByRef hOTP As String, Optional ByRef maxInterval As Integer? = nothing)
        Try
            validKey=true
            errorStatus=errorStatusTypes.YubiKeyNoError
            storageLocation=CONFIG.storageType
            hex_OTP=hOTP.ToLowerInvariant()
            analyseAndUpdateOTP()
            checkKeyAgainstStore()
            If isNothing(maxInterval) then
                If validKey then updateStore()
            Else
                If validKey then
                    If OTPContent.aYubiKey.int_timeStamp-storage.int_timeStamp>maxInterval then 
                        Throw New YubiKeyReplayException("This OTP has expired.")
                    Else
                        updateStore()
                    End If
                end if
            End If

        'Following are the "standard" errors, that we report via an enumarated variable to the calling program.
        'Other exception types, such as YubiKeyStorageException are passed down to the calling function.
        Catch ex As YubiKeyWrongOTPLengthException
            errorStatus=errorStatusTypes.YubiKeyWrongOTPLengthException
            validKey=false
        Catch ex As YubiKeyInvalidOTPCharacterException
            errorStatus=errorStatusTypes.YubiKeyInvalidOTPCharacterException
            validKey=false
        Catch ex As YubiKeyCRCException
            errorStatus=errorStatusTypes.YubiKeyCRCException
            validKey=false
        Catch ex As YubiKeyReplayException
            errorStatus=errorStatusTypes.YubiKeyReplayException
            validKey=false
        end try
    End Sub

    Public Sub updateStore()
        storage.setKeyRecord(OTPContent.aYubiKey.int_sessionCounter,OTPContent.aYubiKey.int_timeStamp,OTPContent.aYubiKey.int_useCounter)
    End Sub

    Public sub checkKeyAgainstStore()
        If OTPContent.aYubiKey.int_sessionCounter < storage.int_sessionCounter then
            Throw New YubiKeyReplayException("This OTP has expired/been used.")
        else
            If (OTPContent.aYubiKey.int_sessionCounter=storage.int_sessionCounter) and OTPContent.aYubiKey.int_useCounter<=storage.int_useCounter then
                Throw New YubiKeyReplayException("This OTP has expired/been used.")
            End If
        End If
        If OTPContent.aYubiKey.hex_privateID <> storage.hex_privateID then Throw New YubiKeyInvalidPrivateID("Check for brute forcing hacks.")
    End sub

    Public Sub analyseAndUpdateOTP()
        If Len(hex_OTP)<>44 then Throw New YubiKeyWrongOTPLengthException("OTP has to be 44 characters.")
        hex_publicID=Left(hex_OTP,12)
        try
            bytes_OTPEncrypted=YubikeyAuth.modHex.decode(Right(hex_OTP,Len(hex_OTP)-12))
        Catch ex As YubikeyAuth.modHex.ModHexEncodingException
            Throw New YubiKeyInvalidOTPCharacterException(ex.ToString())
        end try
        Dim sFactory=New storageFactory(storageLocation)
        storage=sFactory.newStorageInstance()
        storage.getKeyRecordByPublicID(hex_publicID)
        bytes_secretAESKey=hex.decode(storage.hex_AESPrivateKey)
        bytes_OTPDecrypted=decryption.decrypt(bytes_OTPEncrypted,bytes_secretAESKey)
        OTPContent=New YubiKeyDeSerialise(bytes_OTPDecrypted)
    End Sub

End Class
end Namespace