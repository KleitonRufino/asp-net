﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Filtros.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}