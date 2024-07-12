
Public Class frmLocalizar
    Dim ClasseConfiguracao As New clsConfiguracao
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmClientes.Show()
                frmClientes.btnAlterar.Enabled = False
                frmClientes.btnExcluir.Enabled = False
            Case Is = "Produto"
                frmProdutos.Show()
                frmProdutos.btnAlterar.Enabled = False
                frmProdutos.btnExcluir.Enabled = False
            Case Is = "Funcionário"
                frmFuncionarios.Show()
                frmFuncionarios.btnAlterar.Enabled = False
                frmFuncionarios.btnExcluir.Enabled = False
            Case Is = "Fornecedores"
                frmFornecedores.Show()
                frmFornecedores.btnAlterar.Enabled = False
                frmFornecedores.btnExcluir.Enabled = False
            Case Is = "Estoque"
                frmEstoque.Show()
                frmEstoque.btnEntrada.Enabled = False
        End Select
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmClientes.Show()
                frmClientes.btnSalvar.Enabled = False
                frmClientes.btnExcluir.Enabled = False
            Case Is = "Filmes"
                frmProdutos.Show()
                frmProdutos.btnSalvar.Enabled = False
                frmProdutos.btnExcluir.Enabled = False
            Case Is = "Funcionário"
                frmFuncionarios.Show()
                frmFuncionarios.btnSalvar.Enabled = False
                frmFuncionarios.btnExcluir.Enabled = False
            Case Is = "Fornecedores"
                frmFornecedores.Show()
                frmFornecedores.btnSalvar.Enabled = False
                frmFornecedores.btnExcluir.Enabled = False
            Case Is = "Estoque"
                frmEstoque.Show()
                frmEstoque.btnSaida.Enabled = False
        End Select
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmClientes.Show()
                frmClientes.btnSalvar.Enabled = False
                frmClientes.btnAlterar.Enabled = False
            Case Is = "Produtos"
                frmProdutos.Show()
                frmProdutos.btnSalvar.Enabled = False
                frmProdutos.btnAlterar.Enabled = False
            Case Is = "Funcionário"
                frmFuncionarios.Show()
                frmFuncionarios.btnSalvar.Enabled = False
                frmFuncionarios.btnAlterar.Enabled = False
            Case Is = "Fornecedores"
                frmFornecedores.Show()
                frmFornecedores.btnSalvar.Enabled = False
                frmFuncionarios.btnAlterar.Enabled = False
            Case Is = "Estoque"
                frmEstoque.Show()
                frmEstoque.btnExcluir.Enabled = False
        End Select
    End Sub

    Private Sub frmLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLocalizar.Focus()
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        ClasseConfiguracao.Localizar(cboItens.Text, lstLocalizar, txtLocalizar.Text)
    End Sub
End Class