Public Class frmPagoPendente

    Private Sub frmPagoPendente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtNrficha.Focus()
        'CarregaPagamento()
    End Sub

    Private Sub txtNrficha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNrficha.LostFocus
        Dim tbCaderneta As ADODB.Recordset

        If txtNrficha.Text <> "" Then
            tbCaderneta = RecebeTabela("select * from tbCaderneta where nrficha = " & txtNrficha.Text)
            lblClientes.Text = tbCaderneta("cliente").Value
        Else
            MsgBox("Por favor digite um código válido!", MsgBoxStyle.Information)
            Exit Sub
            txtNrficha.Text = ""
            txtNrficha.Focus()
        End If
    End Sub
    Private Sub CarregaPagamento()
        Dim tbCaderneta As ADODB.Recordset, x As Integer

        lstPagamento.Items.Clear()
        tbCaderneta = RecebeTabela("select * from tbCaderneta where pago = false")
        If tbCaderneta.RecordCount > 0 Then
            tbCaderneta.MoveFirst()
            Do Until tbCaderneta.EOF
                lstPagamento.Items.Add(tbCaderneta("nrficha").Value)
                lstPagamento.Items(x).SubItems.Add(tbCaderneta("cliente").Value)
                lstPagamento.Items(x).SubItems.Add(tbCaderneta("dependente").Value)
                lstPagamento.Items(x).SubItems.Add(tbCaderneta("datacompra").Value)
                lstPagamento.Items(x).SubItems.Add(FormatCurrency(tbCaderneta("total_final").Value))
                lstPagamento.Items(x).SubItems.Add(tbCaderneta("pago").Value)
                If x Mod 2 = 0 Then
                    lstPagamento.Items(x).ForeColor = Color.Black
                    lstPagamento.Items(x).BackColor = Color.LightGray
                Else
                    lstPagamento.Items(x).ForeColor = Color.Black
                    lstPagamento.Items(x).BackColor = Color.White
                End If
                x += 1
                tbCaderneta.MoveNext()
            Loop
        End If
    End Sub
    Private Sub Limpar()
        txtNrficha.Text = ""
        lblClientes.Text = ""
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim tbCaderneta As ADODB.Recordset, sql As String

        sql = "Select * from tbCaderneta where nrficha = " & lblNrFicha.Text
        'verificar contas pendentes
        tbCaderneta = RecebeTabela(sql)
        If tbCaderneta.RecordCount = 0 Then
            MsgBox("Não existe o caderneta solicitada !", MsgBoxStyle.Information)
            Exit Sub
        End If
        cbxPago.Checked = IIf(tbCaderneta("pago").Value.ToString = "True", True, False)
        If MsgBox("Deseja pagar a caderneta agora ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        sql = "update tbCaderneta set pago = '1' where nrficha = " & lblNrFicha.Text
        tbCaderneta = RecebeTabela(sql)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim tbCaderneta As ADODB.Recordset

        tbCaderneta = RecebeTabela("select * from tbCaderneta where cliente like '%" & lblClientes.Text & "%'")
        If IsNumeric(txtNrficha.Text) Then
            tbCaderneta = RecebeTabela("select * from tbCaderneta where nrficha = " & txtNrficha.Text)
        End If
        If tbCaderneta.RecordCount = 0 Then
            MsgBox("Esse Cliente não Existe !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        CarregaPagamento()
        tbCaderneta = RecebeTabela("Select sum(total_final) as total_final from tbCaderneta where nrficha = " & txtNrficha.Text)
        If tbCaderneta.RecordCount <> 0 Then
            lblTotalPagar.Text = FormatCurrency(tbCaderneta("total_final").Value)
        Else
            lblTotalPagar.Text = 0
        End If
    End Sub
End Class