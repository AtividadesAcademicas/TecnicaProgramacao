using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    class Despertador:Horario
    {
        private String descricao;
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public Despertador(short horas, short minutos, short segundos, String descricao):base(horas, minutos, segundos)
        {
            this.descricao = descricao;
        }
        public Despertador(short horas, short minutos, String descricao) : base(horas, minutos)
        {
            this.descricao = descricao;
        }
        public Despertador() : base()
        {
            this.descricao = null;
        }
        public String Despertar(Horario horario)
        {
            if (this.Print() == horario.Print())
            {
                return this.descricao + " está na hora";
            }
            else
            {
                return "Ainda não está na hora";
            }
        }
    }
}
