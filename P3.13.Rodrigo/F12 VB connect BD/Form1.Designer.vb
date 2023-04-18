<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnProdutos20 = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.btnProdutosExistencias = New System.Windows.Forms.Button()
        Me.cbxProdutos20 = New System.Windows.Forms.ComboBox()
        Me.lstProdutosExistencias = New System.Windows.Forms.ListBox()
        Me.lblSeparador1 = New System.Windows.Forms.Label()
        Me.lblSeparador2 = New System.Windows.Forms.Label()
        Me.lblSeparador3 = New System.Windows.Forms.Label()
        Me.dgvFornecedores = New System.Windows.Forms.DataGridView()
        Me.cbxPaises = New System.Windows.Forms.ComboBox()
        Me.btnFornecedores = New System.Windows.Forms.Button()
        Me.lblSeparador4 = New System.Windows.Forms.Label()
        Me.txtCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnInserirCategoria = New System.Windows.Forms.Button()
        Me.lblCodigoCategoria = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSeparador5 = New System.Windows.Forms.Label()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox()
        Me.lblNomeProduto = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.lblDescontinuado = New System.Windows.Forms.Label()
        Me.chkSim = New System.Windows.Forms.CheckBox()
        Me.btnInserirProduto = New System.Windows.Forms.Button()
        Me.chkNao = New System.Windows.Forms.CheckBox()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProdutos20
        '
        Me.btnProdutos20.Location = New System.Drawing.Point(412, 172)
        Me.btnProdutos20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProdutos20.Name = "btnProdutos20"
        Me.btnProdutos20.Size = New System.Drawing.Size(263, 29)
        Me.btnProdutos20.TabIndex = 0
        Me.btnProdutos20.Text = "Produtos com Preço > 20 e não Nulos"
        Me.btnProdutos20.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(29, 11)
        Me.dgvProdutos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersWidth = 51
        Me.dgvProdutos.Size = New System.Drawing.Size(646, 141)
        Me.dgvProdutos.TabIndex = 1
        '
        'btnProdutosExistencias
        '
        Me.btnProdutosExistencias.Location = New System.Drawing.Point(412, 221)
        Me.btnProdutosExistencias.Name = "btnProdutosExistencias"
        Me.btnProdutosExistencias.Size = New System.Drawing.Size(263, 29)
        Me.btnProdutosExistencias.TabIndex = 2
        Me.btnProdutosExistencias.Text = "Produtos e suas Existências"
        Me.btnProdutosExistencias.UseVisualStyleBackColor = True
        '
        'cbxProdutos20
        '
        Me.cbxProdutos20.FormattingEnabled = True
        Me.cbxProdutos20.Location = New System.Drawing.Point(29, 172)
        Me.cbxProdutos20.Name = "cbxProdutos20"
        Me.cbxProdutos20.Size = New System.Drawing.Size(336, 23)
        Me.cbxProdutos20.TabIndex = 3
        '
        'lstProdutosExistencias
        '
        Me.lstProdutosExistencias.FormattingEnabled = True
        Me.lstProdutosExistencias.ItemHeight = 15
        Me.lstProdutosExistencias.Location = New System.Drawing.Point(29, 221)
        Me.lstProdutosExistencias.Name = "lstProdutosExistencias"
        Me.lstProdutosExistencias.Size = New System.Drawing.Size(336, 94)
        Me.lstProdutosExistencias.TabIndex = 4
        '
        'lblSeparador1
        '
        Me.lblSeparador1.AutoSize = True
        Me.lblSeparador1.Location = New System.Drawing.Point(12, 154)
        Me.lblSeparador1.Name = "lblSeparador1"
        Me.lblSeparador1.Size = New System.Drawing.Size(687, 15)
        Me.lblSeparador1.TabIndex = 5
        Me.lblSeparador1.Text = "=================================================================================" &
    "===="
        '
        'lblSeparador2
        '
        Me.lblSeparador2.AutoSize = True
        Me.lblSeparador2.Location = New System.Drawing.Point(12, 203)
        Me.lblSeparador2.Name = "lblSeparador2"
        Me.lblSeparador2.Size = New System.Drawing.Size(687, 15)
        Me.lblSeparador2.TabIndex = 6
        Me.lblSeparador2.Text = "=================================================================================" &
    "===="
        '
        'lblSeparador3
        '
        Me.lblSeparador3.AutoSize = True
        Me.lblSeparador3.Location = New System.Drawing.Point(12, 318)
        Me.lblSeparador3.Name = "lblSeparador3"
        Me.lblSeparador3.Size = New System.Drawing.Size(687, 15)
        Me.lblSeparador3.TabIndex = 7
        Me.lblSeparador3.Text = "=================================================================================" &
    "===="
        '
        'dgvFornecedores
        '
        Me.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedores.Location = New System.Drawing.Point(29, 336)
        Me.dgvFornecedores.Name = "dgvFornecedores"
        Me.dgvFornecedores.RowTemplate.Height = 25
        Me.dgvFornecedores.Size = New System.Drawing.Size(646, 105)
        Me.dgvFornecedores.TabIndex = 8
        '
        'cbxPaises
        '
        Me.cbxPaises.FormattingEnabled = True
        Me.cbxPaises.Location = New System.Drawing.Point(412, 447)
        Me.cbxPaises.Name = "cbxPaises"
        Me.cbxPaises.Size = New System.Drawing.Size(263, 23)
        Me.cbxPaises.TabIndex = 9
        '
        'btnFornecedores
        '
        Me.btnFornecedores.Location = New System.Drawing.Point(29, 447)
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(336, 30)
        Me.btnFornecedores.TabIndex = 10
        Me.btnFornecedores.Text = "Fornecedores na Grid"
        Me.btnFornecedores.UseVisualStyleBackColor = True
        '
        'lblSeparador4
        '
        Me.lblSeparador4.AutoSize = True
        Me.lblSeparador4.Location = New System.Drawing.Point(9, 480)
        Me.lblSeparador4.Name = "lblSeparador4"
        Me.lblSeparador4.Size = New System.Drawing.Size(687, 15)
        Me.lblSeparador4.TabIndex = 11
        Me.lblSeparador4.Text = "=================================================================================" &
    "===="
        '
        'txtCodigoCategoria
        '
        Me.txtCodigoCategoria.Location = New System.Drawing.Point(81, 506)
        Me.txtCodigoCategoria.Name = "txtCodigoCategoria"
        Me.txtCodigoCategoria.Size = New System.Drawing.Size(38, 23)
        Me.txtCodigoCategoria.TabIndex = 12
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(241, 506)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(124, 23)
        Me.txtCategoria.TabIndex = 13
        '
        'btnInserirCategoria
        '
        Me.btnInserirCategoria.Location = New System.Drawing.Point(412, 505)
        Me.btnInserirCategoria.Name = "btnInserirCategoria"
        Me.btnInserirCategoria.Size = New System.Drawing.Size(263, 24)
        Me.btnInserirCategoria.TabIndex = 14
        Me.btnInserirCategoria.Text = "Inserir Nova Categoria"
        Me.btnInserirCategoria.UseVisualStyleBackColor = True
        '
        'lblCodigoCategoria
        '
        Me.lblCodigoCategoria.AutoSize = True
        Me.lblCodigoCategoria.Location = New System.Drawing.Point(29, 509)
        Me.lblCodigoCategoria.Name = "lblCodigoCategoria"
        Me.lblCodigoCategoria.Size = New System.Drawing.Size(46, 15)
        Me.lblCodigoCategoria.TabIndex = 15
        Me.lblCodigoCategoria.Text = "Código"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(125, 509)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(110, 15)
        Me.lblNome.TabIndex = 16
        Me.lblNome.Text = "Nome da Categoria"
        '
        'lblSeparador5
        '
        Me.lblSeparador5.AutoSize = True
        Me.lblSeparador5.Location = New System.Drawing.Point(12, 532)
        Me.lblSeparador5.Name = "lblSeparador5"
        Me.lblSeparador5.Size = New System.Drawing.Size(687, 15)
        Me.lblSeparador5.TabIndex = 17
        Me.lblSeparador5.Text = "=================================================================================" &
    "===="
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(29, 562)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(46, 15)
        Me.lblCodigoProduto.TabIndex = 18
        Me.lblCodigoProduto.Text = "Código"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Location = New System.Drawing.Point(81, 557)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(38, 23)
        Me.txtCodigoProduto.TabIndex = 19
        '
        'lblNomeProduto
        '
        Me.lblNomeProduto.AutoSize = True
        Me.lblNomeProduto.Location = New System.Drawing.Point(125, 562)
        Me.lblNomeProduto.Name = "lblNomeProduto"
        Me.lblNomeProduto.Size = New System.Drawing.Size(103, 15)
        Me.lblNomeProduto.TabIndex = 20
        Me.lblNomeProduto.Text = "Nome do Produto"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(241, 562)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(124, 23)
        Me.txtProduto.TabIndex = 21
        '
        'lblDescontinuado
        '
        Me.lblDescontinuado.AutoSize = True
        Me.lblDescontinuado.Location = New System.Drawing.Point(81, 600)
        Me.lblDescontinuado.Name = "lblDescontinuado"
        Me.lblDescontinuado.Size = New System.Drawing.Size(92, 15)
        Me.lblDescontinuado.TabIndex = 22
        Me.lblDescontinuado.Text = "Descontinuado?"
        '
        'chkSim
        '
        Me.chkSim.AutoSize = True
        Me.chkSim.Location = New System.Drawing.Point(189, 599)
        Me.chkSim.Name = "chkSim"
        Me.chkSim.Size = New System.Drawing.Size(46, 19)
        Me.chkSim.TabIndex = 23
        Me.chkSim.Text = "Sim"
        Me.chkSim.UseVisualStyleBackColor = True
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Location = New System.Drawing.Point(412, 562)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Size = New System.Drawing.Size(263, 53)
        Me.btnInserirProduto.TabIndex = 24
        Me.btnInserirProduto.Text = "Inserir Novo Produto"
        Me.btnInserirProduto.UseVisualStyleBackColor = True
        '
        'chkNao
        '
        Me.chkNao.AutoSize = True
        Me.chkNao.Location = New System.Drawing.Point(241, 599)
        Me.chkNao.Name = "chkNao"
        Me.chkNao.Size = New System.Drawing.Size(48, 19)
        Me.chkNao.TabIndex = 25
        Me.chkNao.Text = "Não"
        Me.chkNao.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 634)
        Me.Controls.Add(Me.chkNao)
        Me.Controls.Add(Me.btnInserirProduto)
        Me.Controls.Add(Me.chkSim)
        Me.Controls.Add(Me.lblDescontinuado)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.lblNomeProduto)
        Me.Controls.Add(Me.txtCodigoProduto)
        Me.Controls.Add(Me.lblCodigoProduto)
        Me.Controls.Add(Me.lblSeparador5)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigoCategoria)
        Me.Controls.Add(Me.btnInserirCategoria)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtCodigoCategoria)
        Me.Controls.Add(Me.lblSeparador4)
        Me.Controls.Add(Me.btnFornecedores)
        Me.Controls.Add(Me.cbxPaises)
        Me.Controls.Add(Me.dgvFornecedores)
        Me.Controls.Add(Me.lblSeparador3)
        Me.Controls.Add(Me.lblSeparador2)
        Me.Controls.Add(Me.lblSeparador1)
        Me.Controls.Add(Me.lstProdutosExistencias)
        Me.Controls.Add(Me.cbxProdutos20)
        Me.Controls.Add(Me.btnProdutosExistencias)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.btnProdutos20)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProdutos20 As Button
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents btnProdutosExistencias As Button
    Friend WithEvents cbxProdutos20 As ComboBox
    Friend WithEvents lstProdutosExistencias As ListBox
    Friend WithEvents lblSeparador1 As Label
    Friend WithEvents lblSeparador2 As Label
    Friend WithEvents lblSeparador3 As Label
    Friend WithEvents dgvFornecedores As DataGridView
    Friend WithEvents cbxPaises As ComboBox
    Friend WithEvents btnFornecedores As Button
    Friend WithEvents lblSeparador4 As Label
    Friend WithEvents txtCodigoCategoria As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnInserirCategoria As Button
    Friend WithEvents lblCodigoCategoria As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSeparador5 As Label
    Friend WithEvents lblCodigoProduto As Label
    Friend WithEvents txtCodigoProduto As TextBox
    Friend WithEvents lblNomeProduto As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents lblDescontinuado As Label
    Friend WithEvents chkSim As CheckBox
    Friend WithEvents btnInserirProduto As Button
    Friend WithEvents chkNao As CheckBox
End Class
