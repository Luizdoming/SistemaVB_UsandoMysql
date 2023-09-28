Public Class frm_linhas
    Private Sub frm_linhas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        With Me
            .txt_linha.Text = String.Empty
            .txt_unidade.Text = String.Empty
            .List_linhas.Items.Clear()
            .List_unidades.Items.Clear()
            Dispose()
        End With
    End Sub

    Private Sub frm_linhas_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            .txt_unidade.CharacterCasing = CharacterCasing.Upper
            .txt_linha.CharacterCasing = CharacterCasing.Upper
            .txt_linha.Focus()
            .List_linhas.GridLines = True
            .List_unidades.GridLines = True
            .List_unidades.FullRowSelect = True
            .List_linhas.FullRowSelect = True
            .txt_linha.Enabled = False
            .txt_unidade.Enabled = False
            .List_linhas.Enabled = False
            .List_unidades.Enabled = False
        End With

        Adcionar_dados_lin_medida()
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        If Me.Guna2RadioButton1.Checked = True Then
            Me.List_unidades.Enabled = True
            Me.txt_unidade.Enabled = True
            Me.txt_linha.Enabled = False
            Me.List_linhas.Enabled = False
            Me.txt_id_editar.Clear()
            Me.txt_linha.Clear()
            Me.txt_unidade.Clear()
        End If
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        If Me.Guna2RadioButton2.Checked = True Then
            Me.List_unidades.Enabled = False
            Me.txt_unidade.Enabled = False
            Me.txt_linha.Enabled = True
            Me.List_linhas.Enabled = True
            Me.txt_id_editar.Clear()
            Me.txt_linha.Clear()
            Me.txt_unidade.Clear()
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Salvar_Lin_Unid()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Editar_Linhas_unidades()
    End Sub

    Private Sub List_linhas_Click(sender As Object, e As EventArgs) Handles List_linhas.Click
        With Me
            If Me.List_linhas.Enabled = True Then
                Me.txt_id_editar.Text = .List_linhas.SelectedItems(0).SubItems(1).Text
                Me.txt_linha.Text = .List_linhas.SelectedItems(0).SubItems(0).Text
            End If
        End With
    End Sub

    Private Sub List_unidades_Click(sender As Object, e As EventArgs) Handles List_unidades.Click
        With Me
            If Me.List_unidades.Enabled = True Then
                Me.txt_id_editar.Text = .List_unidades.SelectedItems(0).SubItems(1).Text
                Me.txt_unidade.Text = .List_unidades.SelectedItems(0).SubItems(0).Text
            End If
        End With
    End Sub
End Class