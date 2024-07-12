Imports System.Data.SqlClient

Public Class clsCaixa
    Dim ClasseConexao As New clsConexao, tbCaixa, tbConfig As New DataTable()
#Region "METODOS"
    Public Sub VerificaCaixa()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New String("SELECT * FROM tbcaderneta ORDER BY codigo DESC")
                Dim MsgResult As DialogResult = MessageBox.Show("Deseja Sair do Sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbCaixa)
                    If tbCaixa.Rows.Count = 0 Then
                        MessageBox.Show("Seu caixa ainda não foi fechado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        frmFechaCaixa.Show()
                    ElseIf MsgResult = DialogResult.Yes Then
                        frmPrincipal.Close()
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o caixa: " & ex.Message)
        End Try
    End Sub
    Public Function VerificaCaixaAberto(Funcionario As String) As Integer
        If Not existecaixa() Then
            Return 0
        End If
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = $"Select nrseqcaixa from tbcaixa where funcionario = @Funcionario and not fechado order by nrseqcaixa desc"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Funcionario", Funcionario)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbCaixa)
                        If tbCaixa.Rows.Count > 0 Then
                            Return Convert.ToInt32(tbCaixa.Rows(0)("nrseqcaixa"))
                        Else
                            Return -1
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Administrador: " & ex.Message)
        End Try
    End Function
    Public Function ExisteCaixa() As Boolean
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "select * from tbconfig"
                Using command As New SqlCommand(sql, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbConfig)
                        If tbConfig.Rows.Count > 0 AndAlso Not IsDBNull(tbConfig.Rows(0)("temporario")) Then
                            Return tbConfig.Rows(0)("temporario").ToString()
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Administrador: " & ex.Message)
        End Try
    End Function
    Public Function meucaixa(nrcaixa As Integer) As Decimal
        Dim wcvalor As Decimal = 0
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "Select valorinicial from tbcaixa where nrseqcaixa = @nrcaixa"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@nrcaixa", nrcaixa)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbCaixa)
                        If tbCaixa.Rows.Count > 0 AndAlso Not IsDBNull(tbCaixa.Rows(0)("valorinicial")) Then
                            wcvalor = Convert.ToDecimal(tbCaixa.Rows(0)("valorinicial"))
                        Else
                            For Each row As DataRow In tbCaixa.Rows
                                wcvalor += Convert.ToDecimal(row("valor"))
                            Next
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Administrador: " & ex.Message)
        End Try
        Return wcvalor
    End Function
#End Region
End Class

