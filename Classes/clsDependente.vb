Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class clsDependente
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "PROPRIEDADES"

#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaDependente(lstGrade As ListView, CodEntidade As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbEntidadeDependente WHERE CodEntidade = @CodEntidade"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(TbDependentes)
                        Dim x As Integer = 0
                        For Each row As DataRow In TbDependentes.Rows
                            lstGrade.Items.Add(row("Codigo").ToString())
                            lstGrade.Items(x).SubItems.Add(row("NomeDependente").ToString())
                            lstGrade.Items(x).SubItems.Add(row("DataNasc").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Documento").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Parentesco").ToString())

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
    Public Sub SalvarDependente(CodEntidade As Integer, NomeDependente As String, DataNasc As String, Documento As String, Parentesco As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbEntidadeDependente   (CodEntidade,
                                                                        NomeDependente,
                                                                        DataNasc,
                                                                        Documento,
                                                                        Parentesco,
                                                                        DataCadastro)
                                            VALUES                      (@CodEntidade, 
                                                                        @NomeDependente, 
                                                                        @DataNasc, 
                                                                        @Documento, 
                                                                        @Parentesco, 
                                                                        GETDATE())"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    command.Parameters.AddWithValue("@NomeDependente", NomeDependente)
                    command.Parameters.AddWithValue("@DataNasc", DataNasc)
                    command.Parameters.AddWithValue("@Documento", Documento)
                    command.Parameters.AddWithValue("@Parentesco", Parentesco)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o dependente: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarDependente(CodEntidade As Integer, NomeDependente As String, DataNasc As String, Documento As String, Parentesco As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbEntidadeDependente 
                                    SET  
                                            CodEntidade = @CodEntidade,
                                            NomeDependente = @NomeDependente,
                                            DataNasc = @DataNasc,
                                            Documento = @Documento,
                                            Parentesco = @Parentesco,
                                            DataAlteracao = GETDATE()
W                                   WHERE   CodEntidade = @CodEntidade"

                Using Command As New SqlCommand(sql, connection)
                    Command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    Command.Parameters.AddWithValue("@NomeDependente", NomeDependente)
                    Command.Parameters.AddWithValue("@DataNasc", DataNasc)
                    Command.Parameters.AddWithValue("@Documento", Documento)
                    Command.Parameters.AddWithValue("@Parentesco", Parentesco)
                    Command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o cliente: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirDependente(CodEntidade As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbEntidadeDependente WHERE CodEntidade = @CodEntidade"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o cliente: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
