Imports System.Data.SqlClient
Imports System.IO
Module Modulo
    Public conexaobd As New SqlConnection()
    Public objDataReader As SqlDataReader
    Public comandoSQL As SqlCommand
    Public ACAO, Treinador, Funcionario As Integer
    Public Area As String

    Sub set_area()
        Dim folderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Contencao")
        Dim filePath As String = Path.Combine(folderPath, "area.txt")

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        If File.Exists(filePath) Then
            Dim fileContent As String = File.ReadAllText(filePath)
            Area = fileContent
        Else
            Area = "2030"
            File.WriteAllText(filePath, Area)
        End If
    End Sub

    Public Sub conectar()
        Try
            conexaobd.ConnectionString = "server=BRSPJAM-AP07;database=SGM_ONE;uid=sa;pwd=P@ssw0rd"
            comandoSQL = conexaobd.CreateCommand
            conexaobd.Open()

        Catch ex As Exception
            conexaobd.Close()
            conexaobd.ConnectionString = "server=BRSPJAM-AP07;database=SGM_ONE;uid=sa;pwd=P@ssw0rd"
            comandoSQL = conexaobd.CreateCommand
            conexaobd.Open()
        End Try

    End Sub
    Public Sub desconectar()
        Try
            conexaobd.Close()
            objDataReader.Close()
        Catch ex As Exception

        End Try
    End Sub
End Module
