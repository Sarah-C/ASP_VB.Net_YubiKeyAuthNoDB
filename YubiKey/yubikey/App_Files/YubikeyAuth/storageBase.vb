Namespace YubikeyAuth
Public mustinherit class storageBase : Inherits storageExceptions : Implements IStorable

    Public MustOverride Function getKeyRecordByPublicID(ByRef publicID As String) As DataRow Implements IStorable.getKeyRecordByPublicID
    Public MustOverride sub setKeyRecord(ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer) Implements IStorable.setKeyRecord
    Public MustOverride sub createRecord(ByRef publicID As String, ByRef privateID As String, ByRef AESPrivateKey As String, ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer) Implements IStorable.createRecord
    Public MustOverride sub createStore() Implements IStorable.createStore

    Public Property hex_publicID() As String Implements IStorable.hex_publicID
        Get
            Return property_hex_publicID
        End Get
        Set(ByVal value As String)
            property_hex_publicID = value
        End Set
    End Property

    Public Property hex_privateID() As String Implements IStorable.hex_privateID
        Get
            Return property_hex_privateID
        End Get
        Set(ByVal value As String)
            property_hex_privateID = value
        End Set
    End Property

    Public Property hex_AESPrivateKey() As String Implements IStorable.hex_AESPrivateKey
        Get
            Return property_hex_AESPrivateKey
        End Get
        Set(ByVal value As String)
            property_hex_AESPrivateKey = value
        End Set
    End Property

    Public Property int_sessionCounter() As UInt16 Implements IStorable.int_sessionCounter
        Get
            Return property_int_sessionCounter
        End Get
        Set(ByVal value As UInt16)
            property_int_sessionCounter = value
        End Set
    End Property

    Public Property int_timeStamp() As UInt32 Implements IStorable.int_timeStamp
        Get
            Return property_int_timeStamp
        End Get
        Set(ByVal value As UInt32)
            property_int_timeStamp = value
        End Set
    End Property

    Public Property int_useCounter() As [Byte] Implements IStorable.int_useCounter
        Get
            Return property_int_useCounter
        End Get
        Set(ByVal value As [Byte])
            property_int_useCounter = value
        End Set
    End Property

    Private property_hex_publicID As String
    Private property_hex_privateID As String
    Private property_hex_AESPrivateKey As String
	Private property_int_sessionCounter As UInt16
	Private property_int_timeStamp As UInt32
	Private property_int_useCounter As [Byte]

End Class
End Namespace