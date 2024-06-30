Public Class frmEstoque

    Private Sub Limpar()
        grpEstoque.Tag = 0
        txtProdutos.Text = ""
        txtQuantidade.Text = ""
        txtValor.Text = ""
        txtDataentrada.Text = ""
        cboTipo.Text = ""
        cboFornecedores.Text = ""
    End Sub
    Private Sub CarregarEstoque()
        Dim tbEstoque As ADODB.Recordset, x As Integer, sql As String
        Limpar()
        lstEstoque.Items.Clear()
        sql = "select * from tbEstoque where produto like '%" & txtProdutos.Text & "%'"
        If IsNumeric(txtProdutos.Text) Then
            sql = "select * from tbEstoque where codigo = " & txtProdutos.Text
        End If
        tbEstoque = RecebeTabela(sql)
        If tbEstoque.RecordCount > 0 Then
            tbEstoque.MoveFirst()
            Do Until tbEstoque.EOF
                lstEstoque.Items.Add(tbEstoque("produto").Value)
                lstEstoque.Items(x).SubItems.Add(tbEstoque("quantidade").Value)
                lstEstoque.Items(x).SubItems.Add(tbEstoque("tipo").Value)
                lstEstoque.Items(x).SubItems.Add(tbEstoque("dataentrada").Value)
                lstEstoque.Items(x).SubItems.Add(FormatCurrency(tbEstoque("valor").Value))
                lstEstoque.Items(x).SubItems.Add(tbEstoque("fornecedor").Value)
                If x Mod 2 = 0 Then
                    lstEstoque.Items(x).ForeColor = Color.Black
                    lstEstoque.Items(x).BackColor = Color.LightGray
                Else
                    lstEstoque.Items(x).ForeColor = Color.Black
                    lstEstoque.Items(x).BackColor = Color.White
                End If
                x += 1
                tbEstoque.MoveNext()
            Loop
        End If
    End Sub
    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        Dim tbEstoque As ADODB.Recordset

        tbEstoque = RecebeTabela("select * from tbEstoque where codigo = " & grpEstoque.Tag)
        If grpEstoque.Tag = 0 Then tbEstoque.AddNew()
        tbEstoque("produto").Value = txtProdutos.Text
        tbEstoque("quantidade").Value = txtQuantidade.Text
        tbEstoque("tipo").Value = cboTipo.Text
        tbEstoque("valor").Value = FormatCurrency(txtValor.Text)
        tbEstoque("dataentrada").Value = txtDataentrada.Text
        tbEstoque("fornecedor").Value = cboFornecedores.Text
        tbEstoque.Update()
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        CarregarEstoque()
        Limpar()
    End Sub

    Private Sub frmEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtProdutos.Focus()
        CarregarEstoque()
    End Sub

    Private Sub txtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.LostFocus
        txtDataentrada.Text = Date.Now.Date
    End Sub

    Private Sub cboFornecedores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFornecedores.GotFocus
        Dim tbFornecedores As ADODB.Recordset

        cboFornecedores.Items.Clear()
        tbFornecedores = RecebeTabela("Select * from tbFornecedores order by empresa")
        If tbFornecedores.RecordCount <> 0 Then
            tbFornecedores.MoveFirst()
            While tbFornecedores.EOF = False
                cboFornecedores.Items.Add(tbFornecedores("empresa").Value.ToString)
                tbFornecedores.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboFornecedores_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFornecedores.LostFocus
        Dim tbFornecedores As ADODB.Recordset

        If cboFornecedores.Text = "" Then
            Exit Sub
        End If
        tbFornecedores = RecebeTabela("Select * from tbFornecedores where empresa = '" & cboFornecedores.Text & "'")
        If tbFornecedores.RecordCount = 0 Then
            MsgBox("Atenção: O fornecedor não existe!")
            Exit Sub
            cboFornecedores.Focus()
        End If
        cboFornecedores.Tag = tbFornecedores("codigo").Value
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
    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        Dim tbEstoque As ADODB.Recordset

        tbEstoque = RecebeTabela("update tbEstoque set quantidade = quantidade - 1 where produto = '" & txtProdutos.Text & "'")
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbEstoque As ADODB.Recordset

        tbEstoque = RecebeTabela("select * from tbProdutos where produtos = '" & txtProdutos.Text & "'")
        If tbEstoque.RecordCount = 0 Then Exit Sub
        tbEstoque.Delete()
        CarregarEstoque()
        Limpar()
    End Sub
End Class