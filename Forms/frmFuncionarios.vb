Public Class frmFuncionarios
    Dim ClasseFuncionario As New clsEntidades
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
        lstEntidade.Items.Clear()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseFuncionario.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "FU")
        txtNome.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarEntidade(txtNome.Text, txtNome.Text, "", "", txtEndereco.Text, "", txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCEP.Text, "", mkdRG.Text, mkdCpf.Text, "", "FU")
            ClasseFuncionario.SalvarContato(Val(lblCodigo.Text), mkdTelefone.Text, "", mkdcelular.Text, "")
            ClasseFuncionario.SalvarCargo(Val(lblCodigo.Text), txtNumero.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, "")
            Limpar()
            ClasseFuncionario.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a excluir do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirCargo(Val(lblCodigo.Text))
            ClasseFuncionario.ExcluirContato(Val(lblCodigo.Text))
            ClasseFuncionario.ExcluirEntidade(Val(lblCodigo.Text))
            Limpar()
            ClasseFuncionario.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarCargo(Val(lblCodigo.Text), ClasseFuncionario.CodCargo, txtNumero.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, "")
            ClasseFuncionario.AlterarContato(Val(lblCodigo.Text), ClasseFuncionario.CodContato, mkdTelefone.Text, "", mkdcelular.Text, "")
            ClasseFuncionario.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, txtNome.Text, "", "", txtEndereco.Text, "", txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCEP.Text, "", mkdRG.Text, mkdCpf.Text, "")
            Limpar()
            ClasseFuncionario.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtNome.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            cboCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cbouf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mkdCEP.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
            mkdRG.Text = lstEntidade.SelectedItems(0).SubItems(12).Text
            mkdCpf.Text = lstEntidade.SelectedItems(0).SubItems(13).Text
            ClasseFuncionario.ObterContato(Val(lblCodigo.Text), ClasseFuncionario)
            mkdTelefone.Text = ClasseFuncionario.Telefone1
            mkdcelular.Text = ClasseFuncionario.Celular
            ClasseFuncionario.ObterCargo(Val(lblCodigo.Text), ClasseFuncionario)
            txtNumero.Text = ClasseFuncionario.Matricula.ToString
            mkdCarteira.Text = ClasseFuncionario.CarteiraProfissional
            txtCargo.Text = ClasseFuncionario.Cargo
            txtSalario.Text = ClasseFuncionario.Salario
        End If
    End Sub
End Class