Public Class FrmCadastroProdutos
    Private Sub FrmCadastroProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_data_prod.Text = Today
        txt_desinacao_prod.CharacterCasing = CharacterCasing.Upper
        txt_nome_prod.CharacterCasing = CharacterCasing.Upper
        txt_qtd_prod.MaxLength = 4
        list_prod.GridLines = True
        list_prod.FullRowSelect = True
        Limpar_Campos_Cadastro()
        Add_combo_cadastro()
        Prenecher_listview()
    End Sub

    Private Sub btn_salvar_prod_Click(sender As Object, e As EventArgs) Handles btn_salvar_prod.Click

        'verificar se os campos estão vazios
        If txt_desinacao_prod.Text = String.Empty Then
            MsgBox("O campo Designação está vazio",, "Atenção")
            txt_desinacao_prod.Focus()
            Exit Sub
        ElseIf txt_nome_prod.Text = String.Empty Then
            MsgBox("O campo Codigo do Produto está vazio",, "Atenção")
            txt_nome_prod.Focus()
            Exit Sub
        ElseIf txt_qtd_prod.Text = String.Empty Then
            MsgBox("O campo Quantidade está vazio",, "Atenção")
            txt_qtd_prod.Focus()
            Exit Sub
        ElseIf cbo_linha_prod.Text = String.Empty Then
            MsgBox("O campo Linha está vazio",, "Atenção")
            cbo_linha_prod.Focus()
            Exit Sub
        ElseIf cbo_unidade.Text = String.Empty Then
            MsgBox("O campo Unidade está vazio",, "Atenção")
            cbo_unidade.Focus()
            Exit Sub
        End If

        Try
            'Adcionando os valores dentro dos campos da nossa classe produtos
            With Me
                sql = "INSERT INTO tb_cadastro (Codigo, Linha, Designacao, Unidade_Medida, Qtd_minima, Data, Data_movimentacao)
                VALUES(@Codigo, @Linha, @Designacao, @Unidade_Medida, @Qtd_minima, @Data, @Data_Movimentacao)"
                Conectar_Mysql()
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("@Codigo", .txt_nome_prod.Text) 'Adcionando os parametros com os valores das propriedades da class
                cmd.Parameters.AddWithValue("@Linha", .cbo_linha_prod.Text)
                cmd.Parameters.AddWithValue("@Designacao", .txt_desinacao_prod.Text)
                cmd.Parameters.AddWithValue("@Unidade_Medida", .cbo_unidade.Text)
                cmd.Parameters.AddWithValue("@Qtd_minima", .txt_qtd_prod.Text)
                cmd.Parameters.AddWithValue("@Data", Format(Now, "yyyy/MM/dd"))
                cmd.Parameters.AddWithValue("@Data_movimentacao", Format(Now, "yyyy/MM/dd"))
                cmd.ExecuteNonQuery() 'Executando o comando 
                Desconectar()
                MsgBox("Cadastrado com sucesso!", MsgBoxStyle.SystemModal, "Salvo")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txt_qtd_prod.Clear()
            txt_desinacao_prod.Clear()
            txt_nome_prod.Clear()
            cbo_linha_prod.Text = ""
            cbo_unidade.Text = ""
            txt_nome_prod.Focus()
            Prenecher_listview()
        End Try


    End Sub

    Private Sub txt_qtd_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd_prod.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub list_prod_Click(sender As Object, e As EventArgs) Handles list_prod.Click
        txt_id_prod.Text = list_prod.SelectedItems(0).SubItems(0).Text
        txt_nome_prod.Text = list_prod.SelectedItems(0).SubItems(1).Text
        txt_desinacao_prod.Text = list_prod.SelectedItems(0).SubItems(2).Text
        cbo_linha_prod.Text = list_prod.SelectedItems(0).SubItems(3).Text
        cbo_unidade.Text = list_prod.SelectedItems(0).SubItems(4).Text
        txt_qtd_prod.Text = list_prod.SelectedItems(0).SubItems(5).Text
    End Sub

    Private Sub btn_editar_prod_Click(sender As Object, e As EventArgs) Handles btn_editar_prod.Click

        Try
            If txt_id_prod.Text = "" Then
                MsgBox("Selecione um Iten na Lista Para Atualizar",, "Aviso!")
                Exit Sub
            End If

            If MsgBox("Deseja Atualizar Este Iten ? ", MsgBoxStyle.SystemModal + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.Ok Then
                Conectar_Mysql()
                sql = "UPDATE tb_cadastro SET Codigo = @Codigo ,Linha = @Linha ,Designacao = @Designacao, Unidade_Medida = @Unidade_Medida
               , Data_movimentacao = @Data_movimentacao, Qtd_minima = @Qtd_minima  
                WHERE ID = " & txt_id_prod.Text
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("@Codigo", txt_nome_prod.Text)
                cmd.Parameters.AddWithValue("@Linha", cbo_linha_prod.Text)
                cmd.Parameters.AddWithValue("@Designacao", txt_desinacao_prod.Text)
                cmd.Parameters.AddWithValue("@Unidade_Medida", cbo_unidade.Text)
                cmd.Parameters.AddWithValue("@Data_movimentacao", Format(Now, "yyyy/MM/dd"))
                cmd.Parameters.AddWithValue("@Qtd_minima", txt_qtd_prod.Text)
                cmd.ExecuteNonQuery()
                Desconectar()
                MsgBox("Atualizado Com Sucesso!", MsgBoxStyle.SystemModal, "Salvo")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txt_qtd_prod.Clear()
            txt_desinacao_prod.Clear()
            txt_nome_prod.Clear()
            cbo_linha_prod.Text = ""
            cbo_unidade.Text = ""
            txt_id_prod.Clear()
            txt_nome_prod.Focus()
            Prenecher_listview()
        End Try
    End Sub

    Private Sub btn_delete_prod_Click(sender As Object, e As EventArgs) Handles btn_delete_prod.Click
        Try
            If txt_id_prod.Text = "" Then
                MsgBox("Selecione um Iten na Lista para Deletar",, "Aviso!")
                Exit Sub
            End If

            If MsgBox("Deseja Deletar Este Iten ?", MsgBoxStyle.SystemModal + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.Ok Then
                Conectar_Mysql()
                sql = "DELETE FROM tb_cadastro WHERE ID = " & txt_id_prod.Text
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("ID", txt_id_prod.Text)
                cmd.ExecuteNonQuery()
                Desconectar()
                MsgBox("Deletado com Sucesso!", MsgBoxStyle.SystemModal, "Atenção")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txt_qtd_prod.Clear()
            txt_desinacao_prod.Clear()
            txt_nome_prod.Clear()
            cbo_linha_prod.Text = ""
            cbo_unidade.Text = ""
            txt_id_prod.Clear()
            txt_nome_prod.Focus()
            Prenecher_listview()
        End Try
    End Sub

    Private Sub FrmCadastroProdutos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.list_prod.Items.Clear()
        Limpar_Campos_Cadastro()
    End Sub

    Public Sub Limpar_Campos_Cadastro()

        Me.txt_desinacao_prod.Text = ""
        Me.txt_id_prod.Text = ""
        Me.txt_nome_prod.Text = ""
        Me.txt_qtd_prod.Text = ""
        Me.cbo_linha_prod.Text = ""
        Me.cbo_unidade.Text = ""
        Me.txt_nome_prod.Focus()
        Me.txt_data_prod.Text = Today

    End Sub

End Class