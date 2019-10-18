Public Class ClsEntPembayaran
    Private idPem As String
    Private noinduk As String
    Private tgl As Date
    Private bln As String
    Private biaya As Integer
    Private user As String

    Public Property IdPembayaran As String
        Get
            Return idPem
        End Get
        Set(value As String)
            idPem = value
        End Set
    End Property

    Public Property nisn As String
        Get
            Return noinduk
        End Get
        Set(value As String)
            noinduk = value
        End Set
    End Property

    Public Property tanggal As Date
        Get
            Return tgl
        End Get
        Set(value As Date)
            tgl = value
        End Set
    End Property

    Public Property bulan As String
        Get
            Return bln
        End Get
        Set(value As String)
            bln = value
        End Set
    End Property

    Public Property spp As Integer
        Get
            Return biaya
        End Get
        Set(value As Integer)
            biaya = value
        End Set
    End Property

    Public Property username As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property
End Class
