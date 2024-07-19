Imports System.Data.SqlClient
Imports System.Text
Public Class clsProdutos
    Dim ClasseConexao As New clsConexao, tbProdutos As New DataTable()

#Region "PROPRIEDADES"
    Private Property _Produto As String
    Public Property Produto As String
        Get
            Return _Produto
        End Get
        Set(value As String)
            _Produto = value
        End Set
    End Property
    Private Property _Valor As Decimal
    Public Property Valor As Decimal
        Get
            Return _Valor
        End Get
        Set(value As Decimal)
            _Valor = value
        End Set
    End Property
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaProduto(lstGrade As ListView, Codigo As Integer, Produto As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbProdutos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Produto) Then
                    sql.AppendLine("AND Produto LIKE @Produto")
                End If

                sql.AppendLine("ORDER BY Produto")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Produto) Then
                        command.Parameters.AddWithValue("@Produto", "%" & Produto & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbProdutos)

                    Dim x As Integer = 0
                    If tbProdutos.Rows.Count > 0 Then
                        For Each row As DataRow In tbProdutos.Rows
                            lstGrade.Items.Add(row("Codigo").ToString())
                            lstGrade.Items(x).SubItems.Add(row("produto").ToString())
                            lstGrade.Items(x).SubItems.Add(FormatCurrency(row("valorunit")))
                            lstGrade.Items(x).SubItems.Add(row("validade").ToString())
                            lstGrade.Items(x).SubItems.Add(row("quantidade").ToString())
                            If x Mod 2 = 0 Then
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.LightGray
                            Else
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.White
                            End If
                            x += 1
                        Next
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return tbProdutos
    End Function
    Public Sub SalvarProduto(Produto As String, Validade As Date, ValorUnit As Decimal, Quantidade As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbProdutos (produto, validade, valorunit,Quantidade) VALUES (@produto, @validade, @valorunit,@Quantidade)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Produto", Produto)
                    command.Parameters.AddWithValue("@Validade", Validade)
                    command.Parameters.AddWithValue("@ValorUnit", ValorUnit)
                    command.Parameters.AddWithValue("@Quantidade", Quantidade)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto salvo com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar produto: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarProduto(Codprod As Integer, Produto As String, Validade As Date, ValorUnit As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbProdutos SET produto = @produto, validade = @validade, valorunit = @valorunit WHERE Codigo = @codprod"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codprod", Codprod)
                    command.Parameters.AddWithValue("@Produto", Produto)
                    command.Parameters.AddWithValue("@Validade", Validade)
                    command.Parameters.AddWithValue("@ValorUnit", ValorUnit)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto alterado com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar produto: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirProduto(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbProdutos WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto excluído com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir produto: " & ex.Message)
        End Try
    End Sub
    Public Sub ConsultaProdCodigo(Codigo As Integer, ByRef DadosProd As clsProdutos)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbProdutos WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            DadosProd._Produto = reader.GetString(2) 'tbProdutos.Rows(0)("Produto").ToString
                            DadosProd._Valor = reader.GetDecimal(4) ' Convert.ToDecimal(tbProdutos.Rows(0)("valorunit"))
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
