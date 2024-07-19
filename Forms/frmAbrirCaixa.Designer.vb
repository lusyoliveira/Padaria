<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirCaixa
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
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtValorAbrir = New System.Windows.Forms.TextBox()
        Me.lblValorAbrir = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtCaixa = New System.Windows.Forms.TextBox()
        Me.lblCaixa = New System.Windows.Forms.Label()
        Me.grpAbrirCaixa = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpAbrirCaixa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(400, 81)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 44)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtValorAbrir
        '
        Me.txtValorAbrir.Location = New System.Drawing.Point(27, 100)
        Me.txtValorAbrir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorAbrir.Name = "txtValorAbrir"
        Me.txtValorAbrir.Size = New System.Drawing.Size(139, 22)
        Me.txtValorAbrir.TabIndex = 7
        '
        'lblValorAbrir
        '
        Me.lblValorAbrir.AutoSize = True
        Me.lblValorAbrir.Location = New System.Drawing.Point(23, 81)
        Me.lblValorAbrir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorAbrir.Name = "lblValorAbrir"
        Me.lblValorAbrir.Size = New System.Drawing.Size(112, 16)
        Me.lblValorAbrir.TabIndex = 6
        Me.lblValorAbrir.Text = "Valor do Abertura"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(104, 32)
        Me.lblFuncionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(77, 16)
        Me.lblFuncionario.TabIndex = 3
        Me.lblFuncionario.Text = "Funcionário"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 38)
        Me.Panel2.TabIndex = 11
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(385, 32)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(36, 16)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data"
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
        'grpAbrirCaixa
        '
        Me.grpAbrirCaixa.Controls.Add(Me.DateTimePicker1)
        Me.grpAbrirCaixa.Controls.Add(Me.cboFuncionario)
        Me.grpAbrirCaixa.Controls.Add(Me.btnConfirmar)
        Me.grpAbrirCaixa.Controls.Add(Me.txtValorAbrir)
        Me.grpAbrirCaixa.Controls.Add(Me.lblValorAbrir)
        Me.grpAbrirCaixa.Controls.Add(Me.lblData)
        Me.grpAbrirCaixa.Controls.Add(Me.lblFuncionario)
        Me.grpAbrirCaixa.Controls.Add(Me.txtCaixa)
        Me.grpAbrirCaixa.Controls.Add(Me.lblCaixa)
        Me.grpAbrirCaixa.Location = New System.Drawing.Point(16, 117)
        Me.grpAbrirCaixa.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAbrirCaixa.Name = "grpAbrirCaixa"
        Me.grpAbrirCaixa.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAbrirCaixa.Size = New System.Drawing.Size(525, 159)
        Me.grpAbrirCaixa.TabIndex = 14
        Me.grpAbrirCaixa.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(388, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker1.TabIndex = 15
        '
        'cboFuncionario
        '
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(107, 52)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(271, 24)
        Me.cboFuncionario.TabIndex = 14
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
        Me.Panel1.Size = New System.Drawing.Size(555, 92)
        Me.Panel1.TabIndex = 13
        '
        'frmAbrirCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 289)
        Me.Controls.Add(Me.grpAbrirCaixa)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAbrirCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir Caixa"
        Me.grpAbrirCaixa.ResumeLayout(False)
        Me.grpAbrirCaixa.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtValorAbrir As System.Windows.Forms.TextBox
    Friend WithEvents lblValorAbrir As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
    Friend WithEvents grpAbrirCaixa As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cboFuncionario As ComboBox
End Class
