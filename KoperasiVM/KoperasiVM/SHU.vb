Public Class SHU
    Dim nip_anggota As String
    Dim nama_anggota As String
    Dim simp_bulanan As Integer
    Private Sub SHU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Membagi_Pendapatan_Bunga()

    End Sub
    Private Sub Simpanan_Anggota_per_bulan()
        DGVSHU.Rows.Clear()
        Dim sqlt As String
        sqlt = "select a.nip, k.NAMA_KARYAWAN from Koperasi_Anggota a " & _
               "left join KARYAWAN_MF k on a.nip = k.NIP_KARYAWAN  order by k.NAMA_KARYAWAN"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                nip_anggota = dt(i)(0)
                nama_anggota = dt(i)(1)
                DGVSHU.Rows.Add(nama_anggota)
                For a As Integer = 1 To 12
                    Dim sqlt_simpanan_bln As String
                    sqlt_simpanan_bln = "select SUM(jumlah) from Koperasi_Simpanan where nip_anggota = '" & nip_anggota & "' " & _
                        "and month(tgl_simpan) = '" & a & "'"
                    Dim dt_Simpanan_bln As New DataTable
                    Dim db_simpanan_bln As New CDataBase
                    dt_Simpanan_bln = db_simpanan_bln.selectDB(sqlt_simpanan_bln)
                    If dt_Simpanan_bln.Rows.Count > 0 Then
                        'simp_bulanan = dt_Simpanan_bln(0)(0)
                        If IsDBNull(dt_Simpanan_bln(0)(0)) = True Then
                            simp_bulanan = 0
                        Else
                            simp_bulanan = dt_Simpanan_bln(0)(0)
                        End If
                        'DGVSHU.Columns.Add(a, simp_bulanan)
                        DGVSHU.Item(a, i).Value = Format(simp_bulanan, "N0")
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub simpanan_anggota_total_perbulan()
        DGVSHU.Rows.Clear()
        Dim sqlt As String
        sqlt = "select a.nip, k.NAMA_KARYAWAN from Koperasi_Anggota a " & _
               "left join KARYAWAN_MF k on a.nip = k.NIP_KARYAWAN  order by k.NAMA_KARYAWAN"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim z As Date
                Dim tahun As Integer = 2015
                nip_anggota = dt(i)(0)
                nama_anggota = dt(i)(1)
                DGVSHU.Rows.Add(nama_anggota)
                For a As Integer = 1 To 12
                    z = DateSerial(tahun, a + 1, 0)
                    Dim sqlt_simpanan_bln As String
                    sqlt_simpanan_bln = "select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "' and nip_anggota = '" & nip_anggota & "'"
                    Dim dt_Simpanan_bln As New DataTable
                    Dim db_simpanan_bln As New CDataBase
                    dt_Simpanan_bln = db_simpanan_bln.selectDB(sqlt_simpanan_bln)
                    If dt_Simpanan_bln.Rows.Count > 0 Then
                        'simp_bulanan = dt_Simpanan_bln(0)(0)
                        If IsDBNull(dt_Simpanan_bln(0)(0)) = True Then
                            simp_bulanan = 0
                        Else
                            simp_bulanan = dt_Simpanan_bln(0)(0)
                        End If
                        'DGVSHU.Columns.Add(a, simp_bulanan)
                        DGVSHU.Item(a, i).Value = Format(simp_bulanan, "N0")
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Simpanan_Anggota_per_bulan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simpanan_anggota_total_perbulan()
    End Sub
End Class