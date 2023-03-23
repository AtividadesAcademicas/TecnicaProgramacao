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
        Me.btExibir = New System.Windows.Forms.Button()
        Me.lblAluno = New System.Windows.Forms.Label()
        Me.lblRGM = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtRGM = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtNomeProfessor = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblNomeProfessor = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.btExibirProfessor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btExibir
        '
        Me.btExibir.Location = New System.Drawing.Point(403, 175)
        Me.btExibir.Name = "btExibir"
        Me.btExibir.Size = New System.Drawing.Size(75, 23)
        Me.btExibir.TabIndex = 0
        Me.btExibir.Text = "Exibir"
        Me.btExibir.UseVisualStyleBackColor = True
        '
        'lblAluno
        '
        Me.lblAluno.AutoSize = True
        Me.lblAluno.Location = New System.Drawing.Point(208, 131)
        Me.lblAluno.Name = "lblAluno"
        Me.lblAluno.Size = New System.Drawing.Size(34, 13)
        Me.lblAluno.TabIndex = 1
        Me.lblAluno.Text = "Aluno"
        '
        'lblRGM
        '
        Me.lblRGM.AutoSize = True
        Me.lblRGM.Location = New System.Drawing.Point(208, 180)
        Me.lblRGM.Name = "lblRGM"
        Me.lblRGM.Size = New System.Drawing.Size(32, 13)
        Me.lblRGM.TabIndex = 2
        Me.lblRGM.Text = "RGM"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(205, 206)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'txtRGM
        '
        Me.txtRGM.Location = New System.Drawing.Point(246, 177)
        Me.txtRGM.Name = "txtRGM"
        Me.txtRGM.Size = New System.Drawing.Size(151, 20)
        Me.txtRGM.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(246, 203)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(232, 20)
        Me.txtNome.TabIndex = 5
        '
        'txtNomeProfessor
        '
        Me.txtNomeProfessor.Location = New System.Drawing.Point(246, 340)
        Me.txtNomeProfessor.Name = "txtNomeProfessor"
        Me.txtNomeProfessor.Size = New System.Drawing.Size(232, 20)
        Me.txtNomeProfessor.TabIndex = 11
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(246, 314)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(151, 20)
        Me.txtTitulo.TabIndex = 10
        '
        'lblNomeProfessor
        '
        Me.lblNomeProfessor.AutoSize = True
        Me.lblNomeProfessor.Location = New System.Drawing.Point(205, 343)
        Me.lblNomeProfessor.Name = "lblNomeProfessor"
        Me.lblNomeProfessor.Size = New System.Drawing.Size(35, 13)
        Me.lblNomeProfessor.TabIndex = 9
        Me.lblNomeProfessor.Text = "Nome"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(208, 317)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Título"
        '
        'lblProfessor
        '
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Location = New System.Drawing.Point(208, 268)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(51, 13)
        Me.lblProfessor.TabIndex = 7
        Me.lblProfessor.Text = "Professor"
        '
        'btExibirProfessor
        '
        Me.btExibirProfessor.Location = New System.Drawing.Point(403, 312)
        Me.btExibirProfessor.Name = "btExibirProfessor"
        Me.btExibirProfessor.Size = New System.Drawing.Size(75, 23)
        Me.btExibirProfessor.TabIndex = 6
        Me.btExibirProfessor.Text = "Exibir"
        Me.btExibirProfessor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNomeProfessor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblNomeProfessor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblProfessor)
        Me.Controls.Add(Me.btExibirProfessor)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtRGM)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblRGM)
        Me.Controls.Add(Me.lblAluno)
        Me.Controls.Add(Me.btExibir)
        Me.Name = "Form1"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btExibir As Button
    Friend WithEvents lblAluno As Label
    Friend WithEvents lblRGM As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents txtRGM As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtNomeProfessor As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblNomeProfessor As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblProfessor As Label
    Friend WithEvents btExibirProfessor As Button
End Class
