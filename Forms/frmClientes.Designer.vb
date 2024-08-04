<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblDatacd = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnAlterarDep = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mskrg = New System.Windows.Forms.MaskedTextBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbdMasculino = New System.Windows.Forms.RadioButton()
        Me.rbdFeminino = New System.Windows.Forms.RadioButton()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.mskTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mskcpf_dep = New System.Windows.Forms.MaskedTextBox()
        Me.mskdtdatadep = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCodDep = New System.Windows.Forms.Label()
        Me.lstDependente = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Parentesco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboParentesco = New System.Windows.Forms.ComboBox()
        Me.lblParentesco = New System.Windows.Forms.Label()
        Me.txtDependente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(877, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Quantidade:"
        '
        'lblData
        '
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Location = New System.Drawing.Point(256, 89)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(137, 26)
        Me.lblData.TabIndex = 33
        '
        'lblRegistro
        '
        Me.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegistro.Location = New System.Drawing.Point(992, 192)
        Me.lblRegistro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(85, 28)
        Me.lblRegistro.TabIndex = 36
        '
        'lblDatacd
        '
        Me.lblDatacd.AutoSize = True
        Me.lblDatacd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatacd.Location = New System.Drawing.Point(252, 68)
        Me.lblDatacd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatacd.Name = "lblDatacd"
        Me.lblDatacd.Size = New System.Drawing.Size(119, 17)
        Me.lblDatacd.TabIndex = 32
        Me.lblDatacd.Text = "Data de Cadastro"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(815, 139)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(259, 26)
        Me.txtBairro.TabIndex = 6
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(811, 116)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(46, 17)
        Me.lblBairro.TabIndex = 19
        Me.lblBairro.Text = "Bairro"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(21, 142)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(467, 26)
        Me.txtEndereco.TabIndex = 3
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(19, 118)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(69, 17)
        Me.lblEndereco.TabIndex = 18
        Me.lblEndereco.Text = "Endereço"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(97, 39)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(440, 26)
        Me.txtNome.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(93, 16)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(45, 17)
        Me.lblNome.TabIndex = 17
        Me.lblNome.Text = "Nome"
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
        'btnLimpar
        '
        Me.btnLimpar.BackgroundImage = Global.Padaria.My.Resources.Resources.trash
        Me.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpar.Location = New System.Drawing.Point(699, 565)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(71, 66)
        Me.btnLimpar.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.btnLimpar, "Limpar Campos")
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnconsultar
        '
        Me.btnconsultar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconsultar.Location = New System.Drawing.Point(620, 564)
        Me.btnconsultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(71, 68)
        Me.btnconsultar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Consultar")
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Location = New System.Drawing.Point(383, 562)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Location = New System.Drawing.Point(541, 562)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterar.Location = New System.Drawing.Point(461, 562)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.Location = New System.Drawing.Point(1013, 191)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(71, 68)
        Me.btnRemover.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnRemover, "Excluir")
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(1013, 114)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(71, 68)
        Me.btnAdicionar.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.btnAdicionar, "Salvar")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnAlterarDep
        '
        Me.btnAlterarDep.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterarDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterarDep.Location = New System.Drawing.Point(1013, 266)
        Me.btnAlterarDep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterarDep.Name = "btnAlterarDep"
        Me.btnAlterarDep.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterarDep.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.btnAlterarDep, "Alterar")
        Me.btnAlterarDep.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 92)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 38)
        Me.Panel2.TabIndex = 38
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 102)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1109, 457)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mskrg)
        Me.TabPage1.Controls.Add(Me.mskcpf)
        Me.TabPage1.Controls.Add(Me.lblCpf)
        Me.TabPage1.Controls.Add(Me.lblRg)
        Me.TabPage1.Controls.Add(Me.mskCep)
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblCep)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.mskDnascimento)
        Me.TabPage1.Controls.Add(Me.cboEstadoCivil)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblEstadoCivil)
        Me.TabPage1.Controls.Add(Me.lblDtNasc)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Controls.Add(Me.lstEntidade)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblData)
        Me.TabPage1.Controls.Add(Me.lblRegistro)
        Me.TabPage1.Controls.Add(Me.lblDatacd)
        Me.TabPage1.Controls.Add(Me.lblNome)
        Me.TabPage1.Controls.Add(Me.lblEndereco)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.lblBairro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1101, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mskrg
        '
        Me.mskrg.Location = New System.Drawing.Point(23, 90)
        Me.mskrg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskrg.Mask = "00.000.000"
        Me.mskrg.Name = "mskrg"
        Me.mskrg.Size = New System.Drawing.Size(83, 22)
        Me.mskrg.TabIndex = 72
        Me.mskrg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskcpf
        '
        Me.mskcpf.Location = New System.Drawing.Point(115, 90)
        Me.mskcpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskcpf.Mask = "000.000.000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(132, 22)
        Me.mskcpf.TabIndex = 71
        Me.mskcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(116, 70)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(34, 17)
        Me.lblCpf.TabIndex = 70
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRg.Location = New System.Drawing.Point(17, 70)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(29, 17)
        Me.lblRg.TabIndex = 69
        Me.lblRg.Text = "RG"
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(329, 196)
        Me.mskCep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(91, 22)
        Me.mskCep.TabIndex = 68
        Me.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(21, 196)
        Me.cboUf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(299, 24)
        Me.cboUf.TabIndex = 63
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(497, 142)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(308, 22)
        Me.txtCidade.TabIndex = 67
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(325, 180)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(35, 17)
        Me.lblCep.TabIndex = 66
        Me.lblCep.Text = "CEP"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUf.Location = New System.Drawing.Point(21, 178)
        Me.lblUf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(26, 17)
        Me.lblUf.TabIndex = 65
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(493, 119)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(52, 17)
        Me.lblCidade.TabIndex = 64
        Me.lblCidade.Text = "Cidade"
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(547, 39)
        Me.mskDnascimento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(133, 22)
        Me.mskDnascimento.TabIndex = 62
        Me.mskDnascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(689, 39)
        Me.cboEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(160, 24)
        Me.cboEstadoCivil.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdMasculino)
        Me.GroupBox1.Controls.Add(Me.rbdFeminino)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(859, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 55)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbdMasculino
        '
        Me.rbdMasculino.AutoSize = True
        Me.rbdMasculino.Location = New System.Drawing.Point(111, 22)
        Me.rbdMasculino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbdMasculino.Name = "rbdMasculino"
        Me.rbdMasculino.Size = New System.Drawing.Size(89, 20)
        Me.rbdMasculino.TabIndex = 27
        Me.rbdMasculino.TabStop = True
        Me.rbdMasculino.Text = "Masculino"
        Me.rbdMasculino.UseVisualStyleBackColor = True
        '
        'rbdFeminino
        '
        Me.rbdFeminino.AutoSize = True
        Me.rbdFeminino.Location = New System.Drawing.Point(8, 23)
        Me.rbdFeminino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbdFeminino.Name = "rbdFeminino"
        Me.rbdFeminino.Size = New System.Drawing.Size(83, 20)
        Me.rbdFeminino.TabIndex = 26
        Me.rbdFeminino.TabStop = True
        Me.rbdFeminino.Text = "Feminino"
        Me.rbdFeminino.UseVisualStyleBackColor = True
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(685, 20)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(81, 17)
        Me.lblEstadoCivil.TabIndex = 59
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtNasc.Location = New System.Drawing.Point(543, 20)
        Me.lblDtNasc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(136, 17)
        Me.lblDtNasc.TabIndex = 58
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(21, 39)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 25)
        Me.lblCodigo.TabIndex = 56
        '
        'lstEntidade
        '
        Me.lstEntidade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodEntidade, Me.NomeFantasia, Me.RazaoSocial, Me.DataNasc, Me.EstadoCivil, Me.Endereco, Me.Complemento, Me.Bairro, Me.Cidade, Me.Estado, Me.CEP, Me.Sexo, Me.RG, Me.Documento, Me.OBS, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.lstEntidade.FullRowSelect = True
        Me.lstEntidade.HideSelection = False
        Me.lstEntidade.Location = New System.Drawing.Point(21, 229)
        Me.lstEntidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstEntidade.MultiSelect = False
        Me.lstEntidade.Name = "lstEntidade"
        Me.lstEntidade.Size = New System.Drawing.Size(1055, 179)
        Me.lstEntidade.TabIndex = 38
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.mskCel)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.mskTel2)
        Me.TabPage3.Controls.Add(Me.lblEmail)
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.lblCelular)
        Me.TabPage3.Controls.Add(Me.lblTelefone2)
        Me.TabPage3.Controls.Add(Me.mkdTelefone)
        Me.TabPage3.Controls.Add(Me.lblTelefone1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(1101, 428)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contato"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(335, 44)
        Me.mskCel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskCel.Mask = "(00)0000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(132, 22)
        Me.mskCel.TabIndex = 42
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObs)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(515, 26)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(528, 159)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OBS"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(15, 18)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(496, 128)
        Me.txtObs.TabIndex = 0
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(185, 44)
        Me.mskTel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskTel2.Mask = "(00)0000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(132, 22)
        Me.mskTel2.TabIndex = 41
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(27, 80)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 40
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(29, 100)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(437, 22)
        Me.txtEmail.TabIndex = 39
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(331, 26)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 38
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(181, 26)
        Me.lblTelefone2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(71, 16)
        Me.lblTelefone2.TabIndex = 37
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(31, 44)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(144, 23)
        Me.mkdTelefone.TabIndex = 35
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone1.Location = New System.Drawing.Point(27, 25)
        Me.lblTelefone1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefone1.TabIndex = 36
        Me.lblTelefone1.Text = "Telefone"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAlterarDep)
        Me.TabPage2.Controls.Add(Me.mskcpf_dep)
        Me.TabPage2.Controls.Add(Me.mskdtdatadep)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lblCodDep)
        Me.TabPage2.Controls.Add(Me.lstDependente)
        Me.TabPage2.Controls.Add(Me.cboParentesco)
        Me.TabPage2.Controls.Add(Me.lblParentesco)
        Me.TabPage2.Controls.Add(Me.btnRemover)
        Me.TabPage2.Controls.Add(Me.btnAdicionar)
        Me.TabPage2.Controls.Add(Me.txtDependente)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1101, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dependentes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'mskcpf_dep
        '
        Me.mskcpf_dep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskcpf_dep.Location = New System.Drawing.Point(572, 39)
        Me.mskcpf_dep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskcpf_dep.Mask = "000.000.000-00"
        Me.mskcpf_dep.Name = "mskcpf_dep"
        Me.mskcpf_dep.Size = New System.Drawing.Size(132, 23)
        Me.mskcpf_dep.TabIndex = 63
        '
        'mskdtdatadep
        '
        Me.mskdtdatadep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdtdatadep.Location = New System.Drawing.Point(431, 42)
        Me.mskdtdatadep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskdtdatadep.Mask = "00/00/0000"
        Me.mskdtdatadep.Name = "mskdtdatadep"
        Me.mskdtdatadep.Size = New System.Drawing.Size(132, 23)
        Me.mskdtdatadep.TabIndex = 62
        Me.mskdtdatadep.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(425, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Data de Nascimento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(572, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Código"
        '
        'lblCodDep
        '
        Me.lblCodDep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodDep.Location = New System.Drawing.Point(19, 39)
        Me.lblCodDep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodDep.Name = "lblCodDep"
        Me.lblCodDep.Size = New System.Drawing.Size(67, 25)
        Me.lblCodDep.TabIndex = 58
        '
        'lstDependente
        '
        Me.lstDependente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome, Me.Parentesco})
        Me.lstDependente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDependente.HideSelection = False
        Me.lstDependente.Location = New System.Drawing.Point(19, 73)
        Me.lstDependente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstDependente.Name = "lstDependente"
        Me.lstDependente.Size = New System.Drawing.Size(985, 328)
        Me.lstDependente.TabIndex = 44
        Me.lstDependente.UseCompatibleStateImageBehavior = False
        Me.lstDependente.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Codigo do Cliente"
        Me.codigo.Width = 100
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 150
        '
        'Parentesco
        '
        Me.Parentesco.Text = "Parentesco"
        Me.Parentesco.Width = 120
        '
        'cboParentesco
        '
        Me.cboParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboParentesco.FormattingEnabled = True
        Me.cboParentesco.Items.AddRange(New Object() {"Tio(a)", "Pai", "Mãe", "Filho(a)", "Primo(a)", "Afilhado(a)", "Sobrinho(a)", "Irmão", "Irmã", "Esposa", "Marido"})
        Me.cboParentesco.Location = New System.Drawing.Point(713, 39)
        Me.cboParentesco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboParentesco.Name = "cboParentesco"
        Me.cboParentesco.Size = New System.Drawing.Size(291, 25)
        Me.cboParentesco.TabIndex = 40
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentesco.Location = New System.Drawing.Point(709, 20)
        Me.lblParentesco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(80, 17)
        Me.lblParentesco.TabIndex = 45
        Me.lblParentesco.Text = "Parentesco"
        '
        'txtDependente
        '
        Me.txtDependente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDependente.Location = New System.Drawing.Point(93, 39)
        Me.txtDependente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDependente.Name = "txtDependente"
        Me.txtDependente.Size = New System.Drawing.Size(328, 23)
        Me.txtDependente.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nome"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1140, 644)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblDatacd As System.Windows.Forms.Label
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstDependente As ListView
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents Parentesco As ColumnHeader
    Friend WithEvents cboParentesco As ComboBox
    Friend WithEvents lblParentesco As Label
    Friend WithEvents btnRemover As Button
    Private WithEvents btnAdicionar As Button
    Friend WithEvents txtDependente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstEntidade As ListView
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCodDep As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mskDnascimento As MaskedTextBox
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbdMasculino As RadioButton
    Friend WithEvents rbdFeminino As RadioButton
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblDtNasc As Label
    Friend WithEvents mskCep As MaskedTextBox
    Friend WithEvents cboUf As ComboBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents lblUf As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents mskrg As MaskedTextBox
    Friend WithEvents mskcpf As MaskedTextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblRg As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents mkdTelefone As MaskedTextBox
    Friend WithEvents lblTelefone1 As Label
    Friend WithEvents mskCel As MaskedTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents mskTel2 As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblTelefone2 As Label
    Friend WithEvents mskcpf_dep As MaskedTextBox
    Friend WithEvents mskdtdatadep As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAlterarDep As Button
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
