<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Discounttxtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Detailslstbx = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Totaltxtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alan's Pizzeria"
        '
        'Discounttxtbx
        '
        Me.Discounttxtbx.Location = New System.Drawing.Point(25, 229)
        Me.Discounttxtbx.Name = "Discounttxtbx"
        Me.Discounttxtbx.Size = New System.Drawing.Size(100, 20)
        Me.Discounttxtbx.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Self Pick-up Discount"
        '
        'Detailslstbx
        '
        Me.Detailslstbx.FormattingEnabled = True
        Me.Detailslstbx.Location = New System.Drawing.Point(25, 90)
        Me.Detailslstbx.Name = "Detailslstbx"
        Me.Detailslstbx.Size = New System.Drawing.Size(397, 121)
        Me.Detailslstbx.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Order Details"
        '
        'Totaltxtbx
        '
        Me.Totaltxtbx.Location = New System.Drawing.Point(25, 279)
        Me.Totaltxtbx.Name = "Totaltxtbx"
        Me.Totaltxtbx.Size = New System.Drawing.Size(100, 20)
        Me.Totaltxtbx.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total Amount"
        '
        'Closebtn
        '
        Me.Closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.Location = New System.Drawing.Point(302, 263)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(116, 43)
        Me.Closebtn.TabIndex = 20
        Me.Closebtn.Text = "Close"
        Me.Closebtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 289)
        Me.Panel1.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PizzaCW.My.Resources.Resources.PizzaAboutBox
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(449, 342)
        Me.Controls.Add(Me.Closebtn)
        Me.Controls.Add(Me.Totaltxtbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Discounttxtbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Detailslstbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Discounttxtbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Detailslstbx As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Totaltxtbx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Closebtn As Button
    Friend WithEvents Panel1 As Panel
End Class
