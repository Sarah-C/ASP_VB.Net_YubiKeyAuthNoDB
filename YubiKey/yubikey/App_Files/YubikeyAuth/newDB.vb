Namespace YubikeyAuth
Public Partial Class storeSQL

    Public shared function batchSQLInstructions_makeDB() As string
        dim nameDB As String=CONFIG.DBName
        return _
"USE [master];" & vbCrLf + _
"CREATE DATABASE [" & nameDB & "];" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET COMPATIBILITY_LEVEL = 100;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ANSI_NULL_DEFAULT OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ANSI_NULLS OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ANSI_PADDING OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ANSI_WARNINGS OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ARITHABORT OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET AUTO_CLOSE ON;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET AUTO_CREATE_STATISTICS ON;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET AUTO_SHRINK OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET AUTO_UPDATE_STATISTICS ON;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET CURSOR_CLOSE_ON_COMMIT OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET CURSOR_DEFAULT  GLOBAL;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET CONCAT_NULL_YIELDS_NULL OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET NUMERIC_ROUNDABORT OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET QUOTED_IDENTIFIER OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET RECURSIVE_TRIGGERS OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET  ENABLE_BROKER;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET AUTO_UPDATE_STATISTICS_ASYNC OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET DATE_CORRELATION_OPTIMIZATION OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET TRUSTWORTHY OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET ALLOW_SNAPSHOT_ISOLATION OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET PARAMETERIZATION SIMPLE;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET READ_COMMITTED_SNAPSHOT OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET HONOR_BROKER_PRIORITY OFF;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET  READ_WRITE;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET RECOVERY SIMPLE;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET  MULTI_USER;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET PAGE_VERIFY CHECKSUM;" & vbCrLf + _
"ALTER DATABASE [" & nameDB & "] SET DB_CHAINING OFF;"
    End Function

    Public shared function batchSQLInstructions_makeTables() As string
        dim nameDB As String=CONFIG.DBName
        return _
"USE [" & nameDB & "];" & vbCrLf + _
"SET ANSI_NULLS ON;" & vbCrLf + _
"SET QUOTED_IDENTIFIER ON;" & vbCrLf + _
"SET ANSI_PADDING ON;" & vbCrLf + _
"CREATE TABLE [dbo].[lastGoodKeys](" & vbCrLf + _
"	[recordID] [int] IDENTITY(567364,1) NOT FOR REPLICATION NOT NULL," & vbCrLf + _
"	[AESPrivateKey] [char](32) NOT NULL," & vbCrLf + _
"	[privateID] [char](12) NOT NULL," & vbCrLf + _
"	[publicID] [char](12) NOT NULL," & vbCrLf + _
"	[sessionCounter] [int] NOT NULL," & vbCrLf + _
"	[timeStamp] [int] NOT NULL," & vbCrLf + _
"	[useCounter] [int] NOT NULL," & vbCrLf + _
" CONSTRAINT [PK_Keys] PRIMARY KEY CLUSTERED " & vbCrLf + _
"(" & vbCrLf + _
"	[recordID] ASC" & vbCrLf + _
")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & vbCrLf + _
") ON [PRIMARY];" & vbCrLf + _
"SET ANSI_PADDING OFF;"
    End Function

End Class
End Namespace