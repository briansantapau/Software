Imports System.Data.SQLite
Public Class form_delete
    Private Sub form_delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbox_telefono_TextChanged(sender As Object, e As EventArgs) Handles txtbox_custid.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim custid = txtbox_custid.Text

        If String.IsNullOrWhiteSpace(txtbox_custid.Text) = False Then
            Dim conection As New SQLiteConnection("Data Source=C:\Users\brian\Desktop\Customers.db")
            conection.Open()


            Dim cmd As New SQLiteCommand
            cmd.Connection = conection

            cmd.CommandText = "BEGIN;"
            cmd.ExecuteNonQueryAsync()

            cmd.CommandText = "Delete from Clientes  WHERE CustID=" + custid.ToString + ""

            cmd.ExecuteNonQueryAsync()


            cmd.CommandText = "COMMIT"
            cmd.ExecuteNonQueryAsync()




            Me.Close()

        Else
            lbl_warning.Visible=True





        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub txtbox_custid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_custid.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class