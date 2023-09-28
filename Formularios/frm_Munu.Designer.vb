<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Munu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Munu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.bt_desliga = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_lin_unidade = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_esto = New Guna.UI2.WinForms.Guna2TileButton()
        Me.bt_report = New Guna.UI2.WinForms.Guna2TileButton()
        Me.bt_cad = New Guna.UI2.WinForms.Guna2TileButton()
        Me.bt_movi = New Guna.UI2.WinForms.Guna2TileButton()
        Me.bt_user = New Guna.UI2.WinForms.Guna2TileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbl_data
        '
        Me.lbl_data.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_data.BackColor = System.Drawing.Color.White
        Me.lbl_data.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Location = New System.Drawing.Point(1287, 700)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(92, 24)
        Me.lbl_data.TabIndex = 2
        '
        'lbl_hora
        '
        Me.lbl_hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_hora.BackColor = System.Drawing.Color.White
        Me.lbl_hora.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_hora.Location = New System.Drawing.Point(1252, 723)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(121, 26)
        Me.lbl_hora.TabIndex = 1
        Me.lbl_hora.Text = "00:00:00"
        Me.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.Controls.Add(Me.bt_desliga)
        Me.Guna2Panel1.Controls.Add(Me.btn_lin_unidade)
        Me.Guna2Panel1.Controls.Add(Me.bt_esto)
        Me.Guna2Panel1.Controls.Add(Me.bt_report)
        Me.Guna2Panel1.Controls.Add(Me.bt_cad)
        Me.Guna2Panel1.Controls.Add(Me.bt_movi)
        Me.Guna2Panel1.Controls.Add(Me.bt_user)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(67, 749)
        Me.Guna2Panel1.TabIndex = 6
        '
        'bt_desliga
        '
        Me.bt_desliga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_desliga.BorderRadius = 3
        Me.bt_desliga.CheckedState.Parent = Me.bt_desliga
        Me.bt_desliga.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.bt_desliga.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_desliga.CustomImages.ImageSize = New System.Drawing.Size(33, 35)
        Me.bt_desliga.CustomImages.Parent = Me.bt_desliga
        Me.bt_desliga.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_desliga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_desliga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_desliga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_desliga.DisabledState.Parent = Me.bt_desliga
        Me.bt_desliga.FillColor = System.Drawing.Color.Transparent
        Me.bt_desliga.FocusedColor = System.Drawing.Color.Gray
        Me.bt_desliga.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_desliga.ForeColor = System.Drawing.Color.DimGray
        Me.bt_desliga.HoverState.Parent = Me.bt_desliga
        Me.bt_desliga.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_desliga.Location = New System.Drawing.Point(2, 699)
        Me.bt_desliga.Name = "bt_desliga"
        Me.bt_desliga.ShadowDecoration.Parent = Me.bt_desliga
        Me.bt_desliga.Size = New System.Drawing.Size(150, 44)
        Me.bt_desliga.TabIndex = 12
        Me.bt_desliga.Text = "    Off"
        '
        'btn_lin_unidade
        '
        Me.btn_lin_unidade.BorderRadius = 3
        Me.btn_lin_unidade.CheckedState.Parent = Me.btn_lin_unidade
        Me.btn_lin_unidade.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btn_lin_unidade.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_lin_unidade.CustomImages.ImageSize = New System.Drawing.Size(41, 35)
        Me.btn_lin_unidade.CustomImages.Parent = Me.btn_lin_unidade
        Me.btn_lin_unidade.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_lin_unidade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_lin_unidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_lin_unidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_lin_unidade.DisabledState.Parent = Me.btn_lin_unidade
        Me.btn_lin_unidade.FillColor = System.Drawing.Color.Transparent
        Me.btn_lin_unidade.FocusedColor = System.Drawing.Color.Gray
        Me.btn_lin_unidade.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lin_unidade.ForeColor = System.Drawing.Color.Gray
        Me.btn_lin_unidade.HoverState.Parent = Me.btn_lin_unidade
        Me.btn_lin_unidade.Location = New System.Drawing.Point(2, 441)
        Me.btn_lin_unidade.Name = "btn_lin_unidade"
        Me.btn_lin_unidade.ShadowDecoration.Parent = Me.btn_lin_unidade
        Me.btn_lin_unidade.Size = New System.Drawing.Size(150, 47)
        Me.btn_lin_unidade.TabIndex = 7
        Me.btn_lin_unidade.Text = "          Lin_Uni"
        '
        'bt_esto
        '
        Me.bt_esto.BorderRadius = 3
        Me.bt_esto.CheckedState.Parent = Me.bt_esto
        Me.bt_esto.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.bt_esto.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_esto.CustomImages.ImageSize = New System.Drawing.Size(35, 28)
        Me.bt_esto.CustomImages.Parent = Me.bt_esto
        Me.bt_esto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_esto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_esto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_esto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_esto.DisabledState.Parent = Me.bt_esto
        Me.bt_esto.FillColor = System.Drawing.Color.Transparent
        Me.bt_esto.FocusedColor = System.Drawing.Color.Gray
        Me.bt_esto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_esto.ForeColor = System.Drawing.Color.Gray
        Me.bt_esto.HoverState.Parent = Me.bt_esto
        Me.bt_esto.Location = New System.Drawing.Point(2, 187)
        Me.bt_esto.Name = "bt_esto"
        Me.bt_esto.ShadowDecoration.Parent = Me.bt_esto
        Me.bt_esto.Size = New System.Drawing.Size(150, 47)
        Me.bt_esto.TabIndex = 11
        Me.bt_esto.Text = "          Estoque"
        '
        'bt_report
        '
        Me.bt_report.BorderRadius = 3
        Me.bt_report.CheckedState.Parent = Me.bt_report
        Me.bt_report.CustomImages.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.bt_report.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_report.CustomImages.ImageSize = New System.Drawing.Size(35, 28)
        Me.bt_report.CustomImages.Parent = Me.bt_report
        Me.bt_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_report.DisabledState.Parent = Me.bt_report
        Me.bt_report.FillColor = System.Drawing.Color.Transparent
        Me.bt_report.FocusedColor = System.Drawing.Color.Gray
        Me.bt_report.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_report.ForeColor = System.Drawing.Color.Gray
        Me.bt_report.HoverState.Parent = Me.bt_report
        Me.bt_report.Location = New System.Drawing.Point(2, 250)
        Me.bt_report.Name = "bt_report"
        Me.bt_report.ShadowDecoration.Parent = Me.bt_report
        Me.bt_report.Size = New System.Drawing.Size(150, 47)
        Me.bt_report.TabIndex = 10
        Me.bt_report.Text = "       Report"
        '
        'bt_cad
        '
        Me.bt_cad.BorderRadius = 3
        Me.bt_cad.CheckedState.Parent = Me.bt_cad
        Me.bt_cad.CustomImages.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.bt_cad.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_cad.CustomImages.ImageSize = New System.Drawing.Size(35, 28)
        Me.bt_cad.CustomImages.Parent = Me.bt_cad
        Me.bt_cad.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_cad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_cad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_cad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_cad.DisabledState.Parent = Me.bt_cad
        Me.bt_cad.FillColor = System.Drawing.Color.Transparent
        Me.bt_cad.FocusedColor = System.Drawing.Color.Gray
        Me.bt_cad.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cad.ForeColor = System.Drawing.Color.Gray
        Me.bt_cad.HoverState.Parent = Me.bt_cad
        Me.bt_cad.Location = New System.Drawing.Point(2, 313)
        Me.bt_cad.Name = "bt_cad"
        Me.bt_cad.ShadowDecoration.Parent = Me.bt_cad
        Me.bt_cad.Size = New System.Drawing.Size(150, 47)
        Me.bt_cad.TabIndex = 9
        Me.bt_cad.Text = "          Cadastro"
        '
        'bt_movi
        '
        Me.bt_movi.BorderRadius = 3
        Me.bt_movi.CheckedState.Parent = Me.bt_movi
        Me.bt_movi.CustomImages.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.bt_movi.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_movi.CustomImages.ImageSize = New System.Drawing.Size(35, 28)
        Me.bt_movi.CustomImages.Parent = Me.bt_movi
        Me.bt_movi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_movi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_movi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_movi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_movi.DisabledState.Parent = Me.bt_movi
        Me.bt_movi.FillColor = System.Drawing.Color.Transparent
        Me.bt_movi.FocusedColor = System.Drawing.Color.Gray
        Me.bt_movi.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_movi.ForeColor = System.Drawing.Color.Gray
        Me.bt_movi.HoverState.Parent = Me.bt_movi
        Me.bt_movi.Location = New System.Drawing.Point(2, 376)
        Me.bt_movi.Name = "bt_movi"
        Me.bt_movi.ShadowDecoration.Parent = Me.bt_movi
        Me.bt_movi.Size = New System.Drawing.Size(150, 47)
        Me.bt_movi.TabIndex = 8
        Me.bt_movi.Text = "      Movi"
        '
        'bt_user
        '
        Me.bt_user.BorderRadius = 3
        Me.bt_user.CheckedState.Parent = Me.bt_user
        Me.bt_user.CustomImages.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.bt_user.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_user.CustomImages.ImageSize = New System.Drawing.Size(35, 28)
        Me.bt_user.CustomImages.Parent = Me.bt_user
        Me.bt_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_user.DisabledState.Parent = Me.bt_user
        Me.bt_user.FillColor = System.Drawing.Color.Transparent
        Me.bt_user.FocusedColor = System.Drawing.Color.Gray
        Me.bt_user.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_user.ForeColor = System.Drawing.Color.Gray
        Me.bt_user.HoverState.Parent = Me.bt_user
        Me.bt_user.Location = New System.Drawing.Point(2, 124)
        Me.bt_user.Name = "bt_user"
        Me.bt_user.ShadowDecoration.Parent = Me.bt_user
        Me.bt_user.Size = New System.Drawing.Size(150, 47)
        Me.bt_user.TabIndex = 7
        Me.bt_user.Text = "          Usuário"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frm_Munu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_data)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Munu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents bt_desliga As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bt_esto As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bt_report As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bt_cad As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bt_movi As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents bt_user As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_lin_unidade As Guna.UI2.WinForms.Guna2Button
End Class
