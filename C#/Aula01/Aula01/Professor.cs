using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Professor:Pessoa
    {
        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public Professor(String cpf, String nome, String titulo)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.Titulo = titulo;
        }
    }
}
