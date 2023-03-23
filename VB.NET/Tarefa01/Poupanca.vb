Public Class Poupanca
    Inherits Conta
    Private dataAniversario As Integer

    Public Sub New()
        MyBase.New()
        Me.dataAniversario = Nothing
    End Sub

    Public Sub New(nome As String, numConta As Integer, saldo As Decimal, dataAniversario As String)
        MyBase.New(nome, numConta, saldo)
        Me.dataAniversario = dataAniversario
    End Sub

    Public Property pDataAniversario As String
        Get
            Return dataAniversario
        End Get
        Set(value As String)
            dataAniversario = value
        End Set
    End Property
End Class
