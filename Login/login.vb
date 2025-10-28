Public Class login
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
                admin.Show()
            Else
                txt_usuario.Clear()
                txt_senha.Clear()
                MsgBox("Usuário não autorizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub
End Class
