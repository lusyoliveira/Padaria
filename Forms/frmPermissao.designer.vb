<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissao
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPermissao = New System.Windows.Forms.ComboBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.grpPermissoes = New System.Windows.Forms.GroupBox()
        Me.clbPermissoes = New System.Windows.Forms.CheckedListBox()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalvarNivel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.grpPermissoes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(466, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Permissão"
        '
        'cboPermissao
        '
        Me.cboPermissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Location = New System.Drawing.Point(470, 102)
        Me.cboPermissao.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(247, 28)
        Me.cboPermissao.TabIndex = 1
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSalvar.Location = New System.Drawing.Point(804, 82)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Padaria.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExcluir.Location = New System.Drawing.Point(725, 82)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 68)
        Me.btnExcluir.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'grpPermissoes
        '
        Me.grpPermissoes.Controls.Add(Me.clbPermissoes)
        Me.grpPermissoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPermissoes.Location = New System.Drawing.Point(13, 176)
        Me.grpPermissoes.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPermissoes.Name = "grpPermissoes"
        Me.grpPermissoes.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPermissoes.Size = New System.Drawing.Size(941, 485)
        Me.grpPermissoes.TabIndex = 8
        Me.grpPermissoes.TabStop = False
        Me.grpPermissoes.Tag = "0"
        Me.grpPermissoes.Text = "Permissões de Usuários"
        '
        'clbPermissoes
        '
        Me.clbPermissoes.FormattingEnabled = True
        Me.clbPermissoes.Location = New System.Drawing.Point(7, 22)
        Me.clbPermissoes.Name = "clbPermissoes"
        Me.clbPermissoes.Size = New System.Drawing.Size(927, 446)
        Me.clbPermissoes.TabIndex = 65
        '
        'btnconsultar
        '
        Me.btnconsultar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconsultar.Location = New System.Drawing.Point(883, 82)
        Me.btnconsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(71, 68)
        Me.btnconsultar.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.btnconsultar, "Consultar")
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(393, 102)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(69, 28)
        Me.lblCodigo.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 44)
        Me.Panel1.TabIndex = 9
        '
        'btnSalvarNivel
        '
        Me.btnSalvarNivel.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvarNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvarNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSalvarNivel.Location = New System.Drawing.Point(276, 17)
        Me.btnSalvarNivel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvarNivel.Name = "btnSalvarNivel"
        Me.btnSalvarNivel.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvarNivel.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.btnSalvarNivel, "Salvar")
        Me.btnSalvarNivel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSalvarNivel)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 118)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nova Permissão"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Permissão"
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(6, 51)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(263, 22)
        Me.txtNivel.TabIndex = 0
        '
        'frmPermissao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 674)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPermissao)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpPermissoes)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPermissao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permissões"
        Me.grpPermissoes.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPermissao As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents grpPermissoes As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnconsultar As Button
    Friend WithEvents clbPermissoes As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalvarNivel As Button
    Friend WithEvents txtNivel As TextBox
End Class
