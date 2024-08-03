Imports System.Data.SqlClient

Public Class clsCombo
    Dim ClasseConexao As New clsConexao, tbClientes, tbProdutos As New DataTable()
#Region "PROPRIEDADES"
    Public Property Codigo As Integer
    Public Property Descricao As String
#End Region
#Region "CONSTRUTORES"
    Public Sub New()

    End Sub
#End Region
#Region "METODOS"
    Public Function PreencherComboBox(query As String, campoId As String, campoNome As String) As List(Of clsCombo)
        Dim lista = New List(Of clsCombo)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using cmd = New SqlCommand(query, cn)
                    Dim rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim item As New clsCombo With {
                        .Codigo = rdr.GetInt32(rdr.GetOrdinal(campoId)),
                        .Descricao = rdr.GetString(rdr.GetOrdinal(campoNome))
                    }
                        lista.Add(item)
                    End While
                    rdr.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível consultar os dados!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
        Return lista
    End Function
    Public Function Listar(ByVal Sql As String)
        Dim dt As New DataTable()
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Using command As New SqlCommand(Sql, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function
    Public Overrides Function ToString() As String
        Return Descricao
    End Function

    Public Sub Localizar(Tabela As String, lstGrade As ListView, Localizar As String)
        Dim sql As String = ""
        Dim x As Integer = 0

        Select Case Tabela
            Case "Clientes"
                lstGrade.Items.Clear()
                sql = "SELECT * FROM tbClientes WHERE nome LIKE '%" & Localizar & "%'"
                If IsNumeric(Localizar) Then
                    sql = "SELECT * FROM tbClientes WHERE codigo = " & Localizar
                End If
                tbClientes = Listar(sql)
                If tbClientes.Rows.Count > 0 Then
                    For Each row As DataRow In tbClientes.Rows
                        lstGrade.Items.Add(row("codigo").ToString())
                        lstGrade.Items(x).SubItems.Add(row("nome").ToString())
                        x += 1
                    Next
                End If

            Case "Produtos"
                lstGrade.Items.Clear()
                sql = "SELECT * FROM tbProdutos WHERE titulo LIKE '%" & Localizar & "%'"
                If IsNumeric(Localizar) Then
                    sql = "SELECT * FROM tbProdutos WHERE codigo = " & Localizar
                End If
                tbProdutos = Listar(sql)
                If tbProdutos.Rows.Count > 0 Then
                    For Each row As DataRow In tbProdutos.Rows
                        lstGrade.Items.Add(row("codigo").ToString())
                        lstGrade.Items(x).SubItems.Add(row("titulo").ToString())
                        x += 1
                    Next
                End If
        End Select
    End Sub
#End Region
End Class
