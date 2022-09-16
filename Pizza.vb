Public Class Pizza
    Private PizzaFlavour As Flavour
    Private PizzaPrice As Decimal
    Private PizzaTopping() As String
    Private toppings(3) As Topping
    Public Property Flavour As Flavour
        Get
            Return PizzaFlavour
        End Get
        Set(value As Flavour)
            PizzaFlavour = value
            PizzaPrice = value.Price
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return PizzaPrice
        End Get
        Set(value As Decimal)
            PizzaPrice = value
        End Set
    End Property

    Public Sub SetToppingVar()
        Dim topping() As String = {"Cheese", "Mushroom", "Olive", "Pepperoni"}
        Dim price() As Decimal = {3, 2, 2, 3.5}

        For i As Integer = 0 To 3
            toppings(i) = New Topping
            toppings(i).Topping = topping(i)
            toppings(i).Price = price(i)
        Next
    End Sub

    Public Function CalTopping(ByVal cheese As Boolean, ByVal mushroom As Boolean,
                         ByVal olive As Boolean, ByVal pepperoni As Boolean)
        SetToppingVar()
        Dim i As Integer
        i = 0
        PizzaPrice = PizzaFlavour.Price
        If cheese Then
            PizzaPrice = PizzaPrice + toppings(0).Price
            ReDim Preserve PizzaTopping(i)
            PizzaTopping(i) = toppings(0).Topping
            i = i + 1
        End If
        If mushroom Then
            PizzaPrice = PizzaPrice + toppings(1).Price
            ReDim Preserve PizzaTopping(i)
            PizzaTopping(i) = toppings(1).Topping
            i = i + 1
        End If
        If olive Then
            PizzaPrice = PizzaPrice + toppings(2).Price
            ReDim Preserve PizzaTopping(i)
            PizzaTopping(i) = toppings(2).Topping
            i = i + 1
        End If
        If pepperoni Then
            PizzaPrice = PizzaPrice + toppings(3).Price
            ReDim Preserve PizzaTopping(i)
            PizzaTopping(i) = toppings(3).Topping
            i = i + 1
        End If
        Return PizzaTopping
    End Function

End Class
