<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblCnpj = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.mkdCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.mkdCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.mkdCEP = New System.Windows.Forms.MaskedTextBox()
        Me.cbouf = New System.Windows.Forms.ComboBox()
        Me.grpFornecedores = New System.Windows.Forms.GroupBox()
        Me.lstEntidade = New System.Windows.Forms.ListView()
        Me.CodEntidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomeFantasia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RazaoSocial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataNasc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Endereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Complemento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CEP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RG = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Documento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OBS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cadastro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Alteracao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Inativacao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpFornecedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 93)
        Me.Panel1.TabIndex = 1
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.Location = New System.Drawing.Point(328, 37)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(70, 15)
        Me.lblFornecedor.TabIndex = 3
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornecedor.Location = New System.Drawing.Point(328, 52)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(302, 21)
        Me.txtFornecedor.TabIndex = 8
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(10, 81)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(60, 15)
        Me.lblEndereco.TabIndex = 6
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(68, 37)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(57, 15)
        Me.lblEmpresa.TabIndex = 7
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(463, 79)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(85, 15)
        Me.lblComplemento.TabIndex = 8
        Me.lblComplemento.Text = "Complemento"
        '
        'lblCnpj
        '
        Me.lblCnpj.AutoSize = True
        Me.lblCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnpj.Location = New System.Drawing.Point(633, 34)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(38, 15)
        Me.lblCnpj.TabIndex = 9
        Me.lblCnpj.Text = "CNPJ"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(68, 52)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(255, 21)
        Me.txtEmpresa.TabIndex = 0
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(302, 81)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(40, 15)
        Me.lblBairro.TabIndex = 12
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(550, 79)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(46, 15)
        Me.lblCidade.TabIndex = 13
        Me.lblCidade.Text = "Cidade"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUf.Location = New System.Drawing.Point(676, 79)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(23, 15)
        Me.lblUf.TabIndex = 14
        Me.lblUf.Text = "UF"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(12, 97)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(285, 21)
        Me.txtEndereco.TabIndex = 1
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(465, 97)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(83, 21)
        Me.txtComplemento.TabIndex = 3
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(302, 97)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(158, 21)
        Me.txtBairro.TabIndex = 2
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(10, 118)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(31, 15)
        Me.lblCep.TabIndex = 20
        Me.lblCep.Text = "CEP"
        '
        'mkdCelular
        '
        Me.mkdCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCelular.Location = New System.Drawing.Point(184, 136)
        Me.mkdCelular.Mask = "(00)0000-0000"
        Me.mkdCelular.Name = "mkdCelular"
        Me.mkdCelular.Size = New System.Drawing.Size(100, 21)
        Me.mkdCelular.TabIndex = 10
        Me.mkdCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(89, 136)
        Me.mkdTelefone.Mask = "(00)0000-0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(90, 21)
        Me.mkdTelefone.TabIndex = 9
        Me.mkdTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(182, 118)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(46, 15)
        Me.lblCelular.TabIndex = 28
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(87, 118)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefone.TabIndex = 27
        Me.lblTelefone.Text = "Telefone"
        '
        'txtSite
        '
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.Location = New System.Drawing.Point(506, 136)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(254, 21)
        Me.txtSite.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(290, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(212, 21)
        Me.txtEmail.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(287, 118)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 15)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "E-Mail"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite.Location = New System.Drawing.Point(506, 119)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(28, 15)
        Me.lblSite.TabIndex = 23
        Me.lblSite.Text = "Site"
        '
        'mkdCNPJ
        '
        Me.mkdCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCNPJ.Location = New System.Drawing.Point(635, 52)
        Me.mkdCNPJ.Mask = "000.000.000/0000-00"
        Me.mkdCNPJ.Name = "mkdCNPJ"
        Me.mkdCNPJ.Size = New System.Drawing.Size(125, 21)
        Me.mkdCNPJ.TabIndex = 5
        Me.mkdCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdCEP
        '
        Me.mkdCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCEP.Location = New System.Drawing.Point(11, 136)
        Me.mkdCEP.Mask = "00000 - 000"
        Me.mkdCEP.Name = "mkdCEP"
        Me.mkdCEP.Size = New System.Drawing.Size(73, 21)
        Me.mkdCEP.TabIndex = 7
        Me.mkdCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cbouf
        '
        Me.cbouf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbouf.FormattingEnabled = True
        Me.cbouf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cbouf.Location = New System.Drawing.Point(679, 97)
        Me.cbouf.Name = "cbouf"
        Me.cbouf.Size = New System.Drawing.Size(81, 23)
        Me.cbouf.TabIndex = 6
        '
        'grpFornecedores
        '
        Me.grpFornecedores.Controls.Add(Me.lstEntidade)
        Me.grpFornecedores.Controls.Add(Me.Label7)
        Me.grpFornecedores.Controls.Add(Me.lblCodigo)
        Me.grpFornecedores.Controls.Add(Me.cboCidade)
        Me.grpFornecedores.Controls.Add(Me.btnExcluir)
        Me.grpFornecedores.Controls.Add(Me.btnSalvar)
        Me.grpFornecedores.Controls.Add(Me.btnAlterar)
        Me.grpFornecedores.Controls.Add(Me.mkdCelular)
        Me.grpFornecedores.Controls.Add(Me.cbouf)
        Me.grpFornecedores.Controls.Add(Me.mkdTelefone)
        Me.grpFornecedores.Controls.Add(Me.mkdCEP)
        Me.grpFornecedores.Controls.Add(Me.lblCelular)
        Me.grpFornecedores.Controls.Add(Me.mkdCNPJ)
        Me.grpFornecedores.Controls.Add(Me.lblTelefone)
        Me.grpFornecedores.Controls.Add(Me.txtSite)
        Me.grpFornecedores.Controls.Add(Me.lblCep)
        Me.grpFornecedores.Controls.Add(Me.txtEmail)
        Me.grpFornecedores.Controls.Add(Me.lblEmail)
        Me.grpFornecedores.Controls.Add(Me.txtBairro)
        Me.grpFornecedores.Controls.Add(Me.lblSite)
        Me.grpFornecedores.Controls.Add(Me.txtComplemento)
        Me.grpFornecedores.Controls.Add(Me.txtEndereco)
        Me.grpFornecedores.Controls.Add(Me.lblUf)
        Me.grpFornecedores.Controls.Add(Me.lblCidade)
        Me.grpFornecedores.Controls.Add(Me.lblBairro)
        Me.grpFornecedores.Controls.Add(Me.txtEmpresa)
        Me.grpFornecedores.Controls.Add(Me.lblCnpj)
        Me.grpFornecedores.Controls.Add(Me.lblComplemento)
        Me.grpFornecedores.Controls.Add(Me.lblEmpresa)
        Me.grpFornecedores.Controls.Add(Me.lblEndereco)
        Me.grpFornecedores.Controls.Add(Me.txtFornecedor)
        Me.grpFornecedores.Controls.Add(Me.lblFornecedor)
        Me.grpFornecedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFornecedores.Location = New System.Drawing.Point(10, 100)
        Me.grpFornecedores.Name = "grpFornecedores"
        Me.grpFornecedores.Size = New System.Drawing.Size(773, 432)
        Me.grpFornecedores.TabIndex = 17
        Me.grpFornecedores.TabStop = False
        Me.grpFornecedores.Tag = "0"
        Me.grpFornecedores.Text = "Fornecedores"
        '
        'lstEntidade
        '
        Me.lstEntidade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodEntidade, Me.NomeFantasia, Me.RazaoSocial, Me.DataNasc, Me.EstadoCivil, Me.Endereco, Me.Complemento, Me.Bairro, Me.Cidade, Me.Estado, Me.CEP, Me.Sexo, Me.RG, Me.Documento, Me.OBS, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.lstEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEntidade.FullRowSelect = True
        Me.lstEntidade.HideSelection = False
        Me.lstEntidade.Location = New System.Drawing.Point(13, 173)
        Me.lstEntidade.MultiSelect = False
        Me.lstEntidade.Name = "lstEntidade"
        Me.lstEntidade.Size = New System.Drawing.Size(747, 182)
        Me.lstEntidade.TabIndex = 60
        Me.lstEntidade.Tag = "0"
        Me.lstEntidade.UseCompatibleStateImageBehavior = False
        Me.lstEntidade.View = System.Windows.Forms.View.Details
        '
        'CodEntidade
        '
        Me.CodEntidade.Text = "Código"
        '
        'NomeFantasia
        '
        Me.NomeFantasia.Text = "Nome Fantasia"
        '
        'RazaoSocial
        '
        Me.RazaoSocial.Text = "Razão Social"
        '
        'DataNasc
        '
        Me.DataNasc.Text = "Nascimento"
        '
        'EstadoCivil
        '
        Me.EstadoCivil.Text = "Estado Civil"
        '
        'Endereco
        '
        Me.Endereco.Text = "Endereço"
        '
        'Complemento
        '
        Me.Complemento.Text = "Complemento"
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        '
        'CEP
        '
        Me.CEP.Text = "CEP"
        '
        'Sexo
        '
        Me.Sexo.Text = "Sexo"
        '
        'RG
        '
        Me.RG.Text = "RG"
        '
        'Documento
        '
        Me.Documento.Text = "Documento"
        '
        'OBS
        '
        Me.OBS.Text = "OBS"
        '
        'Cadastro
        '
        Me.Cadastro.Text = "Cadastro"
        '
        'Alteracao
        '
        Me.Alteracao.Text = "Alteração"
        '
        'Inativacao
        '
        Me.Inativacao.Text = "Inativação"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(12, 52)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 20)
        Me.lblCodigo.TabIndex = 58
        '
        'cboCidade
        '
        Me.cboCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Items.AddRange(New Object() {"Juiz de Fora", "Barbacena", "Belo Horizonte"})
        Me.cboCidade.Location = New System.Drawing.Point(553, 97)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(121, 23)
        Me.cboCidade.TabIndex = 4
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.Location = New System.Drawing.Point(436, 361)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(53, 55)
        Me.btnExcluir.TabIndex = 15
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.Location = New System.Drawing.Point(301, 361)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 55)
        Me.btnSalvar.TabIndex = 13
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterar.Location = New System.Drawing.Point(367, 361)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 55)
        Me.btnAlterar.TabIndex = 14
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 31)
        Me.Panel2.TabIndex = 39
        '
        'frmFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 547)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpFornecedores)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fonecedores"
        Me.grpFornecedores.ResumeLayout(False)
        Me.grpFornecedores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents txtFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblCnpj As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents mkdCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbouf As System.Windows.Forms.ComboBox
    Friend WithEvents grpFornecedores As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lstEntidade As ListView
    Friend WithEvents CodEntidade As ColumnHeader
    Friend WithEvents NomeFantasia As ColumnHeader
    Friend WithEvents RazaoSocial As ColumnHeader
    Friend WithEvents DataNasc As ColumnHeader
    Friend WithEvents EstadoCivil As ColumnHeader
    Friend WithEvents Endereco As ColumnHeader
    Friend WithEvents Complemento As ColumnHeader
    Friend WithEvents Bairro As ColumnHeader
    Friend WithEvents Cidade As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents CEP As ColumnHeader
    Friend WithEvents Sexo As ColumnHeader
    Friend WithEvents RG As ColumnHeader
    Friend WithEvents Documento As ColumnHeader
    Friend WithEvents OBS As ColumnHeader
    Friend WithEvents Cadastro As ColumnHeader
    Friend WithEvents Alteracao As ColumnHeader
    Friend WithEvents Inativacao As ColumnHeader
End Class
