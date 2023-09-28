Imports MySql.Data.MySqlClient
Public Class Cadastrar
    'Variaveis de controles -> ATRIBUTOS
    Private cs As MySqlConnection  'Variavel responsavel pela string de conexão
    Private cmd As MySqlCommand    'variavel responsavel pelos comandos sql
    Private da As MySqlDataAdapter 'variavel que carrega os dados para um datatable
    Private dr As MySqlDataReader  'variavel responsavel de carregar os dados com os campos individuais
    Private sql As String ' variavel onde ira ficar os comandos sql

    'Criando as propriedades
    Public Property ID_produto As Integer
    Public Property Codigo_produto As String
    Public Property Nome_produto As String
    Public Property Linha_produto As String
    Public Property Unidade_produto As String
    Public Property Quantidade_produto As Integer
    Public Property Data_produto As Date

    Sub New()
        'Declarando a string de conexão
        cs = New MySqlConnection("Server=localhost;Database=stock_sytem;Uid=root;password=270815**;")
    End Sub

    Sub Descon()
        Try
            cs.Close()
            cs.Dispose()
            cmd.Dispose()
            cs = Nothing
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cadastra_produtos()
        Try
            sql = "INSERT INTO tb_cadastro (Codigo, Linha, Designacao, Unidade_Medida, Qtd_minima, Data_movimentacao)
            VALUES(@Codigo, @Linha, @Designacao, @Unidade_Medida, @Qtd_minima, @Data_movimentacao)"
            cs.Open()
            cmd = New MySqlCommand(sql, cs)
            cmd.Parameters.AddWithValue("@Codigo", Codigo_produto) 'Adcionando os parametrs com os valores das propriedades da class
            cmd.Parameters.AddWithValue("@Linha", Linha_produto)
            cmd.Parameters.AddWithValue("@Designacao", Nome_produto)
            cmd.Parameters.AddWithValue("@Unidade_Medida", Unidade_produto)
            cmd.Parameters.AddWithValue("@Qtd_minima", Quantidade_produto)
            cmd.Parameters.AddWithValue("@Data_movimentacao", Data_produto)
            cmd.ExecuteNonQuery() 'Executando o comando 

        Catch ex As Exception
            Throw ex
        Finally
            Descon()
        End Try
    End Sub

End Class
