Public Class ClsQuery
    Dim sqlt As String

    'Public Function Login(ByVal NIPTemp As String, ByVal passwordTemp As String) As Integer
    '    'Dim a As Integer = 0
    '    'sqlt = "SELECT nama, nickname, nip, posisi, statusAktif, password, JK FROM userAdmin WHERE nip = '" & NIPTemp & "' and password = '" & passwordTemp & "'"
    '    'Dim db As New CDataBaseMySQL
    '    'Dim dt As New DataTable
    '    'dt = db.selectDB(sqlt)
    '    'If dt.Rows.Count > 0 Then
    '    '    a = 1
    '    'End If
    '    'Return a
    'End Function

    'Public Function databaseWebProduct(ByVal idWebTemp As Integer) As DataTable
    '    'Dim dt As New DataTable
    '    'Dim db As New CDataBaseMySQL
    '    'sqlt = " SELECT " & _
    '    '            " p.product_id," & _
    '    '            " p.product_class_id," & _
    '    '            " p.tax_class_id," & _
    '    '            " p.marketPrice," & _
    '    '            " p.ogMeta," & _
    '    '            " p.useCustomOG," & _
    '    '            " p.price," & _
    '    '            " p.sku," & _
    '    '            " p.enabled," & _
    '    '            " p.weight," & _
    '    '            " p.useSeparateBox," & _
    '    '            " p.boxWidth," & _
    '    '            " p.boxLength," & _
    '    '            " p.boxHeight," & _
    '    '            " p.itemsPerBox," & _
    '    '            " p.free_shipping," & _
    '    '            " p.taxable," & _
    '    '            " p.javascript," & _
    '    '            " p.arrivalDate," & _
    '    '            " p.date," & _
    '    '            " p.updateDate," & _
    '    '            " p.attrSepTab," & _
    '    '            " p.cleanURL," & _
    '    '            " p.pinCodesEnabled," & _
    '    '            " p.autoPinCodes," & _
    '    '            " p.productVideo," & _
    '    '            " p.participateSale," & _
    '    '            " p.discountType," & _
    '    '            " p.salePriceValue " & _
    '    '            " FROM xc_products p where p.product_id = '" & idWebTemp & "' "
    '    'dt = db.selectDB(sqlt)
    '    'If dt.Rows.Count > 0 Then
    '    '    Return dt
    '    'Else
    '    '    Return Nothing
    '    'End If
    'End Function

    'Public Function databaseWebProductTranlation(ByVal IdWebTrans) As DataTable
    '    '    Dim dt As New DataTable
    '    '    Dim db As New CDataBaseMySQL
    '    '    sqlt = "SELECT name FROM xc_product_translations where id = '" & IdWebTrans & "'"
    '    '    dt = db.selectDB(sqlt)
    '    '    If dt.Rows.Count Then
    '    '        Return dt
    '    '    Else
    '    '        Return Nothing
    '    '    End If
    '    'End Function

    '    'Public Function databaseLamaLc(ByVal idLamaLc) As DataTable
    '    '    sqlt = " SELECT product_id," & _
    '    '           " product_sku," & _
    '    '           " product_name," & _
    '    '           " product_desc," & _
    '    '           " product_weight," & _
    '    '           " product_weight_uom," & _
    '    '           " product_price," & _
    '    '           " product_currency," & _
    '    '           " date_format(tglupdate,'%Y-%m-%d %T.%f') as tglUpdate," & _
    '    '           " salesPrice," & _
    '    '           " MaketPrice," &
    '    '           " s_desc," & _
    '    '           " product_idXcart," & _
    '    '           " statusEnabled," & _
    '    '           " statusOnline," & _
    '    '           " statusAktif," & _
    '    '           " salesPriceDiskon," & _
    '    '           " marketPriceDiskon, " & _
    '    '           " ifnull(keterangan,'')as ket, " & _
    '    '           " oleh FROM lc_produk_lama where product_idXcart = '" & idLamaLc & "'"
    '    '    Dim dt As New DataTable
    '    '    Dim db As New CDataBaseMySQL
    '    '    dt = db.selectDB(sqlt)
    '    '    If dt.Rows.Count > 0 Then
    '    '        Return dt
    '    '    Else
    '    '        Return Nothing
    '    '    End If
    '    'End Function
    '    'Public Function konversiMatauangAsing(ByVal simbolnegara) As DataTable
    '    '    Dim dt As New DataTable
    '    '    Dim db As New CDataBaseMySQL
    '    '    sqlt = " SELECT idHistory,negara,jenis,harga,tglUpdate,oleh,statusAktif FROM historyKurs k " & _
    '    '           " WHERE k.negara = '" & simbolnegara & "' and k.tglUpdate = (select max(tglUpdate)" & _
    '    '           " from historyKurs kk where k.negara = kk.negara and k.jenis = kk.jenis) "
    '    '    dt = db.selectDB(sqlt)
    '    '    If dt.Rows.Count > 0 Then
    '    '        Return dt
    '    '    Else
    '    '        Return Nothing
    '    '    End If
    '    'End Function
    '    'Public Function StatusUser(ByVal PosisiTemp As String) As DataTable
    '    '    Dim dt As New DataTable
    '    '    Dim db As New CDataBaseMySQL
    '    '    sqlt = "SELECT nama, nickname, nip, posisi, statusAktif, password, JK FROM userAdmin WHERE nip = '" & PosisiTemp & "' and `statusAktif` = '1'"
    '    '    dt = db.selectDB(sqlt)
    '    '    If dt.Rows.Count > 0 Then
    '    '        Return dt
    '    '    Else
    '    '        Return Nothing
    '    '    End If
    '    'End Function

End Class
