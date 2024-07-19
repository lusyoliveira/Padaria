
Public Class frmUsuarios
    Dim ClasseUsuario As New clsUsuario
    Private Sub limpar()
        txtSenha.Text = ""
        txtUsuario.Text = ""
        cboPermissao.Text = ""
        txtFuncionario.Text = ""
        txtUsuario.Focus()
        lstUsuarios.Items.Clear()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseUsuario.ConsultaUsuario(lstUsuarios, 0, txtUsuario.Text)
        txtUsuario.Focus()
    End Sub
    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstUsuarios.SelectedItems(0).SubItems(0).Text)
            txtUsuario.Text = lstUsuarios.SelectedItems(0).SubItems(1).Text
            cboPermissao.Text = lstUsuarios.SelectedItems(0).SubItems(2).Text
            txtFuncionario.Text = lstUsuarios.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.AlterarUsuario(Val(lblCodigo.Text), txtUsuario.Text, cboPermissao.Text, txtSenha.Text, txtFuncionario.Text)
            limpar()
            ClasseUsuario.ConsultaUsuario(lstUsuarios, 0, txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.ExcluirUsuario(Val(lblCodigo.Text))
            limpar()
            ClasseUsuario.ConsultaUsuario(lstUsuarios, 0, txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarUsuario(txtUsuario.Text, cboPermissao.Text, txtSenha.Text, txtFuncionario.Text)
            limpar()
            ClasseUsuario.ConsultaUsuario(lstUsuarios, 0, txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub
End Class