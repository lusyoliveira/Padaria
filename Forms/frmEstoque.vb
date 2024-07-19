Public Class frmEstoque
    Dim ClasseEstoque As New clsEstoque, ClasseCombo As New clsCombo
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
        ClasseEstoque.PesquisaEstoque(lstEstoque, 0, "")
    End Sub
    Private Sub txtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.LostFocus
        txtDataentrada.Text = Date.Now.Date
    End Sub
    Private Sub lstEstoque_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstEstoque.LostFocus
        txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub
    Private Sub lstEstoque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEstoque.SelectedIndexChanged
        If lstEstoque.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEstoque.SelectedItems(0).SubItems(0).Text)
            txtProdutos.Text = lstEstoque.SelectedItems(0).SubItems(1).Text
            txtQuantidade.Text = lstEstoque.SelectedItems(0).SubItems(2).Text
            cboTipo.Text = lstEstoque.SelectedItems(0).SubItems(3).Text
            txtValor.Text = lstEstoque.SelectedItems(0).SubItems(4).Text
            txtDataentrada.Text = lstEstoque.SelectedItems(0).SubItems(5).Text
            cboFornecedores.Text = lstEstoque.SelectedItems(0).SubItems(6).Text
        End If

    End Sub

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a entrada de estoque?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseEstoque.EntradaEstoque(txtProdutos.Text, txtQuantidade.Text, cboTipo.Text, txtValor.Text, txtDataentrada.Text, ClasseEstoque.CodForn)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a entrada de estoque?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseEstoque.SaidaEstoque(txtProdutos.Text, txtQuantidade.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        ClasseEstoque.ExcluirEstoque(txtProdutos.Text)
    End Sub
    Private Sub cboFornecedores_Leave(sender As Object, e As EventArgs) Handles cboFornecedores.Leave
        ClasseEstoque.CodForn = ClasseCombo.LerCombo(cboFornecedores)
    End Sub

    Private Sub cboFornecedores_Enter(sender As Object, e As EventArgs) Handles cboFornecedores.Enter
        ClasseCombo.CarregaCombo(cboFornecedores, "SELECT Codigo, Empresa FROM tbFornecedores ORDER BY Empresa")
    End Sub
End Class