Public Class frmCaderneta
    Dim ClasseCaderneta As New clsCaderneta, ClasseCombo As New clsCombo, ClasseCliente As New clsEntidades, ClasseProduto As New clsProdutos, ClasseDependente As New clsDependente, tbCaderneta, tbClientes, TbProdutos, tbDependentes As DataTable

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
                Dim item As New ListViewItem(row("Codigo").ToString())
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma o cancelamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.Cancelar(Val(lblNumeroCaderneta.Text))
            tbCaderneta = ClasseCaderneta.ConsultaCaderneta()
        Else
            Exit Sub
        End If
        PreencheCaderneta()
    End Sub

    Private Sub cboDependentes_Enter(sender As Object, e As EventArgs) Handles cboDependentes.Enter
        If ClasseCaderneta.CodCliente = 0 Then
            Exit Sub
        Else
            Dim ListaDependentes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidadeDependente WHERE CodEntidade = " & Val(lblNrFicha.Text) & "  ORDER BY NomeDependente", "Codigo", "NomeDependente")
            With Me.cboDependentes
                .DataSource = ListaDependentes
                .ValueMember = "Codigo"
                .DisplayMember = "Descricao"
                .SelectedIndex = "0"
            End With
        End If
    End Sub
    Private Sub txtQuantidade_Leave(sender As Object, e As EventArgs) Handles txtQuantidade.Leave
        If txtCodProd.Text Is Nothing Or txtCodProd.Text = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Exit Sub
        ElseIf IsNumeric(txtQuantidade.Text) = False Then
            MessageBox.Show("Insira uma quantidade válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            txtQuantidade.Focus()
        ElseIf txtQuantidade.Text.Trim() = "" Then
            MessageBox.Show("Insira uma quantidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            txtQuantidade.Focus()
            'ElseIf lblTotal.Text.Trim() = "" Then
            '    MessageBox.Show("É necessário calcular o total!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            '    txtQuantidade.Focus()
        Else
            lblTotal.Text = FormatCurrency(txtQuantidade.Text * lblValor.Text)

            ' Captura os valores dos controles
            Dim codigo As Integer = Integer.Parse(txtCodProd.Text.ToString())
            Dim Produtos As String = lblProdutos.Text.ToString()
            Dim valorUnitario As Decimal = Decimal.Parse(lblValor.Text)
            Dim quantidade As Integer = Integer.Parse(txtQuantidade.Text)
            Dim Total As Decimal = quantidade * valorUnitario

            ' Cria um novo item para adicionar ao ListView
            Dim novoItem As New ListViewItem(codigo)
            novoItem.SubItems.Add(Produtos.ToString())
            novoItem.SubItems.Add(FormatCurrency(valorUnitario))
            novoItem.SubItems.Add(quantidade.ToString())
            novoItem.SubItems.Add(FormatCurrency(Total)) ' Calcula o total

            ' Adiciona o item ao ListView
            lstReservas.Items.Add(novoItem)
            txtCodProd.Text = ""
            lblProdutos.Text = ""
            lblValor.Text = ""
            txtQuantidade.Text = ""
            lblTotal.Text = ""
        End If
    End Sub
    Private Sub txtCodProd_Leave(sender As Object, e As EventArgs) Handles txtCodProd.Leave
        If Val(txtCodProd.Text) = 0 Then
            Exit Sub
        Else
            ClasseProduto.ConsultaProdCodigo(Val(txtCodProd.Text), ClasseProduto)
            lblProdutos.Text = ClasseProduto.Produto
            lblValor.Text = ClasseProduto.Valor
        End If
    End Sub

    Private Sub cboClientes_Leave(sender As Object, e As EventArgs) Handles cboClientes.Leave
        If cboClientes.Text <> "" Then
            cboDependentes.Text = ""
            ClasseCaderneta.CodCliente = cboClientes.SelectedValue
            ClasseCliente.ObterEntidade(ClasseCaderneta.CodCliente, ClasseCliente)
            lblNrFicha.Text = ClasseCliente.CodEntidade
            lblDataVencimento.Text = ClasseCaderneta.ConsultaVencCaderneta(Val(lblNrFicha.Text))
            cboDependentes.Focus()
        Else
            MessageBox.Show("Por favor digite um nome válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboClientes.Text = ""
            cboClientes.Focus()
        End If
    End Sub

    Private Sub frmCaderneta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNumeroCaderneta.Text = ClasseCaderneta.GerarCodCaderneta()
        cboClientes.Focus()
        lblValor.Text = FormatCurrency(0)
        lblDataCompra.Text = Date.Now.Date
    End Sub

    Private Sub cboClientes_Enter(sender As Object, e As EventArgs) Handles cboClientes.Enter
        Dim ListaCliente = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboClientes
            .DataSource = ListaCliente
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.SalvarCaderneta(Val(lblNrFicha.Text), Convert.ToDateTime(lblDataCompra.Text), cboDependentes.Text, Convert.ToDateTime(lblDataVencimento.Text), Convert.ToDecimal(lblTotalFinal.Text))
            For Each item As ListViewItem In lstReservas.Items
                ClasseCaderneta.SalvarDetCaderneta(Val(lblNumeroCaderneta.Text), item.SubItems(0).Text, item.SubItems(2).Text, item.SubItems(3).Text, item.SubItems(4).Text)
            Next
        Else
            Exit Sub
        End If
        Limpar()
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        frmPagoPendente.Show()
    End Sub

End Class