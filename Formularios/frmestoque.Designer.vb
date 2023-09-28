<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmestoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmestoque))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_opt = New System.Windows.Forms.CheckBox()
        Me.cbo_dados = New System.Windows.Forms.ComboBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_pesquisar = New System.Windows.Forms.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1344, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produtos Cadastrados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pesquisa.Location = New System.Drawing.Point(12, 84)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(206, 25)
        Me.txt_pesquisa.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Digite um nome "
        '
        'dataGrid
        '
        Me.dataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGrid.BackgroundColor = System.Drawing.Color.White
        Me.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(2, 131)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(1340, 525)
        Me.dataGrid.TabIndex = 4
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_total.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_total.Location = New System.Drawing.Point(898, 86)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(557, 24)
        Me.lbl_total.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(229, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selecione uma Linha"
        '
        'chk_opt
        '
        Me.chk_opt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_opt.AutoSize = True
        Me.chk_opt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chk_opt.Location = New System.Drawing.Point(405, 85)
        Me.chk_opt.Name = "chk_opt"
        Me.chk_opt.Size = New System.Drawing.Size(257, 24)
        Me.chk_opt.TabIndex = 6
        Me.chk_opt.Text = "Selecione para uma busca cruzada"
        Me.chk_opt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_opt.UseVisualStyleBackColor = True
        '
        'cbo_dados
        '
        Me.cbo_dados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_dados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_dados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_dados.FormattingEnabled = True
        Me.cbo_dados.Location = New System.Drawing.Point(233, 83)
        Me.cbo_dados.Name = "cbo_dados"
        Me.cbo_dados.Size = New System.Drawing.Size(157, 28)
        Me.cbo_dados.TabIndex = 7
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.DimGray
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.Location = New System.Drawing.Point(759, 73)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btn_print.Size = New System.Drawing.Size(68, 57)
        Me.btn_print.TabIndex = 3
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pesquisar.FlatAppearance.BorderSize = 0
        Me.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesquisar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pesquisar.ForeColor = System.Drawing.Color.DimGray
        Me.btn_pesquisar.Image = CType(resources.GetObject("btn_pesquisar.Image"), System.Drawing.Image)
        Me.btn_pesquisar.Location = New System.Drawing.Point(680, 63)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btn_pesquisar.Size = New System.Drawing.Size(55, 75)
        Me.btn_pesquisar.TabIndex = 3
        Me.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_pesquisar.UseVisualStyleBackColor = False
        '
        'frmestoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 661)
        Me.Controls.Add(Me.cbo_dados)
        Me.Controls.Add(Me.chk_opt)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pesquisa)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_pesquisar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmestoque"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_pesquisar As Button
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_opt As CheckBox
    Friend WithEvents cbo_dados As ComboBox
    Friend WithEvents btn_print As Button
End Class
