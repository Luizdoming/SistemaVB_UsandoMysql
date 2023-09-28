'para converter imagem em binario temos que usar este recurso
'importando o modulo de sistema - o system.io
Imports System.IO
Module M_Salvar

    Public Sub salvar_usuarios()

        'verificando se os campos estão preenchidos
        If FrmUser.txt_nome_user.Text = "" Or FrmUser.txt_senha_user.Text = "" Then
            MessageBox.Show("Os campos são Obrigatórios", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Try
                Conectar_Mysql()
                Dim nome As String
                Dim senha As String

                sql = "Select * from users"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                dr = cmd.ExecuteReader

                nome = FrmUser.txt_nome_user.Text
                senha = FrmUser.txt_senha_user.Text

                While dr.Read
                    If dr("Nome") = nome.ToUpper Then
                        MsgBox("Usuário já cadastrado, tente outro nome", MsgBoxStyle.Information, "Aviso!")
                        Desconectar()
                        FrmUser.txt_nome_user.Focus()
                        Exit Sub
                    ElseIf dr("Senha") = senha Then
                        MsgBox("Senha já cadastrada, tente outra senha", MsgBoxStyle.Information, "Aviso!")
                        Desconectar()
                        FrmUser.txt_nome_user.Focus()
                        Exit Sub
                    End If
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
                Desconectar()
                Exit Sub
            End Try

            Desconectar()
            Conectar_Mysql()

            If CLng(0 & FrmUser.txt_id_user.Text) = 0 Then
                sql = "INSERT INTO users (Nome, Senha, Data, img)
                VALUES(@Nome, @Senha, @Data, @img)"
                MsgBox("Usuário Adcionado com Sucesso !", MsgBoxStyle.Information, "Salvo")
            Else
                sql = "UPDATE users SET Nome = @Nome, Senha = @Senha, Data = " & "'" & FrmUser.lbl_data_user.Text & "'" & ", img = @img WHERE idUsers = " & FrmUser.txt_id_user.Text
                MsgBox("Usuário atualizado com sucesso !", MsgBoxStyle.Information, "Atualizado")
            End If

            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Nome", FrmUser.txt_nome_user.Text.ToUpper)
            cmd.Parameters.AddWithValue("@Senha", Encriptar(FrmUser.txt_senha_user.Text))
            cmd.Parameters.AddWithValue("@Data", FrmUser.lbl_data_user.Text)

            'converter imagem para binario
            '-------------------------------------------------------------------------------------
            'temos que colocar o tipo da imagem no campo do banco de dados em formato MedioumBlob
            'coso seja somente blob - aparecera um erro informando que o campo da coluna é menor 
            'que a conversão
            '-------------------------------------------------------------------------------------
            Dim size_file As New UInt32
            Dim mstream As New MemoryStream

            If FrmUser.imagem_user.Image.ToString <> Nothing Then
                FrmUser.imagem_user.Image.Save(mstream, Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                size_file = mstream.Length
                mstream.Close()
                'cmd.Parameters.Add("@img", MySql.Data.MySqlClient.MySqlDbType.Blob)
                cmd.Parameters.AddWithValue("@img", picture)
                cmd.ExecuteNonQuery()
                MsgBox("Processo Concluido !", MsgBoxStyle.ApplicationModal, "Salvo")
                Desconectar()
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Processo Concluido !", MsgBoxStyle.ApplicationModal, "Salvo")
                Desconectar()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Desconectar()
        End Try

        FrmUser.txt_senha_user.Text = String.Empty
        FrmUser.txt_id_user.Text = String.Empty
        FrmUser.txt_nome_user.Text = String.Empty
        FrmUser.imagem_user.Image = Nothing

    End Sub

    Public Sub Adcionar_saidas()
        Dim controle As Control

        Try
            'Verificando se os campos estão vazios
            '----------------------------------------------
            For Each controle In frm_Movimentacao.Controls
                If TypeOf controle Is TextBox Then
                    If controle.Text = String.Empty Then
                        MsgBox("Os campos são obrigatórios",, "Aviso!")
                        controle.Focus()
                        Exit Sub
                    End If
                End If
            Next
            '-----------------------------------------------

            Conectar_Mysql()
            sql = "SELECT Qtd_real FROM tb_cadastro WHERE Codigo ='" & frm_Movimentacao.txt_pesuisa_movimen.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            If dr.Read Then
                If dr("Qtd_real") < frm_Movimentacao.txt_qtd_movim.Text Then
                    MsgBox("Quantidade insuficiente!",, "Aviso!")
                    Desconectar()
                    Exit Sub
                Else
                    sql = ""
                    Desconectar()
                    Conectar_Mysql()
                    sql = "INSERT INTO tb_saidas (Codigo, Designacao, Unidade_Medida, Data_saida, Linha, Quantidade_saida) 
                    VALUES(@Codigo, @Designacao, @Unidade_Medida, @Data_Saida, @Linha, @Quantidade_saida)"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                    cmd.Parameters.AddWithValue("@Codigo", frm_Movimentacao.txt_pesuisa_movimen.Text)
                    cmd.Parameters.AddWithValue("@Designacao", frm_Movimentacao.txt_sesignacao_movim.Text)
                    cmd.Parameters.AddWithValue("@Unidade_Medida", frm_Movimentacao.txt_unidade_movi.Text)
                    cmd.Parameters.AddWithValue("@Data_Saida", Now)
                    cmd.Parameters.AddWithValue("@Linha", frm_Movimentacao.txt_linha_movim.Text)
                    cmd.Parameters.AddWithValue("@Quantidade_saida", CSng(frm_Movimentacao.txt_qtd_movim.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Adcionado com Sucesso!",, "Aviso!")
                    Desconectar()
                    Carregar_Dados_Saidas()
                End If
            End If

            For Each controle In frm_Movimentacao.Controls
                If TypeOf controle Is TextBox Then
                    controle.Text = String.Empty
                End If
            Next

            frm_Movimentacao.txt_data_movim.Text = Today
            frm_Movimentacao.txt_pesuisa_movimen.Focus()

        Catch ex As Exception
            MsgBox("Erro ao salvar os dados na tabela saida" & ex.Message,, "Aviso!")
            Desconectar()
        End Try

    End Sub

    Public Sub Adcionar_Entradas()
        Dim controle As Control

        Try
            'Verificando se os campos estão vazios
            '----------------------------------------------
            For Each controle In frm_Movimentacao.Controls
                If TypeOf controle Is TextBox Then
                    If controle.Text = String.Empty Then
                        MsgBox("Os campos são obrigatórios",, "Aviso!")
                        controle.Focus()
                        Exit Sub
                    End If
                End If
            Next
            '-----------------------------------------------

            Conectar_Mysql()
            sql = "INSERT INTO tb_entradas (Codigo, Designacao, Unidade_Medida, Data_entrada, Linha, Quantidade_entrada)
            VALUES(@Codigo, @Designacao, @Unidade_Medida, @Data_entrada, @Linha, @Quantidade_entrada)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Codigo", frm_Movimentacao.txt_pesuisa_movimen.Text)
            cmd.Parameters.AddWithValue("@Designacao", frm_Movimentacao.txt_sesignacao_movim.Text)
            cmd.Parameters.AddWithValue("@Unidade_Medida", frm_Movimentacao.txt_unidade_movi.Text)
            cmd.Parameters.AddWithValue("@Data_entrada", Now)
            cmd.Parameters.AddWithValue("@Linha", frm_Movimentacao.txt_linha_movim.Text)
            cmd.Parameters.AddWithValue("@Quantidade_Entrada", CSng(frm_Movimentacao.txt_qtd_movim.Text))
            cmd.ExecuteNonQuery()
            MsgBox("Dados Adcionado com Sucesso!",, "Aviso!")
            Desconectar()
            Carregar_dados_Entradas()

            For Each controle In frm_Movimentacao.Controls
                If TypeOf controle Is TextBox Then
                    controle.Text = String.Empty
                End If
            Next

            frm_Movimentacao.txt_data_movim.Text = Today
            frm_Movimentacao.txt_pesuisa_movimen.Focus()
        Catch ex As Exception
            MsgBox("Erro ao salvar os dados na tabela Entradas" & ex.Message,, "Aviso!")
            Desconectar()
        End Try
    End Sub

    Public Sub Editar_Saida()
        Dim chave As String
        'Verificando se os campos estão vazios
        Verificar_Campos(frm_Movimentacao.Controls)
        Try
            If frm_Movimentacao.txt_pesuisa_movimen.Text = String.Empty Then
                Exit Sub
            Else
                chave = frm_Movimentacao.txt_pesuisa_movimen.Text
            End If

            Conectar_Mysql()
            sql = "UPDATE tb_saidas SET Designacao=@Designacao, Unidade_Medida=@unidade_Medida, Linha=@Linha, Quantidade_saida=@Quantidade_saida WHERE Codigo ='" & chave & "'"

            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Designacao", frm_Movimentacao.txt_sesignacao_movim.Text)
            cmd.Parameters.AddWithValue("@Unidade_Medida", frm_Movimentacao.txt_unidade_movi.Text)
            cmd.Parameters.AddWithValue("@Linha", frm_Movimentacao.txt_linha_movim.Text)
            cmd.Parameters.AddWithValue("@Quantidade_saida", frm_Movimentacao.txt_qtd_movim.Text)
            cmd.ExecuteNonQuery()
            Desconectar()
            MsgBox("Editado com Sucesso!",, "Aviso!")
            Limpar_Campos_Movimentacao()
            Carregar_Dados_Saidas()
        Catch ex As Exception
            MsgBox("Erro ao Editar os dados" & vbNewLine,, "Atenção")
        End Try

    End Sub

    Public Sub Editar_Entradas()
        Dim chave As String
        'Verificando se os campos estão vazios
        Verificar_Campos(frm_Movimentacao.Controls)
        Try
            If frm_Movimentacao.txt_pesuisa_movimen.Text = String.Empty Then
                Exit Sub
            Else
                chave = frm_Movimentacao.txt_pesuisa_movimen.Text
            End If

            Conectar_Mysql()
            sql = "UPDATE tb_entradas SET Designacao=@Designacao, Unidade_Medida=@unidade_Medida, Linha=@Linha, Quantidade_entrada=@Quantidade_entrada WHERE Codigo ='" & chave & "'"

            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Designacao", frm_Movimentacao.txt_sesignacao_movim.Text)
            cmd.Parameters.AddWithValue("@Unidade_Medida", frm_Movimentacao.txt_unidade_movi.Text)
            cmd.Parameters.AddWithValue("@Linha", frm_Movimentacao.txt_linha_movim.Text)
            cmd.Parameters.AddWithValue("@Quantidade_entrada", CSng(frm_Movimentacao.txt_qtd_movim.Text))
            cmd.ExecuteNonQuery()
            Desconectar()
            MsgBox("Editado com Sucesso!",, "Aviso!")
            Limpar_Campos_Movimentacao()
            Carregar_dados_Entradas()
        Catch ex As Exception
            MsgBox("Erro ao Editar os dados" & vbNewLine & ex.Message,, "Atenção")
            Desconectar()
        End Try
    End Sub

    Public Sub Carregar_Dados_Saidas()
        Dim i As Integer
        Dim lista As ListViewItem
        Try
            Conectar_Mysql()
            sql = "SELECT Codigo, Designacao, Unidade_Medida, Linha, Quantidade_saida FROM tb_saidas ORDER BY Designacao"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader
            frm_Movimentacao.list_movimentacao.Items.Clear()

            While dr.Read
                lista = frm_Movimentacao.list_movimentacao.Items.Add(dr.GetString(0))
                For i = 1 To 4
                    lista.SubItems.Add(dr.GetString(i))
                Next
            End While

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados da tabela saida" & vbNewLine & Err.Description & vbNewLine & ex.Message,, "Aviso!")
        Finally
            Desconectar()
        End Try
    End Sub

    Public Sub Carregar_dados_Entradas()
        Dim i As Integer
        Dim lista As ListViewItem
        Try
            Conectar_Mysql()
            sql = "SELECT Codigo, Designacao, Unidade_Medida, Linha, Quantidade_entrada FROM tb_entradas ORDER BY Designacao"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader
            frm_Movimentacao.list_movimentacao.Items.Clear()

            While dr.Read
                lista = frm_Movimentacao.list_movimentacao.Items.Add(dr.GetString(0))
                For i = 1 To 4
                    lista.SubItems.Add(dr.GetString(i))
                Next
            End While

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados da tabela saida" & vbNewLine & Err.Description & vbNewLine & ex.Message,, "Aviso!")
        Finally
            Desconectar()
        End Try
    End Sub

    Public Sub Pesquisar_item_movime()
        Dim chave As String

        Try
            If frm_Movimentacao.txt_pesuisa_movimen.Text = String.Empty Then
                MsgBox("Campo de pesquisa está vazio" & vbNewLine & Err.Description,, "Atenção")
                Exit Sub
            Else
                chave = frm_Movimentacao.txt_pesuisa_movimen.Text
                Conectar_Mysql()
                sql = "SELECT Codigo, Designacao, Unidade_Medida, Linha FROM tb_cadastro WHERE Codigo = @Codigo"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("@Codigo", frm_Movimentacao.txt_pesuisa_movimen.Text)
                dr = cmd.ExecuteReader

                If dr.Read() Then
                    With frm_Movimentacao
                        .txt_pesuisa_movimen.Text = dr.GetString("Codigo")
                        .txt_sesignacao_movim.Text = dr.GetString("Designacao")
                        .txt_unidade_movi.Text = dr.GetString("Unidade_Medida")
                        .txt_linha_movim.Text = dr.GetString("Linha")
                        Desconectar()
                        dr.Close()
                        dr.Dispose()
                    End With
                Else
                    MsgBox("Iten não encontrado",, "Aviso!")
                    Desconectar()
                    dr.Close()
                    dr.Dispose()
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar iten" & vbNewLine & ex.Message,, "Atenção")
        End Try


    End Sub

    Public Sub Limpar_Campos_Movimentacao()
        Dim cont As Control

        For Each cont In frm_Movimentacao.Controls
            If TypeOf cont Is TextBox Then
                cont.Text = String.Empty
            End If
        Next

        frm_Movimentacao.txt_pesuisa_movimen.Focus()
        frm_Movimentacao.txt_data_movim.Text = Today

    End Sub

    Public Sub Salvar_Lin_Unid()
        Dim Nome_unidade As String
        Dim linha As String

        Try
            'VERIFICANDO SE OS CAMPOS ESTÃO PREENCHIDOS
            '------------------------------------------
            If frm_linhas.txt_linha.Text = String.Empty Then
                MsgBox("O campo nome da linha está vazio.", vbApplicationModal, "Atenção")
                GoTo verificar_unidade
            End If
            '------------------------------------------------------------------------------

            linha = frm_linhas.txt_linha.Text
            Conectar_Mysql()
            sql = "SELECT * FROM tb_linhas"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            'VERIFICANDO SE JA EXISTE UMA LINHA CADASTRADA COM O MESMO NOME
            While dr.Read
                If dr("Nome_linha") = linha Then
                    MsgBox("Esta linha ja está cadastrada.",, "Atenção")
                    dr.Close()
                    Desconectar()
                    sql = ""
                    GoTo verificar_unidade
                End If
            End While
            '----------------------------------------------------------------

            cmd.Dispose()
            dr.Close()

            'ROTINA PRA INSERIR UM NOVO REGISTRO NA TABELA DE LINHAS
            sql = ""
            sql = "INSERT INTO tb_linhas (Nome_linha, Data) VALUES (@Nome_linha, @Data)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Nome_linha", linha)
            cmd.Parameters.AddWithValue("@Data", Today)
            cmd.ExecuteNonQuery()
            GoTo sair
            '------------------------------------------------------

verificar_unidade:

            If frm_linhas.txt_unidade.Text = String.Empty Then
                MsgBox("O campo nome da unidade está vazio.", vbApplicationModal, "Atenção")
                Exit Sub
            End If

            Nome_unidade = frm_linhas.txt_unidade.Text
            Conectar_Mysql()
            sql = "SELECT * FROM tb_unidade_medidas"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            'VERIFICA SE O NOME DA UNIDADE JA ESTÁ CADASTRADA
            While dr.Read
                If dr("Nome_Unidade") = Nome_unidade Then
                    MsgBox("Unidade ja está cadastrada.",, "Atenção")
                    dr.Close()
                    Desconectar()
                    sql = ""
                    Exit Sub
                End If
            End While
            '-------------------------------------------------------

            'ROTINA PRA INSERIR O NOVO REGISTRO NA TABELA DE UNIDADE
            sql = ""
            cmd.Dispose()
            dr.Close()

            sql = "INSERT INTO tb_unidade_medidas (Nome_Unidade, Data) VALUES (@Nome_Unidade, @Data)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Nome_Unidade", Nome_unidade)
            cmd.Parameters.AddWithValue("@Data", Today)
            cmd.ExecuteNonQuery()
            GoTo sair
            '------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
            Desconectar()
            Exit Sub
        End Try
sair:
        Desconectar()
        dr.Close()
        MsgBox("Dados salvo com sucesso!",, "OK!")
        frm_linhas.txt_linha.Clear()
        frm_linhas.txt_unidade.Clear()
    End Sub

    Public Sub Adcionar_dados_lin_medida()

        Dim lista As ListViewItem
        'Iniciando o processo de adcionar os dados dentro da lista de unidades
        '---------------------------------------------------------------------
        Try
            Conectar_Mysql()
            sql = "SELECT ID, Nome_Unidade FROM tb_unidade_medidas ORDER BY Nome_Unidade"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            With frm_linhas
                .List_linhas.Items.Clear()
                .List_unidades.Items.Clear()
            End With

            While dr.Read
                lista = frm_linhas.List_unidades.Items.Add(dr("Nome_Unidade"))
                lista.SubItems.Add(dr("ID"))
            End While

            Desconectar()
            dr.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados da tabela unidades" & ex.Message,, "Aviso!")
            Desconectar()
        End Try

        Try
            Conectar_Mysql()
            sql = "SELECT ID, Nome_linha FROM tb_linhas ORDER BY Nome_linha"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            While dr.Read
                lista = frm_linhas.List_linhas.Items.Add(dr.GetString(1))
                lista.SubItems.Add(dr.GetString(0))
            End While

            Desconectar()
            dr.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados da tabela linhas" & ex.Message,, "Aviso!")
            Desconectar()
        End Try

    End Sub

    Public Sub Editar_Linhas_unidades()

        'VAMOS VER UM RECURSO QUE EXISTE DENTRO DO VBA - VISUAL BASIC FOR APPLICATION
        'QUE É O TRATAMENTO DE ERRO COM USO DO -> ON ERROR GOTO

        'VARIAVEL PARA MANIPULAR O ID EXISTENTE NA CAIXA DE TEXTO
        Dim ID As Int16

        'VERIFICAR SE OS CAMPOS ESTÃO PREENCHIDOS
        On Error GoTo Erro

        If frm_linhas.Guna2RadioButton1.Checked = False And frm_linhas.Guna2RadioButton2.Checked = False Then
            MsgBox("Selecione uma Opção!",, "Atenção")
            Exit Sub
        End If

        With frm_linhas
            'INICIANDO A INSERÇÃO DOS DADOS NA TABELA UNIDADE
            If .Guna2RadioButton1.Checked = True Then
                If .txt_id_editar.TextLength = 0 Or .txt_unidade.TextLength = 0 Then
                    MsgBox("O campo id está vazio, para editar selecione um item de uma das listas", MsgBoxStyle.ApplicationModal, "Atenção")
                    Exit Sub
                Else
                    ID = .txt_id_editar.Text
                    sql = "UPDATE tb_unidade_medidas SET Nome_Unidade = @Nome_Unidade WHERE ID=@ID"
                    Conectar_Mysql()
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                    cmd.Parameters.AddWithValue("@Nome_Unidade", .txt_unidade.Text)
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.ExecuteNonQuery()
                    MsgBox("Unidade editada com sucesso!",, "Editado")
                    On Error GoTo 0
                    GoTo sair
                End If
            End If
linhas:
            'INICIANDO A INSERÇÃO DOS DADOS NA TABELA LINHAS
            If .Guna2RadioButton2.Checked = True Then
                If .txt_id_editar.TextLength = 0 Or .txt_linha.TextLength = 0 Then
                    MsgBox("O campo id está vazio, para editar selecione um item de uma das listas", MsgBoxStyle.ApplicationModal, "Atenção")
                    Exit Sub
                Else
                    ID = .txt_id_editar.Text
                    sql = "UPDATE tb_linhas SET Nome_linha = @Nome_linha WHERE ID=@ID"
                    Conectar_Mysql()
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                    cmd.Parameters.AddWithValue("@Nome_linha", .txt_linha.Text)
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.ExecuteNonQuery()
                    MsgBox("Linha editada com sucesso!",, "Editado")
                    On Error GoTo 0
                    GoTo sair
                End If
            End If
        End With

        'ROTULOS DOS TRATAMENTOS DE ERROS
sair:
        On Error Resume Next
        Desconectar()
        frm_linhas.txt_id_editar.Clear()
        frm_linhas.txt_unidade.Clear()
        frm_linhas.txt_linha.Clear()
        Exit Sub
Erro:
        MsgBox("Erro ao editar os dados verifique!" & Err.Description,, "Atenção")
        Resume sair

    End Sub
End Module
