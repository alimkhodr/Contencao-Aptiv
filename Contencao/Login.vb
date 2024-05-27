Public Class Login
    Public Event LoginTreinador As EventHandler
    Public Event LoginVerificaTreino As EventHandler

    Private Sub txt_fun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fun.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                conectar()

                If ACAO = 1 Then
                    comandoSQL.CommandText = "SELECT FUN_REGISTRO FROM FUNCIONARIO INNER JOIN TAB_JBC_TREINADOR ON TRE_TREINADOR = FUN_REGISTRO WHERE FUN_CODIN = '" & txt_fun.Text & "'"
                    objDataReader = comandoSQL.ExecuteReader
                    If objDataReader.Read() Then
                        Treinador = objDataReader("FUN_REGISTRO").ToString()
                    Else
                        Treinador = Nothing
                    End If
                    RaiseEvent LoginTreinador(Me, EventArgs.Empty)
                    objDataReader.Close()
                End If

                If ACAO = 2 Then
                    comandoSQL.CommandText = "SELECT REV.JBC_ID, REV.REV_SEQUENCIA, REV.REV_MOTIVO, REV.REV_DATA, FUN_REGISTRO, FUN_CODIN FROM TAB_JBC_REVISAO REV  "
                    comandoSQL.CommandText &= "LEFT JOIN TAB_JBC_TREINAMENTO TRE ON REV.JBC_ID = TRE.JBC_ID AND REV.REV_SEQUENCIA = TRE.REV_SEQUENCIA "
                    comandoSQL.CommandText &= "LEFT JOIN FUNCIONARIO ON FUN_REGISTRO = TRE_FUNCIONARIO "
                    comandoSQL.CommandText &= "WHERE REV.JBC_ID = " & Page_Apontar.JBC
                    objDataReader = comandoSQL.ExecuteReader
                    Page_Apontar.REV.Clear()
                    While objDataReader.Read()
                        If txt_fun.Text <> objDataReader("FUN_CODIN") Then
                            Page_Apontar.REV.Add(Convert.ToInt32(objDataReader("REV_SEQUENCIA")))
                        Else
                            Page_Apontar.REG = objDataReader("FUN_REGISTRO")
                        End If
                    End While
                    RaiseEvent LoginVerificaTreino(Me, EventArgs.Empty)
                    objDataReader.Close()
                End If

                Close()
                desconectar()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub
End Class
