
namespace Atividade01
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
            this.gpbDespertador = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSegundoDespertador = new System.Windows.Forms.Label();
            this.lblMinutoDespertador = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblHoraDespertador = new System.Windows.Forms.Label();
            this.txtSegundoDespertador = new System.Windows.Forms.TextBox();
            this.txtHoraDespertador = new System.Windows.Forms.TextBox();
            this.txtMinutoDespertador = new System.Windows.Forms.TextBox();
            this.gpbRelogio = new System.Windows.Forms.GroupBox();
            this.txtSegundoRelogio = new System.Windows.Forms.TextBox();
            this.lblSegundoRelogio = new System.Windows.Forms.Label();
            this.txtMinutoRelogio = new System.Windows.Forms.TextBox();
            this.lblMinutoRelogio = new System.Windows.Forms.Label();
            this.txtHoraRelogio = new System.Windows.Forms.TextBox();
            this.lblHoraRelogio = new System.Windows.Forms.Label();
            this.btnCriarDespertador = new System.Windows.Forms.Button();
            this.btnCriarRelogio = new System.Windows.Forms.Button();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.gpbDespertador.SuspendLayout();
            this.gpbRelogio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDespertador
            // 
            this.gpbDespertador.Controls.Add(this.lblDescricao);
            this.gpbDespertador.Controls.Add(this.lblSegundoDespertador);
            this.gpbDespertador.Controls.Add(this.lblMinutoDespertador);
            this.gpbDespertador.Controls.Add(this.txtDescricao);
            this.gpbDespertador.Controls.Add(this.lblHoraDespertador);
            this.gpbDespertador.Controls.Add(this.txtSegundoDespertador);
            this.gpbDespertador.Controls.Add(this.txtHoraDespertador);
            this.gpbDespertador.Controls.Add(this.txtMinutoDespertador);
            this.gpbDespertador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDespertador.Location = new System.Drawing.Point(12, 12);
            this.gpbDespertador.Name = "gpbDespertador";
            this.gpbDespertador.Size = new System.Drawing.Size(370, 216);
            this.gpbDespertador.TabIndex = 0;
            this.gpbDespertador.TabStop = false;
            this.gpbDespertador.Text = "Despertador";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(30, 139);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblSegundoDespertador
            // 
            this.lblSegundoDespertador.AutoSize = true;
            this.lblSegundoDespertador.Location = new System.Drawing.Point(36, 107);
            this.lblSegundoDespertador.Name = "lblSegundoDespertador";
            this.lblSegundoDespertador.Size = new System.Drawing.Size(74, 20);
            this.lblSegundoDespertador.TabIndex = 3;
            this.lblSegundoDespertador.Text = "Segundo";
            // 
            // lblMinutoDespertador
            // 
            this.lblMinutoDespertador.AutoSize = true;
            this.lblMinutoDespertador.Location = new System.Drawing.Point(53, 75);
            this.lblMinutoDespertador.Name = "lblMinutoDespertador";
            this.lblMinutoDespertador.Size = new System.Drawing.Size(57, 20);
            this.lblMinutoDespertador.TabIndex = 2;
            this.lblMinutoDespertador.Text = "Minuto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 136);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(248, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // lblHoraDespertador
            // 
            this.lblHoraDespertador.AutoSize = true;
            this.lblHoraDespertador.Location = new System.Drawing.Point(66, 43);
            this.lblHoraDespertador.Name = "lblHoraDespertador";
            this.lblHoraDespertador.Size = new System.Drawing.Size(44, 20);
            this.lblHoraDespertador.TabIndex = 0;
            this.lblHoraDespertador.Text = "Hora";
            // 
            // txtSegundoDespertador
            // 
            this.txtSegundoDespertador.Location = new System.Drawing.Point(116, 104);
            this.txtSegundoDespertador.Name = "txtSegundoDespertador";
            this.txtSegundoDespertador.Size = new System.Drawing.Size(100, 26);
            this.txtSegundoDespertador.TabIndex = 4;
            // 
            // txtHoraDespertador
            // 
            this.txtHoraDespertador.Location = new System.Drawing.Point(116, 40);
            this.txtHoraDespertador.Name = "txtHoraDespertador";
            this.txtHoraDespertador.Size = new System.Drawing.Size(100, 26);
            this.txtHoraDespertador.TabIndex = 2;
            // 
            // txtMinutoDespertador
            // 
            this.txtMinutoDespertador.Location = new System.Drawing.Point(116, 72);
            this.txtMinutoDespertador.Name = "txtMinutoDespertador";
            this.txtMinutoDespertador.Size = new System.Drawing.Size(100, 26);
            this.txtMinutoDespertador.TabIndex = 3;
            // 
            // gpbRelogio
            // 
            this.gpbRelogio.Controls.Add(this.txtSegundoRelogio);
            this.gpbRelogio.Controls.Add(this.lblSegundoRelogio);
            this.gpbRelogio.Controls.Add(this.txtMinutoRelogio);
            this.gpbRelogio.Controls.Add(this.lblMinutoRelogio);
            this.gpbRelogio.Controls.Add(this.txtHoraRelogio);
            this.gpbRelogio.Controls.Add(this.lblHoraRelogio);
            this.gpbRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRelogio.Location = new System.Drawing.Point(388, 12);
            this.gpbRelogio.Name = "gpbRelogio";
            this.gpbRelogio.Size = new System.Drawing.Size(400, 216);
            this.gpbRelogio.TabIndex = 1;
            this.gpbRelogio.TabStop = false;
            this.gpbRelogio.Text = "Relógio";
            // 
            // txtSegundoRelogio
            // 
            this.txtSegundoRelogio.Location = new System.Drawing.Point(105, 104);
            this.txtSegundoRelogio.Name = "txtSegundoRelogio";
            this.txtSegundoRelogio.Size = new System.Drawing.Size(100, 26);
            this.txtSegundoRelogio.TabIndex = 8;
            // 
            // lblSegundoRelogio
            // 
            this.lblSegundoRelogio.AutoSize = true;
            this.lblSegundoRelogio.Location = new System.Drawing.Point(25, 107);
            this.lblSegundoRelogio.Name = "lblSegundoRelogio";
            this.lblSegundoRelogio.Size = new System.Drawing.Size(74, 20);
            this.lblSegundoRelogio.TabIndex = 7;
            this.lblSegundoRelogio.Text = "Segundo";
            // 
            // txtMinutoRelogio
            // 
            this.txtMinutoRelogio.Location = new System.Drawing.Point(105, 72);
            this.txtMinutoRelogio.Name = "txtMinutoRelogio";
            this.txtMinutoRelogio.Size = new System.Drawing.Size(100, 26);
            this.txtMinutoRelogio.TabIndex = 7;
            // 
            // lblMinutoRelogio
            // 
            this.lblMinutoRelogio.AutoSize = true;
            this.lblMinutoRelogio.Location = new System.Drawing.Point(42, 75);
            this.lblMinutoRelogio.Name = "lblMinutoRelogio";
            this.lblMinutoRelogio.Size = new System.Drawing.Size(57, 20);
            this.lblMinutoRelogio.TabIndex = 6;
            this.lblMinutoRelogio.Text = "Minuto";
            // 
            // txtHoraRelogio
            // 
            this.txtHoraRelogio.Location = new System.Drawing.Point(105, 40);
            this.txtHoraRelogio.Name = "txtHoraRelogio";
            this.txtHoraRelogio.Size = new System.Drawing.Size(100, 26);
            this.txtHoraRelogio.TabIndex = 6;
            // 
            // lblHoraRelogio
            // 
            this.lblHoraRelogio.AutoSize = true;
            this.lblHoraRelogio.Location = new System.Drawing.Point(55, 43);
            this.lblHoraRelogio.Name = "lblHoraRelogio";
            this.lblHoraRelogio.Size = new System.Drawing.Size(44, 20);
            this.lblHoraRelogio.TabIndex = 5;
            this.lblHoraRelogio.Text = "Hora";
            // 
            // btnCriarDespertador
            // 
            this.btnCriarDespertador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarDespertador.Location = new System.Drawing.Point(200, 234);
            this.btnCriarDespertador.Name = "btnCriarDespertador";
            this.btnCriarDespertador.Size = new System.Drawing.Size(75, 31);
            this.btnCriarDespertador.TabIndex = 2;
            this.btnCriarDespertador.Text = "Criar";
            this.btnCriarDespertador.UseVisualStyleBackColor = true;
            this.btnCriarDespertador.Click += new System.EventHandler(this.btnCriarDespertador_Click);
            // 
            // btnCriarRelogio
            // 
            this.btnCriarRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarRelogio.Location = new System.Drawing.Point(482, 234);
            this.btnCriarRelogio.Name = "btnCriarRelogio";
            this.btnCriarRelogio.Size = new System.Drawing.Size(75, 31);
            this.btnCriarRelogio.TabIndex = 3;
            this.btnCriarRelogio.Text = "Criar";
            this.btnCriarRelogio.UseVisualStyleBackColor = true;
            this.btnCriarRelogio.Click += new System.EventHandler(this.btnCriarRelogio_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(343, 303);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 31);
            this.btnAnalisar.TabIndex = 4;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.btnCriarRelogio);
            this.Controls.Add(this.btnCriarDespertador);
            this.Controls.Add(this.gpbRelogio);
            this.Controls.Add(this.gpbDespertador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbDespertador.ResumeLayout(false);
            this.gpbDespertador.PerformLayout();
            this.gpbRelogio.ResumeLayout(false);
            this.gpbRelogio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDespertador;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSegundoDespertador;
        private System.Windows.Forms.Label lblMinutoDespertador;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblHoraDespertador;
        private System.Windows.Forms.TextBox txtSegundoDespertador;
        private System.Windows.Forms.TextBox txtHoraDespertador;
        private System.Windows.Forms.TextBox txtMinutoDespertador;
        private System.Windows.Forms.GroupBox gpbRelogio;
        private System.Windows.Forms.TextBox txtSegundoRelogio;
        private System.Windows.Forms.Label lblSegundoRelogio;
        private System.Windows.Forms.TextBox txtMinutoRelogio;
        private System.Windows.Forms.Label lblMinutoRelogio;
        private System.Windows.Forms.TextBox txtHoraRelogio;
        private System.Windows.Forms.Label lblHoraRelogio;
        private System.Windows.Forms.Button btnCriarDespertador;
        private System.Windows.Forms.Button btnCriarRelogio;
        private System.Windows.Forms.Button btnAnalisar;
    }
}

