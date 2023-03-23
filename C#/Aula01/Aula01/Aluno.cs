using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Aluno:Pessoa
    {
        private String rgm;

        public String RGM
        {
            get { return rgm; }
            set { rgm = value; }
        }

        public Aluno(String cpf, String nome, String rgm)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.RGM = rgm;
        }
    }
}
