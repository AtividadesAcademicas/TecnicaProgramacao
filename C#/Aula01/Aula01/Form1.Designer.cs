
namespace Aula01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblRGM = new System.Windows.Forms.Label();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtRGM = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.btnExibirAluno = new System.Windows.Forms.Button();
            this.btnExibirProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(97, 67);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(50, 20);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(97, 273);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(77, 20);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(153, 91);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(51, 20);
            this.lblNomeAluno.TabIndex = 2;
            this.lblNomeAluno.Text = "Nome";
            // 
            // lblRGM
            // 
            this.lblRGM.AutoSize = true;
            this.lblRGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGM.Location = new System.Drawing.Point(153, 128);
            this.lblRGM.Name = "lblRGM";
            this.lblRGM.Size = new System.Drawing.Size(47, 20);
            this.lblRGM.TabIndex = 3;
            this.lblRGM.Text = "RGM";
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(153, 300);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(51, 20);
            this.lblNomeProfessor.TabIndex = 4;
            this.lblNomeProfessor.Text = "Nome";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(153, 337);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(227, 88);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(100, 26);
            this.txtNomeAluno.TabIndex = 6;
            // 
            // txtRGM
            // 
            this.txtRGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGM.Location = new System.Drawing.Point(227, 125);
            this.txtRGM.Name = "txtRGM";
            this.txtRGM.Size = new System.Drawing.Size(100, 26);
            this.txtRGM.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(227, 334);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 26);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfessor.Location = new System.Drawing.Point(227, 297);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(100, 26);
            this.txtNomeProfessor.TabIndex = 8;
            // 
            // btnExibirAluno
            // 
            this.btnExibirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirAluno.Location = new System.Drawing.Point(617, 84);
            this.btnExibirAluno.Name = "btnExibirAluno";
            this.btnExibirAluno.Size = new System.Drawing.Size(75, 35);
            this.btnExibirAluno.TabIndex = 10;
            this.btnExibirAluno.Text = "Exibir";
            this.btnExibirAluno.UseVisualStyleBackColor = true;
            this.btnExibirAluno.Click += new System.EventHandler(this.btnExibirAluno_Click);
            // 
            // btnExibirProfessor
            // 
            this.btnExibirProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirProfessor.Location = new System.Drawing.Point(617, 294);
            this.btnExibirProfessor.Name = "btnExibirProfessor";
            this.btnExibirProfessor.Size = new System.Drawing.Size(75, 33);
            this.btnExibirProfessor.TabIndex = 11;
            this.btnExibirProfessor.Text = "Exibir";
            this.btnExibirProfessor.UseVisualStyleBackColor = true;
            this.btnExibirProfessor.Click += new System.EventHandler(this.btnExibirProfessor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibirProfessor);
            this.Controls.Add(this.btnExibirAluno);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.txtRGM);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNomeProfessor);
            this.Controls.Add(this.lblRGM);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblRGM;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtRGM;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Button btnExibirAluno;
        private System.Windows.Forms.Button btnExibirProfessor;
    }
}

