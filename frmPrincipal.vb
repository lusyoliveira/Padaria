Public Class frmPrincipal

    Private Sub PermissõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissõesToolStripMenuItem.Click
        frmPermissao.Show()
    End Sub

    Private Sub CriarUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriarUsuárioToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        frmConfig.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        frmFuncionarios.Show()
    End Sub

    Private Sub LocaçãoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVendas.Show()
    End Sub
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = 0
        Me.StatusStrip1.Items(1).Text = Format(Date.Now.Date, "long date")
        Me.StatusStrip1.Items(3).Text = GetUserName
        Me.StatusStrip1.Items(5).Text = GetComputerName

        ' Obter a Versão da Aplicação
#If CONFIG = "Release" Then
            lblVersao .Text = String.Format("Versão: " & My.Application.Deployment.CurrentVersion.ToString)
#Else
            Dim strMajorVersion, strMinorVersion, strRevisionVersion As String

            strMajorVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major()
            strMinorVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor()
            strRevisionVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision()

        lblVersao.Text = String.Format("VERSÃO: " & strMajorVersion & "." & strMinorVersion & " REVISÃO: " & strRevisionVersion)

#End If

    End Sub
    Private Sub FazerLogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FazerLogoffToolStripMenuItem.Click
        If (MsgBox("Deseja realmente sair do sistema ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub RegistroDeLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbLogin As ADODB.Recordset, sql As String

        sql = "Select * from tbLogin where usuario <> '' order by usuario"
        tbLogin = RecebeTabela(sql)
        If tbLogin.RecordCount = 0 Then
            MsgBox("Não existem usuário !")
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueToolStripMenuItem.Click
        frmEstoque.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        frmFornecedores.Show()
    End Sub

    Private Sub FilmesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilmesToolStripMenuItem1.Click
        frmProdutos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarToolStripMenuItem.Click
        frmLocalizar.Show()
    End Sub

    Private Sub CadernetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadernetaToolStripMenuItem.Click
        frmCaderneta.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem1.Click
        frmRelatorios.Show()
    End Sub

    Private Sub PagamentosPendentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagamentosPendentesToolStripMenuItem.Click
        frmPagoPendente.Show()
    End Sub

    Private Sub AbrirCaixaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCaixaToolStripMenuItem1.Click
        frmAbrirCaixa.Show()
    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        frmFechaCaixa.Show()
    End Sub

    Private Sub RetirarDoCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetirarDoCaixaToolStripMenuItem.Click
        RetiraCaixa.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        frmSobre.Show()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaToolStripMenuItem.Click
        frmFaturamento.Show()
    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim tbCaixa As ADODB.Recordset

        tbCaixa = RecebeTabela("select valorfecha from tbCaixa")
        If tbCaixa.EOF = True And tbCaixa.BOF = True Then
            MsgBox("Você precisa fechar o caixa!", MsgBoxStyle.Critical)
            Me.Show()
            frmFechaCaixa.Show()
        Else
            If (MsgBox("Deseja Sair do Sistema ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class