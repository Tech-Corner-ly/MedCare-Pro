Imports System.Data.SqlClient

Module md_function

    Dim sQLGetExamID01 As String = "SELECT [ItemExaminID1] 
                                      FROM [clinic].[dbo].[tbEmploye]
                                      Where [EmployeID]=2"


    Public Function GetExamID01(ByVal xEmployeID As Int32) As Boolean

        Dim sQLGetExamID01 As String = "SELECT [ItemExaminID1] 
                                      FROM [clinic].[dbo].[tbEmploye]
                                      Where [EmployeID]=2"

        Dim xCmd As New SqlCommand(sQLGetExamID01, sQlConnection)
        Try
            ' Open the connection
            sQlConnection.Open()

            ' Execute the command and retrieve the value
            Dim xExaminID = xCmd.ExecuteScalar()

            ' Check if result is not null and convert to Integer
            If xExaminID IsNot Nothing Then
                xEmployeID = Convert.ToInt32(xExaminID)
            End If
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error)
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

#Disable Warning BC42353
    End Function


#Enable Warning BC42353
End Module
