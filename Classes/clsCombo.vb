Imports System.Data.SqlClient

Public Class clsCombo
    Dim ClasseConexao As New clsConexao, tbClientes, tbProdutos As New DataTable()
#Region "PROPRIEDADES"
    Public Valor As Object
    Public Descricao As String
#End Region
#Region "CONSTRUTORES"
    Public Sub New()

    End Sub
    Public Sub New(ByVal NovoValor As Object, ByVal NovaDescricao As String)
        Valor = NovoValor
        Descricao = NovaDescricao
    End Sub
#End Region
#Region "METODOS"
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
    Public Sub CarregaCombo(ByVal ComboRec As ComboBox, ByVal Sql As String)
        ' Carrega o combobox
        Dim Lista As New ArrayList()
        Dim Tabela As DataTable

        Lista.Clear()
        ComboRec.AutoCompleteCustomSource.Clear()
        Tabela = Listar(Sql)

        If Tabela.Rows.Count <> 0 Then
            For Each row As DataRow In Tabela.Rows
                Lista.Add(New clsCombo(row(0), row(1).ToString()))
                ComboRec.AutoCompleteCustomSource.Add(row(1).ToString())
            Next
        End If

        ComboRec.DisplayMember = "Descricao"
        ComboRec.ValueMember = "Valor"
        ComboRec.DataSource = Lista
        ComboRec.Text = ""
        ComboRec.SelectedIndex = -1
    End Sub

    Public Function LerCombo(ByVal ComboRec As ComboBox) As String
        Dim Selecionado As String
        Try
            Selecionado = CType(ComboRec.SelectedItem, clsCombo).Valor.ToString
        Catch ex As Exception
            Selecionado = ""
        End Try
        Return Selecionado
    End Function

    Public Sub SelecionarCombo(ByRef ComboRec As ComboBox, ByVal Valor As String)
        Dim Selecionado As String, x As Integer
        Try
            For x = 0 To ComboRec.Items.Count - 1
                If CType(ComboRec.Items(x), clsCombo).Valor.ToString = Valor Then
                    ComboRec.SelectedIndex = x
                    Exit For
                End If
            Next
        Catch ex As Exception
            Selecionado = ""
        End Try
    End Sub
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
