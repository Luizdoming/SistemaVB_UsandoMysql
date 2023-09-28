Imports System.IO
Public Class Frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load

        txt_pass.PasswordChar = Chr(149)
        txt_usuario.CharacterCasing = CharacterCasing.Upper
        Adcionar_user_comboUser()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MsgBox("Deseja Fechar sua Aplicação ?", MsgBoxStyle.DefaultButton2 + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkCancel, "Aviso!") = MsgBoxResult.Ok Then
            Application.Exit()
        Else
            txt_usuario.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        '--------------VALIDANDO SE OS CAMPOS ESTÃO PREENCHIDOS'----------
        With Me
            If cbo_nomeuser.Text = "" Or txt_pass.Text = "" Then
                MsgBox("Os campos são Obrigatórios", MsgBoxStyle.ApplicationModal, "Aviso")
                .cbo_nomeuser.Focus()
                Exit Sub
            End If

            '--------------VERIFICANDO SE O USUÁRIO EXISTE NO BANCO DE DADOS---------------
            Try
                Conectar_Mysql()
                sql = "SELECT * FROM users WHERE Nome=@Nome AND Senha=@Senha"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("@Nome", Trim(.cbo_nomeuser.Text))
                cmd.Parameters.AddWithValue("@Senha", Encriptar(Trim(.txt_pass.Text)))
                dr = cmd.ExecuteReader

                If dr.Read Then
                    frm_Munu.Text = "Usuário Logado é -> " & dr("Nome")
                    Desconectar()
                    .txt_pass.Clear()
                    .txt_usuario.Clear()
                    .cbo_nomeuser.Focus()
                    Dispose()
                    frm_Munu.ShowDialog()
                    Exit Sub
                Else
                    MsgBox("Usuário não registrado", MsgBoxStyle.ApplicationModal, "Aviso!")
                    .txt_pass.Clear()
                    .txt_usuario.Clear()
                    .cbo_nomeuser.Focus()
                End If
                Exit Sub

            Catch ex As Exception
                MsgBox("Erro ao Selecionar usuário" & vbNewLine & ex.Message, MsgBoxStyle.ApplicationModal, "Aviso!")
            End Try
        End With
    End Sub

    Private Sub cbo_nomeuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_nomeuser.SelectedIndexChanged

        img_login.Image = Nothing
        Dim picture() As Byte
        Dim dt As DataTable

        Try
            sql = "SELECT Nome, img FROM users WHERE Nome = @Nome"
            Conectar_Mysql()
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Nome", cbo_nomeuser.Text)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            picture = dt.Rows(0).Item("img")

            'converter a imagem do banco de dados que esta em binario para formato de imagem
            Dim mstream As New MemoryStream(picture)
            img_login.Image = Image.FromStream(mstream)
            Desconectar()

        Catch ex As Exception
            MsgBox("Imagem do usuário não encontrada", MsgBoxStyle.Information, "Imagem")
            Desconectar()
            Exit Sub
        End Try
    End Sub
End Class