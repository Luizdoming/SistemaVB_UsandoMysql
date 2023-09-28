Module Buscar_imagem

    Public Sub Pegar_img()
        Dim file As New OpenFileDialog

        'comando de verificação para buscar nossa imagem em uma pasta 
        If file.ShowDialog <> DialogResult.Cancel Then
            FrmUser.imagem_user.Image = Image.FromFile(file.FileName)
        Else
            FrmUser.imagem_user.Image = Nothing
            Exit Sub
        End If

    End Sub

    Public Sub Adcionar_user_comboUser()

        Try
            Conectar_Mysql()
            sql = "SELECT Nome FROM users"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader
            Frm_login.cbo_nomeuser.Items.Clear()

            While dr.Read
                Frm_login.cbo_nomeuser.Items.Add(dr.GetString("Nome"))
            End While

            dr.Close()
            Desconectar()

        Catch ex As Exception
            MsgBox(ex.Message)
            Desconectar()
        End Try

    End Sub


End Module
