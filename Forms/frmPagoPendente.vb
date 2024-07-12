Public Class frmPagoPendente
    Dim ClasseCaderneta As New clsCaderneta
    Private Sub frmPagoPendente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNrficha.Focus()
        ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
    End Sub
    Private Sub Limpar()
        txtNrficha.Text = ""
        lblClientes.Text = ""
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma o pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseCaderneta.PagarCaderneta(txtNrficha.Text)
            ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseCaderneta.ConsultaCadernetaPendente(lstPagamento)
    End Sub

End Class