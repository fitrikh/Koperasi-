<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjaman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdPinjam = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Dtm = New System.Windows.Forms.DateTimePicker()
        Me.NumLamaPinjam = New System.Windows.Forms.NumericUpDown()
        Me.NumJmlPinjam = New System.Windows.Forms.NumericUpDown()
        Me.NumBunga = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.NumLamaPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumJmlPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBunga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pinjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tgl Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lama Pinjaman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bunga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Pinjam"
        '
        'TxtIdPinjam
        '
        Me.TxtIdPinjam.Enabled = False
        Me.TxtIdPinjam.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPinjam.Location = New System.Drawing.Point(208, 22)
        Me.TxtIdPinjam.Name = "TxtIdPinjam"
        Me.TxtIdPinjam.Size = New System.Drawing.Size(241, 26)
        Me.TxtIdPinjam.TabIndex = 6
        '
        'TxtNama
        '
        Me.TxtNama.Enabled = False
        Me.TxtNama.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(208, 59)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(363, 26)
        Me.TxtNama.TabIndex = 7
        '
        'Dtm
        '
        Me.Dtm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtm.Location = New System.Drawing.Point(208, 101)
        Me.Dtm.Name = "Dtm"
        Me.Dtm.Size = New System.Drawing.Size(200, 24)
        Me.Dtm.TabIndex = 8
        '
        'NumLamaPinjam
        '
        Me.NumLamaPinjam.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLamaPinjam.Location = New System.Drawing.Point(208, 144)
        Me.NumLamaPinjam.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumLamaPinjam.Name = "NumLamaPinjam"
        Me.NumLamaPinjam.Size = New System.Drawing.Size(74, 26)
        Me.NumLamaPinjam.TabIndex = 9
        '
        'NumJmlPinjam
        '
        Me.NumJmlPinjam.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumJmlPinjam.Location = New System.Drawing.Point(208, 215)
        Me.NumJmlPinjam.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
        Me.NumJmlPinjam.Name = "NumJmlPinjam"
        Me.NumJmlPinjam.Size = New System.Drawing.Size(288, 26)
        Me.NumJmlPinjam.TabIndex = 10
        '
        'NumBunga
        '
        Me.NumBunga.Enabled = False
        Me.NumBunga.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBunga.Location = New System.Drawing.Point(208, 178)
        Me.NumBunga.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumBunga.Name = "NumBunga"
        Me.NumBunga.ReadOnly = True
        Me.NumBunga.Size = New System.Drawing.Size(74, 26)
        Me.NumBunga.TabIndex = 11
        Me.NumBunga.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "%"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(46, 291)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(166, 54)
        Me.BtnSimpan.TabIndex = 13
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(405, 291)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(166, 54)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Pinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 360)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumBunga)
        Me.Controls.Add(Me.NumJmlPinjam)
        Me.Controls.Add(Me.NumLamaPinjam)
        Me.Controls.Add(Me.Dtm)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtIdPinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pinjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pinjaman Anggota"
        CType(Me.NumLamaPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumJmlPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBunga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtIdPinjam As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Dtm As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumLamaPinjam As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumJmlPinjam As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumBunga As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
