Public Class Page_Saida
    Public JBC, REG, CON_ID As Integer
    Private ToolTip1 As New ToolTip()

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_codigo_sc.Text = "" Or txt_qtd_sc.Text = "" Or txt_motivo_sc.Text = "" Then
            MessageBox.Show("Preencha todos os dados")
            Return
        End If

        Try
            conectar()
            comandoSQL.CommandText = "INSERT INTO TAB_JBC_SCRAP (CON_ID,COD_ID,SC_QUANTIDADE,SC_MOTIVO) "
            comandoSQL.CommandText &= "VALUES (" & CON_ID & "," & txt_codigo_sc.Text & "," & txt_qtd_sc.Text & ",'" & txt_motivo_sc.Text & "')"
            comandoSQL.ExecuteNonQuery()

            txt_codigo_sc.Text = ""
            txt_qtd_sc.Text = ""
            txt_motivo_sc.Text = ""

            desconectar()
            Preencher()
        Catch ex As Exception
            If ex.Message = "A instrução INSERT conflitou com a restrição do FOREIGN KEY ""FK__TAB_JBC_S__COD_I__62A649C8"". O conflito ocorreu no bando de dados ""SGM_ONE"", tabela ""dbo.TAB_JBC_CODIGOS"", column 'COD_ID'." & vbCrLf & "A instrução foi finalizada." Then
                MessageBox.Show("Código não existente.")
            Else
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Page_Codigos.Show()
    End Sub

    Private Sub btn_fim_Click(sender As Object, e As EventArgs) Handles btn_fim.Click
        Try
            conectar()
            comandoSQL.CommandText = "UPDATE TAB_JBC_CONTENCAO SET CON_SAIDA = GETDATE() WHERE CON_ID = " & CON_ID
            comandoSQL.ExecuteNonQuery()
            MessageBox.Show("Contenção finalizada.")
            Close()
            desconectar()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_qtd_sc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd_sc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_codigo_sc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo_sc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Page_Saida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preencher()
    End Sub
    Sub Preencher()
        Try
            conectar()
            comandoSQL.CommandText &= "SELECT C.CON_ID,C.CON_CAIXA,C.PN_PARTNUMBER,C.CON_QUANTIDADE,C.CON_ENTRADA,C.CARTAO_ID,SUM(S.SC_QUANTIDADE) AS SCRAP FROM TAB_JBC_CONTENCAO C "
            comandoSQL.CommandText &= "LEFT JOIN TAB_JBC_SCRAP S ON S.CON_ID = C.CON_ID WHERE C.CON_ID = " & CON_ID & " GROUP BY C.CON_ID,C.CON_CAIXA,C.PN_PARTNUMBER,C.CON_QUANTIDADE,C.CON_ENTRADA,C.CARTAO_ID"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read Then
                txt_caixa.Text = objDataReader("CON_CAIXA").ToString
                txt_pn.Text = objDataReader("PN_PARTNUMBER").ToString
                txt_qtd.Text = objDataReader("CON_QUANTIDADE").ToString
                txt_entrada.Text = Convert.ToDateTime(objDataReader("CON_ENTRADA")).ToString("dd/MM/yyyy")
                If objDataReader("CARTAO_ID") Is DBNull.Value Then
                    txt_cv.Text = "N/A"
                Else
                    txt_cv.Text = objDataReader("CARTAO_ID").ToString
                End If
                txt_total_sc.Text = objDataReader("SCRAP").ToString
            End If
            objDataReader.Close()
            desconectar()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
End Class
