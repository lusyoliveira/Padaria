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
        Me.grpDados = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblDatacd = New System.Windows.Forms.Label()
        Me.txtNrficha = New System.Windows.Forms.TextBox()
        Me.lblNrficha = New System.Windows.Forms.Label()
        Me.lblDependentes = New System.Windows.Forms.Label()
        Me.lstDependentes = New System.Windows.Forms.ListBox()
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
        Me.grpClientes = New System.Windows.Forms.GroupBox()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.btnDependentes = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.grpDados.SuspendLayout()
        Me.grpClientes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDados
        '
        Me.grpDados.Controls.Add(Me.Label1)
        Me.grpDados.Controls.Add(Me.btnVerifica)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblRegistro)
        Me.grpDados.Controls.Add(Me.lblDatacd)
        Me.grpDados.Controls.Add(Me.txtNrficha)
        Me.grpDados.Controls.Add(Me.lblNrficha)
        Me.grpDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDados.Location = New System.Drawing.Point(13, 78)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Size = New System.Drawing.Size(584, 81)
        Me.grpDados.TabIndex = 29
        Me.grpDados.TabStop = False
        Me.grpDados.Tag = "0"
        Me.grpDados.Text = "Dados do Cadastro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Qtd Clientes Cadastrados"
        '
        'lblData
        '
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Location = New System.Drawing.Point(158, 47)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(111, 20)
        Me.lblData.TabIndex = 33
        '
        'lblRegistro
        '
        Me.lblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegistro.Location = New System.Drawing.Point(308, 44)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(154, 23)
        Me.lblRegistro.TabIndex = 36
        '
        'lblDatacd
        '
        Me.lblDatacd.AutoSize = True
        Me.lblDatacd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatacd.Location = New System.Drawing.Point(155, 22)
        Me.lblDatacd.Name = "lblDatacd"
        Me.lblDatacd.Size = New System.Drawing.Size(113, 16)
        Me.lblDatacd.TabIndex = 32
        Me.lblDatacd.Text = "Data de Cadastro"
        '
        'txtNrficha
        '
        Me.txtNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrficha.Location = New System.Drawing.Point(19, 45)
        Me.txtNrficha.Name = "txtNrficha"
        Me.txtNrficha.Size = New System.Drawing.Size(109, 22)
        Me.txtNrficha.TabIndex = 0
        '
        'lblNrficha
        '
        Me.lblNrficha.AutoSize = True
        Me.lblNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrficha.Location = New System.Drawing.Point(17, 22)
        Me.lblNrficha.Name = "lblNrficha"
        Me.lblNrficha.Size = New System.Drawing.Size(110, 16)
        Me.lblNrficha.TabIndex = 16
        Me.lblNrficha.Text = "Número da Ficha"
        '
        'lblDependentes
        '
        Me.lblDependentes.AutoSize = True
        Me.lblDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDependentes.Location = New System.Drawing.Point(333, 86)
        Me.lblDependentes.Name = "lblDependentes"
        Me.lblDependentes.Size = New System.Drawing.Size(82, 16)
        Me.lblDependentes.TabIndex = 27
        Me.lblDependentes.Text = "Dependetes"
        '
        'lstDependentes
        '
        Me.lstDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDependentes.FormattingEnabled = True
        Me.lstDependentes.ItemHeight = 16
        Me.lstDependentes.Location = New System.Drawing.Point(336, 111)
        Me.lstDependentes.Name = "lstDependentes"
        Me.lstDependentes.Size = New System.Drawing.Size(230, 68)
        Me.lstDependentes.TabIndex = 31
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(20, 111)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(157, 22)
        Me.txtBairro.TabIndex = 6
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(18, 86)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 19
        Me.lblBairro.Text = "Bairro"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(309, 48)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(257, 22)
        Me.txtEndereco.TabIndex = 3
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(306, 22)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 18
        Me.lblEndereco.Text = "Endereço"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(21, 48)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(261, 22)
        Me.txtNome.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(18, 22)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
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
        Me.btnLimpar.Location = New System.Drawing.Point(448, 376)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(53, 54)
        Me.btnLimpar.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.btnLimpar, "Limpar Campos")
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'grpClientes
        '
        Me.grpClientes.Controls.Add(Me.lblNome)
        Me.grpClientes.Controls.Add(Me.mkdTelefone)
        Me.grpClientes.Controls.Add(Me.txtBairro)
        Me.grpClientes.Controls.Add(Me.lblTelefone1)
        Me.grpClientes.Controls.Add(Me.lblBairro)
        Me.grpClientes.Controls.Add(Me.txtEndereco)
        Me.grpClientes.Controls.Add(Me.lblDependentes)
        Me.grpClientes.Controls.Add(Me.lblEndereco)
        Me.grpClientes.Controls.Add(Me.txtNome)
        Me.grpClientes.Controls.Add(Me.lstDependentes)
        Me.grpClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpClientes.Location = New System.Drawing.Point(12, 165)
        Me.grpClientes.Name = "grpClientes"
        Me.grpClientes.Size = New System.Drawing.Size(584, 189)
        Me.grpClientes.TabIndex = 30
        Me.grpClientes.TabStop = False
        Me.grpClientes.Text = "Dados Cliente"
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdTelefone.Location = New System.Drawing.Point(204, 111)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(109, 22)
        Me.mkdTelefone.TabIndex = 12
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone1.Location = New System.Drawing.Point(201, 86)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(61, 16)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 75)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(609, 31)
        Me.Panel2.TabIndex = 38
        '
        'btnconsultar
        '
        Me.btnconsultar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconsultar.Location = New System.Drawing.Point(382, 375)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(53, 55)
        Me.btnconsultar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Consultar")
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'btnVerifica
        '
        Me.btnVerifica.BackgroundImage = Global.Padaria.My.Resources.Resources.guy_blue
        Me.btnVerifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerifica.Location = New System.Drawing.Point(512, 20)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(53, 55)
        Me.btnVerifica.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnVerifica, "Verificar Número de Ficha")
        Me.btnVerifica.UseVisualStyleBackColor = True
        '
        'btnDependentes
        '
        Me.btnDependentes.BackgroundImage = Global.Padaria.My.Resources.Resources.people
        Me.btnDependentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDependentes.Location = New System.Drawing.Point(110, 375)
        Me.btnDependentes.Name = "btnDependentes"
        Me.btnDependentes.Size = New System.Drawing.Size(53, 55)
        Me.btnDependentes.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnDependentes, "Adicionar Dependente")
        Me.btnDependentes.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Location = New System.Drawing.Point(171, 375)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 55)
        Me.btnSalvar.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Location = New System.Drawing.Point(308, 375)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(53, 55)
        Me.btnExcluir.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterar.Location = New System.Drawing.Point(238, 375)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 55)
        Me.btnAlterar.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 445)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.grpClientes)
        Me.Controls.Add(Me.grpDados)
        Me.Controls.Add(Me.btnDependentes)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.grpClientes.ResumeLayout(False)
        Me.grpClientes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDados As System.Windows.Forms.GroupBox
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
    Friend WithEvents btnDependentes As System.Windows.Forms.Button
    Friend WithEvents lblDependentes As System.Windows.Forms.Label
    Friend WithEvents lstDependentes As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblDatacd As System.Windows.Forms.Label
    Friend WithEvents grpClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerifica As System.Windows.Forms.Button
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
