Public Class TutupBuku
    Dim d As Date
    Dim bulan As Integer
    Dim tahun As Integer
    Private Sub TutupBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_bulan.SelectedIndex = bulan - 1
        bulan = Month(Now)
        tahun = Year(Now)
    End Sub
    Private Sub pencairan()
        d = DateSerial(tahun, bulan, 3)
        MsgBox(d)
    End Sub

   
End Class