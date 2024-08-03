Public Class frmAbrirCaixa
    Dim ClasseCombo As New clsCombo, ClasseCaixa As New clsCaixa, Origem As String
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
    End Sub
    Public Sub New(vOrigem As String)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Origem = vOrigem
        'A = Abrir caixa
        'F = Fechar Caixa
        'R = Retirar caixa
        'C = Completar caixa
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
    End Sub
    Private Sub frmAbrirCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFuncionario.Text = frmPrincipal.ToolStripStatusLabel8.Text
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

    End Sub

    Private Sub cboFuncionario_Enter(sender As Object, e As EventArgs) Handles cboFuncionario.Enter
        ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'FU' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
    End Sub
End Class