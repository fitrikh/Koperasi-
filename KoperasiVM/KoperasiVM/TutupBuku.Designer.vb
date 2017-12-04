<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutupBuku
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
        Me.cmb_bulan = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmb_bulan
        '
        Me.cmb_bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bulan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bulan.FormattingEnabled = True
        Me.cmb_bulan.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"})
        Me.cmb_bulan.Location = New System.Drawing.Point(12, 32)
        Me.cmb_bulan.Name = "cmb_bulan"
        Me.cmb_bulan.Size = New System.Drawing.Size(184, 27)
        Me.cmb_bulan.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "TUTUP BUKU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TutupBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(436, 88)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_bulan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TutupBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Tutup Buku"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
