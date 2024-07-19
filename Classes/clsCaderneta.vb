Imports System.Data.SqlClient
Public Class clsCaderneta
    Dim ClasseConexao As New clsConexao, tbCaderneta As New DataTable()
#Region "PROPRIEDADES"
    Public Property CodCliente As Integer
#End Region
#Region "FUNÇÕES"
    Public Function ConsultaCaderneta()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New String("SELECT * FROM tbcaderneta ORDER BY codigo DESC")
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbCaderneta)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Caderneta: " & ex.Message)
        End Try
        Return tbCaderneta
    End Function
    Public Function ConsultaCadernetaPendente(lstGrade As ListView)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New String("SELECT * FROM tbcaderneta WHERE pago = 'False'")
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbCaderneta)
                    Dim x As Integer = 0
                    For Each row As DataRow In tbCaderneta.Rows
                        lstGrade.Items.Add(row("Codigo").ToString())
                        lstGrade.Items(x).SubItems.Add(row("nrficha").ToString())
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
    Public Function ConsultaVencCaderneta(nrficha As Integer)
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
#End Region
#Region "METODOS"
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
    Public Sub SalvarDetCaderneta(nrficha As Integer, nrcaderneta As Integer, CodProd As String, valor As Decimal, quantidade As Integer, total As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbProdutos_Caderneta (nrficha, CodProd, valor, quantidade, datacompra, total) VALUES (@nrficha, @CodProd, @valor, @quantidade, @total)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@nrficha", nrficha)
                    cmd.Parameters.AddWithValue("@CodProd", CodProd)
                    cmd.Parameters.AddWithValue("@valor", valor)
                    cmd.Parameters.AddWithValue("@quantidade", quantidade)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@nrcaderneta", nrcaderneta)
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

    Public Sub PagarCaderneta(nrficha As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbCaderneta SET pago = 'True' WHERE nrficha  = @nrficha"
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
#End Region
End Class
