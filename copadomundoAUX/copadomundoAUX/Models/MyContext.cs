using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CopaDoMundo.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Selecao> Selecoes { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}