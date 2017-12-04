<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarAnggota
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarAnggota))
        Me.Dtkaryawan = New System.Windows.Forms.DataGridView()
        Me.nip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtAnggota = New System.Windows.Forms.DataGridView()
        Me.nip2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jnsAnggota = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.wajib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plafon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Dtkaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtkaryawan
        '
        Me.Dtkaryawan.AllowUserToAddRows = False
        Me.Dtkaryawan.AllowUserToDeleteRows = False
        Me.Dtkaryawan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Dtkaryawan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtkaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtkaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nip, Me.nama})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dtkaryawan.DefaultCellStyle = DataGridViewCellStyle1
        Me.Dtkaryawan.GridColor = System.Drawing.Color.White
        Me.Dtkaryawan.Location = New System.Drawing.Point(12, 31)
        Me.Dtkaryawan.Name = "Dtkaryawan"
        Me.Dtkaryawan.ReadOnly = True
        Me.Dtkaryawan.RowHeadersVisible = False
        Me.Dtkaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dtkaryawan.Size = New System.Drawing.Size(316, 314)
        Me.Dtkaryawan.TabIndex = 0
        '
        'nip
        '
        Me.nip.HeaderText = "Nip"
        Me.nip.Name = "nip"
        Me.nip.ReadOnly = True
        '
        'nama
        '
        Me.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama.HeaderText = "nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'DtAnggota
        '
        Me.DtAnggota.AllowUserToAddRows = False
        Me.DtAnggota.AllowUserToDeleteRows = False
        Me.DtAnggota.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DtAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAnggota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nip2, Me.nama2, Me.jnsAnggota, Me.wajib, Me.plafon})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtAnggota.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtAnggota.GridColor = System.Drawing.Color.White
        Me.DtAnggota.Location = New System.Drawing.Point(464, 31)
        Me.DtAnggota.Name = "DtAnggota"
        Me.DtAnggota.RowHeadersVisible = False
        Me.DtAnggota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DtAnggota.Size = New System.Drawing.Size(493, 314)
        Me.DtAnggota.TabIndex = 1
        '
        'nip2
        '
        Me.nip2.HeaderText = "Nip"
        Me.nip2.Name = "nip2"
        Me.nip2.Visible = False
        '
        'nama2
        '
        Me.nama2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama2.HeaderText = "Nama"
        Me.nama2.Name = "nama2"
        '
        'jnsAnggota
        '
        Me.jnsAnggota.HeaderText = "Jns Anggota"
        Me.jnsAnggota.Items.AddRange(New Object() {"BRONZE", "SILVER", "GOLD", "PLATINUM"})
        Me.jnsAnggota.Name = "jnsAnggota"
        Me.jnsAnggota.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.jnsAnggota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'wajib
        '
        Me.wajib.HeaderText = "Iuran"
        Me.wajib.Name = "wajib"
        '
        'plafon
        '
        Me.plafon.HeaderText = "Plafon"
        Me.plafon.Name = "plafon"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(357, 145)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(93, 40)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "====>"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Location = New System.Drawing.Point(963, 116)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(102, 55)
        Me.BTNSimpan.TabIndex = 3
        Me.BTNSimpan.Text = "TAMBAH ANGGOTA"
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(357, 201)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(93, 40)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "<===="
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DAFTAR KARYAWAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(464, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DAFTAR ANGGOTA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(963, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 55)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DaftarAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1077, 357)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DtAnggota)
        Me.Controls.Add(Me.Dtkaryawan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DaftarAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ">> DAFTAR ANGGOTA"
        CType(Me.Dtkaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dtkaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents nip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtAnggota As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nip2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jnsAnggota As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents wajib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plafon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
