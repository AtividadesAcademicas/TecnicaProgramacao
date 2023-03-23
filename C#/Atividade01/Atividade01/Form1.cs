using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class Form1 : Form
    {
        Despertador despertador = new Despertador();
        Horario horario = new Horario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarDespertador_Click(object sender, EventArgs e)
        {
            if (!(txtHoraDespertador.Text == ""))
            {
                despertador.Hora = Convert.ToInt16(txtHoraDespertador.Text);
            }
            else
            {
                despertador.Hora = 0;
            }

            if (!(txtMinutoDespertador.Text == ""))
            {
                despertador.Minuto = Convert.ToInt16(txtMinutoDespertador.Text);
            }
            else
            {
                despertador.Hora = 0;
            }

            if (!(txtSegundoDespertador.Text == ""))
            {
                despertador.Segundo = Convert.ToInt16(txtSegundoDespertador.Text);
            }
            else
            {
                despertador.Hora = 0;
            }
            despertador.Descricao = txtDescricao.Text;
            MessageBox.Show("Despertador criado", "Sucesso");
        }

        private void btnCriarRelogio_Click(object sender, EventArgs e)
        {
            if (!(txtHoraRelogio.Text == ""))
            {
                horario.Hora = Convert.ToInt16(txtHoraRelogio.Text);
            }
            else
            {
                horario.Hora = 0;
            }

            if (!(txtMinutoRelogio.Text == ""))
            {
                horario.Minuto = Convert.ToInt16(txtMinutoRelogio.Text);
            }
            else
            {
                horario.Minuto = 0;
            }

            if (!(txtSegundoRelogio.Text == ""))
            {
                horario.Segundo = Convert.ToInt16(txtSegundoRelogio.Text);
            }
            else
            {
                horario.Segundo = 0;
            }
            MessageBox.Show("Horário criado", "Sucesso");
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = despertador.Despertar(horario);
        }
    }
}
