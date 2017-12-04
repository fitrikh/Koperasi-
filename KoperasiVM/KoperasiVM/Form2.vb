Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        simpanan()
    End Sub
    Private Sub simpanan()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim sqlt As String
        sqlt = "select SUM(jumlah) from Koperasi_Simpanan"
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        Label2.Text = dt(0)(0)
        a = dt(0)(0)
        Dim sqlt2 As String
        sqlt2 = " select sum(jumlah_bayar) from Koperasi_History_Angsuran "
        Dim dt2 As New DataTable
        Dim db2 As New CDataBase
        dt2 = db2.selectDB(sqlt2)
        b = dt2(0)(0)
        Label4.Text = dt2(0)(0)
        Dim sqlt3 As String
        sqlt3 = "select SUM(jumlah_pinjam) from Koperasi_Detail_Pinjaman "
        Dim dt3 As New DataTable
        Dim db3 As New CDataBase
        dt3 = db3.selectDB(sqlt3)
        Label6.Text = "(" & dt3(0)(0) & ")"
        c = dt3(0)(0)

        Label8.Text = (a + b) - c

    End Sub


End Class