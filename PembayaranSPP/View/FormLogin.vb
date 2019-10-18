Imports System.Data.OleDb
Public Class FormLogin
    Dim a

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Harap Input ID Karyawan dan Password !")
            Else
                CMD = New OleDbCommand("select * from petugas where username='" _
                               & txtUsername.Text & "' and psswrd='" _
                               & txtPassword.Text & "'", OPENCONNECTION)
                DTR = CMD.ExecuteReader
                DTR.Read()
                If DTR.HasRows Then
                    Me.Hide()
                    FormDashboard.Show()
                Else
                    MsgBox("ID Karyawan atau Password yang Anda Masukkan Salah, Mohon Periksa Kembali")
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Focus()

                    a = a + 1
                    If a >= 3 Then
                        MsgBox("Kesempatan Anda Sudah Habis")
                        Me.Close()
                        FormDashboard.Close()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn()
        a = 0
        txtUsername.Focus()
    End Sub

End Class