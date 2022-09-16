Public Class Topping
    Private PizzaTopping As String
    Private ToppingPrice As Decimal

    Public Property Topping() As String
        Get
            Return PizzaTopping
        End Get
        Set(value As String)
            PizzaTopping = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return ToppingPrice
        End Get
        Set(value As Decimal)
            ToppingPrice = value
        End Set
    End Property
End Class
