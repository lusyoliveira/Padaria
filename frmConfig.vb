Imports System.Data.SqlClient

Public Class frmConfig
    Dim sql As String
    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        carregadados()
    End Sub
    Private Sub carregadados()
        Dim tbaux As DataTable = RecebeTabela("SELECT * FROM tbconfig")
        If tbaux.Rows.Count > 0 Then
            Dim row As DataRow = tbaux.Rows(0)
            chkEsconde.Checked = Convert.ToBoolean(row("esconder").ToString())
            txtCliente.Text = row("cliente").ToString()
        End If
        btnAlterar.Enabled = True
        btnSalvar.Enabled = True
        grpConfig.Enabled = False
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim esconderValue As Boolean = chkEsconde.Checked
        Dim sql As String = "UPDATE tbconfig SET cliente = @cliente, esconder = @esconder"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@cliente", txtCliente.Text)
            cmd.Parameters.AddWithValue("@esconder", esconderValue)

            If aConexao.State = ConnectionState.Closed Then
                aConexao.Open()
            End If

            cmd.ExecuteNonQuery()
        End Using

        btnAlterar.Enabled = True
        btnSalvar.Enabled = False
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        grpConfig.Enabled = True
    End Sub
End Class