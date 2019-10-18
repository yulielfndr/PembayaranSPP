Imports System.Data.OleDb
Imports TugasProyek
Public Class ClsCtlPetugas : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
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
