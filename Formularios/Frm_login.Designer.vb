<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_cancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.img_login = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.cbo_nomeuser = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Silver
        Me.btn_login.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.BorderRadius = 2
        Me.btn_login.BorderThickness = 1
        Me.btn_login.CheckedState.Parent = Me.btn_login
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.CustomImages.Parent = Me.btn_login
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.DisabledState.Parent = Me.btn_login
        Me.btn_login.FillColor = System.Drawing.Color.LightGray
        Me.btn_login.FocusedColor = System.Drawing.Color.Silver
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.DimGray
        Me.btn_login.HoverState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.HoverState.Parent = Me.btn_login
        Me.btn_login.Location = New System.Drawing.Point(70, 333)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.ShadowDecoration.Parent = Me.btn_login
        Me.btn_login.Size = New System.Drawing.Size(100, 40)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "OK"
        '
        'txt_usuario
        '
        Me.txt_usuario.BorderColor = System.Drawing.Color.White
        Me.txt_usuario.BorderThickness = 0
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.DefaultText = ""
        Me.txt_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_usuario.DisabledState.Parent = Me.txt_usuario
        Me.txt_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_usuario.FocusedState.BorderColor = System.Drawing.SystemColors.Menu
        Me.txt_usuario.FocusedState.Parent = Me.txt_usuario
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usuario.HoverState.Parent = Me.txt_usuario
        Me.txt_usuario.IconLeftSize = New System.Drawing.Size(32, 33)
        Me.txt_usuario.Location = New System.Drawing.Point(402, 399)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txt_usuario.PlaceholderText = ""
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.ShadowDecoration.Parent = Me.txt_usuario
        Me.txt_usuario.Size = New System.Drawing.Size(10, 10)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.BorderColor = System.Drawing.Color.SteelBlue
        Me.txt_pass.BorderRadius = 3
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.DefaultText = ""
        Me.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pass.DisabledState.Parent = Me.txt_pass
        Me.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pass.FocusedState.BorderColor = System.Drawing.SystemColors.Menu
        Me.txt_pass.FocusedState.Parent = Me.txt_pass
        Me.txt_pass.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pass.HoverState.Parent = Me.txt_pass
        Me.txt_pass.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txt_pass.Location = New System.Drawing.Point(70, 262)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txt_pass.PlaceholderText = "Password"
        Me.txt_pass.SelectedText = ""
        Me.txt_pass.ShadowDecoration.Parent = Me.txt_pass
        Me.txt_pass.Size = New System.Drawing.Size(227, 35)
        Me.txt_pass.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Silver
        Me.btn_cancelar.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelar.BorderRadius = 2
        Me.btn_cancelar.BorderThickness = 1
        Me.btn_cancelar.CheckedState.Parent = Me.btn_cancelar
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.CustomImages.Parent = Me.btn_cancelar
        Me.btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancelar.DisabledState.Parent = Me.btn_cancelar
        Me.btn_cancelar.FillColor = System.Drawing.Color.LightGray
        Me.btn_cancelar.FocusedColor = System.Drawing.Color.Silver
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancelar.HoverState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancelar.HoverState.Parent = Me.btn_cancelar
        Me.btn_cancelar.Location = New System.Drawing.Point(197, 333)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.ShadowDecoration.Parent = Me.btn_cancelar
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 40)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        '
        'img_login
        '
        Me.img_login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.img_login.BackColor = System.Drawing.Color.Transparent
        Me.img_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_login.Image = CType(resources.GetObject("img_login.Image"), System.Drawing.Image)
        Me.img_login.ImageRotate = 0!
        Me.img_login.Location = New System.Drawing.Point(109, 49)
        Me.img_login.Name = "img_login"
        Me.img_login.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.img_login.ShadowDecoration.Parent = Me.img_login
        Me.img_login.Size = New System.Drawing.Size(150, 147)
        Me.img_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_login.TabIndex = 5
        Me.img_login.TabStop = False
        Me.img_login.UseTransparentBackground = True
        '
        'cbo_nomeuser
        '
        Me.cbo_nomeuser.BackColor = System.Drawing.Color.Transparent
        Me.cbo_nomeuser.BorderColor = System.Drawing.Color.SteelBlue
        Me.cbo_nomeuser.BorderRadius = 3
        Me.cbo_nomeuser.DisabledState.Parent = Me.cbo_nomeuser
        Me.cbo_nomeuser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_nomeuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nomeuser.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_nomeuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_nomeuser.FocusedState.Parent = Me.cbo_nomeuser
        Me.cbo_nomeuser.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nomeuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbo_nomeuser.HoverState.Parent = Me.cbo_nomeuser
        Me.cbo_nomeuser.ItemHeight = 30
        Me.cbo_nomeuser.ItemsAppearance.Parent = Me.cbo_nomeuser
        Me.cbo_nomeuser.Location = New System.Drawing.Point(70, 202)
        Me.cbo_nomeuser.Name = "cbo_nomeuser"
        Me.cbo_nomeuser.ShadowDecoration.Parent = Me.cbo_nomeuser
        Me.cbo_nomeuser.Size = New System.Drawing.Size(227, 36)
        Me.cbo_nomeuser.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login Here !"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 396)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.cbo_nomeuser)
        Me.Controls.Add(Me.img_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_login)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Frm_login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_cancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents img_login As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents cbo_nomeuser As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
