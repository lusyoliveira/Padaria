Imports System.Data.SqlClient
Imports System.Text
Public Class clsClientes
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaCliente(lstGrade As ListView, Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbClientes WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Nome) Then
                    sql.AppendLine("AND Nome LIKE @Nome")
                End If

                sql.AppendLine("ORDER BY Nome")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Nome) Then
                        command.Parameters.AddWithValue("@Nome", "%" & Nome & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbClientes)

                    Dim x As Integer = 0
                    If tbClientes.Rows.Count > 0 Then
                        For Each row As DataRow In tbClientes.Rows
                            lstGrade.Items.Add(row("nrficha").ToString())
                            lstGrade.Items(x).SubItems.Add(row("nome").ToString())
                            lstGrade.Items(x).SubItems.Add(row("endereco").ToString())
                            lstGrade.Items(x).SubItems.Add(row("bairro").ToString())
                            lstGrade.Items(x).SubItems.Add(row("telefone").ToString())

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
    Public Sub SalvarCliente(nrficha As Integer, nome As String, endereco As String, bairro As String, telefone As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbClientes (nrficha, nome, endereco, bairro, telefone, datacad) VALUES (@nrficha, @nome, @endereco, @bairro, @telefone, GETDATE())"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@nrficha", nrficha)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarCliente(nrficha As Integer, nome As String, endereco As String, bairro As String, telefone As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()

            Dim sql As String = "UPDATE tbClientes SET nome = @nome, endereco = @endereco, bairro = @bairro, telefone = @telefone WHERE nome = @nome"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@nrficha", nrficha)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirCliente(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbClientes WHERE Codigo = @Codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
