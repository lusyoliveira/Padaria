Public Class frmClientes
    Dim ClasseCliente As New clsClientes, ClasseDependente As New clsDependente, tbClientes As DataTable
    Private Sub Limpar()
        txtNrficha.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        mkdTelefone.Text = ""
        txtNome.Text = ""
        cboParentesco.Text = ""
        lstCliente.Items.Clear()
        lstDependente.Items.Clear()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbClientes = ClasseCliente.ConsultaCliente(lstCliente, Val(txtNrficha.Text), txtNome.Text)
        lblData.Text = Date.Now.Date
        lblRegistro.Text = lstCliente.Items.Count()
        txtNrficha.Focus()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.SalvarCliente(Val(txtNrficha.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, mkdTelefone.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.ExcluirCliente(Val(txtNrficha.Text))
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.AlterarCliente(Val(txtNrficha.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, mkdTelefone.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstDependente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDependente.SelectedIndexChanged
        If lstDependente.SelectedItems.Count > 0 Then
            lblCodDep.Text = Val(lstDependente.SelectedItems(0).ToString)
            txtNome.Text = lstDependente.SelectedItems(1).ToString
            cboParentesco.Text = lstDependente.SelectedItems(2).ToString
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja incluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseDependente.SalvarDependente(Val(lblCodDep.Text), Val(lblCodigo.Text), txtDependente.Text, cboParentesco.SelectedValue)
        Else
            Exit Sub
        End If
        ClasseCliente.ConsultaCliente(lstCliente, Val(txtNrficha.Text), txtNome.Text)
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        ClasseDependente.ExcluirDependente(Val(lblCodDep.Text), Val(lblCodigo.Text))
    End Sub

    Private Sub btnVerifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        tbClientes = ClasseCliente.ConsultaCliente(lstCliente, 0, txtNome.Text)
        If tbClientes.Rows.Count <> 0 Then
            MessageBox.Show("O número de ficha já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNrficha.Text = ""
        Else
            MessageBox.Show("O Número não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        tbClientes = ClasseCliente.ConsultaCliente(lstCliente, Val(txtNrficha.Text), txtNome.Text)
        ClasseDependente.ConsultaDependente(lstDependente, Val(txtNrficha.Text))
    End Sub
End Class