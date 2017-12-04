<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpananVMG
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvSimpanan = New System.Windows.Forms.DataGridView()
        Me.Bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simpanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pinjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angsuran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendapatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simpanan_VMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TahunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.DgvSimpanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvSimpanan
        '
        Me.DgvSimpanan.AllowUserToAddRows = False
        Me.DgvSimpanan.AllowUserToDeleteRows = False
        Me.DgvSimpanan.AllowUserToResizeColumns = False
        Me.DgvSimpanan.AllowUserToResizeRows = False
        Me.DgvSimpanan.BackgroundColor = System.Drawing.Color.White
        Me.DgvSimpanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSimpanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DgvSimpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSimpanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bulan, Me.Simpanan, Me.Pinjaman, Me.Angsuran, Me.Pendapatan, Me.Saldo, Me.Simpanan_VMG, Me.SHU})
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSimpanan.DefaultCellStyle = DataGridViewCellStyle40
        Me.DgvSimpanan.GridColor = System.Drawing.Color.Black
        Me.DgvSimpanan.Location = New System.Drawing.Point(22, 81)
        Me.DgvSimpanan.Name = "DgvSimpanan"
        Me.DgvSimpanan.ReadOnly = True
        Me.DgvSimpanan.RowHeadersVisible = False
        Me.DgvSimpanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvSimpanan.Size = New System.Drawing.Size(914, 347)
        Me.DgvSimpanan.TabIndex = 0
        '
        'Bulan
        '
        Me.Bulan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Bulan.DefaultCellStyle = DataGridViewCellStyle32
        Me.Bulan.HeaderText = "Bulan"
        Me.Bulan.Name = "Bulan"
        Me.Bulan.ReadOnly = True
        '
        'Simpanan
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "N0"
        Me.Simpanan.DefaultCellStyle = DataGridViewCellStyle33
        Me.Simpanan.HeaderText = "Simpanan"
        Me.Simpanan.Name = "Simpanan"
        Me.Simpanan.ReadOnly = True
        '
        'Pinjaman
        '
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N0"
        Me.Pinjaman.DefaultCellStyle = DataGridViewCellStyle34
        Me.Pinjaman.HeaderText = "Pinjaman"
        Me.Pinjaman.Name = "Pinjaman"
        Me.Pinjaman.ReadOnly = True
        '
        'Angsuran
        '
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "N0"
        Me.Angsuran.DefaultCellStyle = DataGridViewCellStyle35
        Me.Angsuran.HeaderText = "Angsuran"
        Me.Angsuran.Name = "Angsuran"
        Me.Angsuran.ReadOnly = True
        '
        'Pendapatan
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N0"
        Me.Pendapatan.DefaultCellStyle = DataGridViewCellStyle36
        Me.Pendapatan.HeaderText = "Pend Bunga"
        Me.Pendapatan.Name = "Pendapatan"
        Me.Pendapatan.ReadOnly = True
        '
        'Saldo
        '
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle37.Format = "N0"
        DataGridViewCellStyle37.NullValue = Nothing
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle37
        Me.Saldo.HeaderText = "Saldo Kas Koperasi Periode Berjalan"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Simpanan_VMG
        '
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N0"
        Me.Simpanan_VMG.DefaultCellStyle = DataGridViewCellStyle38
        Me.Simpanan_VMG.HeaderText = "Hutang VMG"
        Me.Simpanan_VMG.Name = "Simpanan_VMG"
        Me.Simpanan_VMG.ReadOnly = True
        '
        'SHU
        '
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N0"
        Me.SHU.DefaultCellStyle = DataGridViewCellStyle39
        Me.SHU.HeaderText = "Saldo Kas Akhir"
        Me.SHU.Name = "SHU"
        Me.SHU.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(914, 75)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ALUR KAS KOPERASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 533)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(910, 61)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(914, 101)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TahunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(958, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'TahunToolStripMenuItem
        '
        Me.TahunToolStripMenuItem.Name = "TahunToolStripMenuItem"
        Me.TahunToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.TahunToolStripMenuItem.Text = "Tahun"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "2015"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "2016"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Detail :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KoperasiVM.My.Resources.Resources.LOGO_VMG_VERTICAL_KOP_
        Me.PictureBox1.Location = New System.Drawing.Point(176, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(737, 141)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(197, 316)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.Visible = False
        '
        'SimpananVMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 611)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvSimpanan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SimpananVMG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " .:::: Laporan Arus Kas"
        CType(Me.DgvSimpanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvSimpanan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Bulan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simpanan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pinjaman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Angsuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pendapatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simpanan_VMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TahunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
