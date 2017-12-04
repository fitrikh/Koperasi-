Public Class Rekap_Simpanan
    Dim tahun As Integer
    Dim totalSimpanan_pokok_per_bulan As Integer
    Dim totalSimpanan_wajib_per_bulan As Integer
    Dim totalSimpanan_sukarela_per_bulan As Integer
    Dim totalSimpanan As Integer
    Private Sub Rekap_Simpanan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "KOPERASI VINCENT MAESTRO GROUP" & vbCrLf & "Laporan Rekap Koperasi" & vbCrLf & "Per " & Format(Today, "dd MMMM yyyy")
        rekap_bulanan()
    End Sub
    Private Sub rekap_bulanan()
        Try
            For i = 1 To 12
                Dim z As Date
                tahun = 2015
                z = DateSerial(tahun, i + 1, 0)
                Dim sqltSimpanan As String
                'sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
                sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where month(tgl_simpan)= " & i & " and kredit = 401"
                Dim dtsimpanan As New DataTable
                Dim dbsimpanan As New CDataBase
                dtsimpanan = dbsimpanan.selectDB(sqltSimpanan)
                If dtsimpanan.Rows.Count > 0 Then
                    If IsDBNull(dtsimpanan(0)(0)) = True Then
                        totalSimpanan_pokok_per_bulan = 0
                    Else
                        totalSimpanan_pokok_per_bulan = dtsimpanan(0)(0)
                    End If
                    ' MsgBox(totalSimpanan_per_bulan)
                End If


                Dim sqltSimpanan_wajib As String
                'sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
                sqltSimpanan_wajib = " select SUM(jumlah) from Koperasi_Simpanan where month(tgl_simpan)= " & i & " and kredit = 402"
                Dim dtsimpanan_wajib As New DataTable
                Dim dbsimpanan_wajib As New CDataBase
                dtsimpanan_wajib = dbsimpanan_wajib.selectDB(sqltSimpanan_wajib)
                If dtsimpanan_wajib.Rows.Count > 0 Then
                    If IsDBNull(dtsimpanan_wajib(0)(0)) = True Then
                        totalSimpanan_wajib_per_bulan = 0
                    Else
                        totalSimpanan_wajib_per_bulan = dtsimpanan_wajib(0)(0)
                    End If
                    ' MsgBox(totalSimpanan_per_bulan)
                End If

                Dim sqltSimpanan_sukarela As String
                'sqltSimpanan = " select SUM(jumlah) from Koperasi_Simpanan where convert(date,tgl_simpan)<= '" & Format(z, "yyyy-MM-dd") & "'"
                sqltSimpanan_sukarela = " select SUM(jumlah) from Koperasi_Simpanan where month(tgl_simpan)= " & i & " and kredit = 301"
                Dim dtsimpanan_sukarela As New DataTable
                Dim dbsimpanan_sukarela As New CDataBase
                dtsimpanan_sukarela = dbsimpanan_sukarela.selectDB(sqltSimpanan_sukarela)
                If dtsimpanan_sukarela.Rows.Count > 0 Then
                    If IsDBNull(dtsimpanan_sukarela(0)(0)) = True Then
                        totalSimpanan_sukarela_per_bulan = 0
                    Else
                        totalSimpanan_sukarela_per_bulan = dtsimpanan_sukarela(0)(0)
                    End If
                    ' MsgBox(totalSimpanan_per_bulan)
                End If
                Dim d As String
                d = MonthName(i, True)
                totalSimpanan = totalSimpanan_pokok_per_bulan + totalSimpanan_sukarela_per_bulan + totalSimpanan_wajib_per_bulan
                DGVsimpanan.Rows.Add(d.ToUpper, totalSimpanan_pokok_per_bulan, totalSimpanan_wajib_per_bulan, totalSimpanan_sukarela_per_bulan, totalSimpanan)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class