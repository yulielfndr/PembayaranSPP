Public Class ClsEntAngkatan
    Private kode As String
    Private angkatan As String
    Private spp As Integer

    Public Property KodeAngktn As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property Angktn As String
        Get
            Return angkatan
        End Get
        Set(value As String)
            angkatan = value
        End Set
    End Property

    Public Property bSpp As Integer
        Get
            Return spp
        End Get
        Set(value As Integer)
            spp = value
        End Set
    End Property
End Class
