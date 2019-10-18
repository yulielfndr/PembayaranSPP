<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Dashboard
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Location = New System.Drawing.Point(18, 111)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(207, 24)
        Me.btnDashboard.TabIndex = 0
        '
        'btnSiswa
        '
        Me.btnSiswa.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Siswa
        Me.btnSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiswa.Location = New System.Drawing.Point(18, 157)
        Me.btnSiswa.Name = "btnSiswa"
        Me.btnSiswa.Size = New System.Drawing.Size(207, 28)
        Me.btnSiswa.TabIndex = 1
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Pembayaran
        Me.btnPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPembayaran.Location = New System.Drawing.Point(18, 202)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(207, 35)
        Me.btnPembayaran.TabIndex = 2
        '
        'btnSMS
        '
        Me.btnSMS.BackgroundImage = Global.TugasProyek.My.Resources.Resources.SMS
        Me.btnSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMS.Location = New System.Drawing.Point(18, 249)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(207, 35)
        Me.btnSMS.TabIndex = 3
        '
        'btnAkun
        '
        Me.btnAkun.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Akun
        Me.btnAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAkun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAkun.Location = New System.Drawing.Point(18, 294)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(207, 35)
        Me.btnAkun.TabIndex = 4
        '
        'btnKeluar
        '
        Me.btnKeluar.BackgroundImage = Global.TugasProyek.My.Resources.Resources.Keluar
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.Location = New System.Drawing.Point(18, 340)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(207, 35)
        Me.btnKeluar.TabIndex = 5
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormDashboard
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1105, 736)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnAkun)
        Me.Controls.Add(Me.btnSMS)
        Me.Controls.Add(Me.btnPembayaran)
        Me.Controls.Add(Me.btnSiswa)
        Me.Controls.Add(Me.btnDashboard)
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDashboard As Panel
    Friend WithEvents btnSiswa As Panel
    Friend WithEvents btnPembayaran As Panel
    Friend WithEvents btnSMS As Panel
    Friend WithEvents btnAkun As Panel
    Friend WithEvents btnKeluar As Panel
End Class
