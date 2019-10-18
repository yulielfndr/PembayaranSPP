Imports System.Data.OleDb
Imports TugasProyek
Public Class ClsCtlSiswa : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select siswa.nisn, siswa.nama, siswa.telp_ortu, kelas.kelas, angkatan.spp from siswa inner join angkatan on siswa.id_angkatan=angkatan.id_angkatan inner join kelas on siswa.kelas=kelas.id_kelas where siswa.nisn='" & key & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_KelasAngkatan")
            Dim grid As New DataView(DTS.Tables("Cari_KelasAngkatan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from siswa " _
            & "where nisn='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntSiswa
        data = Ob
        CMD = New OleDbCommand("insert into siswa values('" & data.nisn & "','" _
                               & data.NamaS & "','" & data.AlamatS & "','" _
                               & data.JK & "','" & data.NamaO & "','" _
                               & data.AlamatO & "','" & data.TelpO & "','" _
                               & data.id_kelas & "','" & data.id_angkatan & "')", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function



    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from siswa", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_siswa")
            Dim grid As New DataView(DTS.Tables("Tabel_siswa"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilDataSsiswa(kelas As String, angkatan As String) As DataView Implements InfProses.tampilDataSsiswa
        Try
            DTA = New OleDbDataAdapter("select siswa.nisn, siswa.nama, siswa.jeniskelamin, siswa.nama_ortu, siswa.alamat_ortu, siswa.telp_ortu, kelas.kelas, kelas.id_angkatan from siswa inner join kelas on siswa.kelas=kelas.id_kelas where kelas.kelas ='" & kelas & "'and kelas.id_angkatan ='" & angkatan & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_siswa")
            Dim grid As New DataView(DTS.Tables("Tabel_siswa"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntSiswa
        data = Ob
        CMD = New OleDbCommand("update siwa set nama='" _
                               & data.NamaS & "',alamat=" & data.AlamatS _
                               & "',jeniskelamin=" & data.JK & "',nama_ortu=" & data.NamaO & "',alamat_ortu=" _
                               & data.AlamatO & "',telp_ortu=" & data.TelpO & "',kelas=" _
                               & data.id_kelas & "',id_angkatan=" & data.id_angkatan & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
End Class
