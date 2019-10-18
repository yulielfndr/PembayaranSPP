Imports System.Data.OleDb
Module ModKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Data Source=DESKTOP-PQ3L41T;Integrated Security=SSPI;Initial Catalog=TugasProyek"
    Public koneksi As New OleDbConnection(strKon)
    Sub conn()
        OPENCONNECTION()
    End Sub
    Public Function OPENCONNECTION() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception

        End Try
        Return koneksi
    End Function
    Public Function CLOSECONNECTION() As OleDbConnection
        koneksi.Close()
        Return koneksi
    End Function
End Module
