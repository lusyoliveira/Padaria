Imports System.Data.SqlClient

Public Class frmUsuarios
    Private Sub limpar()
        txtSenha.Text = ""
        txtUsuario.Text = ""
        cboPermissao.Text = ""
        txtFuncionario.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregarusuario()
        txtUsuario.Focus()
        MdiParent = frmPrincipal
    End Sub
    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        grpUsuarios.Tag = Val(lstUsuarios.SelectedItems(0).SubItems(0).Text)
        txtFuncionario.Text = lstUsuarios.SelectedItems(0).SubItems(0).Text
        txtUsuario.Text = lstUsuarios.SelectedItems(0).SubItems(1).Text
        cboPermissao.Text = lstUsuarios.SelectedItems(0).SubItems(2).Text
    End Sub
    Private Sub carregarusuario()
        Dim sql As String = "SELECT * FROM tbUsuarios WHERE nome LIKE '%" & txtUsuario.Text & "%'"
        If IsNumeric(txtUsuario.Text) Then
            sql = "SELECT * FROM tbUsuarios WHERE codigo = " & txtUsuario.Text
        End If

        lstUsuarios.Items.Clear()

        Dim cmd As New SqlCommand(sql, aConexao)
        Try
            aConexao.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim x As Integer = 0

            While reader.Read()
                lstUsuarios.Items.Add(reader("funcionario").ToString())
                lstUsuarios.Items(x).SubItems.Add(reader("nome").ToString())
                lstUsuarios.Items(x).SubItems.Add(reader("permissao").ToString())

                If x Mod 2 = 0 Then
                    lstUsuarios.Items(x).ForeColor = Color.Black
                    lstUsuarios.Items(x).BackColor = Color.LightGray
                Else
                    lstUsuarios.Items(x).ForeColor = Color.Black
                    lstUsuarios.Items(x).BackColor = Color.White
                End If

                x += 1
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar usuários: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        cboPermissao.Items.Clear()

        Dim sql As String = "SELECT DISTINCT permissao FROM tbpermissoes ORDER BY permissao"
        Dim cmd As New SqlCommand(sql, aConexao)

        Try
            aConexao.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cboPermissao.Items.Add(reader("permissao").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar permissões: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If btnAlterar.Text = "Alterar" Then
            Dim sql As String = "SELECT * FROM tbUsuarios WHERE codigo = " & grpUsuarios.Tag

            Dim cmd As New SqlCommand(sql, aConexao)
            Try
                aConexao.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txtUsuario.Text = reader("nome").ToString()
                    txtSenha.Text = reader("senha").ToString()
                    cboPermissao.Text = reader("permissao").ToString()

                    btnSalvar.Enabled = False
                    btnExcluir.Enabled = False
                    btnAlterar.Text = "Salvar"
                Else
                    MsgBox("Este usuário não existe!", MsgBoxStyle.Critical)
                End If

                reader.Close()
            Catch ex As Exception
                MsgBox("Erro ao carregar usuário para alteração: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else ' Botão está no modo "Salvar"
            Dim sql As String = "SELECT * FROM tbUsuarios WHERE codigo = " & grpUsuarios.Tag
            Dim cmd As New SqlCommand(sql, aConexao)
            Try
                aConexao.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim builder As New SqlCommandBuilder(adapter)
                Dim ds As New DataSet()

                adapter.Fill(ds, "tbUsuarios")
                Dim row As DataRow = ds.Tables("tbUsuarios").Rows(0)

                row("nome") = txtUsuario.Text
                row("senha") = txtSenha.Text
                row("permissao") = cboPermissao.Text

                adapter.Update(ds, "tbUsuarios")

                btnSalvar.Enabled = True
                btnExcluir.Enabled = True
                btnAlterar.Text = "Alterar"

                limpar()
                carregarusuario()
                txtUsuario.Focus()
            Catch ex As Exception
                MsgBox("Erro ao salvar alterações: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim sql As String = "SELECT * FROM tbUsuarios WHERE codigo = " & grpUsuarios.Tag

        Dim cmd As New SqlCommand(sql, aConexao)
        Try
            aConexao.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As New DataSet()

            adapter.Fill(ds, "tbUsuarios")
            If ds.Tables("tbUsuarios").Rows.Count > 0 Then
                ds.Tables("tbUsuarios").Rows(0).Delete()
                adapter.Update(ds, "tbUsuarios")
                carregarusuario()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class