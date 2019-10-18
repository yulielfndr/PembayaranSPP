<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDashboard = New System.Windows.Forms.Panel()
        Me.btnSiswa = New System.Windows.Forms.Panel()
        Me.btnPembayaran = New System.Windows.Forms.Panel()
        Me.btnSms = New System.Windows.Forms.Panel()
        Me.btnAkun = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Panel()
        Me.cmbAngkatan = New System.Windows.Forms.ComboBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.btnCari = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.LVCari = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Dashboard1
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Location = New System.Drawing.Point(19, 112)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(207, 36)
        Me.btnDashboard.TabIndex = 3
        '
        'btnSiswa
        '
        Me.btnSiswa.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Siswa1
        Me.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiswa.Location = New System.Drawing.Point(18, 156)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(207, 36)
        Me.btnSiswa.TabIndex = 4
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Pembayaran1
        Me.btnPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPembayaran.Location = New System.Drawing.Point(19, 203)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(207, 36)
        Me.btnPembayaran.TabIndex = 5
        '
        'btnSms
        '
        Me.btnSms.BackgroundImage = Global.TugasProyek.My.Resources.Resources.SMS
        Me.btnSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSms.Location = New System.Drawing.Point(18, 249)
        Me.btnSms.Name = "btnSms"
        Me.btnSms.Size = New System.Drawing.Size(207, 36)
        Me.btnSms.TabIndex = 6
        '
        'btnAkun
        '
        Me.btnAkun.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Akun
        Me.btnAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAkun.Location = New System.Drawing.Point(18, 295)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(207, 36)
        Me.btnAkun.TabIndex = 7
        '
        'btnKeluar
        '
        Me.btnKeluar.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Keluar
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKeluar.Location = New System.Drawing.Point(19, 341)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(207, 36)
        Me.btnKeluar.TabIndex = 8
        '
        'cmbAngkatan
        '
        Me.cmbAngkatan.FormattingEnabled = True
        Me.cmbAngkatan.Location = New System.Drawing.Point(641, 220)
        Me.cmbAngkatan.Name = "cmbAngkatan"
        Me.cmbAngkatan.Size = New System.Drawing.Size(259, 21)
        Me.cmbAngkatan.TabIndex = 10
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Location = New System.Drawing.Point(299, 220)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(262, 21)
        Me.cmbKelas.TabIndex = 9
        '
        'btnCari
        '
        Me.btnCari.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnCari
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCari.Location = New System.Drawing.Point(934, 212)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(90, 36)
        Me.btnCari.TabIndex = 7
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnTambah
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTambah.Location = New System.Drawing.Point(934, 275)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(130, 31)
        Me.btnTambah.TabIndex = 8
        '
        'btnUbah
        '
        Me.btnUbah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnUbah
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUbah.Location = New System.Drawing.Point(934, 312)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(130, 31)
        Me.btnUbah.TabIndex = 9
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnHapus
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Location = New System.Drawing.Point(934, 349)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(130, 31)
        Me.btnHapus.TabIndex = 10
        '
        'LVCari
        '
        Me.LVCari.Location = New System.Drawing.Point(257, 275)
        Me.LVCari.Name = "LVCari"
        Me.LVCari.Size = New System.Drawing.Size(654, 422)
        Me.LVCari.TabIndex = 12
        Me.LVCari.UseCompatibleStateImageBehavior = False
        '
        'FormDataSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormDataSiswaT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1105, 736)
        Me.Controls.Add(Me.LVCari)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cmbAngkatan)
        Me.Controls.Add(Me.cmbKelas)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnAkun)
        Me.Controls.Add(Me.btnSms)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.btnSiswa)
        Me.Controls.Add(Me.btnDashboard)
        Me.Name = "FormDataSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelasIpa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDashboard As Panel
    Friend WithEvents btnSiswa As Panel
    Friend WithEvents btnPembayaran As Panel
    Friend WithEvents btnSms As Panel
    Friend WithEvents btnAkun As Panel
    Friend WithEvents btnKeluar As Panel
    Friend WithEvents cmbAngkatan As ComboBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents btnCari As Panel
    Friend WithEvents btnTambah As Panel
    Friend WithEvents btnUbah As Panel
    Friend WithEvents btnHapus As Panel
    Friend WithEvents LVCari As ListView
End Class
