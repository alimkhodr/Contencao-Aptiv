Public Class Page_Entrada
    Public JBC, REG As Integer

    Private Sub cb_caixa_CheckedChanged(sender As Object, e As EventArgs) Handles cb_caixa.CheckedChanged
        If cb_caixa.Checked Then
            txt_caixa.Enabled = False
            txt_pn.Enabled = True
            txt_qtd.Enabled = True
        Else
            txt_caixa.Enabled = True
            txt_pn.Enabled = False
            txt_qtd.Enabled = False
        End If
    End Sub

    Private Sub txt_caixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_caixa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                conectar()
                comandoSQL.CommandText = "SELECT CON_CAIXA FROM TAB_JBC_CONTENCAO C INNER JOIN TAB_JBC J ON J.JBC_ID = C.JBC_ID WHERE CON_CAIXA = '" & txt_caixa.Text & "' AND J.JBC_ID = " & JBC
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read Then
                    MessageBox.Show("Caixa já deu entrada no estoque.")
                    txt_caixa.Clear()
                    txt_caixa.Focus()
                    Return
                End If
                objDataReader.Close()

                comandoSQL.CommandText = "SELECT ETQ_BARCODE, ETQ_PARTINUMBER, ETQ_QUANTIDADE, etq_cod_linha FROM ETIQUETA WHERE ETQ_BARCODE = '" & txt_caixa.Text & "'"
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read Then
                    txt_pn.Text = objDataReader("ETQ_PARTINUMBER").ToString()
                    txt_qtd.Text = objDataReader("ETQ_QUANTIDADE").ToString()
                Else
                    MessageBox.Show("Código não encontrado.")
                    Return
                End If
                objDataReader.Close()
                desconectar()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_qtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click
        If txt_pn.Text = "" Or txt_qtd.Text = "" Then
            MessageBox.Show("PN ou Quantidade incorreta")
            Return
        End If
        Try
            conectar()
            comandoSQL.CommandText = "INSERT INTO TAB_JBC_CONTENCAO (JBC_ID " & If(cb_caixa.Checked, "", ",CON_CAIXA") & ",PN_PARTNUMBER,CON_QUANTIDADE,CON_ENTRADA,CON_AREA,CARTAO_ID,FUN_REGISTRO) "
            comandoSQL.CommandText &= "VALUES (" & JBC & If(cb_caixa.Checked, ",NULL", ",'" & txt_caixa.Text & "'") & ",'" & txt_pn.Text & "'," & txt_qtd.Text & ",GETDATE(),'" & Area & "'," & If(txt_cv.Text = "", "NULL", "'" & txt_cv.Text & "'") & ",'" & REG & "')"
            comandoSQL.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Entrada concluída.")
            Page_Apontar.Lista_Entrada()
            Close()
        Catch ex As Exception
            If ex.Message = "A instrução INSERT conflitou com a restrição do FOREIGN KEY ""FK__TAB_JBC_CONTENCA__301AC9FB"". O conflito ocorreu no bando de dados ""SGM_ONE"", tabela ""dbo.TAB_JBC_PN""." & vbCrLf & "A instrução foi finalizada." Then
                MessageBox.Show("PN não vinculado a JBC.")
            Else
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End If
        End Try
    End Sub
End Class
