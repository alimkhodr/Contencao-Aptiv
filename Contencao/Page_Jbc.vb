Public Class Page_Jbc
    Private Sub Page_Jbc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_area()
        Lista()
    End Sub

    Sub Lista()
        Try
            conectar()
            comandoSQL.CommandText = "SELECT JBC_ID,JBC_TIPO,JBC_DESCRICAO,JBC_RESPONSAVEL, (SELECT COUNT(JBC_ID) FROM TAB_JBC_REVISAO WHERE JBC.JBC_ID = JBC_ID) AS REVISOES, (SELECT COUNT(JBC_ID) FROM TAB_JBC_PN WHERE JBC.JBC_ID = JBC_ID) AS PN, JBC_EMISSAO FROM TAB_JBC JBC WHERE JBC_FIM IS NULL AND ('" & txt_proc.Text & "' = '' OR JBC.JBC_ID LIKE '" & txt_proc.Text & "%');"
            objDataReader = comandoSQL.ExecuteReader
            DataGridView.Rows.Clear()

            DataGridView.Columns.Clear()
            DataGridView.Columns.Add("JBC", "JBC")
            DataGridView.Columns.Add("TIPO", "TIPO")
            DataGridView.Columns.Add("DESC", "DESCRIÇÃO")
            DataGridView.Columns.Add("RESP", "RESPONSÁVEL")
            DataGridView.Columns.Add("REV", "REVISÕES")
            DataGridView.Columns.Add("PN", "PN's")
            DataGridView.Columns.Add("EMISSAO", "EMISSÃO")

            ' Definir a largura das colunas
            DataGridView.Columns("JBC").Width = 30
            DataGridView.Columns("TIPO").Width = 40
            DataGridView.Columns("DESC").Width = 200
            DataGridView.Columns("RESP").Width = 60
            DataGridView.Columns("REV").Width = 35
            DataGridView.Columns("PN").Width = 20
            DataGridView.Columns("EMISSAO").Width = 160
            DataGridView.Columns("DESC").DefaultCellStyle.WrapMode = DataGridViewTriState.True

            While objDataReader.Read()
                Dim row As String() = New String() {
                    objDataReader("JBC_ID").ToString(),
                    objDataReader("JBC_TIPO").ToString(),
                    objDataReader("JBC_DESCRICAO").ToString(),
                    objDataReader("JBC_RESPONSAVEL").ToString(),
                    objDataReader("REVISOES").ToString(),
                    objDataReader("PN").ToString(),
                    (Convert.ToDateTime(objDataReader("JBC_EMISSAO")).ToString("dd/MM/yyyy"))
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

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Lista()
        txt_jbc.Text = "JBC's " & DateTime.Now.ToShortDateString
    End Sub

    Private Sub txt_proc_TextChanged(sender As Object, e As EventArgs) Handles txt_proc.TextChanged
        Lista()
    End Sub

    Private Sub DataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView.DoubleClick
        If DataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)
            Page_Apontar.txt_jbc.Text = "JBC/" & selectedRow.Cells(0).Value
            Page_Apontar.JBC = Convert.ToInt32(selectedRow.Cells(0).Value)
            Page_Apontar.Show()
        End If
    End Sub

    Private Sub TreinamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreinamentosToolStripMenuItem.Click
        Page_Treinamento.Show()
    End Sub
    Private Sub CodigosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CodigosToolStripMenuItem.Click
        Page_Codigos.Show()
    End Sub
    Private Sub ConfiguracaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracaoToolStripMenuItem.Click
        ACAO = 1
        AddHandler Login.LoginTreinador,
            Sub()
                Try
                    If Treinador <> Nothing Then
                        Page_Config.Show()
                    Else
                        MessageBox.Show("Sem privilégio.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Sub
        Login.Show()
    End Sub
End Class
