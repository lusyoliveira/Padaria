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
        Me.components = New System.ComponentModel.Container
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.txtValorAbrir = New System.Windows.Forms.TextBox
        Me.lblValorAbrir = New System.Windows.Forms.Label
        Me.txtData = New System.Windows.Forms.TextBox
        Me.lblFuncionario = New System.Windows.Forms.Label
        Me.txtFuncionario = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblData = New System.Windows.Forms.Label
        Me.txtCaixa = New System.Windows.Forms.TextBox
        Me.lblCaixa = New System.Windows.Forms.Label
        Me.grpAbrirCaixa = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpAbrirCaixa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'txtValorAbrir
        '
        Me.txtValorAbrir.Location = New System.Drawing.Point(20, 97)
        Me.txtValorAbrir.Name = "txtValorAbrir"
        Me.txtValorAbrir.Size = New System.Drawing.Size(105, 20)
        Me.txtValorAbrir.TabIndex = 7
        '
        'lblValorAbrir
        '
        Me.lblValorAbrir.AutoSize = True
        Me.lblValorAbrir.Location = New System.Drawing.Point(17, 81)
        Me.lblValorAbrir.Name = "lblValorAbrir"
        Me.lblValorAbrir.Size = New System.Drawing.Size(89, 13)
        Me.lblValorAbrir.TabIndex = 6
        Me.lblValorAbrir.Text = "Valor do Abertura"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(156, 97)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(106, 20)
        Me.txtData.TabIndex = 5
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
        Me.txtFuncionario.Enabled = False
        Me.txtFuncionario.Location = New System.Drawing.Point(101, 42)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(326, 20)
        Me.txtFuncionario.TabIndex = 2
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
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(153, 81)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data"
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
        'grpAbrirCaixa
        '
        Me.grpAbrirCaixa.Controls.Add(Me.btnConfirmar)
        Me.grpAbrirCaixa.Controls.Add(Me.txtValorAbrir)
        Me.grpAbrirCaixa.Controls.Add(Me.lblValorAbrir)
        Me.grpAbrirCaixa.Controls.Add(Me.txtData)
        Me.grpAbrirCaixa.Controls.Add(Me.lblData)
        Me.grpAbrirCaixa.Controls.Add(Me.lblFuncionario)
        Me.grpAbrirCaixa.Controls.Add(Me.txtFuncionario)
        Me.grpAbrirCaixa.Controls.Add(Me.txtCaixa)
        Me.grpAbrirCaixa.Controls.Add(Me.lblCaixa)
        Me.grpAbrirCaixa.Location = New System.Drawing.Point(12, 95)
        Me.grpAbrirCaixa.Name = "grpAbrirCaixa"
        Me.grpAbrirCaixa.Size = New System.Drawing.Size(451, 151)
        Me.grpAbrirCaixa.TabIndex = 14
        Me.grpAbrirCaixa.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 75)
        Me.Panel1.TabIndex = 13
        '
        'frmAbrirCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 264)
        Me.Controls.Add(Me.grpAbrirCaixa)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtCaixa As System.Windows.Forms.TextBox
    Friend WithEvents lblCaixa As System.Windows.Forms.Label
    Friend WithEvents grpAbrirCaixa As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
