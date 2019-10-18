<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSMSKonfirmasi
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
        Me.txtTujuan = New System.Windows.Forms.TextBox()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.txtApikeys = New System.Windows.Forms.TextBox()
        Me.btnKirim = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTujuan
        '
        Me.txtTujuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTujuan.Location = New System.Drawing.Point(118, 268)
        Me.txtTujuan.Name = "txtTujuan"
        Me.txtTujuan.Size = New System.Drawing.Size(232, 13)
        Me.txtTujuan.TabIndex = 2
        '
        'txtPesan
        '
        Me.txtPesan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesan.Location = New System.Drawing.Point(118, 337)
        Me.txtPesan.Multiline = True
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPesan.Size = New System.Drawing.Size(236, 120)
        Me.txtPesan.TabIndex = 3
        '
        'txtApikeys
        '
        Me.txtApikeys.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApikeys.Location = New System.Drawing.Point(122, 131)
        Me.txtApikeys.Name = "txtApikeys"
        Me.txtApikeys.Size = New System.Drawing.Size(232, 13)
        Me.txtApikeys.TabIndex = 5
        '
        'btnKirim
        '
        Me.btnKirim.BackColor = System.Drawing.Color.Transparent
        Me.btnKirim.BackgroundImage = Global.TugasProyek.My.Resources.Resources.btnKirim
        Me.btnKirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKirim.Location = New System.Drawing.Point(314, 490)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(104, 32)
        Me.btnKirim.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(122, 193)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(232, 13)
        Me.txtNama.TabIndex = 7
        '
        'FormSMSKonfirmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormSMSKonfirmasi
        Me.ClientSize = New System.Drawing.Size(499, 576)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnKirim)
        Me.Controls.Add(Me.txtApikeys)
        Me.Controls.Add(Me.txtPesan)
        Me.Controls.Add(Me.txtTujuan)
        Me.Name = "FormSMSKonfirmasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents txtPesan As TextBox
    Friend WithEvents txtApikeys As TextBox
    Friend WithEvents btnKirim As Panel
    Friend WithEvents txtNama As TextBox
End Class
