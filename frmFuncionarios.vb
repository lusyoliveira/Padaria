Imports System.Data.SqlClient

Public Class frmFuncionarios
    Private Sub Limpar()
        grpFuncionarios.Tag = 0
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        cboCidade.Text = ""
        cbouf.Text = ""
        mkdCEP.Text = ""
        mkdCpf.Text = ""
        mkdRG.Text = ""
        mkdTelefone.Text = ""
        mkdcelular.Text = ""
        txtCargo.Text = ""
        txtSalario.Text = ""
        txtNumero.Text = ""
        mkdPis.Text = ""
        mkdCarteira.Text = ""
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        MdiParent = frmPrincipal
        txtNome.Focus()
    End Sub
    Private Sub lstFuncionarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFuncionarios.SelectedIndexChanged
        If lstFuncionarios.SelectedItems.Count = 0 Then
            Limpar()
            Exit Sub
        End If
        grpFuncionarios.Tag = Val(lstFuncionarios.SelectedItems(0).SubItems(0).Text)
        txtNome.Text = lstFuncionarios.SelectedItems(0).SubItems(0).Text
        txtEndereco.Text = lstFuncionarios.SelectedItems(0).SubItems(1).Text
        txtBairro.Text = lstFuncionarios.SelectedItems(0).SubItems(2).Text
        cboCidade.Text = lstFuncionarios.SelectedItems(0).SubItems(3).Text
        cbouf.Text = lstFuncionarios.SelectedItems(0).SubItems(4).Text
        mkdCEP.Text = lstFuncionarios.SelectedItems(0).SubItems(5).Text
        mkdCpf.Text = lstFuncionarios.SelectedItems(0).SubItems(6).Text
        mkdRG.Text = lstFuncionarios.SelectedItems(0).SubItems(7).Text
        mkdTelefone.Text = lstFuncionarios.SelectedItems(0).SubItems(8).Text
        mkdcelular.Text = lstFuncionarios.SelectedItems(0).SubItems(9).Text
        txtNumero.Text = lstFuncionarios.SelectedItems(0).SubItems(10).Text
        txtCargo.Text = lstFuncionarios.SelectedItems(0).SubItems(11).Text
        txtSalario.Text = lstFuncionarios.SelectedItems(0).SubItems(12).Text
        mkdPis.Text = lstFuncionarios.SelectedItems(0).SubItems(13).Text
        mkdCarteira.Text = lstFuncionarios.SelectedItems(0).SubItems(14).Text
        txtNome.Enabled = False
    End Sub
    Private Sub CarregarFuncionarios()
        Dim sql As String = "SELECT * FROM tbFuncionarios WHERE nome LIKE @nome"

        Limpar()
        lstFuncionarios.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            If IsNumeric(txtNome.Text) Then
                cmd.CommandText = "SELECT * FROM tbFuncionarios WHERE numeroregistro = @numeroregistro"
                cmd.Parameters.AddWithValue("@numeroregistro", txtNome.Text)
            Else
                cmd.Parameters.AddWithValue("@nome", "%" & txtNome.Text & "%")
            End If

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstFuncionarios.Items.Add(reader("nome").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("endereco").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("bairro").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("cidade").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("estado").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("cep").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("cpf").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("rg").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("telefone").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("celular").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("numeroregistro").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("cargo").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("salario").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("pis").ToString())
                        lstFuncionarios.Items(lstFuncionarios.Items.Count - 1).SubItems.Add(reader("numerocarteira").ToString())
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar funcionários: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String = "INSERT INTO tbFuncionarios (nome, endereco, bairro, cidade, estado, cep, cpf, rg, telefone, celular, numeroregistro, cargo, salario, pis, numerocarteira) VALUES (@nome, @endereco, @bairro, @cidade, @estado, @cep, @cpf, @rg, @telefone, @celular, @numeroregistro, @cargo, @salario, @pis, @numerocarteira)"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", cboCidade.Text)
            cmd.Parameters.AddWithValue("@estado", cbouf.Text)
            cmd.Parameters.AddWithValue("@cep", mkdCEP.Text)
            cmd.Parameters.AddWithValue("@cpf", mkdCpf.Text)
            cmd.Parameters.AddWithValue("@rg", mkdRG.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", mkdcelular.Text)
            cmd.Parameters.AddWithValue("@numeroregistro", txtNumero.Text)
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text)
            cmd.Parameters.AddWithValue("@salario", FormatCurrency(txtSalario.Text))
            cmd.Parameters.AddWithValue("@pis", mkdPis.Text)
            cmd.Parameters.AddWithValue("@numerocarteira", mkdCarteira.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
                CarregarFuncionarios()
                Limpar()
            Catch ex As Exception
                MsgBox("Erro ao salvar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim sql As String = "DELETE FROM tbFuncionarios WHERE nome = @nome"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information)
                CarregarFuncionarios()
                Limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim sql As String = "UPDATE tbFuncionarios SET nome = @nome, endereco = @endereco, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, cpf = @cpf, rg = @rg, telefone = @telefone, celular = @celular, cargo = @cargo, salario = @salario, pis = @pis, numerocarteira = @numerocarteira, numeroregistro = @numeroregistro WHERE nome = @nomeAtual"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", cboCidade.Text)
            cmd.Parameters.AddWithValue("@estado", cbouf.Text)
            cmd.Parameters.AddWithValue("@cep", mkdCEP.Text)
            cmd.Parameters.AddWithValue("@cpf", mkdCpf.Text)
            cmd.Parameters.AddWithValue("@rg", mkdRG.Text)
            cmd.Parameters.AddWithValue("@telefone", mkdTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", mkdcelular.Text)
            cmd.Parameters.AddWithValue("@numeroregistro", txtNumero.Text)
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text)
            cmd.Parameters.AddWithValue("@salario", txtSalario.Text)
            cmd.Parameters.AddWithValue("@pis", mkdPis.Text)
            cmd.Parameters.AddWithValue("@numerocarteira", mkdCarteira.Text)
            cmd.Parameters.AddWithValue("@nomeAtual", txtNome.Text)

            Try
                aConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information)
                CarregarFuncionarios()
                txtNome.Focus()
            Catch ex As Exception
                MsgBox("Erro ao alterar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim wcpagina As Integer = 1
        Dim sql As String = "SELECT * FROM tbFuncionarios"

        If Not PrintDocument1.PrintController.IsPreview Then
            Dim printDialog As New PrintDialog()
            If printDialog.ShowDialog() = DialogResult.OK Then
                PrintDocument1.PrinterSettings = printDialog.PrinterSettings
                Using cmd As New SqlCommand(sql, aConexao)
                    Try
                        aConexao.Open()
                        Dim reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Fazer algo com os dados, se necessário
                        End While
                    Catch ex As Exception
                        MsgBox("Erro ao carregar dados para impressão: " & ex.Message, MsgBoxStyle.Critical)
                    Finally
                        aConexao.Close()
                    End Try
                End Using
            End If
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim sql As String = "SELECT * FROM tbFuncionarios"
        Dim wcpagina As Integer = 1
        Dim Y As Integer = 100
        Dim lineHeight As Integer = 15
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim Pulou As Boolean = False

        e.Graphics.DrawString("Relatório de Funcionários", MYFONT3, Brushes.Black, 300, 80)
        e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, 50, 120)
        e.Graphics.DrawString("Nome", MYFONT3, Brushes.Black, 150, 120)
        e.Graphics.DrawString("Endereço", MYFONT3, Brushes.Black, 300, 120)
        e.Graphics.DrawString("Telefone", MYFONT3, Brushes.Black, 500, 120)

        Using cmd As New SqlCommand(sql, aConexao)
            Try
                aConexao.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    If Y < e.MarginBounds.Height Then
                        e.Graphics.DrawString(reader("codigo").ToString(), MYFONT, Brushes.Black, 50, Y)
                        e.Graphics.DrawString(reader("nome").ToString(), MYFONT, Brushes.Black, 150, Y)
                        e.Graphics.DrawString(reader("endereco").ToString(), MYFONT, Brushes.Black, 300, Y)
                        e.Graphics.DrawString(reader("telefone").ToString(), MYFONT, Brushes.Black, 500, Y)
                        Y += lineHeight
                    Else
                        Pulou = True
                        Exit While
                    End If
                End While
                reader.Close()
            Catch ex As Exception
                MsgBox("Erro ao carregar dados para impressão: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using

        If Pulou Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            Y = 100
        End If
    End Sub

End Class