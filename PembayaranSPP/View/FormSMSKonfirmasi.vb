Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text

Public Class FormSMSKonfirmasi
    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim apiKeys = txtApikeys.Text
        Dim pesan = txtPesan.Text
        Dim penerima = txtTujuan.Text
        Dim strPost As String
        Dim pengirim = "Smansapala"
        Dim url As String = "https://api.txtlocal.com/send/?"

        strPost = url + "apikey=" + apiKeys _
            + "&numbers=" + penerima _
            + "&message=" + WebUtility.UrlEncode(pesan) _
            + "&sender=" + pengirim

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strPost)
        MessageBox.Show(result, "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub FormSMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtApikeys.Text = "Bdiq+S1zsXQ-TbN3ih4CUZGli8Zs8OViqg9ZNXBRM9"
        txtPesan.Text = "Terimakasih Telah Melakukan Pembayaran"

        txtApikeys.Enabled = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class