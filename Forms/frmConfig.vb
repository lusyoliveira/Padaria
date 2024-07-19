Public Class frmConfig
    Dim ClasseConfigurcao As New clsConfiguracao, tbConfiguracao As DataTable

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaConfiguracao()
    End Sub
    Private Sub CarregaConfiguracao()
        tbConfiguracao = ClasseConfigurcao.ConsultaConfiguracao()
        If tbConfiguracao.Rows.Count > 0 Then
            Dim row As DataRow = tbConfiguracao.Rows(0)
            chkEsconde.Checked = Convert.ToBoolean(row("esconder").ToString())
            txtCliente.Text = row("cliente").ToString()
        End If
        btnAlterar.Enabled = True
        btnSalvar.Enabled = True
        grpConfig.Enabled = False
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim esconderValue As Boolean = chkEsconde.Checked
        Dim MsgResult As DialogResult = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseConfigurcao.SalvarConfiguracao(txtCliente.Text, esconderValue)
        Else
            Exit Sub
        End If

        btnAlterar.Enabled = True
        btnSalvar.Enabled = False
    End Sub

End Class