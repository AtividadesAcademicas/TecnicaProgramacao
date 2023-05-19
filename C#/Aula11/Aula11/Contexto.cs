using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aula11
{
    public class Contexto:DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}