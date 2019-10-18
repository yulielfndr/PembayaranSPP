Imports System.Data.OleDb
Public Class FormPilihJurusan
    Dim baris As Integer
    Private Sub btnTambahAngkatan_Click(sender As Object, e As EventArgs) Handles btnTambahAngkatan.Click
        FormInputAngkatan.Show()
        Me.Close()
    End Sub
    Private Sub btnTambahKelas_Click(sender As Object, e As EventArgs) Handles btnTambahKelas.Click
        FormInputKelas.Show()
        Me.Close()
    End Sub
    Sub KelasXIPA()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'x-ipa%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Sub KelasXIIPA()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'xi-ipa%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Sub KelasXIIIPA()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'xii-ipa%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Sub KelasXIPS()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'x-ips%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Sub KelasXIIPS()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'xi-ips%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Sub KelasXIIIPs()
        CMD = New OleDbCommand("select kelas from kelas where kelas like 'xII-ips%'", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            FormDataSiswa.cmbKelas.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Me.Close()
    End Sub
    Private Sub xIpa_Click(sender As Object, e As EventArgs) Handles xIpa.Click
        Call KelasXIPA()

        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub xIps_Click(sender As Object, e As EventArgs) Handles xIps.Click
        Call KelasXIPS()

        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub xiIpa_Click(sender As Object, e As EventArgs) Handles xiIpa.Click
        Call KelasXIIPA()

        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub xiIps_Click(sender As Object, e As EventArgs) Handles xiIps.Click
        Call KelasXIIPS()
        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub xiiIpa_Click(sender As Object, e As EventArgs) Handles xiiIpa.Click
        Call KelasXIIIPA()
        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub xiiIips_Click(sender As Object, e As EventArgs) Handles xiiIips.Click
        Call KelasXIIIPs()

        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FormDashboard.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        FormDataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        FormPembayaran.Show()
        Me.Close()
    End Sub

    Private Sub btnAkun_Paint(sender As Object, e As PaintEventArgs) Handles btnAkun.Paint

    End Sub
End Class