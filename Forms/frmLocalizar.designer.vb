<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalizar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalizar))
        Me.grpLocalizar = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItens = New System.Windows.Forms.Label()
        Me.lstLocalizar = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dados = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtLocalizar = New System.Windows.Forms.TextBox()
        Me.cboItens = New System.Windows.Forms.ComboBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpLocalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLocalizar
        '
        Me.grpLocalizar.Controls.Add(Me.btnExcluir)
        Me.grpLocalizar.Controls.Add(Me.btnAlterar)
        Me.grpLocalizar.Controls.Add(Me.btnSalvar)
        Me.grpLocalizar.Controls.Add(Me.btnLocalizar)
        Me.grpLocalizar.Controls.Add(Me.Label1)
        Me.grpLocalizar.Controls.Add(Me.lblItens)
        Me.grpLocalizar.Controls.Add(Me.lstLocalizar)
        Me.grpLocalizar.Controls.Add(Me.txtLocalizar)
        Me.grpLocalizar.Controls.Add(Me.cboItens)
        Me.grpLocalizar.Location = New System.Drawing.Point(19, 100)
        Me.grpLocalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLocalizar.Name = "grpLocalizar"
        Me.grpLocalizar.Padding = New System.Windows.Forms.Padding(4)
        Me.grpLocalizar.Size = New System.Drawing.Size(564, 335)
        Me.grpLocalizar.TabIndex = 11
        Me.grpLocalizar.TabStop = False
        Me.grpLocalizar.Text = "Localizar"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Location = New System.Drawing.Point(381, 247)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterar.Location = New System.Drawing.Point(279, 247)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Location = New System.Drawing.Point(190, 247)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Adicionar Registro não Encontrado")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLocalizar.Location = New System.Drawing.Point(93, 247)
        Me.btnLocalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(71, 68)
        Me.btnLocalizar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnLocalizar, "Localizar")
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Digite um  número ou nome:"
        '
        'lblItens
        '
        Me.lblItens.AutoSize = True
        Me.lblItens.Location = New System.Drawing.Point(28, 27)
        Me.lblItens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(61, 16)
        Me.lblItens.TabIndex = 8
        Me.lblItens.Text = "Tabelas:"
        '
        'lstLocalizar
        '
        Me.lstLocalizar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome, Me.dados})
        Me.lstLocalizar.FullRowSelect = True
        Me.lstLocalizar.HideSelection = False
        Me.lstLocalizar.Location = New System.Drawing.Point(33, 77)
        Me.lstLocalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstLocalizar.MultiSelect = False
        Me.lstLocalizar.Name = "lstLocalizar"
        Me.lstLocalizar.Size = New System.Drawing.Size(497, 144)
        Me.lstLocalizar.TabIndex = 10
        Me.lstLocalizar.UseCompatibleStateImageBehavior = False
        Me.lstLocalizar.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Código"
        '
        'nome
        '
        Me.nome.Text = "Dado Localizado"
        Me.nome.Width = 180
        '
        'dados
        '
        Me.dados.Text = "Dados Extras"
        Me.dados.Width = 100
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(235, 47)
        Me.txtLocalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(295, 22)
        Me.txtLocalizar.TabIndex = 1
        '
        'cboItens
        '
        Me.cboItens.FormattingEnabled = True
        Me.cboItens.Items.AddRange(New Object() {"Clientes", "Produtos", "Funcionários", "Fornecedores", "Estoque"})
        Me.cboItens.Location = New System.Drawing.Point(32, 47)
        Me.cboItens.Margin = New System.Windows.Forms.Padding(4)
        Me.cboItens.Name = "cboItens"
        Me.cboItens.Size = New System.Drawing.Size(195, 24)
        Me.cboItens.TabIndex = 0
        Me.cboItens.Text = "Selecione..."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 92)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 38)
        Me.Panel2.TabIndex = 39
        '
        'frmLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 449)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpLocalizar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmLocalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar..."
        Me.grpLocalizar.ResumeLayout(False)
        Me.grpLocalizar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLocalizar As System.Windows.Forms.GroupBox
    Friend WithEvents cboItens As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItens As System.Windows.Forms.Label
    Friend WithEvents lstLocalizar As System.Windows.Forms.ListView
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents dados As System.Windows.Forms.ColumnHeader
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
