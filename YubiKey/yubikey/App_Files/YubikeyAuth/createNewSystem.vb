Namespace YubikeyAuth
Public Class createNewSystem

    Dim storage As IStorable

    Public Sub new()
        Dim sFactory=New storageFactory(CONFIG.storageType)
        storage=sFactory.newStorageInstance()
        storage.createStore()
    End Sub

    Public sub createRecord(ByRef publicID As String, ByRef privateID As String, ByRef AESPrivateKey As String)
        storage.createRecord(publicID,privateID,AESPrivateKey,0,0,0)
    End Sub

End Class
End Namespace