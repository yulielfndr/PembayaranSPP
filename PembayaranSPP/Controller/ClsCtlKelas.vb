Imports System.Data.OleDb
Imports TugasProyek
Public Class ClsCtlKelas : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from kelas " _
                               & "where id_kelas='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKelas
        data = Ob
        CMD = New OleDbCommand("insert into kelas values('" & data.IdKelas & "','" _
                               & data.Kelas & "','" & data.Jurusan & "','" & data.IdAngkatan & "')", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function



    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from kelas", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_kelas")
            Dim grid As New DataView(DTS.Tables("Tabel_kelas"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntKelas
        data = Ob
        CMD = New OleDbCommand("update kelas set kelas='" _
                               & data.Kelas & "',jurusan=" & data.Jurusan _
                               & "',id_angkatan=" & data.IdAngkatan _
                               & "where id_kelas='" & data.IdKelas & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim akhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_kelas,5)) from kelas", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            akhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K" & Strings.Right("000" & akhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekKelas(key As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_kelas) from kelas " _
                                       & "where id_kelas='" & key & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
            Return cek
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function tampilDataSsiswa(kelas As String, angkatan As String) As DataView Implements InfProses.tampilDataSsiswa
        Throw New NotImplementedException()
    End Function
End Class
