Imports TugasProyek.FormDataSiswa
Public Class FormInputSiswa
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With FormDataSiswa
            '.LVCari.Items.Add(0).SubItems(0).Text = txtNisn.Text
            '.LVCari.Items.Add(0).SubItems(1).Text = txtNama.Text
            '.LVCari.Items.Add(0).SubItems(2).Text = cmbJenisKelamin.Text
            '.LVCari.Items.Add(0).SubItems(3).Text = txtAlamat.Text
            '.LVCari.Items.Add(0).SubItems(4).Text = txtNamaOrtu.Text
            '.LVCari.Items.Add(0).SubItems(5).Text = txtAlamatOrtu.Text
            '.LVCari.Items.Add(0).SubItems(6).Text = txtTelpOrtu.Text
            '.LVCari.Items.Add(0).SubItems(7).Text = txtKelas.Text
            '.LVCari.Items.Add(0).SubItems(8).Text = txtAngkatan.Text

            Dim strSiswa(8) As String
            Dim isi As ListViewItem

            'strSiswa(0) = txtNisn.Text
            'strSiswa(1) = txtNama.Text
            'strSiswa(2) = cmbJenisKelamin.Text
            'strSiswa(3) = txtAlamat.Text
            'strSiswa(4) = txtNamaOrtu.Text
            'strSiswa(5) = txtAlamatOrtu.Text
            'strSiswa(6) = txtTelpOrtu.Text
            'strSiswa(7) = txtKelas.Text
            'strSiswa(8) = txtAngkatan.Text

            'isi = New ListViewItem
            'isi = LVCari.Items.add(strSiswa(0))
            'isi.SubItems.Add(strSiswa(1))
            'isi.SubItems.Add(strSiswa(2))
            'isi.SubItems.Add(strSiswa(3))
            'isi.SubItems.Add(strSiswa(4))
            'isi.SubItems.Add(strSiswa(5))
            'isi.SubItems.Add(strSiswa(6))
            'isi.SubItems.Add(strSiswa(7))
            'isi.SubItems.Add(strSiswa(8))

            'LVCari.Items.Add(isi)

            'Me.Close()
        End With
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        FormPilihJurusan.Show()
        Me.Close()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        FormPembayaran.Show()
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FormInputSiswa_Click(sender As Object, e As EventArgs) Handles Me.Click
        With FormDataSiswa
            .cmbKelas.Text = txtKelas.Text
            .cmbAngkatan.Text = txtAngkatan.Text
        End With
        txtKelas.Enabled = False
        txtAngkatan.Enabled = False
    End Sub
End Class