Imports System.Data.OleDb
Imports TugasProyek.FormPilihJurusan

Public Class FormDataSiswa
    Dim modeProses As Integer
    Dim baris As Integer
    Sub TabelCari()
        LVCari.Columns.Add("NISN", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Nama", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Alamat", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Nama Orangtua", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Alamat Orangtua", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("No.HP Orangtua", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Kelas", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Angkatan", 100, HorizontalAlignment.Center)

        LVCari.View = View.Details
        LVCari.GridLines = True
        LVCari.FullRowSelect = True
    End Sub
    Private Sub RefreshGrid()
        'DTGrid = KontrolSiswa.tampilDataSsiswa(cmbKelas.SelectedItem, cmbAngkatan.SelectedItem).ToTable
        'LVCari.Items.Clear()
        'Dim stritem() As String
        'If DTGrid.Rows.Count > 0 Then
        '    For i = 0 To DTGrid.Rows.Count - 1
        '        stritem(0) = DTGrid.Rows(i).Item(0).ToString
        '        stritem(1) = DTGrid.Rows(i).Item(1).ToString
        '        stritem(2) = DTGrid.Rows(i).Item(2).ToString
        '        stritem(3) = DTGrid.Rows(i).Item(3).ToString
        '        stritem(4) = DTGrid.Rows(i).Item(4).ToString
        '        stritem(5) = DTGrid.Rows(i).Item(5).ToString
        '        stritem(6) = DTGrid.Rows(i).Item(6).ToString
        '        stritem(7) = DTGrid.Rows(i).Item(7).ToString
        '        stritem(8) = DTGrid.Rows(i).Item(8).ToString
        '    Next
        '    LVCari.Items.Add(New ListViewItem(stritem))
        'Else
        '    MsgBox("Maaf Data Tidak Ditemukan")
        'End If
        'DGSiswa.DataSource = DTGrid

        'If DTGrid.Rows.Count > 0 Then
        '    baris = DTGrid.Rows.Count - 1
        '    DGSiswa.Rows(DTGrid.Rows.Count - 1).Selected = True
        '    DGSiswa.CurrentCell = DGSiswa.Item(1, baris)
        'End If
    End Sub

    Sub ComboAngkatan()
        CMD = New OleDbCommand("select id_angkatan from angkatan ", OPENCONNECTION)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmbAngkatan.Items.Add(DTR.Item(0))
        Loop
        CMD.Dispose()
        DTR.Close()
        CMD = New OleDbCommand("", CLOSECONNECTION)
    End Sub

    Private Sub FormKelasIpa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.Enabled = True
        btnSiswa.Enabled = True
        btnPembayaran.Enabled = True
        btnSms.Enabled = True
        btnAkun.Enabled = True
        btnKeluar.Enabled = True
        Call ComboAngkatan()
        Call TabelCari()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolSiswa.tampilDataSsiswa(cmbKelas.SelectedItem, cmbAngkatan.SelectedItem).ToTable
        LVCari.Items.Clear()
        Dim stritem() As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
                stritem(3) = DTGrid.Rows(i).Item(3).ToString
                stritem(4) = DTGrid.Rows(i).Item(4).ToString
                stritem(5) = DTGrid.Rows(i).Item(5).ToString
                stritem(6) = DTGrid.Rows(i).Item(6).ToString
                stritem(7) = DTGrid.Rows(i).Item(7).ToString
                stritem(8) = DTGrid.Rows(i).Item(8).ToString
            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FormDashboard.Show()
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        FormPilihJurusan.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Public Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormInputSiswa.Show()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        modeProses = 2

    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        FormPembayaran.Show()
    End Sub
End Class