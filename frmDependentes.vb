Imports System.Data.SqlClient

Public Class frmDependentes
    Private Sub Limpar()
        txtNome.Text = ""
        cboParentesco.Text = ""
    End Sub
    Private Sub frmDependentes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CarregarDependentes()
    End Sub
    Private Sub frmDependentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grpDependentes.Tag = 0
        CarregarList()
    End Sub

    Private Sub CarregarList()
        Dim sql As String = "SELECT * FROM tbDependentes WHERE codigocliente LIKE '%' + @nrficha + '%'"
        Dim x As Integer = 0

        Limpar()
        lstDependentes.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", frmClientes.txtNrficha.Text)

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstDependentes.Items.Add(reader("codigocliente").ToString())
                        lstDependentes.Items(x).SubItems.Add(reader("nome").ToString())
                        lstDependentes.Items(x).SubItems.Add(reader("parentesco").ToString())

                        If x Mod 2 = 0 Then
                            lstDependentes.Items(x).ForeColor = Color.Black
                            lstDependentes.Items(x).BackColor = Color.LightGray
                        Else
                            lstDependentes.Items(x).ForeColor = Color.Black
                            lstDependentes.Items(x).BackColor = Color.White
                        End If

                        x += 1
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar dependentes: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim sql As String = ""

        sql = "SELECT * FROM tbDependentes WHERE codigo = @tag"
        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@tag", grpDependentes.Tag)

            Try
                aConexao.Open()
                Dim tbDependentes As New DataTable()
                tbDependentes.Load(cmd.ExecuteReader())

                If tbDependentes.Rows.Count = 0 Then
                    MsgBox("Registro não encontrado.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                Dim row As DataRow = tbDependentes.Rows(0)
                If grpDependentes.Tag = 0 Then
                    ' Adiciona um novo registro
                    sql = "INSERT INTO tbDependentes (codigocliente, nome, parentesco) VALUES (@codigocliente, @nome, @parentesco)"
                Else
                    ' Atualiza um registro existente
                    sql = "UPDATE tbDependentes SET nome = @nome, parentesco = @parentesco WHERE codigo = @tag"
                End If

                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@codigocliente", frmClientes.txtNrficha.Text)
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@parentesco", cboParentesco.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information)
                CarregarList()
                txtNome.Text = ""
                txtNome.Focus()

            Catch ex As Exception
                MsgBox("Erro ao salvar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim sql As String = "DELETE FROM tbDependentes WHERE codigocliente = @nrficha"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", frmClientes.txtNrficha.Text)

            Try
                aConexao.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information)
                    CarregarList()
                Else
                    MsgBox("Não foi possível encontrar o registro para exclusão.", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim sql As String = "UPDATE tbDependentes SET nome = @nome, parentesco = @parentesco WHERE codigocliente = @nrficha"

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@parentesco", cboParentesco.Text)
            cmd.Parameters.AddWithValue("@nrficha", frmClientes.txtNrficha.Text)

            Try
                aConexao.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Registro alterado com sucesso!", MsgBoxStyle.Information)
                    CarregarList()
                Else
                    MsgBox("Não foi possível encontrar o registro para alteração.", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox("Erro ao alterar registro: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub
    Private Sub CarregarDependentes()
        Dim sql As String = "SELECT * FROM tbDependentes WHERE codigocliente = @nrficha"

        lstDependentes.Items.Clear()

        Using cmd As New SqlCommand(sql, aConexao)
            cmd.Parameters.AddWithValue("@nrficha", frmClientes.txtNrficha.Text)

            Try
                aConexao.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstDependentes.Items.Add(reader("nome").ToString())
                    End While
                End Using
            Catch ex As Exception
                MsgBox("Erro ao carregar dependentes: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                aConexao.Close()
            End Try
        End Using
    End Sub

    Private Sub grpDependentes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpDependentes.Enter
        txtNome.Focus()
    End Sub

    Private Sub lstDependentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lstDependentes.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        grpDependentes.Tag = Val(lstDependentes.SelectedItems(0).ToString)
        txtNome.Text = lstDependentes.SelectedItems(0).ToString
        cboParentesco.Text = lstDependentes.SelectedItems(1).ToString
    End Sub
End Class