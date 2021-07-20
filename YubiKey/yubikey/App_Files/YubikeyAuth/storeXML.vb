Imports System.Xml
Imports System.IO
Namespace YubikeyAuth
Public Class StoreXML : Inherits storageBase : Implements IStorable

    Public Overrides Function getKeyRecordByPublicID(ByRef publicID As String) As DataRow
        Dim dt =loadXML(publicID)
        Dim row = dt.Rows(0)
        hex_publicID=publicID
        hex_privateID=row.Item("privateID")
        hex_AESPrivateKey=row.Item("AESPrivateKey")
        int_sessionCounter=row.Item("sessionCounter")
        int_timeStamp=row.Item("timeStamp")
        int_useCounter=row.Item("useCounter")
        Return row
    End Function

    Public Overrides sub setKeyRecord(ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)
        Dim dt = loadXML(hex_publicID)
        dt.Rows(0).Item("sessionCounter")=sessionCounter
        dt.Rows(0).Item("timeStamp")=timeStamp
        dt.Rows(0).Item("useCounter")=useCounter
        int_sessionCounter=sessionCounter
        int_timeStamp=timeStamp
        int_useCounter=useCounter
        saveXML(dt,hex_publicID)
    End sub

    Public Overrides sub createRecord(ByRef publicID As String, ByRef privateID As String, ByRef AESPrivateKey As String, ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)
        Dim dt = New DataTable("KeyData")
        dt.Columns.Add("AESPrivateKey", GetType(String))
        dt.Columns.Add("privateID", GetType(String))
        dt.Columns.Add("publicID", GetType(String))
        dt.Columns.Add("sessionCounter", GetType(integer))
        dt.Columns.Add("timeStamp", GetType(integer))
        dt.Columns.Add("useCounter", GetType(integer))
        Dim dr = dt.NewRow()
        dr("AESPrivateKey") = AESPrivateKey
        dr("privateID") = privateID
        dr("publicID") = publicID
        dr("sessionCounter") = sessionCounter
        dr("timeStamp") = timeStamp
        dr("useCounter") = useCounter
        dt.Rows.Add(dr)
        dt.WriteXml(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/" & publicID & ".xml"))
    End Sub

    Public Overrides Sub createStore()
        Dim dt = New DataTable("KeyData")
        dt.Columns.Add("AESPrivateKey", GetType(String))
        dt.Columns.Add("privateID", GetType(String))
        dt.Columns.Add("publicID", GetType(String))
        dt.Columns.Add("sessionCounter", GetType(integer))
        dt.Columns.Add("timeStamp", GetType(integer))
        dt.Columns.Add("useCounter", GetType(integer))
        Dim dr = dt.NewRow()

        if not Directory.Exists(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/")) then
            Directory.CreateDirectory(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/"))
        end if
        dt.WriteXmlSchema(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/keyStoreSchema.xsd"))
    End Sub

    '##########################################

    Public Sub new(ByRef publicID As String)
        Dim row As DataRow = getKeyRecordByPublicID(publicID)
    End Sub

    'Ideal for just adding new data via createRecord
    Public Sub new()
        hex_publicID=""
        hex_privateID=""
        hex_AESPrivateKey=""
        int_sessionCounter=0
        int_timeStamp=0
        int_useCounter=0
    End Sub

    Public function loadXML(ByRef publicID As String) as datatable
        Dim dt As DataTable = New DataTable()
        try
            dt.ReadXmlSchema(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/keyStoreSchema.xsd"))
            dt.ReadXml(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/" & publicID & ".xml"))
            Return dt
        Catch ex As FileNotFoundException
            Throw New YubiKeyStorageExceptionPublicIDNotFound("File missing: " & publicID)
        Catch ex As Exception
            Throw New YubiKeyStorageException(ex.ToString())
        end try
    End function


    Public sub saveXML(ByRef dt As datatable, ByRef privateID As String)
        try
            dt.WriteXml(HttpContext.Current.Server.MapPath("/App_Data/YubiKey/" & privateID & ".xml"))
        Catch ex As Exception
            Throw New YubiKeyStorageException(ex.ToString())
        end try
    End sub

End Class
End Namespace