Imports System.Data.OleDb
Public Interface InfProses
    Function InsertData(Ob As Object) As OleDbCommand
    Function UpdateData(Ob As Object) As OleDbCommand
    Function DeleteData(key As Object) As OleDbCommand
    Function tampilData() As DataView
    Function cariData(key As String) As DataView
    Function tampilDataSsiswa(kelas As String, angkatan As String) As DataView
End Interface
