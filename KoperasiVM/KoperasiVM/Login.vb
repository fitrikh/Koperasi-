Public Class Login

    
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtNip.Text = "" Or TxtPass.Text = "" Then
            MsgBox("pengisian harus legkap")
        Else
            Dim sqlt As String
            sqlt = "select NIP_KARYAWAN,NICK_KARYAWAN from KARYAWAN_MF where NIP_KARYAWAN = '" & TxtNip.Text & "'" & _
                   " and PASS_KARYAWAN = '" & TxtPass.Text & "'"
            Dim dt As New DataTable
            Dim db As New CDataBase
            dt = db.selectDB(sqlt)
            If dt.Rows.Count > 0 Then
                nipAdmin = TxtNip.Text
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("Akun anda salah")
            End If
        End If
    End Sub

    
End Class