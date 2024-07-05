Public Class frmAbrirCaixa

    Private Sub frmAbrirCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFuncionario.Text = frmPrincipal.ToolStripStatusLabel8.Text
    End Sub
End Class