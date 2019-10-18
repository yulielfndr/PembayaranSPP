Public Class ClsEntSiswa
    Private noInduk As String
    Private nama As String
    Private alamat As String
    Private jeniskelamin As String
    Private namaOrtu As String
    Private alamatOrtu As String
    Private telpOrtu As String
    Private kelas As String
    Private angkatan As String

    Public Property nisn As String
        Get
            Return noInduk
        End Get
        Set(value As String)
            noInduk = value
        End Set
    End Property

    Public Property NamaS As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property AlamatS As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property JK As String
        Get
            Return jeniskelamin
        End Get
        Set(value As String)
            jeniskelamin = value
        End Set
    End Property

    Public Property NamaO As String
        Get
            Return namaOrtu
        End Get
        Set(value As String)
            namaOrtu = value
        End Set
    End Property

    Public Property AlamatO As String
        Get
            Return alamatOrtu
        End Get
        Set(value As String)
            alamatOrtu = value
        End Set
    End Property

    Public Property TelpO As String
        Get
            Return telpOrtu
        End Get
        Set(value As String)
            telpOrtu = value
        End Set
    End Property

    Public Property id_kelas As String
        Get
            Return kelas
        End Get
        Set(value As String)
            kelas = value
        End Set
    End Property

    Public Property id_angkatan As String
        Get
            Return angkatan
        End Get
        Set(value As String)
            angkatan = value
        End Set
    End Property
End Class
