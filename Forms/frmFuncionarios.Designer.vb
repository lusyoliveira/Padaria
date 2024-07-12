<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionarios))
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.lstFuncionarios = New System.Windows.Forms.ListView()
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cpf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.celular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.registro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cargo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.salario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.carteira = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpFuncionarios = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.cbouf = New System.Windows.Forms.ComboBox()
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.mkdcelular = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.mkdRG = New System.Windows.Forms.MaskedTextBox()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.mkdCpf = New System.Windows.Forms.MaskedTextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.mkdCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mkdCarteira = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.mkdPis = New System.Windows.Forms.MaskedTextBox()
        Me.lblPIS = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpFuncionarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(552, 599)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 17
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(304, 599)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 15
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(428, 599)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 16
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'lstFuncionarios
        '
        Me.lstFuncionarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nome, Me.endereco, Me.bairro, Me.cidade, Me.estado, Me.cep, Me.cpf, Me.rg, Me.telefone, Me.celular, Me.registro, Me.cargo, Me.salario, Me.carteira, Me.pis})
        Me.lstFuncionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFuncionarios.FullRowSelect = True
        Me.lstFuncionarios.HideSelection = False
        Me.lstFuncionarios.Location = New System.Drawing.Point(16, 396)
        Me.lstFuncionarios.Margin = New System.Windows.Forms.Padding(4)
        Me.lstFuncionarios.MultiSelect = False
        Me.lstFuncionarios.Name = "lstFuncionarios"
        Me.lstFuncionarios.Size = New System.Drawing.Size(969, 195)
        Me.lstFuncionarios.TabIndex = 15
        Me.lstFuncionarios.UseCompatibleStateImageBehavior = False
        Me.lstFuncionarios.View = System.Windows.Forms.View.Details
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 150
        '
        'endereco
        '
        Me.endereco.Text = "Endereço"
        Me.endereco.Width = 150
        '
        'bairro
        '
        Me.bairro.Text = "Bairro"
        Me.bairro.Width = 120
        '
        'cidade
        '
        Me.cidade.Text = "Cidade"
        Me.cidade.Width = 120
        '
        'estado
        '
        Me.estado.Text = "Estado"
        '
        'cep
        '
        Me.cep.Text = "CEP"
        Me.cep.Width = 80
        '
        'cpf
        '
        Me.cpf.Text = "CPF"
        Me.cpf.Width = 100
        '
        'rg
        '
        Me.rg.Text = "RG"
        Me.rg.Width = 70
        '
        'telefone
        '
        Me.telefone.Text = "Telefone"
        Me.telefone.Width = 100
        '
        'celular
        '
        Me.celular.Text = "Celular"
        Me.celular.Width = 120
        '
        'registro
        '
        Me.registro.Text = "Número de Registro"
        Me.registro.Width = 150
        '
        'cargo
        '
        Me.cargo.Text = "Cargo"
        Me.cargo.Width = 120
        '
        'salario
        '
        Me.salario.Text = "Salário"
        Me.salario.Width = 70
        '
        'carteira
        '
        Me.carteira.Text = "Número da Carteira"
        Me.carteira.Width = 120
        '
        'pis
        '
        Me.pis.Text = "PIS"
        Me.pis.Width = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(552, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Bairro"
        '
        'grpFuncionarios
        '
        Me.grpFuncionarios.Controls.Add(Me.Label7)
        Me.grpFuncionarios.Controls.Add(Me.lblCodigo)
        Me.grpFuncionarios.Controls.Add(Me.cbouf)
        Me.grpFuncionarios.Controls.Add(Me.cboCidade)
        Me.grpFuncionarios.Controls.Add(Me.mkdcelular)
        Me.grpFuncionarios.Controls.Add(Me.lblCelular)
        Me.grpFuncionarios.Controls.Add(Me.mkdRG)
        Me.grpFuncionarios.Controls.Add(Me.mkdTelefone)
        Me.grpFuncionarios.Controls.Add(Me.Label5)
        Me.grpFuncionarios.Controls.Add(Me.lblRG)
        Me.grpFuncionarios.Controls.Add(Me.mkdCpf)
        Me.grpFuncionarios.Controls.Add(Me.lblCpf)
        Me.grpFuncionarios.Controls.Add(Me.lblEstado)
        Me.grpFuncionarios.Controls.Add(Me.lblCidade)
        Me.grpFuncionarios.Controls.Add(Me.mkdCEP)
        Me.grpFuncionarios.Controls.Add(Me.lblCEP)
        Me.grpFuncionarios.Controls.Add(Me.txtBairro)
        Me.grpFuncionarios.Controls.Add(Me.Label4)
        Me.grpFuncionarios.Controls.Add(Me.txtEndereco)
        Me.grpFuncionarios.Controls.Add(Me.Label3)
        Me.grpFuncionarios.Controls.Add(Me.txtNome)
        Me.grpFuncionarios.Controls.Add(Me.Label2)
        Me.grpFuncionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFuncionarios.Location = New System.Drawing.Point(16, 100)
        Me.grpFuncionarios.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFuncionarios.Name = "grpFuncionarios"
        Me.grpFuncionarios.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFuncionarios.Size = New System.Drawing.Size(969, 162)
        Me.grpFuncionarios.TabIndex = 16
        Me.grpFuncionarios.TabStop = False
        Me.grpFuncionarios.Tag = "0"
        Me.grpFuncionarios.Text = "Funcionários"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(24, 63)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 26)
        Me.lblCodigo.TabIndex = 60
        '
        'cbouf
        '
        Me.cbouf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbouf.FormattingEnabled = True
        Me.cbouf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cbouf.Location = New System.Drawing.Point(772, 117)
        Me.cbouf.Margin = New System.Windows.Forms.Padding(4)
        Me.cbouf.Name = "cbouf"
        Me.cbouf.Size = New System.Drawing.Size(59, 26)
        Me.cbouf.TabIndex = 42
        '
        'cboCidade
        '
        Me.cboCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Items.AddRange(New Object() {"Juiz de Fora", "Barbacena", "Belo Horizonte"})
        Me.cboCidade.Location = New System.Drawing.Point(388, 117)
        Me.cboCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(160, 26)
        Me.cboCidade.TabIndex = 2
        '
        'mkdcelular
        '
        Me.mkdcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdcelular.Location = New System.Drawing.Point(807, 63)
        Me.mkdcelular.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdcelular.Mask = "(000) 0000 - 0000"
        Me.mkdcelular.Name = "mkdcelular"
        Me.mkdcelular.Size = New System.Drawing.Size(139, 26)
        Me.mkdcelular.TabIndex = 9
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(803, 39)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(62, 20)
        Me.lblCelular.TabIndex = 41
        Me.lblCelular.Text = "Celular"
        '
        'mkdRG
        '
        Me.mkdRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdRG.Location = New System.Drawing.Point(559, 63)
        Me.mkdRG.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdRG.Mask = "00.000.000"
        Me.mkdRG.Name = "mkdRG"
        Me.mkdRG.Size = New System.Drawing.Size(92, 26)
        Me.mkdRG.TabIndex = 7
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(659, 63)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(140, 26)
        Me.mkdTelefone.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(655, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Telefone"
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(555, 39)
        Me.lblRG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(34, 20)
        Me.lblRG.TabIndex = 39
        Me.lblRG.Text = "RG"
        '
        'mkdCpf
        '
        Me.mkdCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCpf.Location = New System.Drawing.Point(412, 63)
        Me.mkdCpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCpf.Mask = "000.000.000 - 00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(139, 26)
        Me.mkdCpf.TabIndex = 6
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(408, 39)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(42, 20)
        Me.lblCpf.TabIndex = 37
        Me.lblCpf.Text = "CPF"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(768, 93)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(61, 20)
        Me.lblEstado.TabIndex = 35
        Me.lblEstado.Text = "Estado"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(384, 93)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(61, 20)
        Me.lblCidade.TabIndex = 33
        Me.lblCidade.Text = "Cidade"
        '
        'mkdCEP
        '
        Me.mkdCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCEP.Location = New System.Drawing.Point(839, 117)
        Me.mkdCEP.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCEP.Mask = "000000 - 000"
        Me.mkdCEP.Name = "mkdCEP"
        Me.mkdCEP.Size = New System.Drawing.Size(107, 26)
        Me.mkdCEP.TabIndex = 5
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(839, 93)
        Me.lblCEP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(43, 20)
        Me.lblCEP.TabIndex = 31
        Me.lblCEP.Text = "CEP"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(556, 117)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(208, 26)
        Me.txtBairro.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(24, 117)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(356, 26)
        Me.txtEndereco.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Endereço"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(86, 63)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(318, 26)
        Me.txtNome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nome"
        '
        'txtSalario
        '
        Me.txtSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalario.Location = New System.Drawing.Point(705, 66)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(75, 26)
        Me.txtSalario.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(701, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Salário"
        '
        'txtCargo
        '
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(115, 68)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(239, 26)
        Me.txtCargo.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(111, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cargo"
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
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mkdCarteira)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSalario)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.mkdPis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblPIS)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 270)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(969, 118)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da Empresa"
        '
        'mkdCarteira
        '
        Me.mkdCarteira.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCarteira.Location = New System.Drawing.Point(543, 66)
        Me.mkdCarteira.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCarteira.Mask = "000.000.000 - 00"
        Me.mkdCarteira.Name = "mkdCarteira"
        Me.mkdCarteira.Size = New System.Drawing.Size(139, 26)
        Me.mkdCarteira.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nº Cart. Trabalho"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(11, 36)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(72, 20)
        Me.lblNumero.TabIndex = 41
        Me.lblNumero.Text = "Registro"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(15, 66)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(73, 26)
        Me.txtNumero.TabIndex = 10
        '
        'mkdPis
        '
        Me.mkdPis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdPis.Location = New System.Drawing.Point(376, 68)
        Me.mkdPis.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdPis.Mask = "000.000.000 - 00"
        Me.mkdPis.Name = "mkdPis"
        Me.mkdPis.Size = New System.Drawing.Size(139, 26)
        Me.mkdPis.TabIndex = 12
        '
        'lblPIS
        '
        Me.lblPIS.AutoSize = True
        Me.lblPIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIS.Location = New System.Drawing.Point(372, 37)
        Me.lblPIS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPIS.Name = "lblPIS"
        Me.lblPIS.Size = New System.Drawing.Size(35, 20)
        Me.lblPIS.TabIndex = 39
        Me.lblPIS.Text = "PIS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 92)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 38)
        Me.Panel2.TabIndex = 44
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 687)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstFuncionarios)
        Me.Controls.Add(Me.grpFuncionarios)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.grpFuncionarios.ResumeLayout(False)
        Me.grpFuncionarios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents lstFuncionarios As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpFuncionarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents mkdCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mkdRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents mkdCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents endereco As System.Windows.Forms.ColumnHeader
    Friend WithEvents bairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents cep As System.Windows.Forms.ColumnHeader
    Friend WithEvents cpf As System.Windows.Forms.ColumnHeader
    Friend WithEvents rg As System.Windows.Forms.ColumnHeader
    Friend WithEvents telefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents cargo As System.Windows.Forms.ColumnHeader
    Friend WithEvents salario As System.Windows.Forms.ColumnHeader
    Friend WithEvents mkdcelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mkdPis As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPIS As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents mkdCarteira As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents registro As System.Windows.Forms.ColumnHeader
    Friend WithEvents carteira As System.Windows.Forms.ColumnHeader
    Friend WithEvents pis As System.Windows.Forms.ColumnHeader
    Friend WithEvents celular As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbouf As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
End Class
