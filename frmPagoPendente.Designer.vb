<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoPendente
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
        Me.grpPagamento = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblTotalPagar2 = New System.Windows.Forms.Label()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.cbxPago = New System.Windows.Forms.CheckBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblCliente2 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblNrFicha = New System.Windows.Forms.Label()
        Me.txtNrficha = New System.Windows.Forms.TextBox()
        Me.lstPagamento = New System.Windows.Forms.ListView()
        Me.NrFicha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dependente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.grpPagamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 30)
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
        Me.Panel1.Size = New System.Drawing.Size(834, 75)
        Me.Panel1.TabIndex = 40
        '
        'grpPagamento
        '
        Me.grpPagamento.Controls.Add(Me.btnConsultar)
        Me.grpPagamento.Controls.Add(Me.lblTotalPagar2)
        Me.grpPagamento.Controls.Add(Me.lblTotalPagar)
        Me.grpPagamento.Controls.Add(Me.cbxPago)
        Me.grpPagamento.Controls.Add(Me.btnPagar)
        Me.grpPagamento.Controls.Add(Me.lblCliente2)
        Me.grpPagamento.Controls.Add(Me.lblClientes)
        Me.grpPagamento.Controls.Add(Me.lblNrFicha)
        Me.grpPagamento.Controls.Add(Me.txtNrficha)
        Me.grpPagamento.Controls.Add(Me.lstPagamento)
        Me.grpPagamento.Location = New System.Drawing.Point(12, 81)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Size = New System.Drawing.Size(809, 498)
        Me.grpPagamento.TabIndex = 41
        Me.grpPagamento.TabStop = False
        Me.grpPagamento.Tag = "0"
        Me.grpPagamento.Text = "Pendência"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultar.Location = New System.Drawing.Point(562, 32)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(53, 55)
        Me.btnConsultar.TabIndex = 100
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblTotalPagar2
        '
        Me.lblTotalPagar2.AutoSize = True
        Me.lblTotalPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalPagar2.Location = New System.Drawing.Point(286, 430)
        Me.lblTotalPagar2.Name = "lblTotalPagar2"
        Me.lblTotalPagar2.Size = New System.Drawing.Size(82, 17)
        Me.lblTotalPagar2.TabIndex = 99
        Me.lblTotalPagar2.Text = "Total Pagar"
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPagar.Location = New System.Drawing.Point(275, 457)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(106, 24)
        Me.lblTotalPagar.TabIndex = 98
        Me.lblTotalPagar.Text = "R$ 0,00"
        Me.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxPago
        '
        Me.cbxPago.AutoSize = True
        Me.cbxPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPago.Location = New System.Drawing.Point(417, 454)
        Me.cbxPago.Name = "cbxPago"
        Me.cbxPago.Size = New System.Drawing.Size(59, 20)
        Me.cbxPago.TabIndex = 88
        Me.cbxPago.Text = "Pago"
        Me.cbxPago.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Location = New System.Drawing.Point(525, 430)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(53, 55)
        Me.btnPagar.TabIndex = 85
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lblCliente2
        '
        Me.lblCliente2.AutoSize = True
        Me.lblCliente2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCliente2.Location = New System.Drawing.Point(144, 26)
        Me.lblCliente2.Name = "lblCliente2"
        Me.lblCliente2.Size = New System.Drawing.Size(51, 17)
        Me.lblCliente2.TabIndex = 79
        Me.lblCliente2.Text = "Cliente"
        '
        'lblClientes
        '
        Me.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientes.Location = New System.Drawing.Point(147, 52)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(361, 23)
        Me.lblClientes.TabIndex = 78
        '
        'lblNrFicha
        '
        Me.lblNrFicha.AutoSize = True
        Me.lblNrFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNrFicha.Location = New System.Drawing.Point(12, 26)
        Me.lblNrFicha.Name = "lblNrFicha"
        Me.lblNrFicha.Size = New System.Drawing.Size(116, 17)
        Me.lblNrFicha.TabIndex = 77
        Me.lblNrFicha.Text = "Número da Ficha"
        '
        'txtNrficha
        '
        Me.txtNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNrficha.Location = New System.Drawing.Point(15, 52)
        Me.txtNrficha.Name = "txtNrficha"
        Me.txtNrficha.Size = New System.Drawing.Size(110, 23)
        Me.txtNrficha.TabIndex = 76
        '
        'lstPagamento
        '
        Me.lstPagamento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NrFicha, Me.Cliente, Me.Dependente, Me.Data, Me.Total, Me.Pago})
        Me.lstPagamento.HideSelection = False
        Me.lstPagamento.Location = New System.Drawing.Point(15, 102)
        Me.lstPagamento.Name = "lstPagamento"
        Me.lstPagamento.Size = New System.Drawing.Size(779, 312)
        Me.lstPagamento.TabIndex = 0
        Me.lstPagamento.UseCompatibleStateImageBehavior = False
        Me.lstPagamento.View = System.Windows.Forms.View.Details
        '
        'NrFicha
        '
        Me.NrFicha.Text = "Número da Ficha"
        Me.NrFicha.Width = 100
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 200
        '
        'Dependente
        '
        Me.Dependente.Text = "Dependente"
        Me.Dependente.Width = 200
        '
        'Data
        '
        Me.Data.Text = "Data da Compra"
        Me.Data.Width = 100
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 80
        '
        'Pago
        '
        Me.Pago.Text = "Pago"
        '
        'frmPagoPendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 592)
        Me.Controls.Add(Me.grpPagamento)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmPagoPendente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caderneta Pendente"
        Me.Panel1.ResumeLayout(False)
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpPagamento As System.Windows.Forms.GroupBox
    Friend WithEvents lstPagamento As System.Windows.Forms.ListView
    Friend WithEvents lblCliente2 As System.Windows.Forms.Label
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents lblNrFicha As System.Windows.Forms.Label
    Friend WithEvents txtNrficha As System.Windows.Forms.TextBox
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents NrFicha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents Dependente As System.Windows.Forms.ColumnHeader
    Friend WithEvents Data As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents Pago As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbxPago As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalPagar2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
End Class
