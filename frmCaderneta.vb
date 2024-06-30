Public Class frmCaderneta
    Private Sub Limpar()
        grpCaderneta.Tag = 0
        cboClientes.Text = ""
        lblNrFicha.Text = ""
        cboDependentes.Text = ""
        lblTotalFinal.Text = ""
        lstReservas.Items.Clear()
    End Sub
    Private Sub carregarreserva()
        Dim tbDthCaderneta As ADODB.Recordset, x As Integer

        lstReservas.Items.Clear()
        tbDthCaderneta = RecebeTabela("select * from tbDthCaderneta")
        If tbDthCaderneta.RecordCount > 0 Then
            tbDthCaderneta.MoveFirst()
            Do Until tbDthCaderneta.EOF
                lstReservas.Items.Add(tbDthCaderneta("nrficha").Value)
                lstReservas.Items(x).SubItems.Add(tbDthCaderneta("produtos").Value)
                lstReservas.Items(x).SubItems.Add(FormatCurrency(tbDthCaderneta("valor").Value))
                lstReservas.Items(x).SubItems.Add(tbDthCaderneta("quantidade").Value)
                lstReservas.Items(x).SubItems.Add(tbDthCaderneta("datacompra").Value)
                lstReservas.Items(x).SubItems.Add(FormatCurrency(tbDthCaderneta("total").Value))
                If x Mod 2 = 0 Then
                    lstReservas.Items(x).ForeColor = Color.Black
                    lstReservas.Items(x).BackColor = Color.LightGray
                Else
                    lstReservas.Items(x).ForeColor = Color.Black
                    lstReservas.Items(x).BackColor = Color.White
                End If
                x += 1
                tbDthCaderneta.MoveNext()
            Loop
        End If
    End Sub
    Private Sub btnFazer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFazer.Click
        Dim tbDthCaderneta As ADODB.Recordset, sql As String

        tbDthCaderneta = RecebeTabela("select * from tbDthCaderneta")
        If grpCaderneta.Tag = 0 Then tbDthCaderneta.AddNew()
        tbDthCaderneta("nrficha").Value = lblNrficha.Text
        tbDthCaderneta("produtos").Value = lblProdutos.Text
        tbDthCaderneta("valor").Value = FormatCurrency(lblValor.Text)
        tbDthCaderneta("quantidade").Value = txtQuantidade.Text
        tbDthCaderneta("datacompra").Value = lblDataCompra.Text
        tbDthCaderneta("total").Value = FormatCurrency(lblTotal.Text)
        tbDthCaderneta("nrcaderneta").Value = Label1.Text
        tbDthCaderneta.Update()
        sql = "Select sum(total) as total from tbDthCaderneta where nrcaderneta = " & Label1.Text
        tbDthCaderneta = RecebeTabela(sql)
        If tbDthCaderneta.RecordCount <> 0 Then
            lblTotalFinal.Text = FormatCurrency(tbDthCaderneta("total").Value)
        Else
            lblTotalFinal.Text = 0
        End If
        txtCodProd.Text = ""
        lblProdutos.Text = ""
        lblValor.Text = ""
        lblTotal.Text = ""
        txtQuantidade.Text = ""
        txtCodProd.Focus()
        carregarreserva()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim tbDthCaderneta As ADODB.Recordset
        tbDthCaderneta = RecebeTabela("select * from tbDthCaderneta where nrficha = " & grpCaderneta.Tag)
        If tbDthCaderneta.RecordCount = 0 Then Exit Sub
        tbDthCaderneta.Delete()
        carregarreserva()
        lblNrficha.Focus()
    End Sub
    Private Sub frmCaderneta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tbDthCaderneta As ADODB.Recordset

        MdiParent = frmPrincipal
        tbDthCaderneta = RecebeTabela("select * from tbDthCaderneta")
        If tbDthCaderneta.EOF = True And tbDthCaderneta.BOF = True Then
            Label2.Text = 0
        Else
            tbDthCaderneta = RecebeTabela("select * from tbDthCaderneta order by nrcaderneta desc")
            Label2.Text = tbDthCaderneta("nrcaderneta").Value.ToString
        End If
        Label1.Text = GeraCodigo()
        'tbDthCaderneta = RecebeTabela("insert into tbDthCaderneta (nrcaderneta) values (" & Label1.Text & ")")
        cboClientes.Focus()
        lblValor.Text = FormatCurrency(0)
        lblDataCompra.Text = Date.Now.Date
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbCaderneta As ADODB.Recordset

        tbCaderneta = RecebeTabela("select * from tbCaderneta where codigo = " & grpCaderneta.Tag)
        If grpDados.Tag = 0 Then tbCaderneta.AddNew()
        tbCaderneta("nrficha").Value = lblNrficha.Text
        tbCaderneta("cliente").Value = cboClientes.Text
        tbCaderneta("datacompra").Value = lblDataCompra.Text
        tbCaderneta("dependente").Value = cboDependentes.Text
        tbCaderneta("datavencimento").Value = lblDataVencimento.Text
        tbCaderneta("total_final").Value = lblTotalFinal.Text
        tbCaderneta.Update()
        'If tbCaderneta.EOF = True And tbCaderneta.BOF = True Then
        'tbCaderneta = RecebeTabela("update tbCaderneta set total_pendente = '" & lblTotalPendente.Text & "' where nrficha = " & lblNrFicha.Text)
        ' Else
        'tbCaderneta = RecebeTabela("update tbCaderneta set total_pendente = '" & lblTotalPagar.Text & "' where nrficha = " & lblNrFicha.Text)
        'End If
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        Limpar()
    End Sub

    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.GotFocus
        Dim tbClientes As ADODB.Recordset

        cboClientes.Items.Clear()
        tbClientes = RecebeTabela("Select * from tbClientes order by nome")
        If tbClientes.RecordCount <> 0 Then
            tbClientes.MoveFirst()
            While tbClientes.EOF = False
                cboClientes.Items.Add(tbClientes("nome").Value.ToString)
                tbClientes.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboClientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.LostFocus
        Dim tbClientes, tbCaderneta As ADODB.Recordset

        If cboClientes.Text <> "" Then
            tbClientes = RecebeTabela("select * from tbClientes where nome = '" & cboClientes.Text & "'")
            lblNrFicha.Text = tbClientes("nrficha").Value
            tbCaderneta = RecebeTabela("select * from tbCaderneta where nrficha = " & lblNrFicha.Text)
        Else
            MsgBox("Por favor digite um nome válido!", MsgBoxStyle.Information)
            Exit Sub
            cboClientes.Text = ""
            cboClientes.Focus()
        End If
        tbCaderneta = RecebeTabela("select datavencimento from tbCaderneta where nrficha = " & lblNrFicha.Text)
        If tbCaderneta.EOF = True And tbCaderneta.BOF = True Then
            lblDataVencimento.Text = Date.Now.Date.AddDays(30)
        Else
            tbCaderneta = RecebeTabela("select datavencimento from tbCaderneta where nrficha = " & lblNrFicha.Text)
            lblDataVencimento.Text = tbCaderneta("datavencimento").Value.ToString
        End If
        cboDependentes.Focus()
    End Sub
    Private Sub txtQuantidade_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidade.LostFocus
        If IsNumeric(txtQuantidade.Text) Then
            If txtQuantidade.Text = "" Then
                MsgBox("Insira uma quantidade", MsgBoxStyle.Exclamation)
                Exit Sub
                txtQuantidade.Focus()
            Else
                lblTotal.Text = FormatCurrency(txtQuantidade.Text * lblValor.Text)
            End If
        Else
            MsgBox("Dado Inválido!", MsgBoxStyle.Critical)
            txtQuantidade.Text = ""
            txtQuantidade.Focus()
        End If
    End Sub

    Private Sub txtCodProd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.GotFocus

    End Sub

    Private Sub txtCodProd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.LostFocus
        Dim tbProdutos As ADODB.Recordset

        tbProdutos = RecebeTabela("select * from tbProdutos")
        If txtCodProd.Text <> "" Then
            tbProdutos = RecebeTabela("select * from tbProdutos where codprod = " & txtCodProd.Text)
            lblProdutos.Text = tbProdutos("produto").Value
            lblValor.Text = FormatCurrency(tbProdutos("valorunit").Value.ToString)
        Else
            Exit Sub
            txtCodProd.Focus()
        End If
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        frmPagoPendente.Show()
    End Sub

    Private Sub cboDependentes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.GotFocus
        Dim tbDependentes As ADODB.Recordset

        cboDependentes.Items.Clear()
        tbDependentes = RecebeTabela("select * from tbDependentes where codigocliente = " & lblNrFicha.Text)
        If tbDependentes.RecordCount <> 0 Then
            tbDependentes.MoveFirst()
            While tbDependentes.EOF = False
                cboDependentes.Items.Add(tbDependentes("nome").Value.ToString)
                tbDependentes.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboDependentes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.LostFocus
        Dim tbDependentes As ADODB.Recordset

        If cboDependentes.Text = "" Then
            MsgBox("Escolha um Dependente!", MsgBoxStyle.Information)
            Exit Sub
            cboDependentes.Focus()
        End If
        tbDependentes = RecebeTabela("Select * from tbDependentes where nome = '" & cboDependentes.Text & "'")
        If tbDependentes.RecordCount = 0 Then
            MsgBox("Atenção: O dependente não existe!")
            Exit Sub
            cboDependentes.Focus()
        End If
        cboDependentes.Tag = tbDependentes("codigo").Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class