Public Class frmPermissao
    Dim ClasseUsuario As New clsUsuario
    Dim x As Integer
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deesja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarPermissao(cboPermissao.Text, lstMenus, IIf(lstMenus.GetItemChecked(x) = True, "1", "0"))
            limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub limpar()
        cboPermissao.Text = ""
        lstMenus.Items.Clear()
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
        lstMenus.Focus()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClasseUsuario.ConsultaPermissoes(cboPermissao.Text, lstMenus)
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a exclusão de permissão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarPermissao(cboPermissao.Text, lstMenus, IIf(lstMenus.GetItemChecked(x) = True, "1", "0"))
            limpar()
        Else
            Exit Sub
        End If
    End Sub
End Class