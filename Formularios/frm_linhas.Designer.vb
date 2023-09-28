<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_linhas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_linhas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_linha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_unidade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.List_linhas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List_unidades = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_editar = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_id_editar = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastre Linhas e Unidades Medidas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2GradientButton1.BorderRadius = 2
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.CustomImages.CheckedImage = CType(resources.GetObject("resource.CheckedImage"), System.Drawing.Image)
        Me.Guna2GradientButton1.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2GradientButton1.FocusedColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(6, 459)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(109, 35)
        Me.Guna2GradientButton1.TabIndex = 1
        Me.Guna2GradientButton1.Text = "           Salvar"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Linha"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome Unidade"
        '
        'txt_linha
        '
        Me.txt_linha.BorderRadius = 5
        Me.txt_linha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_linha.DefaultText = ""
        Me.txt_linha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_linha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_linha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_linha.DisabledState.Parent = Me.txt_linha
        Me.txt_linha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_linha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_linha.FocusedState.Parent = Me.txt_linha
        Me.txt_linha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_linha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_linha.HoverState.Parent = Me.txt_linha
        Me.txt_linha.Location = New System.Drawing.Point(6, 66)
        Me.txt_linha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_linha.Name = "txt_linha"
        Me.txt_linha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_linha.PlaceholderText = ""
        Me.txt_linha.SelectedText = ""
        Me.txt_linha.ShadowDecoration.Parent = Me.txt_linha
        Me.txt_linha.Size = New System.Drawing.Size(157, 30)
        Me.txt_linha.TabIndex = 3
        '
        'txt_unidade
        '
        Me.txt_unidade.BorderRadius = 5
        Me.txt_unidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_unidade.DefaultText = ""
        Me.txt_unidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_unidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_unidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_unidade.DisabledState.Parent = Me.txt_unidade
        Me.txt_unidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_unidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_unidade.FocusedState.Parent = Me.txt_unidade
        Me.txt_unidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_unidade.HoverState.Parent = Me.txt_unidade
        Me.txt_unidade.Location = New System.Drawing.Point(262, 66)
        Me.txt_unidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_unidade.Name = "txt_unidade"
        Me.txt_unidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_unidade.PlaceholderText = ""
        Me.txt_unidade.SelectedText = ""
        Me.txt_unidade.ShadowDecoration.Parent = Me.txt_unidade
        Me.txt_unidade.Size = New System.Drawing.Size(97, 30)
        Me.txt_unidade.TabIndex = 4
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(264, 424)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(245, 74)
        Me.Guna2GroupBox1.TabIndex = 6
        Me.Guna2GroupBox1.Text = "Selecione uma Opção"
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.BackColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(176, 43)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(62, 24)
        Me.Guna2RadioButton2.TabIndex = 7
        Me.Guna2RadioButton2.Text = "Linha"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UseVisualStyleBackColor = False
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.BackColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(15, 43)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(138, 24)
        Me.Guna2RadioButton1.TabIndex = 7
        Me.Guna2RadioButton1.Text = "Unidade Medida"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UseVisualStyleBackColor = False
        '
        'List_linhas
        '
        Me.List_linhas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.List_linhas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.List_linhas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_linhas.HideSelection = False
        Me.List_linhas.Location = New System.Drawing.Point(6, 125)
        Me.List_linhas.Name = "List_linhas"
        Me.List_linhas.Size = New System.Drawing.Size(232, 293)
        Me.List_linhas.TabIndex = 7
        Me.List_linhas.UseCompatibleStateImageBehavior = False
        Me.List_linhas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome Linha"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'List_unidades
        '
        Me.List_unidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.List_unidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.List_unidades.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_unidades.HideSelection = False
        Me.List_unidades.Location = New System.Drawing.Point(262, 125)
        Me.List_unidades.Name = "List_unidades"
        Me.List_unidades.Size = New System.Drawing.Size(232, 293)
        Me.List_unidades.TabIndex = 7
        Me.List_unidades.UseCompatibleStateImageBehavior = False
        Me.List_unidades.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nome Unidade"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'btn_editar
        '
        Me.btn_editar.BorderColor = System.Drawing.Color.Silver
        Me.btn_editar.BorderRadius = 3
        Me.btn_editar.BorderThickness = 1
        Me.btn_editar.CheckedState.Parent = Me.btn_editar
        Me.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btn_editar.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_editar.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_editar.CustomImages.Parent = Me.btn_editar
        Me.btn_editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_editar.DisabledState.Parent = Me.btn_editar
        Me.btn_editar.FillColor = System.Drawing.Color.Gainsboro
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.DimGray
        Me.btn_editar.HoverState.Parent = Me.btn_editar
        Me.btn_editar.Location = New System.Drawing.Point(121, 459)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.ShadowDecoration.Parent = Me.btn_editar
        Me.btn_editar.Size = New System.Drawing.Size(109, 35)
        Me.btn_editar.TabIndex = 8
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_id_editar
        '
        Me.txt_id_editar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_editar.Location = New System.Drawing.Point(515, 66)
        Me.txt_id_editar.Name = "txt_id_editar"
        Me.txt_id_editar.Size = New System.Drawing.Size(63, 13)
        Me.txt_id_editar.TabIndex = 9
        Me.txt_id_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_linhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 502)
        Me.Controls.Add(Me.txt_id_editar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.List_unidades)
        Me.Controls.Add(Me.List_linhas)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.txt_unidade)
        Me.Controls.Add(Me.txt_linha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_linhas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_unidade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_linha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents List_unidades As ListView
    Friend WithEvents List_linhas As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btn_editar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_id_editar As TextBox
End Class
