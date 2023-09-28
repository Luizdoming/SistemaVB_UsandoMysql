<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUser))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete_user = New System.Windows.Forms.Button()
        Me.btn_cad_user_form = New System.Windows.Forms.Button()
        Me.lbl_data_user = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_senha_user = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_id_user = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_nome_user = New Guna.UI2.WinForms.Guna2TextBox()
        Me.imagem_user = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btm_img = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imagem_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(849, 707)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label1"
        '
        'btn_delete_user
        '
        Me.btn_delete_user.BackColor = System.Drawing.Color.LightGray
        Me.btn_delete_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_user.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btn_delete_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_user.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_user.ForeColor = System.Drawing.Color.DimGray
        Me.btn_delete_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete_user.Location = New System.Drawing.Point(170, 250)
        Me.btn_delete_user.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete_user.Name = "btn_delete_user"
        Me.btn_delete_user.Size = New System.Drawing.Size(115, 42)
        Me.btn_delete_user.TabIndex = 2
        Me.btn_delete_user.Text = "Deletar"
        Me.btn_delete_user.UseVisualStyleBackColor = False
        '
        'btn_cad_user_form
        '
        Me.btn_cad_user_form.BackColor = System.Drawing.Color.LightGray
        Me.btn_cad_user_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cad_user_form.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btn_cad_user_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_user_form.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_user_form.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cad_user_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_user_form.Location = New System.Drawing.Point(21, 249)
        Me.btn_cad_user_form.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cad_user_form.Name = "btn_cad_user_form"
        Me.btn_cad_user_form.Size = New System.Drawing.Size(115, 44)
        Me.btn_cad_user_form.TabIndex = 2
        Me.btn_cad_user_form.Text = "Salvar"
        Me.btn_cad_user_form.UseVisualStyleBackColor = False
        '
        'lbl_data_user
        '
        Me.lbl_data_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_data_user.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lbl_data_user.Location = New System.Drawing.Point(667, 13)
        Me.lbl_data_user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_data_user.Name = "lbl_data_user"
        Me.lbl_data_user.Size = New System.Drawing.Size(31, 27)
        Me.lbl_data_user.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_senha_user)
        Me.GroupBox1.Controls.Add(Me.txt_id_user)
        Me.GroupBox1.Controls.Add(Me.txt_nome_user)
        Me.GroupBox1.Controls.Add(Me.btn_cad_user_form)
        Me.GroupBox1.Controls.Add(Me.btn_delete_user)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 306)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txt_senha_user
        '
        Me.txt_senha_user.BorderColor = System.Drawing.Color.SteelBlue
        Me.txt_senha_user.BorderRadius = 1
        Me.txt_senha_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha_user.DefaultText = ""
        Me.txt_senha_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_senha_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_senha_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_user.DisabledState.Parent = Me.txt_senha_user
        Me.txt_senha_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_user.FocusedState.Parent = Me.txt_senha_user
        Me.txt_senha_user.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_user.HoverState.Parent = Me.txt_senha_user
        Me.txt_senha_user.Location = New System.Drawing.Point(14, 175)
        Me.txt_senha_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha_user.Name = "txt_senha_user"
        Me.txt_senha_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha_user.PlaceholderForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_senha_user.PlaceholderText = "Password"
        Me.txt_senha_user.SelectedText = ""
        Me.txt_senha_user.ShadowDecoration.Parent = Me.txt_senha_user
        Me.txt_senha_user.Size = New System.Drawing.Size(264, 31)
        Me.txt_senha_user.TabIndex = 1
        '
        'txt_id_user
        '
        Me.txt_id_user.BorderColor = System.Drawing.Color.SteelBlue
        Me.txt_id_user.BorderRadius = 1
        Me.txt_id_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_user.DefaultText = ""
        Me.txt_id_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_id_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_id_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id_user.DisabledState.Parent = Me.txt_id_user
        Me.txt_id_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_user.FocusedState.Parent = Me.txt_id_user
        Me.txt_id_user.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_id_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id_user.HoverState.Parent = Me.txt_id_user
        Me.txt_id_user.Location = New System.Drawing.Point(14, 61)
        Me.txt_id_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id_user.Name = "txt_id_user"
        Me.txt_id_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_user.PlaceholderForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_id_user.PlaceholderText = "ID"
        Me.txt_id_user.SelectedText = ""
        Me.txt_id_user.ShadowDecoration.Parent = Me.txt_id_user
        Me.txt_id_user.Size = New System.Drawing.Size(100, 31)
        Me.txt_id_user.TabIndex = 5
        '
        'txt_nome_user
        '
        Me.txt_nome_user.BorderColor = System.Drawing.Color.SteelBlue
        Me.txt_nome_user.BorderRadius = 1
        Me.txt_nome_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_user.DefaultText = ""
        Me.txt_nome_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_user.DisabledState.Parent = Me.txt_nome_user
        Me.txt_nome_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_user.FocusedState.Parent = Me.txt_nome_user
        Me.txt_nome_user.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nome_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_user.HoverState.Parent = Me.txt_nome_user
        Me.txt_nome_user.Location = New System.Drawing.Point(14, 118)
        Me.txt_nome_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome_user.Name = "txt_nome_user"
        Me.txt_nome_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome_user.PlaceholderForeColor = System.Drawing.SystemColors.ControlLight
        Me.txt_nome_user.PlaceholderText = "User"
        Me.txt_nome_user.SelectedText = ""
        Me.txt_nome_user.ShadowDecoration.Parent = Me.txt_nome_user
        Me.txt_nome_user.Size = New System.Drawing.Size(264, 31)
        Me.txt_nome_user.TabIndex = 0
        '
        'imagem_user
        '
        Me.imagem_user.BackColor = System.Drawing.Color.Transparent
        Me.imagem_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagem_user.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.imagem_user.Image = CType(resources.GetObject("imagem_user.Image"), System.Drawing.Image)
        Me.imagem_user.ImageRotate = 0!
        Me.imagem_user.Location = New System.Drawing.Point(99, 12)
        Me.imagem_user.Name = "imagem_user"
        Me.imagem_user.ShadowDecoration.BorderRadius = 10
        Me.imagem_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.imagem_user.ShadowDecoration.Parent = Me.imagem_user
        Me.imagem_user.Size = New System.Drawing.Size(131, 131)
        Me.imagem_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem_user.TabIndex = 4
        Me.imagem_user.TabStop = False
        '
        'btm_img
        '
        Me.btm_img.BorderRadius = 3
        Me.btm_img.CheckedState.Parent = Me.btm_img
        Me.btm_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_img.CustomBorderColor = System.Drawing.Color.LightGray
        Me.btm_img.CustomImages.Parent = Me.btm_img
        Me.btm_img.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_img.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_img.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_img.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_img.DisabledState.Parent = Me.btm_img
        Me.btm_img.FillColor = System.Drawing.Color.Silver
        Me.btm_img.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btm_img.ForeColor = System.Drawing.Color.Black
        Me.btm_img.HoverState.Parent = Me.btm_img
        Me.btm_img.ImageSize = New System.Drawing.Size(45, 35)
        Me.btm_img.Location = New System.Drawing.Point(213, 125)
        Me.btm_img.Name = "btm_img"
        Me.btm_img.ShadowDecoration.Parent = Me.btm_img
        Me.btm_img.Size = New System.Drawing.Size(30, 28)
        Me.btm_img.TabIndex = 5
        Me.btm_img.Text = "+"
        Me.btm_img.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 477)
        Me.Controls.Add(Me.btm_img)
        Me.Controls.Add(Me.imagem_user)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_data_user)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmUser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imagem_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cad_user_form As Button
    Friend WithEvents btn_delete_user As Button
    Friend WithEvents lbl_data_user As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents imagem_user As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txt_senha_user As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_id_user As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_nome_user As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btm_img As Guna.UI2.WinForms.Guna2Button
End Class
