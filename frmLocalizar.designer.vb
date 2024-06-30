<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalizar))
        Me.grpLocalizar = New System.Windows.Forms.GroupBox
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.btnLocalizar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblItens = New System.Windows.Forms.Label
        Me.lstLocalizar = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.nome = New System.Windows.Forms.ColumnHeader
        Me.dados = New System.Windows.Forms.ColumnHeader
        Me.txtLocalizar = New System.Windows.Forms.TextBox
        Me.cboItens = New System.Windows.Forms.ComboBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grpLocalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLocalizar
        '
        Me.grpLocalizar.Controls.Add(Me.btnExcluir)
        Me.grpLocalizar.Controls.Add(Me.btnAlterar)
        Me.grpLocalizar.Controls.Add(Me.btnSalvar)
        Me.grpLocalizar.Controls.Add(Me.btnFechar)
        Me.grpLocalizar.Controls.Add(Me.btnLocalizar)
        Me.grpLocalizar.Controls.Add(Me.Label1)
        Me.grpLocalizar.Controls.Add(Me.lblItens)
        Me.grpLocalizar.Controls.Add(Me.lstLocalizar)
        Me.grpLocalizar.Controls.Add(Me.txtLocalizar)
        Me.grpLocalizar.Controls.Add(Me.cboItens)
        Me.grpLocalizar.Location = New System.Drawing.Point(14, 81)
        Me.grpLocalizar.Name = "grpLocalizar"
        Me.grpLocalizar.Size = New System.Drawing.Size(423, 272)
        Me.grpLocalizar.TabIndex = 11
        Me.grpLocalizar.TabStop = False
        Me.grpLocalizar.Text = "Localizar"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Location = New System.Drawing.Point(254, 201)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(53, 55)
        Me.btnExcluir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterar.Location = New System.Drawing.Point(178, 201)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 55)
        Me.btnAlterar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.Location = New System.Drawing.Point(111, 201)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 55)
        Me.btnSalvar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Adicionar Registro não Encontrado")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.Location = New System.Drawing.Point(326, 201)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(53, 55)
        Me.btnFechar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnFechar, "Fechar")
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLocalizar.Location = New System.Drawing.Point(38, 201)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(53, 55)
        Me.btnLocalizar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnLocalizar, "Localizar")
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Digite um  número ou nome:"
        '
        'lblItens
        '
        Me.lblItens.AutoSize = True
        Me.lblItens.Location = New System.Drawing.Point(21, 22)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(48, 13)
        Me.lblItens.TabIndex = 8
        Me.lblItens.Text = "Tabelas:"
        '
        'lstLocalizar
        '
        Me.lstLocalizar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome, Me.dados})
        Me.lstLocalizar.FullRowSelect = True
        Me.lstLocalizar.Location = New System.Drawing.Point(24, 77)
        Me.lstLocalizar.MultiSelect = False
        Me.lstLocalizar.Name = "lstLocalizar"
        Me.lstLocalizar.Size = New System.Drawing.Size(374, 118)
        Me.lstLocalizar.TabIndex = 10
        Me.lstLocalizar.UseCompatibleStateImageBehavior = False
        Me.lstLocalizar.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Código"
        '
        'nome
        '
        Me.nome.Text = "Dado Localizado"
        Me.nome.Width = 180
        '
        'dados
        '
        Me.dados.Text = "Dados Extras"
        Me.dados.Width = 100
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(176, 38)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(222, 20)
        Me.txtLocalizar.TabIndex = 1
        '
        'cboItens
        '
        Me.cboItens.FormattingEnabled = True
        Me.cboItens.Items.AddRange(New Object() {"Clientes", "Produtos", "Funcionários", "Fornecedores", "Estoque"})
        Me.cboItens.Location = New System.Drawing.Point(24, 38)
        Me.cboItens.Name = "cboItens"
        Me.cboItens.Size = New System.Drawing.Size(121, 21)
        Me.cboItens.TabIndex = 0
        Me.cboItens.Text = "Selecione..."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 75)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 31)
        Me.Panel2.TabIndex = 39
        '
        'frmLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 365)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpLocalizar)
        Me.MaximizeBox = False
        Me.Name = "frmLocalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar..."
        Me.grpLocalizar.ResumeLayout(False)
        Me.grpLocalizar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLocalizar As System.Windows.Forms.GroupBox
    Friend WithEvents cboItens As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItens As System.Windows.Forms.Label
    Friend WithEvents lstLocalizar As System.Windows.Forms.ListView
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents dados As System.Windows.Forms.ColumnHeader
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
