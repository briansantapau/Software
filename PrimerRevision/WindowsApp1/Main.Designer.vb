<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.btn_lista_cliente = New System.Windows.Forms.Button()
        Me.btn_anadir_clientes = New System.Windows.Forms.Button()
        Me.btn_eliminar_clientes = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_crear_nueva_orden = New System.Windows.Forms.Button()
        Me.radio_ape_az = New System.Windows.Forms.RadioButton()
        Me.radio_ape_za = New System.Windows.Forms.RadioButton()
        Me.radio_nombre_za = New System.Windows.Forms.RadioButton()
        Me.radio_nombre_az = New System.Windows.Forms.RadioButton()
        Me.radio_oh_mayor = New System.Windows.Forms.RadioButton()
        Me.radio_oh_menor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radio_ttl_myor = New System.Windows.Forms.RadioButton()
        Me.radio_ttl_comp_mnr = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.la = New System.IO.FileSystemWatcher()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.txtbox_nombre = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.txtbox_telefono = New System.Windows.Forms.TextBox()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label_apellido = New System.Windows.Forms.Label()
        Me.txtbox_apellido = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.radio_none = New System.Windows.Forms.RadioButton()
        Me.dg_main = New System.Windows.Forms.DataGridView()
        Me.Btn_ver_Todo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_buscar_custid = New System.Windows.Forms.Button()
        Me.txtbox_custid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.la, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_lista_cliente
        '
        Me.btn_lista_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_lista_cliente, "btn_lista_cliente")
        Me.btn_lista_cliente.Name = "btn_lista_cliente"
        Me.btn_lista_cliente.UseVisualStyleBackColor = True
        '
        'btn_anadir_clientes
        '
        Me.btn_anadir_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_anadir_clientes, "btn_anadir_clientes")
        Me.btn_anadir_clientes.Name = "btn_anadir_clientes"
        Me.btn_anadir_clientes.UseVisualStyleBackColor = True
        '
        'btn_eliminar_clientes
        '
        Me.btn_eliminar_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_eliminar_clientes, "btn_eliminar_clientes")
        Me.btn_eliminar_clientes.Name = "btn_eliminar_clientes"
        Me.btn_eliminar_clientes.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn_salir, "btn_salir")
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.btn_clientes)
        Me.Panel1.Controls.Add(Me.btn_crear_nueva_orden)
        Me.Panel1.Controls.Add(Me.btn_lista_cliente)
        Me.Panel1.Controls.Add(Me.btn_anadir_clientes)
        Me.Panel1.Controls.Add(Me.btn_eliminar_clientes)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Name = "Panel1"
        '
        'btn_clientes
        '
        resources.ApplyResources(Me.btn_clientes, "btn_clientes")
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_crear_nueva_orden
        '
        resources.ApplyResources(Me.btn_crear_nueva_orden, "btn_crear_nueva_orden")
        Me.btn_crear_nueva_orden.Name = "btn_crear_nueva_orden"
        Me.btn_crear_nueva_orden.UseVisualStyleBackColor = True
        '
        'radio_ape_az
        '
        resources.ApplyResources(Me.radio_ape_az, "radio_ape_az")
        Me.radio_ape_az.Name = "radio_ape_az"
        Me.radio_ape_az.UseVisualStyleBackColor = True
        '
        'radio_ape_za
        '
        resources.ApplyResources(Me.radio_ape_za, "radio_ape_za")
        Me.radio_ape_za.Name = "radio_ape_za"
        Me.radio_ape_za.UseVisualStyleBackColor = True
        '
        'radio_nombre_za
        '
        resources.ApplyResources(Me.radio_nombre_za, "radio_nombre_za")
        Me.radio_nombre_za.Name = "radio_nombre_za"
        Me.radio_nombre_za.UseVisualStyleBackColor = True
        '
        'radio_nombre_az
        '
        resources.ApplyResources(Me.radio_nombre_az, "radio_nombre_az")
        Me.radio_nombre_az.Name = "radio_nombre_az"
        Me.radio_nombre_az.UseVisualStyleBackColor = True
        '
        'radio_oh_mayor
        '
        resources.ApplyResources(Me.radio_oh_mayor, "radio_oh_mayor")
        Me.radio_oh_mayor.Name = "radio_oh_mayor"
        Me.radio_oh_mayor.UseVisualStyleBackColor = True
        '
        'radio_oh_menor
        '
        resources.ApplyResources(Me.radio_oh_menor, "radio_oh_menor")
        Me.radio_oh_menor.Name = "radio_oh_menor"
        Me.radio_oh_menor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'radio_ttl_myor
        '
        resources.ApplyResources(Me.radio_ttl_myor, "radio_ttl_myor")
        Me.radio_ttl_myor.Name = "radio_ttl_myor"
        Me.radio_ttl_myor.UseVisualStyleBackColor = True
        '
        'radio_ttl_comp_mnr
        '
        resources.ApplyResources(Me.radio_ttl_comp_mnr, "radio_ttl_comp_mnr")
        Me.radio_ttl_comp_mnr.Name = "radio_ttl_comp_mnr"
        Me.radio_ttl_comp_mnr.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'label5
        '
        resources.ApplyResources(Me.label5, "label5")
        Me.label5.Name = "label5"
        '
        'la
        '
        Me.la.EnableRaisingEvents = True
        Me.la.SynchronizingObject = Me
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'txtbox_nombre
        '
        resources.ApplyResources(Me.txtbox_nombre, "txtbox_nombre")
        Me.txtbox_nombre.Name = "txtbox_nombre"
        '
        'btn
        '
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btn, "btn")
        Me.btn.Name = "btn"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txtbox_telefono
        '
        resources.ApplyResources(Me.txtbox_telefono, "txtbox_telefono")
        Me.txtbox_telefono.Name = "txtbox_telefono"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'label_apellido
        '
        resources.ApplyResources(Me.label_apellido, "label_apellido")
        Me.label_apellido.Name = "label_apellido"
        '
        'txtbox_apellido
        '
        resources.ApplyResources(Me.txtbox_apellido, "txtbox_apellido")
        Me.txtbox_apellido.Name = "txtbox_apellido"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        resources.ApplyResources(Me.btn_refresh, "btn_refresh")
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'radio_none
        '
        resources.ApplyResources(Me.radio_none, "radio_none")
        Me.radio_none.Checked = True
        Me.radio_none.Name = "radio_none"
        Me.radio_none.TabStop = True
        Me.radio_none.UseVisualStyleBackColor = True
        '
        'dg_main
        '
        Me.dg_main.AllowUserToAddRows = False
        Me.dg_main.AllowUserToDeleteRows = False
        Me.dg_main.AllowUserToResizeColumns = False
        Me.dg_main.AllowUserToResizeRows = False
        Me.dg_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dg_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_main.Cursor = System.Windows.Forms.Cursors.Cross
        resources.ApplyResources(Me.dg_main, "dg_main")
        Me.dg_main.Name = "dg_main"
        Me.dg_main.ReadOnly = True
        Me.dg_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'Btn_ver_Todo
        '
        Me.Btn_ver_Todo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_ver_Todo.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Btn_ver_Todo, "Btn_ver_Todo")
        Me.Btn_ver_Todo.Name = "Btn_ver_Todo"
        Me.Btn_ver_Todo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'btn_buscar_custid
        '
        resources.ApplyResources(Me.btn_buscar_custid, "btn_buscar_custid")
        Me.btn_buscar_custid.Name = "btn_buscar_custid"
        Me.btn_buscar_custid.UseVisualStyleBackColor = True
        '
        'txtbox_custid
        '
        resources.ApplyResources(Me.txtbox_custid, "txtbox_custid")
        Me.txtbox_custid.Name = "txtbox_custid"
        '
        'form_main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtbox_custid)
        Me.Controls.Add(Me.btn_buscar_custid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_ver_Todo)
        Me.Controls.Add(Me.dg_main)
        Me.Controls.Add(Me.radio_none)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.radio_ape_az)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radio_ape_za)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radio_nombre_za)
        Me.Controls.Add(Me.radio_ttl_myor)
        Me.Controls.Add(Me.radio_nombre_az)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radio_ttl_comp_mnr)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.radio_oh_mayor)
        Me.Controls.Add(Me.radio_oh_menor)
        Me.Controls.Add(Me.txtbox_apellido)
        Me.Controls.Add(Me.label_apellido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbox_telefono)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txtbox_nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_main"
        Me.Panel1.ResumeLayout(False)
        CType(Me.la, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_lista_cliente As Button
    Friend WithEvents btn_anadir_clientes As Button
    Friend WithEvents btn_eliminar_clientes As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radio_ape_az As RadioButton
    Friend WithEvents radio_ape_za As RadioButton
    Friend WithEvents radio_nombre_za As RadioButton
    Friend WithEvents radio_nombre_az As RadioButton
    Friend WithEvents radio_oh_mayor As RadioButton
    Friend WithEvents radio_oh_menor As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radio_ttl_myor As RadioButton
    Friend WithEvents radio_ttl_comp_mnr As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents label5 As Label
    Friend WithEvents la As IO.FileSystemWatcher
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbox_telefono As TextBox
    Friend WithEvents btn As Button
    Friend WithEvents txtbox_nombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents Button7 As Button
    Friend WithEvents txtbox_apellido As TextBox
    Friend WithEvents label_apellido As Label
    Friend WithEvents btn_crear_nueva_orden As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btn_refresh As Button
    Friend WithEvents radio_none As RadioButton
    Friend WithEvents dg_main As DataGridView
    Friend WithEvents Btn_ver_Todo As Button
    Friend WithEvents btn_buscar_custid As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbox_custid As TextBox
    Friend WithEvents btn_clientes As Button
End Class
