Public Class frmPermissao
    Dim ClasseUsuario As New clsUsuario, ClasseCombo As New clsCombo
    Dim x As Integer
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deseja salvar a permissão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarPermissao(cboPermissao.Text, clbPermissoes, IIf(clbPermissoes.GetItemChecked(x) = True, "1", "0"))
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Limpar()
        cboPermissao.Text = ""
        clbPermissoes.Items.Clear()
        pegamenus(clbPermissoes, frmPrincipal.MenuStrip1)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pegamenus(clbPermissoes, frmPrincipal.MenuStrip1)
        clbPermissoes.Focus()
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        ClasseUsuario.ConsultaPermissoes(cboPermissao.Text, clbPermissoes)
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a exclusão de permissão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarPermissao(cboPermissao.Text, clbPermissoes, IIf(clbPermissoes.GetItemChecked(x) = True, "1", "0"))
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
End Class