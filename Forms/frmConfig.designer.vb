<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.grpConfig = New System.Windows.Forms.GroupBox()
        Me.chkEsconde = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.Padaria.My.Resources.Resources.document
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(344, 102)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 68)
        Me.btnAlterar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(236, 102)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 68)
        Me.btnSalvar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(33, 62)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(373, 26)
        Me.txtCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(29, 38)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 20)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente"
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.lblCliente)
        Me.grpConfig.Controls.Add(Me.txtCliente)
        Me.grpConfig.Controls.Add(Me.btnSalvar)
        Me.grpConfig.Controls.Add(Me.chkEsconde)
        Me.grpConfig.Controls.Add(Me.btnAlterar)
        Me.grpConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConfig.Location = New System.Drawing.Point(16, 100)
        Me.grpConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpConfig.Size = New System.Drawing.Size(437, 183)
        Me.grpConfig.TabIndex = 5
        Me.grpConfig.TabStop = False
        Me.grpConfig.Text = "Configurações"
        '
        'chkEsconde
        '
        Me.chkEsconde.AutoSize = True
        Me.chkEsconde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEsconde.Location = New System.Drawing.Point(33, 119)
        Me.chkEsconde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEsconde.Name = "chkEsconde"
        Me.chkEsconde.Size = New System.Drawing.Size(165, 24)
        Me.chkEsconde.TabIndex = 2
        Me.chkEsconde.Text = "Esconder Opções"
        Me.chkEsconde.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 92)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 38)
        Me.Panel2.TabIndex = 39
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 298)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents grpConfig As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkEsconde As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
