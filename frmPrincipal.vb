Public Class frmPrincipal
    Dim tbLogin, tbCaixa As DataTable
    Dim sql As String
    Private Sub PermissõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissõesToolStripMenuItem.Click
        Dim frmAbrePermissao As New frmPermissao()
        frmAbrePermissao.MdiParent = Me
        frmAbrePermissao.Show()
    End Sub

    Private Sub CriarUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriarUsuárioToolStripMenuItem.Click
        Dim frmAbrefrmUsuarios As New frmUsuarios()
        frmAbrefrmUsuarios.MdiParent = Me
        frmAbrefrmUsuarios.Show()
    End Sub
    Private Sub ConfiguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim frmAbreConfigs As New frmConfig()
        frmAbreConfigs.MdiParent = Me
        frmAbreConfigs.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim frmAbreFuncionarios As New frmFuncionarios()
        frmAbreFuncionarios.MdiParent = Me
        frmAbreFuncionarios.Show()
    End Sub

    Private Sub LocaçãoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmAbreVendas As New frmVendas()
        frmAbreVendas.MdiParent = Me
        frmAbreVendas.Show()
    End Sub
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = 0
        Me.StatusStrip1.Items(1).Text = Format(Date.Now.Date, "long date")
        Me.StatusStrip1.Items(3).Text = GetUserName()
        Me.StatusStrip1.Items(5).Text = GetComputerName()

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
    Private Sub EstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueToolStripMenuItem.Click
        Dim frmAbreEstoque As New frmEstoque()
        frmAbreEstoque.MdiParent = Me
        frmAbreEstoque.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim frmAbreFornecedores As New frmFornecedores()
        frmAbreFornecedores.MdiParent = Me
        frmAbreFornecedores.Show()
    End Sub

    Private Sub FilmesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilmesToolStripMenuItem1.Click
        Dim frmAbreProdutos As New frmProdutos()
        frmAbreProdutos.MdiParent = Me
        frmAbreProdutos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frmAbreClientes As New frmClientes()
        frmAbreClientes.MdiParent = Me
        frmAbreClientes.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarToolStripMenuItem.Click
        Dim frmAbreLocalizar As New frmLocalizar()
        frmAbreLocalizar.MdiParent = Me
        frmAbreLocalizar.Show()
    End Sub

    Private Sub CadernetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadernetaToolStripMenuItem.Click
        Dim frmAbreCaderneta As New frmCaderneta()
        frmAbreCaderneta.MdiParent = Me
        frmAbreCaderneta.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatóriosToolStripMenuItem1.Click
        Dim frmAbreRelatorios As New frmRelatorios()
        frmAbreRelatorios.MdiParent = Me
        frmAbreRelatorios.Show()
    End Sub

    Private Sub PagamentosPendentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagamentosPendentesToolStripMenuItem.Click
        Dim frmAbrePagoPendente As New frmPagoPendente()
        frmAbrePagoPendente.MdiParent = Me
        frmAbrePagoPendente.Show()
    End Sub

    Private Sub AbrirCaixaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCaixaToolStripMenuItem1.Click
        Dim frmAbreCaixa As New frmAbrirCaixa()
        frmAbreCaixa.MdiParent = Me
        frmAbreCaixa.Show()
    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        Dim frmAbreFechaCaixa As New frmFechaCaixa()
        frmAbreFechaCaixa.MdiParent = Me
        frmAbreFechaCaixa.Show()
    End Sub

    Private Sub RetirarDoCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetirarDoCaixaToolStripMenuItem.Click
        Dim frmAbreRetiraCaixa As New RetiraCaixa()
        frmAbreRetiraCaixa.MdiParent = Me
        frmAbreRetiraCaixa.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Dim frmAbreSobre As New frmSobre()
        frmAbreSobre.MdiParent = Me
        frmAbreSobre.Show()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaToolStripMenuItem.Click
        Dim frmAbreFaturamento As New frmFaturamento()
        frmAbreFaturamento.MdiParent = Me
        frmAbreFaturamento.Show()
    End Sub
    Private Sub RegistroDeLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String = "Select * from tbLogin where usuario <> '' order by usuario"
        Dim tbLogin As DataTable = RecebeTabela(sql)

        If tbLogin.Rows.Count = 0 Then
            MsgBox("Não existem usuário !")
            Exit Sub
        End If

        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim tbCaixa As DataTable = RecebeTabela("select valorfecha from tbCaixa")

        If tbCaixa.Rows.Count = 0 Then
            MsgBox("Você precisa fechar o caixa!", MsgBoxStyle.Critical)
            Me.Show()
            frmFechaCaixa.Show()
        Else
            If MsgBox("Deseja Sair do Sistema ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class