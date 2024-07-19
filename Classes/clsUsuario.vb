Imports System.Data.SqlClient
Imports System.Text
Public Class clsUsuario
    Dim ClasseConexao As New clsConexao, tbUsuarios, tbPermissao As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "FUNÇÕES"
    Public Function ConsultaUsuario(lstGrade As ListView, Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbUsuarios WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Nome) Then
                    sql.AppendLine("AND Nome LIKE @Nome")
                End If

                sql.AppendLine("ORDER BY Nome")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Nome) Then
                        command.Parameters.AddWithValue("@Nome", "%" & Nome & "%")
                    End If
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim x As Integer = 0

                        While reader.Read()
                            lstGrade.Items.Add(reader("Codigo").ToString())
                            lstGrade.Items(x).SubItems.Add(reader("nome").ToString())
                            lstGrade.Items(x).SubItems.Add(reader("permissao").ToString())
                            lstGrade.Items(x).SubItems.Add(reader("Funcionario").ToString())

                            If x Mod 2 = 0 Then
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.LightGray
                            Else
                                lstGrade.Items(x).ForeColor = Color.Black
                                lstGrade.Items(x).BackColor = Color.White
                            End If

                            x += 1
                        End While
                    End Using
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o usuário: " & ex.Message)
        End Try
        Return tbUsuarios
    End Function
    Public Function CtrlMenuSubmenu(ByVal menu As System.Windows.Forms.ToolStripMenuItem, ByVal permissao As String, Optional ByVal esconder As Boolean = False) As Boolean
        Dim z As Integer

        For z = 0 To menu.DropDownItems.Count - 1
            If menu.DropDownItems(z).Text <> "" Then
                Dim sql As String = "SELECT ativo FROM tbpermissoes WHERE permissao = @permissao AND menu = @menu"

                Using connection As New SqlConnection(ClasseConexao.connectionString)
                    connection.Open()
                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@permissao", permissao)
                        command.Parameters.AddWithValue("@menu", menu.DropDownItems(z).Text)

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                reader.Read()
                                Dim ativo As Boolean = reader.GetBoolean(reader.GetOrdinal("ativo"))

                                If ativo Then
                                    If Not esconder Then
                                        menu.DropDownItems(z).Enabled = True
                                    Else
                                        menu.DropDownItems(z).Visible = True
                                    End If
                                Else
                                    If Not esconder Then
                                        menu.DropDownItems(z).Enabled = False
                                    Else
                                        menu.DropDownItems(z).Visible = False
                                    End If
                                End If
                            Else
                                If Not esconder Then
                                    menu.DropDownItems(z).Enabled = True
                                Else
                                    menu.DropDownItems(z).Visible = True
                                End If
                            End If
                        End Using
                    End Using
                    connection.Close()
                End Using
                ' Recursivamente chama a função para os submenus
                CtrlMenuSubmenu(menu.DropDownItems(z), permissao, esconder)
            End If
        Next

        Return True
    End Function
    Public Function CtrlMenu(ByVal permissao As String, Optional ByVal esconder As Boolean = False) As Boolean
        Try
            For Each item As ToolStripItem In frmPrincipal.MenuStrip1.Items
                If TypeOf item Is ToolStripMenuItem Then
                    Dim menu As ToolStripMenuItem = DirectCast(item, ToolStripMenuItem)
                    Using connection As New SqlConnection(ClasseConexao.connectionString)
                        connection.Open()
                        Dim sql As String = $"Select * from tbpermissoes where permissao = '{permissao}' and menu = '{menu.Text}'"
                        Using command As New SqlCommand(sql, connection)
                            Using adapter As New SqlDataAdapter(command)
                                adapter.Fill(tbPermissao)
                            End Using
                            If tbPermissao.Rows.Count > 0 Then
                                If Convert.ToBoolean(tbPermissao.Rows(0)("ativo")) Then
                                    If Not esconder Then
                                        menu.Enabled = True
                                    Else
                                        menu.Visible = True
                                    End If
                                Else
                                    If Not esconder Then
                                        menu.Enabled = False
                                    Else
                                        menu.Visible = False
                                    End If
                                End If
                            Else
                                If Not esconder Then
                                    menu.Enabled = True
                                Else
                                    menu.Visible = True
                                End If
                            End If
                        End Using
                        connection.Close()
                    End Using
                    CtrlMenuSubmenu(menu, permissao, esconder)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar permissão: " & ex.Message)
        End Try

        Return True
    End Function
    Public Function VerificaAdministrador(Nome As String) As Boolean
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "Select * from vwUsuariosAdministradores where nome = @Nome"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Nome", Nome)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbUsuarios)
                        If tbUsuarios.Rows.Count > 0 Then
                            Return True
                        Else
                            Return False
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o Administrador: " & ex.Message)
        End Try
    End Function
#End Region
#Region "METODOS"
    Public Sub SalvarUsuario(Nome As String, Permissao As String, Senha As String, Funcionario As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbUsuarios (Nome, Permissao, Senha, funcionario) VALUES (@Nome, @Permissao, @Senha, @funcionario)"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Nome", Nome)
                    command.Parameters.AddWithValue("@Permissao", Permissao)
                    command.Parameters.AddWithValue("@Senha", Senha)
                    command.Parameters.AddWithValue("@funcionario", Funcionario)
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar usuário: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarUsuario(codigo As Integer, Nome As String, Permissao As String, Senha As String, Funcionario As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbUsuarios SET Nome = @Nome, Permissao = @Permissao, Senha = @Senha, Funcionario = @Funcionario WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    command.Parameters.AddWithValue("@Nome", Nome)
                    command.Parameters.AddWithValue("@Permissao", Permissao)
                    command.Parameters.AddWithValue("@Senha", Senha)
                    command.Parameters.AddWithValue("@funcionario", Funcionario)
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o usuário: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirUsuario(codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbUsuarios WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", codigo)
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o usuário: " & ex.Message)
        End Try
    End Sub
    Public Sub Autenticar(Login As String, Senha As String)
        Dim Tentativas As Integer = 3, esconde As Boolean

        Using connection As New SqlConnection(ClasseConexao.connectionString)
            Dim sql As String = "SELECT * FROM tbusuarios ORDER BY nome"
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Login", Login)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbUsuarios)
                    If tbUsuarios.Rows.Count = 0 Then
                        MessageBox.Show("Usuário não existe!!", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf mcripto(Senha).ToUpper = tbUsuarios.Rows(0)("senha").ToString().ToUpper() Then
                        Tentativas = Tentativas - 1
                        CtrlMenu(tbUsuarios.Rows(0)("permissao").ToString(), esconde)
                        MessageBox.Show("Seja Bem-Vindo a Loctech Sistema!", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmPrincipal.StatusStrip1.Items(7).Text = tbUsuarios.Rows(0)("funcionario").ToString()
                        frmPrincipal.Show()
                    Else
                        Tentativas = Tentativas - 1
                        MessageBox.Show("A senha não confere!.Por favor, tente novamente." & vbCrLf & vbCrLf & "Restam: " & Tentativas & vbTab & "tentativas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ' Me.StatusStrip1.Items(1).Text = Tentativas
                        Beep()
                    End If
                End Using
            End Using
            connection.Close()
        End Using
    End Sub

    Public Sub SalvarPermissao(Permissao As String, lstBox As CheckedListBox, Ativo As Boolean)

        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                For x = 0 To lstBox.Items.Count - 1
                    Dim sql As String = "SELECT COUNT(*) FROM tbpermissoes WHERE permissao = @permissao AND menu = @menu"
                    Using commandCheck As New SqlCommand(sql, connection)
                        commandCheck.Parameters.AddWithValue("@permissao", Permissao)
                        commandCheck.Parameters.AddWithValue("@menu", lstBox.Items(x).ToString())

                        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                        If count = 0 Then
                            sql = "INSERT INTO tbpermissoes (permissao, menu, ativo) VALUES (@permissao, @menu, @ativo)"
                        Else
                            sql = "UPDATE tbpermissoes SET ativo = @ativo WHERE permissao = @permissao AND menu = @menu"
                        End If

                        Using commandExecute As New SqlCommand(sql, connection)
                            commandExecute.Parameters.AddWithValue("@permissao", Permissao)
                            commandExecute.Parameters.AddWithValue("@menu", lstBox.Items(x).ToString())
                            commandExecute.Parameters.AddWithValue("@ativo", Ativo)
                            commandExecute.ExecuteNonQuery()
                            lstBox.SetSelected(x, False)
                        End Using
                    End Using
                Next
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar permimssão: " & ex.Message)
        End Try
    End Sub
    Public Sub ConsultaPermissoes(Permissao As String, lstBox As CheckedListBox)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()

                Dim sql As String = "SELECT * FROM tbpermissoes WHERE permissao = @permissao"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@permissao", Permissao)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim menuNome As String = reader("menu").ToString()
                            Dim ativo As Boolean = Convert.ToBoolean(reader("ativo"))
                            ' Iterar sobre os itens do CheckedListBox
                            For x = 0 To lstBox.Items.Count - 1
                                Dim itemText As String = lstBox.Items(x).ToString()
                                If menuNome.ToUpper() = itemText.ToUpper() And ativo = True Then
                                    ' Marcar o item
                                    lstBox.SetItemChecked(x, True)
                                    Exit For
                                End If
                            Next
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar permissões: " & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirPermissao(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbPermissoes WHERE nrseq = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir permissões: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
