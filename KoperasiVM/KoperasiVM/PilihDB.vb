Public Class PilihDB

    Private xmldatabase As String = My.Application.Info.DirectoryPath & "\xmldata.xml"

    Private Sub PilihDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xmldatabase) = True Then
            Xmldataset.ReadXml(xmldatabase)
        End If
    End Sub

    Private Sub DatabasenyaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabasenyaBindingNavigatorSaveItem.Click
        Me.Validate()
        DatabasenyaBindingSource.EndEdit()
        Xmldataset.WriteXml(xmldatabase)
    End Sub

    Private Sub dataTabel()
        Dim sqlt As String
        sqlt = "select id,jenis,alamat from databasenya"
        Dim dt As New DataTable
        'Dim  As New XCData

    End Sub
End Class