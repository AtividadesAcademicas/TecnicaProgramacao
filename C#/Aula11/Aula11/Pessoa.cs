using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula11
{
    public class Pessoa
    {
        [Key]
        public int Codigo { set; get; }
        public String Nome { set; get; }
        public String Email { set; get; }
    }
}