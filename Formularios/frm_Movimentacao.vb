Imports System.ComponentModel

Public Class frm_Movimentacao

    Private Sub frm_Movimentacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.txt_data_movim.Text = Today() '-----------------------Format(Now, "yyyy/mm/dd")
        Me.txt_data_movim.ReadOnly = True
        Me.txt_linha_movim.ReadOnly = True
        Me.txt_unidade_movi.ReadOnly = True '---------------------Não permite edição do texto no controle - somente leitura
        Me.txt_pesuisa_movimen.CharacterCasing = CharacterCasing.Upper 'Coloca todas as letras em maiusculas
        Me.opt_entradas.Checked = False
        Me.opt_saidas.Checked = False
        Me.btn_editar_movimentacao.Enabled = False
        Me.list_movimentacao.GridLines = True
        Me.list_movimentacao.FullRowSelect = True
        Me.list_movimentacao.View = View.Details
        Limpar_Campos_Movimentacao()
        Chk_Entradas.Visible = False
        Chk_saidas.Visible = False
    End Sub

    Private Sub txt_qtd_movim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd_movim.KeyPress
        'Veiriifcando se o campo quantidade esta com caracteres numericos
        'se o caractere digitado for uma letra então o resultado será verdadeiro
        'o campo quantidade receberá um valor vazio
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub opt_saidas_CheckedChanged(sender As Object, e As EventArgs) Handles opt_saidas.CheckedChanged
        Opcao()
        Limpar_Campos_Movimentacao()

        If opt_saidas.Checked = True Then
            Carregar_Dados_Saidas()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub opt_entradas_CheckedChanged(sender As Object, e As EventArgs) Handles opt_entradas.CheckedChanged
        Opcao()
        Limpar_Campos_Movimentacao()

        If opt_entradas.Checked = True Then
            Carregar_dados_Entradas()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_pesquisar_movimenta_Click(sender As Object, e As EventArgs) Handles btn_pesquisar_movimenta.Click
        Pesquisar_item_movime()
    End Sub

    Public Function Opcao() As Boolean

        Try
            With Me
                If opt_entradas.Checked = True Then
                    btn_editar_movimentacao.Enabled = False
                    btn_salvar_movim.Enabled = True
                    Me.list_movimentacao.Enabled = False
                ElseIf opt_saidas.Checked = True Then
                    btn_editar_movimentacao.Enabled = False
                    btn_salvar_movim.Enabled = True
                    Me.list_movimentacao.Enabled = False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Opcao

    End Function

    Private Sub btn_salvar_movim_Click(sender As Object, e As EventArgs) Handles btn_salvar_movim.Click
        Try
            If opt_entradas.Checked = True Then
                Adcionar_Entradas()
            ElseIf opt_saidas.Checked = True Then
                Adcionar_saidas()
            Else
                MsgBox("Selecione uma opção",, "Aviso!")
            End If
        Catch ex As Exception
            MsgBox("Erro oa salvar " & Err.Description,, "Aviso!")
            Desconectar()
        End Try
    End Sub

    Private Sub list_movimentacao_Click(sender As Object, e As EventArgs) Handles list_movimentacao.Click

        With Me.list_movimentacao
            txt_pesuisa_movimen.Text = .SelectedItems.Item(0).Text
            txt_sesignacao_movim.Text = .SelectedItems.Item(0).SubItems(1).Text
            txt_linha_movim.Text = .SelectedItems.Item(0).SubItems(3).Text
            txt_unidade_movi.Text = .SelectedItems.Item(0).SubItems(2).Text
            txt_qtd_movim.Text = .SelectedItems.Item(0).SubItems(4).Text
        End With

    End Sub

    Private Sub frm_Movimentacao_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Limpar_Campos_Movimentacao()
        Me.list_movimentacao.Items.Clear()
    End Sub



    Private Sub btn_editar_movimentacao_Click(sender As Object, e As EventArgs) Handles btn_editar_movimentacao.Click
        If Chk_Entradas.Checked = True Then
            Editar_Entradas()
        ElseIf Chk_saidas.Checked = True Then
            Editar_Saida()
        Else
            MsgBox("Selecione uma Opção!",, "Atenção")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            opt_entradas.Visible = False
            opt_saidas.Visible = False
            Chk_saidas.Visible = True
            Chk_Entradas.Visible = True
            btn_editar_movimentacao.Enabled = True
            btn_salvar_movim.Enabled = False
            Me.list_movimentacao.Enabled = True
            MsgBox("Selecione uma Opção - Entrada ou Saida Para Prosseguir",, "Aviso!")
        ElseIf CheckBox1.Checked = False Then
            opt_entradas.Visible = True
            opt_saidas.Visible = True
            Chk_Entradas.Visible = False
            Chk_saidas.Visible = False
            btn_editar_movimentacao.Enabled = False
            btn_salvar_movim.Enabled = True
            Me.list_movimentacao.Enabled = False
            Limpar_Campos_Movimentacao()
        End If
    End Sub

    Private Sub Chk_Entradas_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Entradas.CheckedChanged
        If Chk_Entradas.Checked = True Then
            Carregar_dados_Entradas()
        End If
    End Sub

    Private Sub Chk_saidas_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_saidas.CheckedChanged
        If Chk_saidas.Checked = True Then
            Carregar_Dados_Saidas()
        End If
    End Sub
End Class