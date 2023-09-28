Imports System.ComponentModel
'Imports System.Threading
Public Class frm_Munu
    Private Sub frm_Munu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'lbl_data.Text = " Hoje é  " & FormatDateTime(Now(), NamedFormat:=DateFormat.LongDate)
        Me.WindowState = FormWindowState.Maximized
        Me.Guna2Panel1.Width = 66
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub frm_Munu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Guna2Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2Panel1.MouseMove
        Me.Guna2Panel1.Width = 151
        'Thread.Sleep(400)
    End Sub

    Private Sub frm_Munu_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Guna2Panel1.Width = 66
        'Thread.Sleep(380)
    End Sub

    Private Sub bt_user_Click(sender As Object, e As EventArgs) Handles bt_user.Click
        FrmUser.Text = Me.Text
        FrmUser.ShowDialog()
    End Sub

    Private Sub bt_esto_Click(sender As Object, e As EventArgs) Handles bt_esto.Click
        frmestoque.Text = Me.Text
        frmestoque.ShowDialog()
    End Sub

    Private Sub bt_report_Click(sender As Object, e As EventArgs) Handles bt_report.Click
        ' Using Form = New FrmRepor
        'Form.ShowDialog()
        'End Using
    End Sub

    Private Sub bt_cad_Click(sender As Object, e As EventArgs) Handles bt_cad.Click
        FrmCadastroProdutos.Text = Me.Text
        FrmCadastroProdutos.ShowDialog()
    End Sub

    Private Sub bt_movi_Click(sender As Object, e As EventArgs) Handles bt_movi.Click
        frm_Movimentacao.Text = Me.Text
        frm_Movimentacao.ShowDialog()
    End Sub

    Private Sub btn_lin_unidade_Click(sender As Object, e As EventArgs) Handles btn_lin_unidade.Click
        frm_linhas.ShowDialog()
    End Sub

    Private Sub bt_desliga_Click(sender As Object, e As EventArgs) Handles bt_desliga.Click

        If MsgBox("Deseja encerrar sua aplicação ? ", vbApplicationModal + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.OkCancel, "Atenção") = MsgBoxResult.Ok Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

End Class