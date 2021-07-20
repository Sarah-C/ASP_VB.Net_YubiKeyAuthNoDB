Namespace YubikeyAuth
Public Class storageFactory

    Public storageLocation As storageSource

    public Enum storageSource
        database
        file
    End Enum

    Public Sub new(ByRef SL As storageSource)
        storageLocation=SL
    End Sub

    Public function newStorageInstance() As IStorable
        Select Case storageLocation
            Case storageSource.database: return New StoreSQL()
            Case storageSource.file: Return New StoreXML()
        End Select
        Return nothing
    End Function

End Class
End Namespace