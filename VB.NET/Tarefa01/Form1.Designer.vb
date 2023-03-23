<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblAniversario = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtAniversario = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblSaldo2 = New System.Windows.Forms.Label()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.txtSaldo2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(209, 36)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(51, 20)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome"
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConta.Location = New System.Drawing.Point(208, 68)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(52, 20)
        Me.lblConta.TabIndex = 1
        Me.lblConta.Text = "Conta"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(210, 100)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(50, 20)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo"
        '
        'lblAniversario
        '
        Me.lblAniversario.AutoSize = True
        Me.lblAniversario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAniversario.Location = New System.Drawing.Point(173, 132)
        Me.lblAniversario.Name = "lblAniversario"
        Me.lblAniversario.Size = New System.Drawing.Size(87, 20)
        Me.lblAniversario.TabIndex = 3
        Me.lblAniversario.Text = "Aniversário"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(266, 33)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(334, 26)
        Me.txtNome.TabIndex = 4
        '
        'txtConta
        '
        Me.txtConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConta.Location = New System.Drawing.Point(266, 65)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(334, 26)
        Me.txtConta.TabIndex = 5
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(266, 97)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(334, 26)
        Me.txtSaldo.TabIndex = 6
        '
        'txtAniversario
        '
        Me.txtAniversario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAniversario.Location = New System.Drawing.Point(266, 129)
        Me.txtAniversario.Name = "txtAniversario"
        Me.txtAniversario.Size = New System.Drawing.Size(334, 26)
        Me.txtAniversario.TabIndex = 7
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(237, 310)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 26)
        Me.txtValor.TabIndex = 8
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(233, 287)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(46, 20)
        Me.lblValor.TabIndex = 9
        Me.lblValor.Text = "Valor"
        '
        'lblSaldo2
        '
        Me.lblSaldo2.AutoSize = True
        Me.lblSaldo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo2.Location = New System.Drawing.Point(502, 287)
        Me.lblSaldo2.Name = "lblSaldo2"
        Me.lblSaldo2.Size = New System.Drawing.Size(50, 20)
        Me.lblSaldo2.TabIndex = 10
        Me.lblSaldo2.Text = "Saldo"
        '
        'btnCriar
        '
        Me.btnCriar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriar.Location = New System.Drawing.Point(351, 185)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(125, 30)
        Me.btnCriar.TabIndex = 11
        Me.btnCriar.Text = "Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositar.Location = New System.Drawing.Point(367, 284)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(94, 30)
        Me.btnDepositar.TabIndex = 12
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSacar.Location = New System.Drawing.Point(367, 320)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(94, 30)
        Me.btnSacar.TabIndex = 13
        Me.btnSacar.Text = "Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'txtSaldo2
        '
        Me.txtSaldo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo2.Location = New System.Drawing.Point(506, 310)
        Me.txtSaldo2.Name = "txtSaldo2"
        Me.txtSaldo2.ReadOnly = True
        Me.txtSaldo2.Size = New System.Drawing.Size(100, 26)
        Me.txtSaldo2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSaldo2)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.lblSaldo2)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtAniversario)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblAniversario)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblConta)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents lblConta As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblAniversario As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtConta As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtAniversario As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents lblSaldo2 As Label
    Friend WithEvents btnCriar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnSacar As Button
    Friend WithEvents txtSaldo2 As TextBox
End Class
