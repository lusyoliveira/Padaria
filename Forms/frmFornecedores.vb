Imports System.Data.SqlClient
Public Class frmFornecedores
    Dim ClasseFornecedores As New clsFornecedores
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
    End Sub
    Private Sub lstFornecedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFornecedores.SelectedIndexChanged
        If lstFornecedores.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        grpFornecedores.Tag = Val(lstFornecedores.SelectedItems(0).SubItems(0).Text)
        txtEmpresa.Text = lstFornecedores.SelectedItems(0).SubItems(0).Text
        txtEndereco.Text = lstFornecedores.SelectedItems(0).SubItems(1).Text
        txtBairro.Text = lstFornecedores.SelectedItems(0).SubItems(2).Text
        txtComplemento.Text = lstFornecedores.SelectedItems(0).SubItems(3).Text
        cboCidade.Text = lstFornecedores.SelectedItems(0).SubItems(4).Text
        mkdCNPJ.Text = lstFornecedores.SelectedItems(0).SubItems(5).Text
        cbouf.Text = lstFornecedores.SelectedItems(0).SubItems(6).Text
        mkdCEP.Text = lstFornecedores.SelectedItems(0).SubItems(7).Text
        txtFornecedor.Text = lstFornecedores.SelectedItems(0).SubItems(8).Text
        mkdTelefone.Text = lstFornecedores.SelectedItems(0).SubItems(9).Text
        mkdCelular.Text = lstFornecedores.SelectedItems(0).SubItems(10).Text
        txtSite.Text = lstFornecedores.SelectedItems(0).SubItems(11).Text
        txtEmail.Text = lstFornecedores.SelectedItems(0).SubItems(12).Text
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.SalvarFornecedor(txtFornecedor.Text, txtEmpresa.Text, txtEndereco.Text, txtBairro.Text, txtComplemento.Text, cboCidade.Text, mkdCNPJ.Text, cbouf.Text, mkdCEP.Text, mkdTelefone.Text, mkdCelular.Text, txtSite.Text, txtEmail.Text)
            ClasseFornecedores.ConsultaFornecedor(lstFornecedores, Val(lblCodigo.Text), txtFornecedor.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.AlterarFornecedor(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, txtEndereco.Text, txtBairro.Text, txtComplemento.Text, cboCidade.Text, mkdCNPJ.Text, cbouf.Text, mkdCEP.Text, mkdTelefone.Text, mkdCelular.Text, txtSite.Text, txtEmail.Text)
            ClasseFornecedores.ConsultaFornecedor(lstFornecedores, Val(lblCodigo.Text), txtFornecedor.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedores.ExcluirFornecedor(Val(lblCodigo.Text))
            ClasseFornecedores.ConsultaFornecedor(lstFornecedores, Val(lblCodigo.Text), txtFornecedor.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()
        ClasseFornecedores.ConsultaFornecedor(lstFornecedores, Val(lblCodigo.Text), txtFornecedor.Text)
    End Sub

End Class
