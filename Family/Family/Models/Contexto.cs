using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Eni> Enis { get; set; }

        public DbSet<Familia> Familias {get;set;}

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
       
    }
}
