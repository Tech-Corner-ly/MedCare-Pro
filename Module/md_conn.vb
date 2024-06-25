Imports System.Data.SqlClient

Module md_conn

    'Public dbServer As String = "192.168.11.254"
    'Public dbName As String = "clinic"
    'Public dbUsername As String = "sa"
    'Public dbPassword As String = "SysLab*2012"
    'Public connectionString As String = "Server=192.168.11.254;Database=clinic;User Id=sa;Password=SysLab*2012"
    'Public sQlConnection As New SqlConnection(connectionString)


    Public sQlConnection As New SqlConnection("Server= '" & My.Settings.dbServer & "'; Database='" & My.Settings.dbName & "'; User Id='" & My.Settings.dbUsername & "'; Password='" & My.Settings.dbPassword & "'")


    Public Function CheckConn() As Boolean
        Try
            If sQlConnection.State = ConnectionState.Open Then
                sQlConnection.Close()
            End If
            If sQlConnection.State = ConnectionState.Closed Then
                sQlConnection.Open()
                Return True
            End If
        Catch ex As Exception
            MsgBox("لا يوجد اتصال بقواعد البيانات, حاول مجدداً")
        End Try
#Disable Warning BC42353
    End Function


#Enable Warning BC42353
End Module
