Imports System.IO
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Text.Encoding
Imports System.Text.ASCIIEncoding
Imports System.Text.UnicodeEncoding
Imports System.Text.UTF7Encoding
Imports System.Text.UTF8Encoding

Public Class frmProdutos
    Private Sub Limpar()
        grpProdutos.Tag = 0
        txtCodigo.Text = ""
        txtProduto.Text = ""
        txtValidade.Text = ""
        txtValorUnit.Text = ""
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbProdutos As ADODB.Recordset

        tbProdutos = RecebeTabela("select * from tbProdutos where codigo = " & grpProdutos.Tag)
        If grpProdutos.Tag = 0 Then tbProdutos.AddNew()
        tbProdutos("codprod").Value = txtCodigo.Text
        tbProdutos("produto").Value = txtProduto.Text
        tbProdutos("validade").Value = txtValidade.Text
        tbProdutos("valorunit").Value = txtValorUnit.Text
        tbProdutos.Update()
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        CarregarFilmes()
        Limpar()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbProdutos As ADODB.Recordset

        tbProdutos = RecebeTabela("select * from tbProdutos where produtos = '" & txtProduto.Text & "'")
        If tbProdutos.RecordCount = 0 Then Exit Sub
        tbProdutos.Delete()
        CarregarFilmes()
        Limpar()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        CarregarFilmes()
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbProdutos As ADODB.Recordset

        tbProdutos = RecebeTabela("update tbProdutos set produto = '" & txtProduto.Text & "', validade = '" & txtValidade.Text & "', valorunit = '" & txtValorUnit.Text & "' where codprod = '" & txtCodigo.Text & "'")
        MsgBox("Registro alterardo com sucesso!", MsgBoxStyle.Information)
        CarregarFilmes()
        txtCodigo.Focus()
    End Sub
    Private Sub CarregarFilmes()
        Dim tbProdutos As ADODB.Recordset, x As Integer, sql As String
        Limpar()
        lstProduto.Items.Clear()
        sql = "select * from tbProdutos where produto like '%" & txtProduto.Text & "%'"
        If IsNumeric(txtCodigo.Text) Then
            sql = "select * from tbProdutos where codigo = " & txtCodigo.Text
        End If
        tbProdutos = RecebeTabela(sql)
        If tbProdutos.RecordCount > 0 Then
            tbProdutos.MoveFirst()
            Do Until tbProdutos.EOF
                lstProduto.Items.Add(tbProdutos("codprod").Value)
                lstProduto.Items(x).SubItems.Add(tbProdutos("produto").Value)
                lstProduto.Items(x).SubItems.Add(FormatCurrency(tbProdutos("valorunit").Value))
                lstProduto.Items(x).SubItems.Add(tbProdutos("validade").Value)
                lstProduto.Items(x).SubItems.Add(tbProdutos("quantidade").Value)
                If x Mod 2 = 0 Then
                    lstProduto.Items(x).ForeColor = Color.Black
                    lstProduto.Items(x).BackColor = Color.LightGray
                Else
                    lstProduto.Items(x).ForeColor = Color.Black
                    lstProduto.Items(x).BackColor = Color.White
                End If
                x += 1
                tbProdutos.MoveNext()
            Loop
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
