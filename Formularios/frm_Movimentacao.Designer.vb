<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimentacao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_pesquisar_movimenta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pesuisa_movimen = New System.Windows.Forms.TextBox()
        Me.opt_saidas = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.opt_entradas = New System.Windows.Forms.RadioButton()
        Me.txt_unidade_movi = New System.Windows.Forms.TextBox()
        Me.txt_linha_movim = New System.Windows.Forms.TextBox()
        Me.txt_qtd_movim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_data_movim = New System.Windows.Forms.TextBox()
        Me.btn_salvar_movim = New System.Windows.Forms.Button()
        Me.btn_editar_movimentacao = New System.Windows.Forms.Button()
        Me.txt_sesignacao_movim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.list_movimentacao = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Chk_Entradas = New System.Windows.Forms.RadioButton()
        Me.Chk_saidas = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btn_pesquisar_movimenta
        '
        Me.btn_pesquisar_movimenta.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_pesquisar_movimenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesquisar_movimenta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pesquisar_movimenta.ForeColor = System.Drawing.Color.DimGray
        Me.btn_pesquisar_movimenta.Location = New System.Drawing.Point(175, 82)
        Me.btn_pesquisar_movimenta.Name = "btn_pesquisar_movimenta"
        Me.btn_pesquisar_movimenta.Size = New System.Drawing.Size(95, 35)
        Me.btn_pesquisar_movimenta.TabIndex = 0
        Me.btn_pesquisar_movimenta.Text = "Pesquisar"
        Me.btn_pesquisar_movimenta.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite um Código"
        '
        'txt_pesuisa_movimen
        '
        Me.txt_pesuisa_movimen.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesuisa_movimen.Location = New System.Drawing.Point(22, 88)
        Me.txt_pesuisa_movimen.Name = "txt_pesuisa_movimen"
        Me.txt_pesuisa_movimen.Size = New System.Drawing.Size(141, 27)
        Me.txt_pesuisa_movimen.TabIndex = 3
        '
        'opt_saidas
        '
        Me.opt_saidas.AutoSize = True
        Me.opt_saidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opt_saidas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_saidas.ForeColor = System.Drawing.Color.DimGray
        Me.opt_saidas.Location = New System.Drawing.Point(22, 610)
        Me.opt_saidas.Name = "opt_saidas"
        Me.opt_saidas.Size = New System.Drawing.Size(69, 24)
        Me.opt_saidas.TabIndex = 4
        Me.opt_saidas.TabStop = True
        Me.opt_saidas.Text = "Saidas"
        Me.opt_saidas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(935, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Movimentação do Estoque"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'opt_entradas
        '
        Me.opt_entradas.AutoSize = True
        Me.opt_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opt_entradas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_entradas.ForeColor = System.Drawing.Color.DimGray
        Me.opt_entradas.Location = New System.Drawing.Point(116, 610)
        Me.opt_entradas.Name = "opt_entradas"
        Me.opt_entradas.Size = New System.Drawing.Size(83, 24)
        Me.opt_entradas.TabIndex = 4
        Me.opt_entradas.TabStop = True
        Me.opt_entradas.Text = "Entradas"
        Me.opt_entradas.UseVisualStyleBackColor = True
        '
        'txt_unidade_movi
        '
        Me.txt_unidade_movi.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unidade_movi.Location = New System.Drawing.Point(638, 88)
        Me.txt_unidade_movi.Name = "txt_unidade_movi"
        Me.txt_unidade_movi.Size = New System.Drawing.Size(86, 27)
        Me.txt_unidade_movi.TabIndex = 3
        '
        'txt_linha_movim
        '
        Me.txt_linha_movim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_linha_movim.Location = New System.Drawing.Point(732, 88)
        Me.txt_linha_movim.Name = "txt_linha_movim"
        Me.txt_linha_movim.Size = New System.Drawing.Size(94, 27)
        Me.txt_linha_movim.TabIndex = 3
        '
        'txt_qtd_movim
        '
        Me.txt_qtd_movim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtd_movim.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_movim.Location = New System.Drawing.Point(835, 86)
        Me.txt_qtd_movim.MinimumSize = New System.Drawing.Size(27, 27)
        Me.txt_qtd_movim.Name = "txt_qtd_movim"
        Me.txt_qtd_movim.Size = New System.Drawing.Size(79, 29)
        Me.txt_qtd_movim.TabIndex = 3
        Me.txt_qtd_movim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(728, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Linha"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(635, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "U.Medida"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(831, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Quantidade"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(983, 704)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Data"
        '
        'txt_data_movim
        '
        Me.txt_data_movim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data_movim.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_movim.Location = New System.Drawing.Point(939, 734)
        Me.txt_data_movim.Name = "txt_data_movim"
        Me.txt_data_movim.Size = New System.Drawing.Size(10, 22)
        Me.txt_data_movim.TabIndex = 3
        Me.txt_data_movim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_salvar_movim
        '
        Me.btn_salvar_movim.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_salvar_movim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_movim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_movim.ForeColor = System.Drawing.Color.DimGray
        Me.btn_salvar_movim.Location = New System.Drawing.Point(714, 597)
        Me.btn_salvar_movim.Name = "btn_salvar_movim"
        Me.btn_salvar_movim.Size = New System.Drawing.Size(95, 40)
        Me.btn_salvar_movim.TabIndex = 0
        Me.btn_salvar_movim.Text = "OK"
        Me.btn_salvar_movim.UseVisualStyleBackColor = False
        '
        'btn_editar_movimentacao
        '
        Me.btn_editar_movimentacao.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_editar_movimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar_movimentacao.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_movimentacao.ForeColor = System.Drawing.Color.DimGray
        Me.btn_editar_movimentacao.Location = New System.Drawing.Point(816, 597)
        Me.btn_editar_movimentacao.Name = "btn_editar_movimentacao"
        Me.btn_editar_movimentacao.Size = New System.Drawing.Size(95, 40)
        Me.btn_editar_movimentacao.TabIndex = 0
        Me.btn_editar_movimentacao.Text = "Editar"
        Me.btn_editar_movimentacao.UseVisualStyleBackColor = False
        '
        'txt_sesignacao_movim
        '
        Me.txt_sesignacao_movim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sesignacao_movim.Location = New System.Drawing.Point(351, 88)
        Me.txt_sesignacao_movim.Name = "txt_sesignacao_movim"
        Me.txt_sesignacao_movim.Size = New System.Drawing.Size(276, 27)
        Me.txt_sesignacao_movim.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Designação"
        '
        'list_movimentacao
        '
        Me.list_movimentacao.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.list_movimentacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_movimentacao.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.list_movimentacao.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_movimentacao.HideSelection = False
        Me.list_movimentacao.Location = New System.Drawing.Point(19, 135)
        Me.list_movimentacao.MultiSelect = False
        Me.list_movimentacao.Name = "list_movimentacao"
        Me.list_movimentacao.Size = New System.Drawing.Size(896, 456)
        Me.list_movimentacao.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.list_movimentacao.TabIndex = 5
        Me.list_movimentacao.UseCompatibleStateImageBehavior = False
        Me.list_movimentacao.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Designação"
        Me.ColumnHeader2.Width = 422
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Linha"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 109
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unidade"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantidade"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 105
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Location = New System.Drawing.Point(225, 610)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Editar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Chk_Entradas
        '
        Me.Chk_Entradas.AutoSize = True
        Me.Chk_Entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk_Entradas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Entradas.ForeColor = System.Drawing.Color.DimGray
        Me.Chk_Entradas.Location = New System.Drawing.Point(395, 610)
        Me.Chk_Entradas.Name = "Chk_Entradas"
        Me.Chk_Entradas.Size = New System.Drawing.Size(83, 24)
        Me.Chk_Entradas.TabIndex = 7
        Me.Chk_Entradas.TabStop = True
        Me.Chk_Entradas.Text = "Entradas"
        Me.Chk_Entradas.UseVisualStyleBackColor = True
        '
        'Chk_saidas
        '
        Me.Chk_saidas.AutoSize = True
        Me.Chk_saidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk_saidas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_saidas.ForeColor = System.Drawing.Color.DimGray
        Me.Chk_saidas.Location = New System.Drawing.Point(308, 610)
        Me.Chk_saidas.Name = "Chk_saidas"
        Me.Chk_saidas.Size = New System.Drawing.Size(69, 24)
        Me.Chk_saidas.TabIndex = 7
        Me.Chk_saidas.TabStop = True
        Me.Chk_saidas.Text = "Saidas"
        Me.Chk_saidas.UseVisualStyleBackColor = True
        '
        'frm_Movimentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(935, 641)
        Me.Controls.Add(Me.Chk_saidas)
        Me.Controls.Add(Me.Chk_Entradas)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.list_movimentacao)
        Me.Controls.Add(Me.opt_entradas)
        Me.Controls.Add(Me.opt_saidas)
        Me.Controls.Add(Me.txt_data_movim)
        Me.Controls.Add(Me.txt_qtd_movim)
        Me.Controls.Add(Me.txt_linha_movim)
        Me.Controls.Add(Me.txt_sesignacao_movim)
        Me.Controls.Add(Me.txt_unidade_movi)
        Me.Controls.Add(Me.txt_pesuisa_movimen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_editar_movimentacao)
        Me.Controls.Add(Me.btn_salvar_movim)
        Me.Controls.Add(Me.btn_pesquisar_movimenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Movimentacao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pesquisar_movimenta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pesuisa_movimen As TextBox
    Friend WithEvents opt_saidas As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents opt_entradas As RadioButton
    Friend WithEvents txt_unidade_movi As TextBox
    Friend WithEvents txt_linha_movim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_data_movim As TextBox
    Friend WithEvents btn_salvar_movim As Button
    Friend WithEvents btn_editar_movimentacao As Button
    Friend WithEvents txt_qtd_movim As TextBox
    Friend WithEvents txt_sesignacao_movim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents list_movimentacao As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Chk_Entradas As RadioButton
    Friend WithEvents Chk_saidas As RadioButton
End Class
