Public Class DaftarAnggota
    Dim dvnama As DataView
    Private Sub DaftarAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        karyawanVM()
    End Sub

    Private Sub karyawanVM()
        Dim sqlt As String
        sqlt = " select k.NIP_KARYAWAN,K.NAMA_KARYAWAN " & _
               "from KARYAWAN_MF K " & _
               "where(K.STS_AKTIF = 1) " & _
               "and K.NIP_KARYAWAN not in (select nip from Koperasi_Anggota) " & _
               " order by K.Nama_Karyawan "
        Dim dt As New DataTable
        Dim db As New CDataBase
        dt = db.selectDB(sqlt)
        If dt.Rows.Count > 0 Then
            Dim nips As String
            Dim namas As String
            For i = 0 To dt.Rows.Count - 1
                nips = dt(i)(0)
                namas = dt(i)(1)
                'MsgBox(namas & nips)
                Dtkaryawan.Rows.Add(nips, namas)
            Next
            'Dtkaryawan.AutoGenerateColumns = False
            'Dtkaryawan.DataSource = dt
            'Dtkaryawan.Columns(0).DataPropertyName = dt.Columns(0).ColumnName
            'Dtkaryawan.Columns(1).DataPropertyName = dt.Columns(1).ColumnName
            'Dtkaryawan.Columns(2).DataPropertyName = dt.Columns(2).ColumnName
        End If
    End Sub
    Private Sub tambahAnggota()
        Dim nip2 As String
        Dim nama As String
        nip2 = Dtkaryawan.Item(0, Dtkaryawan.CurrentRow.Index).Value
        nama = Dtkaryawan.Item(1, Dtkaryawan.CurrentRow.Index).Value
        DtAnggota.Rows.Add(nip2, nama, "SILVER", "Rp 10.000/bulan", "Rp 300.000")
        Dtkaryawan.Rows.RemoveAt(Dtkaryawan.CurrentRow.Index)
    End Sub
    Private Sub simpan()
        If DtAnggota.Rows.Count > 0 Then
            For i = 0 To DtAnggota.Rows.Count - 1
                Dim sqlt As String
                sqlt = " select max(id)+1 from koperasi_anggota "
                Dim dt As New DataTable
                Dim db As New CDataBase
                dt = db.selectDB(sqlt)
                Dim idagg As Integer
                If dt.Rows.Count > 0 Then
                    idagg = dt(0)(0)
                End If
                Dim nipx As String = DtAnggota.Item(0, i).Value
                Dim namax As String = "anggota"
                Dim sqltTambah As String
                sqltTambah = " insert into koperasi_anggota(id,nip,status,posisi,tgl_gabung) values('" & idagg & "','" & nipx & "','1','" & namax & "','" & Format(Now, "yyyy-MM-dd") & "')"
                Dim dbtambah As New CDataBase
                If dbtambah.insertDB(sqltTambah) = True Then
                    Dim sqltidhistory As String
                    sqltidhistory = " select max(idhistory)+1 from koperasi_history_keanggotaan"
                    Dim dtidhistory As New DataTable
                    Dim dbidhistory As New CDataBase
                    dtidhistory = dbidhistory.selectDB(sqltidhistory)
                    Dim idm As Integer
                    If dtidhistory.Rows.Count > 0 Then
                        idm = dtidhistory(0)(0)
                    End If
                    Dim jnsAnggota As Integer
                    If DtAnggota.Item(2, i).Value = "BRONZE" Then
                        jnsAnggota = 0
                    ElseIf DtAnggota.Item(2, i).Value = "SILVER" Then
                        jnsAnggota = 1
                    ElseIf DtAnggota.Item(2, 1).Value = "GOLD" Then
                        jnsAnggota = 2
                    ElseIf DtAnggota.Item(2, i).Value = "PLATINUM" Then
                        jnsAnggota = 3
                    End If
                    Dim sqltambahhistory As String
                    sqltambahhistory = " insert into koperasi_History_keanggotaan(idhistory,idanggota,jnsAnggota,tglSimpan,nipPetugas) values ('" & idm & "','" & idagg & "','" & jnsAnggota & "','" & Format(Now, "yyyy-MM-dd") & "','230305') "
                    Dim dbtambahhistory As New CDataBase
                    If dbtambahhistory.insertDB(sqltambahhistory) = True Then
                    Else
                        MsgBox("history gagal")
                    End If
                Else
                    MsgBox("gagal")
                End If
            Next
        End If
        DtAnggota.Rows.Clear()
        karyawanVM()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        tambahAnggota()
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        simpan()
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        If DtAnggota.Rows.Count > 0 Then
            Dim nipt As String
            Dim namat As String
            nipt = DtAnggota.Item(0, DtAnggota.CurrentRow.Index).Value
            namat = DtAnggota.Item(1, DtAnggota.CurrentRow.Index).Value
            DtAnggota.Rows.RemoveAt(DtAnggota.CurrentRow.Index)
            Dtkaryawan.Rows.Add(nipt, namat)
            Dtkaryawan.Sort(Dtkaryawan.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DtAnggota_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DtAnggota.EditingControlShowing
        If DtAnggota.CurrentCell.ColumnIndex = 2 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            ' Remove an existing event-handler, if present, to avoid 
            ' adding multiple handlers when the editing control is reused.
            RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            '' Add the event handler. 
            AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
        End If
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        If combo.Text = "SILVER" Then
            DtAnggota.Item(3, DtAnggota.CurrentRow.Index).Value = "Rp 10.000/bulan"
            DtAnggota.Item(4, DtAnggota.CurrentRow.Index).Value = "Rp 300.000"
        ElseIf combo.Text = "GOLD" Then
            DtAnggota.Item(3, DtAnggota.CurrentRow.Index).Value = "Rp 50.000/bulan"
            DtAnggota.Item(4, DtAnggota.CurrentRow.Index).Value = "Rp 1.500.000"
        ElseIf combo.Text = "PLATINUM" Then
            DtAnggota.Item(3, DtAnggota.CurrentRow.Index).Value = "Rp 100.000/bulan"
            DtAnggota.Item(4, DtAnggota.CurrentRow.Index).Value = "Rp 3.000.000"
        Else
            DtAnggota.Item(3, DtAnggota.CurrentRow.Index).Value = "0"
            DtAnggota.Item(4, DtAnggota.CurrentRow.Index).Value = "0"
        End If
        'Console.WriteLine("Row: {0}, Value: {1}", DataGridView1.CurrentCell.RowIndex, combo.SelectedItem)
    End Sub
End Class