<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_primary_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_login = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.lbl_warning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(86, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_primary_login
        '
        Me.btn_primary_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_primary_login.Location = New System.Drawing.Point(86, 88)
        Me.btn_primary_login.Name = "btn_primary_login"
        Me.btn_primary_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_primary_login.TabIndex = 1
        Me.btn_primary_login.Text = "Login"
        Me.btn_primary_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'txtbox_login
        '
        Me.txtbox_login.Location = New System.Drawing.Point(73, 19)
        Me.txtbox_login.Name = "txtbox_login"
        Me.txtbox_login.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_login.TabIndex = 4
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(73, 44)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_pass.TabIndex = 5
        '
        'lbl_warning
        '
        Me.lbl_warning.AutoSize = True
        Me.lbl_warning.ForeColor = System.Drawing.Color.Red
        Me.lbl_warning.Location = New System.Drawing.Point(70, 67)
        Me.lbl_warning.Name = "lbl_warning"
        Me.lbl_warning.Size = New System.Drawing.Size(91, 13)
        Me.lbl_warning.TabIndex = 31
        Me.lbl_warning.Text = "Datos Incorectos!"
        Me.lbl_warning.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(250, 175)
        Me.Controls.Add(Me.lbl_warning)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_primary_login)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btn_primary_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_login As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents lbl_warning As Label
End Class
