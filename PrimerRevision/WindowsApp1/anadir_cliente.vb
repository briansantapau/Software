Imports System.Data.SQLite
Public Class form_anadir_clientes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub form_anadir_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        form_main.Show()
    End Sub



    Private Sub txtbox_telefono_TextChanged(sender As Object, e As EventArgs) Handles txtbox_telefono.TextChanged

    End Sub

    Private Sub txtbox_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_telefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        If String.IsNullOrWhiteSpace(txtbox_telefono.Text) = False Or String.IsNullOrWhiteSpace(txtbox_nombre.Text) = False Or String.IsNullOrWhiteSpace(txtbox_direcion.Text) = False Or String.IsNullOrWhiteSpace(txtbox_apellido.Text) = False Then
            Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
            conection.Open()

            Dim apellido = txtbox_apellido.Text

            Dim direcion = txtbox_direcion.Text
            Dim nombre = txtbox_nombre.Text
            Dim telefono = txtbox_telefono.Text


            Dim cmd As New SQLiteCommand
            cmd.Connection = conection

            cmd.CommandText = "BEGIN;"
            cmd.ExecuteNonQueryAsync()

            cmd.CommandText = "INSERT INTO Clientes VALUES ( null ,'" + nombre.ToString + "','" + apellido.ToString + "','" + telefono.ToString + "', 0  ,  0  ,'" + direcion.ToString + "')"

            cmd.ExecuteNonQueryAsync()


            cmd.CommandText = "COMMIT"
            cmd.ExecuteNonQueryAsync()

            Me.Close()





        Else


            lbl_warning.Visible = True







        End If

    End Sub

    Private Sub lbl_warning_Click(sender As Object, e As EventArgs) Handles lbl_warning.Click

    End Sub
End Class