Imports System.Data.OleDb
Public Class FormDashboard
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        FormPembayaran.Show()
        Me.Close()
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        FormPilihJurusan.Show()
        Me.Close()
    End Sub
End Class