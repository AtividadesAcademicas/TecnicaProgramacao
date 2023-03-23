Public Class Form
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_1idade.Click

    End Sub

    Private Sub Comparar_Click(sender As Object, e As EventArgs) Handles Comparar.Click
        Dim idade1, idade2 As Integer

        idade1 = CInt(TextBox_1idade.Text)
        idade2 = CInt(TextBox_2idade.Text)

        If idade1 = idade2 Then
            MessageBox.Show("As idades são iguais", "Resultado")
        ElseIf idade1 > idade2 Then
            MessageBox.Show("A primeira idade é a maior", "Resultado")
        Else
            MessageBox.Show("A segunda idade é a maior", "Resultado")
        End If
    End Sub

    Private Sub Limpar_Click(sender As Object, e As EventArgs) Handles Limpar.Click
        TextBox_1idade.Clear()
        TextBox_2idade.Clear()
    End Sub
End Class
