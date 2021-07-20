Namespace YubikeyAuth
Public Interface IStorable

    function getKeyRecordByPublicID(ByRef publicID As String) As DataRow

    sub setKeyRecord(ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)

    sub createRecord(ByRef publicID As String, ByRef privateID As String, ByRef AESPrivateKey As String, ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)
    
    Sub createStore()

    Property hex_privateID As string
    property hex_AESPrivateKey as string
    property hex_publicID As String
	property int_sessionCounter As UInt16
	property int_timeStamp As UInt32
	property int_useCounter As [Byte]

End Interface

End Namespace