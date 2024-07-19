Imports System.Data.SqlClient
Imports System.Text
Public Class clsFuncionarios
    Dim ClasseConexao As New clsConexao, tbFuncionarios As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaFuncionario(lstGrade As ListView, Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFuncionarios WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Nome) Then
                    sql.AppendLine("AND nome LIKE @nome")
                End If

                sql.AppendLine("ORDER BY nome")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Nome) Then
                        command.Parameters.AddWithValue("@nome", "%" & Nome & "%")
                    End If
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            lstGrade.Items.Add(reader("Codigo").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("nome").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("endereco").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("bairro").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cidade").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("estado").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cep").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cpf").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("rg").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("telefone").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("celular").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("numeroregistro").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cargo").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("salario").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("pis").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("numerocarteira").ToString())
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar Funcionarios: " & ex.Message)
        End Try
        Return tbFuncionarios
    End Function
    Public Sub SalvarFuncionario(nome As String, endereco As String, bairro As String, cidade As String, uf As String, cpf As String, rg As String, cep As String, telefone As String, numeroregistro As String, celular As String, numerocarteira As String, cargo As String, salario As Decimal, pis As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbFuncionarios (nome, endereco, bairro, cidade, estado, cep, cpf, rg, telefone, celular, numeroregistro, cargo, salario, pis, numerocarteira) VALUES (@nome, @endereco, @bairro, @cidade, @estado, @cep, @cpf, @rg, @telefone, @celular, @numeroregistro, @cargo, @salario, @pis, @numerocarteira)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nome", nome)
                    cmd.Parameters.AddWithValue("@endereco", endereco)
                    cmd.Parameters.AddWithValue("@bairro", bairro)
                    cmd.Parameters.AddWithValue("@cidade", cidade)
                    cmd.Parameters.AddWithValue("@estado", uf)
                    cmd.Parameters.AddWithValue("@cep", cep)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    cmd.Parameters.AddWithValue("@rg", rg)
                    cmd.Parameters.AddWithValue("@telefone", telefone)
                    cmd.Parameters.AddWithValue("@celular", celular)
                    cmd.Parameters.AddWithValue("@numeroregistro", numeroregistro)
                    cmd.Parameters.AddWithValue("@cargo", cargo)
                    cmd.Parameters.AddWithValue("@salario", salario)
                    cmd.Parameters.AddWithValue("@pis", pis)
                    cmd.Parameters.AddWithValue("@numerocarteira", numerocarteira)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar Funcionarios: " & ex.Message)
        End Try
    End Sub

    Public Sub AlterarFuncionario(codigo As Integer, nome As String, endereco As String, bairro As String, cidade As String, uf As String, cpf As String, rg As String, cep As String, telefone As String, numeroregistro As String, celular As String, numerocarteira As String, cargo As String, salario As Decimal, pis As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbFuncionarios SET nome = @nome, endereco = @endereco, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, cpf = @cpf, rg = @rg, telefone = @telefone, celular = @celular, numeroregistro = @numeroregistro, cargo = @cargo, salario = @salario, pis = @pis, numerocarteira = @numerocarteira WHERE Codigo = @codigo"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@codigo", codigo)
                    cmd.Parameters.AddWithValue("@nome", nome)
                    cmd.Parameters.AddWithValue("@endereco", endereco)
                    cmd.Parameters.AddWithValue("@bairro", bairro)
                    cmd.Parameters.AddWithValue("@cidade", cidade)
                    cmd.Parameters.AddWithValue("@estado", uf)
                    cmd.Parameters.AddWithValue("@cep", cep)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    cmd.Parameters.AddWithValue("@rg", rg)
                    cmd.Parameters.AddWithValue("@telefone", telefone)
                    cmd.Parameters.AddWithValue("@celular", celular)
                    cmd.Parameters.AddWithValue("@numeroregistro", numeroregistro)
                    cmd.Parameters.AddWithValue("@cargo", cargo)
                    cmd.Parameters.AddWithValue("@salario", salario)
                    cmd.Parameters.AddWithValue("@pis", pis)
                    cmd.Parameters.AddWithValue("@numerocarteira", numerocarteira)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar Funcionarios: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirFuncionario(codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbFuncionarios WHERE Codigo = @codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir Funcionarios: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
