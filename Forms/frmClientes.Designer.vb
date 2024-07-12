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
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblDatacd = New System.Windows.Forms.Label()
        Me.txtNrficha = New System.Windows.Forms.TextBox()
        Me.lblNrficha = New System.Windows.Forms.Label()
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
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lstCliente = New System.Windows.Forms.ListView()
        Me.clCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clDtCad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clEndereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clBairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(783, 391)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Qtd Clientes Cadastrados"
        '
        'btnVerifica
        '
        Me.btnVerifica.BackgroundImage = Global.Padaria.My.Resources.Resources.guy_blue
        Me.btnVerifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerifica.Location = New System.Drawing.Point(735, 565)
        Me.btnVerifica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(71, 66)
        Me.btnVerifica.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnVerifica, "Verificar Número de Ficha")
        Me.btnVerifica.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Location = New System.Drawing.Point(607, 41)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(148, 24)
        Me.lblData.TabIndex = 33
        '
        'lblRegistro
        '
        Me.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegistro.Location = New System.Drawing.Point(992, 387)
        Me.lblRegistro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(86, 28)
        Me.lblRegistro.TabIndex = 36
        '
        'lblDatacd
        '
        Me.lblDatacd.AutoSize = True
        Me.lblDatacd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatacd.Location = New System.Drawing.Point(603, 16)
        Me.lblDatacd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatacd.Name = "lblDatacd"
        Me.lblDatacd.Size = New System.Drawing.Size(141, 20)
        Me.lblDatacd.TabIndex = 32
        Me.lblDatacd.Text = "Data de Cadastro"
        '
        'txtNrficha
        '
        Me.txtNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrficha.Location = New System.Drawing.Point(100, 40)
        Me.txtNrficha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNrficha.Name = "txtNrficha"
        Me.txtNrficha.Size = New System.Drawing.Size(144, 26)
        Me.txtNrficha.TabIndex = 0
        '
        'lblNrficha
        '
        Me.lblNrficha.AutoSize = True
        Me.lblNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrficha.Location = New System.Drawing.Point(96, 16)
        Me.lblNrficha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNrficha.Name = "lblNrficha"
        Me.lblNrficha.Size = New System.Drawing.Size(137, 20)
        Me.lblNrficha.TabIndex = 16
        Me.lblNrficha.Text = "Número da Ficha"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(374, 94)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(208, 26)
        Me.txtBairro.TabIndex = 6
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(347, 70)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(55, 20)
        Me.lblBairro.TabIndex = 19
        Me.lblBairro.Text = "Bairro"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(25, 94)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(341, 26)
        Me.txtEndereco.TabIndex = 3
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(22, 70)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(80, 20)
        Me.lblEndereco.TabIndex = 18
        Me.lblEndereco.Text = "Endereço"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(252, 40)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(347, 26)
        Me.txtNome.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(248, 16)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 20)
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
        Me.btnLimpar.Location = New System.Drawing.Point(656, 565)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnconsultar.Location = New System.Drawing.Point(568, 564)
        Me.btnconsultar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnSalvar.Location = New System.Drawing.Point(287, 564)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnExcluir.Location = New System.Drawing.Point(470, 564)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnAlterar.Location = New System.Drawing.Point(376, 564)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnRemover.Location = New System.Drawing.Point(1011, 246)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnAdicionar.Location = New System.Drawing.Point(1011, 170)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(71, 68)
        Me.btnAdicionar.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.btnAdicionar, "Salvar")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(595, 94)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(144, 26)
        Me.mkdTelefone.TabIndex = 12
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone1.Location = New System.Drawing.Point(590, 70)
        Me.lblTelefone1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(73, 20)
        Me.lblTelefone1.TabIndex = 34
        Me.lblTelefone1.Text = "Telefone"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1155, 92)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1155, 38)
        Me.Panel2.TabIndex = 38
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 99)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1110, 457)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Controls.Add(Me.lstCliente)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNrficha)
        Me.TabPage1.Controls.Add(Me.lblData)
        Me.TabPage1.Controls.Add(Me.lblRegistro)
        Me.TabPage1.Controls.Add(Me.lblDatacd)
        Me.TabPage1.Controls.Add(Me.txtNrficha)
        Me.TabPage1.Controls.Add(Me.mkdTelefone)
        Me.TabPage1.Controls.Add(Me.lblNome)
        Me.TabPage1.Controls.Add(Me.lblTelefone1)
        Me.TabPage1.Controls.Add(Me.lblEndereco)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.lblBairro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1102, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(25, 40)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 25)
        Me.lblCodigo.TabIndex = 56
        '
        'lstCliente
        '
        Me.lstCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clCodigo, Me.clNome, Me.clDtCad, Me.clEndereco, Me.clBairro, Me.clTelefone})
        Me.lstCliente.FullRowSelect = True
        Me.lstCliente.HideSelection = False
        Me.lstCliente.Location = New System.Drawing.Point(25, 128)
        Me.lstCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCliente.MultiSelect = False
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(1053, 244)
        Me.lstCliente.TabIndex = 38
        Me.lstCliente.Tag = "0"
        Me.lstCliente.UseCompatibleStateImageBehavior = False
        Me.lstCliente.View = System.Windows.Forms.View.Details
        '
        'clCodigo
        '
        Me.clCodigo.Text = "Código"
        Me.clCodigo.Width = 48
        '
        'clNome
        '
        Me.clNome.Text = "Nome"
        Me.clNome.Width = 177
        '
        'clDtCad
        '
        Me.clDtCad.Text = "Data Cadastro"
        Me.clDtCad.Width = 100
        '
        'clEndereco
        '
        Me.clEndereco.DisplayIndex = 4
        Me.clEndereco.Text = "Endereço"
        '
        'clBairro
        '
        Me.clBairro.DisplayIndex = 5
        Me.clBairro.Text = "Bairro"
        '
        'clTelefone
        '
        Me.clTelefone.DisplayIndex = 3
        Me.clTelefone.Text = "Telefone"
        Me.clTelefone.Width = 91
        '
        'TabPage2
        '
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
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1102, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dependentes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Código"
        '
        'lblCodDep
        '
        Me.lblCodDep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodDep.Location = New System.Drawing.Point(18, 38)
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
        Me.lstDependente.Location = New System.Drawing.Point(18, 73)
        Me.lstDependente.Margin = New System.Windows.Forms.Padding(4)
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
        Me.cboParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboParentesco.FormattingEnabled = True
        Me.cboParentesco.Items.AddRange(New Object() {"Tio(a)", "Pai", "Mãe", "Filho(a)", "Primo(a)", "Afilhado(a)", "Sobrinho(a)", "Irmão", "Irmã", "Esposa", "Marido"})
        Me.cboParentesco.Location = New System.Drawing.Point(429, 38)
        Me.cboParentesco.Margin = New System.Windows.Forms.Padding(4)
        Me.cboParentesco.Name = "cboParentesco"
        Me.cboParentesco.Size = New System.Drawing.Size(209, 26)
        Me.cboParentesco.TabIndex = 40
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentesco.Location = New System.Drawing.Point(425, 14)
        Me.lblParentesco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(94, 20)
        Me.lblParentesco.TabIndex = 45
        Me.lblParentesco.Text = "Parentesco"
        '
        'txtDependente
        '
        Me.txtDependente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDependente.Location = New System.Drawing.Point(93, 39)
        Me.txtDependente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDependente.Name = "txtDependente"
        Me.txtDependente.Size = New System.Drawing.Size(328, 26)
        Me.txtDependente.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nome"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 644)
        Me.Controls.Add(Me.btnVerifica)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents txtNrficha As System.Windows.Forms.TextBox
    Friend WithEvents lblNrficha As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblDatacd As System.Windows.Forms.Label
    Friend WithEvents btnVerifica As System.Windows.Forms.Button
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
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
    Friend WithEvents lstCliente As ListView
    Friend WithEvents clCodigo As ColumnHeader
    Friend WithEvents clNome As ColumnHeader
    Friend WithEvents clDtCad As ColumnHeader
    Friend WithEvents clTelefone As ColumnHeader
    Friend WithEvents clEndereco As ColumnHeader
    Friend WithEvents clBairro As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCodDep As Label
End Class
