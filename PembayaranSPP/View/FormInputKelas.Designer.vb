<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputKelas
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
        Me.btnDashoboard = New System.Windows.Forms.Panel()
        Me.btnSiswa = New System.Windows.Forms.Panel()
        Me.btnPembayaran = New System.Windows.Forms.Panel()
        Me.btnSMS = New System.Windows.Forms.Panel()
        Me.btnAkun = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.DGKelas = New System.Windows.Forms.DataGridView()
        Me.txtKdKelas = New System.Windows.Forms.TextBox()
        Me.txtNamaKelas = New System.Windows.Forms.TextBox()
        Me.txtJurusan = New System.Windows.Forms.TextBox()
        Me.cmbAngkatan = New System.Windows.Forms.ComboBox()
        CType(Me.DGKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDashoboard
        '
        Me.btnDashoboard.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Dashboard1
        Me.btnDashoboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashoboard.Location = New System.Drawing.Point(18, 127)
        Me.btnDashoboard.Name = "btnDashoboard"
        Me.btnDashoboard.Size = New System.Drawing.Size(207, 36)
        Me.btnDashoboard.TabIndex = 2
        '
        'btnSiswa
        '
        Me.btnSiswa.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Siswa1
        Me.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiswa.Location = New System.Drawing.Point(18, 172)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(207, 36)
        Me.btnSiswa.TabIndex = 3
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Pembayaran1
        Me.btnPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPembayaran.Location = New System.Drawing.Point(18, 216)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(207, 36)
        Me.btnPembayaran.TabIndex = 4
        '
        'btnSMS
        '
        Me.btnSMS.BackgroundImage = Global.TugasProyek.My.Resources.Resources.SMS
        Me.btnSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSMS.Location = New System.Drawing.Point(18, 263)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(207, 36)
        Me.btnSMS.TabIndex = 5
        '
        'btnAkun
        '
        Me.btnAkun.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Akun
        Me.btnAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAkun.Location = New System.Drawing.Point(18, 309)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(207, 36)
        Me.btnAkun.TabIndex = 6
        '
        'btnKeluar
        '
        Me.btnKeluar.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Keluar
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKeluar.Location = New System.Drawing.Point(18, 355)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(207, 36)
        Me.btnKeluar.TabIndex = 7
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnTambah
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTambah.Location = New System.Drawing.Point(254, 303)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(129, 31)
        Me.btnTambah.TabIndex = 8
        '
        'btnUbah
        '
        Me.btnUbah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnUbah
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUbah.Location = New System.Drawing.Point(419, 303)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(129, 31)
        Me.btnUbah.TabIndex = 9
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnHapus
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Location = New System.Drawing.Point(590, 303)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(129, 31)
        Me.btnHapus.TabIndex = 10
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnSimpan
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSimpan.Location = New System.Drawing.Point(759, 303)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(129, 31)
        Me.btnSimpan.TabIndex = 11
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnBatal
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBatal.Location = New System.Drawing.Point(924, 303)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(129, 31)
        Me.btnBatal.TabIndex = 9
        '
        'DGKelas
        '
        Me.DGKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKelas.Location = New System.Drawing.Point(254, 367)
        Me.DGKelas.Name = "DGKelas"
        Me.DGKelas.Size = New System.Drawing.Size(799, 319)
        Me.DGKelas.TabIndex = 12
        '
        'txtKdKelas
        '
        Me.txtKdKelas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdKelas.Location = New System.Drawing.Point(422, 215)
        Me.txtKdKelas.Name = "txtKdKelas"
        Me.txtKdKelas.Size = New System.Drawing.Size(186, 13)
        Me.txtKdKelas.TabIndex = 13
        '
        'txtNamaKelas
        '
        Me.txtNamaKelas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaKelas.Location = New System.Drawing.Point(422, 255)
        Me.txtNamaKelas.Name = "txtNamaKelas"
        Me.txtNamaKelas.Size = New System.Drawing.Size(186, 13)
        Me.txtNamaKelas.TabIndex = 14
        '
        'txtJurusan
        '
        Me.txtJurusan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJurusan.Location = New System.Drawing.Point(848, 216)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(186, 13)
        Me.txtJurusan.TabIndex = 15
        '
        'cmbAngkatan
        '
        Me.cmbAngkatan.FormattingEnabled = True
        Me.cmbAngkatan.Location = New System.Drawing.Point(842, 250)
        Me.cmbAngkatan.Name = "cmbAngkatan"
        Me.cmbAngkatan.Size = New System.Drawing.Size(192, 21)
        Me.cmbAngkatan.TabIndex = 16
        '
        'FormInputKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormKelas
        Me.ClientSize = New System.Drawing.Size(1105, 736)
        Me.Controls.Add(Me.cmbAngkatan)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.txtNamaKelas)
        Me.Controls.Add(Me.txtKdKelas)
        Me.Controls.Add(Me.DGKelas)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnAkun)
        Me.Controls.Add(Me.btnSMS)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.btnSiswa)
        Me.Controls.Add(Me.btnDashoboard)
        Me.Name = "FormInputKelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInputKelas"
        CType(Me.DGKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDashoboard As Panel
    Friend WithEvents btnSiswa As Panel
    Friend WithEvents btnPembayaran As Panel
    Friend WithEvents btnSMS As Panel
    Friend WithEvents btnAkun As Panel
    Friend WithEvents btnKeluar As Panel
    Friend WithEvents btnTambah As Panel
    Friend WithEvents btnUbah As Panel
    Friend WithEvents btnHapus As Panel
    Friend WithEvents btnSimpan As Panel
    Friend WithEvents btnBatal As Panel
    Friend WithEvents DGKelas As DataGridView
    Friend WithEvents txtKdKelas As TextBox
    Friend WithEvents txtNamaKelas As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents cmbAngkatan As ComboBox
End Class
