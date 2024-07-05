Imports System.Data.SqlClient

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
    Private Sub frmEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtProdutos.Focus()
        CarregarEstoque()
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
    Private Sub CarregarEstoque()
        Dim sql As String = "SELECT * FROM tbEstoque WHERE produto LIKE @produto"

        lstEstoque.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            If IsNumeric(txtProdutos.Text) Then
                cmd.CommandText = "SELECT * FROM tbEstoque WHERE codigo = @codigo"
                cmd.Parameters.AddWithValue("@codigo", txtProdutos.Text)
            Else
                cmd.Parameters.AddWithValue("@produto", "%" & txtProdutos.Text & "%")
            End If

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstEstoque.Items.Add(reader("produto").ToString())
                        lstEstoque.Items(lstEstoque.Items.Count - 1).SubItems.Add(reader("quantidade").ToString())
                        lstEstoque.Items(lstEstoque.Items.Count - 1).SubItems.Add(reader("tipo").ToString())
                        lstEstoque.Items(lstEstoque.Items.Count - 1).SubItems.Add(reader("dataentrada").ToString())
                        lstEstoque.Items(lstEstoque.Items.Count - 1).SubItems.Add(FormatCurrency(reader("valor").ToString()))
                        lstEstoque.Items(lstEstoque.Items.Count - 1).SubItems.Add(reader("fornecedor").ToString())
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar estoque: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        Dim sql As String = "INSERT INTO tbEstoque (produto, quantidade, tipo, valor, dataentrada, fornecedor) VALUES (@produto, @quantidade, @tipo, @valor, @dataentrada, @fornecedor)"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@produto", txtProdutos.Text)
            cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
            cmd.Parameters.AddWithValue("@tipo", cboTipo.Text)
            cmd.Parameters.AddWithValue("@valor", txtValor.Text)
            cmd.Parameters.AddWithValue("@dataentrada", txtDataentrada.Text)
            cmd.Parameters.AddWithValue("@fornecedor", cboFornecedores.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
                CarregarEstoque()
                Limpar()
            Catch ex As Exception
                MsgBox("Erro ao salvar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        Dim sql As String = "UPDATE tbEstoque SET quantidade = quantidade - 1 WHERE produto = @produto"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@produto", txtProdutos.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Saída registrada com sucesso!", MsgBoxStyle.Information)
                CarregarEstoque()
            Catch ex As Exception
                MsgBox("Erro ao registrar saída: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim sql As String = "DELETE FROM tbEstoque WHERE produto = @produto"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@produto", txtProdutos.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information)
                CarregarEstoque()
                Limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub cboFornecedores_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFornecedores.LostFocus
        Dim sql As String = "SELECT * FROM tbFornecedores WHERE empresa = @empresa"

        If cboFornecedores.Text = "" Then
            Exit Sub
        End If

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@empresa", cboFornecedores.Text)

            Try
                aConexao.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    MsgBox("Atenção: O fornecedor não existe!", MsgBoxStyle.Information)
                    cboFornecedores.Text = ""
                    cboFornecedores.Focus()
                Else
                    reader.Read()
                    cboFornecedores.Tag = reader("codigo").ToString()
                End If
            Catch ex As Exception
                MsgBox("Erro ao verificar fornecedor: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub

End Class