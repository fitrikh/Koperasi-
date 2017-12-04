Public Class LaporanTagihan
    Public waktu As Integer
    Dim s As Date
    Dim s2 As Integer
    Dim d As String
    Dim status As Integer = 0
    Private Sub tagihan()
        label()
        DGVTagihan.Rows.Clear()
        Dim sqlt As String
        sqlt = " select k.idsetor, m.NAMA_KARYAWAN,a.account,k.jumlah from Koperasi_setor k" & _
               " left join KARYAWAN_MF m on m.NIP_KARYAWAN = k.nip " & _
               " left join Koperasi_Account a on a.id_account = k.jns_setor " & _
               " where Month(k.tanggalPotong) = '" & waktu & "' and Year(k.tanggalPotong) = '" & s2 & "'" & _
               " order by a.account,m.Nama_Karyawan"
        Dim dt As New DataTable
        Dim db As New CDataBase
        Dim nama As String = ""
        dt.Rows.Clear()
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            'tabel:
            'DGVTagihan.AutoGenerateColumns = False
            '            DGVTagihan.Columns(0).DataPropertyName = dt.Columns(0).ColumnName
            '            DGVTagihan.Columns(1).DataPropertyName = dt.Columns(1).ColumnName
            '            DGVTagihan.Columns(2).DataPropertyName = dt.Columns(2).ColumnName
            '            DGVTagihan.Columns(3).DataPropertyName = dt.Columns(3).ColumnName
            DGVTagihan.Columns(3).DefaultCellStyle.Format = "N0"
            '            DGVTagihan.DataSource = dt
            Dim data1 As Integer = 0
            Dim data2 As Integer = 0
            Dim idrow As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                'idsetor, NAMA_KARYAWAN, account, jumlah
                If dt.Rows(i).Item("account") <> nama Then
                    If i > 0 Then
                        DGVTagihan.Item("Jumlah", idrow).Value = Format(data2, "N0")
                    End If
                    data2 = 0
                    nama = dt.Rows(i).Item("account")
                    DGVTagihan.Rows.Add("SHOW", "TOTAL ", nama, "", 0)
                    idrow = DGVTagihan.Rows.Count - 1
                End If
                
                DGVTagihan.Rows.Add(dt.Rows(i).Item("account"), "", dt.Rows(i).Item("nama_karyawan"), Format(dt.Rows(i).Item("jumlah"), "N0"))
                data1 = dt(i)("jumlah")
                data2 += data1
                If i = dt.Rows.Count - 1 Then
                    DGVTagihan.Item("Jumlah", idrow).Value = data2
                End If
            Next
            
        Else
            'MsgBox("Data Untuk Bulan " & d & " belum ada")
            dt.Rows.Clear()
            'waktu = waktu - 1
            'GoTo tabel
        End If
        'DGVTagihan.Columns().Item().
    End Sub
    Private Sub sembunyikan()
        If DGVTagihan.Rows.Count > 0 Then
            For i = 0 To DGVTagihan.Rows.Count - 1
                If DGVTagihan.Item(1, i).Value <> "" Then
                    'TAMPIL
                    DGVTagihan.Rows(i).DefaultCellStyle.BackColor = Color.DarkGreen
                    DGVTagihan.Rows(i).DefaultCellStyle.ForeColor = Color.Honeydew
                    DGVTagihan.Rows(i).Visible = True
                    DGVTagihan.Item(0, i).Value = "HIDE"
                Else
                    'TIDAK TAMPIL
                    DGVTagihan.Rows(i).DefaultCellStyle.BackColor = Color.Honeydew
                    DGVTagihan.Rows(i).Visible = False
                End If
            Next
        End If
    End Sub
    Private Sub tampilkan()
        status = 0
        Dim pilihan As String
        Dim pilihan2 As String
        pilihan = DGVTagihan.Item(2, DGVTagihan.CurrentRow.Index).Value
        pilihan2 = pilihan.Replace("TOTAL ", "")
        If DGVTagihan.Item(0, DGVTagihan.CurrentRow.Index).Value = "HIDE" Then
            'Pertama Hide dijadikan Show -> Dari row 0 sampai Total Row DGV yang nama accountnya sama
            If DGVTagihan.Rows.Count > 0 Then
                For i = 0 To DGVTagihan.Rows.Count - 1
                    If DGVTagihan.Item(0, i).Value = pilihan Then
                        DGVTagihan.Rows(i).Visible = True
                    End If
                Next
            End If
            'Setelah Di Show semua, status kolom header jadi Show
            DGVTagihan.Item(0, DGVTagihan.CurrentRow.Index).Value = "SHOW"
        ElseIf DGVTagihan.Item(0, DGVTagihan.CurrentRow.Index).Value = "SHOW" Then
            'Pertama Show dijadikan Hide -> Dari row 0 sampai Total Row DGV yang nama accountnya sama
            If DGVTagihan.Rows.Count > 0 Then
                For i = 0 To DGVTagihan.Rows.Count - 1
                    If DGVTagihan.Item(0, i).Value = pilihan Then
                        DGVTagihan.Rows(i).Visible = False
                    End If
                Next
            End If
            'Setelah Di Show semua, status kolom header jadi Hide
            DGVTagihan.Item(0, DGVTagihan.CurrentRow.Index).Value = "HIDE"
        End If
        
        If status = 0 Then
            
        End If
        
        
        'MsgBox(pilihan2)
    End Sub
    Private Sub LaporanTagihan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbTahun.SelectedIndex = 1
        s2 = Year(CmbTahun.SelectedValue)
        CmbTahun.SelectedIndex = 1
        waktu = Month(s)
        label()
        waktubulan()
        CMBbulan.SelectedIndex = waktu - 1
        tagihan()
        Resume_laporan()
        sembunyikan()
    End Sub
    Private Sub waktubulan()
        If waktu = 1 Then
            d = "Januari"
        ElseIf waktu = 2 Then
            d = "Februari"
        ElseIf waktu = 3 Then
            d = "Maret"
        ElseIf waktu = 4 Then
            d = "April"
        ElseIf waktu = 5 Then
            d = "Mei"
        ElseIf waktu = 6 Then
            d = "Juni"
        ElseIf waktu = 7 Then
            d = "Juli"
        ElseIf waktu = 8 Then
            d = "Agustus"
        ElseIf waktu = 9 Then
            d = "September"
        ElseIf waktu = 10 Then
            d = "Oktober"
        ElseIf waktu = 11 Then
            d = "Nopember"
        ElseIf waktu = 12 Then
            d = "Desember"
        Else
            d = "Tidak Ada"
        End If
    End Sub
    Private Sub label()
        Label1.Text = " Laporan Tagihan Bulan " & d & " Tahun " & s2
        Dim sqlt As String
        sqlt = " select sum(jumlah) from koperasi_setor where month(tanggalPotong) = '" & waktu & "' and year(tanggalPotong) = '" & s2 & "'"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            Dim tagihan As Double
            If IsDBNull(dt(0)(0)) = True Then
                tagihan = 0
            Else
                tagihan = dt(0)(0)
            End If
            Label2.TextAlign = ContentAlignment.MiddleCenter
            Label2.Text = " Jumlah tagihan Bulan " & d & " Tahun " & s2 & " adalah     " & Format(tagihan, "N")
        End If
    End Sub
    Private Sub Resume_laporan()
        Dim sqlt_laporan As String
        sqlt_laporan = " select M.NIP_KARYAWAN,m.NAMA_KARYAWAN,sum(k.jumlah) as total from Koperasi_setor k" & _
                       " left join KARYAWAN_MF m on m.NIP_KARYAWAN = k.nip " & _
                       " left join Koperasi_Account a on a.id_account = k.jns_setor " & _
                       " where Month(k.tanggalPotong) = '" & waktu & "' and Year(k.tanggalPotong) = '" & s2 & "'" & _
                       " group by M.NIP_KARYAWAN,m.NAMA_KARYAWAN order by m.NAMA_KARYAWAN "
        Dim dt_laporan As New DataTable
        Dim db_laporan As New CDataBase
        dt_laporan = db_laporan.selectDB(sqlt_laporan)
        Dim namaAkun As String
        Dim jumlahtotal As Integer
        Dim total2 As Integer
        Dim keys As String
        Dim nipakun As String
        If dt_laporan.Rows.Count > 0 Then
            TreeView1.Nodes.Clear()
            For i = 0 To dt_laporan.Rows.Count - 1
                namaAkun = dt_laporan(i)(1)
                jumlahtotal = dt_laporan(i)(2)
                total2 = +jumlahtotal
                nipakun = dt_laporan(i)(0)
                keys = "Laporan " & namaAkun
                If TreeView1.SelectedNode Is Nothing Then
                    TreeView1.Nodes.Add(i, namaAkun & " " & Format(jumlahtotal, "N0"))
                End If
                Dim sqltdetail As String
                sqltdetail = "select a.account,k.jumlah from Koperasi_setor k" & _
                           " left join KARYAWAN_MF m on m.NIP_KARYAWAN = k.nip " & _
                           " left join Koperasi_Account a on a.id_account = k.jns_setor " & _
                           " where Month(k.tanggalPotong) = '" & waktu & "' and Year(k.tanggalPotong) = '" & s2 & "' and m.NIP_KARYAWAN = '" & nipakun & "' order by a.account"
                Dim dtdetail As New DataTable
                Dim dbdetail As New CDataBase
                dtdetail = dbdetail.selectDB(sqltdetail)
                If dtdetail.Rows.Count > 0 Then
                    Dim namak As String
                    Dim jum As Integer
                    For x = 0 To dtdetail.Rows.Count - 1
                        namak = dtdetail(x)(0)
                        jum = dtdetail(x)(1)
                        TreeView1.Nodes(i).Nodes.Add("detail", namak & " " & Format(jum, "N0"))
                    Next
                End If
            Next
        End If






    End Sub

    Private Sub CMBbulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub CMBbulan_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBbulan.SelectedIndexChanged
        's = Now
        s2 = CmbTahun.SelectedItem
        label()
        waktu = CMBbulan.SelectedIndex + 1
        waktubulan()
        tagihan()
        TreeView1.Nodes.Clear()
        Resume_laporan()
        Label3.Text = "Laporan Keuangan Bulan " & vbCrLf & CMBbulan.SelectedItem
        sembunyikan()
    End Sub

    Private Sub DGVTagihan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVTagihan.Click
        tampilkan()
    End Sub

    Private Sub CmbTahun_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbTahun.SelectedIndexChanged
        s2 = CmbTahun.SelectedItem
        label()
        tagihan()
        waktu = CMBbulan.SelectedIndex + 1
        waktubulan()
        TreeView1.Nodes.Clear()
        Resume_laporan()
        Label3.Text = "Laporan Keuangan Bulan " & vbCrLf & CMBbulan.SelectedItem
        sembunyikan()
    End Sub
End Class