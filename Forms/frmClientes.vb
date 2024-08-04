Public Class frmClientes
    Dim ClasseCliente As New clsEntidades, ClasseDependente As New clsDependente, ClasseCombo As New clsCombo, tbClientes As DataTable
    Private Sub Limpar()
        lblCodigo.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        mkdTelefone.Text = ""
        txtNome.Text = ""
        cboParentesco.Text = ""
        txtNome.Text = ""
        mskDnascimento.Text = ""
        cboEstadoCivil.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        rbdFeminino.Checked = False
        rbdMasculino.Checked = False
        txtCidade.Text = ""
        cboUf.Text = ""
        mskCep.Text = ""
        mskTel2.Text = ""
        mskCel.Text = ""
        txtEmail.Text = ""
        mskrg.Text = ""
        mskcpf.Text = ""
        txtDependente.Text = ""
        mskcpf_dep.Text = ""
        mskcpf_dep.Text = ""
        mskdtdatadep.Text = ""
        txtObs.Text = ""
        lstEntidade.Items.Clear()
        lstDependente.Items.Clear()
    End Sub
    Private Sub frmProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseCliente.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        lblData.Text = Date.Now.Date
        lblRegistro.Text = lstEntidade.Items.Count()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.SalvarEntidade(txtNome.Text, txtNome.Text, "", cboEstadoCivil.Text, txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, "", mskrg.Text, mskcpf.Text, txtObs.Text, "C")
            ClasseCliente.SalvarContato(Val(lblCodigo.Text), mkdTelefone.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.ExcluirContato(Val(lblCodigo.Text))
            ClasseCliente.ExcluirEntidade(Val(lblCodigo.Text))
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCliente.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, txtNome.Text, mskDnascimento.Text, cboEstadoCivil.Text, txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, If(rbdFeminino.Checked = True, "F", "M"), mskrg.Text, mskcpf.Text, txtObs.Text)
            ClasseCliente.AlterarContato(Val(lblCodigo.Text), ClasseCliente.CodContato, mkdTelefone.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            Limpar()
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
            ClasseDependente.SalvarDependente(Val(lblCodigo.Text), txtDependente.Text, mskdtdatadep.Text, mskcpf_dep.Text, cboParentesco.SelectedValue)
        Else
            Exit Sub
        End If
        ClasseCliente.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

    Private Sub btnAlterarDep_Click(sender As Object, e As EventArgs) Handles btnAlterarDep.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja incluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseDependente.AlterarDependente(Val(lblCodigo.Text), txtDependente.Text, mskdtdatadep.Text, mskcpf_dep.Text, cboParentesco.SelectedValue)
        Else
            Exit Sub
        End If
        ClasseCliente.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtNome.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            mskDnascimento.Text = lstEntidade.SelectedItems(0).SubItems(3).Text
            cboEstadoCivil.Text = lstEntidade.SelectedItems(0).SubItems(4).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            txtCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cboUf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mskCep.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
            mskcpf.Text = lstEntidade.SelectedItems(0).SubItems(13).Text
        End If
        ClasseCliente.ObterContato(Val(lblCodigo.Text), ClasseCliente)
        mkdTelefone.Text = ClasseCliente.Telefone1
        mskTel2.Text = ClasseCliente.Telefone2
        mskCel.Text = ClasseCliente.Celular
        txtEmail.Text = ClasseCliente.Email
    End Sub

    Private Sub cboParentesco_Enter(sender As Object, e As EventArgs) Handles cboParentesco.Enter
        Dim ListaParentesco = ClasseCombo.PreencherComboBox("SELECT * FROM tbParentesco ORDER BY Parentesco", "Codigo", "Parentesco")
        With Me.cboParentesco
            .DataSource = ListaParentesco
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboEstadoCivil_Enter(sender As Object, e As EventArgs) Handles cboEstadoCivil.Enter
        Dim ListaCivil = ClasseCombo.PreencherComboBox("SELECT * FROM tbEstadoCivil ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboEstadoCivil
            .DataSource = ListaCivil
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseDependente.ExcluirDependente(Val(lblCodigo.Text))
        Else
            Exit Sub
        End If
        ClasseCliente.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        tbClientes = ClasseCliente.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        ClasseDependente.ConsultaDependente(lstDependente, Val(lblCodigo.Text))
    End Sub
End Class