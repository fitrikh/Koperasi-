Public Class CKoneksi
    Private conn As String
    Private report As String

    Public Property ConnectDB() As String
        Get
            Return conn
        End Get
        Set(ByVal Value As String)
            conn = Value
        End Set
    End Property

    Public Property reportPath() As String
        Get
            Return report
        End Get
        Set(ByVal Value As String)
            report = Value
        End Set
    End Property

    Public Sub New()
        'conn = "Integrated Security=SSPI;Packet Size=4096;Data Source=DION\SQLEXPRESS;Tag with column collation when possible=False;Initial Catalog=dbVM;Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider=SQLOLEDB.1;Workstation ID=DION;Use Encryption for Data=False"
        'conn = "Provider=SQLOLEDB.1;Data Source=handa-pc\SQLEXPRESS;Initial Catalog=dbvm10;Integrated Security=true User;ID='root';Password=''"
        'conn = "Provider=SQLOLEDB.1;Data Source=192.168.0.3\SQLEXPRESS;Initial Catalog=dbVM;Persist Security Info=True;User ID=sa;Password=SQLServer2008"
        'conn = "Provider=SQLOLEDB.1;Data Source=EDP\SQLEXPRESS;Initial Catalog=dbVM;User ID=sa;pwd=sql"
        'conn = "Auto Translate=True;Integrated Security=SSPI;User ID=ANDRY-39D81825A;Data Source=ANDRY-39D81825A\SQLEXPRESS;Tag with column collation when possible=False;Initial Catalog=dbVM;Use Procedure for Prepare=1;Provider=SQLOLEDB.1;Persist Security Info=False;Workstation ID=ANDRY-39D81825A;Use Encryption for Data=False;Packet Size=4096"
        '#fitri >>> konekdatabase online

        'conn = "Data Source=FITRI\SQLEXPRESS;Initial Catalog=dbvm;Integrated Security=True"
        conn = "Provider=SQLOLEDB;Data Source=FITRI\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=dbvm"
        'conn = "Database=dbvm;" & "Data Source=handa-pc\SQLEXPRESS;" & "User Id='root';Password='';allow zero datetime=yes"
        'conn = "Database=vincentm_oshopvm;" & "Data Source=localhost;" & "User Id='root';Password='';allow zero datetime=yes"
        'conn = "Database= vincentm_oshopvm;" & "Data Source=localhost;" & "User Id='root';Password='';allow zero datetime=yes"
    End Sub
End Class
