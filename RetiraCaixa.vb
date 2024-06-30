Public Class RetiraCaixa

    Private Sub RetiraCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        txtFuncionario.Text = frmPrincipal.ToolStripStatusLabel8.Text
    End Sub
End Class