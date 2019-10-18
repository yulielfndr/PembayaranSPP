Public Class ClsEntPetugas
    Private usrname As String
    Private nama As String
    Private pswrd As String

    Public Property Username() As String
        Get
            Return usrname
        End Get
        Set(value As String)
            usrname = value
        End Set
    End Property

    Public Property namaPetugas() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return pswrd
        End Get
        Set(value As String)
            pswrd = value
        End Set
    End Property
End Class
