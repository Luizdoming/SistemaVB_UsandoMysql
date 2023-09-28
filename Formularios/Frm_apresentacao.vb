Imports System.Threading
Public Class Frm_apresentacao

    Private Sub Frm_apresentacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(1)

        If Guna2CircleProgressBar1.Value = 100 Then
            Dispose()
            Timer1.Enabled = False
            Frm_login.ShowDialog()
        End If

    End Sub
End Class