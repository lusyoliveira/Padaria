<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstoque
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpEstoque = New System.Windows.Forms.GroupBox()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.cboFornecedores = New System.Windows.Forms.ComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.txtDataentrada = New System.Windows.Forms.TextBox()
        Me.lblDataentrada = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lstEstoque = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.produtos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dataentrada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fornecedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpEstoque.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEstoque
        '
        Me.grpEstoque.Controls.Add(Me.cboProduto)
        Me.grpEstoque.Controls.Add(Me.Label7)
        Me.grpEstoque.Controls.Add(Me.lblCodigo)
        Me.grpEstoque.Controls.Add(Me.btnExcluir)
        Me.grpEstoque.Controls.Add(Me.btnSaida)
        Me.grpEstoque.Controls.Add(Me.cboFornecedores)
        Me.grpEstoque.Controls.Add(Me.lblFornecedor)
        Me.grpEstoque.Controls.Add(Me.btnEntrada)
        Me.grpEstoque.Controls.Add(Me.txtDataentrada)
        Me.grpEstoque.Controls.Add(Me.lblDataentrada)
        Me.grpEstoque.Controls.Add(Me.txtValor)
        Me.grpEstoque.Controls.Add(Me.lblValor)
        Me.grpEstoque.Controls.Add(Me.lstEstoque)
        Me.grpEstoque.Controls.Add(Me.txtQuantidade)
        Me.grpEstoque.Controls.Add(Me.Label4)
        Me.grpEstoque.Controls.Add(Me.cboTipo)
        Me.grpEstoque.Controls.Add(Me.lblTipo)
        Me.grpEstoque.Controls.Add(Me.Label1)
        Me.grpEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEstoque.Location = New System.Drawing.Point(16, 100)
        Me.grpEstoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEstoque.Size = New System.Drawing.Size(737, 447)
        Me.grpEstoque.TabIndex = 12
        Me.grpEstoque.TabStop = False
        Me.grpEstoque.Tag = "0"
        Me.grpEstoque.Text = "Estoque"
        '
        'cboProduto
        '
        Me.cboProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(88, 57)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(299, 26)
        Me.cboProduto.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "C�digo"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(27, 57)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 26)
        Me.lblCodigo.TabIndex = 62
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Location = New System.Drawing.Point(395, 354)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Entrar no Estoque")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSaida
        '
        Me.btnSaida.BackgroundImage = Global.Padaria.My.Resources.Resources.folder_open
        Me.btnSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaida.Location = New System.Drawing.Point(316, 354)
        Me.btnSaida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(71, 68)
        Me.btnSaida.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnSaida, "Entrar no Estoque")
        Me.btnSaida.UseVisualStyleBackColor = True
        '
        'cboFornecedores
        '
        Me.cboFornecedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboFornecedores.FormattingEnabled = True
        Me.cboFornecedores.Location = New System.Drawing.Point(277, 122)
        Me.cboFornecedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFornecedores.Name = "cboFornecedores"
        Me.cboFornecedores.Size = New System.Drawing.Size(432, 26)
        Me.cboFornecedores.TabIndex = 14
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.Location = New System.Drawing.Point(275, 98)
        Me.lblFornecedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(94, 20)
        Me.lblFornecedor.TabIndex = 13
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'btnEntrada
        '
        Me.btnEntrada.BackgroundImage = Global.Padaria.My.Resources.Resources.add
        Me.btnEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEntrada.Location = New System.Drawing.Point(231, 354)
        Me.btnEntrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(71, 68)
        Me.btnEntrada.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnEntrada, "Entrar no Estoque")
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'txtDataentrada
        '
        Me.txtDataentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataentrada.Location = New System.Drawing.Point(133, 121)
        Me.txtDataentrada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataentrada.Name = "txtDataentrada"
        Me.txtDataentrada.Size = New System.Drawing.Size(136, 26)
        Me.txtDataentrada.TabIndex = 4
        '
        'lblDataentrada
        '
        Me.lblDataentrada.AutoSize = True
        Me.lblDataentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataentrada.Location = New System.Drawing.Point(131, 97)
        Me.lblDataentrada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataentrada.Name = "lblDataentrada"
        Me.lblDataentrada.Size = New System.Drawing.Size(131, 20)
        Me.lblDataentrada.TabIndex = 10
        Me.lblDataentrada.Text = "Data da Entrada"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(27, 121)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 26)
        Me.txtValor.TabIndex = 3
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(23, 97)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(48, 20)
        Me.lblValor.TabIndex = 9
        Me.lblValor.Text = "Valor"
        '
        'lstEstoque
        '
        Me.lstEstoque.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.produtos, Me.quantidade, Me.tip, Me.dataentrada, Me.valor, Me.Fornecedor})
        Me.lstEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEstoque.FullRowSelect = True
        Me.lstEstoque.HideSelection = False
        Me.lstEstoque.Location = New System.Drawing.Point(27, 155)
        Me.lstEstoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstEstoque.MultiSelect = False
        Me.lstEstoque.Name = "lstEstoque"
        Me.lstEstoque.Size = New System.Drawing.Size(683, 191)
        Me.lstEstoque.TabIndex = 11
        Me.lstEstoque.UseCompatibleStateImageBehavior = False
        Me.lstEstoque.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "C�digo"
        '
        'produtos
        '
        Me.produtos.Text = "Produtos"
        Me.produtos.Width = 150
        '
        'quantidade
        '
        Me.quantidade.Text = "Quantidade"
        Me.quantidade.Width = 70
        '
        'tip
        '
        Me.tip.Text = "Tipo"
        Me.tip.Width = 70
        '
        'dataentrada
        '
        Me.dataentrada.Text = "Data da Entrada"
        Me.dataentrada.Width = 100
        '
        'valor
        '
        Me.valor.Text = "Valor"
        Me.valor.Width = 80
        '
        'Fornecedor
        '
        Me.Fornecedor.Text = "Fornecedor"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(395, 55)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(99, 26)
        Me.txtQuantidade.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantidade"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"CD", "DVD", "Jogos"})
        Me.cboTipo.Location = New System.Drawing.Point(501, 57)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(208, 26)
        Me.cboTipo.TabIndex = 2
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(499, 34)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(37, 18)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Produtos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 92)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 38)
        Me.Panel2.TabIndex = 39
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 564)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpEstoque)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Estoque"
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEstoque As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstEstoque As System.Windows.Forms.ListView
    Friend WithEvents produtos As System.Windows.Forms.ColumnHeader
    Friend WithEvents quantidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents tip As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents dataentrada As System.Windows.Forms.ColumnHeader
    Friend WithEvents valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtDataentrada As System.Windows.Forms.TextBox
    Friend WithEvents lblDataentrada As System.Windows.Forms.Label
    Friend WithEvents btnEntrada As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboFornecedores As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSaida As System.Windows.Forms.Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Fornecedor As ColumnHeader
    Friend WithEvents cboProduto As ComboBox
End Class
