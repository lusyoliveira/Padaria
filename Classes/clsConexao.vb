Imports System.Data.SqlClient
Imports System.ServiceProcess

Public Class clsConexao

    Private sqlServer = GetNomeSQLServer()  ' Substitua pelo nome do seu servidor
    Private sqlDatabase = "dbPadaria"  ' Substitua pelo nome do seu banco de dados
    Private sqlUser = "sa"  ' Substitua pelo seu usuário
    Private sqlPassword = "123456"  ' Substitua pela sua senha
    Public connectionString As String = $"Server={sqlServer};Database={sqlDatabase};User Id={sqlUser};Password={sqlPassword};"

    ''' <summary>
    ''' Esta função obtem o nome do servidor SQL Server.
    ''' </summary>
    ''' <returns>Retorna o nome do servidor.</returns>
    Public Function GetNomeSQLServer() As String
        'Nome do PC local
        Dim strPCname As String = Environment.MachineName
        ' nome do serviço do SQL Server Express
        Dim strInstancia As String = "MSSQL$SQLEXPRESS"
        Dim strNomeSQLServer As String = String.Empty

        ' Inclua uma referência a : System.ServiceProcess;
        Dim servicos As ServiceController() = ServiceController.GetServices()
        ' percorre os serviços 
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

End Class
