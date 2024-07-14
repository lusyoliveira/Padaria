Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Text

Public Class clsCaderneta
    Dim ClasseConexao As New clsConexao, tbCaderneta As New DataTable()
#Region "PROPRIEDADES"
    Public Property CodCliente As Integer
#End Region
#Region "METODOS"
    Public Function ConsultaCaderneta()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New String("SELECT * FROM tbcaderneta ORDER BY codigo DESC")
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbcaderneta)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
        Return tbcaderneta
    End Function
    Public Function ConsultaCadernetaPendente(lstGrade As ListView)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New String("SELECT * FROM tbcaderneta ORDER BY codigo DESC")
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbCaderneta)
                    Dim x As Integer = 0
                    For Each row As DataRow In tbCaderneta.Rows
                        lstGrade.Items.Add(row("nrficha").ToString())
                        lstGrade.Items(x).SubItems.Add(row("cliente").ToString())
                        lstGrade.Items(x).SubItems.Add(row("dependente").ToString())
                        lstGrade.Items(x).SubItems.Add(row("datacompra").ToString())
                        lstGrade.Items(x).SubItems.Add(FormatCurrency(row("total_final")))
                        lstGrade.Items(x).SubItems.Add(row("pago").ToString())

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
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
        Return tbCaderneta
    End Function
    Public Sub Fazer(nrficha As Integer, produtos As String, valor As Decimal, quantidade As Integer, datacompra As Date, total As Decimal, nrcaderneta As Integer)
        Dim sql As String
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()

                If nrcaderneta = 0 Then
                    sql = "INSERT INTO tbCaderneta (nrficha, produtos, valor, quantidade, datacompra, total) VALUES (@nrficha, @produtos, @valor, @quantidade, @datacompra, @total)"
                Else
                    sql = "UPDATE tbCaderneta SET produtos = @produtos, valor = @valor, quantidade = @quantidade, datacompra = @datacompra, total = @total WHERE nrficha = @nrficha"
                End If

                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    cmd.Parameters.AddWithValue("@produtos", produtos)
                    cmd.Parameters.AddWithValue("@valor", valor)
                    cmd.Parameters.AddWithValue("@quantidade", quantidade)
                    cmd.Parameters.AddWithValue("@datacompra", datacompra)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@Codigo", nrcaderneta)
                    cmd.ExecuteNonQuery()
                End Using

                sql = "SELECT SUM(total) AS total FROM tbCaderneta WHERE nrcaderneta = @nrcaderneta"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrcaderneta", nrcaderneta)
                    Dim Somatotal As Object = cmd.ExecuteScalar()
                    Dim TotalFinal As Decimal = If(Somatotal IsNot Nothing, FormatCurrency(total.ToString()), "0")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
    End Sub
    Public Sub Cancelar(nrficha As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbDthCaderneta WHERE nrficha = @nrficha"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()

            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
    End Sub
    Public Function GerarCodCaderneta()
        Dim codigo As String

        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT codigo+1 AS Codigo FROM tbClientes ORDER BY codigo DESC"
                Using command As New SqlCommand(sql, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbCaderneta)
                        If tbCaderneta.Rows.Count > 0 Then
                            ' Obter o código do último cliente
                            codigo = tbCaderneta.Rows(0)("codigo").ToString()
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o código da caderneta: " & ex.Message)
        End Try
        Return codigo
    End Function
    Public Sub SalvarCaderneta(nrficha As Integer, cliente As String, datacompra As Date, dependente As String, datavencimento As Date, totalfinal As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbCaderneta (nrficha, cliente, datacompra, dependente, datavencimento, total_final) VALUES (@nrficha, @cliente, @datacompra, @dependente, @datavencimento, @total_final)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    cmd.Parameters.AddWithValue("@cliente", cliente)
                    cmd.Parameters.AddWithValue("@datacompra", datacompra)
                    cmd.Parameters.AddWithValue("@dependente", dependente)
                    cmd.Parameters.AddWithValue("@datavencimento", datavencimento)
                    cmd.Parameters.AddWithValue("@total_final", totalfinal)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
    End Sub
    Public Sub AtualizarCaderneta(Codigo As Integer, nrficha As Integer, cliente As String, datacompra As Date, dependente As String, datavencimento As Date, totalfinal As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbCaderneta SET cliente = @cliente, datacompra = @datacompra, dependente = @dependente, datavencimento = @datavencimento, total_final = @total_final WHERE codigo = @codigo"

                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    cmd.Parameters.AddWithValue("@cliente", cliente)
                    cmd.Parameters.AddWithValue("@datacompra", datacompra)
                    cmd.Parameters.AddWithValue("@dependente", dependente)
                    cmd.Parameters.AddWithValue("@datavencimento", datavencimento)
                    cmd.Parameters.AddWithValue("@total_final", totalfinal)
                    cmd.Parameters.AddWithValue("@codigo", Codigo)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
    End Sub
    Public Function ConsultaNumeroCaderneta(nrficha As Integer)
        Dim DataVencimento As String
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbCaderneta WHERE nrficha = @nrficha"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(tbCaderneta)
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try

        If tbCaderneta.Rows.Count = 0 Then
            DataVencimento = Date.Now.Date.AddDays(30).ToString()
        Else
            DataVencimento = tbCaderneta.Rows(0)("datavencimento").ToString()
        End If
        Return DataVencimento
    End Function
    Public Sub PagarCaderneta(nrficha As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "update tbCaderneta set pago = 'True' where nrficha  = @nrficha"

                Using cmd As New SqlCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
