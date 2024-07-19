<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPermissao = New System.Windows.Forms.ComboBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpUsuarios = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.txtFuncionario = New System.Windows.Forms.TextBox()
        Me.lstUsuarios = New System.Windows.Forms.ListView()
        Me.funcionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.permissao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtUsuario.Location = New System.Drawing.Point(522, 68)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(197, 26)
        Me.txtUsuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(518, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(161, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Permissão"
        '
        'cboPermissao
        '
        Me.cboPermissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO LIMITADO", "VENDEDOR"})
        Me.cboPermissao.Location = New System.Drawing.Point(165, 118)
        Me.cboPermissao.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(356, 28)
        Me.cboPermissao.TabIndex = 4
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok1
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSalvar.Location = New System.Drawing.Point(229, 505)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAlterar.Location = New System.Drawing.Point(321, 505)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExcluir.Location = New System.Drawing.Point(407, 505)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSenha.Location = New System.Drawing.Point(28, 120)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(129, 26)
        Me.txtSenha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Senha"
        '
        'grpUsuarios
        '
        Me.grpUsuarios.Controls.Add(Me.Label7)
        Me.grpUsuarios.Controls.Add(Me.lblCodigo)
        Me.grpUsuarios.Controls.Add(Me.lblFuncionario)
        Me.grpUsuarios.Controls.Add(Me.txtFuncionario)
        Me.grpUsuarios.Controls.Add(Me.cboPermissao)
        Me.grpUsuarios.Controls.Add(Me.Label3)
        Me.grpUsuarios.Controls.Add(Me.Label2)
        Me.grpUsuarios.Controls.Add(Me.txtSenha)
        Me.grpUsuarios.Controls.Add(Me.Label1)
        Me.grpUsuarios.Controls.Add(Me.txtUsuario)
        Me.grpUsuarios.Controls.Add(Me.btnExcluir)
        Me.grpUsuarios.Controls.Add(Me.btnAlterar)
        Me.grpUsuarios.Controls.Add(Me.btnSalvar)
        Me.grpUsuarios.Controls.Add(Me.lstUsuarios)
        Me.grpUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpUsuarios.Location = New System.Drawing.Point(17, 100)
        Me.grpUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.grpUsuarios.Name = "grpUsuarios"
        Me.grpUsuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.grpUsuarios.Size = New System.Drawing.Size(727, 593)
        Me.grpUsuarios.TabIndex = 17
        Me.grpUsuarios.TabStop = False
        Me.grpUsuarios.Tag = "0"
        Me.grpUsuarios.Text = "Usuários"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(28, 66)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(95, 26)
        Me.lblCodigo.TabIndex = 62
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFuncionario.Location = New System.Drawing.Point(127, 43)
        Me.lblFuncionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(96, 20)
        Me.lblFuncionario.TabIndex = 19
        Me.lblFuncionario.Text = "Funcionário"
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFuncionario.Location = New System.Drawing.Point(131, 68)
        Me.txtFuncionario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(381, 26)
        Me.txtFuncionario.TabIndex = 1
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.usuario, Me.permissao, Me.funcionario})
        Me.lstUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lstUsuarios.FullRowSelect = True
        Me.lstUsuarios.HideSelection = False
        Me.lstUsuarios.Location = New System.Drawing.Point(28, 158)
        Me.lstUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.lstUsuarios.MultiSelect = False
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(669, 323)
        Me.lstUsuarios.TabIndex = 17
        Me.lstUsuarios.UseCompatibleStateImageBehavior = False
        Me.lstUsuarios.View = System.Windows.Forms.View.Details
        '
        'funcionario
        '
        Me.funcionario.Text = "Nome do Funcionário"
        Me.funcionario.Width = 200
        '
        'usuario
        '
        Me.usuario.Text = "Nome De Usuário"
        Me.usuario.Width = 160
        '
        'permissao
        '
        Me.permissao.Text = "Permissão"
        Me.permissao.Width = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 92)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 38)
        Me.Panel2.TabIndex = 39
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 710)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuários"
        Me.grpUsuarios.ResumeLayout(False)
        Me.grpUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPermissao As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListView
    Friend WithEvents usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents permissao As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents funcionario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Codigo As ColumnHeader
End Class
