Public Class frmUsuarios
    Private Sub carregarusuario()
        Dim tbUsuarios As ADODB.Recordset, x As Integer, sql As String
        limpar()
        lstUsuarios.Items.Clear()
        sql = "select * from tbUsuarios where nome like '%" & txtUsuario.Text & "%'"
        If IsNumeric(txtUsuario.Text) Then
            sql = "select * from tbUsuarios where codigo = " & txtUsuario.Text
        End If
        tbUsuarios = RecebeTabela(sql)
        If tbUsuarios.RecordCount > 0 Then
            tbUsuarios.MoveFirst()
            Do Until tbUsuarios.EOF
                lstUsuarios.Items.Add(tbUsuarios("funcionario").Value)
                lstUsuarios.Items(x).SubItems.Add(tbUsuarios("nome").Value.ToString)
                lstUsuarios.Items(x).SubItems.Add(tbUsuarios("permissao").Value)
                If x Mod 2 = 0 Then
                    lstUsuarios.Items(x).ForeColor = Color.Black
                    lstUsuarios.Items(x).BackColor = Color.LightGray
                Else
                    lstUsuarios.Items(x).ForeColor = Color.Black
                    lstUsuarios.Items(x).BackColor = Color.White
                End If
                x += 1
                tbUsuarios.MoveNext()
            Loop
        End If
    End Sub
    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        Dim tbaux As ADODB.Recordset
        With cboPermissao
            .Items.Clear()
            tbaux = RecebeTabela("Select distinct permissao from tbpermissoes order by permissao")
            If tbaux.RecordCount <> 0 Then
                tbaux.MoveFirst()
                While tbaux.EOF = False
                    .Items.Add(tbaux.Fields("permissao").Value.ToString)
                    tbaux.MoveNext()
                End While
            End If

        End With
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbUsuarios As ADODB.Recordset

        tbUsuarios = RecebeTabela("select * from tbUsuarios where codigo = " & grpUsuarios.Tag)
        If grpUsuarios.Tag = 0 Then tbUsuarios.AddNew()
        tbUsuarios("funcionario").Value = txtFuncionario.Text
        tbUsuarios("nome").Value = txtUsuario.Text
        tbUsuarios("senha").Value = mcripto(txtSenha.Text)
        tbUsuarios("permissao").Value = cboPermissao.Text
        tbUsuarios.Update()
        limpar()
        carregarusuario()
        txtUsuario.Focus()
    End Sub
    Private Sub limpar()
        txtSenha.Text = ""
        txtUsuario.Text = ""
        cboPermissao.Text = ""
        txtFuncionario.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregarusuario()
        txtUsuario.Focus()
        MdiParent = frmPrincipal
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbUsuarios As ADODB.Recordset

        tbUsuarios = RecebeTabela("select * from tbUsuarios where codigo = " & grpUsuarios.Tag)
        If tbUsuarios.RecordCount = 0 Then Exit Sub
        tbUsuarios.Delete()
        carregarusuario()
        txtUsuario.Focus()
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        grpUsuarios.Tag = Val(lstUsuarios.SelectedItems(0).SubItems(0).Text)
        txtFuncionario.Text = lstUsuarios.SelectedItems(0).SubItems(0).Text
        txtUsuario.Text = lstUsuarios.SelectedItems(0).SubItems(1).Text
        cboPermissao.Text = lstUsuarios.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbUsuarios As ADODB.Recordset, sql As String

        If btnAlterar.Text = "Alterar" Then
            sql = "Select * from tbUsuarios "
            tbUsuarios = RecebeTabela(sql)
            If tbUsuarios.RecordCount = 0 Then
                MsgBox("Este Usuário Não Existe !", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txtUsuario.Text = tbUsuarios.Fields("nome").Value.ToString
            txtSenha.Text = tbUsuarios.Fields("senha").Value.ToString
            cboPermissao.Text = tbUsuarios.Fields("permissao").Value.ToString
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnAlterar.Text = "Salvar"
        Else
            tbUsuarios = RecebeTabela("select * from tbUsuarios where codigo = " & grpUsuarios.Tag)
            If grpUsuarios.Tag = 0 Then tbUsuarios.AddNew()
            tbUsuarios("nome").Value = txtUsuario.Text
            tbUsuarios("senha").Value = txtSenha.Text
            tbUsuarios("permissao").Value = cboPermissao.Text
            tbUsuarios.Update()
            btnSalvar.Enabled = True
            btnExcluir.Enabled = True
            btnAlterar.Text = "Alterar"
            limpar()
            carregarusuario()
            txtUsuario.Focus()
        End If
    End Sub
End Class