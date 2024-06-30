<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.lblProduto = New System.Windows.Forms.Label
        Me.grpProdutos = New System.Windows.Forms.GroupBox
        Me.lblMansagem = New System.Windows.Forms.Label
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.lblQuantidade = New System.Windows.Forms.Label
        Me.txtValidade = New System.Windows.Forms.TextBox
        Me.lblValidade = New System.Windows.Forms.Label
        Me.txtValorUnit = New System.Windows.Forms.TextBox
        Me.lblValorUnit = New System.Windows.Forms.Label
        Me.txtProduto = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lstProduto = New System.Windows.Forms.ListView
        Me.codprod = New System.Windows.Forms.ColumnHeader
        Me.Produto = New System.Windows.Forms.ColumnHeader
        Me.Valor = New System.Windows.Forms.ColumnHeader
        Me.Validade = New System.Windows.Forms.ColumnHeader
        Me.Quantidade = New System.Windows.Forms.ColumnHeader
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grpProdutos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(235, 31)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(55, 16)
        Me.lblProduto.TabIndex = 11
        Me.lblProduto.Text = "Produto"
        '
        'grpProdutos
        '
        Me.grpProdutos.Controls.Add(Me.lblMansagem)
        Me.grpProdutos.Controls.Add(Me.txtQuantidade)
        Me.grpProdutos.Controls.Add(Me.lblQuantidade)
        Me.grpProdutos.Controls.Add(Me.txtValidade)
        Me.grpProdutos.Controls.Add(Me.lblValidade)
        Me.grpProdutos.Controls.Add(Me.txtValorUnit)
        Me.grpProdutos.Controls.Add(Me.lblValorUnit)
        Me.grpProdutos.Controls.Add(Me.txtProduto)
        Me.grpProdutos.Controls.Add(Me.txtCodigo)
        Me.grpProdutos.Controls.Add(Me.lblCodigo)
        Me.grpProdutos.Controls.Add(Me.lstProduto)
        Me.grpProdutos.Controls.Add(Me.btnExcluir)
        Me.grpProdutos.Controls.Add(Me.btnSalvar)
        Me.grpProdutos.Controls.Add(Me.btnAlterar)
        Me.grpProdutos.Controls.Add(Me.lblProduto)
        Me.grpProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProdutos.Location = New System.Drawing.Point(12, 81)
        Me.grpProdutos.Name = "grpProdutos"
        Me.grpProdutos.Size = New System.Drawing.Size(611, 548)
        Me.grpProdutos.TabIndex = 10
        Me.grpProdutos.TabStop = False
        Me.grpProdutos.Tag = "0"
        Me.grpProdutos.Text = "Produtos"
        '
        'lblMansagem
        '
        Me.lblMansagem.AutoSize = True
        Me.lblMansagem.Location = New System.Drawing.Point(31, 489)
        Me.lblMansagem.Name = "lblMansagem"
        Me.lblMansagem.Size = New System.Drawing.Size(57, 20)
        Me.lblMansagem.TabIndex = 0
        Me.lblMansagem.Text = "Label1"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(262, 120)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(75, 26)
        Me.txtQuantidade.TabIndex = 51
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(259, 92)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(78, 16)
        Me.lblQuantidade.TabIndex = 50
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtValidade
        '
        Me.txtValidade.Location = New System.Drawing.Point(129, 120)
        Me.txtValidade.Name = "txtValidade"
        Me.txtValidade.Size = New System.Drawing.Size(109, 26)
        Me.txtValidade.TabIndex = 49
        '
        'lblValidade
        '
        Me.lblValidade.AutoSize = True
        Me.lblValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidade.Location = New System.Drawing.Point(126, 92)
        Me.lblValidade.Name = "lblValidade"
        Me.lblValidade.Size = New System.Drawing.Size(63, 16)
        Me.lblValidade.TabIndex = 48
        Me.lblValidade.Text = "Validade"
        '
        'txtValorUnit
        '
        Me.txtValorUnit.Location = New System.Drawing.Point(21, 120)
        Me.txtValorUnit.Name = "txtValorUnit"
        Me.txtValorUnit.Size = New System.Drawing.Size(86, 26)
        Me.txtValorUnit.TabIndex = 47
        '
        'lblValorUnit
        '
        Me.lblValorUnit.AutoSize = True
        Me.lblValorUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUnit.Location = New System.Drawing.Point(18, 92)
        Me.lblValorUnit.Name = "lblValorUnit"
        Me.lblValorUnit.Size = New System.Drawing.Size(89, 16)
        Me.lblValorUnit.TabIndex = 46
        Me.lblValorUnit.Text = "Valor Unitário"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(238, 59)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(349, 26)
        Me.txtProduto.TabIndex = 45
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(21, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(193, 26)
        Me.txtCodigo.TabIndex = 44
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(18, 31)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 16)
        Me.lblCodigo.TabIndex = 43
        Me.lblCodigo.Text = "Código"
        '
        'lstProduto
        '
        Me.lstProduto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codprod, Me.Produto, Me.Valor, Me.Validade, Me.Quantidade})
        Me.lstProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProduto.FullRowSelect = True
        Me.lstProduto.Location = New System.Drawing.Point(21, 162)
        Me.lstProduto.MultiSelect = False
        Me.lstProduto.Name = "lstProduto"
        Me.lstProduto.Size = New System.Drawing.Size(566, 296)
        Me.lstProduto.TabIndex = 42
        Me.lstProduto.UseCompatibleStateImageBehavior = False
        Me.lstProduto.View = System.Windows.Forms.View.Details
        '
        'codprod
        '
        Me.codprod.Text = "Código do Produto"
        Me.codprod.Width = 110
        '
        'Produto
        '
        Me.Produto.Text = "Produto"
        Me.Produto.Width = 170
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.Width = 70
        '
        'Validade
        '
        Me.Validade.Text = "Validade"
        Me.Validade.Width = 100
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 80
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(345, 476)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(53, 55)
        Me.btnExcluir.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(209, 476)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 55)
        Me.btnSalvar.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(275, 476)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 55)
        Me.btnAlterar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 75)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 31)
        Me.Panel2.TabIndex = 39
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(635, 643)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpProdutos)
        Me.MaximizeBox = False
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.grpProdutos.ResumeLayout(False)
        Me.grpProdutos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents grpProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lstProduto As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtValorUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblValorUnit As System.Windows.Forms.Label
    Friend WithEvents txtProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtValidade As System.Windows.Forms.TextBox
    Friend WithEvents lblValidade As System.Windows.Forms.Label
    Friend WithEvents codprod As System.Windows.Forms.ColumnHeader
    Friend WithEvents Produto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Validade As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblMansagem As System.Windows.Forms.Label

End Class
