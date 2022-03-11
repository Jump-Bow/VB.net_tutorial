Imports Oracle.ManagedDataAccess.Client
Imports Dapper



Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr = "DATA SOURCE=127.0.0.1/db_name; PASSWORD=password; PERSIST SECURITY INFO=True; USER ID=user_id"

        Dim cn As New OracleConnection(connStr)

        Dim result = cn.Query("select * from table_name")

        For Each item In result
            Console.WriteLine(item)
        Next

    End Sub
End Class
