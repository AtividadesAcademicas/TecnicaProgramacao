Public Class Form1
    Dim obj_conta = New Poupanca()

    Public Sub Atualiza()
        txtValor.Clear()
        txtSaldo.Text = obj_conta.pSaldo
        txtSaldo2.Text = obj_conta.pSaldo
    End Sub

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        If String.IsNullOrEmpty(txtConta.Text) Or String.IsNullOrEmpty(txtNome.Text) Or String.IsNullOrEmpty(txtSaldo.Text) Or String.IsNullOrEmpty(txtAniversario.Text) Then
            MessageBox.Show("Preencha todos os campos", "Erro")
        Else
            If CInt(txtConta.Text) <> obj_conta.pNumConta Then
                obj_conta.pNumConta = CInt(txtConta.Text)
                obj_conta.pNome = txtNome.Text
                obj_conta.pSaldo = CDec(txtSaldo.Text)
                obj_conta.pDataAniversario = CInt(txtAniversario.Text)
                MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso")
            Else
                MessageBox.Show("Cliente já cadastrado", "Erro")
            End If
            Atualiza()
        End If
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        If String.IsNullOrEmpty(txtValor.Text) Then
            MessageBox.Show("Preencha o valor", "Erro")
        Else
            obj_conta.Depositar(CDec(txtValor.Text))
            Atualiza()
        End If
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        If String.IsNullOrEmpty(txtValor.Text) Then
            MessageBox.Show("Preencha o valor", "Erro")
        Else
            If obj_conta.pSaldo >= CDec(txtValor.Text) Then
                obj_conta.Sacar(CDec(txtValor.Text))
            Else
                MessageBox.Show("Saldo insuficiente", "Erro")
            End If
            Atualiza()
        End If
    End Sub
End Class