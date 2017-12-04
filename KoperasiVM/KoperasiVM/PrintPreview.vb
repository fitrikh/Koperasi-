Imports Microsoft.Reporting.WinForms
Public Class PrintPreview
    Public nama_cetak As String
    Public nip_cetak As String
    Public tgl_cetak As Date
    Public jml_cicilan_cetak As String
    Public alasan_cetak As String
    Public jumlah_pinjaman_cetak As Integer


    Private Sub PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        jml_cicilan_cetak = InputBox("Berapakah Jumlah Cicilan yang Diinginkan? ", "Input Jumlah Cicilan")
        If jml_cicilan_cetak = "" Then
            jml_cicilan_cetak = 0
        Else
            jml_cicilan_cetak = jml_cicilan_cetak & " kali Angsuran"
        End If
        Dim nama As New ReportParameter("Par_Nama", nama_cetak)
        Dim nip_ctk As New ReportParameter("Nip_anggota", nip_cetak)
        Dim tgL_ajukan As New ReportParameter("tgl_cetak_acc", Format(tgl_cetak, "dd MMM yyyy"))
        Dim jml_pinjam As New ReportParameter("jml_pinjam", jumlah_pinjaman_cetak)
        Dim alasan As New ReportParameter("alasan_cetak", alasan_cetak)
        Dim cicil As New ReportParameter("jml_cicil_cetak", jml_cicilan_cetak)
        ReportViewer1.LocalReport.SetParameters(nama)
        ReportViewer1.LocalReport.SetParameters(nip_ctk)
        ReportViewer1.LocalReport.SetParameters(tgL_ajukan)
        ReportViewer1.LocalReport.SetParameters(jml_pinjam)
        ReportViewer1.LocalReport.SetParameters(alasan)
        ReportViewer1.LocalReport.SetParameters(cicil)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class