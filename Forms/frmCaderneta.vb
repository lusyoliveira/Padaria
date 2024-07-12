Public Class frmCaderneta
    Dim ClasseCaderneta As New clsCaderneta, ClasseCliente As New clsClientes, ClasseProduto As New clsProdutos, ClasseDependente As New clsDependente, tbCaderneta, tbClientes, TbProdutos, tbDependentes As DataTable

    Private Sub Limpar()
        grpCaderneta.Tag = 0
        cboClientes.Text = ""
        lblNrFicha.Text = ""
        cboDependentes.Text = ""
        lblTotalFinal.Text = ""
        lstReservas.Items.Clear()
    End Sub
    Private Sub PreencheCaderneta()
        Dim x As Integer = 0

        lstReservas.Items.Clear()

        If tbCaderneta.Rows.Count > 0 Then
            For Each row As DataRow In tbCaderneta.Rows
                Dim item As New ListViewItem(row("nrficha").ToString())
                item.SubItems.Add(row("produtos").ToString())
                item.SubItems.Add(FormatCurrency(row("valor").ToString()))
                item.SubItems.Add(row("quantidade").ToString())
                item.SubItems.Add(row("datacompra").ToString())
                item.SubItems.Add(FormatCurrency(row("total").ToString()))

                If x Mod 2 = 0 Then
                    item.ForeColor = Color.Black
                    item.BackColor = Color.LightGray
                Else
                    item.ForeColor = Color.Black
                    item.BackColor = Color.White
                End If

                lstReservas.Items.Add(item)
                x += 1
            Next
        End If
    End Sub
    Private Sub btnFazer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFazer.Click
        ClasseCaderneta.Fazer(Val(lblNrFicha.Text), lblProdutos.Text, lblValor.Text, Val(txtQuantidade.Text), lblDataCompra.Text, lblTotal.Text, Label1.Text)
        txtCodProd.Text = ""
        lblProdutos.Text = ""
        lblValor.Text = ""
        lblTotal.Text = ""
        txtQuantidade.Text = ""
        txtCodProd.Focus()
        PreencheCaderneta()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma o cancelamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.Cancelar(Val(lblNrFicha.Text))
            tbCaderneta = ClasseCaderneta.ConsultaCaderneta()
        Else
            Exit Sub
        End If
        PreencheCaderneta()
        lblNrFicha.Focus()
    End Sub

    Private Sub frmCaderneta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ClasseCaderneta.GerarCodCaderneta()

        Label1.Text = GeraCodigo()
        cboClientes.Focus()
        lblValor.Text = FormatCurrency(0)
        lblDataCompra.Text = Date.Now.Date
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.SalvarCaderneta(lblNrFicha.Text, cboClientes.Text, Convert.ToDateTime(lblDataCompra.Text), cboDependentes.Text, Convert.ToDateTime(lblDataVencimento.Text), Convert.ToDecimal(lblTotalFinal.Text))
        Else
            Exit Sub
        End If
        Limpar()
    End Sub
    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.GotFocus
        'tbClientes = ClasseCliente.ConsultaCliente(0, "")
        cboClientes.Items.Clear()

        If tbClientes.Rows.Count > 0 Then
            For Each row As DataRow In tbClientes.Rows
                cboClientes.Items.Add(row("Nome").ToString())
            Next
        End If
    End Sub
    Private Sub cboClientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.LostFocus
        If cboClientes.Text <> "" Then
            lblDataVencimento.Text = ClasseCaderneta.ConsultaNumeroCaderneta(lblNrFicha.Text)
            cboDependentes.Focus()
        Else
            MessageBox.Show("Por favor digite um nome válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboClientes.Text = ""
            cboClientes.Focus()
        End If
    End Sub

    Private Sub txtQuantidade_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidade.LostFocus
        If IsNumeric(txtQuantidade.Text) Then
            If txtQuantidade.Text = "" Then
                MessageBox.Show("Insira uma quantidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
                txtQuantidade.Focus()
            Else
                lblTotal.Text = FormatCurrency(txtQuantidade.Text * lblValor.Text)
            End If
        Else
            MessageBox.Show("Dado Inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantidade.Text = ""
            txtQuantidade.Focus()
        End If
    End Sub
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        frmPagoPendente.Show()
    End Sub
    Private Sub txtCodProd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.LostFocus
        ' TbProdutos = ClasseProduto.ConsultaProduto(Val(txtCodProd.Text), "")

        If txtCodProd.Text <> "" Then
            If TbProdutos.Rows.Count > 0 Then
                lblProdutos.Text = TbProdutos.Rows(0)("produto").ToString()
                lblValor.Text = FormatCurrency(TbProdutos.Rows(0)("valorunit").ToString())
            End If
        Else
            txtCodProd.Focus()
        End If
    End Sub
    Private Sub cboDependentes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.GotFocus
        cboDependentes.Items.Clear()

        'tbDependentes = classeDependente.ConsultaDependente(lblNrFicha.Text, "")

        If tbDependentes.Rows.Count > 0 Then
            For Each row As DataRow In tbDependentes.Rows
                cboDependentes.Items.Add(row("Nome").ToString())
            Next
        End If
    End Sub
    Private Sub cboDependentes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.LostFocus
        'tbDependentes = ClasseDependente.ConsultaDependente(0, cboDependentes.Text)

        If cboDependentes.Text = "" Then
            MessageBox.Show("Escolha um Dependente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDependentes.Focus()
            Exit Sub
        Else
            If tbDependentes.Rows.Count = 0 Then
                MessageBox.Show("O dependente não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboDependentes.Focus()
                Exit Sub
            End If
        End If
        cboDependentes.Tag = tbDependentes.Rows(0)("codigo").ToString()
    End Sub

End Class