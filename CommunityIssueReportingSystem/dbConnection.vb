Imports Microsoft.Data.SqlClient

Public Module DatabaseModule

    Private ConnectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CommunityReport;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

    Public Function TestConnection() As Boolean
        Using conn As SqlConnection = GetConnection()
            Try
                conn.Open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

End Module