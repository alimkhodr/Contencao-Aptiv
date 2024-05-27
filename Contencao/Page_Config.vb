Imports System.IO

Public Class Page_Config
    Public JBC, REG As Integer

    Private Sub Page_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_area.Items.Clear()
        cbo_area.Items.Add("2030")
        cbo_area.Items.Add("CARE")
        cbo_area.Items.Add("2070")
        cbo_area.Items.Add("2010")
        cbo_area.Items.Add("RETABA")
        cbo_area.Items.Add("BT")

        set_area()
        cbo_area.Text = Area
    End Sub

    Private Sub btn_entrada_Click(sender As Object, e As EventArgs) Handles btn_entrada.Click
        Dim folderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Contencao")
        Dim filePath As String = Path.Combine(folderPath, "area.txt")

        If File.Exists(filePath) Then
            File.WriteAllText(filePath, cbo_area.Text)
            MessageBox.Show("Área alterada.")
            set_area()
        Else
            MessageBox.Show("Arquivo contendo a área apagado")
        End If
    End Sub

End Class
