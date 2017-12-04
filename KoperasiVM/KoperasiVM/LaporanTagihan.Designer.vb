<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanTagihan
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CMBbulan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVTagihan = New System.Windows.Forms.DataGridView()
        Me.idsetor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namakaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jnsTagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbTahun = New System.Windows.Forms.ComboBox()
        CType(Me.DGVTagihan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMBbulan
        '
        Me.CMBbulan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMBbulan.BackColor = System.Drawing.Color.DarkGreen
        Me.CMBbulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBbulan.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBbulan.ForeColor = System.Drawing.Color.White
        Me.CMBbulan.FormattingEnabled = True
        Me.CMBbulan.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOPEMBER", "DESEMBER"})
        Me.CMBbulan.Location = New System.Drawing.Point(520, 20)
        Me.CMBbulan.Name = "CMBbulan"
        Me.CMBbulan.Size = New System.Drawing.Size(168, 32)
        Me.CMBbulan.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(866, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jumlah Tagihan Bulan XXX"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVTagihan
        '
        Me.DGVTagihan.AllowUserToAddRows = False
        Me.DGVTagihan.AllowUserToDeleteRows = False
        Me.DGVTagihan.AllowUserToResizeColumns = False
        Me.DGVTagihan.AllowUserToResizeRows = False
        Me.DGVTagihan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVTagihan.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DGVTagihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTagihan.ColumnHeadersVisible = False
        Me.DGVTagihan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsetor, Me.namakaryawan, Me.head, Me.jnsTagihan, Me.Jumlah, Me.StatusBayar})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTagihan.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVTagihan.GridColor = System.Drawing.Color.Honeydew
        Me.DGVTagihan.Location = New System.Drawing.Point(5, 128)
        Me.DGVTagihan.Name = "DGVTagihan"
        Me.DGVTagihan.ReadOnly = True
        Me.DGVTagihan.RowHeadersVisible = False
        Me.DGVTagihan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTagihan.Size = New System.Drawing.Size(540, 347)
        Me.DGVTagihan.TabIndex = 6
        '
        'idsetor
        '
        Me.idsetor.HeaderText = "idsetor"
        Me.idsetor.Name = "idsetor"
        Me.idsetor.ReadOnly = True
        Me.idsetor.Visible = False
        '
        'namakaryawan
        '
        Me.namakaryawan.HeaderText = "Nama Karyawan"
        Me.namakaryawan.Name = "namakaryawan"
        Me.namakaryawan.ReadOnly = True
        Me.namakaryawan.Width = 80
        '
        'head
        '
        Me.head.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.head.HeaderText = "Head"
        Me.head.Name = "head"
        Me.head.ReadOnly = True
        '
        'jnsTagihan
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.jnsTagihan.DefaultCellStyle = DataGridViewCellStyle4
        Me.jnsTagihan.HeaderText = "Jenis Tagihan"
        Me.jnsTagihan.Name = "jnsTagihan"
        Me.jnsTagihan.ReadOnly = True
        Me.jnsTagihan.Width = 128
        '
        'Jumlah
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Jumlah.DefaultCellStyle = DataGridViewCellStyle5
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'StatusBayar
        '
        Me.StatusBayar.HeaderText = "Status Bayar"
        Me.StatusBayar.Name = "StatusBayar"
        Me.StatusBayar.ReadOnly = True
        Me.StatusBayar.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Laporan Tagihan Bulan XXX"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.ForeColor = System.Drawing.Color.White
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(552, 128)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(302, 347)
        Me.TreeView1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(552, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 60)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Laporan Per Karyawan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(540, 60)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Laporan Keuangan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTahun
        '
        Me.CmbTahun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbTahun.BackColor = System.Drawing.Color.DarkGreen
        Me.CmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTahun.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTahun.ForeColor = System.Drawing.Color.White
        Me.CmbTahun.FormattingEnabled = True
        Me.CmbTahun.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CmbTahun.Location = New System.Drawing.Point(694, 20)
        Me.CmbTahun.Name = "CmbTahun"
        Me.CmbTahun.Size = New System.Drawing.Size(107, 32)
        Me.CmbTahun.TabIndex = 11
        '
        'LaporanTagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(866, 509)
        Me.Controls.Add(Me.CmbTahun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.CMBbulan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVTagihan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LaporanTagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Tagihan"
        CType(Me.DGVTagihan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGVTagihan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents CMBbulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idsetor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namakaryawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jnsTagihan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusBayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbTahun As System.Windows.Forms.ComboBox
End Class
