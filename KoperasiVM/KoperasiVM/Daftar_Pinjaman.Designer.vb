<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daftar_Pinjaman
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Daftar_Pinjaman))
        Me.DGCDaftar = New System.Windows.Forms.DataGridView()
        Me.idPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglpinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml_angsuran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisaAng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisaAng2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVCALON = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglPengajuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alasan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGCDaftar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCALON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGCDaftar
        '
        Me.DGCDaftar.AllowUserToAddRows = False
        Me.DGCDaftar.AllowUserToDeleteRows = False
        Me.DGCDaftar.AllowUserToResizeColumns = False
        Me.DGCDaftar.AllowUserToResizeRows = False
        Me.DGCDaftar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCDaftar.BackgroundColor = System.Drawing.Color.Green
        Me.DGCDaftar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCDaftar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCDaftar.ColumnHeadersHeight = 35
        Me.DGCDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGCDaftar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPinjam, Me.nama, Me.tglpinjam, Me.jumlahp, Me.lama, Me.jml_angsuran, Me.sisaAng, Me.sisaAng2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCDaftar.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGCDaftar.EnableHeadersVisualStyles = False
        Me.DGCDaftar.GridColor = System.Drawing.Color.Lavender
        Me.DGCDaftar.Location = New System.Drawing.Point(12, 47)
        Me.DGCDaftar.Name = "DGCDaftar"
        Me.DGCDaftar.ReadOnly = True
        Me.DGCDaftar.RowHeadersVisible = False
        Me.DGCDaftar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGCDaftar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCDaftar.Size = New System.Drawing.Size(807, 218)
        Me.DGCDaftar.TabIndex = 0
        '
        'idPinjam
        '
        Me.idPinjam.HeaderText = "id"
        Me.idPinjam.Name = "idPinjam"
        Me.idPinjam.ReadOnly = True
        Me.idPinjam.Visible = False
        '
        'nama
        '
        Me.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'tglpinjam
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.tglpinjam.DefaultCellStyle = DataGridViewCellStyle2
        Me.tglpinjam.HeaderText = "Tgl Pinjam"
        Me.tglpinjam.Name = "tglpinjam"
        Me.tglpinjam.ReadOnly = True
        '
        'jumlahp
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.jumlahp.DefaultCellStyle = DataGridViewCellStyle3
        Me.jumlahp.HeaderText = "Jml Pinjam"
        Me.jumlahp.Name = "jumlahp"
        Me.jumlahp.ReadOnly = True
        '
        'lama
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.lama.DefaultCellStyle = DataGridViewCellStyle4
        Me.lama.HeaderText = "Lama Pinjam"
        Me.lama.Name = "lama"
        Me.lama.ReadOnly = True
        '
        'jml_angsuran
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.jml_angsuran.DefaultCellStyle = DataGridViewCellStyle5
        Me.jml_angsuran.HeaderText = "Jml Angsuran"
        Me.jml_angsuran.Name = "jml_angsuran"
        Me.jml_angsuran.ReadOnly = True
        '
        'sisaAng
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "# kali"
        DataGridViewCellStyle6.NullValue = "0"
        Me.sisaAng.DefaultCellStyle = DataGridViewCellStyle6
        Me.sisaAng.HeaderText = "Sisa Angsuran"
        Me.sisaAng.Name = "sisaAng"
        Me.sisaAng.ReadOnly = True
        '
        'sisaAng2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.sisaAng2.DefaultCellStyle = DataGridViewCellStyle7
        Me.sisaAng2.HeaderText = "Sisa Angsuran"
        Me.sisaAng2.Name = "sisaAng2"
        Me.sisaAng2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(806, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(806, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVCALON
        '
        Me.DGVCALON.AllowUserToAddRows = False
        Me.DGVCALON.AllowUserToDeleteRows = False
        Me.DGVCALON.AllowUserToResizeColumns = False
        Me.DGVCALON.AllowUserToResizeRows = False
        Me.DGVCALON.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCALON.BackgroundColor = System.Drawing.Color.Green
        Me.DGVCALON.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCALON.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVCALON.ColumnHeadersHeight = 35
        Me.DGVCALON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVCALON.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.id2, Me.nama1, Me.tglPengajuan, Me.nom, Me.alasan, Me.statusAcc, Me.status2, Me.tglAcc})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCALON.DefaultCellStyle = DataGridViewCellStyle15
        Me.DGVCALON.EnableHeadersVisualStyles = False
        Me.DGVCALON.GridColor = System.Drawing.Color.Lavender
        Me.DGVCALON.Location = New System.Drawing.Point(8, 326)
        Me.DGVCALON.Name = "DGVCALON"
        Me.DGVCALON.ReadOnly = True
        Me.DGVCALON.RowHeadersVisible = False
        Me.DGVCALON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVCALON.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCALON.Size = New System.Drawing.Size(807, 267)
        Me.DGVCALON.TabIndex = 3
        '
        'id1
        '
        Me.id1.HeaderText = "id1"
        Me.id1.Name = "id1"
        Me.id1.ReadOnly = True
        Me.id1.Visible = False
        '
        'id2
        '
        Me.id2.HeaderText = "id2"
        Me.id2.Name = "id2"
        Me.id2.ReadOnly = True
        Me.id2.Visible = False
        '
        'nama1
        '
        Me.nama1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama1.HeaderText = "Nama"
        Me.nama1.Name = "nama1"
        Me.nama1.ReadOnly = True
        '
        'tglPengajuan
        '
        DataGridViewCellStyle10.Format = "D"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.tglPengajuan.DefaultCellStyle = DataGridViewCellStyle10
        Me.tglPengajuan.HeaderText = "Pengajuan"
        Me.tglPengajuan.Name = "tglPengajuan"
        Me.tglPengajuan.ReadOnly = True
        '
        'nom
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = "0"
        Me.nom.DefaultCellStyle = DataGridViewCellStyle11
        Me.nom.HeaderText = "Nominal"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'alasan
        '
        Me.alasan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.alasan.HeaderText = "Alasan"
        Me.alasan.Name = "alasan"
        Me.alasan.ReadOnly = True
        '
        'statusAcc
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.statusAcc.DefaultCellStyle = DataGridViewCellStyle12
        Me.statusAcc.HeaderText = "Status Acc"
        Me.statusAcc.Name = "statusAcc"
        Me.statusAcc.ReadOnly = True
        Me.statusAcc.Visible = False
        '
        'status2
        '
        Me.status2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.status2.DefaultCellStyle = DataGridViewCellStyle13
        Me.status2.HeaderText = "Status"
        Me.status2.Name = "status2"
        Me.status2.ReadOnly = True
        '
        'tglAcc
        '
        DataGridViewCellStyle14.Format = "f"
        DataGridViewCellStyle14.NullValue = "0"
        Me.tglAcc.DefaultCellStyle = DataGridViewCellStyle14
        Me.tglAcc.HeaderText = "Tgl Acc"
        Me.tglAcc.Name = "tglAcc"
        Me.tglAcc.ReadOnly = True
        '
        'Daftar_Pinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(831, 586)
        Me.Controls.Add(Me.DGVCALON)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGCDaftar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Daftar_Pinjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Pinjaman Koperasi VMG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGCDaftar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCALON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGCDaftar As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGVCALON As System.Windows.Forms.DataGridView
    Friend WithEvents idPinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglpinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlahp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jml_angsuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisaAng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisaAng2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglPengajuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alasan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusAcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglAcc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
