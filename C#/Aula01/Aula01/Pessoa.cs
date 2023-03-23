using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Pessoa
    {
        private String cpf;

        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
