Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class clsDependente
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "PROPRIEDADES"

#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaDependente(lstGrade As ListView, nrficha As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbDependentes WHERE codigocliente = @nrficha"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(TbDependentes)
                        Dim x As Integer = 0
                        For Each row As DataRow In TbDependentes.Rows
                            lstGrade.Items.Add(row("codigocliente").ToString())
                            lstGrade.Items(x).SubItems.Add(row("nome").ToString())
                            lstGrade.Items(x).SubItems.Add(row("parentesco").ToString())

                            If x Mod 2 = 0 Then
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.LightGray
                            Else
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.White
                            End If
                            x += 1
                        Next
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return TbDependentes
    End Function
    Public Sub SalvarDependente(CodDep As Integer, CodCli As Integer, Nome As String, Parentesco As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbDependentes WHERE codigo = @CodDep"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodDep", CodDep)

                    TbDependentes.Load(cmd.ExecuteReader())

                    Dim row As DataRow = TbDependentes.Rows(0)
                    If TbDependentes.Rows.Count() = 0 Then
                        ' Adiciona um novo registro
                        sql = "INSERT INTO tbDependentes (codigocliente, nome, parentesco) VALUES (@CodCli, @nome, @parentesco)"
                    Else
                        ' Atualiza um registro existente
                        sql = "UPDATE tbDependentes SET nome = @nome, parentesco = @parentesco WHERE codigo = @CodDep"
                    End If

                    cmd.CommandText = sql
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@CodCli", CodCli)
                    cmd.Parameters.AddWithValue("@nome", Nome)
                    cmd.Parameters.AddWithValue("@parentesco", Parentesco)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirDependente(CodDep As Integer, CodCli As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbDependentes WHERE codigocliente = @nrficha"

                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", frmClientes.txtNrficha.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Não foi possível encontrar o registro para exclusão!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o cliente: " & ex.Message)
        End Try
    End Sub
    Public Sub AtualizaDependente(CodDep As Integer, CodCli As Integer, Nome As String, Parentesco As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbDependentes SET nome = @nome, parentesco = @parentesco WHERE codigocliente = @CodCli"

                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nome", Nome)
                    cmd.Parameters.AddWithValue("@parentesco", Parentesco)
                    cmd.Parameters.AddWithValue("@CodCli", CodCli)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registro alterar com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Não foi possível encontrar o registro para alterar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o cliente: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
