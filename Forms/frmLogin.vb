Public Class frmLogin
    Dim ClasseUsuario As New clsUsuario
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        ClasseUsuario.Autenticar(txtUsuario.Text, txtSenha.Text)
    End Sub

End Class