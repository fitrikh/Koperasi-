Public Class Form1
    Dim cicilan As Double
    Dim bunga As Double
    Dim waktu As Date
    Dim idAngs As Integer
    Dim idpinjaman As Integer
    Dim Bulan As Integer, Tahun As Integer, d As Date
    Dim idsetor
    Dim statusUser As String
    Dim totalSimpanan_per_bulan As Integer
    Dim totalAngsuran_per_bulan As Integer
    Dim totalPinjaman_per_bulan As Integer
    Dim totalSimpanan_anggota_istimewa_per_bulan As Integer

    Dim no_urut As Integer
    Dim nipAnggota As String
    Dim nama_Lengkap As String
    Dim namaPanggilan As String
    Dim devisi_anggota As String
    Dim status_anggota As String
    Dim simp_Pokok_anngota As Decimal
    Dim simp_wajib_anggota As Decimal
    Dim simp_sukarela_anggota As Decimal
    Dim SHU_anngota As Decimal
    Dim pinjaman As Decimal = 0
    Dim idPinjam As Integer
    Dim Angsuran_anggota_yg_Tersisa As Decimal = 0
    Dim Angsuran_anggota_yg_sudah_dibayar As Decimal = 0
    Dim jns_keanggotaan As String
    Dim tgl_Gabung As Date
    Dim tgl_masuk As Date
    Dim lamaKerja As Integer
    Dim sekarang As Date


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        statusUser = " "
        'anggota_koperasi()
        'jumlahSimpanan()
        'warnaKolom()
        ''Saldo()
        'headline()
        anggota_koperasi()
        paketan()
    End Sub
    Private Sub paketan()
        'jumlahSimpanan()
        warnaKolom()
        Saldo()
        headline()
    End Sub
    Private Sub warnaKolom()
        For i = 0 To DGVAnggota.Rows.Count - 1
            If DGVAnggota.Rows(i).Index Mod 2 = 0 Then
                DGVAnggota.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                DGVAnggota.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub anggota_koperasi()
        Dim lama As String
        sekarang = Now
        Dim sqlt As String
        sqlt = " select row_number() over (order by km.NAMA_KARYAWAN) as 'No', " & _
               " kk.nip, km.NAMA_KARYAWAN, km.NICK_KARYAWAN, dm.NAMA_DEVISI, a.jns_keanggotaan," & _
               " kk.tgl_gabung,km.TGLMULAIKERJA_KARYAWAN" & _
               " from Koperasi_Anggota kk left join KARYAWAN_MF km on kk.nip = km.NIP_KARYAWAN" & _
               " left join DETAIL_KARYAWAN d on d.nip_karyawan = kk.nip " & _
               " left join DEVISI_MF dm on dm.KODE_DEVISI = d.kode_devisi " & _
               " left join Koperasi_History_Keanggotaan h on h.idanggota = kk.id" & _
               " left join Koperasi_Jns_Anggota a on a.idhistory_jns_keanggotaan = h.jnsAnggota " & _
               " where d.tgl_berlaku = (select max(dd.tgl_berlaku) " & _
               " from DETAIL_KARYAWAN dd  where dd.nip_karyawan = d.nip_karyawan" & _
               " ) and " & _
               " h.idhistory = (select MAX(hh.idhistory) " & _
               " from Koperasi_History_Keanggotaan hh where hh.idanggota = h.idanggota)" & _
               " order by km.NAMA_KARYAWAN "
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                no_urut = dt(i)(0)
                nipAnggota = dt(i)(1)
                nama_Lengkap = dt(i)(2)
                namaPanggilan = dt(i)(3)
                devisi_anggota = dt(i)(4)
                jns_keanggotaan = dt(i)(5)
                tgl_Gabung = dt(i)("tgl_gabung")
                tgl_masuk = dt(i)("TGLMULAIKERJA_KARYAWAN")
                lamaKerja = sekarang.Year - tgl_masuk.Year
                lama = lamaKerja & " Tahun"
                If lamaKerja <= 0 Then
                    lamaKerja = sekarang.Month - tgl_masuk.Month
                    lama = lamaKerja & " Bulan"
                End If
                'MsgBox(lamaKerja)
                'cari simpanan pokok
                Dim sqlt_pokok As String
                sqlt_pokok = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nipAnggota & "' and kredit = '401'"
                Dim dt_pokok As New DataTable
                Dim db_pokok As New CDataBase
                dt_pokok = db_pokok.selectDB(sqlt_pokok)
                If dt_pokok.Rows.Count > 0 Then
                    If IsDBNull(dt_pokok(0)(0)) = True Then
                        simp_Pokok_anngota = 0
                    Else
                        simp_Pokok_anngota = dt_pokok(0)(0)
                    End If
                End If
                Dim sqlt_wajib As String
                sqlt_wajib = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nipAnggota & "' and kredit = '402'"
                Dim dt_wajib As New DataTable
                Dim db_wajib As New CDataBase
                dt_wajib = db_wajib.selectDB(sqlt_wajib)
                If dt_wajib.Rows.Count > 0 Then
                    If IsDBNull(dt_wajib(0)(0)) = True Then
                        simp_wajib_anggota = 0
                    Else
                        simp_wajib_anggota = dt_wajib(0)(0)
                    End If
                End If
                Dim sqlt_sukarela As String
                sqlt_sukarela = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nipAnggota & "' and kredit = '301'"
                Dim dt_sukarela As New DataTable
                Dim db_sukarela As New CDataBase
                dt_sukarela = db_sukarela.selectDB(sqlt_sukarela)
                If dt_sukarela.Rows.Count > 0 Then
                    If IsDBNull(dt_sukarela(0)(0)) = True Then
                        simp_sukarela_anggota = 0
                    Else
                        simp_sukarela_anggota = dt_sukarela(0)(0)
                    End If
                End If
                Dim sqlt_shu As String
                sqlt_shu = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nipAnggota & "' and kredit = '305'"
                Dim dt_shu As New DataTable
                Dim db_shu As New CDataBase
                dt_shu = db_shu.selectDB(sqlt_shu)
                If dt_shu.Rows.Count > 0 Then
                    If IsDBNull(dt_shu(0)(0)) = True Then
                        SHU_anngota = 0
                    Else
                        SHU_anngota = dt_shu(0)(0)
                    End If
                End If
                Dim sqlt_pinjam As String
                sqlt_pinjam = "select idpinjam,tglPinjam, nip_peminjam, jumlah_pinjam, lama_pinjam, bunga " & _
                              " from Koperasi_Detail_Pinjaman where nip_peminjam = '" & nipAnggota & "'"
                Dim dt_pinjam As New DataTable
                Dim db_pinjam As New CDataBase
                dt_pinjam = db_pinjam.selectDB(sqlt_pinjam)
                pinjaman = 0
                Angsuran_anggota_yg_sudah_dibayar = 0
                Angsuran_anggota_yg_Tersisa = 0
                If dt_pinjam.Rows.Count > 0 Then
                    For a = 0 To dt_pinjam.Rows.Count - 1
                        If IsDBNull(dt_pinjam(a)("jumlah_pinjam")) = True Then
                            pinjaman = 0
                        Else
                            pinjaman = dt_pinjam(a)("jumlah_pinjam")
                        End If
                        If IsDBNull(dt_pinjam(a)("idpinjam")) = True Then
                            idPinjam = 0
                        Else
                            idPinjam = dt_pinjam(a)("idpinjam")
                        End If
                        Dim sqlt_angsuran As String
                        sqlt_angsuran = "select sum(jumlah_bayar) from Koperasi_History_Angsuran where id_pinjam = '" & idPinjam & "' and jns_bayar = '102'"
                        Dim dt_angsuran As New DataTable
                        Dim db_angsuran As New CDataBase
                        dt_angsuran = db_angsuran.selectDB(sqlt_angsuran)
                        If dt_angsuran.Rows.Count > 0 Then
                            If IsDBNull(dt_angsuran(0)(0)) = True Then
                                Angsuran_anggota_yg_sudah_dibayar = 0
                            Else
                                Angsuran_anggota_yg_sudah_dibayar = dt_angsuran(0)(0)
                            End If
                            If pinjaman - Angsuran_anggota_yg_sudah_dibayar = 0 Then
                                pinjaman = 0
                                Angsuran_anggota_yg_Tersisa = 0
                            ElseIf pinjaman - Angsuran_anggota_yg_sudah_dibayar > 0 Then
                                Angsuran_anggota_yg_Tersisa = pinjaman - Angsuran_anggota_yg_sudah_dibayar
                            End If
                        End If
                    Next
                End If
                DGVAnggota.Rows.Add(no_urut, nipAnggota, nama_Lengkap, namaPanggilan, devisi_anggota, jns_keanggotaan, lama, Format(simp_Pokok_anngota, "N0"), Format(simp_wajib_anggota, "N0"), Format(simp_sukarela_anggota, "N0"), Format(SHU_anngota, "N0"), Format(pinjaman, "N0"), Format(Angsuran_anggota_yg_Tersisa, "N0"), "", tgl_Gabung)
            Next
        End If
    End Sub
    Private Sub Simpanan()
        'Dim tglsetor As Date
        'tglsetor = Date.DaysInMonth()
         'menampung hasil
        'MsgBox(d)
        Dim jmlsimpanan As Double = 100000
        Dim sqlt As String
        sqlt = " select row_number() over (order by km.NAMA_KARYAWAN) as 'No', " & _
               " kk.nip, km.NAMA_KARYAWAN, km.NICK_KARYAWAN, dm.NAMA_DEVISI, h.jnsAnggota," & _
               " kk.tgl_gabung " & _
               " from Koperasi_Anggota kk left join KARYAWAN_MF km on kk.nip = km.NIP_KARYAWAN" & _
               " left join DETAIL_KARYAWAN d on d.nip_karyawan = kk.nip " & _
               " left join DEVISI_MF dm on dm.KODE_DEVISI = d.kode_devisi " & _
               " left join Koperasi_History_Keanggotaan h on h.idanggota = kk.id" & _
               " left join Koperasi_Jns_Anggota a on a.idhistory_jns_keanggotaan = h.jnsAnggota " & _
               " where h.jnsAnggota <> 0 and d.tgl_berlaku = (select max(dd.tgl_berlaku) " & _
               " from DETAIL_KARYAWAN dd  where dd.nip_karyawan = d.nip_karyawan" & _
               " ) and km.STS_AKTIF = 1 and " & _
               " h.idhistory = (select MAX(hh.idhistory) " & _
               " from Koperasi_History_Keanggotaan hh where hh.idanggota = h.idanggota)" & _
               " order by km.NAMA_KARYAWAN "
        Dim dt As New DataTable
        Dim db As New CDataBase
        Dim nipKaryawan As String
        Dim idacount As Integer = 0
        Dim idJenisAnggota As Integer
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                'mencari apakah simpanan pokok telah dibayarkan sepenuhnya. maka saya harus menghitung jumlah simpanan pokok terlebih dahulu.
                nipKaryawan = dt(i)(1)
                idJenisAnggota = dt(i)(5)
                'MsgBox(nipKaryawan)
                Dim sqlt2 As String
                sqlt2 = "select SUM(s.jumlah)" & _
                        "from Koperasi_Simpanan s left join KARYAWAN_MF k " & _
                        "on s.nip_anggota = k.NIP_KARYAWAN " & _
                        "left join Koperasi_Account a " & _
                        "on a.id_account = s.Kredit " & _
                        "where s.Kredit = 401  and nip_anggota = '" & nipKaryawan & "'"
                Dim dt2 As New DataTable
                Dim db2 As New CDataBase
                Dim jumlah As Double
                dt2 = db2.selectDB(sqlt2)
                If dt2.Rows.Count > 0 Then
                    If IsDBNull(dt2(0)(0)) = True Then
                        jumlah = 0
                    Else
                        jumlah = dt2(0)(0)
                    End If
                    If jumlah >= 100000 Then
                        idacount = 402
                        ' mencari jumlah simpanan wajib anggota perbulan dengan kriteria mencari jenis keanggotaan
                        Dim sqltwajib As String
                        sqltwajib = " SELECT id_simpanan,jns_simpanan,jumlah,idjnsAnggota" & _
                                    " FROM Koperasi_Jenis_Simpanan s" & _
                                    " where noAccount = 402 and idjnsAnggota = '" & idJenisAnggota & "'" & _
                                    " and tglSimpan = (select MAX(ss.tglSimpan)" & _
                                    " from Koperasi_Jenis_Simpanan ss where s.idjnsAnggota = ss.idjnsAnggota) "
                        Dim dtwajib As New DataTable
                        Dim dbwajib As New CDataBase
                        dtwajib = dbwajib.selectDB(sqltwajib)
                        If dtwajib.Rows.Count > 0 Then
                            jmlsimpanan = dtwajib(0)(2)
                        End If
                        GoTo bayar
                    ElseIf jumlah = 0 Then
                        jmlsimpanan = 50000
                        idacount = 401
                        GoTo bayar
                    Else
                        jmlsimpanan = 100000 - jumlah
                        idacount = 401
                        GoTo bayar
                    End If
                Else
bayar:              Dim sqtid As String
                    sqtid = "select max(idsetor)+1 from koperasi_setor"
                    Dim dtid As New DataTable
                    Dim dbid As New CDataBase
                    dtid = dbid.selectDB(sqtid)
                    If dtid.Rows.Count > 0 Then
                        idsetor = dtid(0)(0)
                    End If
                    Dim sqltInsertblmbayar As String
                    sqltInsertblmbayar = "insert into Koperasi_setor(idsetor,nip,jumlah,jns_setor,tanggalPotong," & _
                                         "status_aktif,id_pinjam) values ('" & idsetor & "','" & nipKaryawan & "','" & jmlsimpanan & "','" & idacount & "','" & Format(d, "yyyy-MM-dd") & "','1','0')"
                    Dim dbinsertblmbayar As New CDataBase
                    If dbinsertblmbayar.insertDB(sqltInsertblmbayar) = True Then
                    Else
                        MsgBox("insert simpanan gagal")
                    End If
                End If
            Next
        End If
        MsgBox("selesai")
    End Sub
    Private Sub jumlahSimpanan()
        Dim nipA As String
        For i = 0 To DGVAnggota.Rows.Count - 1
            nipA = DGVAnggota.Item(1, i).Value
            Dim sqlt As String
            sqlt = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nipA & "'"
            Dim dt As New DataTable
            Dim db As New CDataBase
            dt = db.selectDB(sqlt)
            If dt.Rows.Count > 0 Then
                DGVAnggota.Item(6, i).Value = dt(0)(0)
                DGVAnggota.Columns(6).DefaultCellStyle.Format = "N"
                ' DGVAnggota.Columns(7).DefaultCellStyle.Format = "N"
            End If
            Dim sqlt2 As String
            sqlt2 = "select idpinjam,jumlah_pinjam as pinjaman,lama_pinjam from koperasi_detail_pinjaman where nip_peminjam = '" & nipA & "'"
            Dim dt2 As New DataTable
            Dim db2 As New CDataBase
            dt2 = db2.selectDB(sqlt2)
            If dt2.Rows.Count > 0 Then
                Dim idpin As Integer
                Dim jpinjam As Integer
                Dim lpinjam As Double
                For a = 0 To dt2.Rows.Count - 1
                    If IsDBNull(dt2(a)(0)) = True Then
                        DGVAnggota.Item(7, i).Value = 0
                    ElseIf dt2(a)(0) = 0 Then
                        DGVAnggota.Item(7, i).Value = 0
                    Else
                        idpin = dt2(a)(0)
                        jpinjam = dt2(a)(1)
                        lpinjam = dt2(a)(2)
                        Dim sqltAngsuran As String
                        sqltAngsuran = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where id_pinjam = '" & idpin & "' and jns_bayar = '102'"
                        Dim dtAngsuran As New DataTable
                        Dim dbAngsuran As New CDataBase
                        dtAngsuran = dbAngsuran.selectDB(sqltAngsuran)
                        Dim jAngsuran As Double
                        If dtAngsuran.Rows.Count > 0 Then
                            If IsDBNull(dtAngsuran(0)(0)) = True Then
                                jAngsuran = 0
                            Else
                                jAngsuran = dtAngsuran(0)(0)
                            End If
                            If jpinjam - jAngsuran <> 0 Then
                                DGVAnggota.Item(7, i).Value = jpinjam
                                DGVAnggota.Item(8, i).Value = jpinjam - jAngsuran
                            Else
                                DGVAnggota.Item(7, i).Value = 0
                            End If
                        End If
                        Dim sqqltLama As String
                        sqqltLama = " select count(jumlah_bayar) from Koperasi_History_Angsuran where id_pinjam = '" & idpin & "' and jns_bayar = '102'"
                        Dim dtlama As New DataTable
                        Dim dblama As New CDataBase
                        dtlama = dblama.selectDB(sqqltLama)
                        Dim upinjam As Integer
                        If dtlama.Rows.Count > 0 Then
                            upinjam = dtlama(0)(0)
                            If jpinjam - jAngsuran <> 0 Then
                                DGVAnggota.Item(9, i).Value = lpinjam - upinjam & " x"
                            End If

                        End If
                    End If
                Next
            Else
                DGVAnggota.Item(7, i).Value = "-"
            End If
        Next
        DGVAnggota.Columns(7).DefaultCellStyle.Format = "N0"
        DGVAnggota.Columns(8).DefaultCellStyle.Format = "N0"
        'Dim row As String() = New String() {"6309189", "Alfa Adhitya"}
        'DGVAnggota.Rows.Add(row)
    End Sub
    Private Sub Saldo()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer = 10000000
        Dim sqlt As String
        sqlt = "select SUM(jumlah) from Koperasi_Simpanan where kredit <> 305"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        a = dt(0)(0)

        Dim sqlt2 As String
        sqlt2 = " select sum(jumlah_bayar) from Koperasi_History_Angsuran where jns_bayar = '102'"
        Dim dt2 As New DataTable
        Dim db2 As New CDataBase
        dt2 = db2.selectDB(sqlt2)
        b = dt2(0)(0)

        Dim sqlt3 As String
        sqlt3 = "select SUM(jumlah_pinjam) from Koperasi_Detail_Pinjaman "
        Dim dt3 As New DataTable
        Dim db3 As New CDataBase
        dt3 = db3.selectDB(sqlt3)
        c = dt3(0)(0)

        With DGVSaldo
            Dim row As String() = New String() {"Jumlah Simpanan Anggota", Format(a, "N0")}
            Dim row2 As String() = New String() {"Bantuan dari VM Maximum", Format(d, "N0")}
            Dim row3 As String() = New String() {"Jumlah Pinjaman Anggota Tidak Termasuk Bunga", "(" & Format(c - b, "N0") & ")"}
            Dim row4 As String() = New String() {"Saldo Dana Koperasi", Format((a + b) - c, "N0")}
            .Rows.Clear()
            .Rows.Add(row)
            .Rows.Add(row3)
            .Rows.Add(row4)
            .Rows.Add(row2)
            'atau
        End With
    End Sub
    Private Sub headline()
        lblHeader.Text = "Koperasi Simpan Pinjam VMG " & vbCrLf & "Laporan Koperasi " & vbCrLf & " per " & Format(Now, "dd MMMM yyyy")
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Angsuran()
        Dim sqlt As String
        sqlt = " select idpinjam,tglPinjam, nip_peminjam, jumlah_pinjam, lama_pinjam, bunga " & _
               " from Koperasi_Detail_Pinjaman "
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        Dim idpinjam As Integer
        Dim tglpinjam As Date
        Dim nippeminjam As String
        Dim jumlah_pinjam As Double
        Dim lama_pinjam As Integer
        Dim bunga As Integer
        Dim jumlahangsuran
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                idpinjam = dt(i)("idpinjam")
                tglpinjam = dt(i)("tglPinjam")
                nippeminjam = dt(i)("nip_peminjam")
                jumlah_pinjam = dt(i)("jumlah_pinjam")
                lama_pinjam = dt(i)("lama_pinjam")
                bunga = dt(i)("bunga")
                ' kita cari jumlah angsuran anggota
                Dim sqlt1 As String
                sqlt1 = " select sum(jumlah_bayar) from Koperasi_History_Angsuran where id_pinjam = '" & idpinjam & "' and jns_bayar = '102'"
                Dim dt1 As New DataTable
                Dim db1 As New CDataBase
                dt1 = db1.selectDB(sqlt1)
                If dt1.Rows.Count > 0 Then
                    If IsDBNull(dt1(0)(0)) = True Then
                        jumlahangsuran = 0
                    Else
                        jumlahangsuran = dt1(0)(0)
                    End If
                    Dim jns_setor = 0
                    If jumlahangsuran < jumlah_pinjam Then
                        For a = 0 To 1
                            Dim sqtid As String
                            sqtid = "select max(idsetor)+1 from koperasi_setor"
                            Dim dtid As New DataTable
                            Dim dbid As New CDataBase
                            dtid = dbid.selectDB(sqtid)
                            If dtid.Rows.Count > 0 Then
                                idsetor = dtid(0)(0)
                            End If
                            If a = 0 Then
                                jumlahangsuran = jumlah_pinjam / lama_pinjam
                                jns_setor = 102
                            ElseIf a = 1 Then
                                jumlahangsuran = bunga / lama_pinjam
                                jns_setor = 500
                            End If
                            Dim sqlt3 As String
                            sqlt3 = " insert into Koperasi_setor(idsetor,nip,jumlah,jns_setor,tanggalPotong," & _
                                    "status_aktif,id_pinjam) values ('" & idsetor & "','" & nippeminjam & "','" & jumlahangsuran & "','" & jns_setor & "','" & Format(d, "yyyy-MM-dd") & "','1','" & idpinjam & "')"
                            Dim db3 As New CDataBase
                            If db3.insertDB(sqlt3) = True Then
                            Else
                                MsgBox("gagal insert Angsuran " & nippeminjam)
                            End If
                        Next
                    End If
                End If
            Next
        End If
        MsgBox("selesai")
    End Sub
    Private Sub penyesuaian()
        Dim sqlt As String
        sqlt = "select id,nip_anggota,kodeAccount,jumlah,tgl_penyesuaian,keterangan" & _
               " from Koperasi_Penyesuaian where tgl_penyesuaian = '" & Format(d, "yyyy-MM-dd") & "'"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            Dim id_anggota As Integer
            Dim kodeAkun As Integer
            Dim jmlPenyesuan As Decimal
            For i = 0 To dt.Rows.Count - 1
                id_anggota = dt(i)("nip_anggota")
                kodeAkun = dt(i)("kodeAccount")
                jmlPenyesuan = dt(i)("jumlah")
                'cari koperasi setor untuk disesuaikan
                Dim sqlt_setor
                sqlt_setor = "select idsetor,nip,jumlah,jns_setor,tanggalPotong from Koperasi_setor " & _
                             "where tanggalPotong = '" & Format(d, "yyyy-MM-dd") & "' and jns_setor = '" & kodeAkun & "'"
                Dim dtsetor As New DataTable
                Dim dbsetor As New CDataBase
                dtsetor = dbsetor.selectDB(sqlt_setor)
                'If dtsetor.Rows.Count > 0 Then
                '    Dim idset As Integer
                '    idset = "Update koperasi setor set jumlah = jumlah + '"& jmlPenyesuan &"' where idsetor = '"&  &"'"
                'End If
                MsgBox(id_anggota)
            Next
            ' MsgBox("")
        End If

    End Sub
    Private Sub TelahDibayarpembayaran()
        'sub ini mengenai hal-hal yang dibayarkan atau kewajiban yang telah dibayarkan oleh anggota
        'pembayaran ini terdiri dari simpanan pokok, simpanan wajib, simpanan sukarela, angsuran perbulan, bunga
        'mencari pembayaran simpanan pokok dan wajib  berdasarkan bulan yang berkaitan
        'Tabel yang berkaitan adalah tabel Koperasi_setor dan Koperasi_simpanan
        Dim bln As Integer = 6
        Dim sqlt As String
        sqlt = " select idsetor,nip,jumlah,tanggalPotong,jns_setor from Koperasi_setor " & _
               " where month(tanggalPotong) = '" & bln & "'" & _
               "and (jns_setor = 401 or jns_setor = 402) "
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            Dim sqltDel As String
            sqltDel = " delete from koperasi_simpanan where month(tgl_simpan) = '" & bln & "'"
            Dim dbDel As New CDataBase
            If dbDel.deleteDB(sqltDel) = True Then
                Dim idsetor As Integer
                Dim nipK As Integer
                Dim jumlahSetor As Double
                Dim tglPotong As Date
                Dim jns_setor As Integer
                Dim jnsSimpanan As Integer
                For i = 0 To dt.Rows.Count - 1
                    idsetor = dt(i)("idsetor")
                    nipK = dt(i)("nip")
                    jumlahSetor = dt(i)("jumlah")
                    tglPotong = dt(i)("tanggalPotong")
                    jns_setor = dt(i)("jns_setor")
                    Dim sqltIdmax As String
                    sqltIdmax = "select max(id)+1 from koperasi_simpanan"
                    Dim dtmax As New DataTable
                    Dim dbmax As New CDataBase
                    dtmax = dbmax.selectDB(sqltIdmax)
                    Dim idmax As Integer
                    If dtmax.Rows.Count > 0 Then
                        idmax = dtmax(0)(0)
                    End If
                    'cek jns setor utnuk membedakan pos yang harus dimasukan
                    '401 = simpanan pokok ==> tabel koperasi_simpanan
                    '402 = simpanan wajib ==> tabel koperasi_simpanan
                    '102 = Angsuran Anggota
                    '500 = Angsuran Bunga

                    If jns_setor = 401 Then
                        jnsSimpanan = 1
                        GoTo Simpanan
                    ElseIf jns_setor = 402 Then
                        jnsSimpanan = 2
Simpanan:               Dim sqltInsSimpanan
                        sqltInsSimpanan = "insert into Koperasi_Simpanan(id,tgl_simpan,nip_anggota,id_jns_simpanan,jumlah,nip_admin,Debit,Kredit,idSetor) " & _
                                          "values('" & idmax & "','" & tglPotong & "','" & nipK & "','" & jnsSimpanan & "','" & jumlahSetor & "','230305','101','" & jns_setor & "','" & idsetor & "')"
                        Dim dbInsSimpanan As New CDataBase
                        If dbInsSimpanan.insertDB(sqltInsSimpanan) = True Then
                        Else
                            MsgBox("Input data to Simpanan is failed")
                        End If
                    End If
                Next
            Else
                MsgBox("Wipe data Gagal")
            End If

        End If

    End Sub
    Private Sub SimpananYoki()
        Dim x As Integer
        Dim y As Integer
        Dim z As Date
        y = InputBox("Masukan Bulan", "Masukan Bulan", x)
        Tahun = 2015
        z = DateSerial(Tahun, y + 1, 0)
        'cari jumlah simpanan Anggota per bulan
        Dim sqltSimpanan As String
        sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
        Dim dtsimpanan As New DataTable
        Dim dbsimpanan As New CDataBase
        dtsimpanan = dbsimpanan.selectDB(sqltSimpanan)
        If dtsimpanan.Rows.Count > 0 Then
            If IsDBNull(dtsimpanan(0)(0)) = True Then
                totalSimpanan_per_bulan = 0
            Else
                totalSimpanan_per_bulan = dtsimpanan(0)(0)
            End If
            MsgBox(totalSimpanan_per_bulan)
        End If
        'mencari angsuran
        Dim sqltAngsuran As String
        sqltAngsuran = "select SUM(jumlah_bayar) from Koperasi_History_Angsuran where convert(date,tgl_bayar)<= '" & Format(z, "yyyy-MM-dd") & "'"
        Dim dt_Angsuran As New DataTable
        Dim dbangsuran As New CDataBase
        dt_Angsuran = dbangsuran.selectDB(sqltAngsuran)
        If dt_Angsuran.Rows.Count > 0 Then
            If IsDBNull(dt_Angsuran(0)(0)) = True Then
                totalAngsuran_per_bulan = 0
            Else
                totalAngsuran_per_bulan = dt_Angsuran(0)(0)
            End If
            MsgBox(totalAngsuran_per_bulan)
        End If
        'mencari pinjaman
        Dim sqtlPinjaman As String
        sqtlPinjaman = " select SUM(jumlah_pinjam) from Koperasi_Detail_Pinjaman " & _
                       "where convert(date,tglPinjam)<= '" & Format(z, "yyyy-MM-dd") & "'"
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
        MsgBox(totalPinjaman_per_bulan)
        'cari simpanan Anggota istimewa
        totalSimpanan_anggota_istimewa_per_bulan = totalSimpanan_per_bulan + totalAngsuran_per_bulan - totalPinjaman_per_bulan
        MsgBox(totalSimpanan_anggota_istimewa_per_bulan)

        If totalSimpanan_anggota_istimewa_per_bulan < 0 Then

        End If

    End Sub
    Private Sub waktuHariIni()
        waktu = Now
    End Sub
    Private Sub DGVAnggota_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAnggota.CellDoubleClick
        If statusUser = " " Then
            MsgBox("Mohon Maaf Anda Tidak Memiliki")
        Else
            Dim menu2 As New Menu
            menu2.nipAnggota = DGVAnggota.Item(1, DGVAnggota.CurrentRow.Index).Value
            menu2.namaAnggota = DGVAnggota.Item(2, DGVAnggota.CurrentRow.Index).Value
            menu2.tgl_gabung = DGVAnggota.Item(14, DGVAnggota.CurrentRow.Index).Value
            If menu2.ShowDialog = Windows.Forms.DialogResult.OK Then

            End If
        End If
        
    End Sub

    Private Sub DGVAnggota_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVAnggota.ColumnHeaderMouseClick
        paketan()
    End Sub

    Private Sub BtnTutupBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutupBuku.Click
        Bulan = Month(Now)
        Tahun = Year(Now)
        d = DateSerial(Tahun, Bulan + 1, 0)
        MsgBox(d)
        Simpanan()
        Angsuran()
        'penyesuaian()
    End Sub

    Private Sub BtnTagihan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTagihan.Click
        Dim ltagihan As New LaporanTagihan
        ltagihan.waktu = Month(Now)
        ltagihan.Show()
        'If ltagihan.ShowDialog = Windows.Forms.DialogResult.OK Then
        'End If
    End Sub
    Private Sub superadminPaket()
        BtnTagihan.Visible = True
        BtnTutupBuku.Visible = True
        DGVAnggota.Enabled = True
        btnDaftarPinjaman.Visible = True
        BtnTambah.Visible = True
        BTN_Pembayaran.Visible = True
        btn_aturan.Visible = True
    End Sub
    Private Sub adminPaket()
        BtnTagihan.Visible = True
        BtnTutupBuku.Visible = False
        DGVAnggota.Enabled = True
        btnDaftarPinjaman.Visible = True
        BtnTambah.Visible = True
        BTN_Pembayaran.Visible = False
        btn_aturan.Visible = True
    End Sub
    Private Sub nonAdmin()
        BtnTagihan.Visible = False
        BtnTutupBuku.Visible = False
        DGVAnggota.Enabled = False
        btnDaftarPinjaman.Visible = False
        BtnTambah.Visible = False
        BTN_Pembayaran.Visible = False
        btn_aturan.Visible = True
    End Sub
    Private Sub akunting()
        BtnTagihan.Visible = True
        BtnTutupBuku.Visible = False
        DGVAnggota.Enabled = False
        btnDaftarPinjaman.Visible = True
        BtnTambah.Visible = False
        BTN_Pembayaran.Visible = False
        btn_aturan.Visible = True
    End Sub
    Private Sub BtnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdmin.Click
        Dim log As New Login
        If BtnAdmin.Text = "Login" Then
            If log.ShowDialog = Windows.Forms.DialogResult.OK Then
                If nipAdmin = "230305" Then
                    superadminPaket()
                    BtnAdmin.Text = "Log  Out"
                    statusUser = "admin"
                ElseIf nipAdmin = "240901" Then
admin:              adminPaket()
                    BtnAdmin.Text = "Log  Out"
                    statusUser = "admin"
                ElseIf nipAdmin = "210103" Then
                    GoTo admin
                ElseIf nipAdmin = "000702" Then
                    GoTo admin
                ElseIf nipAdmin = "250908" Then
                    GoTo admin
                ElseIf nipAdmin = "250101" Then
                    akunting()
                Else
                    MsgBox("Mohon maaf anda tidak memiliki akses")
                End If
            End If
        ElseIf BtnAdmin.Text = "Log Out" Then
            nonAdmin()
            statusUser = " "
        Else
            nonAdmin()
            BtnAdmin.Text = "Login"
            statusUser = " "
            'MsgBox(BtnAdmin.Text)
        End If

    End Sub
    Private Sub btnDaftarPinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftarPinjaman.Click
        Dim daftar As New Daftar_Pinjaman
        If daftar.ShowDialog = Windows.Forms.DialogResult.OK Then
            anggota_koperasi()
            paketan()
        End If
    End Sub
    Private Sub DGVAnggota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAnggota.CellContentClick

    End Sub
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim tambah_Anggota As New DaftarAnggota
        If tambah_Anggota.ShowDialog = Windows.Forms.DialogResult.OK Then
            statusUser = " "
            anggota_koperasi()
            jumlahSimpanan()
            warnaKolom()
            Saldo()
            headline()
        End If
    End Sub
    Private Sub BtnYoki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYoki.Click
        'SimpananYoki()
        Dim datasimpanan As New SimpananVMG
        If datasimpanan.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
    Private Sub VMGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMGToolStripMenuItem.Click
        Dim datasimpanan As New SimpananVMG
        datasimpanan.Show()
        'If datasimpanan.ShowDialog = Windows.Forms.DialogResult.OK Then

        'End If
    End Sub

    
    Private Sub BTN_Pembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Pembayaran.Click
        TutupBuku.Show()
    End Sub

    Private Sub RekapSimpananToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RekapSimpananToolStripMenuItem.Click
        Dim s As New Rekap_Simpanan
        s.Show()
    End Sub

    Private Sub btn_aturan_Click(sender As System.Object, e As System.EventArgs) Handles btn_aturan.Click
        Peraturan.Show()
    End Sub
End Class
