Public Class Page_Inspecao
    Public JBC, REG, CON_ID As Integer
    Private Sub txt_caixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_caixa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                conectar()
                comandoSQL.CommandText = "SELECT CON_ID,PN_PARTNUMBER,CARTAO_ID,CON_INS_INICIO FROM TAB_JBC_CONTENCAO WHERE CON_CAIXA = '" & txt_caixa.Text & "' AND JBC_ID = " & JBC
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read Then
                    If objDataReader("CON_INS_INICIO") IsNot DBNull.Value Then
                        MessageBox.Show("Caixa já inspecionada.")
                        txt_caixa.Clear()
                        txt_caixa.Focus()
                        Return
                    End If

                    CON_ID = objDataReader("CON_ID").ToString
                    If objDataReader("CARTAO_ID") Is DBNull.Value Then
                        txt_cv.Text = "N/A"
                    Else
                        txt_cv.Text = objDataReader("CARTAO_ID").ToString
                    End If
                    txt_pn.Text = objDataReader("PN_PARTNUMBER").ToString

                Else
                    MessageBox.Show("Não foi dada entrada na caixa.")
                    txt_caixa.Clear()
                    txt_caixa.Focus()
                    Return
                End If
                objDataReader.Close()
                desconectar()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_inspecao_Click(sender As Object, e As EventArgs) Handles btn_inspecao.Click
        If CON_ID = 0 Then
            MessageBox.Show("Caxa não selecionada")
            Return
        End If
        Try
            conectar()
            comandoSQL.CommandText = "UPDATE TAB_JBC_CONTENCAO SET CON_INS_INICIO = GETDATE(), CON_INS_REGISTRO = '" & REG & "' WHERE CON_ID = " & CON_ID
            comandoSQL.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Inspeção salva.")
            Page_Apontar.Lista_Entrada()
            Close()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
End Class
