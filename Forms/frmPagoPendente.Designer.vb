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
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.grpPagamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1112, 37)
        Me.Panel2.TabIndex = 41
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
        Me.Panel1.Size = New System.Drawing.Size(938, 92)
        Me.Panel1.TabIndex = 40
        '
        'grpPagamento
        '
        Me.grpPagamento.Controls.Add(Me.Label2)
        Me.grpPagamento.Controls.Add(Me.lblCodigo)
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
        Me.grpPagamento.Location = New System.Drawing.Point(16, 100)
        Me.grpPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPagamento.Size = New System.Drawing.Size(902, 452)
        Me.grpPagamento.TabIndex = 41
        Me.grpPagamento.TabStop = False
        Me.grpPagamento.Tag = "0"
        Me.grpPagamento.Text = "Pendência"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.Padaria.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultar.Location = New System.Drawing.Point(461, 365)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(71, 68)
        Me.btnConsultar.TabIndex = 100
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblTotalPagar2
        '
        Me.lblTotalPagar2.AutoSize = True
        Me.lblTotalPagar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalPagar2.Location = New System.Drawing.Point(708, 33)
        Me.lblTotalPagar2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPagar2.Name = "lblTotalPagar2"
        Me.lblTotalPagar2.Size = New System.Drawing.Size(95, 20)
        Me.lblTotalPagar2.TabIndex = 99
        Me.lblTotalPagar2.Text = "Total Pagar"
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPagar.Location = New System.Drawing.Point(712, 60)
        Me.lblTotalPagar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(91, 26)
        Me.lblTotalPagar.TabIndex = 98
        Me.lblTotalPagar.Text = "R$ 0,00"
        Me.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxPago
        '
        Me.cbxPago.AutoSize = True
        Me.cbxPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPago.Location = New System.Drawing.Point(811, 60)
        Me.cbxPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPago.Name = "cbxPago"
        Me.cbxPago.Size = New System.Drawing.Size(69, 24)
        Me.cbxPago.TabIndex = 88
        Me.cbxPago.Text = "Pago"
        Me.cbxPago.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.BackgroundImage = Global.Padaria.My.Resources.Resources.ok
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Location = New System.Drawing.Point(382, 365)
        Me.btnPagar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(71, 68)
        Me.btnPagar.TabIndex = 85
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lblCliente2
        '
        Me.lblCliente2.AutoSize = True
        Me.lblCliente2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCliente2.Location = New System.Drawing.Point(219, 33)
        Me.lblCliente2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente2.Name = "lblCliente2"
        Me.lblCliente2.Size = New System.Drawing.Size(61, 20)
        Me.lblCliente2.TabIndex = 79
        Me.lblCliente2.Text = "Cliente"
        '
        'lblClientes
        '
        Me.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientes.Location = New System.Drawing.Point(223, 60)
        Me.lblClientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(481, 26)
        Me.lblClientes.TabIndex = 78
        '
        'lblNrFicha
        '
        Me.lblNrFicha.AutoSize = True
        Me.lblNrFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNrFicha.Location = New System.Drawing.Point(126, 33)
        Me.lblNrFicha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNrFicha.Name = "lblNrFicha"
        Me.lblNrFicha.Size = New System.Drawing.Size(73, 20)
        Me.lblNrFicha.TabIndex = 77
        Me.lblNrFicha.Text = "Nº Ficha"
        '
        'txtNrficha
        '
        Me.txtNrficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNrficha.Location = New System.Drawing.Point(130, 59)
        Me.txtNrficha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNrficha.Name = "txtNrficha"
        Me.txtNrficha.Size = New System.Drawing.Size(85, 26)
        Me.txtNrficha.TabIndex = 76
        '
        'lstPagamento
        '
        Me.lstPagamento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.NrFicha, Me.Cliente, Me.Dependente, Me.Data, Me.Total, Me.Pago})
        Me.lstPagamento.HideSelection = False
        Me.lstPagamento.Location = New System.Drawing.Point(20, 96)
        Me.lstPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPagamento.Name = "lstPagamento"
        Me.lstPagamento.Size = New System.Drawing.Size(861, 261)
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
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(20, 58)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(88, 26)
        Me.lblCodigo.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Codigo"
        '
        'frmPagoPendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 570)
        Me.Controls.Add(Me.grpPagamento)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Codigo As ColumnHeader
End Class
