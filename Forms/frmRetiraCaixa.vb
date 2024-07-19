Public Class frmRetiraCaixa
    Dim ClasseCombo As New clsCombo, ClasseCaixa As New clsCaixa
    Private Sub RetiraCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFuncionario.Text = frmPrincipal.ToolStripStatusLabel8.Text
    End Sub

    Private Sub cboFuncionario_Leave(sender As Object, e As EventArgs) Handles cboFuncionario.Leave
        ClasseCaixa.CodFunc = ClasseCombo.LerCombo(cboFuncionario)

    End Sub
    Private Sub cboFuncionario_Enter(sender As Object, e As EventArgs) Handles cboFuncionario.Enter
        ClasseCombo.CarregaCombo(cboFuncionario, "SELECT Codigo, Nome FROM tbFuncionarios ORDER BY Nome")
    End Sub
End Class