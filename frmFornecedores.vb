Public Class frmFornecedores
    Private Sub limpar()
        txtFornecedor.Text = ""
        txtEmpresa.Text = ""
        mkdCNPJ.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        cboCidade.Text = ""
        txtComplemento.Text = ""
        mkdCEP.Text = ""
        cbouf.Text = ""
        txtSite.Text = ""
        txtEmail.Text = ""
        mkdTelefone.Text = ""
        mkdCelular.Text = ""
    End Sub
    Private Sub CarregarFornecedores()
        Dim tbFornecedores As ADODB.Recordset, x As Integer, sql As String
        limpar()
        lstFornecedores.Items.Clear()
        sql = "select * from tbFornecedores where empresa like '%" & txtEmpresa.Text & "%'"
        If IsNumeric(txtEmpresa.Text) Then
            sql = "select * from tbFornecedores where codigo = " & txtEmpresa.Text
        End If
        tbFornecedores = RecebeTabela(sql)
        If tbFornecedores.RecordCount > 0 Then
            tbFornecedores.MoveFirst()
            Do Until tbFornecedores.EOF
                lstFornecedores.Items.Add(tbFornecedores("empresa").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("endereco").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("bairro").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("complemento").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("cidade").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("cnpj").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("uf").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("cep").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("fornecedor").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("telefone").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("celular").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("site").Value)
                lstFornecedores.Items(x).SubItems.Add(tbFornecedores("email").Value)
                If x Mod 2 = 0 Then
                    lstFornecedores.Items(x).ForeColor = Color.Black
                    lstFornecedores.Items(x).BackColor = Color.LightGray
                Else
                    lstFornecedores.Items(x).ForeColor = Color.Black
                    lstFornecedores.Items(x).BackColor = Color.White
                End If
                x += 1
                tbFornecedores.MoveNext()
            Loop
        End If
    End Sub

    Private Sub lstFornecedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFornecedores.SelectedIndexChanged
        If lstFornecedores.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        grpFornecedores.Tag = Val(lstFornecedores.SelectedItems(0).SubItems(0).Text)
        txtEmpresa.Text = lstFornecedores.SelectedItems(0).SubItems(0).Text
        txtEndereco.Text = lstFornecedores.SelectedItems(0).SubItems(1).Text
        txtBairro.Text = lstFornecedores.SelectedItems(0).SubItems(2).Text
        txtComplemento.Text = lstFornecedores.SelectedItems(0).SubItems(3).Text
        cboCidade.Text = lstFornecedores.SelectedItems(0).SubItems(4).Text
        mkdCNPJ.Text = lstFornecedores.SelectedItems(0).SubItems(5).Text
        cbouf.Text = lstFornecedores.SelectedItems(0).SubItems(6).Text
        mkdCEP.Text = lstFornecedores.SelectedItems(0).SubItems(7).Text
        txtFornecedor.Text = lstFornecedores.SelectedItems(0).SubItems(8).Text
        mkdTelefone.Text = lstFornecedores.SelectedItems(0).SubItems(9).Text
        mkdCelular.Text = lstFornecedores.SelectedItems(0).SubItems(10).Text
        txtSite.Text = lstFornecedores.SelectedItems(0).SubItems(11).Text
        txtEmail.Text = lstFornecedores.SelectedItems(0).SubItems(12).Text
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbFornecedores As ADODB.Recordset

        tbFornecedores = RecebeTabela("select * from tbFornecedores where codigo = " & grpFornecedores.Tag)
        If grpFornecedores.Tag = 0 Then tbFornecedores.AddNew()
        tbFornecedores("empresa").Value = txtEmpresa.Text
        tbFornecedores("endereco").Value = txtEndereco.Text
        tbFornecedores("bairro").Value = txtBairro.Text
        tbFornecedores("complemento").Value = txtComplemento.Text
        tbFornecedores("cidade").Value = cboCidade.Text
        tbFornecedores("cnpj").Value = mkdCNPJ.Text
        tbFornecedores("uf").Value = cbouf.Text
        tbFornecedores("cep").Value = mkdCEP.Text
        tbFornecedores("fornecedor").Value = txtFornecedor.Text
        tbFornecedores("telefone").Value = mkdTelefone.Text
        tbFornecedores("celular").Value = mkdCelular.Text
        tbFornecedores("site").Value = txtSite.Text
        tbFornecedores("email").Value = txtEmail.Text
        tbFornecedores.Update()
        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
        CarregarFornecedores()
        limpar()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbFornecedores As ADODB.Recordset

        tbFornecedores = RecebeTabela("update tbFornecedores set empresa = '" & txtEmpresa.Text & "',endereco = '" & txtEndereco.Text & "',bairro = '" & txtBairro.Text & "',complemento = '" & txtComplemento.Text & "',cidade = '" & cboCidade.Text & "',cnpj = '" & mkdCNPJ.Text & "',uf = '" & cbouf.Text & "',cep = '" & mkdCEP.Text & "', fornecedor = '" & txtFornecedor.Text & "', telefone = '" & mkdTelefone.Text & "', celular = '" & mkdCelular.Text & "', site = '" & txtSite.Text & "', email = '" & txtEmail.Text & "' where empresa = '" & txtEmpresa.Text & "'")
        MsgBox("Registro alterardo com sucesso!", MsgBoxStyle.Information)
        CarregarFornecedores()
        txtEmpresa.Focus()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbFornecedores As ADODB.Recordset

        tbFornecedores = RecebeTabela("select * from tbFornecedores where empresa = '" & txtEmpresa.Text & "'")
        If tbFornecedores.RecordCount = 0 Then Exit Sub
        tbFornecedores.Delete()
        CarregarFornecedores()

        limpar()
    End Sub
    Private Sub frmFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()
        CarregarFornecedores()
    End Sub
End Class
