<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetiraCaixa
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtValorAbrir = New System.Windows.Forms.TextBox()
        Me.lblValorAbrir = New System.Windows.Forms.Label()
        Me.txtCaixa = New System.Windows.Forms.TextBox()
        Me.lblCaixa = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 38)
        Me.Panel2.TabIndex = 41
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
        Me.Panel1.Size = New System.Drawing.Size(564, 92)
        Me.Panel1.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cboFuncionario)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.lblFuncionario)
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.txtValorAbrir)
        Me.GroupBox1.Controls.Add(Me.lblValorAbrir)
        Me.GroupBox1.Controls.Add(Me.txtCaixa)
        Me.GroupBox1.Controls.Add(Me.lblCaixa)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(532, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retirada"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmar.Location = New System.Drawing.Point(428, 92)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(77, 68)
        Me.btnConfirmar.TabIndex = 22
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtValorAbrir
        '
        Me.txtValorAbrir.Location = New System.Drawing.Point(33, 122)
        Me.txtValorAbrir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValorAbrir.Name = "txtValorAbrir"
        Me.txtValorAbrir.Size = New System.Drawing.Size(139, 22)
        Me.txtValorAbrir.TabIndex = 21
        '
        'lblValorAbrir
        '
        Me.lblValorAbrir.AutoSize = True
        Me.lblValorAbrir.Location = New System.Drawing.Point(29, 103)
        Me.lblValorAbrir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorAbrir.Name = "lblValorAbrir"
        Me.lblValorAbrir.Size = New System.Drawing.Size(112, 16)
        Me.lblValorAbrir.TabIndex = 20
        Me.lblValorAbrir.Text = "Valor do Abertura"
        '
        'txtCaixa
        '
        Me.txtCaixa.Enabled = False
        Me.txtCaixa.Location = New System.Drawing.Point(32, 63)
        Me.txtCaixa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCaixa.Name = "txtCaixa"
        Me.txtCaixa.Size = New System.Drawing.Size(73, 22)
        Me.txtCaixa.TabIndex = 15
        Me.txtCaixa.Text = "1"
        '
        'lblCaixa
        '
        Me.lblCaixa.AutoSize = True
        Me.lblCaixa.Location = New System.Drawing.Point(28, 43)
        Me.lblCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaixa.Name = "lblCaixa"
        Me.lblCaixa.Size = New System.Drawing.Size(41, 16)
        Me.lblCaixa.TabIndex = 14
        Me.lblCaixa.Text = "Caixa"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(393, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker1.TabIndex = 26
        '
        'cboFuncionario
        '
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(112, 63)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(271, 24)
        Me.cboFuncionario.TabIndex = 25
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(390, 43)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(36, 16)
        Me.lblData.TabIndex = 24
        Me.lblData.Text = "Data"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(109, 43)
        Me.lblFuncionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(77, 16)
        Me.lblFuncionario.TabIndex = 23
        Me.lblFuncionario.Text = "Funcionário"
        '
        'frmRetiraCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 303)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRetiraCaixa"
        Me.Text = "RetiraCaixa"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtValorAbrir As System.Windows.Forms.TextBox
    Friend WithEvents lblValorAbrir As System.Windows.Forms.Label
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cboFuncionario As ComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblFuncionario As Label
End Class
