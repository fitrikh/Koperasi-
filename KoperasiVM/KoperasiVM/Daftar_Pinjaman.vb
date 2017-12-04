Imports Microsoft.Reporting.WinForms
Public Class Daftar_Pinjaman
    Dim tgl As Date
    Dim totalPinjam As Integer
    Dim totalangsuran As Integer
    Dim totalSaldoP As Integer

    Private Sub Daftar_Pinjaman_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            daftarCalonPeminjam()
            daftarPinjaman()
            ' warna()
            status()
            warna2()
            Label1.Text = "DAFTAR PEMINJAMAN ANGGOTA YANG SEDANG BERJALAN" & vbCrLf & Format(Now, "dd MMMM yyyy")
            Label2.Text = "DAFTAR CALON PEMINJAMAN " & vbCrLf & Format(Now, "dd MMMM yyyy")
            'sembunyikanYangSudahLunas()
        End If
    End Sub
    Private Sub Daftar_Pinjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftarCalonPeminjam()
        daftarPinjaman()
        warna()
        status()
        warna2()
        Label1.Text = "DAFTAR PEMINJAMAN ANGGOTA YANG SEDANG BERJALAN" & vbCrLf & Format(Now, "dd MMMM yyyy")
        Label2.Text = "DAFTAR CALON PEMINJAMAN " & vbCrLf & Format(Now, "dd MMMM yyyy")
        'sembunyikanYangSudahLunas()

    End Sub
    Private Sub daftarPinjaman()
        Dim sqlt As String
        sqlt = "Select * from " & _
               " (select p.idpinjam, k.NAMA_KARYAWAN, p.tglPinjam, p.jumlah_pinjam,p.lama_pinjam," & _
               " sum(isnull(a.jumlah_bayar,0)) as jml_angsuran," & _
               " case a.jumlah_bayar when 0 then '0' else p.lama_pinjam - count(a.jumlah_bayar)end as sisa," & _
               " case when a.jumlah_bayar is null then p.jumlah_pinjam else p.jumlah_pinjam - sum(a.jumlah_bayar)end as saldo" & _
               " from Koperasi_Detail_Pinjaman p left join KARYAWAN_MF k" & _
               " on k.NIP_KARYAWAN = p.nip_peminjam" & _
               " left join Koperasi_History_Angsuran a on a.id_pinjam = p.idpinjam" & _
               " where(a.jns_bayar = 102 Or a.jns_bayar Is null) " & _
               " group by p.idpinjam,k.NAMA_KARYAWAN,p.tglPinjam,p.jumlah_pinjam,p.lama_pinjam,a.jumlah_bayar) as w" & _
               " where jml_angsuran <> jumlah_pinjam order by tglPinjam Desc"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            DGCDaftar.AutoGenerateColumns = False
            'DGCDaftar.Columns(0).DataPropertyName = dt.Columns(0).ColumnName
            'DGCDaftar.Columns(1).DataPropertyName = dt.Columns(1).ColumnName
            'DGCDaftar.Columns(2).DataPropertyName = dt.Columns(2).ColumnName
            'DGCDaftar.Columns(3).DataPropertyName = dt.Columns(3).ColumnName
            'DGCDaftar.Columns(4).DataPropertyName = dt.Columns(4).ColumnName
            'DGCDaftar.Columns(5).DataPropertyName = dt.Columns(5).ColumnName
            'DGCDaftar.Columns(6).DataPropertyName = dt.Columns(6).ColumnName
            'DGCDaftar.Columns(7).DataPropertyName = dt.Columns(7).ColumnName
            'DGCDaftar.DataSource = dt
            Dim idp As Integer
            Dim namak As String
            Dim tglpinjam As Date
            Dim jml_pinjma As Integer
            Dim lamaP As String
            Dim jmlAngs As Integer
            Dim sisaP As String
            Dim saldop As Integer

            Dim ix As Integer
            For i = 0 To dt.Rows.Count - 1
                idp = dt(i)(0)
                namak = dt(i)(1)
                tglpinjam = dt(i)(2)
                jml_pinjma = dt(i)(3)
                lamaP = (dt(i)(4))
                jmlAngs = dt(i)(5)
                sisaP = dt(i)(6)
                saldop = dt(i)(7)
                totalPinjam += jml_pinjma
                totalangsuran += jmlAngs
                totalSaldoP += saldop
                DGCDaftar.Rows.Add(idp, namak, Format(tglpinjam, "dd-MMM-yyyy"), jml_pinjma, lamaP, jmlAngs, sisaP, saldop)
                'MsgBox(idp)
                ix = i + 1
            Next
            DGCDaftar.Rows.Add("", "TOTAL", "", totalPinjam, "", totalangsuran, "", totalSaldoP)
            DGCDaftar.Rows(ix).DefaultCellStyle.BackColor = Color.GreenYellow
            DGCDaftar.Rows(ix).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            DGCDaftar.Item(1, ix).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        'With DGCDaftar
        '    For x = 0 To DGCDaftar.Rows.Count - 1
        '        If DGCDaftar.Item(1, x).Value = "TOTAL" Then

        '        End If
        '    Next
        'End With


    End Sub
    Private Sub daftarCalonPeminjam()
        Dim sqlt As String
        sqlt = " SELECT K.id_kasbon,d.id_kasbondetail, m.NAMA_KARYAWAN, d.tgl_pengajuan," & _
               " d.nominal_bon, d.alasan, d.status_ACC, d.tgl_ACCPimpinan, d.tgl_cair " & _
               " FROM KASBON K" & _
               " left join KASBON_DETAIL d on d.id_kasbon = K.id_kasbon" & _
               " left join KARYAWAN_MF m on m.NIP_KARYAWAN = K.nip_karyawan" & _
               " where(Year(d.tgl_pengajuan)) >= 2015 And d.tgl_cair Is null or (d.status_ACC < 3) " & _
               " order by d.tgl_pengajuan desc "
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            DGVCALON.AutoGenerateColumns = False
            DGVCALON.Columns(0).DataPropertyName = dt.Columns(0).ColumnName
            DGVCALON.Columns(1).DataPropertyName = dt.Columns(1).ColumnName
            DGVCALON.Columns(2).DataPropertyName = dt.Columns(2).ColumnName
            DGVCALON.Columns(3).DataPropertyName = dt.Columns(3).ColumnName
            DGVCALON.Columns(4).DataPropertyName = dt.Columns(4).ColumnName
            DGVCALON.Columns(5).DataPropertyName = dt.Columns(5).ColumnName
            DGVCALON.Columns(6).DataPropertyName = dt.Columns(6).ColumnName
            DGVCALON.Columns(8).DataPropertyName = dt.Columns(7).ColumnName
            DGVCALON.DataSource = dt
        End If
    End Sub
    Private Sub warna()
        DGCDaftar.DefaultCellStyle.BackColor = Color.White
        For i = 0 To DGCDaftar.Rows.Count - 2
            If DGCDaftar.Rows(i).Index Mod 2 <> 0 Then
                DGCDaftar.Rows(i).DefaultCellStyle.BackColor = Color.PaleTurquoise
            End If
        Next
        'DGCDaftar.Rows(DGCDaftar.Rows.Count - 1).DefaultCellStyle.BackColor = Color.GreenYellow
    End Sub

    Private Sub warna2()
        For i = 0 To DGVCALON.Rows.Count - 1
            If DGVCALON.Rows(i).Index Mod 2 = 0 Then
                DGVCALON.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
            Else
                DGVCALON.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub sembunyikanYangSudahLunas()
        For i = 0 To DGCDaftar.Rows.Count - 2
            If DGCDaftar.Item(6, i).Value = "0" Then
                'DGCDaftar.Rows(i).Visible = False
                DGCDaftar.Rows.RemoveAt(DGCDaftar.Rows(i).Index)
            End If
        Next

    End Sub
    Private Sub status()
        For i = 0 To DGVCALON.Rows.Count - 1
            If DGVCALON.Item(6, i).Value = 3 Then
                DGVCALON.Item(7, i).Value = "Acc Pimpinan"
            ElseIf DGVCALON.Item(6, i).Value = 0 Then
                DGVCALON.Item(7, i).Value = "Acc HRD"
            ElseIf DGVCALON.Item(6, i).Value = 1 Then
                DGVCALON.Item(7, i).Value = "Dibatalkan via HRD"
            ElseIf DGVCALON.Item(6, i).Value = 2 Then
                DGVCALON.Item(7, i).Value = "Dibatalkan via Pimpinan"
            ElseIf DGVCALON.Item(6, i).Value = -1 Then
                DGVCALON.Item(7, i).Value = "Permohonan"
            End If
        Next
    End Sub

    Private Sub DGCDaftar_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGCDaftar.ColumnHeaderMouseClick
        'MsgBox()
        If DGCDaftar.Rows.Count > 0 Then
            For x As Integer = DGCDaftar.Rows.Count - 1 To 0 Step -1
                If DGCDaftar.Rows(x).Index Mod 2 = 0 Then
                    DGCDaftar.Rows(x).DefaultCellStyle.BackColor = Color.PaleTurquoise
                Else
                    DGCDaftar.Rows(x).DefaultCellStyle.BackColor = Color.White
                End If
                If DGCDaftar.Item(1, x).Value = "TOTAL" Then
                    DGCDaftar.Rows.RemoveAt(DGCDaftar.Rows(x).Index)
                End If
            Next
        End If
        DGCDaftar.Rows.Add("", "TOTAL", "", totalPinjam, "", totalangsuran, "", totalSaldoP)
        DGCDaftar.Rows(DGCDaftar.Rows.Count - 1).DefaultCellStyle.BackColor = Color.GreenYellow
        DGCDaftar.Rows(DGCDaftar.Rows.Count - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        DGCDaftar.Item(1, DGCDaftar.Rows.Count - 1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Label1.Text = "DAFTAR PEMINJAMAN ANGGOTA YANG SEDANG BERJALAN" & vbCrLf & Format(Now, "dd MMMM yyyy")

    End Sub
    Private Sub cetak()
        Dim cetak_bukti As New PrintPreview
        cetak_bukti.nama_cetak = DGVCALON.Item(2, DGVCALON.CurrentRow.Index).Value
        Dim no_id_cetak As String
        no_id_cetak = DGVCALON.Item(0, DGVCALON.CurrentRow.Index).Value & "-" & DGVCALON.Item(1, DGVCALON.CurrentRow.Index).Value
        cetak_bukti.nip_cetak = no_id_cetak
        cetak_bukti.tgl_cetak = DGVCALON.Item(3, DGVCALON.CurrentRow.Index).Value
        cetak_bukti.jumlah_pinjaman_cetak = DGVCALON.Item(4, DGVCALON.CurrentRow.Index).Value
        cetak_bukti.alasan_cetak = DGVCALON.Item(5, DGVCALON.CurrentRow.Index).Value
        If cetak_bukti.ShowDialog = Windows.Forms.DialogResult.OK Then
            
        End If
    End Sub
    Private Sub DGVCALON_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVCALON.ColumnHeaderMouseClick
        status()
        warna2()
    End Sub
    Private Sub DGVCALON_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVCALON.DoubleClick
        cetak()
    End Sub

    Private Sub DGVCALON_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCALON.CellContentClick

    End Sub
End Class