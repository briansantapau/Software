<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_nueva_orden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_nueva_orden))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox_toppings = New System.Windows.Forms.TextBox()
        Me.txtbox_frosting = New System.Windows.Forms.TextBox()
        Me.txtbox_layers = New System.Windows.Forms.TextBox()
        Me.txtbox_dae = New System.Windows.Forms.TextBox()
        Me.txtbox_sabor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_costo = New System.Windows.Forms.TextBox()
        Me.txtbox_deposito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(135, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(23, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Anadir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtbox_toppings
        '
        Me.txtbox_toppings.Location = New System.Drawing.Point(110, 44)
        Me.txtbox_toppings.Name = "txtbox_toppings"
        Me.txtbox_toppings.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_toppings.TabIndex = 21
        '
        'txtbox_frosting
        '
        Me.txtbox_frosting.Location = New System.Drawing.Point(110, 71)
        Me.txtbox_frosting.Name = "txtbox_frosting"
        Me.txtbox_frosting.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_frosting.TabIndex = 22
        '
        'txtbox_layers
        '
        Me.txtbox_layers.Location = New System.Drawing.Point(110, 98)
        Me.txtbox_layers.Name = "txtbox_layers"
        Me.txtbox_layers.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_layers.TabIndex = 23
        '
        'txtbox_dae
        '
        Me.txtbox_dae.Location = New System.Drawing.Point(110, 12)
        Me.txtbox_dae.Name = "txtbox_dae"
        Me.txtbox_dae.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_dae.TabIndex = 24
        '
        'txtbox_sabor
        '
        Me.txtbox_sabor.Location = New System.Drawing.Point(110, 125)
        Me.txtbox_sabor.Name = "txtbox_sabor"
        Me.txtbox_sabor.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_sabor.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Dia a Entregar :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Toppings :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Frosting:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Layers:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Sabor:"
        '
        'txtbox_costo
        '
        Me.txtbox_costo.Location = New System.Drawing.Point(110, 151)
        Me.txtbox_costo.Name = "txtbox_costo"
        Me.txtbox_costo.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_costo.TabIndex = 31
        '
        'txtbox_deposito
        '
        Me.txtbox_deposito.Location = New System.Drawing.Point(110, 183)
        Me.txtbox_deposito.Name = "txtbox_deposito"
        Me.txtbox_deposito.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_deposito.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Costo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Deposito:"
        '
        'form_nueva_orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbox_deposito)
        Me.Controls.Add(Me.txtbox_costo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_sabor)
        Me.Controls.Add(Me.txtbox_dae)
        Me.Controls.Add(Me.txtbox_layers)
        Me.Controls.Add(Me.txtbox_frosting)
        Me.Controls.Add(Me.txtbox_toppings)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_nueva_orden"
        Me.Text = "Nueva Orden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbox_toppings As TextBox
    Friend WithEvents txtbox_frosting As TextBox
    Friend WithEvents txtbox_layers As TextBox
    Friend WithEvents txtbox_dae As TextBox
    Friend WithEvents txtbox_sabor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox_costo As TextBox
    Friend WithEvents txtbox_deposito As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
