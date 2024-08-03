Public Class frmRetiraCaixa
    Dim ClasseCombo As New clsCombo, ClasseCaixa As New clsCaixa
    Private Sub RetiraCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFuncionario.Text = frmPrincipal.ToolStripStatusLabel8.Text
    End Sub

    Private Sub cboFuncionario_Enter(sender As Object, e As EventArgs) Handles cboFuncionario.Enter
        ClasseCombo.PreencherComboBox("SELECT * FROM tbFuncionarios WHERE Tipo ='FU' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
    End Sub
End Class