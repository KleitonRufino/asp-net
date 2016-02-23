using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Validacao.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
    }
}