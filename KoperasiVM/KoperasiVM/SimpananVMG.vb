Public Class SimpananVMG
    Dim tahun As Integer
    Dim totalSimpanan_per_bulan As Integer
    Dim totalAngsuran_per_bulan As Integer
    Dim totalPinjaman_per_bulan As Integer
    Dim totalSimpanan_anggota_istimewa_per_bulan As Integer
    Dim totalBunga_per_bulan As Integer
    Dim saldoKas As Integer
    Dim pembayaran_hutang_vmg As Integer
    Dim saldoAkhir_kas As Integer
    Dim totalSimpanan_per_akhir As Integer
    Dim totalAngsuran_per_akhir As Integer
    Dim totalPinjaman_per_akhir As Integer
    Dim saldoKas1 As Integer
    Dim saldoAkhir_kas1 As Integer
    Dim totalBunga_per_akhir As Integer

    Private Sub SimpananVMG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tahun = 2016
        Label1.Text = "KOPERASI VINCENT MAESTRO GROUP" & vbCrLf & "Laporan Alur Kas Koperasi" & vbCrLf & "Tahun " & tahun
        SimpananYoki()
        Dim tgl As Date = Now
        ' Label1.Text = "ALUR KAS KOPERASI" & vbCrLf & "Koperasi VMG Surabaya" & vbCrLf & "Tahun 2015"
        Label2.Text = "Catatan Koperasi : " & vbCrLf & vbCrLf & _
                      "Saldo Koperasi = Simpanan Anggota + Angsuran + SHU - Pinjaman Anggota" & vbCrLf & _
                      "Hutang VMG =  Saldo Akhir Koperasi + Saldo Koperasi - Saldo akhir Hutang VMG "
        Label3.Text = "Surabaya," & Format(tgl, "dd MMMM yyyy") & vbCrLf & "Mengetahui, " & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Julius Joki Setiawan"
    End Sub
    Private Sub SimpananYoki()
        Try
            If tahun > 2015 Then
                simpananAkhirTahun()
                DgvSimpanan.Rows.Add("Saldo Akhir tahun ".ToUpper & tahun - 1, totalSimpanan_per_akhir, totalPinjaman_per_akhir, totalAngsuran_per_akhir, _
                                   totalBunga_per_akhir, saldoKas1, -totalSimpanan_anggota_istimewa_per_bulan, saldoAkhir_kas1)
            Else
                saldoAkhir_kas1 = 0
                saldoKas1 = 0
            End If

            'tahun = 2016
            ''Tampilkan Bulan Desember Tahun Sebelumnya
            For i = 1 To 12
                'Dim x As Integer
                'Dim y As Integer
                Dim z As Date
                'y = InputBox("Masukan Bulan", "Masukan Bulan", x)

                z = DateSerial(tahun, i + 1, 0)
                'cari jumlah simpanan Anggota per bulan
                Dim sqltSimpanan As String
                'sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
                sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where month(tgl_simpan)= " & i & " and kredit <> 305 AND year(tgl_simpan)= " & tahun & ""
                Dim dtsimpanan As New DataTable
                Dim dbsimpanan As New CDataBase
                dtsimpanan = dbsimpanan.selectDB(sqltSimpanan)
                If dtsimpanan.Rows.Count > 0 Then
                    If IsDBNull(dtsimpanan(0)(0)) = True Then
                        totalSimpanan_per_bulan = 0
                    Else
                        totalSimpanan_per_bulan = dtsimpanan(0)(0)
                    End If
                    ' MsgBox(totalSimpanan_per_bulan)
                End If
                'mencari angsuran
                Dim sqltAngsuran As String
                'sqltAngsuran = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 102 and convert(date,tgl_bayar)<= '" & _
                '     Format(z, "yyyy-MM-dd") & "'"
                sqltAngsuran = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 102 and month(tgl_bayar) = '" & i & "' AND year(tgl_bayar)= " & tahun & ""
                Dim dt_Angsuran As New DataTable
                Dim dbangsuran As New CDataBase
                dt_Angsuran = dbangsuran.selectDB(sqltAngsuran)
                If dt_Angsuran.Rows.Count > 0 Then
                    If IsDBNull(dt_Angsuran(0)(0)) = True Then
                        totalAngsuran_per_bulan = 0
                    Else
                        totalAngsuran_per_bulan = dt_Angsuran(0)(0)
                    End If
                    ' MsgBox(totalAngsuran_per_bulan)
                End If
                'mencari bunga
                Dim sqltBunga As String
                'sqltBunga = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 500 and convert(date,tgl_bayar)<= '" & _
                ' Format(z, "yyyy-MM-dd") & "'"
                sqltBunga = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 500 and month(tgl_bayar) = '" & i & "' AND year(tgl_bayar)= " & tahun & ""
                Dim dtbunga As New DataTable
                Dim dbbunga As New CDataBase
                dtbunga = dbbunga.selectDB(sqltBunga)
                If dtbunga.Rows.Count > 0 Then
                    If IsDBNull(dtbunga(0)(0)) = True Then
                        totalBunga_per_bulan = 0
                    Else
                        totalBunga_per_bulan = dtbunga(0)(0)
                    End If
                End If
                'mencari pinjaman
                Dim sqtlPinjaman As String
                'sqtlPinjaman = " select SUM(jumlah_pinjam) as jumlah_pinjam from Koperasi_Detail_Pinjaman " & _
                '               "where convert(date,tglPinjam)<= '" & Format(z, "yyyy-MM-dd") & "'"
                sqtlPinjaman = "select SUM(jumlah_pinjam) as jumlah_pinjam from Koperasi_Detail_Pinjaman where month(tglPinjam) = '" & i & "' AND year(tglPinjam)= " & tahun & ""
                Dim dt_pinjaman As New DataTable
                Dim db_pinjaman As New CDataBase
                dt_pinjaman = db_pinjaman.selectDB(sqtlPinjaman)
                If dt_pinjaman.Rows.Count > 0 Then
                    If IsDBNull(dt_pinjaman(0)(0)) = True Then
                        totalPinjaman_per_bulan = 0
                    Else
                        totalPinjaman_per_bulan = dt_pinjaman(0)(0)
                    End If
                End If
                Dim d As String
                d = MonthName(i, True)
                ' totalSimpanan_anggota_istimewa_per_bulan = totalSimpanan_per_bulan + totalAngsuran_per_bulan + totalBunga_per_bulan - totalPinjaman_per_bulan
                If i = 1 And tahun > 2015 Then
                    saldoKas = totalSimpanan_per_bulan - totalPinjaman_per_bulan + totalAngsuran_per_bulan + totalBunga_per_bulan + saldoAkhir_kas1
                Else
                    saldoKas = totalSimpanan_per_bulan - totalPinjaman_per_bulan + totalAngsuran_per_bulan + totalBunga_per_bulan
                End If

                saldoAkhir_kas = saldoAkhir_kas + saldoKas + totalSimpanan_anggota_istimewa_per_bulan
                If saldoAkhir_kas < 0 Then
                    totalSimpanan_anggota_istimewa_per_bulan = saldoAkhir_kas
                    saldoAkhir_kas = 0
                Else
                    totalSimpanan_anggota_istimewa_per_bulan = 0
                End If
                'totalSimpanan_anggota_istimewa_per_bulan = saldoKas + totalSimpanan_anggota_istimewa_per_bulan + saldoAkhir_kas
                '' mencari jumlah hutang koperasi ke VMG
                'If saldoAkhir_kas < 0 Then
                '    totalSimpanan_anggota_istimewa_per_bulan = saldoKas + totalSimpanan_anggota_istimewa_per_bulan + saldoAkhir_kas
                'ElseIf saldoAkhir_kas >= 0 Then
                '    If totalSimpanan_anggota_istimewa_per_bulan <> 0 Then
                '        totalSimpanan_anggota_istimewa_per_bulan = totalSimpanan_anggota_istimewa_per_bulan + saldoKas + saldoAkhir_kas
                '        'If totalSimpanan_anggota_istimewa_per_bulan > 0 Then
                '        '    saldoAkhir_kas = totalSimpanan_anggota_istimewa_per_bulan
                '        '    totalSimpanan_anggota_istimewa_per_bulan = 0
                '        'End If
                '    Else
                '        If saldoKas < 0 Then
                '            totalSimpanan_anggota_istimewa_per_bulan = totalSimpanan_anggota_istimewa_per_bulan + saldoKas + saldoAkhir_kas
                '        End If
                '        'totalSimpanan_anggota_istimewa_per_bulan = totalSimpanan_anggota_istimewa_per_bulan + saldoKas + saldoAkhir_kas
                '        'totalSimpanan_anggota_istimewa_per_bulan = 0
                '    End If
                'End If
                'saldoAkhir_kas = saldoKas + totalSimpanan_anggota_istimewa_per_bulan + saldoAkhir_kas
                'If saldoAkhir_kas < 0 Then
                '    saldoAkhir_kas = 0
                'ElseIf totalSimpanan_anggota_istimewa_per_bulan >= saldoKas Then
                '    saldoAkhir_kas = 0
                'Else
                '    'saldoAkhir_kas = saldoKas + totalSimpanan_anggota_istimewa_per_bulan + saldoAkhir_kas
                '    'saldoAkhir_kas = saldoAkhir_kas
                '    'totalSimpanan_anggota_istimewa_per_bulan = 0
                'End If
                DgvSimpanan.Rows.Add(d.ToUpper, totalSimpanan_per_bulan, totalPinjaman_per_bulan, totalAngsuran_per_bulan, totalBunga_per_bulan, saldoKas, -totalSimpanan_anggota_istimewa_per_bulan, saldoAkhir_kas)
            Next
        Catch ex As Exception

        End Try
       
        

    End Sub
    Private Sub simpananAkhirTahun()
        Dim tahun1 As Integer = tahun - 1
        'mencari simpanan anggota
        Dim sqltSimpanan As String
        'sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
        sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where kredit <> 305 AND year(tgl_simpan)<= " & tahun1 & ""
        Dim dtsimpanan As New DataTable
        Dim dbsimpanan As New CDataBase
        dtsimpanan = dbsimpanan.selectDB(sqltSimpanan)
        If dtsimpanan.Rows.Count > 0 Then
            If IsDBNull(dtsimpanan(0)(0)) = True Then
                totalSimpanan_per_akhir = 0
            Else
                totalSimpanan_per_akhir = dtsimpanan(0)(0)
            End If
            ' MsgBox(totalSimpanan_per_bulan)
        End If
        'mencari angsuran
        Dim sqltAngsuran As String
        sqltAngsuran = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 102 and  year(tgl_bayar)<= " & tahun1 & ""
        Dim dt_Angsuran As New DataTable
        Dim dbangsuran As New CDataBase
        dt_Angsuran = dbangsuran.selectDB(sqltAngsuran)
        If dt_Angsuran.Rows.Count > 0 Then
            If IsDBNull(dt_Angsuran(0)(0)) = True Then
                totalAngsuran_per_akhir = 0
            Else
                totalAngsuran_per_akhir = dt_Angsuran(0)(0)
            End If
            ' MsgBox(totalAngsuran_per_bulan)
        End If
        Dim sqltBunga As String
        sqltBunga = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = 500 and year(tgl_bayar)<= " & tahun1 & ""
        Dim dtbunga As New DataTable
        Dim dbbunga As New CDataBase
        dtbunga = dbbunga.selectDB(sqltBunga)
        If dtbunga.Rows.Count > 0 Then
            If IsDBNull(dtbunga(0)(0)) = True Then
                totalBunga_per_akhir = 0
            Else
                totalBunga_per_akhir = dtbunga(0)(0)
            End If
        End If
        'mencari pinjaman
        Dim sqtlPinjaman As String
        'sqtlPinjaman = " select SUM(jumlah_pinjam) as jumlah_pinjam from Koperasi_Detail_Pinjaman " & _
        '               "where convert(date,tglPinjam)<= '" & Format(z, "yyyy-MM-dd") & "'"
        sqtlPinjaman = "select SUM(jumlah_pinjam) as jumlah_pinjam from Koperasi_Detail_Pinjaman where year(tglPinjam)<= " & tahun1 & ""
        Dim dt_pinjaman As New DataTable
        Dim db_pinjaman As New CDataBase
        dt_pinjaman = db_pinjaman.selectDB(sqtlPinjaman)
        If dt_pinjaman.Rows.Count > 0 Then
            If IsDBNull(dt_pinjaman(0)(0)) = True Then
                totalPinjaman_per_akhir = 0
            Else
                totalPinjaman_per_akhir = dt_pinjaman(0)(0)
            End If
        End If

        saldoKas1 = totalSimpanan_per_akhir - totalPinjaman_per_akhir + totalAngsuran_per_akhir + totalBunga_per_akhir
        saldoAkhir_kas1 = saldoAkhir_kas1 + saldoKas1 + totalSimpanan_anggota_istimewa_per_bulan
    End Sub

    Private Sub DgvSimpanan_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSimpanan.CellClick
        ToolTip1.ToolTipTitle = "halooooo"
    End Sub


    
    Private Sub DgvSimpanan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSimpanan.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        tahun = 2015
        saldoAkhir_kas1 = 0
        saldoKas1 = 0
        saldoAkhir_kas = 0
        saldoKas = 0
        DgvSimpanan.Rows.Clear()
        SimpananYoki()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        tahun = 2016
        saldoAkhir_kas1 = 0
        saldoKas1 = 0
        saldoAkhir_kas = 0
        saldoKas = 0
        DgvSimpanan.Rows.Clear()
        SimpananYoki()
    End Sub

    Private Sub DgvSimpanan_CellMouseMove(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgvSimpanan.CellMouseMove
        ToolTip1.ToolTipTitle = "haloo"

    End Sub

    Private Sub ToolTip1_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup
        Dim isi
        isi = "coba tooltip"
    End Sub

    Sub DgvSimpanan_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DgvSimpanan.CellFormatting
        'colum :
        ' 1 : Bulan
        ' 2 : Simpanan
        ' 3 : Pinjaman
        ' 4 : Angsuran
        ' 5 : Pendapatan Bunga
        ' 6 : Saldo Kas
        ' 7 : Hutang VMG
        ' 8 : Saldo Akhir
        ' Dim isi As String
        Try
            With DgvSimpanan.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If e.Value.Equals("0") Then
                    .ToolTipText = "very bad"
                ElseIf e.Value.Equals("**") Then
                    .ToolTipText = "bad"

                ElseIf e.Value.Equals("***") Then
                    .ToolTipText = "good"

                ElseIf e.Value.Equals("****") Then
                    .ToolTipText = "very good"

                Else
                    If e.ColumnIndex = 1 Then
                        ListBox1.Items.Clear()
                        Dim sqltSimpanan As String
                        sqltSimpanan = " select k.NICK_KARYAWAN, s.jumlah from Koperasi_Simpanan s" & _
                                       " left join KARYAWAN_MF k on k.NIP_KARYAWAN = s.nip_anggota " & _
                                       " where month(s.tgl_simpan)= " & e.RowIndex + 1 & " and kredit <> " & _
                                       " 305 AND year(tgl_simpan)= " & tahun & ""
                        Dim dtsimpanan As New DataTable
                        Dim dbsimpanan As New CDataBase
                        dtsimpanan = dbsimpanan.selectDB(sqltSimpanan)
                        For s = 0 To dtsimpanan.Rows.Count - 1
                            ListBox1.Items.Add(dtsimpanan(s)(0) & " " & dtsimpanan(s)(1))
                        Next
                    End If
                End If

            End With
        Catch ex As Exception
        End Try

    End Sub
    Private Sub DgvSimpanan_MouseHover(sender As Object, e As System.EventArgs) Handles DgvSimpanan.MouseHover
        'Me.ToolTip1.SetToolTip(Me.Cursor, "halo2")

        'Dim hit As DataGridView.HitTestInfo = DgvSimpanan.HitTest(e.)
        'If hit.Type = DataGridViewHitTestType.Cell Then

        '    If Not hit Is m_HoveredItem Then
        '        Me.ToolTip1.Hide(Me.DgvSimpanan)
        '        '  m_HoveredItem = hit
        '        If hit Is Nothing Then

        '        Else
        '            'Me.ToolTip2.SetToolTip(Me.DataGridView1, ConnectedUsers(Me.DataGridView1.Rows(hit.RowIndex).Cells("Database").Value, Instance))
        '            'Me.ToolTip1.Show(ConnectedUsers(Me.DgvSimpanan.Rows(hit.RowIndex).Cells("Database").Value, Instance), DgvSimpanan, e.X, e.Y)
        '        End If
        '    End If

        'End If
    End Sub

    Private Sub DgvSimpanan_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DgvSimpanan.MouseMove

    End Sub
End Class