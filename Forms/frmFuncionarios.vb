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
        lstFuncionarios.Items.Clear()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
        txtNome.Focus()
    End Sub
    Private Sub lstFuncionarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFuncionarios.SelectedIndexChanged
        If lstFuncionarios.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstFuncionarios.SelectedItems(0).SubItems(0).Text)
            txtNome.Text = lstFuncionarios.SelectedItems(0).SubItems(1).Text
            txtEndereco.Text = lstFuncionarios.SelectedItems(0).SubItems(2).Text
            txtBairro.Text = lstFuncionarios.SelectedItems(0).SubItems(3).Text
            cboCidade.Text = lstFuncionarios.SelectedItems(0).SubItems(4).Text
            cbouf.Text = lstFuncionarios.SelectedItems(0).SubItems(5).Text
            mkdCEP.Text = lstFuncionarios.SelectedItems(0).SubItems(6).Text
            mkdCpf.Text = lstFuncionarios.SelectedItems(0).SubItems(7).Text
            mkdRG.Text = lstFuncionarios.SelectedItems(0).SubItems(8).Text
            mkdTelefone.Text = lstFuncionarios.SelectedItems(0).SubItems(9).Text
            mkdcelular.Text = lstFuncionarios.SelectedItems(0).SubItems(10).Text
            txtNumero.Text = lstFuncionarios.SelectedItems(0).SubItems(11).Text
            txtCargo.Text = lstFuncionarios.SelectedItems(0).SubItems(12).Text
            txtSalario.Text = lstFuncionarios.SelectedItems(0).SubItems(13).Text
            mkdPis.Text = lstFuncionarios.SelectedItems(0).SubItems(14).Text
            mkdCarteira.Text = lstFuncionarios.SelectedItems(0).SubItems(15).Text
            txtNome.Enabled = False
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarFuncionario(txtNome.Text, txtEndereco.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCpf.Text, mkdRG.Text, mkdCEP.Text, mkdTelefone.Text, txtNumero.Text, mkdcelular.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, mkdPis.Text)
            Limpar()
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a excluir do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirFuncionario(Val(lblCodigo.Text))
            Limpar()
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarFuncionario(Val(lblCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCpf.Text, mkdRG.Text, mkdCEP.Text, mkdTelefone.Text, txtNumero.Text, mkdcelular.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, mkdPis.Text)
            Limpar()
            ClasseFuncionario.ConsultaFuncionario(lstFuncionarios, Val(lblCodigo.Text), txtNome.Text)
        Else
            Exit Sub
        End If
    End Sub
End Class