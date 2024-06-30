Public Class frmLocalizar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalizar.Click
        Dim tbClientes, tbProdutos, tbFuncionarios, tbFornecedores, tbEstoque As ADODB.Recordset, sql As String, x As Integer

        Select Case cboItens.Text
            Case Is = "Clientes"
                lstLocalizar.Items.Clear()
                sql = "select * from tbClientes where nome like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbClientes where nrficha = " & txtLocalizar.Text
                End If
                tbClientes = RecebeTabela(sql)
                If tbClientes.RecordCount > 0 Then
                    tbClientes.MoveFirst()
                    Do Until tbClientes.EOF
                        lstLocalizar.Items.Add(tbClientes("codigo").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbClientes("nome").Value.ToString)
                        lstLocalizar.Items(x).SubItems.Add(tbClientes("nrficha").Value)
                        x += 1
                        tbClientes.MoveNext()
                    Loop
                Else
                    MsgBox("Esse Cliente Não Existe", MsgBoxStyle.Exclamation)
                    Exit Sub
                    txtLocalizar.Focus()
                End If
            Case Is = "Produtos"
                lstLocalizar.Items.Clear()
                sql = "select * from tbProdutos where produto like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbProdutos where codprod = " & txtLocalizar.Text
                End If
                tbProdutos = RecebeTabela(sql)
                If tbProdutos.RecordCount > 0 Then
                    tbProdutos.MoveFirst()
                    Do Until tbProdutos.EOF
                        lstLocalizar.Items.Add(tbProdutos("codprod").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbProdutos("produto").Value.ToString)
                        lstLocalizar.Items(x).SubItems.Add(tbProdutos("validade").Value)
                        x += 1
                        tbProdutos.MoveNext()
                    Loop
                Else
                    MsgBox("Esse Produto Não Existe", MsgBoxStyle.Exclamation)
                    Exit Sub
                    txtLocalizar.Focus()
                End If
            Case Is = "Funcionários"
                lstLocalizar.Items.Clear()
                sql = "select * from tbFuncionarios where nome like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbFuncionarios where codigo = " & txtLocalizar.Text
                End If
                tbFuncionarios = RecebeTabela(sql)
                If tbFuncionarios.RecordCount > 0 Then
                    tbFuncionarios.MoveFirst()
                    Do Until tbFuncionarios.EOF
                        lstLocalizar.Items.Add(tbFuncionarios("codigo").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbFuncionarios("nome").Value.ToString)
                        lstLocalizar.Items(x).SubItems.Add(tbFuncionarios("salario").Value)
                        x += 1
                        tbFuncionarios.MoveNext()
                    Loop
                Else
                    MsgBox("Esse Funcionário Não Existe", MsgBoxStyle.Exclamation)
                    Exit Sub
                    txtLocalizar.Focus()
                End If
            Case Is = "Fornecedores"
                lstLocalizar.Items.Clear()
                sql = "select * from tbFornecedores where Empresa like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbFornecedores where codigo = " & txtLocalizar.Text
                End If
                tbFornecedores = RecebeTabela(sql)
                If tbFornecedores.RecordCount > 0 Then
                    tbFornecedores.MoveFirst()
                    Do Until tbFornecedores.EOF
                        lstLocalizar.Items.Add(tbFornecedores("codigo").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbFornecedores("empresa").Value.ToString)
                        lstLocalizar.Items(x).SubItems.Add(tbFornecedores("telefone").Value)
                        x += 1
                        tbFornecedores.MoveNext()
                    Loop
                Else
                    MsgBox("Esse Fornecedor Não Existe", MsgBoxStyle.Exclamation)
                    Exit Sub
                    txtLocalizar.Focus()
                End If
            Case Is = "Estoque"
                lstLocalizar.Items.Clear()
                sql = "select * from tbEstoque where produto like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbEstoque where codprod = " & txtLocalizar.Text
                End If
                tbEstoque = RecebeTabela(sql)
                If tbEstoque.RecordCount > 0 Then
                    tbEstoque.MoveFirst()
                    Do Until tbEstoque.EOF
                        lstLocalizar.Items.Add(tbEstoque("codprod").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbEstoque("produto").Value.ToString)
                        lstLocalizar.Items(x).SubItems.Add(tbEstoque("quantidade").Value)
                        x += 1
                        tbEstoque.MoveNext()
                    Loop
                Else
                    MsgBox("Esse Unidade Não Existe", MsgBoxStyle.Exclamation)
                    Exit Sub
                    txtLocalizar.Focus()
                End If
            Case Else
                MsgBox("Selecione Uma Tabela!", MsgBoxStyle.Exclamation)
                Exit Sub
                cboItens.Focus()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

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
        MdiParent = frmPrincipal
        txtLocalizar.Focus()
    End Sub
End Class