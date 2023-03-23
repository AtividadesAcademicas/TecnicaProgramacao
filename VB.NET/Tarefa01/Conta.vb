Public Class Conta
    Private nome As String
    Private numConta As Integer
    Private saldo As Decimal

    Public Sub New()
        Me.nome = Nothing
        Me.numConta = Nothing
        Me.saldo = Nothing
    End Sub

    Public Sub New(nome As String, numConta As Integer, saldo As Decimal)
        Me.nome = nome
        Me.numConta = numConta
        Me.saldo = saldo
    End Sub

    Public Property pNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property pNumConta As Integer
        Get
            Return numConta
        End Get
        Set(value As Integer)
            numConta = value
        End Set
    End Property

    Public Property pSaldo As Decimal
        Get
            Return saldo
        End Get
        Set(value As Decimal)
            saldo = value
        End Set
    End Property

    Public Sub Depositar(valor As Decimal)
        Me.saldo = Me.saldo + valor
    End Sub

    Public Sub Sacar(valor As Decimal)
        If Me.saldo < valor Then
            MessageBox.Show("Saldo insuficiente", "Erro")
        Else
            Me.saldo = Me.saldo - valor
        End If
    End Sub
End Class
