Public Class frmDependentes
    Private Sub Limpar()
        txtNome.Text = ""
        cboParentesco.Text = ""
    End Sub
    Private Sub CarregarList()
        Dim tbDependentes As ADODB.Recordset, sql As String, x As Integer

        Limpar()
        lstDependentes.Items.Clear()
        sql = "select * from tbDependentes where codigocliente like '%" & frmClientes.txtNrficha.Text & "%'"
        tbDependentes = RecebeTabela(sql)
        If tbDependentes.RecordCount > 0 Then
            tbDependentes.MoveFirst()
            Do Until tbDependentes.EOF
                lstDependentes.Items.Add(tbDependentes("codigocliente").Value)
                lstDependentes.Items(x).SubItems.Add(tbDependentes("nome").Value)
                lstDependentes.Items(x).SubItems.Add(tbDependentes("parentesco").Value)
                If x Mod 2 = 0 Then
                    lstDependentes.Items(x).ForeColor = Color.Black
                    lstDependentes.Items(x).BackColor = Color.LightGray
                Else
                    lstDependentes.Items(x).ForeColor = Color.Black
                    lstDependentes.Items(x).BackColor = Color.White
                End If
                x += 1
                tbDependentes.MoveNext()
            Loop
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim tbDependentes As ADODB.Recordset

        tbDependentes = RecebeTabela("select * from tbDependentes where codigo = " & grpDependentes.Tag)
        If grpDependentes.Tag = 0 Then tbDependentes.AddNew()
        tbDependentes("codigocliente").Value = frmClientes.txtNrficha.Text
        tbDependentes("nome").Value = txtNome.Text
        tbDependentes("parentesco").Value = cboParentesco.Text
        tbDependentes.Update()
        CarregarList()
        txtNome.Text = ""
        txtNome.Focus()
    End Sub

    Private Sub frmDependentes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CarregarDependentes()
    End Sub
    Private Sub CarregarDependentes()
        Dim tbDependentes As ADODB.Recordset, sql As String

        lstDependentes.Items.Clear()
        sql = "select * from tbDependentes where codigocliente = " & frmClientes.txtNrficha.Text
        tbDependentes = RecebeTabela(sql)
        If tbDependentes.RecordCount > 0 Then
            tbDependentes.MoveFirst()
            Do Until tbDependentes.EOF
                lstDependentes.Items.Add(tbDependentes("nome").Value)
                tbDependentes.MoveNext()
            Loop
        End If
    End Sub

    Private Sub frmDependentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grpDependentes.Tag = 0
        CarregarList()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim tbDependentes As ADODB.Recordset

        tbDependentes = RecebeTabela("select * from tbDependentes where codigocliente = " & frmClientes.txtNrficha.Text)
        If tbDependentes.RecordCount = 0 Then Exit Sub
        tbDependentes.Delete()
        CarregarList()
        txtNome.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim tbDependentes As ADODB.Recordset, sql As String

        sql = "update tbDependentes set nome = '" & txtNome.Text & "', parentesco = '" & cboParentesco.Text & "' where codigocliente = " & frmClientes.txtNrficha.Text
        tbDependentes = RecebeTabela(sql)
        MsgBox("Registro alterardo com sucesso!", MsgBoxStyle.Information)
        CarregarList()
        txtNome.Focus()
    End Sub

    Private Sub grpDependentes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpDependentes.Enter
        txtNome.Focus()
    End Sub

    Private Sub lstDependentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lstDependentes.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        grpDependentes.Tag = Val(lstDependentes.SelectedItems(0).ToString)
        txtNome.Text = lstDependentes.SelectedItems(0).ToString
        cboParentesco.Text = lstDependentes.SelectedItems(1).ToString
    End Sub
End Class