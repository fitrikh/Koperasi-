<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHU
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVSHU = New System.Windows.Forms.DataGridView()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.April = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Juni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Juli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Okt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DGVSHU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVSHU
        '
        Me.DGVSHU.AllowUserToAddRows = False
        Me.DGVSHU.AllowUserToDeleteRows = False
        Me.DGVSHU.AllowUserToResizeColumns = False
        Me.DGVSHU.AllowUserToResizeRows = False
        Me.DGVSHU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSHU.BackgroundColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSHU.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVSHU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVSHU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nama, Me.Jan, Me.Feb, Me.Maret, Me.April, Me.Mei, Me.Juni, Me.Juli, Me.Agust, Me.Sept, Me.Okt, Me.Nop, Me.Des})
        Me.DGVSHU.Location = New System.Drawing.Point(9, 63)
        Me.DGVSHU.Name = "DGVSHU"
        Me.DGVSHU.ReadOnly = True
        Me.DGVSHU.RowHeadersVisible = False
        Me.DGVSHU.Size = New System.Drawing.Size(1047, 252)
        Me.DGVSHU.TabIndex = 0
        '
        'Nama
        '
        Me.Nama.HeaderText = ""
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Width = 150
        '
        'Jan
        '
        Me.Jan.HeaderText = "Jan"
        Me.Jan.Name = "Jan"
        Me.Jan.ReadOnly = True
        '
        'Feb
        '
        Me.Feb.HeaderText = "Feb"
        Me.Feb.Name = "Feb"
        Me.Feb.ReadOnly = True
        '
        'Maret
        '
        Me.Maret.HeaderText = "Maret"
        Me.Maret.Name = "Maret"
        Me.Maret.ReadOnly = True
        '
        'April
        '
        Me.April.HeaderText = "April"
        Me.April.Name = "April"
        Me.April.ReadOnly = True
        '
        'Mei
        '
        Me.Mei.HeaderText = "Mei"
        Me.Mei.Name = "Mei"
        Me.Mei.ReadOnly = True
        '
        'Juni
        '
        Me.Juni.HeaderText = "Juni"
        Me.Juni.Name = "Juni"
        Me.Juni.ReadOnly = True
        '
        'Juli
        '
        Me.Juli.HeaderText = "Juli"
        Me.Juli.Name = "Juli"
        Me.Juli.ReadOnly = True
        '
        'Agust
        '
        Me.Agust.HeaderText = "Agust"
        Me.Agust.Name = "Agust"
        Me.Agust.ReadOnly = True
        '
        'Sept
        '
        Me.Sept.HeaderText = "Sept"
        Me.Sept.Name = "Sept"
        Me.Sept.ReadOnly = True
        '
        'Okt
        '
        Me.Okt.HeaderText = "Okt"
        Me.Okt.Name = "Okt"
        Me.Okt.ReadOnly = True
        '
        'Nop
        '
        Me.Nop.HeaderText = "Nop"
        Me.Nop.Name = "Nop"
        Me.Nop.ReadOnly = True
        '
        'Des
        '
        Me.Des.HeaderText = "Des"
        Me.Des.Name = "Des"
        Me.Des.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Rincian Per Bulan Simpanan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Rincian Saldo Akhir Per Bulan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SHU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1061, 327)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVSHU)
        Me.Name = "SHU"
        Me.Text = "SHU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVSHU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVSHU As System.Windows.Forms.DataGridView
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Maret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents April As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mei As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Juni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Juli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Agust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Okt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
