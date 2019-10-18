<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputAngkatan
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
        Me.btnSMS = New System.Windows.Forms.Panel()
        Me.btnAkun = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.DGAngkatan = New System.Windows.Forms.DataGridView()
        Me.txtKdAngkatan = New System.Windows.Forms.TextBox()
        Me.txtAngkatan = New System.Windows.Forms.TextBox()
        Me.txtBSpp = New System.Windows.Forms.TextBox()
        CType(Me.DGAngkatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Dashboard1
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Location = New System.Drawing.Point(18, 125)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(207, 36)
        Me.btnDashboard.TabIndex = 3
        '
        'btnSiswa
        '
        Me.btnSiswa.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Siswa1
        Me.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiswa.Location = New System.Drawing.Point(18, 171)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(207, 36)
        Me.btnSiswa.TabIndex = 4
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Pembayaran1
        Me.btnPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPembayaran.Location = New System.Drawing.Point(18, 217)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(207, 36)
        Me.btnPembayaran.TabIndex = 5
        '
        'btnSMS
        '
        Me.btnSMS.BackgroundImage = Global.TugasProyek.My.Resources.Resources.SMS
        Me.btnSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSMS.Location = New System.Drawing.Point(18, 263)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(207, 36)
        Me.btnSMS.TabIndex = 6
        '
        'btnAkun
        '
        Me.btnAkun.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Akun
        Me.btnAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAkun.Location = New System.Drawing.Point(18, 310)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(207, 36)
        Me.btnAkun.TabIndex = 7
        '
        'btnKeluar
        '
        Me.btnKeluar.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Keluar
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKeluar.Location = New System.Drawing.Point(18, 356)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(207, 36)
        Me.btnKeluar.TabIndex = 8
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnTambah
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTambah.Location = New System.Drawing.Point(252, 303)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(129, 31)
        Me.btnTambah.TabIndex = 9
        '
        'btnUbah
        '
        Me.btnUbah.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnUbah
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUbah.Location = New System.Drawing.Point(419, 303)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(129, 31)
        Me.btnUbah.TabIndex = 10
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnHapus
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Location = New System.Drawing.Point(591, 303)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(129, 31)
        Me.btnHapus.TabIndex = 11
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnSimpan
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSimpan.Location = New System.Drawing.Point(761, 303)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(129, 31)
        Me.btnSimpan.TabIndex = 12
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnBatal
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBatal.Location = New System.Drawing.Point(925, 303)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(129, 31)
        Me.btnBatal.TabIndex = 10
        '
        'DGAngkatan
        '
        Me.DGAngkatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAngkatan.Location = New System.Drawing.Point(252, 365)
        Me.DGAngkatan.Name = "DGAngkatan"
        Me.DGAngkatan.Size = New System.Drawing.Size(802, 332)
        Me.DGAngkatan.TabIndex = 13
        '
        'txtKdAngkatan
        '
        Me.txtKdAngkatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdAngkatan.Location = New System.Drawing.Point(419, 217)
        Me.txtKdAngkatan.Name = "txtKdAngkatan"
        Me.txtKdAngkatan.Size = New System.Drawing.Size(186, 13)
        Me.txtKdAngkatan.TabIndex = 14
        '
        'txtAngkatan
        '
        Me.txtAngkatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAngkatan.Location = New System.Drawing.Point(421, 254)
        Me.txtAngkatan.Name = "txtAngkatan"
        Me.txtAngkatan.Size = New System.Drawing.Size(186, 13)
        Me.txtAngkatan.TabIndex = 15
        '
        'txtBSpp
        '
        Me.txtBSpp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBSpp.Location = New System.Drawing.Point(846, 217)
        Me.txtBSpp.Name = "txtBSpp"
        Me.txtBSpp.Size = New System.Drawing.Size(186, 13)
        Me.txtBSpp.TabIndex = 16
        '
        'FormInputAngkatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormInputAngkatan
        Me.ClientSize = New System.Drawing.Size(1105, 736)
        Me.Controls.Add(Me.txtBSpp)
        Me.Controls.Add(Me.txtAngkatan)
        Me.Controls.Add(Me.txtKdAngkatan)
        Me.Controls.Add(Me.DGAngkatan)
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
        Me.Controls.Add(Me.btnDashboard)
        Me.Name = "FormInputAngkatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInputAngkatan"
        CType(Me.DGAngkatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDashboard As Panel
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
    Friend WithEvents DGAngkatan As DataGridView
    Friend WithEvents txtKdAngkatan As TextBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents txtBSpp As TextBox
End Class
