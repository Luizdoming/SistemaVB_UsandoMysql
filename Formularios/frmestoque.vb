Imports System.ComponentModel

Public Class frmestoque
    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        If chk_opt.Checked = True Then
            CarregarDuplo()
        Else
            CarregarDados()
        End If
    End Sub

    Private Sub frmestoque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Add_Combobox()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If dataGrid.Rows.Count <= 1 Then
            MsgBox("Sua Lista está vazia", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal, "Aviso!")
            Exit Sub
        End If

        PegarDados()

    End Sub

    Private Sub frmestoque_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
        txt_pesquisa.Clear()
        cbo_dados.Text = String.Empty
    End Sub

    Public Sub PegarDados()
        'Criamos 2 variaveis uma do tipo DataSet - outra do tipo DataTable
        Dim ds As New DataSet1
        Dim dt As New DataTable

        dt = ds.Tables("DataBase")

        For i = 0 To dataGrid.Rows.Count - 1
            dt.Rows.Add(dataGrid.Rows(i).Cells(1).Value,
            dataGrid.Rows(i).Cells(2).Value,
            dataGrid.Rows(i).Cells(3).Value,
            dataGrid.Rows(i).Cells(4).Value,
            dataGrid.Rows(i).Cells(8).Value,
            dataGrid.Rows(i).Cells(9).Value,
            dataGrid.Rows(i).Cells(10).Value,
            dataGrid.Rows(i).Cells(11).Value)
        Next

        With FrmRepor.ReportViewer2.LocalReport
            '.ReportPath = "D:\Arquivos\Sistema_mysqlLocal_VS_Studio\report.rdlc"
            .ReportPath = Application.StartupPath & "\report.rdlc"
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("MyDataSet1", dt))
        End With

        FrmRepor.Show()
        FrmRepor.ReportViewer2.RefreshReport()
    End Sub
End Class
