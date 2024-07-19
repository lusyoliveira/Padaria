Imports System.IO
Imports System.Text
Public Class frmProdutos
    Dim ClasseProdutos As New clsProdutos
    Private Sub Limpar()
        grpProdutos.Tag = 0
        txtCodigo.Text = ""
        txtProduto.Text = ""
        txtValidade.Text = ""
        txtValorUnit.Text = ""
        lstProduto.Items.Clear()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseProdutos.ConsultaProduto(lstProduto, Val(txtCodigo.Text), txtProduto.Text)
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.SalvarProduto(txtProduto.Text, txtValidade.Text, txtValorUnit.Text, Val(txtQuantidade.Text))
            Limpar()
            ClasseProdutos.ConsultaProduto(lstProduto, Val(txtCodigo.Text), txtProduto.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a exclusão do produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.ExcluirProduto(Val(txtCodigo.Text))
            Limpar()
            ClasseProdutos.ConsultaProduto(lstProduto, Val(txtCodigo.Text), txtProduto.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteracao do produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.AlterarProduto(Val(txtCodigo.Text), txtProduto.Text, txtValidade.Text, txtValorUnit.Text)
            Limpar()
            ClasseProdutos.ConsultaProduto(lstProduto, Val(txtCodigo.Text), txtProduto.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProduto.SelectedIndexChanged
        If lstProduto.SelectedItems.Count > 0 Then

            txtCodigo.Text = lstProduto.SelectedItems(0).SubItems(0).Text
            txtProduto.Text = lstProduto.SelectedItems(0).SubItems(1).Text
            txtValorUnit.Text = lstProduto.SelectedItems(0).SubItems(2).Text
            txtValidade.Text = lstProduto.SelectedItems(0).SubItems(3).Text
            txtQuantidade.Text = lstProduto.SelectedItems(0).SubItems(4).Text
            txtCodigo.Enabled = False
        End If
    End Sub
    Private Sub ExportarXLS(ByVal oListView As ListView)
        Try
            Using oSF As New SaveFileDialog
                oSF.Filter = "Ficheiro do Excel (*.xls)|*.xls"
                If oSF.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Cria o ficheiro..
                    Using oSR As New StreamWriter(oSF.FileName, False, Encoding.Default)
                        Const cQuo As String = """"
                        Const cTab As String = vbTab
                        ' Adiciona o cabeçalho..
                        For Each oColumn As ColumnHeader In oListView.Columns
                            If Not oColumn.Index = (oListView.Columns.Count - 1) Then
                                oSR.Write(oColumn.Text & cTab)
                            Else
                                oSR.Write(oColumn.Text)
                            End If
                        Next
                        oSR.WriteLine()
                        ' Escreve todos os rows..
                        For Each oItem As ListViewItem In oListView.Items
                            ' Escreve o primeiro item
                            oSR.Write(cQuo & oItem.Text & cQuo & cTab)
                            ' Escreve os restantes subitems
                            For i As Integer = 1 To (oItem.SubItems.Count - 1)
                                oSR.Write(cQuo & oItem.SubItems(i).Text & cQuo & cTab)
                            Next
                            oSR.WriteLine()
                        Next
                        MessageBox.Show("Ficheiro exportado com êxito!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
