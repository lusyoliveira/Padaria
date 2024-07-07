<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDependentes
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
        Me.grpDependentes = New System.Windows.Forms.GroupBox()
        Me.lstDependentes = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Parentesco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboParentesco = New System.Windows.Forms.ComboBox()
        Me.lblParentesco = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpDependentes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDependentes
        '
        Me.grpDependentes.Controls.Add(Me.lstDependentes)
        Me.grpDependentes.Controls.Add(Me.cboParentesco)
        Me.grpDependentes.Controls.Add(Me.lblParentesco)
        Me.grpDependentes.Controls.Add(Me.btnExcluir)
        Me.grpDependentes.Controls.Add(Me.btnAlterar)
        Me.grpDependentes.Controls.Add(Me.btnSalvar)
        Me.grpDependentes.Controls.Add(Me.txtNome)
        Me.grpDependentes.Controls.Add(Me.lblNome)
        Me.grpDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDependentes.Location = New System.Drawing.Point(12, 81)
        Me.grpDependentes.Name = "grpDependentes"
        Me.grpDependentes.Size = New System.Drawing.Size(518, 293)
        Me.grpDependentes.TabIndex = 0
        Me.grpDependentes.TabStop = False
        Me.grpDependentes.Tag = "0"
        Me.grpDependentes.Text = "Dependentes"
        '
        'lstDependentes
        '
        Me.lstDependentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome, Me.Parentesco})
        Me.lstDependentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDependentes.HideSelection = False
        Me.lstDependentes.Location = New System.Drawing.Point(20, 99)
        Me.lstDependentes.Name = "lstDependentes"
        Me.lstDependentes.Size = New System.Drawing.Size(410, 177)
        Me.lstDependentes.TabIndex = 7
        Me.lstDependentes.UseCompatibleStateImageBehavior = False
        Me.lstDependentes.View = System.Windows.Forms.View.Details
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
        Me.cboParentesco.Location = New System.Drawing.Point(309, 57)
        Me.cboParentesco.Name = "cboParentesco"
        Me.cboParentesco.Size = New System.Drawing.Size(121, 23)
        Me.cboParentesco.TabIndex = 3
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentesco.Location = New System.Drawing.Point(306, 32)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(76, 16)
        Me.lblParentesco.TabIndex = 37
        Me.lblParentesco.Text = "Parentesco"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(446, 221)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(53, 55)
        Me.btnExcluir.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(446, 160)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 55)
        Me.btnAlterar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(446, 99)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 55)
        Me.btnSalvar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(20, 58)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(247, 22)
        Me.txtNome.TabIndex = 0
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(17, 28)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 75)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 31)
        Me.Panel2.TabIndex = 39
        '
        'frmDependentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 387)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpDependentes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDependentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dependentes"
        Me.grpDependentes.ResumeLayout(False)
        Me.grpDependentes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDependentes As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cboParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents lblParentesco As System.Windows.Forms.Label
    Friend WithEvents lstDependentes As System.Windows.Forms.ListView
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents Parentesco As System.Windows.Forms.ColumnHeader
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
