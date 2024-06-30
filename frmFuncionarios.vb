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
    Private Sub CarregarFuncionarios()
        Dim tbFuncionarios As ADODB.Recordset, x As Integer, sql As String
        Limpar()
        lstFuncionarios.Items.Clear()
        sql = "select * from tbFuncionarios where nome like '%" & txtNome.Text & "%'"
        If IsNumeric(txtNome.Text) Then
            sql = "select * from tbFuncionarios where numeroregistro = " & txtNome.Text
        End If
        tbFuncionarios = RecebeTabela(sql)
        If tbFuncionarios.RecordCount > 0 Then
            tbFuncionarios.MoveFirst()
            Do Until tbFuncionarios.EOF
                lstFuncionarios.Items.Add(tbFuncionarios("nome").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("endereco").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("bairro").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("cidade").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("estado").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("cep").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("cpf").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("rg").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("telefone").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("celular").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("numeroregistro").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("cargo").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("salario").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("pis").Value)
                lstFuncionarios.Items(x).SubItems.Add(tbFuncionarios("numerocarteira").Value)
                If x Mod 2 = 0 Then
                    lstFuncionarios.Items(x).ForeColor = Color.Black
                    lstFuncionarios.Items(x).BackColor = Color.LightGray
                Else
                    lstFuncionarios.Items(x).ForeColor = Color.Black
                    lstFuncionarios.Items(x).BackColor = Color.White
                End If
                x += 1
                tbFuncionarios.MoveNext()
            Loop
        End If

    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbFuncionarios As ADODB.Recordset
        tbFuncionarios = RecebeTabela("select * from tbFuncionarios where codigo = " & grpFuncionarios.Tag)
        If grpFuncionarios.Tag = 0 Then tbFuncionarios.AddNew()
        tbFuncionarios("nome").Value = txtNome.Text
        tbFuncionarios("endereco").Value = txtEndereco.Text
        tbFuncionarios("bairro").Value = txtBairro.Text
        tbFuncionarios("cidade").Value = cboCidade.Text
        tbFuncionarios("estado").Value = cbouf.Text
        tbFuncionarios("cep").Value = mkdCEP.Text
        tbFuncionarios("cpf").Value = mkdCpf.Text
        tbFuncionarios("rg").Value = mkdRG.Text
        tbFuncionarios("telefone").Value = mkdTelefone.Text
        tbFuncionarios("celular").Value = mkdcelular.Text
        tbFuncionarios("cargo").Value = txtCargo.Text
        tbFuncionarios("salario").Value = FormatCurrency(txtSalario.Text)
        tbFuncionarios("numeroregistro").Value = txtNumero.Text
        tbFuncionarios("numerocarteira").Value = mkdCarteira.Text
        tbFuncionarios("pis").Value = mkdPis.Text
        tbFuncionarios.Update()
        CarregarFuncionarios()
        txtNome.Focus()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbFuncionarios As ADODB.Recordset
        tbFuncionarios = RecebeTabela("select * from tbFuncionarios where nome = '" & txtNome.Text & "'")
        If tbFuncionarios.RecordCount = 0 Then Exit Sub
        tbFuncionarios.Delete()
        CarregarFuncionarios()
        txtNome.Focus()
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

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbFuncionarios As ADODB.Recordset

        tbFuncionarios = RecebeTabela("Update tbFuncionarios set nome = '" & txtNome.Text & "', endereco = '" & txtEndereco.Text & "', bairro = '" & txtBairro.Text & "', cidade = '" & cboCidade.Text & "', estado = '" & cbouf.Text & "', cep = '" & mkdCEP.Text & "', cpf = '" & mkdCpf.Text & "', rg = '" & mkdRG.Text & "', telefone = '" & mkdTelefone.Text & "', celular = '" & mkdcelular.Text & "', cargo = '" & txtCargo.Text & "', salario = '" & txtSalario.Text & "', pis = '" & mkdPis.Text & "', numerocarteira = '" & mkdCarteira.Text & "', numeroregistro = '" & txtNumero.Text & "' where nome = '" & txtNome.Text & "'")
        MsgBox("Registro alterardo com sucesso!", MsgBoxStyle.Information)
        CarregarFuncionarios()
        txtNome.Focus()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim wcpagina As Integer, tbFuncionarios As ADODB.Recordset

        wcpagina = 1
        If PrintDocument1.PrintController.IsPreview = False Then
            PrintDialog1.ShowDialog()
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            tbFuncionarios = RecebeTabela("select * from tbFuncionarios")
            While tbFuncionarios.EOF = False
                PrintPreviewDialog1.Document = PrintDocument1
                tbFuncionarios.MoveNext()
            End While
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tbFuncionarios As ADODB.Recordset, wcimagem As Image, wcpagina As Integer

        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim Pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left
        Dim Y1 As Single = e.MarginBounds.Top
        Dim Line As Single = MYFONT.GetHeight(e.Graphics)
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics)
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics)

        wcimagem = Image.FromFile("C:\Users\Luzinha\My Projects\Locadora\Locadora\Resources\filmadora.jpg")
        e.Graphics.DrawImage(wcimagem, X1, Y1 - 30, 50, 50)
        e.Graphics.DrawString("Locadora", MYFONT2, Brushes.Black, X1 + 100, Y1)
        Y1 += Line2
        e.Graphics.DrawString("Relatório de Funcionários", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line3
        e.Graphics.DrawString("COD", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Salário", MYFONT3, Brushes.Black, X1 + 40, Y1)
        e.Graphics.DrawString("Nome", MYFONT3, Brushes.Black, X1 + 100, Y1)
        e.Graphics.DrawString("Endereço", MYFONT3, Brushes.Black, X1 + 320, Y1)
        e.Graphics.DrawString("Telefone", MYFONT3, Brushes.Black, X1 + 500, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)

        tbFuncionarios = RecebeTabela("select * from tbFuncionarios")
        While tbFuncionarios.EOF = False
            e.Graphics.DrawString(tbFuncionarios("codigo").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbFuncionarios("salario").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 40, Y1)
            e.Graphics.DrawString(tbFuncionarios("nome").Value.ToString, MYFONT, Brushes.Black, X1 + 100, Y1)
            e.Graphics.DrawString(tbFuncionarios("endereco").Value.ToString, MYFONT, Brushes.Black, X1 + 320, Y1)
            e.Graphics.DrawString(tbFuncionarios("telefone").Value.ToString, MYFONT, Brushes.Black, X1 + 500, Y1)
            Y1 += Line
            tbFuncionarios.MoveNext()
            If Y1 >= e.MarginBounds.Bottom - 100 Then
                Pulou = True
                Exit While
            End If
        End While
        If Pulou Then
            e.HasMorePages = True
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
            Y1 += Line
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT2, Brushes.Black, X1, Y1)
            wcpagina += 1
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbFuncionarios As ADODB.Recordset, sql As String

        sql = "Select * from tbFuncionarios where nome <> '' order by nome"
        tbFuncionarios = RecebeTabela(sql)
        If tbFuncionarios.RecordCount = 0 Then
            MsgBox("Não existem Funcionários !")
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub mkdCEP_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mkdCEP.MaskInputRejected

    End Sub
End Class