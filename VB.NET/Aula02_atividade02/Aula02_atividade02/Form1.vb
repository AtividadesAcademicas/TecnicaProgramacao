Public Class Form1
    Private Sub btExibir_Click(sender As Object, e As EventArgs) Handles btExibir.Click
        Dim obj_aluno As New Aluno("Pedro", "123456789")
        txtNome.Text = obj_aluno.PNome
        txtRGM.Text = obj_aluno.prgm
    End Sub

    Private Sub btExibirProfessor_Click(sender As Object, e As EventArgs) Handles btExibirProfessor.Click
        Dim obj_professor As New Professor("Cláudio", "Professor")
        txtNomeProfessor.Text = obj_professor.PNome
        txtTitulo.Text = obj_professor.pTitulo
    End Sub
End Class
