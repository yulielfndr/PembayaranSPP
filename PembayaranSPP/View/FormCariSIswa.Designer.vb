<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariSIswa
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
        Me.LVCari = New System.Windows.Forms.ListView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LVCari
        '
        Me.LVCari.Location = New System.Drawing.Point(12, 230)
        Me.LVCari.Name = "LVCari"
        Me.LVCari.Size = New System.Drawing.Size(486, 293)
        Me.LVCari.TabIndex = 1
        Me.LVCari.UseCompatibleStateImageBehavior = False
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCari.Location = New System.Drawing.Point(130, 113)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(222, 13)
        Me.txtCari.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.TugasProyek.My.Resources.Resources.search_listing
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(380, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 37)
        Me.Button1.TabIndex = 6
        '
        'FormCariSIswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasProyek.My.Resources.Resources.FormCari2
        Me.ClientSize = New System.Drawing.Size(510, 535)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.LVCari)
        Me.Name = "FormCariSIswa"
        Me.Text = "FormCariSIswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVCari As ListView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Button1 As Panel
End Class
