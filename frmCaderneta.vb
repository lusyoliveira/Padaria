Imports System.Data.SqlClient

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
        Dim tbDthCaderneta As DataTable = RecebeTabela("SELECT * FROM tbDthCaderneta")
        Dim x As Integer = 0

        lstReservas.Items.Clear()

        If tbDthCaderneta.Rows.Count > 0 Then
            For Each row As DataRow In tbDthCaderneta.Rows
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
        Dim sql As String

        If grpCaderneta.Tag = 0 Then
            sql = "INSERT INTO tbDthCaderneta (nrficha, produtos, valor, quantidade, datacompra, total, nrcaderneta) VALUES (@nrficha, @produtos, @valor, @quantidade, @datacompra, @total, @nrcaderneta)"
        Else
            sql = "UPDATE tbDthCaderneta SET produtos = @produtos, valor = @valor, quantidade = @quantidade, datacompra = @datacompra, total = @total WHERE nrficha = @nrficha"
        End If

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", lblNrFicha.Text)
            cmd.Parameters.AddWithValue("@produtos", lblProdutos.Text)
            cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(lblValor.Text))
            cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text))
            cmd.Parameters.AddWithValue("@datacompra", Convert.ToDateTime(lblDataCompra.Text))
            cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(lblTotal.Text))
            cmd.Parameters.AddWithValue("@nrcaderneta", Label1.Text)

            If aConexao.State = ConnectionState.Closed Then
                aConexao.Open()
            End If

            cmd.ExecuteNonQuery()
        End Using

        sql = "SELECT SUM(total) AS total FROM tbDthCaderneta WHERE nrcaderneta = @nrcaderneta"
        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrcaderneta", Label1.Text)
            Dim total As Object = cmd.ExecuteScalar()
            lblTotalFinal.Text = If(total IsNot Nothing, FormatCurrency(total.ToString()), "0")
        End Using

        txtCodProd.Text = ""
        lblProdutos.Text = ""
        lblValor.Text = ""
        lblTotal.Text = ""
        txtQuantidade.Text = ""
        txtCodProd.Focus()
        carregarreserva()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim sql As String = "DELETE FROM tbDthCaderneta WHERE nrficha = @nrficha"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", grpCaderneta.Tag)

            If aConexao.State = ConnectionState.Closed Then
                aConexao.Open()
            End If

            cmd.ExecuteNonQuery()
        End Using

        carregarreserva()
        lblNrFicha.Focus()
    End Sub

    Private Sub frmCaderneta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tbDthCaderneta As DataTable = RecebeTabela("SELECT * FROM tbDthCaderneta")
        If tbDthCaderneta.Rows.Count = 0 Then
            Label2.Text = "0"
        Else
            tbDthCaderneta = RecebeTabela("SELECT * FROM tbDthCaderneta ORDER BY nrcaderneta DESC")
            Label2.Text = tbDthCaderneta.Rows(0)("nrcaderneta").ToString()
        End If
        Label1.Text = GeraCodigo()
        cboClientes.Focus()
        lblValor.Text = FormatCurrency(0)
        lblDataCompra.Text = Date.Now.Date
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String

        If grpDados.Tag = 0 Then
            sql = "INSERT INTO tbCaderneta (nrficha, cliente, datacompra, dependente, datavencimento, total_final) VALUES (@nrficha, @cliente, @datacompra, @dependente, @datavencimento, @total_final)"
        Else
            sql = "UPDATE tbCaderneta SET cliente = @cliente, datacompra = @datacompra, dependente = @dependente, datavencimento = @datavencimento, total_final = @total_final WHERE codigo = @codigo"
        End If

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", lblNrFicha.Text)
            cmd.Parameters.AddWithValue("@cliente", cboClientes.Text)
            cmd.Parameters.AddWithValue("@datacompra", Convert.ToDateTime(lblDataCompra.Text))
            cmd.Parameters.AddWithValue("@dependente", cboDependentes.Text)
            cmd.Parameters.AddWithValue("@datavencimento", Convert.ToDateTime(lblDataVencimento.Text))
            cmd.Parameters.AddWithValue("@total_final", Convert.ToDecimal(lblTotalFinal.Text))
            cmd.Parameters.AddWithValue("@codigo", grpCaderneta.Tag)

            If aConexao.State = ConnectionState.Closed Then
                aConexao.Open()
            End If

            cmd.ExecuteNonQuery()
        End Using

        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        Limpar()
    End Sub
    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.GotFocus
        Dim tbClientes As DataTable = RecebeTabela("SELECT * FROM tbClientes ORDER BY nome")
        cboClientes.Items.Clear()

        If tbClientes.Rows.Count > 0 Then
            For Each row As DataRow In tbClientes.Rows
                cboClientes.Items.Add(row("nome").ToString())
            Next
        End If
    End Sub
    Private Sub cboClientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.LostFocus
        If cboClientes.Text <> "" Then
            Dim tbClientes As DataTable = RecebeTabela("SELECT * FROM tbClientes WHERE nome = @nome")
            Dim tbCaderneta As DataTable
            Using cmd As New SqlCommand("SELECT * FROM tbClientes WHERE nome = @nome", aConexao)
                cmd.Parameters.AddWithValue("@nome", cboClientes.Text)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(tbClientes)
                End Using
            End Using

            If tbClientes.Rows.Count > 0 Then
                lblNrFicha.Text = tbClientes.Rows(0)("nrficha").ToString()
                tbCaderneta = RecebeTabela("SELECT * FROM tbCaderneta WHERE nrficha = @nrficha")
                Using cmd As New SqlCommand("SELECT datavencimento FROM tbCaderneta WHERE nrficha = @nrficha", aConexao)
                    cmd.Parameters.AddWithValue("@nrficha", lblNrFicha.Text)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(tbCaderneta)
                    End Using
                End Using

                If tbCaderneta.Rows.Count = 0 Then
                    lblDataVencimento.Text = Date.Now.Date.AddDays(30).ToString()
                Else
                    lblDataVencimento.Text = tbCaderneta.Rows(0)("datavencimento").ToString()
                End If

                cboDependentes.Focus()
            Else
                MsgBox("Por favor digite um nome válido!", MsgBoxStyle.Information)
                cboClientes.Text = ""
                cboClientes.Focus()
            End If
        End If
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
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        frmPagoPendente.Show()
    End Sub
    Private Sub txtCodProd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProd.LostFocus
        Dim tbProdutos As DataTable

        If txtCodProd.Text <> "" Then
            tbProdutos = RecebeTabela("SELECT * FROM tbProdutos WHERE codprod = @codprod")
            Using cmd As New SqlCommand("SELECT * FROM tbProdutos WHERE codprod = @codprod", aConexao)
                cmd.Parameters.AddWithValue("@codprod", txtCodProd.Text)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(tbProdutos)
                End Using
            End Using

            If tbProdutos.Rows.Count > 0 Then
                lblProdutos.Text = tbProdutos.Rows(0)("produto").ToString()
                lblValor.Text = FormatCurrency(tbProdutos.Rows(0)("valorunit").ToString())
            End If
        Else
            txtCodProd.Focus()
        End If
    End Sub
    Private Sub cboDependentes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.GotFocus
        Dim tbDependentes As DataTable

        cboDependentes.Items.Clear()

        tbDependentes = RecebeTabela("SELECT * FROM tbDependentes WHERE codigocliente = @codigocliente")
        Using cmd As New SqlCommand("SELECT * FROM tbDependentes WHERE codigocliente = @codigocliente", aConexao)
            cmd.Parameters.AddWithValue("@codigocliente", lblNrFicha.Text)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(tbDependentes)
            End Using
        End Using

        If tbDependentes.Rows.Count > 0 Then
            For Each row As DataRow In tbDependentes.Rows
                cboDependentes.Items.Add(row("nome").ToString())
            Next
        End If
    End Sub
    Private Sub cboDependentes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDependentes.LostFocus
        Dim tbDependentes As DataTable

        If cboDependentes.Text = "" Then
            MsgBox("Escolha um Dependente!", MsgBoxStyle.Information)
            cboDependentes.Focus()
            Exit Sub
        End If

        tbDependentes = RecebeTabela("SELECT * FROM tbDependentes WHERE nome = @nome")
        Using cmd As New SqlCommand("SELECT * FROM tbDependentes WHERE nome = @nome", aConexao)
            cmd.Parameters.AddWithValue("@nome", cboDependentes.Text)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(tbDependentes)
            End Using
        End Using

        If tbDependentes.Rows.Count = 0 Then
            MsgBox("Atenção: O dependente não existe!")
            cboDependentes.Focus()
            Exit Sub
        End If

        cboDependentes.Tag = tbDependentes.Rows(0)("codigo").ToString()
    End Sub

End Class