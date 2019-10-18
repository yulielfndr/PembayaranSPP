Public Class ClsEntKelas
    Private idKel As String
    Private kel As String
    Private jur As String
    Private idAng As String

    Public Property IdKelas As String
        Get
            Return idKel
        End Get
        Set(value As String)
            idKel = value
        End Set
    End Property

    Public Property Kelas As String
        Get
            Return kel
        End Get
        Set(value As String)
            kel = value
        End Set
    End Property

    Public Property Jurusan As String
        Get
            Return jur
        End Get
        Set(value As String)
            jur = value
        End Set
    End Property

    Public Property IdAngkatan As String
        Get
            Return idAng
        End Get
        Set(value As String)
            idAng = value
        End Set
    End Property
End Class
