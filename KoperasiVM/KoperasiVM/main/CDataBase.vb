Public Class CDataBase

    'Private dbCon As New SqlClient.SqlConnection
    'Private dbCommand As New SqlClient.SqlCommand
    'Private dbAdapter As New SqlClient.SqlDataAdapter
    Private dbCon As New OleDb.OleDbConnection
    Private dbCommand As New OleDb.OleDbCommand
    Private dbAdapter As New OleDb.OleDbDataAdapter
    Dim DT As New DataTable
    Dim clsConn As New CKoneksi

    Public Sub New()
        dbCon.ConnectionString = clsConn.ConnectDB
        dbCommand.Connection = dbCon
    End Sub

    Public Function insertDB(ByVal query As String) As Boolean
        dbCommand.CommandText = query
        dbCon.Open()

        Dim temp As Integer
        Try
            temp = dbCommand.ExecuteNonQuery
            dbCon.Close()
            Return True
        Catch ex As Exception
            dbCon.Close()
            Console.WriteLine(ex.Message)
            Return False
        End Try
        dbCon.Close()
    End Function

    Public Function updateDB(ByVal query As String) As Boolean
        dbCommand.CommandText = query
        dbCon.Open()

        Dim temp As Integer
        Try
            temp = dbCommand.ExecuteNonQuery
            dbCon.Close()
            Return True
        Catch ex As Exception
            dbCon.Close()
            Console.WriteLine(ex.Message)
            Return False
        End Try
        dbCon.Close()
    End Function

    Public Function deleteDB(ByVal query As String) As Boolean
        dbCommand.CommandText = query
        dbCon.Open()

        Dim temp As Integer
        Try
            temp = dbCommand.ExecuteNonQuery
            dbCon.Close()
            Return True
        Catch ex As Exception
            dbCon.Close()
            Console.WriteLine(ex.Message)
            Return False
        End Try
        dbCon.Close()
    End Function

    Public Function selectDB(ByVal query As String) As DataTable
        Try
            Dim dt As New DataTable

            dbCommand.CommandText = query
            dbCon.Open()

            dbCommand.Connection = dbCon
            dbCommand.CommandText = query

            dbAdapter.SelectCommand = dbCommand
            'dbAdapter.FillSchema(DT, SchemaType.Mapped)
            dbAdapter.Fill(dt)
            dbCon.Close()
            Return dt
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            MessageBox.Show(ex.ToString)
            Return DT
        End Try

    End Function
End Class