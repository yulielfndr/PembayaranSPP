Imports System.Data.OleDb
Imports TugasProyek
Public Class ClsCtlAngkatan : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from angkatan " _
                               & "where id_angkatan='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntAngkatan
        data = Ob
        CMD = New OleDbCommand("insert into angkatan values('" & data.KodeAngktn & "','" _
                               & data.Angktn & "'," & data.bSpp & ")", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from angkatan", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_angkatan")
            Dim grid As New DataView(DTS.Tables("Tabel_angkatan"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntAngkatan
        data = Ob
        CMD = New OleDbCommand("update angkatan set angkatan='" _
                               & data.Angktn & "',spp=" & data.bSpp _
                               & "where id_angkatan='" & data.KodeAngktn & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim akhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_angkatan,3)) from angkatan", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            akhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "A" & Strings.Right("00" & akhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekAngkatan(key As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(id_angkatan) from angkatan " _
                                       & "where id_angkatan='" & key & "'", OPENCONNECTION)
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
