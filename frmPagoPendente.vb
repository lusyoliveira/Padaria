Public Class frmPagoPendente

    Private Sub frmPagoPendente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtNrficha.Focus()
        'CarregaPagamento()
    End Sub
    Private Sub Limpar()
        txtNrficha.Text = ""
        lblClientes.Text = ""
    End Sub

    Private Sub txtNrficha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNrficha.LostFocus
        Dim tbCaderneta As DataTable

        If txtNrficha.Text <> "" Then
            tbCaderneta = RecebeTabela("select * from tbCaderneta where nrficha = " & txtNrficha.Text)
            If tbCaderneta.Rows.Count > 0 Then
                lblClientes.Text = tbCaderneta.Rows(0)("cliente").ToString()
            Else
                MsgBox("Por favor, digite um código válido!", MsgBoxStyle.Information)
                txtNrficha.Text = ""
                txtNrficha.Focus()
            End If
        End If
    End Sub

    Private Sub CarregaPagamento()
        Dim tbCaderneta As DataTable
        Dim x As Integer = 0

        lstPagamento.Items.Clear()
        tbCaderneta = RecebeTabela("select * from tbCaderneta where pago = 'False'")
        For Each row As DataRow In tbCaderneta.Rows
            lstPagamento.Items.Add(row("nrficha").ToString())
            lstPagamento.Items(x).SubItems.Add(row("cliente").ToString())
            lstPagamento.Items(x).SubItems.Add(row("dependente").ToString())
            lstPagamento.Items(x).SubItems.Add(row("datacompra").ToString())
            lstPagamento.Items(x).SubItems.Add(FormatCurrency(row("total_final")))
            lstPagamento.Items(x).SubItems.Add(row("pago").ToString())

            If x Mod 2 = 0 Then
                lstPagamento.Items(x).ForeColor = Color.Black
                lstPagamento.Items(x).BackColor = Color.LightGray
            Else
                lstPagamento.Items(x).ForeColor = Color.Black
                lstPagamento.Items(x).BackColor = Color.White
            End If

            x += 1
        Next
    End Sub
    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim sql As String

        sql = "Select * from tbCaderneta where nrficha = " & lblNrFicha.Text
        ' Verifica se a caderneta solicitada existe
        Dim tbCaderneta As DataTable = RecebeTabela(sql)
        If tbCaderneta.Rows.Count = 0 Then
            MsgBox("Não existe a caderneta solicitada!", MsgBoxStyle.Information)
            Exit Sub
        End If

        ' Confirmação para pagar a caderneta
        If MsgBox("Deseja pagar a caderneta agora?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Atualiza o campo pago para 'True' na tabela tbCaderneta
        sql = "update tbCaderneta set pago = 'True' where nrficha = " & lblNrFicha.Text
        Dim result As DataTable = RecebeTabela(sql)
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim tbCaderneta As DataTable

        If IsNumeric(txtNrficha.Text) Then
            tbCaderneta = RecebeTabela("select * from tbCaderneta where nrficha = " & txtNrficha.Text)
        Else
            tbCaderneta = RecebeTabela("select * from tbCaderneta where cliente like '%" & lblClientes.Text & "%'")
        End If

        If tbCaderneta.Rows.Count = 0 Then
            MsgBox("Esse Cliente não Existe!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        CarregaPagamento()

        ' Calcula o total final a pagar para exibir na label lblTotalPagar
        tbCaderneta = RecebeTabela("Select sum(total_final) as total_final from tbCaderneta where nrficha = " & txtNrficha.Text)
        If tbCaderneta.Rows.Count > 0 AndAlso Not IsDBNull(tbCaderneta.Rows(0)("total_final")) Then
            lblTotalPagar.Text = FormatCurrency(tbCaderneta.Rows(0)("total_final"))
        Else
            lblTotalPagar.Text = FormatCurrency(0)
        End If
    End Sub

End Class