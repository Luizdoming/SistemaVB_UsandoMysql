Imports System.ComponentModel

Public Class FrmUser
    Public Const Style As String = "yyyy/MM/dd"

    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_nome_user.Focus()
        txt_senha_user.PasswordChar = Chr(149)
        lbl_data_user.Text = Format(Now, Style)
    End Sub
    Private Sub btn_cad_user_form_Click(sender As Object, e As EventArgs) Handles btn_cad_user_form.Click
        salvar_usuarios()
    End Sub

    Private Sub Data_user_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim i As Integer
        'Try
        '    If Data_user.SelectedRows(0).Cells(0).Value = Nothing Then
        '        MessageBox.Show("Você selecionou um item fora da lista", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        Exit Sub
        '    End If
        '    ' 1º -> Maneira de selecionar um iten de um datagridview
        '    i = Me.Data_user.CurrentRow.Index
        '    txt_id_user.Text = Me.Data_user.Item(0, i).Value
        '    txt_nome_user.Text = Me.Data_user.Item(1, i).Value

        '    'Segundo metodo de selecionar um item de uma datagridview
        '    '----------------------------------------------------------
        '    'Me.txt_id_user.Text = Data_user.SelectedRows(0).Cells(0).Value.ToString
        '    'Me.txt_nome_user.Text = Me.Data_user.SelectedRows(0).Cells(1).Value.ToString
        'Catch ex As Exception
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Data_user_MouseClick(sender As Object, e As MouseEventArgs)
        'Dim i As Integer
        'Try
        '    If Data_user.SelectedRows(0).Cells(0).Value = Nothing Then
        '        MessageBox.Show("Você selecionou um item fora da lista", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        Exit Sub
        '    End If

        '    ' 1º -> Maneira de selecionar um iten de um datagridview
        '    i = Data_user.CurrentRow.Index
        '    txt_id_user.Text = Data_user.Item(0, i).Value
        '    txt_nome_user.Text = Data_user.Item(1, i).Value

        'Catch ex As Exception
        '    Exit Sub
        'End Try
    End Sub

    Private Sub btn_delete_user_Click(sender As Object, e As EventArgs) Handles btn_delete_user.Click

        Dim chave As Int32
        Dim senha As String
        Dim controles As Control

        Try
            If txt_id_user.Text = String.Empty Then
                MsgBox("Selecione um Usuário Para Deletar, Digitando seu ID.", MsgBoxStyle.Information, "Atenção")
                Me.txt_id_user.Focus()
                Exit Sub
            End If

            '--------------------------------
            'VERIFICANDO SE O USUARIO EXISTE
            '--------------------------------
            Conectar_Mysql()
            sql = "SELECT IdUsers, Nome FROM users"
            chave = txt_id_user.Text : senha = txt_nome_user.Text
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
            dr = cmd.ExecuteReader

            While dr.Read
                If dr("idUsers").ToString = chave Or dr("Nome").ToString = senha Then
                    MsgBox("Usuário encontrado",, "Aviso!")
                    Desconectar()
                    GoTo continua
                Else
                    MsgBox("Usuário não encontrado",, "Aviso!")
                    Desconectar()
                    GoTo sair
                End If
            End While

            '--------------------------------------
            'COMENÇANDO A ROTINA DE DELETAR USUARIO
            '--------------------------------------
continua:

            If MsgBox("Deseja Deletar Este Usuário ? ", +vbOKCancel + MsgBoxStyle.DefaultButton2, "Atenção") = vbOK Then
                Conectar_Mysql()
                chave = txt_id_user.Text
                sql = "DELETE FROM users WHERE idUsers = @idUsers"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, cs)
                cmd.Parameters.AddWithValue("@idUsers", chave)
                cmd.ExecuteNonQuery()
                Desconectar()
                MsgBox("Usuário deletado...",, "OK")
                Exit Sub
            Else
                Exit Sub
            End If
sair:

            For Each controles In Me.Controls
                If TypeOf controles Is Guna.UI2.WinForms.Guna2TextBox Then
                    controles.Text = String.Empty
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Desconectar()
        End Try

    End Sub

    Private Sub FrmUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.txt_id_user.Text = String.Empty
        Me.txt_nome_user.Text = String.Empty
        Me.txt_senha_user.Text = String.Empty
    End Sub

    Private Sub btm_img_Click(sender As Object, e As EventArgs) Handles btm_img.Click
        Pegar_img()
    End Sub

    Private Sub FrmUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Me.imagem_user.Image = Nothing
    End Sub
End Class