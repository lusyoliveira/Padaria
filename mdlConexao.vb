Imports System.Data.SqlClient
Module mdlConexao
    Public aConexao As New SqlConnection()
    Dim sqlServer, sqlDatabase, sqlUser, sqlPassword As String

    Public Function RecebeTabela(ByVal sql As String) As DataTable
        Dim dtResultado As New DataTable()

        ' Configurações da conexão
        sqlServer = "VAR223\SQLEXPRESS"  ' Substitua pelo nome do seu servidor
        sqlDatabase = "dbPadaria"  ' Substitua pelo nome do seu banco de dados
        sqlUser = "sa"  ' Substitua pelo seu usuário
        sqlPassword = "123456"  ' Substitua pela sua senha

        If sql.ToUpper() = "FECHAR" Then
            If aConexao.State <> ConnectionState.Closed Then
                aConexao.Close()
            End If
            Return Nothing
        End If

        ' Verifica se a conexão está fechada e abre se necessário
        If aConexao.State = ConnectionState.Closed Then
            aConexao.ConnectionString = $"Server={sqlServer};Database={sqlDatabase};User Id={sqlUser};Password={sqlPassword};"
            aConexao.Open()
        End If

        ' Executa o comando SQL e preenche o DataTable
        Using cmd As New SqlCommand(sql, aConexao)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dtResultado)
            End Using
        End Using

        Return dtResultado
    End Function
End Module