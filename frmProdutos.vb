
Imports System.Data.SqlClient

Public Class frmProdutos
    Private Sub Limpar()
        grpProdutos.Tag = 0
        txtCodigo.Text = ""
        txtProduto.Text = ""
        txtValidade.Text = ""
        txtValorUnit.Text = ""
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarFilmes()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String
        Dim tbProdutos As DataTable

        tbProdutos = RecebeTabela("select * from tbProdutos where codigo = " & grpProdutos.Tag)
        If grpProdutos.Tag = 0 Then
            ' Adicionar novo registro
            sql = $"insert into tbProdutos (codprod, produto, validade, valorunit) values ('{txtCodigo.Text}', '{txtProduto.Text}', '{txtValidade.Text}', '{txtValorUnit.Text}')"
        Else
            ' Atualizar registro existente
            sql = $"update tbProdutos set codprod = '{txtCodigo.Text}', produto = '{txtProduto.Text}', validade = '{txtValidade.Text}', valorunit = '{txtValorUnit.Text}' where codigo = {grpProdutos.Tag}"
        End If

        tbProdutos = RecebeTabela(sql)
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        CarregarFilmes()
        Limpar()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbProdutos As DataTable

        tbProdutos = RecebeTabela("select * from tbProdutos where produto = '" & txtProduto.Text & "'")
        If tbProdutos.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim sql As String = $"delete from tbProdutos where produto = '{txtProduto.Text}'"
        tbProdutos = RecebeTabela(sql)

        MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information)
        CarregarFilmes()
        Limpar()
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim sql As String
        Dim tbProdutos As DataTable

        sql = $"update tbProdutos set produto = '{txtProduto.Text}', validade = '{txtValidade.Text}', valorunit = '{txtValorUnit.Text}' where codprod = '{txtCodigo.Text}'"
        tbProdutos = RecebeTabela(sql)

        MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information)
        CarregarFilmes()
        txtCodigo.Focus()
    End Sub

    Private Sub CarregarFilmes()
        Dim tbProdutos As DataTable
        Dim x As Integer = 0
        Dim sql As String = "SELECT * FROM tbProdutos"

        Limpar()
        lstProduto.Items.Clear()

        If IsNumeric(txtCodigo.Text) Then
            sql = "SELECT * FROM tbProdutos"
        End If

        tbProdutos = RecebeTabela(sql)
        Using cmd As New SqlCommand(sql, aConexao)
            If IsNumeric(txtCodigo.Text) Then
                cmd.Parameters.AddWithValue("@codprod", txtCodigo.Text)
            End If

            Using da As New SqlDataAdapter(cmd)
                tbProdutos = New DataTable()
                da.Fill(tbProdutos)
            End Using
        End Using

        If tbProdutos.Rows.Count > 0 Then
            For Each row As DataRow In tbProdutos.Rows
                lstProduto.Items.Add(row("codprod").ToString())
                lstProduto.Items(x).SubItems.Add(row("produto").ToString())
                lstProduto.Items(x).SubItems.Add(FormatCurrency(row("valorunit")))
                lstProduto.Items(x).SubItems.Add(row("validade").ToString())
                lstProduto.Items(x).SubItems.Add(row("quantidade").ToString())
                If x Mod 2 = 0 Then
                    lstProduto.Items(x).ForeColor = Color.Black
                    lstProduto.Items(x).BackColor = Color.LightGray
                Else
                    lstProduto.Items(x).ForeColor = Color.Black
                    lstProduto.Items(x).BackColor = Color.White
                End If
                x += 1
            Next
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProduto.SelectedIndexChanged
        If lstProduto.SelectedItems.Count = 0 Then
            Limpar()
            Exit Sub
        End If
        grpProdutos.Tag = Val(lstProduto.SelectedItems(0).SubItems(0).Text)
        txtCodigo.Text = lstProduto.SelectedItems(0).SubItems(0).Text
        txtProduto.Text = lstProduto.SelectedItems(0).SubItems(1).Text
        txtValidade.Text = lstProduto.SelectedItems(0).SubItems(2).Text
        txtValorUnit.Text = lstProduto.SelectedItems(0).SubItems(3).Text
        txtQuantidade.Text = lstProduto.SelectedItems(0).SubItems(4).Text
        txtCodigo.Enabled = False
    End Sub
    'Private Sub ExportarXLS(ByVal oListView As ListView)
    '    Try
    '        Using oSF As New SaveFileDialog
    '            oSF.Filter = "Ficheiro do Excel (*.xls)|*.xls"
    '            If oSF.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                ' Cria o ficheiro..
    '                Using oSR As New StreamWriter(oSF.FileName, False, Encoding.Default)
    '                    Const cQuo As String = """"
    '                    Const cTab As String = vbTab
    '                    ' Adiciona o cabeçalho..
    '                    For Each oColumn As ColumnHeader In oListView.Columns
    '                        If Not oColumn.Index = (oListView.Columns.Count - 1) Then
    '                            oSR.Write(oColumn.Text & cTab)
    '                        Else
    '                            oSR.Write(oColumn.Text)
    '                        End If
    '                    Next
    '                    oSR.WriteLine()
    '                    ' Escreve todos os rows..
    '                    For Each oItem As ListViewItem In oListView.Items
    '                        ' Escreve o primeiro item
    '                        oSR.Write(cQuo & oItem.Text & cQuo & cTab)
    '                        ' Escreve os restantes subitems
    '                        For i As Integer = 1 To (oItem.SubItems.Count - 1)
    '                            oSR.Write(cQuo & oItem.SubItems(i).Text & cQuo & cTab)
    '                        Next
    '                        oSR.WriteLine()
    '                    Next
    '                    MessageBox.Show("Ficheiro exportado com êxito!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                End Using
    '            End If
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class
