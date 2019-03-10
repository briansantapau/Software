Public Class form_salir
    Private Sub btn_salir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_si.Click
        Application.Exit()
    End Sub
End Class