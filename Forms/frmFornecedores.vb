Imports System.Data.SqlClient
Public Class frmFornecedores
    Dim ClasseFornecedores As New clsEntidades
    Private Sub limpar()
        txtFornecedor.Text = ""
        txtEmpresa.Text = ""
        mkdCNPJ.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        cboCidade.Text = ""
        txtComplemento.Text = ""
        mkdCEP.Text = ""
        cbouf.Text = ""
        txtSite.Text = ""
        txtEmail.Text = ""
        mkdTelefone.Text = ""
        mkdCelular.Text = ""
        lstEntidade.Items.Clear()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.SalvarEntidade(txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCEP.Text, "", "", mkdCNPJ.Text, "", "F")
            ClasseFornecedores.SalvarContato(Val(lblCodigo.Text), mkdTelefone.Text, "", mkdCelular.Text, txtEmail.Text)
            ClasseFornecedores.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.AlterarEntidade(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCEP.Text, "", "", mkdCNPJ.Text, "")
            ClasseFornecedores.AlterarContato(Val(lblCodigo.Text), ClasseFornecedores.CodContato, mkdTelefone.Text, "", mkdCelular.Text, txtEmail.Text)
            limpar()
            ClasseFornecedores.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.ExcluirContato(Val(lblCodigo.Text))
            ClasseFornecedores.ExcluirEntidade(Val(lblCodigo.Text))
            limpar()
            ClasseFornecedores.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()
        ClasseFornecedores.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtEmpresa.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            txtFornecedor.Text = lstEntidade.SelectedItems(0).SubItems(2).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            cboCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cbouf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mkdCEP.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
            mkdCNPJ.Text = lstEntidade.SelectedItems(0).SubItems(13).Text
            ClasseFornecedores.ObterContato(Val(lblCodigo.Text), ClasseFornecedores)
            mkdTelefone.Text = ClasseFornecedores.Telefone1
            mkdCelular.Text = ClasseFornecedores.Celular
            txtEmail.Text = ClasseFornecedores.Email
        End If
    End Sub
End Class
