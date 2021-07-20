Imports yubikey.YubikeyAuth.storageFactory
Namespace YubikeyAuth
Public Class CONFIG


    ' storageSource.file          : uses the App_Data folder, and XML to store the YubiKeys data.
    ' storageSource.file.database : uses the MS SQL Server database to store the YubiKey data.
    Public Shared storageType As storageSource = storageSource.file


    'Details for using a database connection to store the YubiKeys data:
    Public shared DBName As String      ="YubiKey"
    Public shared DBLocation As String  ="Sarah-PC\Sarah"
    Public shared DBUser As String      ="sa"
    Public shared DBPassword As String  ="Password1"


    'When you run the site, cilcking "Initialise the storage system!" in the head of the page,
    'and then the button marked "Make the database / XML system." will use the following commands to make the new YubiKey account details:
    Public Shared sub newUsers(ByRef newSystem As createNewSystem)

        'Add your new Yubikey details here...
        'newSystem.createRecord( Public ID in ModHex , Private ID in Hex , Private AES key in Hex )

        'Example key:
        newSystem.createRecord("vvnilflchcnn", "084f2877ab88", "742ca121d2662dd6f6b32119b1f7d6c9")

    End Sub

End Class
End Namespace
