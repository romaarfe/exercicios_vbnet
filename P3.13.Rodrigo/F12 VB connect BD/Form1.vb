Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql1 As String = "SELECT * FROM Produtos;"

        dgvProdutos.DataSource = obj.BuscaDados(sc, ssql1)


        Dim ssql2 As String = "SELECT DISTINCT País FROM Fornecedores;"

        cbxPaises.DataSource = obj.BuscaDados(sc, ssql2)
        cbxPaises.DisplayMember = "País"
        cbxPaises.SelectedIndex = -1
        cbxPaises.SelectedText = "Selecione um País"
    End Sub

    Private Sub cbxProdutos20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProdutos20.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProdutos20.Click
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT NomeDoProduto FROM Produtos WHERE PreçoUnitário > 20 AND Existências != 0;"

        cbxProdutos20.DataSource = obj.BuscaDados(sc, ssql)
        cbxProdutos20.DisplayMember = "NomeDoProduto"

    End Sub

    Private Sub btnIniciaRegistos_Click(sender As Object, e As EventArgs) Handles btnProdutosExistencias.Click
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT CONCAT(NomeDoProduto, ', ', Existências) AS Resultado FROM Produtos;"


        lstProdutosExistencias.DataSource = obj.BuscaDados(sc, ssql)
        lstProdutosExistencias.DisplayMember = "Resultado"

    End Sub

    Private Sub btnFornecedores_Click(sender As Object, e As EventArgs) Handles btnFornecedores.Click
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT * FROM Fornecedores;"

        dgvFornecedores.DataSource = obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub cbxPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPaises.SelectedIndexChanged
        Dim obj As New DataBaseAccess

        Dim sc As String = obj.ConnectionString
        Dim ssql As String = "SELECT * FROM Fornecedores WHERE País = '" & cbxPaises.Text & "';"

        dgvFornecedores.DataSource = obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub btnInserirCategoria_Click(sender As Object, e As EventArgs) Handles btnInserirCategoria.Click
        
        Try
            Dim obj As New DataBaseAccess

            Dim sc As String = obj.ConnectionString

            Dim codigoCategoria As Integer = CInt(txtCodigoCategoria.Text)
            Dim nomeCategoria As String = txtCategoria.Text

            Dim ssql As String = "INSERT INTO Categorias (CódigoDaCategoria, NomeDaCategoria) VALUES (" & codigoCategoria & ", '" & nomeCategoria & "');"
            obj.BuscaDados(sc, ssql)

            MessageBox.Show("Nova Categoria inserida com sucesso!!!")
        Catch
            MessageBox.Show("Favor, preencher ambas textboxes")
        End Try


    End Sub

    Private Sub btnInserirProduto_Click(sender As Object, e As EventArgs) Handles btnInserirProduto.Click

        Try
            Dim obj As New DataBaseAccess

            Dim sc As String = obj.ConnectionString

            Dim codigoProduto As Integer = CInt(txtCodigoProduto.Text)
            Dim nomeProduto As String = txtProduto.Text
            Dim descontinuado As Boolean

            If chkSim.Checked Then
                descontinuado = True
            ElseIf chkNao.Checked Then
                descontinuado = False
            End If

            Dim ssql As String = "INSERT INTO Produtos (CódigoDoProduto, NomeDoProduto, Descontinuado) VALUES (" & codigoProduto & ", '" & nomeProduto & "', '" & descontinuado & "');"
            obj.BuscaDados(sc, ssql)

            MessageBox.Show("Novo Produto inserido com sucesso!!!")
        Catch
            MessageBox.Show("Favor, preencher as textboxes e marcar a checkbox adequada")
        End Try

    End Sub
End Class
