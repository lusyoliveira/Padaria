Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub Limpar()
        grpDados.Tag = 0
        txtNrficha.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        mkdTelefone.Text = ""
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        lblData.Text = Date.Now.Date
        lblRegistro.Text = ContarRegistros()
        txtNrficha.Focus()
    End Sub
    Private Sub btnDependentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDependentes.Click
        frmDependentes.Show()
    End Sub
    Private Sub CarregarDependentes()
        Dim sql As String = "SELECT nome FROM tbDependentes WHERE codigocliente = @nrficha"

        lstDependentes.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", txtNrficha.Text)

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstDependentes.Items.Add(reader("nome").ToString())
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar dependentes: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String = ""

        If grpDados.Tag = 0 Then
            sql = "INSERT INTO tbClientes (nrficha, nome, endereco, bairro, telefone, datacad) VALUES (@nrficha, @nome, @endereco, @bairro, @telefone, @datacad)"
        Else
            sql = "UPDATE tbClientes SET nome = @nome, endereco = @endereco, bairro = @bairro, telefone = @telefone WHERE codigo = @codigo"
        End If

        Using cmd As New SqlCommand(sql, aConexao)
            If grpDados.Tag = 0 Then
                cmd.Parameters.AddWithValue("@nrficha", txtNrficha.Text)
                cmd.Parameters.AddWithValue("@datacad", lblData.Text)
            Else
                cmd.Parameters.AddWithValue("@codigo", grpDados.Tag)
            End If

            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
                Limpar()
                ContarRegistros()
            Catch ex As Exception
                MsgBox("Erro ao salvar o registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtNrficha.Text = "" Then
            MsgBox("Número da ficha inválido!", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MsgBox("Tem Certeza Que Deseja Excluir o Cliente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If result = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM tbClientes WHERE nrficha = @nrficha"

            Using cmd As New SqlCommand(sql, aConexao)
                cmd.Parameters.AddWithValue("@nrficha", txtNrficha.Text)

                Try
                    aConexao.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information)
                    Limpar()
                    ContarRegistros()
                Catch ex As Exception
                    MsgBox("Erro ao excluir o cliente: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    aConexao.Close()
                End Try
            End Using
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim sql As String = "UPDATE tbClientes SET nome = @nome, endereco = @endereco, bairro = @bairro, telefone = @telefone WHERE nome = @nome"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information)
                txtNome.Focus()
            Catch ex As Exception
                MsgBox("Erro ao alterar o registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnVerifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifica.Click
        Dim sql As String = "SELECT nrficha FROM tbClientes WHERE nome LIKE @nome"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", "%" & txtNome.Text & "%")

            Try
                aConexao.Open()
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    MsgBox("O número de ficha já existe!", MsgBoxStyle.Information)
                    txtNrficha.Text = ""
                Else
                    MsgBox("O Número não existe!", MsgBoxStyle.Information)
                    txtNome.Focus()
                End If
            Catch ex As Exception
                MsgBox("Erro ao verificar o cliente: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Dim sql As String = ""

        If IsNumeric(txtNrficha.Text) Then
            sql = "SELECT * FROM tbClientes WHERE nrficha = @nrficha"
        Else
            sql = "SELECT * FROM tbClientes WHERE nome LIKE @nome"
        End If

        Using cmd As New SqlCommand(sql, aConexao)
            If IsNumeric(txtNrficha.Text) Then
                cmd.Parameters.AddWithValue("@nrficha", txtNrficha.Text)
            Else
                cmd.Parameters.AddWithValue("@nome", "%" & txtNome.Text & "%")
            End If

            Try
                aConexao.Open()
                Dim tbClientes As New DataTable()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(tbClientes)
                End Using

                If tbClientes.Rows.Count > 0 Then
                    txtNrficha.Text = tbClientes.Rows(0)("nrficha").ToString()
                    txtNome.Text = tbClientes.Rows(0)("nome").ToString()
                    txtEndereco.Text = tbClientes.Rows(0)("endereco").ToString()
                    txtBairro.Text = tbClientes.Rows(0)("bairro").ToString()
                    mkdTelefone.Text = tbClientes.Rows(0)("telefone").ToString()
                    CarregarDependentes()
                Else
                    MsgBox("Esse Cliente não Existe!", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox("Erro ao consultar o cliente: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
End Class