Public Class frmRelatorios
    Dim tbaux
    Dim sql As String
    Dim wcpagina As Integer = 1
    Dim imagem As Image

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click


        Select Case cboConsulta.Text
            Case Is = "Caixa"
                sql = "Select * from tbCaixa where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and data like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by data"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum Caixa no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Clientes"
                sql = "Select * from tbClientes where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and nome like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by nome"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum Cliente no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Estoque"
                sql = "Select * from tbEstoque where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and produto like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by dataentrada"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum Estoque no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Fornecedores"
                sql = "Select * from tbFornecedores where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and empresa like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by empresa"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum Fornocedores no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Produtos"
                sql = "Select * from tbProdutos where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and produto like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by validade"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum Cliente no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Login"
                sql = "Select * from tbLogin where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and usuario like '%" & txtFiltro.Text & "%'"
                End If
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum login no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Is = "Dependentes"
                sql = "Select * from tbDependentes where 1=1 "
                If txtFiltro.Text <> "" Then
                    sql = sql & " and nome like '%" & txtFiltro.Text & "%'"
                End If
                sql = sql & " order by nome"
                tbaux = RecebeTabela(sql)
                If tbaux.RecordCount = 0 Then
                    MsgBox("Nenhum dependente no cadastro !", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Case Else
                MsgBox("Dados Inválidos!", MsgBoxStyle.Critical)
        End Select
        Dim limite As Integer = 10000
        Dim cntr As Integer = 0
        Dim i As Integer

        ProgressBar1.Value = 0
        ProgressBar1.Step = 1
        For i = 0 To limite
            cntr = cntr + 1
            If cntr Mod 100 = 0 Then
                Label4.Text = cntr.ToString()
                ProgressBar1.PerformStep()
                Application.DoEvents()
                System.Threading.Thread.Sleep(40)
                lblGerando.Visible = True
            End If
        Next
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        wcpagina = 1
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top  ' Variavel que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da
        'imagem = Image.FromFile("C:\Users\Luzinha\My Projects\Locadora\Locadora\drag.png")
        ' e.Graphics.DrawImage(imagem, X1, Y1 - 50, 50, 50)
        e.Graphics.DrawString("Padaria", MYFONT2, Brushes.Blue, X1 + 100, Y1)
        Y1 += Line2
        Select Case cboConsulta.Text
            Case Is = "Caixa"
                e.Graphics.DrawString("Relatório do Caixa", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Clientes"
                e.Graphics.DrawString("Relatório de Clientes", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Dependentes"
                e.Graphics.DrawString("Relatório de Dependentes", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Estoque"
                e.Graphics.DrawString("Relatório de Estoque", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Produtos"
                e.Graphics.DrawString("Relatório de Produtos", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Fornecedores"
                e.Graphics.DrawString("Relatório de Fornecedores", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Is = "Login"
                e.Graphics.DrawString("Relatório de Login", MYFONT3, Brushes.Red, X1 + 100, Y1)
            Case Else
                MsgBox("Dados Inválidos!", MsgBoxStyle.Critical)
        End Select
        Y1 += Line3
        Select Case cboConsulta.Text
            Case Is = "Caixa"
                e.Graphics.DrawString("Data do Fechamento", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Saldo Final", MYFONT3, Brushes.Black, X1 + 170, Y1)
                e.Graphics.DrawString("Saldo Inicial", MYFONT3, Brushes.Black, X1 + 230, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(CDate(tbaux.Fields("data").Value.ToString), MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(FormatCurrency(tbaux.Fields("saldo_incial").Value.ToString), MYFONT, Brushes.Black, X1 + 170, Y1)
                    e.Graphics.DrawString(FormatCurrency(tbaux.Fields("saldo_final").Value.ToString), MYFONT, Brushes.Black, X1 + 230, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Clientes"
                e.Graphics.DrawString("Cliente", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Endereço", MYFONT3, Brushes.Black, X1 + 150, Y1)
                e.Graphics.DrawString("Nº Ficha", MYFONT3, Brushes.Black, X1 + 390, Y1)
                e.Graphics.DrawString("Telefone", MYFONT3, Brushes.Black, X1 + 500, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("nome").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(tbaux.Fields("endereco").Value.ToString, MYFONT, Brushes.Black, X1 + 150, Y1)
                    e.Graphics.DrawString(tbaux.Fields("nrficha").Value.ToString, MYFONT, Brushes.Black, X1 + 410, Y1)
                    e.Graphics.DrawString(tbaux.Fields("telefone").Value.ToString, MYFONT, Brushes.Black, X1 + 520, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Dependentes"
                e.Graphics.DrawString("Dependente", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Cliente", MYFONT3, Brushes.Black, X1 + 100, Y1)
                e.Graphics.DrawString("Parentesco", MYFONT3, Brushes.Black, X1 + 200, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("nome").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(tbaux.Fields("codigocliente").Value.ToString, MYFONT, Brushes.Black, X1 + 100, Y1)
                    e.Graphics.DrawString(tbaux.Fields("parentesco").Value.ToString, MYFONT, Brushes.Black, X1 + 200, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Estoque"
                e.Graphics.DrawString("Código do Produto", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Produto", MYFONT3, Brushes.Black, X1 + 150, Y1)
                e.Graphics.DrawString("Quantidade", MYFONT3, Brushes.Black, X1 + 390, Y1)
                e.Graphics.DrawString("Data de Entrada", MYFONT3, Brushes.Black, X1 + 500, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("codprod").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(tbaux.Fields("produto").Value.ToString, MYFONT, Brushes.Black, X1 + 150, Y1)
                    e.Graphics.DrawString(tbaux.Fields("quantidade").Value.ToString, MYFONT, Brushes.Black, X1 + 410, Y1)
                    e.Graphics.DrawString(CDate(tbaux.Fields("dataentrada").Value.ToString), MYFONT, Brushes.Black, X1 + 520, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Produtos"
                e.Graphics.DrawString("Código do Produto", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Produto", MYFONT3, Brushes.Black, X1 + 150, Y1)
                e.Graphics.DrawString("Quantidade", MYFONT3, Brushes.Black, X1 + 390, Y1)
                e.Graphics.DrawString("Validade", MYFONT3, Brushes.Black, X1 + 500, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("codprod").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(tbaux.Fields("produto").Value.ToString, MYFONT, Brushes.Black, X1 + 150, Y1)
                    e.Graphics.DrawString(tbaux.Fields("quantidade").Value.ToString, MYFONT, Brushes.Black, X1 + 410, Y1)
                    e.Graphics.DrawString(CDate(tbaux.Fields("validade").Value.ToString), MYFONT, Brushes.Black, X1 + 520, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Fornecedores"
                e.Graphics.DrawString("Empresa", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Endereço", MYFONT3, Brushes.Black, X1 + 150, Y1)
                e.Graphics.DrawString("Cidade", MYFONT3, Brushes.Black, X1 + 390, Y1)
                e.Graphics.DrawString("Telefone", MYFONT3, Brushes.Black, X1 + 500, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("empresa").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(tbaux.Fields("endereco").Value.ToString, MYFONT, Brushes.Black, X1 + 150, Y1)
                    e.Graphics.DrawString(tbaux.Fields("cidade").Value.ToString, MYFONT, Brushes.Black, X1 + 410, Y1)
                    e.Graphics.DrawString(tbaux.Fields("telefone").Value.ToString, MYFONT, Brushes.Black, X1 + 520, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While
            Case Is = "Login"
                e.Graphics.DrawString("Usuário", MYFONT3, Brushes.Black, X1, Y1)
                e.Graphics.DrawString("Login", MYFONT3, Brushes.Black, X1 + 100, Y1)
                e.Graphics.DrawString("Entrada", MYFONT3, Brushes.Black, X1 + 200, Y1)
                e.Graphics.DrawString("Logoff", MYFONT3, Brushes.Black, X1 + 300, Y1)
                e.Graphics.DrawString("Saída", MYFONT3, Brushes.Black, X1 + 400, Y1)
                Y1 += Line3
                e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
                While tbaux.EOF = False
                    e.Graphics.DrawString(tbaux.Fields("usuario").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
                    e.Graphics.DrawString(CDate(tbaux.Fields("datalogin").Value.ToString), MYFONT, Brushes.Black, X1 + 100, Y1)
                    e.Graphics.DrawString(TimeValue(tbaux.Fields("horalogin").Value.ToString), MYFONT, Brushes.Black, X1 + 200, Y1)
                    e.Graphics.DrawString(CDate(tbaux.Fields("datalogoff").Value.ToString), MYFONT, Brushes.Black, X1 + 300, Y1)
                    e.Graphics.DrawString(TimeValue(tbaux.Fields("horalogoff").Value.ToString), MYFONT, Brushes.Black, X1 + 400, Y1)
                    Y1 += Line
                    tbaux.MoveNext()
                    If Y1 >= e.MarginBounds.Bottom - 50 Then
                        pulou = True
                        Exit While
                    End If
                End While

            Case Else
                MsgBox("Dados Inválidos!", MsgBoxStyle.Critical)
        End Select
        If pulou = True Then
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 700, Y1)
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT3, Brushes.Black, X1, Y1)
            wcpagina += 1
            e.HasMorePages = True
        End If

    End Sub

    Private Sub frmRelatorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtFiltro.Focus()
        lblGerando.Visible = False
    End Sub
End Class
