Imports System.Data.SqlClient
Namespace YubikeyAuth
Public Partial Class storeSQL : Inherits storageBase : Implements IStorable

    Public Overrides Function getKeyRecordByPublicID(ByRef publicID As String) As DataRow
        Dim datatable As System.Data.DataTable = New System.Data.DataTable()
        'Using opens and closes the connection automatically.
        Using connectionHandle As New SqlConnection(connection)
            Dim commandHandle As New SqlCommand("SELECT * FROM lastGoodKeys WHERE publicID=@publicID", connectionHandle)
            connectionHandle.Open()
            With commandHandle
                .CommandType = Data.CommandType.Text
                .Parameters.AddWithValue("@publicID", publicID)
            End With
            Dim dataAdaptor As SqlDataAdapter = New SqlDataAdapter(commandHandle)
            dataAdaptor.Fill(datatable)
        End Using
        If datatable.Rows.Count > 0 Then
            Dim row =datatable.Rows(0)
            hex_publicID=publicID
            hex_privateID=row.Item("privateID")
            hex_AESPrivateKey=row.Item("AESPrivateKey")
            int_sessionCounter=row.Item("sessionCounter")
            int_timeStamp=row.Item("timeStamp")
            int_useCounter=row.Item("useCounter")
            Return row
        Else
            Throw New YubiKeyStorageExceptionPublicIDNotFound("File missing: " & publicID)
        End If
    End Function

    Public Overrides sub setKeyRecord(ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)
        'Using opens and closes the connection automatically.
        Using connectionHandle As New SqlConnection(connection)
            Dim commandHandle As New SqlCommand("UPDATE lastGoodKeys SET sessionCounter=@sessionCounter, timeStamp=@timeStamp, useCounter=@useCounter WHERE publicID=@publicID", connectionHandle)
            connectionHandle.Open()
            With commandHandle
                .CommandType = Data.CommandType.Text
                .Parameters.AddWithValue("@publicID", hex_publicID)
                .Parameters.AddWithValue("@sessionCounter", sessionCounter)
                .Parameters.AddWithValue("@timeStamp", timeStamp)
                .Parameters.AddWithValue("@useCounter", useCounter)
            End With
            commandHandle.ExecuteNonQuery()
        End Using
        int_sessionCounter=sessionCounter
        int_timeStamp=timeStamp
        int_useCounter=useCounter
    End sub

    Public Overrides sub createRecord(ByRef publicID As String, ByRef privateID As String, ByRef AESPrivateKey As String, ByRef sessionCounter As Integer, ByRef timeStamp As Integer, ByRef useCounter As Integer)
        'Using opens and closes the connection automatically.
        Using connectionHandle As New SqlConnection(connection)
            Dim commandHandle As New SqlCommand("INSERT INTO lastGoodKeys (AESPrivateKey,privateID,publicID,sessionCounter,timeStamp,useCounter) VALUES(@AESPrivateKey,@privateID,@publicID,@sessionCounter,@timeStamp,@useCounter)", connectionHandle)
            connectionHandle.Open()
            With commandHandle
                .CommandType = Data.CommandType.Text
                .Parameters.AddWithValue("@AESPrivateKey", hex_publicID)
                .Parameters.AddWithValue("@privateID", hex_privateID)
                .Parameters.AddWithValue("@publicID", hex_publicID)
                .Parameters.AddWithValue("@sessionCounter", sessionCounter)
                .Parameters.AddWithValue("@timeStamp", timeStamp)
                .Parameters.AddWithValue("@useCounter", useCounter)
            End With
            commandHandle.ExecuteNonQuery()
        End Using
        int_sessionCounter=sessionCounter
        int_timeStamp=timeStamp
        int_useCounter=useCounter
    End Sub

    Public Overrides sub createStore()
        Dim datatable As System.Data.DataTable = New System.Data.DataTable()
        Using connectionHandle As New SqlConnection(DBMasterPath)
            Dim commandHandle As New SqlCommand(batchSQLInstructions_makeDB(), connectionHandle)
            connectionHandle.Open()
            commandHandle.ExecuteNonQuery()
            'Make database.
            commandHandle.CommandText=batchSQLInstructions_makeTables()
            commandHandle.ExecuteNonQuery()
        End Using
    End Sub

    '##########################################
    'Public shared initialConnection As String = CONFIG.DBMasterPath
    'Public shared connection As String = CONFIG.DBPath

    Public DBMasterPath As String
    Public connection As String

    Public Sub new(ByRef publicID As String)
        Dim row As DataRow = getKeyRecordByPublicID(publicID)
    End Sub

    'Ideal for just adding new data via createRecord
    Public Sub new()
        DBMasterPath="Data Source=" & CONFIG.DBLocation & ";Initial Catalog=Master;Persist Security Info=True;User ID=" & CONFIG.DBUser & ";Password=" & CONFIG.DBPassword
        connection="Data Source=" & CONFIG.DBLocation & ";Initial Catalog=" & CONFIG.DBName & ";Persist Security Info=True;User ID=" & CONFIG.DBUser & ";Password=" & CONFIG.DBPassword
        hex_publicID=""
        hex_privateID=""
        hex_AESPrivateKey=""
        int_sessionCounter=0
        int_timeStamp=0
        int_useCounter=0
    End Sub


End Class
End Namespace