Public Class frmLogin
    Dim Tentativas As String
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tbaux As ADODB.Recordset

        Tentativas = 3
        Me.StatusStrip1.Items(1).Text = Tentativas
        grpLogin.Tag = 0
        tbaux = RecebeTabela("Select * from tbusuarios order by nome")
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                txtUsuario.AutoCompleteCustomSource.Add(tbaux("nome").Value.ToString)
                tbaux.MoveNext()
            End While
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim esconde As Boolean, tbLogin, tbaux, tbUsuarios As ADODB.Recordset

        tbaux = RecebeTabela("Select * from tbusuarios where nome = '" & txtUsuario.Text & "'")
        If tbaux.RecordCount = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            txtSenha.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()
            Exit Sub
        End If
        Me.StatusStrip1.Items(1).Text = Tentativas
        Select Case Tentativas
            Case Is <> 0
                If mcripto(txtSenha.Text).ToUpper = tbaux.Fields("senha").Value.ToString.ToUpper Then
                    Tentativas = Tentativas - 1
                    CtrlMenu(tbaux.Fields("permissao").Value.ToString, esconde)
                    tbLogin = RecebeTabela("select * from tbLogin where codigo = " & grpLogin.Tag)
                    If grpLogin.Tag = 0 Then tbLogin.AddNew()
                    tbLogin("datalogin").Value = Date.Now.Date
                    tbLogin("horalogin").Value = TimeOfDay
                    tbLogin("tentativa").Value = Tentativas
                    tbLogin("usuario").Value = txtUsuario.Text
                    tbLogin.Update()
                    frmPrincipal.Show()
                    tbUsuarios = RecebeTabela("select * from tbUsuarios where nome = '" & txtUsuario.Text & "'")
                    frmPrincipal.StatusStrip1.Items(7).Text = tbUsuarios("funcionario").Value.ToString
                Else
                    Tentativas = Tentativas - 1
                    MsgBox("A senha não confere!." & vbCrLf & "Por favor, tente novamente." & vbCrLf & vbCrLf & "Restam: " & Tentativas & vbTab & "tentativas.", MsgBoxStyle.Critical)
                    tbLogin = RecebeTabela("select * from tbLogin where codigo = " & grpLogin.Tag)
                    If grpLogin.Tag = 0 Then tbLogin.AddNew()
                    tbLogin("datalogin").Value = Date.Now.Date
                    tbLogin("horalogin").Value = TimeOfDay
                    tbLogin("tentativa").Value = Tentativas
                    tbLogin("usuario").Value = txtUsuario.Text
                    tbLogin.Update()
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