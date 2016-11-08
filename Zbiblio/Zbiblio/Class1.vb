Public Class Film
#Region "Attributs"
    Private _titre As String
    Private _dureeHeure As Integer
    Private _dureeMinute As Integer
    Private _realisateur As String
    Private _description As String
    Private _acteurPrincipal As String
    Private _nombreDeFilm As Integer
    Private _note As Integer

#End Region

#Region "Propriétés"
    Public Property titres() As String
        Get
            Return _titre
        End Get
        Set(value As String)
            _titre = value
        End Set
    End Property

    Public Property dureeHeure() As Integer
        Get
            Return _dureeHeure
        End Get
        Set(value As Integer)
            _dureeHeure = value
        End Set
    End Property
    Public Property dureeMinute() As Integer
        Get
            Return _dureeMinute
        End Get
        Set(value As Integer)
            _dureeMinute = value
        End Set
    End Property

    Public Property realisateur() As String
        Set(value As String)
            _realisateur = value
        End Set
        Get
            Return _realisateur
        End Get
    End Property

    Public Property description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property acteurPrincipal() As String
        Get
            Return _realisateur
        End Get
        Set(value As String)
            _realisateur = value
        End Set
    End Property

    Public Property note() As Integer

#End Region
End Class
