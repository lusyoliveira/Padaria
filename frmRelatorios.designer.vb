<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.cboConsulta = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.lblGerando = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.lblAviso = New System.Windows.Forms.Label
        Me.lblTabelas = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.grpFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Location = New System.Drawing.Point(406, 166)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 33)
        Me.btnImprimir.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Gerar Relatório")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'cboConsulta
        '
        Me.cboConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsulta.FormattingEnabled = True
        Me.cboConsulta.Items.AddRange(New Object() {"Caixa", "Clientes", "Estoque", "Fornecedores", "Produtos", "Dependentes", "Login"})
        Me.cboConsulta.Location = New System.Drawing.Point(305, 116)
        Me.cboConsulta.Name = "cboConsulta"
        Me.cboConsulta.Size = New System.Drawing.Size(210, 23)
        Me.cboConsulta.TabIndex = 6
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Gerar Relatório"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 31)
        Me.Panel2.TabIndex = 11
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(23, 113)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(253, 26)
        Me.txtFiltro.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 75)
        Me.Panel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.lblGerando)
        Me.grpFiltro.Controls.Add(Me.ProgressBar1)
        Me.grpFiltro.Controls.Add(Me.lblFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAviso)
        Me.grpFiltro.Controls.Add(Me.lblTabelas)
        Me.grpFiltro.Controls.Add(Me.cboConsulta)
        Me.grpFiltro.Controls.Add(Me.btnImprimir)
        Me.grpFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltro.Location = New System.Drawing.Point(12, 81)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(536, 267)
        Me.grpFiltro.TabIndex = 12
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Filtros"
        '
        'lblGerando
        '
        Me.lblGerando.AutoSize = True
        Me.lblGerando.Location = New System.Drawing.Point(6, 205)
        Me.lblGerando.Name = "lblGerando"
        Me.lblGerando.Size = New System.Drawing.Size(84, 20)
        Me.lblGerando.TabIndex = 16
        Me.lblGerando.Text = "Gerando..."
        Me.lblGerando.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 228)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(524, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(19, 90)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(44, 20)
        Me.lblFiltro.TabIndex = 14
        Me.lblFiltro.Text = "Filtro"
        '
        'lblAviso
        '
        Me.lblAviso.Location = New System.Drawing.Point(19, 32)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(496, 51)
        Me.lblAviso.TabIndex = 8
        Me.lblAviso.Text = "Digite o que você deseja localizar e em seguida selecione a tabela desejada. Um r" & _
            "elatório é gerado com apenas com os dados do filtro."
        '
        'lblTabelas
        '
        Me.lblTabelas.AutoSize = True
        Me.lblTabelas.Location = New System.Drawing.Point(301, 90)
        Me.lblTabelas.Name = "lblTabelas"
        Me.lblTabelas.Size = New System.Drawing.Size(65, 20)
        Me.lblTabelas.TabIndex = 7
        Me.lblTabelas.Text = "Tabelas"
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 359)
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "frmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerador de Relatórios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cboConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents lblTabelas As System.Windows.Forms.Label
    Friend WithEvents lblAviso As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGerando As System.Windows.Forms.Label

End Class
