<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechaCaixa
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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpCaixaFechar = New System.Windows.Forms.GroupBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.txtValorFechar = New System.Windows.Forms.TextBox
        Me.lblValorFechar = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblData = New System.Windows.Forms.Label
        Me.lblFuncionario = New System.Windows.Forms.Label
        Me.txtFuncionario = New System.Windows.Forms.TextBox
        Me.txtCaixa = New System.Windows.Forms.TextBox
        Me.lblCaixa = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.grpCaixaFechar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 31)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 75)
        Me.Panel1.TabIndex = 10
        '
        'grpCaixaFechar
        '
        Me.grpCaixaFechar.Controls.Add(Me.btnConfirmar)
        Me.grpCaixaFechar.Controls.Add(Me.txtValorFechar)
        Me.grpCaixaFechar.Controls.Add(Me.lblValorFechar)
        Me.grpCaixaFechar.Controls.Add(Me.TextBox3)
        Me.grpCaixaFechar.Controls.Add(Me.lblData)
        Me.grpCaixaFechar.Controls.Add(Me.lblFuncionario)
        Me.grpCaixaFechar.Controls.Add(Me.txtFuncionario)
        Me.grpCaixaFechar.Controls.Add(Me.txtCaixa)
        Me.grpCaixaFechar.Controls.Add(Me.lblCaixa)
        Me.grpCaixaFechar.Location = New System.Drawing.Point(12, 90)
        Me.grpCaixaFechar.Name = "grpCaixaFechar"
        Me.grpCaixaFechar.Size = New System.Drawing.Size(451, 151)
        Me.grpCaixaFechar.TabIndex = 12
        Me.grpCaixaFechar.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(352, 81)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 36)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "Button1"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtValorFechar
        '
        Me.txtValorFechar.Location = New System.Drawing.Point(20, 97)
        Me.txtValorFechar.Name = "txtValorFechar"
        Me.txtValorFechar.Size = New System.Drawing.Size(105, 20)
        Me.txtValorFechar.TabIndex = 7
        '
        'lblValorFechar
        '
        Me.lblValorFechar.AutoSize = True
        Me.lblValorFechar.Location = New System.Drawing.Point(17, 81)
        Me.lblValorFechar.Name = "lblValorFechar"
        Me.lblValorFechar.Size = New System.Drawing.Size(108, 13)
        Me.lblValorFechar.TabIndex = 6
        Me.lblValorFechar.Text = "Valor do Fechamento"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(156, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(106, 20)
        Me.TextBox3.TabIndex = 5
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(153, 81)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(98, 26)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(62, 13)
        Me.lblFuncionario.TabIndex = 3
        Me.lblFuncionario.Text = "Funcionário"
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Location = New System.Drawing.Point(101, 42)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(326, 20)
        Me.txtFuncionario.TabIndex = 2
        '
        'txtCaixa
        '
        Me.txtCaixa.Enabled = False
        Me.txtCaixa.Location = New System.Drawing.Point(20, 42)
        Me.txtCaixa.Name = "txtCaixa"
        Me.txtCaixa.Size = New System.Drawing.Size(56, 20)
        Me.txtCaixa.TabIndex = 1
        Me.txtCaixa.Text = "1"
        '
        'lblCaixa
        '
        Me.lblCaixa.AutoSize = True
        Me.lblCaixa.Location = New System.Drawing.Point(17, 26)
        Me.lblCaixa.Name = "lblCaixa"
        Me.lblCaixa.Size = New System.Drawing.Size(33, 13)
        Me.lblCaixa.TabIndex = 0
        Me.lblCaixa.Text = "Caixa"
        '
        'frmFechaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 259)
        Me.Controls.Add(Me.grpCaixaFechar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFechaCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fechar Caixa"
        Me.Panel1.ResumeLayout(False)
        Me.grpCaixaFechar.ResumeLayout(False)
        Me.grpCaixaFechar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpCaixaFechar As System.Windows.Forms.GroupBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtValorFechar As System.Windows.Forms.TextBox
    Friend WithEvents lblValorFechar As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblData As System.Windows.Forms.Label
End Class
