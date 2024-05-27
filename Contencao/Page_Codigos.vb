Public Class Page_Codigos
    Private Sub Page_Codigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()
            comandoSQL.CommandText = "SELECT * FROM TAB_JBC_CODIGOS"
            objDataReader = comandoSQL.ExecuteReader
            DataGridView.Rows.Clear()

            DataGridView.Columns.Clear()
            DataGridView.Columns.Add("COD_ID", "CÓDIGO")
            DataGridView.Columns.Add("COD_MOTIVO", "MOTIVO")

            ' Definir a largura das colunas
            DataGridView.Columns("COD_ID").Width = 70

            While objDataReader.Read()
                Dim row As String() = New String() {
                    objDataReader("COD_ID").ToString(),
                    objDataReader("COD_MOTIVO").ToString()
                }
                DataGridView.Rows.Add(row)
            End While
            objDataReader.Close()
            desconectar()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
        DataGridView.ClearSelection()
    End Sub
End Class
