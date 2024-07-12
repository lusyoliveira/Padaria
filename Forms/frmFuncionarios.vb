Public Class frmFuncionarios
    Dim ClasseFuncionario As New clsFuncionarios
    Private Sub Limpar()
        grpFuncionarios.Tag = 0
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        cboCidade.Text = ""
        cbouf.Text = ""
        mkdCEP.Text = ""
        mkdCpf.Text = ""
        mkdRG.Text = ""
        mkdTelefone.Text = ""
        mkdcelular.Text = ""
        txtCargo.Text = ""
        txtSalario.Text = ""
        txtNumero.Text = ""
        mkdPis.Text = ""
        mkdCarteira.Text = ""
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
        txtNome.Focus()
    End Sub
    Private Sub lstFuncionarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFuncionarios.SelectedIndexChanged
        If lstFuncionarios.SelectedItems.Count = 0 Then
            Limpar()
            Exit Sub
        End If
        grpFuncionarios.Tag = Val(lstFuncionarios.SelectedItems(0).SubItems(0).Text)
        txtNome.Text = lstFuncionarios.SelectedItems(0).SubItems(0).Text
        txtEndereco.Text = lstFuncionarios.SelectedItems(0).SubItems(1).Text
        txtBairro.Text = lstFuncionarios.SelectedItems(0).SubItems(2).Text
        cboCidade.Text = lstFuncionarios.SelectedItems(0).SubItems(3).Text
        cbouf.Text = lstFuncionarios.SelectedItems(0).SubItems(4).Text
        mkdCEP.Text = lstFuncionarios.SelectedItems(0).SubItems(5).Text
        mkdCpf.Text = lstFuncionarios.SelectedItems(0).SubItems(6).Text
        mkdRG.Text = lstFuncionarios.SelectedItems(0).SubItems(7).Text
        mkdTelefone.Text = lstFuncionarios.SelectedItems(0).SubItems(8).Text
        mkdcelular.Text = lstFuncionarios.SelectedItems(0).SubItems(9).Text
        txtNumero.Text = lstFuncionarios.SelectedItems(0).SubItems(10).Text
        txtCargo.Text = lstFuncionarios.SelectedItems(0).SubItems(11).Text
        txtSalario.Text = lstFuncionarios.SelectedItems(0).SubItems(12).Text
        mkdPis.Text = lstFuncionarios.SelectedItems(0).SubItems(13).Text
        mkdCarteira.Text = lstFuncionarios.SelectedItems(0).SubItems(14).Text
        txtNome.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarFuncionario(txtNome.Text, txtEndereco.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCpf.Text, mkdRG.Text, mkdCEP.Text, mkdTelefone.Text, txtNumero.Text, mkdcelular.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, mkdPis.Text)
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a excluir do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirFuncionario(Val(lblCodigo.Text))
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarFuncionario(lblCodigo.Text, txtNome.Text, txtEndereco.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCpf.Text, mkdRG.Text, mkdCEP.Text, mkdTelefone.Text, txtNumero.Text, mkdcelular.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, mkdPis.Text)
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
End Class