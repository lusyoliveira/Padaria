Imports System.Data.SqlClient
Imports System.Text
Public Class clsFuncionarios
    Dim ClasseConexao As New clsConexao, tbFuncionarios As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaFuncionario(lstGrade As ListView, Codigo As Integer, Matricula As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFuncionarios WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND codfunc = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Matricula) Then
                    sql.AppendLine("AND numeroregistro LIKE @Matricula")
                End If

                sql.AppendLine("ORDER BY Matricula")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Matricula) Then
                        command.Parameters.AddWithValue("@Matricula", "%" & Matricula & "%")
                    End If
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            lstGrade.Items.Add(reader("nome").ToString())
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
        End Using
    End Sub

    Public Sub AlterarFuncionario(codigo As Integer, nome As String, endereco As String, bairro As String, cidade As String, uf As String, cpf As String, rg As String, cep As String, telefone As String, numeroregistro As String, celular As String, numerocarteira As String, cargo As String, salario As Decimal, pis As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbFuncionarios SET matricula = @matricula, nome = @nome, estadocivil = @estadoCivil, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, sexo = @sexo, telefone1 = @telefone1, telefone2 = @telefone2, celular = @celular, email = @email, rg = @rg, cpf = @cpf, carteiraprofissional = @carteiraProfissional, cargo = @cargo, salario = @salario, expediente = @expediente, obs = @obs WHERE codfunc = @codigo"
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
        End Using
    End Sub
    Public Sub ExcluirFuncionario(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbFuncionarios WHERE codfunc = @codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
