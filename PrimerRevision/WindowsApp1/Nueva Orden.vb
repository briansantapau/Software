Imports System.Data.SQLite
Public Class form_nueva_orden
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Dim dae As String
        Dim toppings As String
        Dim layers As String
        Dim sabor As String
        Dim costo As String
        Dim deposito As String
        Dim frosting As String


        dae = txtbox_dae.Text
        toppings = txtbox_toppings.Text
        frosting = txtbox_frosting.Text

        layers = txtbox_layers.Text
        sabor = txtbox_sabor.Text
        costo = txtbox_costo.Text
        deposito = txtbox_deposito.Text





        Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Orders.db")
        conection.Open()




        Dim cmd As New SQLiteCommand
        cmd.Connection = conection

        cmd.CommandText = "BEGIN;"
        cmd.ExecuteNonQueryAsync()

        Dim dte As String
        dte = DateString.Replace("-", "/")


        cmd.CommandText = "INSERT INTO Ordenes VALUES ( null ,'" + dae.ToString + "','" + toppings.ToString + "','" + frosting.ToString + "','" + layers.ToString + "','" + sabor.ToString + "'," + costo.ToString + "," + deposito.ToString + ",'" + deposito.ToString + dte + "')"

        cmd.ExecuteNonQueryAsync()


        cmd.CommandText = "COMMIT"
        cmd.ExecuteNonQueryAsync()

        Me.Close()



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtbox_frosting.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtbox_costo.TextChanged

    End Sub

    Private Sub txtbox_costo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_costo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_deposito_TextChanged(sender As Object, e As EventArgs) Handles txtbox_deposito.TextChanged

    End Sub

    Private Sub txtbox_deposito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_deposito.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class