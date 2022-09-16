Public Class Form1
    'Variables
    Dim pizzas(3) As Flavour
    Dim SelectedPizza As Pizza
    Dim SelectedTopping() As String
    Dim SelectedPrice As Decimal
    Dim SelectedDesc As String
    Public Total As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Codes that has to be initialized the moment the form runs
        SetPizzaVar()
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        GroupBox1.BackColor = Color.FromArgb(120, 0, 0, 0)
        GroupBox2.BackColor = Color.FromArgb(120, 0, 0, 0)
        GroupBox1.ForeColor = Color.White
        GroupBox2.ForeColor = Color.White
        Pizzalstbx.Font = New Font("Lucida Handwriting", 8)
        Basketlstbx.Font = New Font("Lucida Handwriting", 8)

        With SelfPickupbtn
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With
        VeggieLoverbtn.BackColor = Color.Transparent
        VeggieLoverbtn.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        AlohaChickenbtn.BackColor = Color.Transparent
        AlohaChickenbtn.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        FlamingTunabtn.BackColor = Color.Transparent
        FlamingTunabtn.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        UltimateHawaiianbtn.BackColor = Color.Transparent
        UltimateHawaiianbtn.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)

        Cheesecbx.BackColor = Color.Transparent
        Cheesecbx.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        Mushroomcbx.BackColor = Color.Transparent
        Mushroomcbx.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        Olivecbx.BackColor = Color.Transparent
        Olivecbx.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)
        Pepperonicbx.BackColor = Color.Transparent
        Pepperonicbx.Font = New Font("Lucida Handwriting", 8, FontStyle.Bold)

        With Label1
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With
        With Label2
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With
        With Label3
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With
        With Label4
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With
        With Label5
            .BackColor = Color.FromArgb(120, 0, 0, 0)
            .ForeColor = Color.White
        End With

        AddBasketbtn.ForeColor = Color.White
        AddBasketbtn.BackColor = Color.DarkGreen
        Orderbtn.ForeColor = Color.White
        Orderbtn.BackColor = Color.DarkGreen
        Clearbtn.ForeColor = Color.White
        Clearbtn.BackColor = Color.DarkGreen
        Exitbtn.ForeColor = Color.White
        Exitbtn.BackColor = Color.DarkGreen

    End Sub

    'Add Basket Button
    Private Sub AddBasketbtn_Click(sender As Object, e As EventArgs) Handles AddBasketbtn.Click
        FlavourCheck()
        'Selects the flavour string from the selected flavour
        Try
            SelectedDesc = SelectedPizza.Flavour.Flavour
        Catch
            MessageBox.Show("You must select a flavour")
            Exit Sub
        End Try
        Pizzalstbx.Items.Clear()

        'Boolean empty topping, will set to false if user selects a topping
        Dim EmptyArray As Boolean
        EmptyArray = True
        If Cheesecbx.Checked Or Mushroomcbx.Checked Or Olivecbx.Checked Or Pepperonicbx.Checked Then
            EmptyArray = False
        End If


        'If the topping array is empty, the program will crash if I run the loop
        'So the EmptyArray if else statement is to detect and circumvent the crash by having an alternative process
        If EmptyArray Then
            SelectedPrice = SelectedPizza.Price
        Else
            'Call the method for calculating topping price and returns list of selected toppings
            SelectedTopping = SelectedPizza.CalTopping(Cheesecbx.Checked, Mushroomcbx.Checked,
                                                       Olivecbx.Checked, Pepperonicbx.Checked)
            PizzaToppingMerge()
            SelectedPrice = SelectedPizza.Price
        End If

        Total = Total + SelectedPrice
        'To update both listboxes
        Pizzalstbx.Items.Add(SelectedDesc)
        Pizzalstbx.Items.Add("$" + Convert.ToString(SelectedPrice))
        Basketlstbx.Items.Add(SelectedDesc)
        Basketlstbx.Items.Add("$" + Convert.ToString(SelectedPrice))
        'To display the price
        Subtotaltxtbx.Text = "$" + Convert.ToString(SelectedPrice)
        Totaltxtbx.Text = "$" + Convert.ToString(Total)
    End Sub

    'Order Function
    Private Sub Orderbtn_Click(sender As Object, e As EventArgs) Handles Orderbtn.Click
        Form2.ShowDialog()
        Form2.ClearAll()
    End Sub
    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Form2.ShowDialog()
        Form2.ClearAll()
    End Sub


    'Exit Function
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    'Clear Function
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        ClearAll()
    End Sub
    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        ClearAll()
    End Sub


    'About Box
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub


    'Flavour List
    Private Sub SetPizzaVar()
        'To do: Refactor this part to Flavour file to reduce complexity
        'Set pizza array with all flavours selection.
        Dim flavour() As String = {"Veggie Lover", "Ultimate Hawaiian", "Aloha Chicken", "Flaming Tuna"}
        Dim price() As Decimal = {20, 25, 30, 35}

        'Loop to create the flavour object one by one.
        For i As Integer = 0 To pizzas.Length - 1
            pizzas(i) = New Flavour
            pizzas(i).Flavour = flavour(i)
            pizzas(i).Price = price(i)
        Next
    End Sub


    'Flavour check
    Private Sub FlavourCheck()
        If VeggieLoverbtn.Checked Then
            SelectedPizza = New Pizza
            SelectedPizza.Flavour = pizzas(0)
        ElseIf UltimateHawaiianbtn.Checked Then
            SelectedPizza = New Pizza
            SelectedPizza.Flavour = pizzas(1)
        ElseIf AlohaChickenbtn.Checked Then
            SelectedPizza = New Pizza
            SelectedPizza.Flavour = pizzas(2)
        ElseIf FlamingTunabtn.Checked Then
            SelectedPizza = New Pizza
            SelectedPizza.Flavour = pizzas(3)
        End If
    End Sub


    'Clear all & reset subroutine
    Private Sub ClearAll()
        'Clear the listboxes & texts
        Basketlstbx.Items.Clear()
        Pizzalstbx.Items.Clear()
        Totaltxtbx.Text = Nothing
        Subtotaltxtbx.Text = Nothing
        PictureBox1.Image = Nothing

        'Clear the variables
        SelectedPizza = Nothing
        Total = 0

        'Uncheck all the radio buttons and checkboxes
        Mushroomcbx.CheckState = CheckState.Unchecked
        Cheesecbx.CheckState = CheckState.Unchecked
        Olivecbx.CheckState = CheckState.Unchecked
        Pepperonicbx.CheckState = CheckState.Unchecked
        SelfPickupbtn.Checked = False
        VeggieLoverbtn.Checked = False
        AlohaChickenbtn.Checked = False
        UltimateHawaiianbtn.Checked = False
        FlamingTunabtn.Checked = False
    End Sub


    'Pizza/topping string concatenation 
    Private Sub PizzaToppingMerge()
        SelectedDesc = SelectedDesc + " with"
        For i As Integer = 0 To SelectedTopping.Length - 1
            If SelectedTopping.Length = 1 Then
                SelectedDesc = SelectedDesc + " " + SelectedTopping(i)
            ElseIf i = SelectedTopping.Length - 1 Then
                SelectedDesc = SelectedDesc + " and " + SelectedTopping(i)
            Else
                SelectedDesc = SelectedDesc + " " + SelectedTopping(i) + ","
            End If
        Next
    End Sub


    Private Sub VeggieLoverbtn_CheckedChanged(sender As Object, e As EventArgs) Handles VeggieLoverbtn.CheckedChanged
        If VeggieLoverbtn.Checked Then
            PictureBox1.Image = My.Resources.VeggieLover
        End If
    End Sub

    Private Sub UltimateHawaiianbtn_CheckedChanged(sender As Object, e As EventArgs) Handles UltimateHawaiianbtn.CheckedChanged
        If UltimateHawaiianbtn.Checked Then
            PictureBox1.Image = My.Resources.UltimateHawaiian
        End If
    End Sub

    Private Sub AlohaChickenbtn_CheckedChanged(sender As Object, e As EventArgs) Handles AlohaChickenbtn.CheckedChanged
        If AlohaChickenbtn.Checked Then
            PictureBox1.Image = My.Resources.AlohaChicken
        End If
    End Sub

    Private Sub FlamingTunabtn_CheckedChanged(sender As Object, e As EventArgs) Handles FlamingTunabtn.CheckedChanged
        If FlamingTunabtn.Checked Then
            PictureBox1.Image = My.Resources.FlamingTuna
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
