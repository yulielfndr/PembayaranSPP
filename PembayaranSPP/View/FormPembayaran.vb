Public Class FormPembayaran


    Sub TabelViewPembayaran()
        LVPembayaran.Columns.Add("NoPembayaran", 100, HorizontalAlignment.Center)
        LVPembayaran.Columns.Add("NISN", 100, HorizontalAlignment.Center)
        LVPembayaran.Columns.Add("Bulan", 100, HorizontalAlignment.Center)
        LVPembayaran.Columns.Add("Biaya", 100, HorizontalAlignment.Center)
        LVPembayaran.Columns.Add("Tanggal", 100, HorizontalAlignment.Center)

        LVPembayaran.View = View.Details
        LVPembayaran.GridLines = True
        LVPembayaran.FullRowSelect = True
    End Sub

    Sub IdTransaksi()
        CMD = New OleDb.OleDbCommand("Select * from pembayaran where idpembayaran in(select max(idpembayaran) order by idpembayarani desc", OPENCONNECTION)
        DTR = CMD.ExecuteReader

        If Not DTR.HasRows Then
            txtNoPembayaran.Text = Format(Now, "yyMMdd" + "01")
        Else
            If Microsoft.VisualBasic.Left(DTR.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                txtNoPembayaran.Text = DTR.GetString(0) + 1
            End If

        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FormCariSIswa.Show()
    End Sub

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TabelViewPembayaran()
        cmbBulan.Items.Add("Januari")
        cmbBulan.Items.Add("Februari")
        cmbBulan.Items.Add("Maret")
        cmbBulan.Items.Add("April")
        cmbBulan.Items.Add("Mei")
        cmbBulan.Items.Add("Juni")
        cmbBulan.Items.Add("Juli")
        cmbBulan.Items.Add("Agustus")
        cmbBulan.Items.Add("September")
        cmbBulan.Items.Add("Oktober")
        cmbBulan.Items.Add("November")
        cmbBulan.Items.Add("Desember")

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strSiswa(4) As String

        strSiswa(0) = txtNoPembayaran.Text
        strSiswa(1) = txtNisn.Text
        strSiswa(2) = cmbBulan.Text
        strSiswa(3) = txtBiaya.Text
        strSiswa(4) = txtTanggal.Text

        LVPembayaran.Items.Add(New ListViewItem(strSiswa))
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPembayaran.SelectedItems(0).Remove()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnSiswa_Click(sender As Object, e As EventArgs) Handles btnSiswa.Click
        FormPilihJurusan.Show()
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        FormSMSKonfirmasi.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim namaHari As String()
        Dim bulan As String()
        namaHari = New String() {"MINGGU", "SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU"}
        bulan = New String() {"", "JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}
        txtTanggal.Text = namaHari(Now.DayOfWeek) & ", " & Format(Now, "dd" & bulan(Month(Now)) & "yyyy hh:mm:ss")
    End Sub
End Class