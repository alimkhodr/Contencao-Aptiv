Public Class Page_Treinamento
    Public JBC, REV As Integer
    Private Sub Page_Treinamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista()
        DataGridView_fun.Columns.Add("REGISTRO", "REGISTRO")
        DataGridView_fun.Columns.Add("NOME", "NOME")
    End Sub

    Sub Lista()
        Try
            conectar()
            comandoSQL.CommandText = "SELECT JBC.JBC_ID, REV.REV_SEQUENCIA, REV.REV_MOTIVO, REV.REV_DATA FROM TAB_JBC_REVISAO REV INNER JOIN TAB_JBC JBC ON JBC.JBC_ID = REV.JBC_ID "
            comandoSQL.CommandText &= "WHERE ('" & txt_proc.Text & "' = '' OR JBC.JBC_ID LIKE '" & txt_proc.Text & "%') AND JBC.JBC_FIM IS NULL ORDER BY JBC.JBC_ID DESC, REV_SEQUENCIA DESC"
            objDataReader = comandoSQL.ExecuteReader
            DataGridView_rev.Rows.Clear()
            DataGridView_rev.Columns.Clear()
            DataGridView_rev.Columns.Add("JBC", "JBC")
            DataGridView_rev.Columns.Add("REVISAO", "REVISÃO")
            DataGridView_rev.Columns.Add("MOTIVO", "MOTIVO")
            DataGridView_rev.Columns.Add("DATA", "ABERTURA")

            ' Definir a largura das colunas
            DataGridView_rev.Columns("JBC").Width = 40
            DataGridView_rev.Columns("REVISAO").Width = 55
            DataGridView_rev.Columns("MOTIVO").Width = 170
            DataGridView_rev.Columns("DATA").Width = 130

            While objDataReader.Read()
                Dim row As String() = New String() {
                objDataReader("JBC_ID").ToString(),
                objDataReader("REV_SEQUENCIA").ToString(),
                objDataReader("REV_MOTIVO").ToString(),
                objDataReader("REV_DATA").ToString()
            }
                DataGridView_rev.Rows.Add(row)
            End While
            objDataReader.Close()
            desconectar()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
        DataGridView_rev.ClearSelection()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView_rev.DoubleClick
        DataGridView_fun.Rows.Clear()
        If DataGridView_rev.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView_rev.SelectedRows(0)
            JBC = Convert.ToInt32(selectedRow.Cells(0).Value)
            REV = Convert.ToInt32(selectedRow.Cells(1).Value)
            Try
                conectar()
                comandoSQL.CommandText = "SELECT * FROM TAB_JBC_REVISAO WHERE JBC_ID = " & JBC & " AND REV_SEQUENCIA = " & REV
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read() Then
                    WebBrowser1.Navigate(String.Format("file://mfgsvr2/inetpub/wwwroot/Treinamentos/JBC/" & objDataReader("REV_PATH").ToString(), Application.StartupPath))
                    txt_jbc.Text = "JBC/" & JBC & " REV/" & objDataReader("REV_SEQUENCIA").ToString()
                End If
                txt_fun.Enabled = True
                btn_fim.Enabled = True
                objDataReader.Close()
                desconectar()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_fun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fun.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                conectar()
                comandoSQL.CommandText = "SELECT FUN_REGISTRO, FUN_NOME, JBC_ID, REV_SEQUENCIA FROM FUNCIONARIO LEFT JOIN TAB_JBC_TREINAMENTO ON TRE_FUNCIONARIO = FUN_REGISTRO WHERE FUN_CODIN = '" & txt_fun.Text & "' ORDER BY REV_SEQUENCIA DESC;"
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read() Then
                    If objDataReader("JBC_ID") Is DBNull.Value And objDataReader("REV_SEQUENCIA") Is DBNull.Value Then
                        If DataGridView_fun.Rows.Count <> 0 Then
                            For i As Integer = 0 To DataGridView_fun.Rows.Count - 1
                                If objDataReader("FUN_REGISTRO").ToString() <> Convert.ToInt32(DataGridView_fun.Rows(i).Cells(0).Value) Then
                                    Dim row As String() = New String() {
                                    objDataReader("FUN_REGISTRO").ToString(),
                                    objDataReader("FUN_NOME").ToString()
                                    }
                                    DataGridView_fun.Rows.Add(row)
                                Else
                                    MessageBox.Show("Funcionário já esta na lista.")
                                    txt_fun.Text = ""
                                    Return
                                End If
                            Next
                        Else
                            Dim row As String() = New String() {
                                objDataReader("FUN_REGISTRO").ToString(),
                                objDataReader("FUN_NOME").ToString()
                                }
                            DataGridView_fun.Rows.Add(row)
                        End If
                    Else
                        If objDataReader("JBC_ID").ToString() <> JBC And objDataReader("REV_SEQUENCIA").ToString() <> JBC Then
                            If DataGridView_fun.Rows.Count <> 0 Then
                                For i As Integer = 0 To DataGridView_fun.Rows.Count - 1
                                    If objDataReader("FUN_REGISTRO").ToString() <> Convert.ToInt32(DataGridView_fun.Rows(i).Cells(0).Value) Then
                                        Dim row As String() = New String() {
                                        objDataReader("FUN_REGISTRO").ToString(),
                                        objDataReader("FUN_NOME").ToString()
                                        }
                                        DataGridView_fun.Rows.Add(row)
                                    Else
                                        MessageBox.Show("Funcionário já esta na lista.")
                                        txt_fun.Text = ""
                                        Return
                                    End If
                                Next
                            Else
                                Dim row As String() = New String() {
                                    objDataReader("FUN_REGISTRO").ToString(),
                                    objDataReader("FUN_NOME").ToString()
                                    }
                                DataGridView_fun.Rows.Add(row)
                            End If
                        Else
                            MessageBox.Show("Funcionário já treinado para esta revisão.")
                            txt_fun.Text = ""
                            Return
                        End If
                    End If
                End If
                objDataReader.Close()
                desconectar()
                txt_fun.Text = ""
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
            DataGridView_fun.ClearSelection()
        End If
    End Sub

    Sub Clear()
        JBC = 0
        REV = 0

        Lista()
        DataGridView_fun.Rows.Clear()

        txt_jbc.Text = "JBC"
        txt_fun.Text = ""

        WebBrowser1.Navigate(String.Format("", Application.StartupPath))

        txt_fun.Enabled = False
        btn_fim.Enabled = False
    End Sub

    Private Sub btn_fim_Click(sender As Object, e As EventArgs) Handles btn_fim.Click
        If DataGridView_fun.Rows.Count <> 0 Then
            ACAO = 1
            AddHandler Login.LoginTreinador, Sub()
                                                 Try
                                                     TreinaFun()
                                                 Catch ex As Exception
                                                     MessageBox.Show("Ocorreu um erro: " & ex.Message)
                                                 End Try
                                             End Sub
            Login.Show()
        Else
            MessageBox.Show("Nenhum funcionário na lista.")
        End If
    End Sub

    Private Sub TreinaFun()
        Dim Reg As Integer
        If Treinador <> Nothing Then
            Try
                conectar()
                For i As Integer = 0 To DataGridView_fun.Rows.Count - 1
                    Reg = Convert.ToInt32(DataGridView_fun.Rows(i).Cells(0).Value)
                    comandoSQL.CommandText = "INSERT INTO TAB_JBC_TREINAMENTO (JBC_ID,REV_SEQUENCIA,TRE_FUNCIONARIO,TRE_TREINADOR,TRE_DATA) VALUES(" & JBC & "," & REV & ",'" & Reg & "'," & Treinador & ", GETDATE())"
                    comandoSQL.ExecuteNonQuery()
                Next
                Clear()
                desconectar()
            Catch ex As Exception
                If ex.Message = "Violação da restrição PRIMARY KEY 'PK__TAB_JBC___CA6AD6CE0900FCDA'. Não é possível inserir a chave duplicada no objeto 'dbo.TAB_JBC_TREINAMENTO'. O valor da chave duplicada é (" & REV & ", " & JBC & ", " & Reg & ")." & vbCrLf & "A instrução foi finalizada." Then
                    MessageBox.Show("Funcionário já treinado para esta JBC")
                Else
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End If
            End Try
        Else
            MessageBox.Show("Treinador não cadastrado.")
        End If
    End Sub

    Private Sub txt_proc_TextChanged(sender As Object, e As EventArgs) Handles txt_proc.TextChanged
        Lista()
    End Sub

    Private Sub JBCMenuItem_Click(sender As Object, e As EventArgs) Handles JBCMenuItem.Click
        Close()
    End Sub

End Class
