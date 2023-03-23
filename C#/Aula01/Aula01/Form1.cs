using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Form1 : Form
    {
        Aluno objetoAluno;
        public Form1()
        {
            InitializeComponent();
            objetoAluno = new Aluno("111.111.111-11", "Paulo", "11.111-1");
        }

        private void btnExibirAluno_Click(object sender, EventArgs e)
        {
            txtRGM.Text = objetoAluno.RGM;
            txtNomeAluno.Text = objetoAluno.Nome;
        }

        private void btnExibirProfessor_Click(object sender, EventArgs e)
        {
            Professor objetoProfessor = new Professor("111.111.111-12", "João", "Mestre");
            txtNomeProfessor.Text = objetoProfessor.Nome;
            txtTitulo.Text = objetoProfessor.Titulo;
        }
    }
}
