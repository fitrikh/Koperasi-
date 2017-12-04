Public Class Pinjaman
    Public nippeminjam As String
    Public namapeminjam As String
    Dim pokokbulan As Decimal
    Dim bungabulan As Decimal
    Dim idAngsuran As Integer
    Dim totalbayar As Decimal
    Dim harini As DateTime
    Dim bunga As Decimal
    


   
    Private Sub Pinjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNama.Text = namapeminjam
        cariidpinjaman()
    End Sub

    Private Sub cariidpinjaman()
        Dim sqlt As String
        sqlt = "select MAX(idpinjam)+1 from Koperasi_Detail_Pinjaman"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            TxtIdPinjam.Text = dt(0)(0)
        End If
    End Sub
    Private Sub cariidangsuranterakhir()
        Dim sqlt As String
        sqlt = "select MAX(id_angsuran)+1 from Koperasi_Detail_Angsuran"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            idAngsuran = dt(0)(0)
        End If
    End Sub
    Private Sub perhitunganBungaFlat()
        pokokbulan = NumJmlPinjam.Value / NumLamaPinjam.Value
        bungabulan = (NumJmlPinjam.Value * NumBunga.Value) / (100)
        totalbayar = pokokbulan + bungabulan
    End Sub
    Private Sub insertdetailpinjaman()
        harini = Now
        bunga = ((NumJmlPinjam.Value * NumBunga.Value) / 100) * NumLamaPinjam.Value
        nip = "230305"
        Dim sqlt As String
        sqlt = " insert into Koperasi_Detail_Pinjaman" & _
               "(idpinjam,tglPinjam,nip_peminjam,jumlah_pinjam," & _
               "lama_pinjam,bunga,nip_petugas,jumlah_bayar) " & _
               "values ('" & TxtIdPinjam.Text & "','" & Format(Dtm.Value, "yyyy-MM-dd") & "','" & nippeminjam & "','" & NumJmlPinjam.Value & "','" & NumLamaPinjam.Value & "','" & bunga & "','" & nip & "','0')"
        Dim db As New CDataBase
        If db.insertDB(sqlt) = True Then
            hitungAngsuran()
        Else
            MsgBox("gagal")
        End If
    End Sub
    Private Sub hitungAngsuran()
        Dim a As Integer = 0
        For i = 0 To NumLamaPinjam.Value - 1
            Dim idA As Integer
            idA = i + 1
            Dim sqlt As String
            sqlt = "insert into Koperasi_Detail_Angsuran(id_angsuran,id_pinjaman,cicilan," & _
                   "jml_bunga,jml_angsuran,jumlah_bayar,tgl_bayar) " & _
                   "values('" & idA & "','" & TxtIdPinjam.Text & "','" & pokokbulan & "','" & bungabulan & "','" & totalbayar & "','0','1900-01-01 00:00')"
            Dim db As New CDataBase
            If db.insertDB(sqlt) = True Then
                a = a + 1
            Else
                'MsgBox("gagal")
            End If
        Next
        If a > 0 Then
            MsgBox("Pinjaman Telah Masuk Database")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    
   
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        perhitunganBungaFlat()
        cariidangsuranterakhir()
        insertdetailpinjaman()

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class