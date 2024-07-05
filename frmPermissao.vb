Public Class frmPermissao
    Dim tbaux, tbPermissoes
    Dim sql As String
    Dim x As Integer
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        If cboPermissao.Text = "" Then
            MsgBox("Selecione a permissão para gravar.", MsgBoxStyle.Information)
            cboPermissao.Focus()
            Exit Sub
        End If
        For x = 0 To lstMenus.Items.Count - 1
            sql = "Select * from tbpermissoes where permissao = '" & cboPermissao.Text & "' and menu ='" & lstMenus.Items(x).ToString & "'"
            tbaux = RecebeTabela(sql)
            If tbaux.RecordCount = 0 Then
                sql = "Insert into tbpermissoes (permissao,menu,ativo) values ('" & cboPermissao.Text & "','" & lstMenus.Items(x).ToString & "','" & IIf(lstMenus.GetItemChecked(x) = True, "1", "0") & "')"
            Else
                sql = "update tbpermissoes set ativo= '" & IIf(lstMenus.GetItemChecked(x) = True, "1", "0") & "' where permissao = '" & cboPermissao.Text & "' and menu ='" & lstMenus.Items(x).ToString & "'"
            End If
            tbaux = RecebeTabela(sql)
            lstMenus.SetItemChecked(x, False)
        Next
        limpar()

    End Sub

    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        With cboPermissao
            .Items.Clear()
            tbaux = RecebeTabela("Select distinct permissao from tbpermissoes order by permissao")
            If tbaux.RecordCount <> 0 Then
                tbaux.MoveFirst()
                While tbaux.EOF = False
                    .Items.Add(tbaux.Fields("permissao").Value.ToString)
                    tbaux.MoveNext()
                End While
            End If

        End With
    End Sub

    Private Sub limpar()
        cboPermissao.Text = ""
        lstMenus.Items.Clear()
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
        lstMenus.Focus()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cboPermissao.Text = "" Then
            MsgBox("Selecione a permissão para gravar.", MsgBoxStyle.Information)
            cboPermissao.Focus()
            Exit Sub
        End If
        sql = "Select * from tbpermissoes where permissao = '" & cboPermissao.Text & "'"
        tbaux = RecebeTabela(sql)
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                For x = 0 To lstMenus.Items.Count - 1
                    If tbaux.Fields("menu").Value.ToString.ToUpper = lstMenus.Items(x).ToString.ToUpper Then
                        lstMenus.SetItemChecked(x, IIf(tbaux.Fields("ativo").Value = True, True, False))
                    End If

                Next
                tbaux.MoveNext()
            End While
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        tbPermissoes = RecebeTabela("select * from tbPermissoes where codigo = " & grpPermissoes.Tag)
        If tbPermissoes.RecordCount = 0 Then Exit Sub
        tbPermissoes.Delete()
        cboPermissao.Focus()
    End Sub
End Class