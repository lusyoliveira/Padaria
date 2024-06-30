<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetiraCaixa
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.txtValorAbrir = New System.Windows.Forms.TextBox
        Me.lblValorAbrir = New System.Windows.Forms.Label
        Me.txtData = New System.Windows.Forms.TextBox
        Me.lblData = New System.Windows.Forms.Label
        Me.lblFuncionario = New System.Windows.Forms.Label
        Me.txtFuncionario = New System.Windows.Forms.TextBox
        Me.txtCaixa = New System.Windows.Forms.TextBox
        Me.lblCaixa = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 31)
        Me.Panel2.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 75)
        Me.Panel1.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.txtValorAbrir)
        Me.GroupBox1.Controls.Add(Me.lblValorAbrir)
        Me.GroupBox1.Controls.Add(Me.txtData)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.lblFuncionario)
        Me.GroupBox1.Controls.Add(Me.txtFuncionario)
        Me.GroupBox1.Controls.Add(Me.txtCaixa)
        Me.GroupBox1.Controls.Add(Me.lblCaixa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retirada"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(356, 90)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 36)
        Me.btnConfirmar.TabIndex = 22
        Me.btnConfirmar.Text = "Button1"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtValorAbrir
        '
        Me.txtValorAbrir.Location = New System.Drawing.Point(24, 106)
        Me.txtValorAbrir.Name = "txtValorAbrir"
        Me.txtValorAbrir.Size = New System.Drawing.Size(105, 20)
        Me.txtValorAbrir.TabIndex = 21
        '
        'lblValorAbrir
        '
        Me.lblValorAbrir.AutoSize = True
        Me.lblValorAbrir.Location = New System.Drawing.Point(21, 90)
        Me.lblValorAbrir.Name = "lblValorAbrir"
        Me.lblValorAbrir.Size = New System.Drawing.Size(89, 13)
        Me.lblValorAbrir.TabIndex = 20
        Me.lblValorAbrir.Text = "Valor do Abertura"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(160, 106)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(106, 20)
        Me.txtData.TabIndex = 19
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(157, 90)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 18
        Me.lblData.Text = "Data"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(102, 35)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(62, 13)
        Me.lblFuncionario.TabIndex = 17
        Me.lblFuncionario.Text = "Funcionário"
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Enabled = False
        Me.txtFuncionario.Location = New System.Drawing.Point(105, 51)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(326, 20)
        Me.txtFuncionario.TabIndex = 16
        '
        'txtCaixa
        '
        Me.txtCaixa.Enabled = False
        Me.txtCaixa.Location = New System.Drawing.Point(24, 51)
        Me.txtCaixa.Name = "txtCaixa"
        Me.txtCaixa.Size = New System.Drawing.Size(56, 20)
        Me.txtCaixa.TabIndex = 15
        Me.txtCaixa.Text = "1"
        '
        'lblCaixa
        '
        Me.lblCaixa.AutoSize = True
        Me.lblCaixa.Location = New System.Drawing.Point(21, 35)
        Me.lblCaixa.Name = "lblCaixa"
        Me.lblCaixa.Size = New System.Drawing.Size(33, 13)
        Me.lblCaixa.TabIndex = 14
        Me.lblCaixa.Text = "Caixa"
        '
        'RetiraCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 246)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RetiraCaixa"
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
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
End Class
