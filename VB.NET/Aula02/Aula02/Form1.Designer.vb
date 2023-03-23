<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Comparar = New System.Windows.Forms.Button()
        Me.Limpar = New System.Windows.Forms.Button()
        Me.Label_1idade = New System.Windows.Forms.Label()
        Me.Label_2idade = New System.Windows.Forms.Label()
        Me.TextBox_1idade = New System.Windows.Forms.TextBox()
        Me.TextBox_2idade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Comparar
        '
        Me.Comparar.Location = New System.Drawing.Point(203, 219)
        Me.Comparar.Name = "Comparar"
        Me.Comparar.Size = New System.Drawing.Size(100, 23)
        Me.Comparar.TabIndex = 0
        Me.Comparar.Text = "Comparar"
        Me.Comparar.UseVisualStyleBackColor = True
        '
        'Limpar
        '
        Me.Limpar.Location = New System.Drawing.Point(203, 248)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(100, 23)
        Me.Limpar.TabIndex = 1
        Me.Limpar.Text = "Limpar"
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Label_1idade
        '
        Me.Label_1idade.AutoSize = True
        Me.Label_1idade.Location = New System.Drawing.Point(143, 108)
        Me.Label_1idade.Name = "Label_1idade"
        Me.Label_1idade.Size = New System.Drawing.Size(114, 13)
        Me.Label_1idade.TabIndex = 2
        Me.Label_1idade.Text = "Digite a primeira idade:"
        '
        'Label_2idade
        '
        Me.Label_2idade.AutoSize = True
        Me.Label_2idade.Location = New System.Drawing.Point(138, 143)
        Me.Label_2idade.Name = "Label_2idade"
        Me.Label_2idade.Size = New System.Drawing.Size(119, 13)
        Me.Label_2idade.TabIndex = 3
        Me.Label_2idade.Text = "Digite a segunda idade:"
        '
        'TextBox_1idade
        '
        Me.TextBox_1idade.Location = New System.Drawing.Point(263, 105)
        Me.TextBox_1idade.Name = "TextBox_1idade"
        Me.TextBox_1idade.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_1idade.TabIndex = 4
        '
        'TextBox_2idade
        '
        Me.TextBox_2idade.Location = New System.Drawing.Point(263, 140)
        Me.TextBox_2idade.Name = "TextBox_2idade"
        Me.TextBox_2idade.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_2idade.TabIndex = 5
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_2idade)
        Me.Controls.Add(Me.TextBox_1idade)
        Me.Controls.Add(Me.Label_2idade)
        Me.Controls.Add(Me.Label_1idade)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Comparar)
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Comparar As Button
    Friend WithEvents Limpar As Button
    Friend WithEvents Label_1idade As Label
    Friend WithEvents Label_2idade As Label
    Friend WithEvents TextBox_1idade As TextBox
    Friend WithEvents TextBox_2idade As TextBox
End Class
