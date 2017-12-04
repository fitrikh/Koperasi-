<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Keuangan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.satu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.satu, Me.dua, Me.tiga, Me.empat, Me.lima, Me.enam})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(784, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'satu
        '
        Me.satu.HeaderText = "noA"
        Me.satu.Name = "satu"
        Me.satu.ReadOnly = True
        '
        'dua
        '
        Me.dua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dua.HeaderText = "akunA"
        Me.dua.Name = "dua"
        Me.dua.ReadOnly = True
        '
        'tiga
        '
        Me.tiga.HeaderText = "jumlahA"
        Me.tiga.Name = "tiga"
        Me.tiga.ReadOnly = True
        '
        'empat
        '
        Me.empat.HeaderText = "noB"
        Me.empat.Name = "empat"
        Me.empat.ReadOnly = True
        '
        'lima
        '
        Me.lima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lima.HeaderText = "akunB"
        Me.lima.Name = "lima"
        Me.lima.ReadOnly = True
        '
        'enam
        '
        Me.enam.HeaderText = "jumlahB"
        Me.enam.Name = "enam"
        Me.enam.ReadOnly = True
        '
        'Laporan_Keuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 372)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Laporan_Keuangan"
        Me.Text = "Laporan Keuangan Koperasi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents satu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enam As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
