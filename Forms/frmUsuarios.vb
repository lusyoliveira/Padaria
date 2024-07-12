
Public Class frmUsuarios
    Dim ClasseUsuario As New clsUsuario
    Private Sub limpar()
        txtSenha.Text = ""
        txtUsuario.Text = ""
        cboPermissao.Text = ""
        txtFuncionario.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseUsuario.ConsultaUsuario(lstUsuarios, 0, txtUsuario.Text)
        txtUsuario.Focus()
    End Sub
    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        lblCodigo.Text = Val(lstUsuarios.SelectedItems(0).SubItems(0).Text)
        txtFuncionario.Text = lstUsuarios.SelectedItems(0).SubItems(0).Text
        txtUsuario.Text = lstUsuarios.SelectedItems(0).SubItems(1).Text
        cboPermissao.Text = lstUsuarios.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.AlterarUsuario(Val(lblCodigo.Text), txtUsuario.Text, cboPermissao.Text, txtSenha.Text, txtSenha.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.ExcluirUsuario(Val(lblCodigo.Text))
        Else
            Exit Sub
        End If
    End Sub

End Class