Imports System.Configuration
Imports System.Data.SqlClient
Imports System.ServiceProcess
Module mdlConexao
    Public aConexao As New SqlConnection()
    Dim sqlServer, sqlDatabase, sqlUser, sqlPassword As String
    ''' <summary>
    ''' Esta fun��o obtem o nome do servidor SQL Server.
    ''' </summary>
    ''' <returns>Retorna o nome do servidor.</returns>

    Public Function GetNomeSQLServer() As String
        'Nome do PC local
        Dim strPCname As String = Environment.MachineName
        ' nome do servi�o do SQL Server Express
        Dim strInstancia As String = "MSSQL$SQLEXPRESS"
        Dim strNomeSQLServer As String = String.Empty

        ' Inclua uma refer�ncia a : System.ServiceProcess;
        Dim servicos As ServiceController() = ServiceController.GetServices()
        ' percorre os servi�os 
        For Each servico As ServiceController In servicos
            If servico Is Nothing Then
                Continue For
            End If
            Dim strNomeDoServico As String = servico.ServiceName
            If strNomeDoServico.Contains(strInstancia) Then
                strNomeSQLServer = strNomeDoServico
            End If
        Next
        Dim IndiceInicio As Integer = strNomeSQLServer.IndexOf("$")
        If IndiceInicio > -1 Then
            'strSqlServerName=NomeDoSeuPC\SQLEXPRESS;
            strNomeSQLServer = strPCname + "\" + strNomeSQLServer.Substring(IndiceInicio + 1)
        End If
        Return strNomeSQLServer
    End Function
    Public Function RecebeTabela(ByVal sql As String) As DataTable
        Dim dtResultado As New DataTable()

        ' Configura��es da conex�o
        sqlServer = GetNomeSQLServer()  ' Substitua pelo nome do seu servidor
        sqlDatabase = "dbPadaria"  ' Substitua pelo nome do seu banco de dados
        sqlUser = "sa"  ' Substitua pelo seu usu�rio
        sqlPassword = "123456"  ' Substitua pela sua senha

        If sql.ToUpper() = "FECHAR" Then
            If aConexao.State <> ConnectionState.Closed Then
                aConexao.Close()
            End If
            Return Nothing
        End If

        ' Verifica se a conex�o est� fechada e abre se necess�rio
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