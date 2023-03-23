using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    class Horario
    {
        private short hora;
        public short Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private short minuto;
        public short Minuto
        {
            get { return minuto; }
            set { minuto = value; }
        }

        private short segundo;
        public short Segundo
        {
            get { return segundo; }
            set { segundo = value; }
        }

        public Horario()
        {
            this.hora = 0;
            this.minuto = 0;
            this.segundo = 0;
        }

        public Horario(short horas, short minutos, short segundos)
        {
            this.hora = horas;
            this.minuto = minutos;
            this.segundo = segundos;
        }

        public Horario(short horas, short minutos)
        {
            this.hora = horas;
            this.minuto = minutos;
            this.segundo = 0;
        }

        public int EmSegundos()
        {
            int segundos = this.segundo + (this.minuto * 60) + ((this.hora * 60) * 60);
            return segundos;
        }

        public String Print()
        {
            String horario = this.hora + ":" + this.minuto + ":" + this.segundo;
            return horario;
        }
    }
}
