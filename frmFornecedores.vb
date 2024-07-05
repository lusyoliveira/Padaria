Imports System.Data.SqlClient

Public Class frmFornecedores
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
    Private Sub CarregarFornecedores()
        Dim sql As String = "SELECT * FROM tbFornecedores WHERE empresa LIKE @empresa"

        limpar()
        lstFornecedores.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            If IsNumeric(txtEmpresa.Text) Then
                cmd.CommandText = "SELECT * FROM tbFornecedores WHERE codigo = @codigo"
                cmd.Parameters.AddWithValue("@codigo", txtEmpresa.Text)
            Else
                cmd.Parameters.AddWithValue("@empresa", "%" & txtEmpresa.Text & "%")
            End If

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstFornecedores.Items.Add(reader("empresa").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("endereco").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("bairro").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("complemento").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("cidade").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("cnpj").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("uf").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("cep").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("fornecedor").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("telefone").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("celular").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("site").ToString())
                        lstFornecedores.Items(lstFornecedores.Items.Count - 1).SubItems.Add(reader("email").ToString())
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar fornecedores: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String = "INSERT INTO tbFornecedores (empresa, endereco, bairro, complemento, cidade, cnpj, uf, cep, fornecedor, telefone, celular, site, email) VALUES (@empresa, @endereco, @bairro, @complemento, @cidade, @cnpj, @uf, @cep, @fornecedor, @telefone, @celular, @site, @email)"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
            cmd.Parameters.AddWithValue("@cidade", cboCidade.Text)
            cmd.Parameters.AddWithValue("@cnpj", mkdCNPJ.Text)
            cmd.Parameters.AddWithValue("@uf", cbouf.Text)
            cmd.Parameters.AddWithValue("@cep", mkdCEP.Text)
            cmd.Parameters.AddWithValue("@fornecedor", txtFornecedor.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", mkdCelular.Text)
            cmd.Parameters.AddWithValue("@site", txtSite.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
                CarregarFornecedores()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao salvar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim sql As String = "UPDATE tbFornecedores SET empresa = @empresa, endereco = @endereco, bairro = @bairro, complemento = @complemento, cidade = @cidade, cnpj = @cnpj, uf = @uf, cep = @cep, telefone = @telefone, celular = @celular, site = @site, email = @email WHERE empresa = @empresa"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
            cmd.Parameters.AddWithValue("@cidade", cboCidade.Text)
            cmd.Parameters.AddWithValue("@cnpj", mkdCNPJ.Text)
            cmd.Parameters.AddWithValue("@uf", cbouf.Text)
            cmd.Parameters.AddWithValue("@cep", mkdCEP.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", mkdCelular.Text)
            cmd.Parameters.AddWithValue("@site", txtSite.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information)
                CarregarFornecedores()
                txtEmpresa.Focus()
            Catch ex As Exception
                MsgBox("Erro ao alterar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim sql As String = "DELETE FROM tbFornecedores WHERE empresa = @empresa"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information)
                CarregarFornecedores()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub

    Private Sub frmFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()
        CarregarFornecedores()
    End Sub
End Class
