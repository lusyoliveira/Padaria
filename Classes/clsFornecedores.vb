Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.Text

Public Class clsFornecedores
    Dim ClasseConexao As New clsConexao, tbFornecedores As New DataTable()
#Region "PROPRIEDADES"

#End Region
#Region "METODOS"
    Public Sub ConsultaFornecedor(lstGrade As ListView, Codigo As Integer, Fornecedor As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFornecedores WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Fornecedor) Then
                    sql.AppendLine("AND Fornecedor LIKE @Fornecedor")
                End If

                sql.AppendLine("ORDER BY Fornecedor")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Fornecedor) Then
                        command.Parameters.AddWithValue("@Fornecedor", "%" & Fornecedor & "%")
                    End If
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            lstGrade.Items.Add(reader("Codigo").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("empresa").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("endereco").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("bairro").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("complemento").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cidade").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cnpj").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("uf").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("cep").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("fornecedor").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("telefone").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("celular").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("site").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("email").ToString())
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o fornecedor: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarFornecedor(Fornecedor As String, Empresa As String, CNPJ As String, endereco As String, bairro As String, complemento As String, cidade As String, UF As String, CEP As String, Telefone As String, Celular As String, site As String, email As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbFornecedores (Fornecedor, Empresa, CNPJ,endereco, bairro, complemento, cidade, UF, CEP, Telefone, Celular,site, email) VALUES (@Fornecedor, @Empresa, @CNPJ,@endereco, @bairro, @complemento, @cidade, @UF, @CEP, @Telefone, @Celular,@site, @email)"
            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Fornecedor", Fornecedor)
                command.Parameters.AddWithValue("@Empresa", Empresa)
                command.Parameters.AddWithValue("@CNPJ", CNPJ)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@complemento", complemento)
                command.Parameters.AddWithValue("@cidade", cidade)
                command.Parameters.AddWithValue("@UF", UF)
                command.Parameters.AddWithValue("@CEP", CEP)
                command.Parameters.AddWithValue("@Telefone", Telefone)
                command.Parameters.AddWithValue("@Celular", Celular)
                command.Parameters.AddWithValue("@site", site)
                command.Parameters.AddWithValue("@email", email)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarFornecedor(Codigo As Integer, Fornecedor As String, Empresa As String, CNPJ As String, endereco As String, bairro As String, complemento As String, cidade As String, UF As String, CEP As String, Telefone As String, Celular As String, site As String, email As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbFornecedores SET Fornecedor = @Fornecedor, Empresa = @Empresa, CNPJ = @CNPJ, endereco = @endereco, bairro = @bairro, complemento = @complemento, cidade = @cidade,UF = @UF, CEP = @CEP, Telefone = @Telefone, Celular = @Celular, site = @site, email = @email WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Codigo", Codigo)
                command.Parameters.AddWithValue("@Fornecedor", Fornecedor)
                command.Parameters.AddWithValue("@Empresa", Empresa)
                command.Parameters.AddWithValue("@CNPJ", CNPJ)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@complemento", complemento)
                command.Parameters.AddWithValue("@cidade", cidade)
                command.Parameters.AddWithValue("@UF", UF)
                command.Parameters.AddWithValue("@CEP", CEP)
                command.Parameters.AddWithValue("@Telefone", Telefone)
                command.Parameters.AddWithValue("@Celular", Celular)
                command.Parameters.AddWithValue("@site", site)
                command.Parameters.AddWithValue("@email", email)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirFornecedor(Codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbFornecedores WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Codigo", Codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ComboFornecedores(Fornecedores As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbFornecedores WHERE empresa = @empresa"
                Using cmd As New SqlCommand(sql, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If Not reader.HasRows Then
                            MessageBox.Show("Fornecedor inexistente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            reader.Read()
                            Fornecedores = reader("codigo").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consulta fornecedor: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
