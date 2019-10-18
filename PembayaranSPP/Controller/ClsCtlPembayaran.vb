Imports System.Data.OleDb
Imports TugasProyek
Public Class ClsCtlPembayaran : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntPembayaran
        data = Ob
        CMD = New OleDbCommand("insert into pembayaran values('" & data.IdPembayaran & "','" _
                               & data.nisn & "','" & data.tanggal & "','" _
                               & data.bulan & "'," & data.spp & ",'" _
                               & data.username & "')", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function tampilDataSsiswa(kelas As String, angkatan As String) As DataView Implements InfProses.tampilDataSsiswa
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Throw New NotImplementedException()
    End Function
End Class
