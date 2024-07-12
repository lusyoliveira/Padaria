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
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.lstFornecedores = New System.Windows.Forms.ListView()
        Me.empresa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.complemento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CNPJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.uf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fornecedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.celular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.siteweb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.grpFornecedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 92)
        Me.Panel1.TabIndex = 1
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.Location = New System.Drawing.Point(438, 45)
        Me.lblFornecedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(85, 18)
        Me.lblFornecedor.TabIndex = 3
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFornecedor.Location = New System.Drawing.Point(438, 64)
        Me.txtFornecedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(401, 24)
        Me.txtFornecedor.TabIndex = 8
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(13, 100)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(72, 18)
        Me.lblEndereco.TabIndex = 6
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(91, 45)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(68, 18)
        Me.lblEmpresa.TabIndex = 7
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(617, 97)
        Me.lblComplemento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(102, 18)
        Me.lblComplemento.TabIndex = 8
        Me.lblComplemento.Text = "Complemento"
        '
        'lblCnpj
        '
        Me.lblCnpj.AutoSize = True
        Me.lblCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnpj.Location = New System.Drawing.Point(844, 42)
        Me.lblCnpj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(48, 18)
        Me.lblCnpj.TabIndex = 9
        Me.lblCnpj.Text = "CNPJ"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(91, 64)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(339, 24)
        Me.txtEmpresa.TabIndex = 0
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(403, 100)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(48, 18)
        Me.lblBairro.TabIndex = 12
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(734, 97)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(54, 18)
        Me.lblCidade.TabIndex = 13
        Me.lblCidade.Text = "Cidade"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUf.Location = New System.Drawing.Point(902, 97)
        Me.lblUf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(28, 18)
        Me.lblUf.TabIndex = 14
        Me.lblUf.Text = "UF"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(16, 119)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(379, 24)
        Me.txtEndereco.TabIndex = 1
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(620, 119)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(109, 24)
        Me.txtComplemento.TabIndex = 3
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(403, 119)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(209, 24)
        Me.txtBairro.TabIndex = 2
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(14, 145)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(39, 18)
        Me.lblCep.TabIndex = 20
        Me.lblCep.Text = "CEP"
        '
        'mkdCelular
        '
        Me.mkdCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCelular.Location = New System.Drawing.Point(246, 167)
        Me.mkdCelular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mkdCelular.Mask = "(00)0000-0000"
        Me.mkdCelular.Name = "mkdCelular"
        Me.mkdCelular.Size = New System.Drawing.Size(132, 24)
        Me.mkdCelular.TabIndex = 10
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(119, 167)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mkdTelefone.Mask = "(00)0000-0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(119, 24)
        Me.mkdTelefone.TabIndex = 9
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(243, 145)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(54, 18)
        Me.lblCelular.TabIndex = 28
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(116, 145)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(65, 18)
        Me.lblTelefone.TabIndex = 27
        Me.lblTelefone.Text = "Telefone"
        '
        'txtSite
        '
        Me.txtSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSite.Location = New System.Drawing.Point(675, 167)
        Me.txtSite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(337, 24)
        Me.txtSite.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(386, 167)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(281, 24)
        Me.txtEmail.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(383, 145)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 18)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "E-Mail"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSite.Location = New System.Drawing.Point(675, 147)
        Me.lblSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(33, 18)
        Me.lblSite.TabIndex = 23
        Me.lblSite.Text = "Site"
        '
        'mkdCNPJ
        '
        Me.mkdCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCNPJ.Location = New System.Drawing.Point(847, 64)
        Me.mkdCNPJ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mkdCNPJ.Mask = "000.000.000/0000-00"
        Me.mkdCNPJ.Name = "mkdCNPJ"
        Me.mkdCNPJ.Size = New System.Drawing.Size(165, 24)
        Me.mkdCNPJ.TabIndex = 5
        '
        'mkdCEP
        '
        Me.mkdCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCEP.Location = New System.Drawing.Point(15, 167)
        Me.mkdCEP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mkdCEP.Mask = "00000 - 000"
        Me.mkdCEP.Name = "mkdCEP"
        Me.mkdCEP.Size = New System.Drawing.Size(96, 24)
        Me.mkdCEP.TabIndex = 7
        '
        'cbouf
        '
        Me.cbouf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbouf.FormattingEnabled = True
        Me.cbouf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cbouf.Location = New System.Drawing.Point(905, 119)
        Me.cbouf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbouf.Name = "cbouf"
        Me.cbouf.Size = New System.Drawing.Size(107, 26)
        Me.cbouf.TabIndex = 6
        '
        'grpFornecedores
        '
        Me.grpFornecedores.Controls.Add(Me.Label7)
        Me.grpFornecedores.Controls.Add(Me.lblCodigo)
        Me.grpFornecedores.Controls.Add(Me.cboCidade)
        Me.grpFornecedores.Controls.Add(Me.btnExcluir)
        Me.grpFornecedores.Controls.Add(Me.btnSalvar)
        Me.grpFornecedores.Controls.Add(Me.btnAlterar)
        Me.grpFornecedores.Controls.Add(Me.lstFornecedores)
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
        Me.grpFornecedores.Location = New System.Drawing.Point(16, 100)
        Me.grpFornecedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpFornecedores.Name = "grpFornecedores"
        Me.grpFornecedores.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpFornecedores.Size = New System.Drawing.Size(1031, 532)
        Me.grpFornecedores.TabIndex = 17
        Me.grpFornecedores.TabStop = False
        Me.grpFornecedores.Tag = "0"
        Me.grpFornecedores.Text = "Fornecedores"
        '
        'cboCidade
        '
        Me.cboCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Items.AddRange(New Object() {"Juiz de Fora", "Barbacena", "Belo Horizonte"})
        Me.cboCidade.Location = New System.Drawing.Point(737, 119)
        Me.cboCidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(160, 26)
        Me.cboCidade.TabIndex = 4
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.Location = New System.Drawing.Point(582, 444)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 15
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.Location = New System.Drawing.Point(401, 444)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 13
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterar.Location = New System.Drawing.Point(489, 444)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 14
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'lstFornecedores
        '
        Me.lstFornecedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.empresa, Me.endereco, Me.bairro, Me.complemento, Me.cidade, Me.CNPJ, Me.uf, Me.cep, Me.fornecedor, Me.telefone, Me.celular, Me.siteweb, Me.email})
        Me.lstFornecedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lstFornecedores.FullRowSelect = True
        Me.lstFornecedores.HideSelection = False
        Me.lstFornecedores.Location = New System.Drawing.Point(15, 199)
        Me.lstFornecedores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstFornecedores.MultiSelect = False
        Me.lstFornecedores.Name = "lstFornecedores"
        Me.lstFornecedores.Size = New System.Drawing.Size(997, 237)
        Me.lstFornecedores.TabIndex = 29
        Me.lstFornecedores.UseCompatibleStateImageBehavior = False
        Me.lstFornecedores.View = System.Windows.Forms.View.Details
        '
        'empresa
        '
        Me.empresa.Text = "Empresa"
        Me.empresa.Width = 150
        '
        'endereco
        '
        Me.endereco.Text = "Endereço"
        Me.endereco.Width = 150
        '
        'bairro
        '
        Me.bairro.Text = "Bairro"
        Me.bairro.Width = 100
        '
        'complemento
        '
        Me.complemento.Text = "Complemento"
        Me.complemento.Width = 80
        '
        'cidade
        '
        Me.cidade.Text = "Cidade"
        Me.cidade.Width = 100
        '
        'CNPJ
        '
        Me.CNPJ.Text = "CNPJ"
        Me.CNPJ.Width = 100
        '
        'uf
        '
        Me.uf.Text = "UF"
        Me.uf.Width = 40
        '
        'cep
        '
        Me.cep.Text = "CEP"
        Me.cep.Width = 90
        '
        'fornecedor
        '
        Me.fornecedor.Text = "Fornecedor"
        Me.fornecedor.Width = 100
        '
        'telefone
        '
        Me.telefone.Text = "Telefone"
        '
        'celular
        '
        Me.celular.Text = "Celular"
        '
        'siteweb
        '
        Me.siteweb.Text = "Site"
        Me.siteweb.Width = 100
        '
        'email
        '
        Me.email.Text = "E - Mail"
        Me.email.Width = 100
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
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 38)
        Me.Panel2.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(16, 64)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 24)
        Me.lblCodigo.TabIndex = 58
        '
        'frmFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 649)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpFornecedores)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lstFornecedores As System.Windows.Forms.ListView
    Friend WithEvents empresa As System.Windows.Forms.ColumnHeader
    Friend WithEvents endereco As System.Windows.Forms.ColumnHeader
    Friend WithEvents bairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents complemento As System.Windows.Forms.ColumnHeader
    Friend WithEvents cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents CNPJ As System.Windows.Forms.ColumnHeader
    Friend WithEvents uf As System.Windows.Forms.ColumnHeader
    Friend WithEvents cep As System.Windows.Forms.ColumnHeader
    Friend WithEvents fornecedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents telefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents celular As System.Windows.Forms.ColumnHeader
    Friend WithEvents siteweb As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
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
End Class
