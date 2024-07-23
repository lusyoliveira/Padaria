Imports System.Data.SqlClient
Imports System.Text

Public Class clsEstoque
    Dim ClasseConexao As New clsConexao
#Region "PROPRIEDADES"
    Private Property _CodProd As Integer
    Public Property CodProd As Integer
        Get
            Return _CodProd
        End Get
        Set(value As Integer)
            _CodProd = value
        End Set
    End Property
    Private Property _CodForn As Integer
    Public Property CodForn As Integer
        Get
            Return _CodForn
        End Get
        Set(value As Integer)
            _CodForn = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Sub PesquisaEstoque(lstGrade As ListView, CodProd As Integer, Produto As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM cs_Estoque WHERE 1=1")
                Using cmd As New SqlCommand(sql.ToString, connection)
                    If CodProd <> 0 Then
                        sql.AppendLine("AND CodProd = @Codigo")
                    End If

                    If Not String.IsNullOrEmpty(Produto) Then
                        sql.AppendLine("AND Produto LIKE @Produto")
                    End If

                    sql.AppendLine("ORDER BY Nome")
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            lstGrade.Items.Add(reader("CodProd").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("produto").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("quantidade").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("tipo").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("dataentrada").ToString())
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(FormatCurrency(reader("valor").ToString()))
                            lstGrade.Items(lstGrade.Items.Count - 1).SubItems.Add(reader("fornecedor").ToString())
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar estoque: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub EntradaEstoque(CodProd As Integer, Quantidade As Integer, tipo As String, Valor As Decimal, DataEntrada As String, Fornecedor As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbEstoque (CodProd, quantidade, tipo, valor, dataentrada, fornecedor) VALUES (@CodProd, @quantidade, @tipo, @valor, @dataentrada, @fornecedor)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodProd", CodProd)
                    cmd.Parameters.AddWithValue("@quantidade", Quantidade)
                    cmd.Parameters.AddWithValue("@tipo", tipo)
                    cmd.Parameters.AddWithValue("@valor", Valor)
                    cmd.Parameters.AddWithValue("@dataentrada", DataEntrada)
                    cmd.Parameters.AddWithValue("@fornecedor", Fornecedor)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Entrada registrada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao registrar a entrada: " & ex.Message)
        End Try
    End Sub
    Public Sub SaidaEstoque(CodProd As Integer, Quantidade As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbEstoque SET quantidade = quantidade - 1 WHERE CodProd = @CodProd"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodProd", CodProd)
                    cmd.Parameters.AddWithValue("@quantidade", Quantidade)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Saida registrada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao registra a saída: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirEstoque(Produto As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbEstoque WHERE produto = @produto"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@produto", Produto)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir estoque: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
