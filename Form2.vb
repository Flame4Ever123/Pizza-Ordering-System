Public Class Form2
    Dim Discount As Decimal
    Dim Total As Decimal
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Closebtn.ForeColor = Color.White
        Closebtn.BackColor = Color.DarkGreen
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
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        Detailslstbx.Font = New Font("Lucida Handwriting", 8)
        Detailslstbx.Items.AddRange(Form1.Basketlstbx.Items)
        Total = Form1.Total
        If Form1.SelfPickupbtn.Checked Then
            Total = Total * 0.9
            Discounttxtbx.Text = "$" + Convert.ToString(Form1.Total - Total)
        Else
            Discounttxtbx.Text = "No Discount"
        End If
        Totaltxtbx.Text = "$" + Convert.ToString(Total)
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        ClearAll()
        Me.Close()
    End Sub

    Public Sub ClearAll()
        'Clear all fields in form 2
        Detailslstbx.Items.Clear()
        Discounttxtbx.Text = Nothing
        Totaltxtbx.Text = Nothing
    End Sub

    Private Sub Detailslstbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Detailslstbx.SelectedIndexChanged

    End Sub
End Class