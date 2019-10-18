Imports System.Data.OleDb
Public Class FormInputKelas
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolKelas.tampilData.ToTable
        DGKelas.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKelas.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKelas.CurrentCell = DGKelas.Item(1, baris)
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
            With DGKelas.Rows(br)
                txtKdKelas.Text = .Cells(0).Value.ToString
                txtNamaKelas.Text = .Cells(1).Value.ToString
                txtJurusan.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtKdKelas.Text = ""
        txtNamaKelas.Text = ""
        txtJurusan.Text = ""

        txtKdKelas.Text = KontrolKelas.kodeBaru()

        txtNamaKelas.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaKelas.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKelas
            .IdKelas = txtKdKelas.Text
            .Kelas = txtNamaKelas.Text
            .Jurusan = txtJurusan.Text


        End With
        If modeProses = 1 Then
            KontrolKelas.InsertData(EntitasKelas)
        ElseIf modeProses = 2 Then
            KontrolKelas.UpdateData(EntitasKelas)
        End If
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status As Boolean
        status = KontrolKelas.cekKelas(txtKdKelas.Text)
        If status Then
            MsgBox("Data Masih Digunakan, Tidak boleh Dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If
        If MsgBox("Apakah anda yakin akan menghapus " & txtNamaKelas.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolKelas.DeleteData(txtKdKelas.Text)
        End If
    End Sub
    Private Sub DGKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKelas.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKelas.Rows(baris).Selected = True
            IsiBox(baris)
        End If
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
    Private Sub FormInputKelas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshGrid()
        Call ComboAngkatan()
        txtKdKelas.Enabled = False
    End Sub

    Private Sub btnDashoboard_Click(sender As Object, e As EventArgs) Handles btnDashoboard.Click
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
End Class