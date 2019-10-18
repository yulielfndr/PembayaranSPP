Public Class FormCariSIswa
    Sub TabelCari()
        LVCari.Columns.Add("NISN", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Nama", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("No.Telp Ortu", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("Kelas", 100, HorizontalAlignment.Center)
        LVCari.Columns.Add("SPP", 100, HorizontalAlignment.Center)

        LVCari.View = View.Details
        LVCari.GridLines = True
        LVCari.FullRowSelect = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DTGrid = KontrolSiswa.cariData(txtCari.Text).ToTable
        LVCari.Items.Clear()
        Dim stritem(4) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
                stritem(3) = DTGrid.Rows(i).Item(3).ToString
                stritem(4) = DTGrid.Rows(i).Item(4).ToString
            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub FormCariSIswa_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCari.Focus()
        Call TabelCari()
    End Sub

    Private Sub LVCari_DoubleClick(sender As Object, e As EventArgs) Handles LVCari.DoubleClick
        With FormPembayaran
            .txtNisn.Text = LVCari.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LVCari.SelectedItems(0).SubItems(1).Text
            .txtKelas.Text = LVCari.SelectedItems(0).SubItems(3).Text
            .txtBiaya.Text = LVCari.SelectedItems(0).SubItems(4).Text
            Me.Close()
        End With

        With FormSMSKonfirmasi
            .txtNama.Text = LVCari.SelectedItems(0).SubItems(1).Text
            .txttujuan.Text = LVCari.SelectedItems(0).SubItems(2).Text
        End With
    End Sub

End Class