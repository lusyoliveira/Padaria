<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaderneta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaderneta))
        Me.grpCaderneta = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumeroCaderneta = New System.Windows.Forms.Label()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.lblDataVencimento2 = New System.Windows.Forms.Label()
        Me.lblTotalFinal2 = New System.Windows.Forms.Label()
        Me.lblTotalFinal = New System.Windows.Forms.Label()
        Me.lblProdutos = New System.Windows.Forms.Label()
        Me.lblCodProd2 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lblDataCompra = New System.Windows.Forms.Label()
        Me.lblDataCompra2 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lstReservas = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Produtos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblProdutos2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpDados = New System.Windows.Forms.GroupBox()
        Me.cboDependentes = New System.Windows.Forms.ComboBox()
        Me.lblNrFicha = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.lblDependentes = New System.Windows.Forms.Label()
        Me.lblNrFicha2 = New System.Windows.Forms.Label()
        Me.lblCliente2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.grpCaderneta.SuspendLayout()
        Me.grpDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCaderneta
        '
        Me.grpCaderneta.Controls.Add(Me.Label3)
        Me.grpCaderneta.Controls.Add(Me.lblNumeroCaderneta)
        Me.grpCaderneta.Controls.Add(Me.lblDataVencimento)
        Me.grpCaderneta.Controls.Add(Me.lblDataVencimento2)
        Me.grpCaderneta.Controls.Add(Me.lblTotalFinal2)
        Me.grpCaderneta.Controls.Add(Me.lblTotalFinal)
        Me.grpCaderneta.Controls.Add(Me.lblProdutos)
        Me.grpCaderneta.Controls.Add(Me.lblCodProd2)
        Me.grpCaderneta.Controls.Add(Me.btnMostrar)
        Me.grpCaderneta.Controls.Add(Me.txtQuantidade)
        Me.grpCaderneta.Controls.Add(Me.btnCancelar)
        Me.grpCaderneta.Controls.Add(Me.lblQuantidade)
        Me.grpCaderneta.Controls.Add(Me.txtCodProd)
        Me.grpCaderneta.Controls.Add(Me.lblDataCompra)
        Me.grpCaderneta.Controls.Add(Me.lblDataCompra2)
        Me.grpCaderneta.Controls.Add(Me.btnSalvar)
        Me.grpCaderneta.Controls.Add(Me.lblTotal1)
        Me.grpCaderneta.Controls.Add(Me.lblTotal)
        Me.grpCaderneta.Controls.Add(Me.lblValor1)
        Me.grpCaderneta.Controls.Add(Me.lblValor)
        Me.grpCaderneta.Controls.Add(Me.btnImprimir)
        Me.grpCaderneta.Controls.Add(Me.lstReservas)
        Me.grpCaderneta.Controls.Add(Me.lblProdutos2)
        Me.grpCaderneta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpCaderneta.Location = New System.Drawing.Point(19, 207)
        Me.grpCaderneta.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCaderneta.Name = "grpCaderneta"
        Me.grpCaderneta.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCaderneta.Size = New System.Drawing.Size(992, 445)
        Me.grpCaderneta.TabIndex = 2
        Me.grpCaderneta.TabStop = False
        Me.grpCaderneta.Tag = "0"
        Me.grpCaderneta.Text = "Caderneta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Nº Caderneta"
        '
        'lblNumeroCaderneta
        '
        Me.lblNumeroCaderneta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumeroCaderneta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCaderneta.Location = New System.Drawing.Point(20, 52)
        Me.lblNumeroCaderneta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroCaderneta.Name = "lblNumeroCaderneta"
        Me.lblNumeroCaderneta.Size = New System.Drawing.Size(105, 28)
        Me.lblNumeroCaderneta.TabIndex = 6
        Me.lblNumeroCaderneta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDataVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataVencimento.Location = New System.Drawing.Point(269, 52)
        Me.lblDataVencimento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(157, 28)
        Me.lblDataVencimento.TabIndex = 92
        Me.lblDataVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataVencimento2
        '
        Me.lblDataVencimento2.AutoSize = True
        Me.lblDataVencimento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDataVencimento2.Location = New System.Drawing.Point(265, 27)
        Me.lblDataVencimento2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataVencimento2.Name = "lblDataVencimento2"
        Me.lblDataVencimento2.Size = New System.Drawing.Size(161, 20)
        Me.lblDataVencimento2.TabIndex = 91
        Me.lblDataVencimento2.Text = "Data da Vencimento"
        '
        'lblTotalFinal2
        '
        Me.lblTotalFinal2.AutoSize = True
        Me.lblTotalFinal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalFinal2.Location = New System.Drawing.Point(430, 27)
        Me.lblTotalFinal2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFinal2.Name = "lblTotalFinal2"
        Me.lblTotalFinal2.Size = New System.Drawing.Size(87, 20)
        Me.lblTotalFinal2.TabIndex = 88
        Me.lblTotalFinal2.Text = "Total Final"
        '
        'lblTotalFinal
        '
        Me.lblTotalFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFinal.Location = New System.Drawing.Point(434, 50)
        Me.lblTotalFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFinal.Name = "lblTotalFinal"
        Me.lblTotalFinal.Size = New System.Drawing.Size(141, 30)
        Me.lblTotalFinal.TabIndex = 87
        Me.lblTotalFinal.Text = "R$ 0,00"
        Me.lblTotalFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProdutos
        '
        Me.lblProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutos.Location = New System.Drawing.Point(101, 111)
        Me.lblProdutos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdutos.Name = "lblProdutos"
        Me.lblProdutos.Size = New System.Drawing.Size(551, 23)
        Me.lblProdutos.TabIndex = 86
        '
        'lblCodProd2
        '
        Me.lblCodProd2.AutoSize = True
        Me.lblCodProd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCodProd2.Location = New System.Drawing.Point(16, 86)
        Me.lblCodProd2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodProd2.Name = "lblCodProd2"
        Me.lblCodProd2.Size = New System.Drawing.Size(61, 20)
        Me.lblCodProd2.TabIndex = 85
        Me.lblCodProd2.Text = "Código"
        '
        'btnMostrar
        '
        Me.btnMostrar.BackgroundImage = Global.Padaria.My.Resources.Resources.folder_open
        Me.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrar.Location = New System.Drawing.Point(572, 360)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(71, 68)
        Me.btnMostrar.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.btnMostrar, "Mostrar Pagamentos Pendentes")
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(764, 112)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(104, 24)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Location = New System.Drawing.Point(414, 360)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 68)
        Me.btnCancelar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQuantidade.Location = New System.Drawing.Point(760, 88)
        Me.lblQuantidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(94, 20)
        Me.lblQuantidade.TabIndex = 83
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(20, 111)
        Me.txtCodProd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(72, 24)
        Me.txtCodProd.TabIndex = 2
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDataCompra
        '
        Me.lblDataCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDataCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCompra.Location = New System.Drawing.Point(133, 52)
        Me.lblDataCompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataCompra.Name = "lblDataCompra"
        Me.lblDataCompra.Size = New System.Drawing.Size(128, 28)
        Me.lblDataCompra.TabIndex = 78
        Me.lblDataCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataCompra2
        '
        Me.lblDataCompra2.AutoSize = True
        Me.lblDataCompra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDataCompra2.Location = New System.Drawing.Point(129, 27)
        Me.lblDataCompra2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataCompra2.Name = "lblDataCompra2"
        Me.lblDataCompra2.Size = New System.Drawing.Size(132, 20)
        Me.lblDataCompra2.TabIndex = 76
        Me.lblDataCompra2.Text = "Data da Compra"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(335, 360)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotal1.Location = New System.Drawing.Point(872, 85)
        Me.lblTotal1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(46, 20)
        Me.lblTotal1.TabIndex = 77
        Me.lblTotal1.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(876, 111)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(96, 25)
        Me.lblTotal.TabIndex = 76
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblValor1.Location = New System.Drawing.Point(656, 85)
        Me.lblValor1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(48, 20)
        Me.lblValor1.TabIndex = 75
        Me.lblValor1.Text = "Valor"
        '
        'lblValor
        '
        Me.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(660, 111)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(96, 23)
        Me.lblValor.TabIndex = 74
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.Padaria.My.Resources.Resources.print_view
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Location = New System.Drawing.Point(493, 360)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 68)
        Me.btnImprimir.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lstReservas
        '
        Me.lstReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Produtos, Me.Valor, Me.Quantidade, Me.total})
        Me.lstReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lstReservas.FullRowSelect = True
        Me.lstReservas.HideSelection = False
        Me.lstReservas.Location = New System.Drawing.Point(20, 142)
        Me.lstReservas.Margin = New System.Windows.Forms.Padding(4)
        Me.lstReservas.MultiSelect = False
        Me.lstReservas.Name = "lstReservas"
        Me.lstReservas.Size = New System.Drawing.Size(952, 210)
        Me.lstReservas.TabIndex = 10
        Me.lstReservas.UseCompatibleStateImageBehavior = False
        Me.lstReservas.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'Produtos
        '
        Me.Produtos.Text = "Produtos"
        Me.Produtos.Width = 220
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.Width = 80
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 80
        '
        'total
        '
        Me.total.Text = "Total"
        Me.total.Width = 80
        '
        'lblProdutos2
        '
        Me.lblProdutos2.AutoSize = True
        Me.lblProdutos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblProdutos2.Location = New System.Drawing.Point(97, 86)
        Me.lblProdutos2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdutos2.Name = "lblProdutos2"
        Me.lblProdutos2.Size = New System.Drawing.Size(67, 20)
        Me.lblProdutos2.TabIndex = 12
        Me.lblProdutos2.Text = "Produto"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 92)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 38)
        Me.Panel2.TabIndex = 39
        '
        'grpDados
        '
        Me.grpDados.Controls.Add(Me.cboDependentes)
        Me.grpDados.Controls.Add(Me.lblNrFicha)
        Me.grpDados.Controls.Add(Me.cboClientes)
        Me.grpDados.Controls.Add(Me.lblDependentes)
        Me.grpDados.Controls.Add(Me.lblNrFicha2)
        Me.grpDados.Controls.Add(Me.lblCliente2)
        Me.grpDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDados.Location = New System.Drawing.Point(19, 100)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDados.Size = New System.Drawing.Size(995, 100)
        Me.grpDados.TabIndex = 40
        Me.grpDados.TabStop = False
        Me.grpDados.Tag = "0"
        Me.grpDados.Text = "Dados do Cliente"
        '
        'cboDependentes
        '
        Me.cboDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDependentes.FormattingEnabled = True
        Me.cboDependentes.Location = New System.Drawing.Point(615, 53)
        Me.cboDependentes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDependentes.Name = "cboDependentes"
        Me.cboDependentes.Size = New System.Drawing.Size(371, 25)
        Me.cboDependentes.TabIndex = 1
        '
        'lblNrFicha
        '
        Me.lblNrFicha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNrFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrFicha.Location = New System.Drawing.Point(20, 53)
        Me.lblNrFicha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNrFicha.Name = "lblNrFicha"
        Me.lblNrFicha.Size = New System.Drawing.Size(133, 26)
        Me.lblNrFicha.TabIndex = 84
        Me.lblNrFicha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboClientes
        '
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(161, 53)
        Me.cboClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(444, 25)
        Me.cboClientes.TabIndex = 0
        '
        'lblDependentes
        '
        Me.lblDependentes.AutoSize = True
        Me.lblDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDependentes.Location = New System.Drawing.Point(611, 28)
        Me.lblDependentes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDependentes.Name = "lblDependentes"
        Me.lblDependentes.Size = New System.Drawing.Size(99, 20)
        Me.lblDependentes.TabIndex = 81
        Me.lblDependentes.Text = "Dependente"
        '
        'lblNrFicha2
        '
        Me.lblNrFicha2.AutoSize = True
        Me.lblNrFicha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNrFicha2.Location = New System.Drawing.Point(16, 32)
        Me.lblNrFicha2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNrFicha2.Name = "lblNrFicha2"
        Me.lblNrFicha2.Size = New System.Drawing.Size(137, 20)
        Me.lblNrFicha2.TabIndex = 75
        Me.lblNrFicha2.Text = "Número da Ficha"
        '
        'lblCliente2
        '
        Me.lblCliente2.AutoSize = True
        Me.lblCliente2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCliente2.Location = New System.Drawing.Point(161, 32)
        Me.lblCliente2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente2.Name = "lblCliente2"
        Me.lblCliente2.Size = New System.Drawing.Size(61, 20)
        Me.lblCliente2.TabIndex = 77
        Me.lblCliente2.Text = "Cliente"
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
        'frmCaderneta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 665)
        Me.Controls.Add(Me.grpDados)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpCaderneta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmCaderneta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caderneta"
        Me.grpCaderneta.ResumeLayout(False)
        Me.grpCaderneta.PerformLayout()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCaderneta As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lstReservas As System.Windows.Forms.ListView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCliente2 As System.Windows.Forms.Label
    Friend WithEvents lblNrFicha2 As System.Windows.Forms.Label
    Friend WithEvents grpDados As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblValor1 As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblProdutos2 As System.Windows.Forms.Label
    Friend WithEvents lblDependentes As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents Produtos As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblNrFicha As System.Windows.Forms.Label
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents lblProdutos As System.Windows.Forms.Label
    Friend WithEvents lblCodProd2 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalFinal2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFinal As System.Windows.Forms.Label
    Friend WithEvents cboDependentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents lblDataVencimento2 As System.Windows.Forms.Label
    Friend WithEvents lblDataCompra As System.Windows.Forms.Label
    Friend WithEvents lblDataCompra2 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCaderneta As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Codigo As ColumnHeader
End Class
