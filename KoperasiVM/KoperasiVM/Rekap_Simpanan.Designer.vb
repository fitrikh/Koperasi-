<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rekap_Simpanan
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVsimpanan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simpanan_Pokok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simpanan_Wajib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Simpanan_sukarela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVsimpanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVsimpanan
        '
        Me.DGVsimpanan.AllowUserToAddRows = False
        Me.DGVsimpanan.AllowUserToDeleteRows = False
        Me.DGVsimpanan.AllowUserToResizeColumns = False
        Me.DGVsimpanan.AllowUserToResizeRows = False
        Me.DGVsimpanan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVsimpanan.BackgroundColor = System.Drawing.Color.White
        Me.DGVsimpanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVsimpanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVsimpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVsimpanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bulan, Me.Simpanan_Pokok, Me.Simpanan_Wajib, Me.Simpanan_sukarela, Me.Total})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVsimpanan.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGVsimpanan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVsimpanan.Location = New System.Drawing.Point(0, 70)
        Me.DGVsimpanan.Name = "DGVsimpanan"
        Me.DGVsimpanan.ReadOnly = True
        Me.DGVsimpanan.RowHeadersVisible = False
        Me.DGVsimpanan.Size = New System.Drawing.Size(758, 352)
        Me.DGVsimpanan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 68)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REKAP SIMPANAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bulan
        '
        Me.bulan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bulan.DefaultCellStyle = DataGridViewCellStyle9
        Me.bulan.HeaderText = "Bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.ReadOnly = True
        '
        'Simpanan_Pokok
        '
        Me.Simpanan_Pokok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Simpanan_Pokok.DefaultCellStyle = DataGridViewCellStyle10
        Me.Simpanan_Pokok.HeaderText = "Simpanan_Pokok"
        Me.Simpanan_Pokok.Name = "Simpanan_Pokok"
        Me.Simpanan_Pokok.ReadOnly = True
        '
        'Simpanan_Wajib
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        Me.Simpanan_Wajib.DefaultCellStyle = DataGridViewCellStyle11
        Me.Simpanan_Wajib.HeaderText = "Simpanan Wajib"
        Me.Simpanan_Wajib.Name = "Simpanan_Wajib"
        Me.Simpanan_Wajib.ReadOnly = True
        '
        'Simpanan_sukarela
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N0"
        Me.Simpanan_sukarela.DefaultCellStyle = DataGridViewCellStyle12
        Me.Simpanan_sukarela.HeaderText = "Simpanan Sukarela"
        Me.Simpanan_sukarela.Name = "Simpanan_sukarela"
        Me.Simpanan_sukarela.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle13
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.KoperasiVM.My.Resources.Resources.LOGO_VMG_VERTICAL_KOP_
        Me.PictureBox1.Location = New System.Drawing.Point(137, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Rekap_Simpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVsimpanan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Rekap_Simpanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "     Rekap_Simpanan"
        CType(Me.DGVsimpanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVsimpanan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bulan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simpanan_Pokok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simpanan_Wajib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Simpanan_sukarela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
