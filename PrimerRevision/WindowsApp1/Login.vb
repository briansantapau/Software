Imports System.Data.SQLite
Public Class Login

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load




        'Este es el primer form que se abre!
        'este form tiene el nombre de "form_primary_login"
        'todo los form empiezan con form_xxxxxxxx x=el otro nombre
        ' forms hasta ahora: form_main,form_anadir_cliente,form_login





        'centraliza  a el centro de pantalla
        Me.CenterToScreen()







    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_primary_login.Click
        If txtbox_login.Text = "user" And txtbox_pass.Text = "pass" Then

            form_main.Show()
            Me.Hide()

        Else

            lbl_warning.Visible = True




        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class
