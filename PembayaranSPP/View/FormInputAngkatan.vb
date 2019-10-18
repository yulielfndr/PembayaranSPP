Public Class FormInputAngkatan
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolAngkatan.tampilData.ToTable
        DGAngkatan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGAngkatan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGAngkatan.CurrentCell = DGAngkatan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGAngkatan.Rows(br)
                txtKdAngkatan.Text = .Cells(0).Value.ToString
                txtAngkatan.Text = .Cells(1).Value.ToString
                txtBSpp.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtAngkatan.Text = ""
        txtBSpp.Text = ""

        txtKdAngkatan.Text = KontrolAngkatan.kodeBaru()

        txtAngkatan.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtAngkatan.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasAngkatan
            .KodeAngktn = txtKdAngkatan.Text
            .Angktn = txtAngkatan.Text
            .bSpp = txtBSpp.Text

        End With
        If modeProses = 1 Then
            KontrolAngkatan.InsertData(EntitasAngkatan)
        ElseIf modeProses = 2 Then
            KontrolAngkatan.UpdateData(EntitasAngkatan)
        End If
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status As Boolean
        status = KontrolAngkatan.cekAngkatan(txtKdAngkatan.Text)
        If status Then
            MsgBox("Data Masih Digunakan, Tidak boleh Dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If
        If MsgBox("Apakah anda yakin akan menghapus " & txtAngkatan.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolAngkatan.DeleteData(txtKdAngkatan.Text)
        End If
    End Sub

    Private Sub DGAngkatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAngkatan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGAngkatan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
    Private Sub FormInputAngkatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshGrid()
        txtKdAngkatan.Enabled = False
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

    Private Sub btnSMS_Click(sender As Object, e As EventArgs) Handles btnSMS.Click
        'formsms.show()
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class