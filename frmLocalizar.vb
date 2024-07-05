Imports System.Data.SqlClient

Public Class frmLocalizar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalizar.Click
        Dim sql As String = ""
        Dim x As Integer = 0

        lstLocalizar.Items.Clear()

        Select Case cboItens.Text
            Case "Clientes"
                sql = "SELECT * FROM tbClientes WHERE nome LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbClientes WHERE nrficha = " & txtLocalizar.Text
                End If
            Case "Produtos"
                sql = "SELECT * FROM tbProdutos WHERE produto LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbProdutos WHERE codprod = " & txtLocalizar.Text
                End If
            Case "Funcionários"
                sql = "SELECT * FROM tbFuncionarios WHERE nome LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbFuncionarios WHERE codigo = " & txtLocalizar.Text
                End If
            Case "Fornecedores"
                sql = "SELECT * FROM tbFornecedores WHERE Empresa LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbFornecedores WHERE codigo = " & txtLocalizar.Text
                End If
            Case "Estoque"
                sql = "SELECT * FROM tbEstoque WHERE produto LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbEstoque WHERE codprod = " & txtLocalizar.Text
                End If
            Case Else
                MsgBox("Selecione uma tabela!", MsgBoxStyle.Exclamation)
                cboItens.Focus()
                Exit Sub
        End Select

        Dim cmd As New SqlCommand(sql, aConexao)
        Try
            aConexao.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Select Case cboItens.Text
                        Case "Clientes"
                            lstLocalizar.Items.Add(reader("codigo").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("nome").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("nrficha").ToString())
                        Case "Produtos"
                            lstLocalizar.Items.Add(reader("codprod").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("produto").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("validade").ToString())
                        Case "Funcionários"
                            lstLocalizar.Items.Add(reader("codigo").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("nome").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("salario").ToString())
                        Case "Fornecedores"
                            lstLocalizar.Items.Add(reader("codigo").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("Empresa").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("telefone").ToString())
                        Case "Estoque"
                            lstLocalizar.Items.Add(reader("codprod").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("produto").ToString())
                            lstLocalizar.Items(x).SubItems.Add(reader("quantidade").ToString())
                    End Select
                    x += 1
                End While

                If x = 0 Then
                    MsgBox("Nenhum registro encontrado.", MsgBoxStyle.Information)
                    txtLocalizar.Focus()
                End If

                reader.Close()
            Catch ex As Exception
                MsgBox("Erro ao executar consulta: " & ex.Message, MsgBoxStyle.Critical)
            End Try

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
        txtLocalizar.Focus()
    End Sub
End Class