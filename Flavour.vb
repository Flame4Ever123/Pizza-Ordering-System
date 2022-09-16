Public Class Flavour
    Private PizzaFlavour As String
    Private PizzaPrice As Decimal
    Public Property Flavour() As String
        Get
            Return PizzaFlavour
        End Get
        Set(value As String)
            PizzaFlavour = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return PizzaPrice
        End Get
        Set(value As Decimal)
            PizzaPrice = value
        End Set
    End Property
End Class
