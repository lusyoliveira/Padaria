<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.lblProduto2 = New System.Windows.Forms.Label()
        Me.lblValorUnit2 = New System.Windows.Forms.Label()
        Me.lblRecebido2 = New System.Windows.Forms.Label()
        Me.grpLocacao = New System.Windows.Forms.GroupBox()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.lblTroco2 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblTotalpagar = New System.Windows.Forms.Label()
        Me.lblTotalPagar2 = New System.Windows.Forms.Label()
        Me.lblRecebido = New System.Windows.Forms.Label()
        Me.lblValorUnit = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpLocacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProduto2
        '
        Me.lblProduto2.AutoSize = True
        Me.lblProduto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto2.Location = New System.Drawing.Point(264, 35)
        Me.lblProduto2.Name = "lblProduto2"
        Me.lblProduto2.Size = New System.Drawing.Size(54, 16)
        Me.lblProduto2.TabIndex = 15
        Me.lblProduto2.Text = "Produto"
        '
        'lblValorUnit2
        '
        Me.lblValorUnit2.AutoSize = True
        Me.lblValorUnit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUnit2.Location = New System.Drawing.Point(160, 104)
        Me.lblValorUnit2.Name = "lblValorUnit2"
        Me.lblValorUnit2.Size = New System.Drawing.Size(39, 16)
        Me.lblValorUnit2.TabIndex = 16
        Me.lblValorUnit2.Text = "Valor"
        '
        'lblRecebido2
        '
        Me.lblRecebido2.AutoSize = True
        Me.lblRecebido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebido2.Location = New System.Drawing.Point(280, 417)
        Me.lblRecebido2.Name = "lblRecebido2"
        Me.lblRecebido2.Size = New System.Drawing.Size(67, 16)
        Me.lblRecebido2.TabIndex = 19
        Me.lblRecebido2.Text = "Recebido"
        '
        'grpLocacao
        '
        Me.grpLocacao.Controls.Add(Me.lblTroco)
        Me.grpLocacao.Controls.Add(Me.lblTroco2)
        Me.grpLocacao.Controls.Add(Me.txtQuantidade)
        Me.grpLocacao.Controls.Add(Me.lblQuantidade)
        Me.grpLocacao.Controls.Add(Me.lblProduto)
        Me.grpLocacao.Controls.Add(Me.txtCodigo)
        Me.grpLocacao.Controls.Add(Me.lblCodigo)
        Me.grpLocacao.Controls.Add(Me.lblTotalpagar)
        Me.grpLocacao.Controls.Add(Me.lblTotalPagar2)
        Me.grpLocacao.Controls.Add(Me.lblRecebido)
        Me.grpLocacao.Controls.Add(Me.lblValorUnit)
        Me.grpLocacao.Controls.Add(Me.btnPagar)
        Me.grpLocacao.Controls.Add(Me.lblRecebido2)
        Me.grpLocacao.Controls.Add(Me.lblValorUnit2)
        Me.grpLocacao.Controls.Add(Me.lblProduto2)
        Me.grpLocacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocacao.Location = New System.Drawing.Point(12, 81)
        Me.grpLocacao.Name = "grpLocacao"
        Me.grpLocacao.Size = New System.Drawing.Size(680, 500)
        Me.grpLocacao.TabIndex = 14
        Me.grpLocacao.TabStop = False
        Me.grpLocacao.Tag = "0"
        Me.grpLocacao.Text = "Vendas"
        '
        'lblTroco
        '
        Me.lblTroco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.Location = New System.Drawing.Point(402, 444)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(79, 31)
        Me.lblTroco.TabIndex = 41
        Me.lblTroco.Text = "R$ 0,00"
        '
        'lblTroco2
        '
        Me.lblTroco2.AutoSize = True
        Me.lblTroco2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco2.Location = New System.Drawing.Point(399, 417)
        Me.lblTroco2.Name = "lblTroco2"
        Me.lblTroco2.Size = New System.Drawing.Size(43, 16)
        Me.lblTroco2.TabIndex = 40
        Me.lblTroco2.Text = "Troco"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(28, 134)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(80, 26)
        Me.txtQuantidade.TabIndex = 39
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(25, 104)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(77, 16)
        Me.lblQuantidade.TabIndex = 38
        Me.lblQuantidade.Text = "Quantidade"
        '
        'lblProduto
        '
        Me.lblProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduto.Location = New System.Drawing.Point(267, 58)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(383, 26)
        Me.lblProduto.TabIndex = 36
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(28, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(216, 26)
        Me.txtCodigo.TabIndex = 35
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCodigo.Location = New System.Drawing.Point(24, 35)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 34
        Me.lblCodigo.Text = "Código"
        '
        'lblTotalpagar
        '
        Me.lblTotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalpagar.Location = New System.Drawing.Point(150, 444)
        Me.lblTotalpagar.Name = "lblTotalpagar"
        Me.lblTotalpagar.Size = New System.Drawing.Size(77, 31)
        Me.lblTotalpagar.TabIndex = 33
        Me.lblTotalpagar.Text = "R$ 0,00"
        '
        'lblTotalPagar2
        '
        Me.lblTotalPagar2.AutoSize = True
        Me.lblTotalPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagar2.Location = New System.Drawing.Point(147, 417)
        Me.lblTotalPagar2.Name = "lblTotalPagar2"
        Me.lblTotalPagar2.Size = New System.Drawing.Size(89, 16)
        Me.lblTotalPagar2.TabIndex = 32
        Me.lblTotalPagar2.Text = "Total a Pagar"
        '
        'lblRecebido
        '
        Me.lblRecebido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebido.Location = New System.Drawing.Point(283, 444)
        Me.lblRecebido.Name = "lblRecebido"
        Me.lblRecebido.Size = New System.Drawing.Size(79, 31)
        Me.lblRecebido.TabIndex = 28
        Me.lblRecebido.Text = "R$ 0,00"
        '
        'lblValorUnit
        '
        Me.lblValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValorUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUnit.Location = New System.Drawing.Point(163, 133)
        Me.lblValorUnit.Name = "lblValorUnit"
        Me.lblValorUnit.Size = New System.Drawing.Size(81, 26)
        Me.lblValorUnit.TabIndex = 26
        Me.lblValorUnit.Text = "R$ 0,00"
        '
        'btnPagar
        '
        Me.btnPagar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(511, 426)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(53, 55)
        Me.btnPagar.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnPagar, "Pagar")
        Me.btnPagar.UseVisualStyleBackColor = True
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
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
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
        Me.Panel1.Size = New System.Drawing.Size(705, 75)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 31)
        Me.Panel2.TabIndex = 39
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 601)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpLocacao)
        Me.MaximizeBox = False
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        Me.grpLocacao.ResumeLayout(False)
        Me.grpLocacao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProduto2 As System.Windows.Forms.Label
    Friend WithEvents lblValorUnit2 As System.Windows.Forms.Label
    Friend WithEvents lblRecebido2 As System.Windows.Forms.Label
    Friend WithEvents grpLocacao As System.Windows.Forms.GroupBox
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblValorUnit As System.Windows.Forms.Label
    Friend WithEvents lblRecebido As System.Windows.Forms.Label
    Friend WithEvents lblTotalpagar As System.Windows.Forms.Label
    Friend WithEvents lblTotalPagar2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblTroco As System.Windows.Forms.Label
    Friend WithEvents lblTroco2 As System.Windows.Forms.Label
End Class
