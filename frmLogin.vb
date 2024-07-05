Public Class frmLogin
    Dim Tentativas As String
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tbaux As DataTable

        Tentativas = 3
        Me.StatusStrip1.Items(1).Text = Tentativas
        grpLogin.Tag = 0
        tbaux = RecebeTabela("Select * from tbusuarios order by nome")
        If tbaux.Rows.Count <> 0 Then
            For Each row As DataRow In tbaux.Rows
                txtUsuario.AutoCompleteCustomSource.Add(row("nome").ToString())
            Next
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim esconde As Boolean
        Dim tbaux, tbLogin, tbUsuarios As DataTable

        tbaux = RecebeTabela("Select * from tbusuarios where nome = '" & txtUsuario.Text & "'")
        If tbaux.Rows.Count = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            txtSenha.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()
            Exit Sub
        End If

        Me.StatusStrip1.Items(1).Text = Tentativas

        Select Case Tentativas
            Case Is <> 0
                If mcripto(txtSenha.Text).ToUpper = tbaux.Rows(0)("senha").ToString().ToUpper Then
                    Tentativas = Tentativas - 1
                    CtrlMenu(tbaux.Rows(0)("permissao").ToString(), esconde)
                    tbLogin = RecebeTabela("select * from tbLogin where codigo = " & grpLogin.Tag)
                    If grpLogin.Tag = 0 Then
                        ' Lógica para adicionar novo registro no DataTable ou tratar conforme necessário
                    End If
                    ' Atualização do registro no DataTable ou tratamento conforme necessário
                    frmPrincipal.Show()
                    tbUsuarios = RecebeTabela("select * from tbUsuarios where nome = '" & txtUsuario.Text & "'")
                    If tbUsuarios.Rows.Count > 0 Then
                        frmPrincipal.StatusStrip1.Items(7).Text = tbUsuarios.Rows(0)("funcionario").ToString()
                    End If
                Else
                    Tentativas = Tentativas - 1
                    MsgBox("A senha não confere!." & vbCrLf & "Por favor, tente novamente." & vbCrLf & vbCrLf & "Restam: " & Tentativas & vbTab & "tentativas.", MsgBoxStyle.Critical)
                    tbLogin = RecebeTabela("select * from tbLogin where codigo = " & grpLogin.Tag)
                    If grpLogin.Tag = 0 Then
                        ' Lógica para adicionar novo registro no DataTable ou tratar conforme necessário
                    End If
                    ' Atualização do registro no DataTable ou tratamento conforme necessário
                    Me.StatusStrip1.Items(1).Text = Tentativas
                    txtSenha.Text = ""
                    txtSenha.Focus()
                End If
            Case Is <= 0
                Tentativas = Tentativas - 1
                MsgBox("Suas tentativas expiraram!" & vbCrLf & "O aplicativo será fechado!", MsgBoxStyle.Critical)
                Me.Close()
        End Select
    End Sub

End Class