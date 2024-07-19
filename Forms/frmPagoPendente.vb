Public Class frmPagoPendente
    Dim ClasseCaderneta As New clsCaderneta
    Private Sub frmPagoPendente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNrficha.Focus()
        ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
    End Sub
    Private Sub Limpar()
        txtNrficha.Text = ""
        lblClientes.Text = ""
        lblTotalPagar.Text = ""
        lstPagamento.Items.Clear()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma o pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.PagarCaderneta(txtNrficha.Text)
            Limpar()
            ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
    End Sub

    Private Sub lstPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPagamento.SelectedIndexChanged
        If lstPagamento.SelectedItems.Count > 0 Then
            lblCodigo.Text = lstPagamento.SelectedItems(0).SubItems(0).Text
            txtNrficha.Text = lstPagamento.SelectedItems(0).SubItems(1).Text
            lblClientes.Text = lstPagamento.SelectedItems(0).SubItems(2).Text
            lblTotalPagar.Text = lstPagamento.SelectedItems(0).SubItems(4).Text
            txtNrficha.Enabled = False
        End If
    End Sub
End Class