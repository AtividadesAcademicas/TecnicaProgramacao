Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salario, reajuste, novosalario As Double

        salario = TextBox2.Text
        reajuste = TextBox3.Text

        novosalario = salario + (salario * reajuste / 100)

        Label4.Text = "O novo salário de " & TextBox1.Text & " é R$" & novosalario
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label4.Text = "Preencha os campos para calcular o reajuste"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
