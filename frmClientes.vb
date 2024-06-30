Public Class frmClientes
    Private Sub Limpar()
        grpDados.Tag = 0
        txtNrficha.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        mkdtelefone.Text = ""
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbClientes As ADODB.Recordset

        tbClientes = RecebeTabela("select * from tbClientes where codigo = " & grpDados.Tag)
        If grpDados.Tag = 0 Then tbClientes.AddNew()
        tbClientes("nrficha").Value = txtNrficha.Text
        tbClientes("nome").Value = txtNome.Text
        tbClientes("endereco").Value = txtEndereco.Text
        tbClientes("bairro").Value = txtBairro.Text
        tbClientes("telefone").Value = mkdtelefone.Text
        tbClientes("datacad").Value = lblData.Text
        tbClientes.Update()
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        Limpar()
        ContarRegistros()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbClientes As ADODB.Recordset

        If txtNrficha.Text = "" Then
            MsgBox("Número da ficha inválido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        tbClientes = RecebeTabela("Select * from tbClientes where nrficha = " & txtNrficha.Text)
        If tbClientes.RecordCount = 0 Then
            MsgBox("Não existe esse cliente !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNome.Text = tbClientes("nome").Value.ToString
        txtEndereco.Text = tbClientes("endereco").Value.ToString
        txtBairro.Text = tbClientes("bairro").Value.ToString
        mkdtelefone.Text = tbClientes("telefone").Value.ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o Cliente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            tbClientes = RecebeTabela("delete from tbClientes where nrficha = " & txtNrficha.Text)
        End If
        Limpar()
        ContarRegistros()
        txtNome.Focus()
    End Sub

    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        lblData.Text = Date.Now.Date
        lblRegistro.Text = ContarRegistros()
        txtNrficha.Focus()
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbClientes As ADODB.Recordset

        tbClientes = RecebeTabela("update tbClientes set nome = '" & txtNome.Text & "', endereco = '" & txtEndereco.Text & "', bairro = '" & txtBairro.Text & "', telefone = '" & mkdtelefone.Text & "' where nome = '" & txtNome.Text & "'")
        MsgBox("Registro alterardo com sucesso!", MsgBoxStyle.Information)
        txtNome.Focus()
    End Sub

    Private Sub btnDependentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDependentes.Click
        frmDependentes.Show()
    End Sub
    Private Sub CarregarDependentes()
        Dim tbDependentes As ADODB.Recordset, sql As String

        lstDependentes.Items.Clear()
        sql = "select * from tbDependentes where codigocliente = " & txtNrficha.Text
        tbDependentes = RecebeTabela(sql)
        If tbDependentes.RecordCount > 0 Then
            tbDependentes.MoveFirst()
            Do Until tbDependentes.EOF
                lstDependentes.Items.Add(tbDependentes("nome").Value)
                tbDependentes.MoveNext()
            Loop
        End If
    End Sub
    Private Sub btnVerifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifica.Click
        Dim tbClientes As ADODB.Recordset

        tbClientes = RecebeTabela("select * from tbClientes where nome like '%" & txtNome.Text & "%'")
        If txtNrficha.Text = tbClientes("nrficha").Value Then
            MsgBox("O número de ficha já existe!", MsgBoxStyle.Information)
            txtNrficha.Text = ""
        Else
            MsgBox("O Número não existe!", MsgBoxStyle.Information)
            txtNome.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Dim tbClientes As ADODB.Recordset

        tbClientes = RecebeTabela("select * from tbClientes where nome like '%" & txtNome.Text & "%'")
        If IsNumeric(txtNrficha.Text) Then
            tbClientes = RecebeTabela("select * from tbClientes where nrficha = " & txtNrficha.Text)
        End If
        If tbClientes.RecordCount = 0 Then
            MsgBox("Esse Cliente não Existe !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNrficha.Text = tbClientes.Fields("nrficha").Value.ToString
        txtNome.Text = tbClientes("nome").Value.ToString
        txtEndereco.Text = tbClientes("endereco").Value.ToString
        txtBairro.Text = tbClientes("bairro").Value.ToString
        mkdtelefone.Text = tbClientes("telefone").Value.ToString
        CarregarDependentes()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
End Class