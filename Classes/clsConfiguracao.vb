Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Public Class clsConfiguracao
    Dim ClasseConexao As New clsConexao, tbConfiguracao As New DataTable()
#Region "METODOS"
    Public Function ConsultaConfiguracao() As DataTable
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            Dim sql As String = "SELECT * FROM tbconfig"
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbConfiguracao)
                End Using
            End Using
        End Using
        Return tbConfiguracao
    End Function
    Public Sub SalvarConfiguracao(Cliente As String, Esconder As Boolean)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbconfig SET cliente = @cliente, esconder = @esconder"
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@cliente", Cliente)
                cmd.Parameters.AddWithValue("@esconder", Esconder)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub
    Public Sub Localizar(Tabela As String, lstGrade As ListView, Localizar As String)
        Dim sql As String = ""
        Dim x As Integer = 0

        lstGrade.Items.Clear()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Select Case Tabela
                    Case "Clientes"
                        sql = "SELECT * FROM tbClientes WHERE nome LIKE '%" & Localizar & "%'"
                        If IsNumeric(Localizar) Then
                            sql = "SELECT * FROM tbClientes WHERE nrficha = " & Localizar
                        End If
                    Case "Produtos"
                        sql = "SELECT * FROM tbProdutos WHERE produto LIKE '%" & Localizar & "%'"
                        If IsNumeric(Localizar) Then
                            sql = "SELECT * FROM tbProdutos WHERE codprod = " & Localizar
                        End If
                    Case "Funcionários"
                        sql = "SELECT * FROM tbFuncionarios WHERE nome LIKE '%" & Localizar & "%'"
                        If IsNumeric(Localizar) Then
                            sql = "SELECT * FROM tbFuncionarios WHERE codigo = " & Localizar
                        End If
                    Case "Fornecedores"
                        sql = "SELECT * FROM tbFornecedores WHERE Empresa LIKE '%" & Localizar & "%'"
                        If IsNumeric(Localizar) Then
                            sql = "SELECT * FROM tbFornecedores WHERE codigo = " & Localizar
                        End If
                    Case "Estoque"
                        sql = "SELECT * FROM tbEstoque WHERE produto LIKE '%" & Localizar & "%'"
                        If IsNumeric(Localizar) Then
                            sql = "SELECT * FROM tbEstoque WHERE codprod = " & Localizar
                        End If
                    Case Else
                        MessageBox.Show("Selecione uma tabela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                End Select

                Using cmd As New SqlCommand(sql, connection)
                    connection.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            Select Case Tabela
                                Case "Clientes"
                                    lstGrade.Items.Add(reader("codigo").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("nome").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("nrficha").ToString())
                                Case "Produtos"
                                    lstGrade.Items.Add(reader("codprod").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("produto").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("validade").ToString())
                                Case "Funcionários"
                                    lstGrade.Items.Add(reader("codigo").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("nome").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("salario").ToString())
                                Case "Fornecedores"
                                    lstGrade.Items.Add(reader("codigo").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("Empresa").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("telefone").ToString())
                                Case "Estoque"
                                    lstGrade.Items.Add(reader("codprod").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("produto").ToString())
                                    lstGrade.Items(x).SubItems.Add(reader("quantidade").ToString())
                            End Select
                            x += 1
                        End While

                        If x = 0 Then
                            MessageBox.Show("Nenhum registro encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        reader.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
