Public Class Page_Apontar
    Public JBC, REG As Integer
    Public REV As New List(Of Integer)
    Public Verifica As Boolean
    Private Sub Page_Apontar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista_PN()
        Lista_Entrada()
    End Sub

    Sub Lista_PN()
        Try
            conectar()
            comandoSQL.CommandText = "SELECT PN_PARTNUMBER FROM TAB_JBC_PN WHERE JBC_ID = " & JBC
            objDataReader = comandoSQL.ExecuteReader
            DataGridView.Rows.Clear()

            DataGridView.Columns.Clear()
            DataGridView.Columns.Add("PN", "PARTNUMBERS")

            While objDataReader.Read()
                Dim row As String() = New String() {
                    objDataReader("PN_PARTNUMBER").ToString()
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

    'da entrada na caixa
    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click
        ACAO = 2
        AddHandler Login.LoginVerificaTreino,
            Sub()
                Try
                    VerificaTreino()
                    If Verifica = True Then
                        Page_Entrada.JBC = JBC
                        Page_Entrada.REG = REG
                        Page_Entrada.txt_jbc.Text = "JBC/" & JBC
                        Page_Entrada.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Sub
        Login.Show()
    End Sub

    'da inspeção na caixa
    Private Sub btn_inspecao_Click(sender As Object, e As EventArgs) Handles btn_inspecao.Click
        ACAO = 2
        AddHandler Login.LoginVerificaTreino,
            Sub()
                Try
                    VerificaTreino()
                    If Verifica = True Then
                        Page_Inspecao.JBC = JBC
                        Page_Inspecao.REG = REG
                        Page_Inspecao.txt_jbc.Text = "JBC/" & JBC
                        Page_Inspecao.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Sub
        Login.Show()
    End Sub

    'verifica se foi treinado e da as revisões que não foi treinado
    Private Sub VerificaTreino()
        If REV.Count <> 0 Then
            Dim massasge As String = ""
            For i As Integer = 0 To REV.Count - 1
                If REV(i) = REV.Last Then
                    massasge &= REV(i)
                ElseIf REV(i) = REV.Last - 1 Then
                    massasge &= REV(i) & " e "
                Else
                    massasge &= REV(i) & ", "
                End If
            Next
            MessageBox.Show("Funcionário não treinado para as revisões " & massasge & " da JBC " & JBC & ".")
            Verifica = False
        Else
            Verifica = True
        End If
    End Sub

    Private Sub Page_Apontar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Page_Entrada.Close()
        Page_Inspecao.Close()
    End Sub

    Private Sub txt_proc_TextChanged(sender As Object, e As EventArgs) Handles txt_proc.TextChanged
        Lista_Entrada()
    End Sub

    Private Sub DataGridView_Entrada_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView_Entrada.DoubleClick
        ACAO = 2
        AddHandler Login.LoginVerificaTreino,
            Sub()
                Try
                    VerificaTreino()
                    If Verifica = True Then
                        If DataGridView_Entrada.SelectedRows.Count > 0 Then
                            Dim selectedRow As DataGridViewRow = DataGridView_Entrada.SelectedRows(0)
                            Page_Saida.CON_ID = selectedRow.Cells(0).Value
                            Page_Saida.JBC = JBC
                            Page_Saida.REG = REG
                            Page_Saida.txt_jbc.Text = "JBC/" & JBC
                            Page_Saida.Show()
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Sub
        Login.Show()
    End Sub

    Sub Lista_Entrada()
        Try
            conectar()
            comandoSQL.CommandText = "SELECT C.CON_ID,C.CON_CAIXA,C.PN_PARTNUMBER,C.CON_QUANTIDADE,C.CON_ENTRADA,DATEDIFF(DAY, C.CON_ENTRADA, GETDATE()) AS DIAS,C.CON_INS_INICIO "
            comandoSQL.CommandText &= "FROM TAB_JBC_CONTENCAO C WHERE C.CON_SAIDA IS NULL AND JBC_ID = " & JBC & " AND (('" & txt_proc.Text & "' = '' OR C.CON_CAIXA LIKE '" & txt_proc.Text & "%') "
            comandoSQL.CommandText &= "OR ('" & txt_proc.Text & "' = '' OR C.PN_PARTNUMBER LIKE '" & txt_proc.Text & "%')) GROUP BY C.CON_ID, C.CON_CAIXA, C.PN_PARTNUMBER, C.CON_QUANTIDADE, C.CON_ENTRADA, C.CON_INS_INICIO "
            objDataReader = comandoSQL.ExecuteReader
            DataGridView_Entrada.Rows.Clear()
            DataGridView_Entrada.Columns.Clear()
            DataGridView_Entrada.Columns.Add("CON_ID", "ID")
            DataGridView_Entrada.Columns.Add("CON_CAIXA", "CAIXA")
            DataGridView_Entrada.Columns.Add("PN_PARTNUMBER", "PARTNUMBER")
            DataGridView_Entrada.Columns.Add("CON_QUANTIDADE", "QUANTIDADE")
            DataGridView_Entrada.Columns.Add("CON_ENTRADA", "ENTRADA")
            DataGridView_Entrada.Columns.Add("DIAS", "DIAS EM CONTENÃO")
            DataGridView_Entrada.Columns.Add("CON_INS_INICIO", "INICIO INSPEÇÃO")

            ' Definir a propiedade das colunas
            DataGridView_Entrada.Columns("CON_ID").Visible = False

            While objDataReader.Read()
                Dim row As String() = New String() {
                    objDataReader("CON_ID").ToString(),
                    objDataReader("CON_CAIXA").ToString(),
                    objDataReader("PN_PARTNUMBER").ToString(),
                    objDataReader("CON_QUANTIDADE").ToString(),
                    Convert.ToDateTime(objDataReader("CON_ENTRADA")).ToString("dd/MM/yyyy"),
                    objDataReader("DIAS").ToString(),
                    If(objDataReader("CON_INS_INICIO") IsNot DBNull.Value, Convert.ToDateTime(objDataReader("CON_INS_INICIO")).ToString("dd/MM/yyyy HH:mm"), "SEM INSPEÇÃO")
                }
                DataGridView_Entrada.Rows.Add(row)
            End While
            objDataReader.Close()
            desconectar()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
        DataGridView_Entrada.ClearSelection()
    End Sub

End Class
