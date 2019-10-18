<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
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
        Me.components = New System.ComponentModel.Container()
        Me.btnDashboard = New System.Windows.Forms.Panel()
        Me.btnSiswa = New System.Windows.Forms.Panel()
        Me.btnPembayaran = New System.Windows.Forms.Panel()
        Me.btnSms = New System.Windows.Forms.Panel()
        Me.btnAkun = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Panel()
        Me.btnCari = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.LVPembayaran = New System.Windows.Forms.ListView()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.txtNisn = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKelas = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.txtNoPembayaran = New System.Windows.Forms.TextBox()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.btnKonfirmasi = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTanggal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Dashboard1
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Location = New System.Drawing.Point(18, 111)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(207, 26)
        Me.btnDashboard.TabIndex = 4
        '
        'btnSiswa
        '
        Me.btnSiswa.BackColor = System.Drawing.Color.Transparent
        Me.btnSiswa.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Siswa
        Me.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiswa.Location = New System.Drawing.Point(18, 157)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(207, 36)
        Me.btnSiswa.TabIndex = 5
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackColor = System.Drawing.Color.Transparent
        Me.btnPembayaran.BackgroundImage = Global.TugasProyek.My.Resources.Resources.pembayarann
        Me.btnPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPembayaran.Location = New System.Drawing.Point(18, 203)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(207, 36)
        Me.btnPembayaran.TabIndex = 6
        '
        'btnSms
        '
        Me.btnSms.BackColor = System.Drawing.Color.Transparent
        Me.btnSms.BackgroundImage = Global.TugasProyek.My.Resources.Resources.SMS
        Me.btnSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSms.Location = New System.Drawing.Point(18, 249)
        Me.btnSms.Name = "btnSms"
        Me.btnSms.Size = New System.Drawing.Size(207, 36)
        Me.btnSms.TabIndex = 7
        '
        'btnAkun
        '
        Me.btnAkun.BackColor = System.Drawing.Color.Transparent
        Me.btnAkun.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Akun
        Me.btnAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAkun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAkun.Location = New System.Drawing.Point(18, 294)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(207, 36)
        Me.btnAkun.TabIndex = 8
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Keluar
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.Location = New System.Drawing.Point(18, 340)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(207, 36)
        Me.btnKeluar.TabIndex = 9
        '
        'btnCari
        '
        Me.btnCari.BackgroundImage = Global.TugasProyek.My.Resources.Resources.search_listing
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.Location = New System.Drawing.Point(612, 201)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(48, 37)
        Me.btnCari.TabIndex = 5
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Tambahh
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Location = New System.Drawing.Point(698, 321)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(88, 31)
        Me.btnTambah.TabIndex = 6
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.Transparent
        Me.btnUbah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Ubahh
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.Location = New System.Drawing.Point(828, 322)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(88, 31)
        Me.btnUbah.TabIndex = 7
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.BackgroundImage = Global.TugasProyek.My.Resources.Resources.hapuss
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Location = New System.Drawing.Point(955, 321)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(88, 31)
        Me.btnHapus.TabIndex = 7
        '
        'LVPembayaran
        '
        Me.LVPembayaran.Location = New System.Drawing.Point(258, 453)
        Me.LVPembayaran.Name = "LVPembayaran"
        Me.LVPembayaran.Size = New System.Drawing.Size(787, 233)
        Me.LVPembayaran.TabIndex = 10
        Me.LVPembayaran.UseCompatibleStateImageBehavior = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Transparent
        Me.btnBatal.BackgroundImage = Global.TugasProyek.My.Resources.Resources.batal
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.Location = New System.Drawing.Point(903, 382)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(88, 31)
        Me.btnBatal.TabIndex = 9
        '
        'txtNisn
        '
        Me.txtNisn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNisn.Location = New System.Drawing.Point(274, 210)
        Me.txtNisn.Name = "txtNisn"
        Me.txtNisn.Size = New System.Drawing.Size(312, 13)
        Me.txtNisn.TabIndex = 12
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(274, 274)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(312, 13)
        Me.txtNama.TabIndex = 13
        '
        'txtKelas
        '
        Me.txtKelas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKelas.Location = New System.Drawing.Point(274, 335)
        Me.txtKelas.Name = "txtKelas"
        Me.txtKelas.Size = New System.Drawing.Size(312, 13)
        Me.txtKelas.TabIndex = 14
        '
        'txtBiaya
        '
        Me.txtBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBiaya.Location = New System.Drawing.Point(274, 401)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(312, 13)
        Me.txtBiaya.TabIndex = 15
        '
        'txtNoPembayaran
        '
        Me.txtNoPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoPembayaran.Location = New System.Drawing.Point(715, 213)
        Me.txtNoPembayaran.Name = "txtNoPembayaran"
        Me.txtNoPembayaran.Size = New System.Drawing.Size(312, 13)
        Me.txtNoPembayaran.TabIndex = 16
        '
        'cmbBulan
        '
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Location = New System.Drawing.Point(715, 274)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(312, 21)
        Me.cmbBulan.TabIndex = 17
        '
        'btnKonfirmasi
        '
        Me.btnKonfirmasi.BackColor = System.Drawing.Color.Transparent
        Me.btnKonfirmasi.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnkonfir
        Me.btnKonfirmasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKonfirmasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonfirmasi.Location = New System.Drawing.Point(764, 383)
        Me.btnKonfirmasi.Name = "btnKonfirmasi"
        Me.btnKonfirmasi.Size = New System.Drawing.Size(88, 31)
        Me.btnKonfirmasi.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtTanggal
        '
        Me.txtTanggal.AutoSize = True
        Me.txtTanggal.BackColor = System.Drawing.Color.Transparent
        Me.txtTanggal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTanggal.Location = New System.Drawing.Point(909, 61)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(39, 13)
        Me.txtTanggal.TabIndex = 18
        Me.txtTanggal.Text = "Label1"
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormPembayaran11
        Me.ClientSize = New System.Drawing.Size(1105, 736)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.btnKonfirmasi)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.txtNoPembayaran)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtKelas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNisn)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.LVPembayaran)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnAkun)
        Me.Controls.Add(Me.btnSms)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.btnSiswa)
        Me.Controls.Add(Me.btnDashboard)
        Me.Name = "FormPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembayaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDashboard As Panel
    Friend WithEvents btnSiswa As Panel
    Friend WithEvents btnPembayaran As Panel
    Friend WithEvents btnSms As Panel
    Friend WithEvents btnAkun As Panel
    Friend WithEvents btnKeluar As Panel
    Friend WithEvents btnCari As Panel
    Friend WithEvents btnTambah As Panel
    Friend WithEvents btnUbah As Panel
    Friend WithEvents btnHapus As Panel
    Friend WithEvents LVPembayaran As ListView
    Friend WithEvents btnBatal As Panel
    Friend WithEvents txtNisn As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents txtNoPembayaran As TextBox
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents btnKonfirmasi As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtTanggal As Label
End Class
