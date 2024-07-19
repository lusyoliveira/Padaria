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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpCaixaFechar = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtValorFechar = New System.Windows.Forms.TextBox()
        Me.lblValorFechar = New System.Windows.Forms.Label()
        Me.txtCaixa = New System.Windows.Forms.TextBox()
        Me.lblCaixa = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.grpCaixaFechar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 38)
        Me.Panel2.TabIndex = 11
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
        Me.Panel1.Size = New System.Drawing.Size(558, 92)
        Me.Panel1.TabIndex = 10
        '
        'grpCaixaFechar
        '
        Me.grpCaixaFechar.Controls.Add(Me.DateTimePicker1)
        Me.grpCaixaFechar.Controls.Add(Me.cboFuncionario)
        Me.grpCaixaFechar.Controls.Add(Me.lblData)
        Me.grpCaixaFechar.Controls.Add(Me.lblFuncionario)
        Me.grpCaixaFechar.Controls.Add(Me.btnConfirmar)
        Me.grpCaixaFechar.Controls.Add(Me.txtValorFechar)
        Me.grpCaixaFechar.Controls.Add(Me.lblValorFechar)
        Me.grpCaixaFechar.Controls.Add(Me.txtCaixa)
        Me.grpCaixaFechar.Controls.Add(Me.lblCaixa)
        Me.grpCaixaFechar.Location = New System.Drawing.Point(16, 111)
        Me.grpCaixaFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCaixaFechar.Name = "grpCaixaFechar"
        Me.grpCaixaFechar.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCaixaFechar.Size = New System.Drawing.Size(523, 178)
        Me.grpCaixaFechar.TabIndex = 12
        Me.grpCaixaFechar.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(400, 86)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 44)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtValorFechar
        '
        Me.txtValorFechar.Location = New System.Drawing.Point(28, 97)
        Me.txtValorFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorFechar.Name = "txtValorFechar"
        Me.txtValorFechar.Size = New System.Drawing.Size(139, 22)
        Me.txtValorFechar.TabIndex = 7
        '
        'lblValorFechar
        '
        Me.lblValorFechar.AutoSize = True
        Me.lblValorFechar.Location = New System.Drawing.Point(24, 78)
        Me.lblValorFechar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorFechar.Name = "lblValorFechar"
        Me.lblValorFechar.Size = New System.Drawing.Size(136, 16)
        Me.lblValorFechar.TabIndex = 6
        Me.lblValorFechar.Text = "Valor do Fechamento"
        '
        'txtCaixa
        '
        Me.txtCaixa.Enabled = False
        Me.txtCaixa.Location = New System.Drawing.Point(27, 52)
        Me.txtCaixa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCaixa.Name = "txtCaixa"
        Me.txtCaixa.Size = New System.Drawing.Size(73, 22)
        Me.txtCaixa.TabIndex = 1
        Me.txtCaixa.Text = "1"
        '
        'lblCaixa
        '
        Me.lblCaixa.AutoSize = True
        Me.lblCaixa.Location = New System.Drawing.Point(23, 32)
        Me.lblCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaixa.Name = "lblCaixa"
        Me.lblCaixa.Size = New System.Drawing.Size(41, 16)
        Me.lblCaixa.TabIndex = 0
        Me.lblCaixa.Text = "Caixa"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(388, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker1.TabIndex = 19
        '
        'cboFuncionario
        '
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(107, 50)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(271, 24)
        Me.cboFuncionario.TabIndex = 18
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(385, 30)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(36, 16)
        Me.lblData.TabIndex = 17
        Me.lblData.Text = "Data"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(104, 30)
        Me.lblFuncionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(77, 16)
        Me.lblFuncionario.TabIndex = 16
        Me.lblFuncionario.Text = "Funcionário"
        '
        'frmFechaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 307)
        Me.Controls.Add(Me.grpCaixaFechar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtValorFechar As System.Windows.Forms.TextBox
    Friend WithEvents lblValorFechar As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cboFuncionario As ComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblFuncionario As Label
End Class
