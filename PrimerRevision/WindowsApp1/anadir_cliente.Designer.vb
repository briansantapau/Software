<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_anadir_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_anadir_clientes))
        Me.txtbox_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_apellido = New System.Windows.Forms.TextBox()
        Me.txtbox_telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbox_direcion = New System.Windows.Forms.TextBox()
        Me.lbl_warning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_nombre
        '
        Me.txtbox_nombre.Location = New System.Drawing.Point(104, 9)
        Me.txtbox_nombre.Name = "txtbox_nombre"
        Me.txtbox_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_nombre.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(34, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre :"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 206)
        Me.Splitter1.TabIndex = 16
        Me.Splitter1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(92, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Anadir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(92, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(34, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido :"
        '
        'txtbox_apellido
        '
        Me.txtbox_apellido.Location = New System.Drawing.Point(104, 34)
        Me.txtbox_apellido.Name = "txtbox_apellido"
        Me.txtbox_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_apellido.TabIndex = 11
        '
        'txtbox_telefono
        '
        Me.txtbox_telefono.Location = New System.Drawing.Point(104, 61)
        Me.txtbox_telefono.MaxLength = 12
        Me.txtbox_telefono.Name = "txtbox_telefono"
        Me.txtbox_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_telefono.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(34, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Telefono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(29, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Direcion:"
        '
        'txtbox_direcion
        '
        Me.txtbox_direcion.Location = New System.Drawing.Point(84, 87)
        Me.txtbox_direcion.Name = "txtbox_direcion"
        Me.txtbox_direcion.Size = New System.Drawing.Size(134, 20)
        Me.txtbox_direcion.TabIndex = 15
        Me.txtbox_direcion.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_warning
        '
        Me.lbl_warning.AutoSize = True
        Me.lbl_warning.ForeColor = System.Drawing.Color.Red
        Me.lbl_warning.Location = New System.Drawing.Point(54, 110)
        Me.lbl_warning.Name = "lbl_warning"
        Me.lbl_warning.Size = New System.Drawing.Size(113, 13)
        Me.lbl_warning.TabIndex = 30
        Me.lbl_warning.Text = "Hay un Campo  Vacio!"
        Me.lbl_warning.Visible = False
        '
        'form_anadir_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(234, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_warning)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.txtbox_direcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_telefono)
        Me.Controls.Add(Me.txtbox_apellido)
        Me.Controls.Add(Me.txtbox_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximumSize = New System.Drawing.Size(250, 245)
        Me.MinimumSize = New System.Drawing.Size(250, 245)
        Me.Name = "form_anadir_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anadir Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_apellido As TextBox
    Friend WithEvents txtbox_telefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbox_direcion As TextBox
    Friend WithEvents lbl_warning As Label
End Class
