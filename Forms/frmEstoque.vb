Public Class frmEstoque
    Dim ClasseEstoque As New clsEstoque
    Private Sub Limpar()
        grpEstoque.Tag = 0
        txtProdutos.Text = ""
        txtQuantidade.Text = ""
        txtValor.Text = ""
        txtDataentrada.Text = ""
        cboTipo.Text = ""
        cboFornecedores.Text = ""
    End Sub
    Private Sub frmEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtProdutos.Focus()
        ClasseEstoque.CarregarEstoque(lstEstoque, 0, "")
    End Sub
    Private Sub txtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.LostFocus
        txtDataentrada.Text = Date.Now.Date
    End Sub
    Private Sub lstEstoque_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstEstoque.LostFocus
        txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub
    Private Sub lstEstoque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEstoque.SelectedIndexChanged
        If lstEstoque.SelectedItems.Count = 0 Then
            Limpar()
            Exit Sub
        End If
        grpEstoque.Tag = Val(lstEstoque.SelectedItems(0).SubItems(0).Text)
        txtProdutos.Text = lstEstoque.SelectedItems(0).SubItems(0).Text
        txtQuantidade.Text = lstEstoque.SelectedItems(0).SubItems(1).Text
        cboTipo.Text = lstEstoque.SelectedItems(0).SubItems(2).Text
        txtValor.Text = lstEstoque.SelectedItems(0).SubItems(3).Text
        txtDataentrada.Text = lstEstoque.SelectedItems(0).SubItems(4).Text
        cboFornecedores.Text = lstEstoque.SelectedItems(0).SubItems(5).Text
    End Sub

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        ClasseEstoque.EntradaEstoque(txtProdutos.Text, txtQuantidade.Text, cboTipo.Text, txtValor.Text, txtDataentrada.Text, cboFornecedores.Text)
    End Sub
    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        ClasseEstoque.SaidaEstoque(txtProdutos.Text, txtQuantidade.Text)
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        ClasseEstoque.ExcluirEstoque(txtProdutos.Text)
    End Sub
    Private Sub cboFornecedores_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFornecedores.LostFocus
    End Sub

End Class