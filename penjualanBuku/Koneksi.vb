Imports System.Data.OleDb
Module Koneksi
    Public conn As OleDbConnection
    Public dataAdapt As OleDbDataAdapter
    Public dataReader As OleDbDataReader
    Public dataSet As DataSet
    Public cmd As OleDbCommand

    Public Sub koneksiServer()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" _
                                   & Application.StartupPath & "\JualBuku.accdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
