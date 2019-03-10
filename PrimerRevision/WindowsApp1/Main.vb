Imports System.Data.SQLite

Public Class form_main
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load




        Me.CenterToScreen()
        Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file As String = "Orders.db"
        Dim pathtofile As String = System.IO.Path.Combine(location, file)
        Dim connectionstring As String = ("Data Source=" + "dbpathtofile")


        Dim execution As String = ""

        If dbexist(pathtofile) = False Then

            execution = "CREATE TABLE Ordenes (
    OrderID INTEGER PRIMARY KEY
                 UNIQUE
                 NOT NULL,
    DAE           TEXT,
    Toppings         TEXT,
    Frosting         TEXT,
    Layers         TEXT,
    Sabor          TEXT,
    [Costo]        DECIMAL(7,2),
    [Deposito]     DECIMAL(7,2),
    DiaHecho        TEXT
);"





        End If

        Dim conection As New SQLiteConnection("Data Source=" + pathtofile.ToString)


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = execution.ToString
        cmd.ExecuteNonQueryAsync()

        cmd.CommandText = "Select * from Ordenes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table




    End Sub


    Private Function dbexist(pathtofile As String) As Boolean


        Return System.IO.File.Exists(pathtofile)


    End Function

    Private Sub refreshorder()





        Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file As String = "Orders.db"
        Dim pathtofile As String = System.IO.Path.Combine(location, file)
        Dim connectionstring As String = ("Data Source=" + "dbpathtofile")


        Dim execution As String = ""


        Dim conection As New SQLiteConnection("Data Source=" + pathtofile.ToString)


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = execution.ToString
        cmd.ExecuteNonQueryAsync()

        cmd.CommandText = "Select * from Ordenes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table



    End Sub

    Private Sub refreshcustomer()

        radio_none.Checked() = True




        Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file As String = "Customers.db"
        Dim pathtofile As String = System.IO.Path.Combine(location, file)
        Dim connectionstring As String = ("Data Source=" + "dbpathtofile")


        Dim execution As String = ""


        Dim conection As New SQLiteConnection("Data Source=" + pathtofile.ToString)


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection


        cmd.CommandText = "Select * from Clientes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_eliminar_clientes.Click
        form_delete.Show()


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_salir.Click






        form_salir.Show()




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radio_nombre_az.CheckedChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_lista_cliente.Click




        Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file As String = "Orders.db"
        Dim pathtofile As String = System.IO.Path.Combine(location, file)
        Dim connectionstring As String = ("Data Source=" + "dbpathtofile")


        Dim execution As String = ""

        If dbexist(pathtofile) = False Then

            execution = "CREATE TABLE Ordenes (
    OrderID INTEGER PRIMARY KEY
                 UNIQUE
                 NOT NULL,
    DAE           TEXT,
    Toppings         TEXT,
    Frosting         TEXT,
    Layers         TEXT,
    Sabor          TEXT,
    [Costo]        DECIMAL(7,2),
    [Deposito]     DECIMAL(7,2),
    DiaHecho        TEXT
);"





        End If

        Dim conection As New SQLiteConnection("Data Source=" + pathtofile.ToString)


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = execution.ToString
        cmd.ExecuteNonQueryAsync()

        cmd.CommandText = "Select * from Ordenes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table




    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles label_apellido.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btn_anadir_clientes_Click(sender As Object, e As EventArgs) Handles btn_anadir_clientes.Click
        form_anadir_clientes.Show()



        refreshcustomer()


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub dg_main_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = "Select * from Clientes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table


    End Sub

    Private Sub dg_main_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
        conection.Open()



        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = "Select * from Clientes WHERE Apellido='" + txtbox_apellido.Text + "' COLLATE NOCASE"

        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        If String.IsNullOrWhiteSpace(txtbox_nombre.Text) = False Then

            Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
            conection.Open()

            Dim cmd As New SQLiteCommand
            cmd.Connection = conection

            cmd.CommandText = "Select * from Clientes WHERE Nombre='" + txtbox_nombre.Text + "' COLLATE NOCASE"



            If radio_ape_az.Checked() = True Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido DESC "

            End If

            If radio_ape_za.Checked() Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido ASC "


            End If





            If radio_nombre_az.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY Nombre DESC "
            End If

            If radio_nombre_za.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY Nombre ASC "
            End If

            If radio_oh_mayor.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY [Ordenes Hechas] DESC"
            End If

            If radio_oh_menor.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY [Ordenes Hechas] ASC "
            End If

            If radio_ttl_comp_mnr.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY [Total Comprado] ASC"
            End If

            If radio_ttl_myor.Checked() Then
                cmd.CommandText = cmd.CommandText.ToString + " ORDER BY [Total Comprado] DESC"
            End If









            cmd.ExecuteNonQueryAsync()



            Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
            Dim dat_table As New DataTable
            dat_table.Load(read)
            read.Close()
            conection.Close()
            dg_main.DataSource = dat_table
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_nombre.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox_telefono.TextChanged

    End Sub

    Private Sub txtbox_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_telefono.KeyPress
        If Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If String.IsNullOrWhiteSpace(txtbox_telefono.Text) = False Then

            Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
            conection.Open()

            Dim cmd As New SQLiteCommand
            cmd.Connection = conection

            cmd.CommandText = "Select * from Clientes WHERE Telefono=" + txtbox_telefono.Text
            If radio_ape_az.Checked() = True Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido DESC "

            End If

            If radio_ape_za.Checked() Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido ASC "


            End If





            If radio_nombre_az.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY Nombre DESC "
            End If

            If radio_nombre_za.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY Nombre ASC "
            End If

            If radio_oh_mayor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Ordenes Hechas] ASC"
            End If

            If radio_oh_menor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Ordenes Hechas] DESC"
            End If

            If radio_ttl_comp_mnr.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Total Comprado] ASC"
            End If

            If radio_ttl_myor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Total Comprado] DESC"
            End If



            cmd.ExecuteNonQueryAsync()
            Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
            Dim dat_table As New DataTable
            dat_table.Load(read)
            read.Close()
            conection.Close()
            dg_main.DataSource = dat_table
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtbox_apellido.TextChanged

    End Sub

    Private Sub radio_oh_mayor_CheckedChanged(sender As Object, e As EventArgs) Handles radio_oh_mayor.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_main.CellContentClick

    End Sub

    Private Sub Btn_ver_Todo_Click(sender As Object, e As EventArgs) Handles Btn_ver_Todo.Click
        Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = "Select * from Clientes"


        cmd.ExecuteNonQueryAsync()
        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table

    End Sub

    Private Sub btn_crear_nueva_orden_Click(sender As Object, e As EventArgs) Handles btn_crear_nueva_orden.Click
        form_nueva_orden.Show()




        refreshorder()





    End Sub

    Private Sub txtbox_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_apellido.KeyPress
        If Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_nombre.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtbox_custid.TextChanged



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_custid.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_buscar_custid_Click(sender As Object, e As EventArgs) Handles btn_buscar_custid.Click
        If String.IsNullOrWhiteSpace(txtbox_custid.Text) = False Then

            Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
            conection.Open()

            Dim cmd As New SQLiteCommand
            cmd.Connection = conection

            cmd.CommandText = "Select * from Clientes WHERE CustID=" + txtbox_custid.Text
            If radio_ape_az.Checked() = True Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido DESC "

            End If

            If radio_ape_za.Checked() Then

                cmd.CommandText = cmd.CommandText + " ORDER BY Apellido ASC "


            End If





            If radio_nombre_az.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY Nombre DESC "
            End If

            If radio_nombre_za.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY Nombre ASC "
            End If

            If radio_oh_mayor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Ordenes Hechas] ASC"
            End If

            If radio_oh_menor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Ordenes Hechas] DESC"
            End If

            If radio_ttl_comp_mnr.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Total Comprado] ASC"
            End If

            If radio_ttl_myor.Checked() Then
                cmd.CommandText = cmd.CommandText + " ORDER BY [Total Comprado] DESC"
            End If



            cmd.ExecuteNonQueryAsync()
            Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
            Dim dat_table As New DataTable
            dat_table.Load(read)
            read.Close()
            conection.Close()
            dg_main.DataSource = dat_table

        End If




    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        radio_none.Checked() = True




        Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file As String = "Customers.db"
        Dim pathtofile As String = System.IO.Path.Combine(location, file)
        Dim connectionstring As String = ("Data Source=" + "dbpathtofile")


        Dim execution As String = ""

        If dbexist(pathtofile) = False Then

            execution = "CREATE TABLE Clientes (
    CustID INTEGER PRIMARY KEY
                 UNIQUE
                 NOT NULL,
    Nombre           TEXT,
    Apellido         TEXT,
    Telefono         TEXT,
    [Ordenes Hechas] INTEGER,
    [Total Comprado] INTEGER,
    Direcion         TEXT
);"





        End If

        Dim conection As New SQLiteConnection("Data Source=" + pathtofile.ToString)


        conection.Open()

        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = execution.ToString
        cmd.ExecuteNonQueryAsync()

        cmd.CommandText = "Select * from Clientes"
        cmd.ExecuteNonQueryAsync()



        Dim read As SQLite.SQLiteDataReader = cmd.ExecuteReader
        Dim dat_table As New DataTable
        dat_table.Load(read)
        read.Close()
        conection.Close()
        dg_main.DataSource = dat_table



    End Sub
End Class