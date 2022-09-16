<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pepperonicbx = New System.Windows.Forms.CheckBox()
        Me.Olivecbx = New System.Windows.Forms.CheckBox()
        Me.Mushroomcbx = New System.Windows.Forms.CheckBox()
        Me.Cheesecbx = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlamingTunabtn = New System.Windows.Forms.RadioButton()
        Me.AlohaChickenbtn = New System.Windows.Forms.RadioButton()
        Me.UltimateHawaiianbtn = New System.Windows.Forms.RadioButton()
        Me.VeggieLoverbtn = New System.Windows.Forms.RadioButton()
        Me.Pizzalstbx = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddBasketbtn = New System.Windows.Forms.Button()
        Me.Basketlstbx = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Totaltxtbx = New System.Windows.Forms.TextBox()
        Me.Subtotaltxtbx = New System.Windows.Forms.TextBox()
        Me.SelfPickupbtn = New System.Windows.Forms.RadioButton()
        Me.Orderbtn = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.OrderToolStripMenuItem.Text = "&Order"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem.Text = "&Clear All"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pizza"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Pepperonicbx)
        Me.GroupBox1.Controls.Add(Me.Olivecbx)
        Me.GroupBox1.Controls.Add(Me.Mushroomcbx)
        Me.GroupBox1.Controls.Add(Me.Cheesecbx)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 45)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toppings"
        '
        'Pepperonicbx
        '
        Me.Pepperonicbx.AutoSize = True
        Me.Pepperonicbx.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pepperonicbx.Location = New System.Drawing.Point(352, 20)
        Me.Pepperonicbx.Name = "Pepperonicbx"
        Me.Pepperonicbx.Size = New System.Drawing.Size(125, 19)
        Me.Pepperonicbx.TabIndex = 6
        Me.Pepperonicbx.Text = "Pepperoni - $3.5"
        Me.Pepperonicbx.UseVisualStyleBackColor = True
        '
        'Olivecbx
        '
        Me.Olivecbx.AutoSize = True
        Me.Olivecbx.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Olivecbx.Location = New System.Drawing.Point(250, 20)
        Me.Olivecbx.Name = "Olivecbx"
        Me.Olivecbx.Size = New System.Drawing.Size(84, 19)
        Me.Olivecbx.TabIndex = 5
        Me.Olivecbx.Text = "Olive - $2"
        Me.Olivecbx.UseVisualStyleBackColor = True
        '
        'Mushroomcbx
        '
        Me.Mushroomcbx.AutoSize = True
        Me.Mushroomcbx.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mushroomcbx.Location = New System.Drawing.Point(114, 20)
        Me.Mushroomcbx.Name = "Mushroomcbx"
        Me.Mushroomcbx.Size = New System.Drawing.Size(117, 19)
        Me.Mushroomcbx.TabIndex = 4
        Me.Mushroomcbx.Text = "Mushroom - $2"
        Me.Mushroomcbx.UseVisualStyleBackColor = True
        '
        'Cheesecbx
        '
        Me.Cheesecbx.AutoSize = True
        Me.Cheesecbx.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cheesecbx.Location = New System.Drawing.Point(6, 20)
        Me.Cheesecbx.Name = "Cheesecbx"
        Me.Cheesecbx.Size = New System.Drawing.Size(92, 19)
        Me.Cheesecbx.TabIndex = 0
        Me.Cheesecbx.Text = "Cheese - $3"
        Me.Cheesecbx.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlamingTunabtn)
        Me.GroupBox2.Controls.Add(Me.AlohaChickenbtn)
        Me.GroupBox2.Controls.Add(Me.UltimateHawaiianbtn)
        Me.GroupBox2.Controls.Add(Me.VeggieLoverbtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(263, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 175)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pizza"
        '
        'FlamingTunabtn
        '
        Me.FlamingTunabtn.AutoSize = True
        Me.FlamingTunabtn.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlamingTunabtn.Location = New System.Drawing.Point(6, 141)
        Me.FlamingTunabtn.Name = "FlamingTunabtn"
        Me.FlamingTunabtn.Size = New System.Drawing.Size(151, 19)
        Me.FlamingTunabtn.TabIndex = 8
        Me.FlamingTunabtn.TabStop = True
        Me.FlamingTunabtn.Text = "Flaming Tuna - $35"
        Me.FlamingTunabtn.UseVisualStyleBackColor = True
        '
        'AlohaChickenbtn
        '
        Me.AlohaChickenbtn.AutoSize = True
        Me.AlohaChickenbtn.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlohaChickenbtn.Location = New System.Drawing.Point(6, 102)
        Me.AlohaChickenbtn.Name = "AlohaChickenbtn"
        Me.AlohaChickenbtn.Size = New System.Drawing.Size(148, 19)
        Me.AlohaChickenbtn.TabIndex = 7
        Me.AlohaChickenbtn.TabStop = True
        Me.AlohaChickenbtn.Text = "Aloha Chicken - $30"
        Me.AlohaChickenbtn.UseVisualStyleBackColor = True
        '
        'UltimateHawaiianbtn
        '
        Me.UltimateHawaiianbtn.AutoSize = True
        Me.UltimateHawaiianbtn.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltimateHawaiianbtn.Location = New System.Drawing.Point(6, 59)
        Me.UltimateHawaiianbtn.Name = "UltimateHawaiianbtn"
        Me.UltimateHawaiianbtn.Size = New System.Drawing.Size(183, 19)
        Me.UltimateHawaiianbtn.TabIndex = 6
        Me.UltimateHawaiianbtn.TabStop = True
        Me.UltimateHawaiianbtn.Text = "Ultimate Hawaiian - $25"
        Me.UltimateHawaiianbtn.UseVisualStyleBackColor = True
        '
        'VeggieLoverbtn
        '
        Me.VeggieLoverbtn.AutoSize = True
        Me.VeggieLoverbtn.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VeggieLoverbtn.Location = New System.Drawing.Point(6, 19)
        Me.VeggieLoverbtn.Name = "VeggieLoverbtn"
        Me.VeggieLoverbtn.Size = New System.Drawing.Size(135, 19)
        Me.VeggieLoverbtn.TabIndex = 5
        Me.VeggieLoverbtn.TabStop = True
        Me.VeggieLoverbtn.Text = "Veggie Lover - $20"
        Me.VeggieLoverbtn.UseVisualStyleBackColor = True
        '
        'Pizzalstbx
        '
        Me.Pizzalstbx.FormattingEnabled = True
        Me.Pizzalstbx.Location = New System.Drawing.Point(13, 278)
        Me.Pizzalstbx.Name = "Pizzalstbx"
        Me.Pizzalstbx.Size = New System.Drawing.Size(499, 43)
        Me.Pizzalstbx.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subtotal"
        '
        'AddBasketbtn
        '
        Me.AddBasketbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBasketbtn.Location = New System.Drawing.Point(392, 337)
        Me.AddBasketbtn.Name = "AddBasketbtn"
        Me.AddBasketbtn.Size = New System.Drawing.Size(120, 47)
        Me.AddBasketbtn.TabIndex = 8
        Me.AddBasketbtn.Text = "Add To Basket"
        Me.AddBasketbtn.UseVisualStyleBackColor = True
        '
        'Basketlstbx
        '
        Me.Basketlstbx.FormattingEnabled = True
        Me.Basketlstbx.Location = New System.Drawing.Point(13, 399)
        Me.Basketlstbx.Name = "Basketlstbx"
        Me.Basketlstbx.Size = New System.Drawing.Size(499, 121)
        Me.Basketlstbx.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Basket"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total"
        '
        'Totaltxtbx
        '
        Me.Totaltxtbx.Location = New System.Drawing.Point(13, 543)
        Me.Totaltxtbx.Name = "Totaltxtbx"
        Me.Totaltxtbx.Size = New System.Drawing.Size(178, 20)
        Me.Totaltxtbx.TabIndex = 11
        '
        'Subtotaltxtbx
        '
        Me.Subtotaltxtbx.Location = New System.Drawing.Point(14, 353)
        Me.Subtotaltxtbx.Name = "Subtotaltxtbx"
        Me.Subtotaltxtbx.Size = New System.Drawing.Size(177, 20)
        Me.Subtotaltxtbx.TabIndex = 13
        '
        'SelfPickupbtn
        '
        Me.SelfPickupbtn.AutoSize = True
        Me.SelfPickupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelfPickupbtn.Location = New System.Drawing.Point(383, 539)
        Me.SelfPickupbtn.Name = "SelfPickupbtn"
        Me.SelfPickupbtn.Size = New System.Drawing.Size(123, 24)
        Me.SelfPickupbtn.TabIndex = 14
        Me.SelfPickupbtn.TabStop = True
        Me.SelfPickupbtn.Text = "Self Pick-up"
        Me.SelfPickupbtn.UseVisualStyleBackColor = True
        '
        'Orderbtn
        '
        Me.Orderbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orderbtn.Location = New System.Drawing.Point(19, 590)
        Me.Orderbtn.Name = "Orderbtn"
        Me.Orderbtn.Size = New System.Drawing.Size(102, 47)
        Me.Orderbtn.TabIndex = 15
        Me.Orderbtn.Text = "Order"
        Me.Orderbtn.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.Location = New System.Drawing.Point(216, 590)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(102, 47)
        Me.Clearbtn.TabIndex = 16
        Me.Clearbtn.Text = "Clear All"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbtn.Location = New System.Drawing.Point(404, 590)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(102, 47)
        Me.Exitbtn.TabIndex = 17
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(18, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Pizzalstbx)
        Me.Panel1.Controls.Add(Me.Subtotaltxtbx)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SelfPickupbtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Orderbtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Clearbtn)
        Me.Panel1.Controls.Add(Me.Totaltxtbx)
        Me.Panel1.Controls.Add(Me.Exitbtn)
        Me.Panel1.Controls.Add(Me.Basketlstbx)
        Me.Panel1.Controls.Add(Me.AddBasketbtn)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(16, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 659)
        Me.Panel1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PizzaCW.My.Resources.Resources.PizzaSplashScreen
        Me.ClientSize = New System.Drawing.Size(565, 713)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pepperonicbx As CheckBox
    Friend WithEvents Olivecbx As CheckBox
    Friend WithEvents Mushroomcbx As CheckBox
    Friend WithEvents Cheesecbx As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlamingTunabtn As RadioButton
    Friend WithEvents AlohaChickenbtn As RadioButton
    Friend WithEvents UltimateHawaiianbtn As RadioButton
    Friend WithEvents VeggieLoverbtn As RadioButton
    Friend WithEvents Pizzalstbx As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddBasketbtn As Button
    Friend WithEvents Basketlstbx As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Totaltxtbx As TextBox
    Friend WithEvents Subtotaltxtbx As TextBox
    Friend WithEvents SelfPickupbtn As RadioButton
    Friend WithEvents Orderbtn As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
