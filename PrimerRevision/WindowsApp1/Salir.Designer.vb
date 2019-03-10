<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_salir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_salir))
        Me.btn_si = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_salir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_si
        '
        Me.btn_si.Location = New System.Drawing.Point(48, 43)
        Me.btn_si.Name = "btn_si"
        Me.btn_si.Size = New System.Drawing.Size(75, 23)
        Me.btn_si.TabIndex = 0
        Me.btn_si.Text = "Si"
        Me.btn_si.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(129, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_salir
        '
        Me.lbl_salir.AutoSize = True
        Me.lbl_salir.Location = New System.Drawing.Point(78, 9)
        Me.lbl_salir.Name = "lbl_salir"
        Me.lbl_salir.Size = New System.Drawing.Size(67, 13)
        Me.lbl_salir.TabIndex = 2
        Me.lbl_salir.Text = "Desea Salir?"
        '
        'form_salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 79)
        Me.Controls.Add(Me.lbl_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_si)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_salir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_si As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_salir As Label
End Class
