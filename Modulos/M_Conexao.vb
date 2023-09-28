Imports System.IO
Imports MySql.Data.MySqlClient

Module M_Conexao
    'declaração das variaveis publicas para usarmos em todo nosso projeto
    '-------------------------------------------------------------------
    Public cs As MySqlConnection '("Server=localhost;Database=stock_sytem;Uid=root;password=270815**;")
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader

    Public sql As String
    Public user As String
    Public pas As String

    Public Sub Conectar_Mysql()
        cs = New MySqlConnection("Server=localhost;Database=stock_sytem;Uid=root;password=270815**;")
        Try
            cs.Open()
            Exit Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            cs.Close()
            cs.Dispose()
            cs = Nothing
            cmd = Nothing
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub CarregarDados()
        Dim chave As String
        Dim dt As New DataTable

        If frmestoque.txt_pesquisa.Text = "" Then
            MsgBox("Campo de pesquisa está vazio", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal, "Aviso!")
            Exit Sub
        Else
            chave = frmestoque.txt_pesquisa.Text
            Conectar_Mysql()
            frmestoque.dataGrid.Columns.Clear()
        End If

        Try
            'Codigo, Linha, Designacao, Unidade_Medida, Qtd_real, Data_movimentacao, Status, Total_Rolos
            sql = "SELECT * FROM tb_cadastro WHERE Designacao LIKE '%" & chave & "%'"
            cmd = New MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Designacao", chave)
            da = New MySqlDataAdapter(sql, cs)
            da.Fill(dt)
            frmestoque.dataGrid.DataSource = dt
            frmestoque.lbl_total.Text = "Encontramos Um Total de: " & frmestoque.dataGrid.Rows.Count - 1 & " Registros"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cs.Close()
            cs.Dispose()
            cmd = Nothing
            cs = Nothing
        End Try
    End Sub

    Public Sub CarregarDuplo()
        Dim chave As String
        Dim linha As String
        Dim dt As New DataTable

        If frmestoque.txt_pesquisa.Text = "" Or frmestoque.cbo_dados.Text = "" Then
            MsgBox("Campos são Obrigatorios", MsgBoxStyle.Information, "Aviso!")
            Exit Sub
        Else
            chave = frmestoque.txt_pesquisa.Text
            linha = frmestoque.cbo_dados.Text
            Conectar_Mysql()
            frmestoque.dataGrid.Columns.Clear()
        End If

        Try
            'Codigo, Linha, Designacao, Unidade_Medida, Qtd_real, Data_movimentacao, Status, Total_Rolos
            sql = "SELECT * FROM tb_cadastro WHERE Linha LIKE '%" & linha & "%'" & "AND Designacao LIKE'%" & chave & "%'"
            cmd = New MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@linha", linha)
            cmd.Parameters.AddWithValue("@Designacao", chave)
            da = New MySqlDataAdapter(sql, cs) 'aqui poderia usar como parametro so o cmd -> ficaria assim -> da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            frmestoque.dataGrid.DataSource = dt
            frmestoque.lbl_total.Text = "Encontramos um total de " & frmestoque.dataGrid.Rows.Count - 1 & " Registros"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cs.Close()
            cs.Dispose()
            cmd = Nothing
            cs = Nothing
            da = Nothing
        End Try
    End Sub

    Public Sub Add_Combobox()
        Try
            Conectar_Mysql()
            sql = "SELECT * FROM tb_linhas"
            cmd = New MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader()

            'Primeiro limpamos nossa combobox
            frmestoque.cbo_dados.Items.Clear()

            'Agora fazemos um loop para adcionar os dados de acordo com a coluna desejada
            'tabem pode ser usado para adcionar dados em uma datagridview
            While dr.Read
                frmestoque.cbo_dados.Items.Add(dr.GetString(1))
            End While

        Catch ex As Exception
            MsgBox("Erro ao adionar os dados" & vbNewLine & ex.Message, MsgBoxStyle.ApplicationModal, "Aviso!")
        Finally
            cs.Close()
            cs.Dispose()
            cmd = Nothing
            cs = Nothing
            dr.Close()
        End Try

    End Sub

    Public Sub Print()
        ''Rotina usada para gerar uma tela Para imprimir
        ''----------------------------------------------
        'Dim height As Integer = frmestoque.dataGrid.Height
        'frmestoque.dataGrid.Height = frmestoque.dataGrid.RowCount * frmestoque.dataGrid.RowTemplate.Height
        'bitmap = New Bitmap(frmestoque.dataGrid.Width, frmestoque.dataGrid.Height)
        'frmestoque.dataGrid.DrawToBitmap(bitmap, New Rectangle(0, 0, frmestoque.dataGrid.Width, frmestoque.dataGrid.Height))
        'frmestoque.PrintPreviewDialog1.Document = frmestoque.PrintDocument1
        'frmestoque.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'frmestoque.PrintPreviewDialog1.ShowDialog()
        'frmestoque.dataGrid.Height = height

    End Sub

    Public Sub Carregar_usuarios()
        'Dim dt = New DataTable

        'Try
        '    Conectar_Mysql()
        '    sql = "SELECT * FROM users ORDER BY Nome"
        '    cmd = New MySqlCommand(sql, cs)
        '    da = New MySqlDataAdapter(cmd)
        '    da.Fill(dt)
        '    FrmUser.Data_user.DataSource = dt
        'Catch ex As Exception
        '    MessageBox.Show("Erro ao Carregar Os dados", "Aviso!" & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    cs.Close()
        '    cs.Dispose()
        '    cmd = Nothing
        '    cs = Nothing
        '    da = Nothing

        'End Try

        ''Configurar Datagrid
        ''------------------------------------------------------------------------------------------------
        'With FrmUser.Data_user
        '    .Columns("idUsers").HeaderText = "ID"
        '    .Columns("idUsers").Width = 60
        '    .Columns("idUsers").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter

        '    .Columns("Nome").HeaderText = "Nome"
        '    .Columns("Nome").Width = 375
        '    .Columns("nome").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft

        '    .Columns("Senha").HeaderText = "Senha"
        '    .Columns("Senha").Width = 95
        '    .Columns("Senha").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter

        '    .Columns("Data").HeaderText = "Data"
        '    .Columns("Data").Width = 100
        '    .Columns("Data").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        'End With

    End Sub

    Public Sub Add_combo_cadastro()
        Try
            Conectar_Mysql()
            sql = "SELECT Nome_linha FROM tb_linhas"
            cmd = New MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            FrmCadastroProdutos.cbo_linha_prod.Items.Clear()

            While dr.Read
                FrmCadastroProdutos.cbo_linha_prod.Items.Add(dr.GetString(0))
            End While

            cmd.Dispose()
            dr.Close()

            sql = "SELECT Nome_Unidade FROM tb_unidade_medidas"
            cmd = New MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            FrmCadastroProdutos.cbo_unidade.Items.Clear()

            While dr.Read
                FrmCadastroProdutos.cbo_unidade.Items.Add(dr.GetString(0))
            End While

        Catch ex As Exception
            MsgBox("Erro ao Adcionar os dados" & vbNewLine & ex.Message, "Erro")
        Finally
            Desconectar()
            dr.Close()
            dr.Dispose()
        End Try
    End Sub

    Public Sub Prenecher_listview() 'preenchedo a listview do formulario movimentação

        Dim i As Integer
        Dim lista As ListViewItem
        Try
            Conectar_Mysql()
            sql = "SELECT ID, Codigo, Designacao, Linha, Unidade_Medida, Qtd_minima , Data FROM tb_cadastro"
            cmd = New MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            FrmCadastroProdutos.list_prod.Items.Clear()

            While dr.Read
                lista = FrmCadastroProdutos.list_prod.Items.Add(dr.GetString(0))
                For i = 1 To 6
                    lista.SubItems.Add(dr.GetString(i))
                Next
            End While

            FrmCadastroProdutos.Text = "Temos um total de -> " & FrmCadastroProdutos.list_prod.Items.Count

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados para lista" & vbNewLine & ex.Message, "Erro")
        Finally
            Desconectar()
            dr.Close()
            dr.Dispose()
        End Try

    End Sub

    Public Sub Verificar_Campos(obj As Object)
        Dim controle As Control

        For Each controle In obj
            If TypeOf controle Is TextBox Then
                If controle.Text = String.Empty Then
                    MsgBox("Campos é Obrigatório",, "Aviso!")
                    controle.Focus()
                    Exit Sub
                End If
            ElseIf TypeOf controle Is Guna.UI2.WinForms.Guna2TextBox Then
                If controle.Text = String.Empty Then
                    MsgBox("Campos é Obrigatório",, "Aviso!")
                    controle.Focus()
                    Exit Sub
                End If
            End If
        Next

    End Sub

End Module
