Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class clsEntidades
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "CONSTRUTORES"

#End Region
#Region "PROPRIEDADES"
    Private Property _CodEntidade As Integer
    Public Property CodEntidade As Integer
        Get
            Return _CodEntidade
        End Get
        Set(value As Integer)
            _CodEntidade = value
        End Set
    End Property
    Private Property _CodContato As Integer
    Public Property CodContato As Integer
        Get
            Return _CodContato
        End Get
        Set(value As Integer)
            _CodContato = value
        End Set
    End Property
    Private Property _CodCargo As Integer
    Public Property CodCargo As Integer
        Get
            Return _CodCargo
        End Get
        Set(value As Integer)
            _CodCargo = value
        End Set
    End Property
    Private Property _NumeroFicha As Integer
    Public Property NumeroFicha As Integer
        Get
            Return _NumeroFicha
        End Get
        Set(value As Integer)
            _NumeroFicha = value
        End Set
    End Property
    Private Property _NomeFantasia As String
    Public Property NomeFantasia As String
        Get
            Return _NomeFantasia
        End Get
        Set(value As String)
            _NomeFantasia = value
        End Set
    End Property
    Private Property _Telefone1 As String
    Public Property Telefone1 As String
        Get
            Return _Telefone1
        End Get
        Set(value As String)
            _Telefone1 = value
        End Set
    End Property
    Private Property _Telefone2 As String
    Public Property Telefone2 As String
        Get
            Return _Telefone2
        End Get
        Set(value As String)
            _Telefone2 = value
        End Set
    End Property
    Private Property _Celular As String
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property
    Private Property _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Private Property _Matricula As Integer
    Public Property Matricula As Integer
        Get
            Return _Matricula
        End Get
        Set(value As Integer)
            _Matricula = value
        End Set
    End Property
    Private Property _CarteiraProfissional As String
    Public Property CarteiraProfissional As String
        Get
            Return _CarteiraProfissional
        End Get
        Set(value As String)
            _CarteiraProfissional = value
        End Set
    End Property
    Private Property _Cargo As Integer
    Public Property Cargo As Integer
        Get
            Return _Cargo
        End Get
        Set(value As Integer)
            _Cargo = value
        End Set
    End Property
    Private Property _Salario As Decimal
    Public Property Salario As Decimal
        Get
            Return _Salario
        End Get
        Set(value As Decimal)
            _Salario = value
        End Set
    End Property
    Private Property _Expediente As String
    Public Property Expediente As String
        Get
            Return _Expediente
        End Get
        Set(value As String)
            _Expediente = value
        End Set
    End Property

#End Region
#Region "METODOS"
    Public Function PesquisaEntidade(lstGrade As ListView, Codigo As Integer, NomeFantasia As String, Tipo As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbEntidades WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(NomeFantasia) Then
                    sql.AppendLine("AND NomeFantasia LIKE @NomeFantasia")
                End If

                If Not String.IsNullOrEmpty(Tipo) Then
                    sql.AppendLine("AND Tipo = @Tipo")
                End If

                sql.AppendLine("ORDER BY NomeFantasia")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(NomeFantasia) Then
                        command.Parameters.AddWithValue("@Nome", "%" & NomeFantasia & "%")
                    End If

                    If Not String.IsNullOrEmpty(Tipo) Then
                        command.Parameters.AddWithValue("@Tipo", Tipo)
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbClientes)

                    Dim x As Integer = 0
                    If tbClientes.Rows.Count > 0 Then
                        For Each row As DataRow In tbClientes.Rows
                            lstGrade.Items.Add(row("Codigo").ToString())
                            lstGrade.Items(x).SubItems.Add(row("NomeFantasia").ToString())
                            lstGrade.Items(x).SubItems.Add(row("RazaoSocial").ToString())
                            lstGrade.Items(x).SubItems.Add(row("DataNasc").ToString())
                            lstGrade.Items(x).SubItems.Add(row("EstadoCivil").ToString())
                            lstGrade.Items(x).SubItems.Add(row("endereco").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Complemento").ToString())
                            lstGrade.Items(x).SubItems.Add(row("bairro").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Cidade").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Uf").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Cep").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Sexo").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Rg").ToString())
                            lstGrade.Items(x).SubItems.Add(row("Documento").ToString())
                            lstGrade.Items(x).SubItems.Add(row("obs").ToString())
                            lstGrade.Items(x).SubItems.Add(row("DataCadastro").ToString())
                            lstGrade.Items(x).SubItems.Add(row("DataAlteracao").ToString())
                            lstGrade.Items(x).SubItems.Add(row("DataInativacao").ToString())
                            x += 1
                        Next
                    Else
                        MessageBox.Show("Esse Cliente não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return tbClientes
    End Function
    Public Sub ObterEntidade(Codigo As Integer, ByRef DadosEntidades As clsEntidades)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbEntidades WHERE Codigo = @Codigo"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@Codigo", Codigo)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DadosEntidades._CodEntidade = reader.GetInt32(0)
                            DadosEntidades._NomeFantasia = reader.GetInt32(1)
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a Entidade: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarEntidade(NomeFantasia As String, RazaoSocial As String, Datanasc As String, Estadocivil As String, Endereco As String, Complemento As String, Bairro As String, Cidade As String, Uf As String, Cep As String, sexo As String, Rg As String, Documento As String, Obs As String, Tipo As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbEntidades   (NomeFantasia,
                                                           RazaoSocial,
                                                           Datanasc,
                                                           Estadocivil,
                                                           Endereco,
                                                           Complemento,
                                                           Bairro,
                                                           Cidade,
                                                           Uf,
                                                           Cep,
                                                           sexo,
                                                           Rg,
                                                           Documento,
                                                           Obs,
                                                           DataCadastro,
                                                           Tipo)
                                                VALUES     (@NomeFantasia,
                                                           @RazaoSocial,
                                                           @Datanasc,
                                                           @Estadocivil,
                                                           @Endereco,
                                                           @Complemento,
                                                           @Bairro,
                                                           @Cidade,
                                                           @Uf,
                                                           @Cep,
                                                           @sexo,
                                                           @Rg,
                                                           @Documento,
                                                           @Obs,
                                                           GETDATE(),
                                                           @Tipo)"
                Using command As New SqlCommand(sql, connection)
                    If NomeFantasia = "" Then
                        command.Parameters.AddWithValue("@NomeFantasia", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@NomeFantasia", NomeFantasia)
                    End If
                    If RazaoSocial = "" Then
                        command.Parameters.AddWithValue("@RazaoSocial", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@RazaoSocial", RazaoSocial)
                    End If
                    If Datanasc = "" Then
                        command.Parameters.AddWithValue("@Datanasc", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Datanasc", Datanasc)
                    End If
                    If Estadocivil = "" Then
                        command.Parameters.AddWithValue("@Estadocivil", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Estadocivil", Estadocivil)
                    End If
                    If Endereco = "" Then
                        command.Parameters.AddWithValue("@Endereco", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Endereco", Endereco)
                    End If
                    If Complemento = "" Then
                        command.Parameters.AddWithValue("@Complemento", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Complemento", Complemento)
                    End If
                    If Bairro = "" Then
                        command.Parameters.AddWithValue("@Bairro", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Bairro", Bairro)
                    End If
                    If Cidade = "" Then
                        command.Parameters.AddWithValue("@Cidade", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Cidade", Cidade)
                    End If
                    If Uf = "" Then
                        command.Parameters.AddWithValue("@Uf", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Uf", Uf)
                    End If
                    command.Parameters.AddWithValue("@Cep", Cep)
                    If sexo = "" Then
                        command.Parameters.AddWithValue("@sexo", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@sexo", sexo)
                    End If
                    If Rg = "" Then
                        command.Parameters.AddWithValue("@Rg", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Rg", Rg)
                    End If
                    If Documento = "" Then
                        command.Parameters.AddWithValue("@Documento", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Documento", Documento)
                    End If
                    If Obs = "" Then
                        command.Parameters.AddWithValue("@Obs", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Obs", Obs)
                    End If
                    If Tipo = "" Then
                        command.Parameters.AddWithValue("@Tipo", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Tipo", Tipo)
                    End If
                    command.ExecuteNonQuery()
                    MessageBox.Show("Entidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a Entidade: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarEntidade(codigo As Integer, NomeFantasia As String, RazaoSocial As String, Datanasc As Date, Estadocivil As String, Endereco As String, Complemento As String, Bairro As String, Cidade As String, Uf As String, Cep As String, sexo As String, Rg As String, Documento As String, Obs As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE	tbEntidades
                               SET	NomeFantasia = @NomeFantasia,
		                            RazaoSocial = @RazaoSocial,
		                            Datanasc = @Datanasc,
		                            Estadocivil = @Estadocivil,
		                            Endereco = @Endereco,
		                            Complemento = @Complemento,
		                            Bairro = @Bairro,
		                            Cidade = @Cidade,
		                            Uf = @Uf,
		                            CEP = @Cep,
		                            sexo = @sexo,
		                            Rg = @Rg,
		                            Documento = @Documento,
		                            Obs = @Obs,
		                            DataAlteracao = GETDATE()
                             WHERE	Codigo = @Codigo"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.Parameters.AddWithValue("@NomeFantasia", NomeFantasia)
                    command.Parameters.AddWithValue("@RazaoSocial", RazaoSocial)
                    command.Parameters.AddWithValue("@Datanasc", Datanasc)
                    command.Parameters.AddWithValue("@Estadocivil", Estadocivil)
                    command.Parameters.AddWithValue("@Endereco", Endereco)
                    command.Parameters.AddWithValue("@Complemento", Complemento)
                    command.Parameters.AddWithValue("@Bairro", Bairro)
                    command.Parameters.AddWithValue("@Cidade", Cidade)
                    command.Parameters.AddWithValue("@Uf", Uf)
                    command.Parameters.AddWithValue("@Cep", Cep)
                    command.Parameters.AddWithValue("@sexo", sexo)
                    command.Parameters.AddWithValue("@Rg", Rg)
                    command.Parameters.AddWithValue("@Documento", Documento)
                    command.Parameters.AddWithValue("@Obs", Obs)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Entidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar Entidade: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirEntidade(codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbEntidades WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Entidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir a Entidade: " & ex.Message)
        End Try
    End Sub
    Public Sub ObterContato(CodEntidade As Integer, ByRef DadosEntidades As clsEntidades)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    Using RDR As SqlDataReader = cmd.ExecuteReader()
                        While RDR.Read()
                            DadosEntidades._CodContato = If(Not RDR.IsDBNull(RDR.GetOrdinal("Codigo")), RDR.GetInt32(RDR.GetOrdinal("Codigo")), String.Empty)
                            DadosEntidades._Telefone1 = If(Not RDR.IsDBNull(RDR.GetOrdinal("Telefone1")), RDR.GetString(RDR.GetOrdinal("Telefone1")), String.Empty)
                            DadosEntidades._Telefone2 = If(Not RDR.IsDBNull(RDR.GetOrdinal("Telefone2")), RDR.GetString(RDR.GetOrdinal("Telefone2")), String.Empty)
                            DadosEntidades._Celular = If(Not RDR.IsDBNull(RDR.GetOrdinal("Celular")), RDR.GetString(RDR.GetOrdinal("Celular")), String.Empty)
                            DadosEntidades._Email = If(Not RDR.IsDBNull(RDR.GetOrdinal("Email")), RDR.GetString(RDR.GetOrdinal("Email")), String.Empty)
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a Entidade: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarContato(CodEntidade As Integer, Telefone1 As String, Telefone2 As String, Celular As String, Email As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO    tbEntidadeContatos
                                                (CodEntidade,
                                                Telefone1,
                                                Telefone2,
                                                Celular,
                                                Email)
                                        VALUES
                                                (@CodEntidade,
                                                @Telefone1,
                                                @Telefone2,
                                                @Celular,
                                                @Email)"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    command.Parameters.AddWithValue("@Telefone1", Telefone1)
                    command.Parameters.AddWithValue("@Telefone2", Telefone2)
                    command.Parameters.AddWithValue("@Celular", Celular)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Contato salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o Contato: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarContato(CodEntidade As Integer, Codigo As Integer, Telefone1 As String, Telefone2 As String, Celular As String, Email As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE	tbEntidadeContatos
                                SET     CodEntidade = @CodEntidade, 
                                        Telefone1 = @Telefone1,
                                        Telefone2 = @Telefone2,
                                        Celular = @Celular,
                                        Email = @Email,
                                WHERE   Codigo = @Codigo AND CodEntidade = @CodEntidade"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.Parameters.AddWithValue("@Telefone1", Telefone1)
                    command.Parameters.AddWithValue("@Telefone2", Telefone2)
                    command.Parameters.AddWithValue("@Celular", Celular)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Contato alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o Contato: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirContato(CodEntidade As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Contato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o Contato: " & ex.Message)
        End Try
    End Sub

    Public Sub SalvarCargo(CodEntidade As Integer, Matricula As Integer, CarteiraProfissional As String, Cargo As String, Salario As String, Expediente As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbEntidadeCargo   (CodEntidade,
                                                                   Matricula,
                                                                   CarteiraProfissional,
                                                                   Cargo,
                                                                   Salario,
                                                                   Expediente,
                                                                   GETDATE())
                                        VALUES                     (@CodEntidade,
                                                                   @Matricula,
                                                                   @CarteiraProfissional,
                                                                   @Cargo,
                                                                   @Salario,
                                                                   @Expediente,
                                                                   @DataCadastro)"
                Using command As New SqlCommand(sql, connection)
                    If CodEntidade = 0 Then
                        command.Parameters.AddWithValue("@CodEntidade", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    End If
                    If Matricula = 0 Then
                        command.Parameters.AddWithValue("@Matricula", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Matricula", Matricula)
                    End If
                    If CarteiraProfissional = "" Then
                        command.Parameters.AddWithValue("@CarteiraProfissional", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@CarteiraProfissional", CarteiraProfissional)
                    End If
                    If Cargo = 0 Then
                        command.Parameters.AddWithValue("@Cargo", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Cargo", Cargo)
                    End If
                    If Salario = "" Then
                        command.Parameters.AddWithValue("@Salario", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Salario", Salario)
                    End If
                    If Expediente = "" Then
                        command.Parameters.AddWithValue("@Expediente", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Expediente", Expediente)
                    End If
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cargo salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o Cargo: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarCargo(CodEntidade As Integer, Codigo As Integer, Matricula As Integer, CarteiraProfissional As String, Cargo As String, Salario As String, Expediente As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE	tbEntidadeCargo
                                    SET     CodEntidade = @CodEntidade, 
                                            Matricula = @Matricula,
                                            CarteiraProfissional = @CarteiraProfissional,
                                            Cargo = @Cargo,
                                            Salario = @Salario,
                                            Expediente = @Expediente,
                                            DataAlteracao = GETDATE()
                                WHERE   Codigo = @Codigo AND CodEntidade = @CodEntidade"
                Using command As New SqlCommand(sql, connection)
                    If CodEntidade = 0 Then
                        command.Parameters.AddWithValue("@CodEntidade", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    End If
                    If Codigo = 0 Then
                        command.Parameters.AddWithValue("@Codigo", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If
                    If Matricula = 0 Then
                        command.Parameters.AddWithValue("@Matricula", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Matricula", Matricula)
                    End If
                    If CarteiraProfissional = "" Then
                        command.Parameters.AddWithValue("@CarteiraProfissional", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@CarteiraProfissional", CarteiraProfissional)
                    End If
                    If Cargo = 0 Then
                        command.Parameters.AddWithValue("@Cargo", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Cargo", Cargo)
                    End If
                    If Salario = "" Then
                        command.Parameters.AddWithValue("@Salario", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Salario", Salario)
                    End If
                    If Expediente = "" Then
                        command.Parameters.AddWithValue("@Expediente", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@Expediente", Expediente)
                    End If
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cargo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o Contato: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirCargo(CodEntidade As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbEntidadeCargo WHERE CodEntidade = @CodEntidade"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cargo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o Contato: " & ex.Message)
        End Try
    End Sub
    Public Sub ObterCargo(CodEntidade As Integer, ByRef DadosEntidades As clsEntidades)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbEntidadeCargo WHERE CodEntidade = @CodEntidade"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodEntidade", CodEntidade)
                    Using RDR As SqlDataReader = cmd.ExecuteReader()
                        While RDR.Read()
                            DadosEntidades._CodCargo = If(Not RDR.IsDBNull(RDR.GetOrdinal("Codigo")), RDR.GetInt32(RDR.GetOrdinal("Codigo")), String.Empty)
                            DadosEntidades._Matricula = If(Not RDR.IsDBNull(RDR.GetOrdinal("Matricula")), RDR.GetInt32(RDR.GetOrdinal("Matricula")), String.Empty)
                            DadosEntidades._CarteiraProfissional = If(Not RDR.IsDBNull(RDR.GetOrdinal("CarteiraProfissional")), RDR.GetString(RDR.GetOrdinal("CarteiraProfissional")), String.Empty)
                            DadosEntidades._Cargo = If(Not RDR.IsDBNull(RDR.GetOrdinal("Cargo")), RDR.GetInt32(RDR.GetOrdinal("Cargo")), String.Empty)
                            DadosEntidades._Salario = If(Not RDR.IsDBNull(RDR.GetOrdinal("Salario")), RDR.GetDecimal(RDR.GetOrdinal("Salario")), 0)
                            DadosEntidades._Expediente = If(Not RDR.IsDBNull(RDR.GetOrdinal("Expediente")), RDR.GetString(RDR.GetOrdinal("Expediente")), String.Empty)
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a Entidade: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
