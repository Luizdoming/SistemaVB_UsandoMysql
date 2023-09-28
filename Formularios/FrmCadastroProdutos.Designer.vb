<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroProdutos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_linha_prod = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_salvar_prod = New Guna.UI2.WinForms.Guna2Button()
        Me.list_prod = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_nome_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_qtd_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_desinacao_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_data_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbo_unidade = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_editar_prod = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete_prod = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1138, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Produtos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbo_linha_prod
        '
        Me.cbo_linha_prod.BackColor = System.Drawing.Color.Transparent
        Me.cbo_linha_prod.BorderRadius = 3
        Me.cbo_linha_prod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_linha_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_linha_prod.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_linha_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_linha_prod.FocusedState.Parent = Me.cbo_linha_prod
        Me.cbo_linha_prod.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_linha_prod.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbo_linha_prod.HoverState.Parent = Me.cbo_linha_prod
        Me.cbo_linha_prod.ItemHeight = 27
        Me.cbo_linha_prod.ItemsAppearance.Parent = Me.cbo_linha_prod
        Me.cbo_linha_prod.Location = New System.Drawing.Point(537, 78)
        Me.cbo_linha_prod.Name = "cbo_linha_prod"
        Me.cbo_linha_prod.ShadowDecoration.Parent = Me.cbo_linha_prod
        Me.cbo_linha_prod.Size = New System.Drawing.Size(140, 33)
        Me.cbo_linha_prod.TabIndex = 3
        '
        'btn_salvar_prod
        '
        Me.btn_salvar_prod.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salvar_prod.BorderRadius = 3
        Me.btn_salvar_prod.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.btn_salvar_prod.CheckedState.Parent = Me.btn_salvar_prod
        Me.btn_salvar_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar_prod.CustomImages.Parent = Me.btn_salvar_prod
        Me.btn_salvar_prod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar_prod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_salvar_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_salvar_prod.DisabledState.Parent = Me.btn_salvar_prod
        Me.btn_salvar_prod.FillColor = System.Drawing.SystemColors.Highlight
        Me.btn_salvar_prod.FocusedColor = System.Drawing.Color.White
        Me.btn_salvar_prod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_prod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_salvar_prod.HoverState.Parent = Me.btn_salvar_prod
        Me.btn_salvar_prod.Location = New System.Drawing.Point(26, 672)
        Me.btn_salvar_prod.Name = "btn_salvar_prod"
        Me.btn_salvar_prod.ShadowDecoration.Parent = Me.btn_salvar_prod
        Me.btn_salvar_prod.Size = New System.Drawing.Size(100, 35)
        Me.btn_salvar_prod.TabIndex = 2
        Me.btn_salvar_prod.Text = "Salvar"
        '
        'list_prod
        '
        Me.list_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_prod.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.list_prod.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prod.HideSelection = False
        Me.list_prod.Location = New System.Drawing.Point(26, 124)
        Me.list_prod.Name = "list_prod"
        Me.list_prod.Size = New System.Drawing.Size(1098, 527)
        Me.list_prod.TabIndex = 3
        Me.list_prod.UseCompatibleStateImageBehavior = False
        Me.list_prod.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID_Produto"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 110
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Designação"
        Me.ColumnHeader9.Width = 425
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Linha"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 118
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Uni_Medida"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 110
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Qtd_Minima"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 110
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Data_Cadastro"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 110
        '
        'txt_nome_prod
        '
        Me.txt_nome_prod.BorderRadius = 3
        Me.txt_nome_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_prod.DefaultText = ""
        Me.txt_nome_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_prod.DisabledState.Parent = Me.txt_nome_prod
        Me.txt_nome_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_prod.FocusedState.Parent = Me.txt_nome_prod
        Me.txt_nome_prod.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_prod.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_nome_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_prod.HoverState.Parent = Me.txt_nome_prod
        Me.txt_nome_prod.Location = New System.Drawing.Point(26, 81)
        Me.txt_nome_prod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nome_prod.Name = "txt_nome_prod"
        Me.txt_nome_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome_prod.PlaceholderText = ""
        Me.txt_nome_prod.SelectedText = ""
        Me.txt_nome_prod.ShadowDecoration.Parent = Me.txt_nome_prod
        Me.txt_nome_prod.Size = New System.Drawing.Size(200, 30)
        Me.txt_nome_prod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Digite o Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(534, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Linha Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Designação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(870, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Qtd_Minima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(701, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Uni_Medida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(997, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Data Cadastro"
        '
        'txt_id_prod
        '
        Me.txt_id_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_prod.DefaultText = ""
        Me.txt_id_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_id_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_id_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id_prod.DisabledState.Parent = Me.txt_id_prod
        Me.txt_id_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_prod.FocusedState.Parent = Me.txt_id_prod
        Me.txt_id_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_prod.HoverState.Parent = Me.txt_id_prod
        Me.txt_id_prod.Location = New System.Drawing.Point(1066, 672)
        Me.txt_id_prod.Name = "txt_id_prod"
        Me.txt_id_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_prod.PlaceholderText = ""
        Me.txt_id_prod.SelectedText = ""
        Me.txt_id_prod.ShadowDecoration.Parent = Me.txt_id_prod
        Me.txt_id_prod.Size = New System.Drawing.Size(58, 30)
        Me.txt_id_prod.TabIndex = 4
        Me.txt_id_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_qtd_prod
        '
        Me.txt_qtd_prod.BorderRadius = 3
        Me.txt_qtd_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtd_prod.DefaultText = ""
        Me.txt_qtd_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qtd_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qtd_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd_prod.DisabledState.Parent = Me.txt_qtd_prod
        Me.txt_qtd_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qtd_prod.FocusedState.Parent = Me.txt_qtd_prod
        Me.txt_qtd_prod.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_prod.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_qtd_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qtd_prod.HoverState.Parent = Me.txt_qtd_prod
        Me.txt_qtd_prod.Location = New System.Drawing.Point(873, 81)
        Me.txt_qtd_prod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qtd_prod.Name = "txt_qtd_prod"
        Me.txt_qtd_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtd_prod.PlaceholderText = ""
        Me.txt_qtd_prod.SelectedText = ""
        Me.txt_qtd_prod.ShadowDecoration.Parent = Me.txt_qtd_prod
        Me.txt_qtd_prod.Size = New System.Drawing.Size(83, 30)
        Me.txt_qtd_prod.TabIndex = 5
        Me.txt_qtd_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_desinacao_prod
        '
        Me.txt_desinacao_prod.BorderRadius = 3
        Me.txt_desinacao_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desinacao_prod.DefaultText = ""
        Me.txt_desinacao_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_desinacao_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_desinacao_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desinacao_prod.DisabledState.Parent = Me.txt_desinacao_prod
        Me.txt_desinacao_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desinacao_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desinacao_prod.FocusedState.Parent = Me.txt_desinacao_prod
        Me.txt_desinacao_prod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desinacao_prod.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_desinacao_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desinacao_prod.HoverState.Parent = Me.txt_desinacao_prod
        Me.txt_desinacao_prod.Location = New System.Drawing.Point(247, 81)
        Me.txt_desinacao_prod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_desinacao_prod.Name = "txt_desinacao_prod"
        Me.txt_desinacao_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desinacao_prod.PlaceholderText = ""
        Me.txt_desinacao_prod.SelectedText = ""
        Me.txt_desinacao_prod.ShadowDecoration.Parent = Me.txt_desinacao_prod
        Me.txt_desinacao_prod.Size = New System.Drawing.Size(265, 30)
        Me.txt_desinacao_prod.TabIndex = 2
        '
        'txt_data_prod
        '
        Me.txt_data_prod.BorderRadius = 3
        Me.txt_data_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_data_prod.DefaultText = ""
        Me.txt_data_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_data_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_data_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_data_prod.DisabledState.Parent = Me.txt_data_prod
        Me.txt_data_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_data_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_data_prod.FocusedState.Parent = Me.txt_data_prod
        Me.txt_data_prod.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_prod.ForeColor = System.Drawing.Color.Brown
        Me.txt_data_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_data_prod.HoverState.Parent = Me.txt_data_prod
        Me.txt_data_prod.Location = New System.Drawing.Point(1001, 81)
        Me.txt_data_prod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_data_prod.Name = "txt_data_prod"
        Me.txt_data_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_data_prod.PlaceholderText = ""
        Me.txt_data_prod.ReadOnly = True
        Me.txt_data_prod.SelectedText = ""
        Me.txt_data_prod.ShadowDecoration.Parent = Me.txt_data_prod
        Me.txt_data_prod.Size = New System.Drawing.Size(123, 30)
        Me.txt_data_prod.TabIndex = 6
        '
        'cbo_unidade
        '
        Me.cbo_unidade.BackColor = System.Drawing.Color.Transparent
        Me.cbo_unidade.BorderRadius = 3
        Me.cbo_unidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_unidade.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_unidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_unidade.FocusedState.Parent = Me.cbo_unidade
        Me.cbo_unidade.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_unidade.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbo_unidade.HoverState.Parent = Me.cbo_unidade
        Me.cbo_unidade.ItemHeight = 27
        Me.cbo_unidade.ItemsAppearance.Parent = Me.cbo_unidade
        Me.cbo_unidade.Location = New System.Drawing.Point(704, 78)
        Me.cbo_unidade.Name = "cbo_unidade"
        Me.cbo_unidade.ShadowDecoration.Parent = Me.cbo_unidade
        Me.cbo_unidade.Size = New System.Drawing.Size(140, 33)
        Me.cbo_unidade.TabIndex = 4
        '
        'btn_editar_prod
        '
        Me.btn_editar_prod.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editar_prod.BorderRadius = 3
        Me.btn_editar_prod.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.btn_editar_prod.CheckedState.Parent = Me.btn_editar_prod
        Me.btn_editar_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar_prod.CustomImages.Parent = Me.btn_editar_prod
        Me.btn_editar_prod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_editar_prod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_editar_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_editar_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_editar_prod.DisabledState.Parent = Me.btn_editar_prod
        Me.btn_editar_prod.FillColor = System.Drawing.SystemColors.Highlight
        Me.btn_editar_prod.FocusedColor = System.Drawing.Color.White
        Me.btn_editar_prod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_prod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_editar_prod.HoverState.Parent = Me.btn_editar_prod
        Me.btn_editar_prod.Location = New System.Drawing.Point(132, 672)
        Me.btn_editar_prod.Name = "btn_editar_prod"
        Me.btn_editar_prod.ShadowDecoration.Parent = Me.btn_editar_prod
        Me.btn_editar_prod.Size = New System.Drawing.Size(100, 35)
        Me.btn_editar_prod.TabIndex = 2
        Me.btn_editar_prod.Text = "Editar"
        '
        'btn_delete_prod
        '
        Me.btn_delete_prod.BackColor = System.Drawing.SystemColors.Control
        Me.btn_delete_prod.BorderRadius = 3
        Me.btn_delete_prod.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.btn_delete_prod.CheckedState.Parent = Me.btn_delete_prod
        Me.btn_delete_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_prod.CustomImages.Parent = Me.btn_delete_prod
        Me.btn_delete_prod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete_prod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete_prod.DisabledState.Parent = Me.btn_delete_prod
        Me.btn_delete_prod.FillColor = System.Drawing.SystemColors.Highlight
        Me.btn_delete_prod.FocusedColor = System.Drawing.Color.White
        Me.btn_delete_prod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_prod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_delete_prod.HoverState.Parent = Me.btn_delete_prod
        Me.btn_delete_prod.Location = New System.Drawing.Point(238, 672)
        Me.btn_delete_prod.Name = "btn_delete_prod"
        Me.btn_delete_prod.ShadowDecoration.Parent = Me.btn_delete_prod
        Me.btn_delete_prod.Size = New System.Drawing.Size(100, 35)
        Me.btn_delete_prod.TabIndex = 2
        Me.btn_delete_prod.Text = "Deletar"
        '
        'FrmCadastroProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1138, 710)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_data_prod)
        Me.Controls.Add(Me.txt_desinacao_prod)
        Me.Controls.Add(Me.txt_qtd_prod)
        Me.Controls.Add(Me.txt_id_prod)
        Me.Controls.Add(Me.txt_nome_prod)
        Me.Controls.Add(Me.list_prod)
        Me.Controls.Add(Me.btn_delete_prod)
        Me.Controls.Add(Me.btn_editar_prod)
        Me.Controls.Add(Me.btn_salvar_prod)
        Me.Controls.Add(Me.cbo_unidade)
        Me.Controls.Add(Me.cbo_linha_prod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadastroProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_linha_prod As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_salvar_prod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents list_prod As ListView
    Friend WithEvents txt_nome_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_qtd_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_desinacao_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_data_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbo_unidade As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btn_editar_prod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete_prod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
